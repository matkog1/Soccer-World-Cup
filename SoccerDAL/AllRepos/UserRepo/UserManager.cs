using SoccerDAL.Models;

public class UserManager
{
    private readonly IUserRepository userRepository;
    private readonly IUserFactory userFactory;
    public UserManager(IUserRepositoryFactory userRepositoryFactory, IUserFactory userFactory)
    {
        string credentialsFile = "credentials.txt";
        userRepository = userRepositoryFactory.CreateUserRepository(credentialsFile);
        this.userFactory = userFactory;
    }

    public User RegisterUser(string username, string password)
    {

        User existingUser = userRepository.GetUserByUsername(username);
        if (existingUser != null)
        {
            // The user already exists, return null or throw an exception
            return null;
        }

        User newUser = userFactory.CreateUser(username, password);
        userRepository.AddUser(newUser);
        return newUser;
    }

    public User LoginUser(string username, string password)
    {
        User user = userRepository.GetUserByUsername(username);
        if (user != null && user.Password == password)
        {
            return user;
        }
        else
        {
            return null;
        }
    }
}


