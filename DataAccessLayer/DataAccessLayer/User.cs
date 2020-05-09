namespace DataAccessLayer
{
    public class User
    {
        public string name;
        public string password;
        public string role;
        public int id;

        public User(
            string name,
            string password,
            string role,
            int id)
        {
            this.name = name;
            this.password = password;
            this.role = role;
            this.id = id;
        }
    }
}