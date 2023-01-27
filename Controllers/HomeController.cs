using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RSCAnderlechtF.Models;
using System.Diagnostics;

namespace RSCAnderlechtF.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            using(var _context = new aspnetRSCAnderlechtF3E7AE6293255424A9837121B340A5182Context())
            {
                var allPosts = _context.Posts.Select(p => new Post
                {
                    Content = p.Content,
                    User = p.User,
                    CreateAt = p.CreateAt,
                    Id = p.Id,
                    Comments = p.Comments,
                }).ToList();
                return View(allPosts);
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