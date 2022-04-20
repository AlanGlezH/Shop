namespace Shop.User.Application;
public class UsersResponse
{
    public IEnumerable<UserResponse> Users;
    public UsersResponse(IEnumerable<UserResponse> users)
    {
        this.Users = users;
    }
}