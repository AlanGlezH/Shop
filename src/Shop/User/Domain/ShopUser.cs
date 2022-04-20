namespace Shop.User.Domain;

public class ShopUser
{
    public UserId Id { get; }
    public Name Name { get; }
    public LastName LastName { get; }
    public UserName UserName { get; }
    public Password Password { get; }
    public ShopUser(
        UserId id,
        Name name,
        LastName lastName,
        UserName userName,
        Password password)
    {
        this.Id = id;
        this.Name = name;
        this.LastName = lastName;
        this.UserName = userName;
        this.Password = password;
    }
}