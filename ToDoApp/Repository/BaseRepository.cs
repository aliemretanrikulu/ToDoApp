using System;
using ToDoApp.Models;

namespace TodoList2.Repository;

public class BaseRepository
{
    List<ToDo> todos = new List<ToDo>()
    {
        
        new ToDo()
        {
            
            Description = "Fizik Ödevi Yapılaak",
            EndDate = new DateTime(2024,10,10),
            StartDate = new DateTime(2024,9,26),
            isCompleted = false,
            Priority = "Çok Yüksek Öncelikli",
            Title = "Fizik Ödevi",
            UserId = 1
        }
    };

    List<User> users = new List<User>()
    {
        new User()
        {
            Id=1,
            Age= 25,
            EMail = "deneme@gmail.com",
            Name = "deneme",
            Surname = "Doğan",
            Password = "12345689"
        }
    };

    protected List<User> Users() { return users; }
    protected List<ToDo> Todos() { return todos; }
}