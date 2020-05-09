using System.Dynamic;

namespace DataAccessLayer
{
    public class User
    {

        public User(string name, string password, string role, int id)
        {
            Name = name;
            Password = password;
            Role = role;
            Id = id;
        }

        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int Id { get; set; }
    }
}