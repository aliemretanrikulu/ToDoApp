

using ToDoApp.Models;

namespace ToDoApp.Repository;

public interface IUserRepository : IRepository<User,long>
{
    List<User> GetAll();
    User GetById(int id);
    User Add(ToDo item);
    User Remove(int id);
}

}
