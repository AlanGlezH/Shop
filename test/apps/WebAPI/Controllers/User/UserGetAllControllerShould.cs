using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Shop.Test.API;
using Shop.User.Domain;
using Xunit;

namespace WebAPI.Controllers.User
{
    public class UserGetAllControllerShould : ShopApplicationTextCase
    {
        public UserGetAllControllerShould(ShopWebApplicationFactory<Program> factory)
            : base(factory)
        {

        }

        [Fact]
        public async Task Get_all_users()
        {
            

            await AssertResponse(
                HttpMethod.Get,
                "/api/v1/users",
                200,
                "[{\"id\":\"1\",\"name\":\"Alan\",\"lastName\":\"Gonzalez\",\"userName\":\"Username\"}]");
        }
    }
}

