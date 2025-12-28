using LearningPlatform.Application.Abstractions.Repositories;
using LearningPlatform.Application.Abstractions.Repositories.UserRepos;
using LearningPlatform.Infrastructure.Persistence;
using LearningPlatform.Infrastructure.Persistence.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// MediatR
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(
        typeof(LearningPlatform.Application.Features.Users.Commands.CreateUser.CreateUserCommand).Assembly);
});

// DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Repository
builder.Services.AddScoped<IUserRepository, UserRepository>();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.Run();
