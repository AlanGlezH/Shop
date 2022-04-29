using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.Hosting;

namespace Shop.Test.API;

public class ShopWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
{
    public ShopWebApplicationFactory()
    {
        SetUp();
    }

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureServices(services =>
        {

        });
    }

    private void SetUp()
    {
        var databaseCleaner = new DatabaseCleaner();
        databaseCleaner.SetUpDatabase();

    }
}