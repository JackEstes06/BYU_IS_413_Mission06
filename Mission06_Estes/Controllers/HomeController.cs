using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Estes.Models;

namespace Mission06_Estes.Controllers;

public class HomeController : Controller
{
    private MovieContext _context;

    // Ctor
    public HomeController(MovieContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult KnowJoel()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult Movies()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Movies(Movie response)
    {
        // Add record to database
        _context.Movies.Add(response);
        _context.SaveChanges();
        return View();
    }
    
    [HttpGet]
    public IActionResult MoviesList()
    {
        return View();
    }
}