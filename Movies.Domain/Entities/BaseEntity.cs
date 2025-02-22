namespace Movies.Domain.Entities;

public abstract class BaseEntity
{
    public int Id { get; set;}
    public DateTime createDate { get; set; }
}