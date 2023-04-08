using SoccerDAL.Models;

public interface IUserFactory
{
    User CreateUser(string username, string password);
}


