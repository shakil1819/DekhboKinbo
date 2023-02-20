namespace DekhboKinbo.Models;

public class Actor_Movie
{
    public int MovieID { get; set; }
    public Movie Movie { get; set; }
    public int ActorID { get; set; }
    public Actor Actor { get; set; }
    
}