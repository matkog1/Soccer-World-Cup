using SoccerDAL.Models;
using TestConsole;

public class UserFactory : IUserFactory, IUserRepositoryFactory
{
    public User CreateUser(string username, string password)
    {
        return new User { Username = username, Password = password };
    }

    public IUserRepository CreateUserRepository(string credentialsFile)
    {
        return new UserRepository(credentialsFile);
    }
}


