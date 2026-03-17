namespace E_rental_service.Entities;
using E_rental_service.Enums;
public class Teacher : User
{
    //properties
    public double PopularityRating 
    {
        get {return PopularityRating;}
        set 
        {
            if (value < 0 || value > 5)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "PopularityRating must be in range from 0 to 5.");
            }
            PopularityRating = value;
        }
    }
    
    //constructor
    public Teacher(string identifier, string firstName,
        string lastName, UserTypes type, double popularityRating) : base(identifier, firstName, lastName, type)
    {
        PopularityRating = popularityRating;
    }
    
}