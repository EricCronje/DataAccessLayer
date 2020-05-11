namespace DataAccessLayer
{
    internal interface IUser
    {
        User GetUser(int id);
        bool AuthorizeUser(string userName, string password);
    }
}