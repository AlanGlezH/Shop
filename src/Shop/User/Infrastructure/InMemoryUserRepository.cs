using System.Collections.Generic;
using System.Threading.Tasks;
using Shop.User.Domain;

namespace Shop.User.Infrastructure;

public class InMemoryUserRepository : UserRepository
{
    public InMemoryUserRepository()
    {

    }

    public async Task<List<ShopUser>> SearchAll()
    {
        var user = new ShopUser(

            new UserId("1"),
            new Name("Alan"),
            new LastName("Gonzalez"),
            new UserName("Username"),
            new Password("ssss")
        );

        return await Task.FromResult(new List<ShopUser>()
        {
            user
        });
    }
}
