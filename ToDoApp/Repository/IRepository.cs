

using ToDoApp.Models;

namespace ToDoApp.Repository;

public interface IRepository<TEntity, TId>
    where TEntity : Entity<TId>, new()
{
    List<TEntity> GetAll();
    ToDo GetById(TId id);
    ToDo Add(TEntity item);
    ToDo Remove(TId id);
}

