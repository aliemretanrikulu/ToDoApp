using ToDoApp.Models;
using ToDoApp.Repository;

namespace TodoList2.Repository;

public interface IUserRepository : IRepository<User, long>
{

}