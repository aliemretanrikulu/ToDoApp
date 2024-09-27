

using ToDoApp.Models;

namespace ToDoApp.Repository;

public abstract class BaseRepository
{
    List<ToDo> todos = new List<ToDo>()
    {
        new ToDo()
        {
           Id = 1,
           CreatedDate = DateTime.Now,
           Description = "Fizik ödevi yapılacak",
           EndDate = new DateTime(2024,10,10),
           StartDate = new DateTime(2024,9,26),
           isCompleted = false,
           Priority = "Çok yüksek öncelikli",
           UserId = 1,
        }
    };

    List<User> user = new List<User>()
    {
        new User()
        {
            Id = 1,
            Age = 25,
            EMail = "deneme@gmail.com",
            Name = "deneme",
            Surname = "denemed",
            Password = "123456"

        }

    };
