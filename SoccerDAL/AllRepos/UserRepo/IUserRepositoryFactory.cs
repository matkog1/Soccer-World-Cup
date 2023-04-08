public interface IUserRepositoryFactory
{
    IUserRepository CreateUserRepository(string credentialsFile);
}


