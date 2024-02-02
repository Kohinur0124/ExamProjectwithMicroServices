using Microsoft.IdentityModel.Tokens;
using System.Text;
using YandexEats.Application;
using YandexEats.Application.BackgraundServices;
using YandexEats.Infrastructure;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddMemoryCache();
builder.Services.AddHostedService<BackgraundServices>();

builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "redis,6379";

});


builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = "Issuer",
            ValidateAudience = true,
            ValidAudience = "Audience",
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("mana-shu-security-key"))
        };
    });



var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();


//app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
