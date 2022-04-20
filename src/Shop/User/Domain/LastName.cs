using Shop.Shared.Domain;

namespace Shop.User.Domain;
public class LastName : StringValueObject
{
    public LastName(string value) : base(value)
    {
    }
}