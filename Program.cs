using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentProject.DataAccess;
using StudentProject.DataAccess.Interface;
using StudentProject.DataAccess.Repository;
using StudentProject.IdentityProvider.IdentityConfiguration;
using StudentProject.IdentityProvider.Model;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("MyConnection");
// Add services to the container.

builder.Services.AddScoped<IStudentRepository,StudentRepository>();

builder.Services.AddDbContext<StudentDbContext>(DbContextOptionsBuilder =>
{
    DbContextOptionsBuilder.UseSqlServer(connectionString);
    DbContextOptionsBuilder.UseLazyLoadingProxies(false);
});

builder.Services.AddIdentity<User, Role>(options =>
{
    AccountLockPolicy.Configue(options);
    PasswordPolicy.Configure(options);
    UserDetailPolicy.Configure(options);
    SignInPolicy.Configure(options);
}).AddEntityFrameworkStores<StudentDbContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
