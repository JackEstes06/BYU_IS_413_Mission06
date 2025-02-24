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
        ViewBag.Categories = _context.Categories.ToList();
        return View();
    }
    [HttpPost]
    public IActionResult Movies(Movie response)
    {
        if (ModelState.IsValid)
        {
            // Add record to database
            _context.Movies.Add(response);
            _context.SaveChanges();

            // ViewBag.Categories = _context.Categories.ToList();
            return View("Index");
        }
        else
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View(response);
        }
    }
    
    [HttpGet]
    public IActionResult MoviesList()
    {
        var movies = _context.Movies.ToList();
        Console.WriteLine(movies);
        
        return View(movies);
    }
}