using System.Runtime.InteropServices.JavaScript;
using DekhboKinbo.Data;

namespace DekhboKinbo.Models;

public class Movie
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string ImageURL { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public MovieCategory MovieCategory { get; set; }
}