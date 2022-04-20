using Shop.Shared.Domain;

namespace Shop.User.Domain;
public class Password : StringValueObject
{
    public Password(string value) : base(value)
    {
    }
}