using System.Reflection.Metadata.Ecma335;

namespace ToDoApp.Models;

public sealed class User : Entity<long>
{

    public User()
    {
        
    }

    public User(string name, string surname, int age, string eMail, string password)
    {
        Name = name;
        Surname = surname;
        Age = age;
        EMail = eMail;
        Password = password;
    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string EMail { get; set; }
    public string Password { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Surname: {Surname}, Age: {Age}, E-Mail: {EMail}, Password: {Password}";

    }
}





    
