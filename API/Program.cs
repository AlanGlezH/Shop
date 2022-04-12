using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using Shop.API.Swagger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
    // Reporting api versions will return headers "api-supported-version"
    // And "api-deprecated-versions"
    options.ReportApiVersions = true;
    //Only versions [ApiController] defaults to 
    options.UseApiBehavior = true;

});

builder.Services.AddVersionedApiExplorer(setup =>
   {
       setup.GroupNameFormat = "'v'VVV";
       setup.SubstituteApiVersionInUrl = true;
   });




builder.Services.AddSwaggerGen(options =>
{
    options.EnableAnnotations();
    options.OperationFilter<SwaggerDefaultValues>();
    // integrate xml comments


});

builder.Services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();


var app = builder.Build();

var versionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(
        options =>
        {
            foreach (var apiDescription in versionProvider.ApiVersionDescriptions)
            {
                options.SwaggerEndpoint($"/swagger/{apiDescription.GroupName}/swagger.json",
                    apiDescription.GroupName.ToUpperInvariant());
            }
        });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
