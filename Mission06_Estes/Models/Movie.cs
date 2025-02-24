using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Mission06_Estes.Models;

public class Movie
{
    private static readonly int CurrentYear = DateTime.Today.Year;
    
    [Key]
    [Required]
    public int MovieId { get; set; }
    
    [ForeignKey("CategoryId")]
    [Required]
    public int CategoryId { get; set; }
    public Category category { get; set; }
        
    [Required]
    public string Title { get; set; }

    [Required]
    [Range(1888, int.MaxValue, ErrorMessage = $"You must enter a year between 1888 and the {nameof(CurrentYear)}")]
    public int Year { get; set; } = 1888;
    
    [Required]
    public string Rating { get; set; }
    
    [Required]
    public int CopiedToPlex { get; set; } = 0;
    
    // Non-Required values for database
    // Default to type? (bool?, etc.) for dotnet ef migrations to set up database the with nullable fields
    public string? Director { get; set; }
    public int? Edited { get; set; }
    public string? LentTo { get; set; }
    public string? Notes { get; set; }
}