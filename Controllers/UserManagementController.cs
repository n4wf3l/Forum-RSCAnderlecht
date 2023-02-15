using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RSCAnderlechtF.Models;
using System.Runtime.Intrinsics.X86;
using System.Security;

namespace RSCAnderlechtF.Controllers
{
    public class UserManagementController : Controller
    {
        public IActionResult Index()
        {
            using (var _context = new aspnetRSCAnderlechtF3E7AE6293255424A9837121B340A5182Context())
            {
                var allUsers = _context.AspNetUsers.ToList();

                if (allUsers == null)
                {
                    return NoContent();
                }

                return View("Index", allUsers);

            }
        }


        [HttpPost]
        [AllowAnonymous]
        public IActionResult CreateUser(AspNetUser user)
        {
            using (var _context = new aspnetRSCAnderlechtF3E7AE6293255424A9837121B340A5182Context())
            {

                var passwordHasher = new PasswordHasher<AspNetUser>();
                user.Id = Guid.NewGuid().ToString();
                user.EmailConfirmed = true;
                user.UserName = user.Email;
                user.NormalizedEmail = user.Email;
                user.NormalizedUserName = user.Email;
                user.SecurityStamp = Guid.NewGuid().ToString();
                user.PasswordHash = passwordHasher.HashPassword(user, user.PasswordHash);
                _context.AspNetUsers.Add(user);

                try
                {
                    _context.SaveChanges();

                    _context.AspNetUserRoles.Add(new AspNetUserRole
                    {
                        UserId = user.Id,
                        RoleId = user.ConcurrencyStamp
                    });
                    _context.SaveChanges();

                    return View("Index", _context.AspNetUsers.ToList());

                }
                catch (Exception e)
                {
                    return new BadRequestObjectResult(e);
                }
            }
        }




        [HttpPost]
        [AllowAnonymous]
        public IActionResult UpdateUser(AspNetUser user)
        {
            if (user == null) return BadRequest();

            using (var _context = new aspnetRSCAnderlechtF3E7AE6293255424A9837121B340A5182Context())
            {
                var passwordHasher = new PasswordHasher<AspNetUser>();

                var userObj = _context.AspNetUsers.Where(u => u.Id == user.Id).FirstOrDefault();
                userObj.EmailConfirmed = true;
                userObj.UserName = user.Email;
                userObj.NormalizedEmail = user.Email;
                userObj.Email = user.Email;
                userObj.NormalizedUserName = user.Email;
                userObj.SecurityStamp = Guid.NewGuid().ToString();
                userObj.PasswordHash = passwordHasher.HashPassword(user, user.PasswordHash);

                _context.SaveChanges();

                var userRoleObj = _context.AspNetUserRoles.Where(ur => ur.UserId == user.Id).FirstOrDefault();
                if (userRoleObj != null)
                {
                    userRoleObj.RoleId = user.ConcurrencyStamp;

                    _context.SaveChanges();
                }

                return Index();
            }
        }

                [HttpPost]
        public IActionResult DeleteUser(string userId)
        {
            using (var _context = new aspnetRSCAnderlechtF3E7AE6293255424A9837121B340A5182Context())
            {
                var userToDel = _context.AspNetUsers.Where(p => p.Id == userId).FirstOrDefault();

                if (userToDel != null)
                {
                    var userPosts = _context.Posts.Where(p => p.UserId == userToDel.Id).ToList();
                    var userCommnets = _context.Comments.Where(c => c.UserId == userToDel.Id).ToList();

                    if (userCommnets.Any())
                    {
                        _context.Comments.RemoveRange(userCommnets);
                        _context.SaveChanges();
                    } 

                    if (userPosts.Any())
                    {
                        _context.Posts.RemoveRange(userPosts);
                        _context.SaveChanges();
                    }

                    var userRole = _context.AspNetUserRoles.Where(r => r.UserId == userToDel.Id).First();

                    _context.AspNetUserRoles.Remove(userRole);
                    _context.SaveChanges();

                    _context.AspNetUsers.Remove(userToDel);
                    _context.SaveChanges();
                    return View("Index", _context.AspNetUsers.ToList());
                }
            }
            return NotFound();
        }

    }
}
