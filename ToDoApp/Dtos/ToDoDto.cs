

namespace ToDoApp.Dtos;

public record ToDoDto (
    
    int Id,
    int UserId,
    string Title,
    string Description,
    DateTime CreatedDate,
    string StartDate,
    string EndDate,
    bool isCompleted,
    string Priority
    );
