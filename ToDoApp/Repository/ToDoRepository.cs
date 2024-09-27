
using ToDoApp.Models;

namespace ToDoApp.Repository;

public sealed class ToDoRepository : BaseRepository, IToDoRepository
{
    public ToDo Add(ToDo item)
    {
        throw new NotImplementedException();
    }

    public List<ToDo> GetAll()
    {
        throw new NotImplementedException();
    }

    public ToDo GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public ToDo Remove(Guid id)
    {
        throw new NotImplementedException();
    }
}

