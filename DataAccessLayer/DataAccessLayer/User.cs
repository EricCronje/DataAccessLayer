using System;

namespace DataAccessLayer
{
    public abstract class User: IDisposable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public User(int id, string name, string password, string role)
        {
            Name = name;
            Id = id;
            Password = password;
            Role = role;
        }

        public void Dispose()
        {
            Name = null;
            Password = null;
            Role = null;
        }
    }
}