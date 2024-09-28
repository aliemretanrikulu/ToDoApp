

namespace ToDoApp.Dtos;

public record ToDoDto (
    
    int Id,
    int UserId,
    string Title,
    string Description,
    DateTime CreatedDate,
    DateTime StartDate,
    DateTime EndDate,
    bool isCompleted,
    string Priority
    );
