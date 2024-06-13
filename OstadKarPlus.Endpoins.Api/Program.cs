using Microsoft.EntityFrameworkCore;
using OstadKarPlus.Domain.Core.UsersAgg.Entities;
using OstadKarPlus.Infrastructure.DB.SqlServer.EFCore.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using OstadKarPlus.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

IConfiguration configuration = builder.Configuration;

string connectionString = configuration
 .GetConnectionString("SqlConnectionString") ?? throw new InvalidOperationException("Connection string 'SqlConnectionString' not found.");

builder.Services.AddDbContext<OstadKarPlusDBContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddIdentityCore<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<OstadKarPlusDBContext>()
    .AddDefaultTokenProviders();

// Adding Authentication
string jwtSecret = configuration["JWT:Secret"] ?? "";
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        //ValidateIssuer = true,
        //ValidateAudience = true,
        //ValidAudience = configuration["JWT:ValidAudience"],
        //ValidIssuer = configuration["JWT:ValidIssuer"],

        ValidateIssuer = false,
        ValidateAudience = false,

        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSecret))
    };
});

builder.Services.AddAuthorization();

//Add User Depedencies to DI
builder.Services.AddUsers();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
