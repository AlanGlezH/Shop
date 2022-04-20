using Shop.Shared.Domain;

namespace Shop.User.Domain;
public class Name : StringValueObject
{
    public Name(string value) : base(value)
    {
    }
}