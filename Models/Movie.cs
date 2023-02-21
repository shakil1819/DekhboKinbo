using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;
using DekhboKinbo.Data;

namespace DekhboKinbo.Models;

public class Movie
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string ImageURL { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public MovieCategory MovieCategory { get; set; }
    
    //relationship
    public List<Actor_Movie> Actor_Movies { get; set; }
    
    //cinema
    public int CinemaID { get; set; }
    [ForeignKey("CinemaID")] 
    public Cinema Cinema { get; set; }
    
    //producer
    public int ProducerID { get; set; }
    [ForeignKey("ProducerID")] 
    public Producer Producer { get; set; }
}