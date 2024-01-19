using book_store.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace book_store.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Login()
        {
            return View();

        }

    //    [HttpPost]
    //    public async Task<IActionResult> Login(string username, string password)
    //    {
    //        // Checking if username and password is empty or not
    //        if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
    //        {
    //            ViewBag.Message = "Empty value is not acceptable for even demo also :3";
    //            return View();
    //        }
    //        if (!IsValidUser(username, password))
    //        {
    //            ViewBag.Message = "Invalid username or password.";
    //            return View();
    //        }
    //        // Learn about Claims Principle -> https://docs.microsoft.com/en-us/dotnet/api/system.security.claims.claimsprincipal?view=netframework-4.8            

    //        // Here you can fetch your user information from the database
    //        // For this demo I am using demo identifier to authenticate
    //        var claims = new List<Claim>
    //{
    //new Claim(ClaimTypes.Name, username)
    //};
    //        // Learn more about ClaimsIdentity -> https://docs.microsoft.com/en-us/dotnet/api/system.security.claims.claimsidentity?view=netframework-4.8

    //        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

    //        // This is optional configuration
    //        var authProperties = new AuthenticationProperties
    //        {
    //            AllowRefresh = true,
    //            IsPersistent = true,
    //            ExpiresUtc = DateTime.UtcNow.AddMinutes(20)
    //        };
    //        await HttpContext.SignInAsync(
    //          CookieAuthenticationDefaults.AuthenticationScheme,
    //          new ClaimsPrincipal(claimsIdentity),
    //          authProperties
    //        );
    //        return RedirectToAction("Privacy");
    //    }
    //    [HttpPost]
    //    public async Task<IActionResult> Logout()
    //    {
    //        await HttpContext.SignOutAsync();
    //        return RedirectToAction("Index");
    //    }
    //    private bool IsValidUser(string username, string password)
    //    {
    //        // Replace this with your actual user authentication logic.
    //        // For demo purposes, I'm using a simple check.
    //        return username == "demo" && password == "password";
    //    }



    }
}
