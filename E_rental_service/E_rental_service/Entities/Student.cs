namespace E_rental_service.Entities;
using E_rental_service.Enums;
public class Student: User
{
    //properties
    public int YearOfStudy {get; set;}
    
    //constructor
    public Student(string identifier, string firstName,
        string lastName, UserTypes type, int yearOfStudy) : base(identifier, firstName, lastName, type)
    {
        YearOfStudy = yearOfStudy;
    }
}