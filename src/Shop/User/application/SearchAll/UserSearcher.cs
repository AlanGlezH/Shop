using Shop.User.Domain;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.User.Application.SearchAll;

public class UserSearcher
{
    private UserRepository userRepository;
    public UserSearcher(UserRepository userRepository)
    {
        this.userRepository = userRepository;
    }

    public async Task<UsersResponse> Search()
    {
        var users = await userRepository.SearchAll();
        Console.WriteLine(users.FirstOrDefault().Name.Value);
        return new UsersResponse(users
                .Select(user =>
                    new UserResponse(
                        user.Id.Value,
                        user.UserName.Value,
                        user.Name.Value,
                        user.LastName.Value
                    )
                )
            );
    }

}