namespace DataAccessLayer
{
    internal class SalesUser : User
    {
        public SalesUser(int id, string name, string password, string role) : base(id, name, password, role)
        {
        }
    }
}