using YogaAlbano.Infrastructure;
using YogaAlbano.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/health", () => "YogaAlbano API is running")
.WithName("Health")
.WithOpenApi();

app.MapGet("/health/db", async (YogaAlbanoDbContext dbContext) =>
{
    try
    {
        return await dbContext.Database.CanConnectAsync()
            ? Results.Ok("Database connection is working")
            : Results.Problem(
                detail: "Database connection failed",
                statusCode: StatusCodes.Status503ServiceUnavailable);
    }
    catch
    {
        return Results.Problem(
            detail: "Database connection failed",
            statusCode: StatusCodes.Status503ServiceUnavailable);
    }
})
.WithName("DatabaseHealth")
.WithOpenApi();

app.Run();
