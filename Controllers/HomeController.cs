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

        public IActionResult Index()
        {
            SetCookie();
            ViewData["cookie-value"] = GetCookieValue();
            return View(GetAllPosts());
        }

        private void SetCookie()
        {
            Response.Cookies.Append("MyCookie", "cookie-value",
            new CookieOptions { Expires = DateTime.Now.AddDays(1) });
        }

        private string GetCookieValue()
        {
            string cookieValue;
            if (Request.Cookies.TryGetValue("cookie-name", out cookieValue))
            {
                return cookieValue;
            }
            return string.Empty;
        }

        private List<Post> GetAllPosts()
        {
            using (var _context = new aspnetRSCAnderlechtF3E7AE6293255424A9837121B340A5182Context())
            {
                return _context.Posts.Select(p => new Post
                {
                    Content = p.Content,
                    User = p.User,
                    CreateAt = p.CreateAt,
                    Id = p.Id,
                    Comments = p.Comments,
                }).ToList();
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