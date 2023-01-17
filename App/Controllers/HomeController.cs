using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App.Models;
using BLL;
using BOL;
namespace App.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
     Data d1=new Data();
     List<salgrade> lis = d1.getList();
     this.ViewData["lis"] =lis;
     
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }
    public IActionResult TrainerPage()
    {
        return View();
    }
    public IActionResult ErrorPage()
    {
        return View();
    }
    public IActionResult newPage()
    {
        return View();
    }
    public IActionResult Registration()
    {
        return View();
    }

    public IActionResult log(string uname,string pass)
    {
        if(uname == "niha" && pass == "soni")
        {
            return Redirect("/home/TrainerPage");
        }
        else{
            return Redirect("/home/ErrorPage");
        }
    }
    public IActionResult reg()
    {
        return Redirect("/home/newPage");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
