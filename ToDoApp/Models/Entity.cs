namespace ToDoApp.Models;

public abstract class Entity<TId>
{
    public int Id { get; set; }

    protected Entity()
    {

    }

    protected Entity(TId id) 
    {
        Id = Id;
    }

}
