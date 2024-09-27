﻿using System.Xml.Linq;

namespace ToDoApp.Models;

public class ToDo : Entity<Guid>
{

    public ToDo()
    {
        CreatedDate = DateTime.Now;
    }

    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public bool isCompleted { get; set; }
    public int UserId { get; set; }
    public string Priority { get; set; }
}



