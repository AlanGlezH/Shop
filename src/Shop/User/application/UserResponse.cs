namespace Shop.User.Application;

public class UserResponse
{
    public string Id { get; }
    public string Name { get; }
    public string LastName { get; }
    public string UserName { get; }

    public UserResponse(string id, string userName, string name, string lastName)
    {
        this.Id = id;
        this.UserName = userName;
        this.Name = name;
        this.LastName = lastName;
    }
}