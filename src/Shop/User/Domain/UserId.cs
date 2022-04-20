using Shop.Shared.Domain;

namespace Shop.User.Domain;
public class UserId : StringValueObject
{
    public UserId(string value) : base(value)
    {
    }
}