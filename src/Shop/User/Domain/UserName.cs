using Shop.Shared.Domain;

namespace Shop.User.Domain;

public class UserName : StringValueObject
{
    public UserName(string value) : base(value)
    {
    }
}