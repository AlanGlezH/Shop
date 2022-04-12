public interface IUserRepository {
    Task<List<User>> GetUsers();
}