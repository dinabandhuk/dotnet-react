namespace Movies.Domain.Entities;

public class Movie : BaseEntity
{
    public string title { get; set; }
    public string description { get; set; }
    public string category { get; set; }
}