using JustinaSimulator.Application.Interfaces;
using JustinaSimulator.Application.UseCases.MovePointer;
using JustinaSimulator.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();

// Domain/Application Services
builder.Services.AddScoped<MovePointerHandler>();

// Infrastructure Services
builder.Services.AddSingleton<ISimulationStateRepository, InMemorySimulationRepository>();

// Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseCors("AllowAll"); // Enable CORS in Development
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
