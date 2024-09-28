using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;
using ToDoApp.Repository;

namespace TodoList2.Repository
{
    public class TodoRepository : BaseRepository

    {
        public ToDo Add(ToDo item)
        {
            throw new NotImplementedException();
        }

        public List<ToDo> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<ToDo> GetAllByTitleContains(string title)
        {
            throw new NotImplementedException();
        }

        public ToDo? GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public ToDo Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}