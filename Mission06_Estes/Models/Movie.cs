using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Mission06_Estes.Models;

public class Movie
{
    [Key]
    [Required]
    public int movieID { get; set; }
    
    [Required]
    public string movieTitle { get; set; }
    
    [Required]
    public string movieCategory { get; set; }
    
    [Required]
    public int movieYear { get; set; }
    
    [Required]
    public string movieDirector { get; set; }
    
    [Required]
    public string movieRating { get; set; }
    
    // Non-Required values for database
    // Default to type? (bool?, etc.) for dotnet ef migrations to set up database the same way
    public bool? movieEdited { get; set; }
    public string? movieLentTo { get; set; }
    public string? movieNotes { get; set; }
}