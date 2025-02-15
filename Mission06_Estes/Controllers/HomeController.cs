using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Estes.Models;

namespace Mission06_Estes.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MovieContext _context;

    // Ctor
    public HomeController(ILogger<HomeController> logger, MovieContext context)
    {
        _logger = logger;
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
}