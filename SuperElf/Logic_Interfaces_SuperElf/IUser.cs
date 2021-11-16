namespace Logic_Interfaces_SuperElf
{
    public interface IUser
    {
        int userId { get; }
        string userName { get; }
        string firstName { get; }
        string lastName { get; }
        string password { get; }
        string emailaddress { get; }
        bool isAdmin { get; }
        bool isModerator { get; }
    }
}