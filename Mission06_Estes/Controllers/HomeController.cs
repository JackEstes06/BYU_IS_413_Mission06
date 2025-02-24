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
    
    // MOVIES VIEW ACTIONS
    [HttpGet]
    public IActionResult Movies()
    {
        ViewBag.Categories = _context.Categories.ToList();
        return View(new Movie());
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
    
    // MOVIESLIST VIEW ACTIONS
    [HttpGet]
    public IActionResult MoviesList()
    {
        var movies = _context.Movies.ToList();
        Console.WriteLine(movies);
        
        return View(movies);
    }

    // EDIT ACTIONS -> UTILIZE MOVIES VIEW SUBMISSION
    [HttpGet]
    public IActionResult Edit(int id)
    {
        Movie movieToEdit = _context.Movies.Single(x => x.MovieId == id);
        
        ViewBag.Categories = _context.Categories.ToList();
        return View("Movies", movieToEdit);
    }

    [HttpPost]
    public IActionResult Edit(Movie movie)
    {
        _context.Update(movie);
        _context.SaveChanges();
        
        return RedirectToAction("MoviesList");
    }
    
    // DELETE VIEW ACTIONS
    [HttpGet]
    public IActionResult Delete(int id)
    {
        Movie movieToDelete = _context.Movies.Single(x => x.MovieId == id);
        
        return View(movieToDelete);
    }

    [HttpPost]
    public IActionResult Delete(Movie movie)
    {
        _context.Movies.Remove(movie);
        _context.SaveChanges();
        
        return RedirectToAction("MoviesList");
    }
}