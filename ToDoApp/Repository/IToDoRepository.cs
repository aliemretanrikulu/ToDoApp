
using ToDoApp.Models;

namespace ToDoApp.Repository;

public interface IToDoRepository : IRepository<ToDo, Guid>
{
    List<ToDo> 
}
