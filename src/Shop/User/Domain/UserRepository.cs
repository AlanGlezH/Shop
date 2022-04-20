using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.User.Domain;

public interface UserRepository
{
    Task<List<ShopUser>> SearchAll();
}

