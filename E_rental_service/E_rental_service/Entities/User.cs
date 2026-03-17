namespace E_rental_service.Entities;
using E_rental_service.Enums;
    
public abstract class User
{
    //properties
    public string Identifier {get; set;}
    public string FirstName { get; set; } 
    public string LastName { get; set; }
    public UserTypes Type { get; set; }
    
    //constructor
    public User(string identifier, string firstName,
        string lastName, UserTypes type)
    {
        Identifier = identifier;
        FirstName = firstName;
        LastName = lastName;
        Type = type;
    }
}