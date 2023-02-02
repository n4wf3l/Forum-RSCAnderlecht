using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RSCAnderlechtF.Models;
using System.Diagnostics;

namespace RSCAnderlechtF.Controllers
{
    [Authorize]
    public class PostManagementController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public PostManagementController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        public IActionResult CreatePost(Post post)
        {
            using (var _context = new aspnetRSCAnderlechtF3E7AE6293255424A9837121B340A5182Context())
            {
                var currentUser = _context.AspNetUsers.Where(u => u.Email == User.Identity.Name).FirstOrDefault();

                if (currentUser == null)
                {
                    return NoContent();
                }

                post.CreateAt = DateTime.Now;
                post.UserId = currentUser.Id;
                _context.Posts.Add(post);

                try
                {
                    _context.SaveChanges();
                    return View("MyPosts", _context.Posts.Where(u => u.UserId == currentUser.Id).ToList() );

                }
                catch (Exception e)
                {
                    return new BadRequestObjectResult(e);
                }
            }
        }

        [AllowAnonymous]
        public IActionResult MyPosts()
        {
            using (var _context = new aspnetRSCAnderlechtF3E7AE6293255424A9837121B340A5182Context())
            {
                var currentUser = _context.AspNetUsers.Where(u => u.Email == User.Identity.Name).FirstOrDefault();

                if (currentUser == null)
                {
                    return NoContent();
                }
                var myAllPosts = _context.Posts.Where(p => p.UserId == currentUser.Id).ToList();
                return View("MyPosts", myAllPosts);

            }
        }

        [HttpPost]
        public IActionResult DeletePost(int postId)
        {
            using (var _context = new aspnetRSCAnderlechtF3E7AE6293255424A9837121B340A5182Context())
            {
                var postToDel = _context.Posts.Where(p => p.Id == postId).FirstOrDefault();

                if (postToDel != null)
                {
                    _context.Posts.Remove(postToDel);
                    _context.SaveChanges();
                    return View("MyPosts", _context.Posts.ToList());
                }
            }
            return NotFound();
        }

        [AllowAnonymous]
        public IActionResult PostDetails(int postId)
        {
            using (var _context = new aspnetRSCAnderlechtF3E7AE6293255424A9837121B340A5182Context())
            {
                var postData = _context.Posts.Where(p => p.Id == postId)
                    .Select(p => new Post
                    {
                        Content = p.Content,
                        User = p.User,
                        CreateAt = p.CreateAt,
                        Id = p.Id,
                        Comments = p.Comments,
                    }).FirstOrDefault();

                return View(postData);
            }

        }

        [HttpPost]
        public IActionResult CreateComment(Comment comment)
        {
            using (var _context = new aspnetRSCAnderlechtF3E7AE6293255424A9837121B340A5182Context())
            {
                var currentUser = _context.AspNetUsers.Where(u => u.Email == User.Identity.Name).FirstOrDefault();

                if (currentUser == null)
                {
                    return NoContent();
                }

                comment.PostId = comment.Id;
                comment.Id = 0;
                comment.CreatedAt = DateTime.Now;
                comment.UserId = currentUser.Id;

                _context.Comments.Add(comment);

                try
                {
                    _context.SaveChanges();
                    return View("PostDetails", _context.Posts.Where(p => p.Id == comment.PostId).Select(p => new Post
                    {
                        Content = p.Content,
                        User = p.User,
                        CreateAt = p.CreateAt,
                        Id = p.Id,
                        Comments = p.Comments,
                    }).FirstOrDefault());

                }
                catch(Exception e)
                {
                    return NotFound();
                }
            }
        }

        [HttpPost]
        public IActionResult SearchPost(string keyword)
        {
            using(var _context = new aspnetRSCAnderlechtF3E7AE6293255424A9837121B340A5182Context())
            {
                var searchResult = _context.Posts.Where(p => p.Content.Contains(keyword)).Select(p => new Post
                {
                    Content = p.Content,
                    User = p.User,
                    CreateAt = p.CreateAt,
                    Id = p.Id,
                    Comments = p.Comments,
                }).ToList();

                return View("SearchResult" , searchResult);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
