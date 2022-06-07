namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}

// What is Entity Framework?
// Entity Framework is a .NET ORM (Object Relational Mapping) library 
// allows you to map your object-oriented data model to a relational database.
// translate our code into SQL commands and execute them against a relational database.

