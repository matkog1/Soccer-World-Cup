using SoccerDAL.Models;

public interface IUserRepository
{
    void AddUser(User user);
    User GetUserByUsername(string username);
}


