using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System;
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

    public IActionResult Index(){
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

    public IActionResult reg(string idn,string name,string address,string datej)
    {
        var int1 = Int16.Parse(idn);
        TrainerD trainer = new TrainerD{
            id=int1,
            name = name,
            address = address,
            doj = datej
        };
        Data data = new Data();
        bool status = data.insert(trainer);

        if(status){
            return Redirect("/home/newPage");
        }
        else{
             return Redirect("/home/ErrorPage");
        }
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
