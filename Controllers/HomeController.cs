using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Host;
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

        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)), new CookieOptions()
            {
                Expires = DateTimeOffset.UtcNow.AddYears(1)
            });
            return Redirect(Request.Headers["Referer"].ToString());
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Home");
            }

            return View();
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Home");
            }

            return View();
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

        [Authorize]
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

        [AllowAnonymous]
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