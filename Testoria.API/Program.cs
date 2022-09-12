using Testoria.Business.Configuration;
using Microsoft.EntityFrameworkCore;
using Testoria.API.Infrastructure;
using Testoria.API.Configuration;
using Testoria.Business.Services;
using Testoria.Data.Repositories;
using Testoria.Data;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
string _connectionStringVariableName = "ASP_NET";

builder.Services.AddControllers();

string connString = builder.Configuration.GetValue<string>(_connectionStringVariableName);

var connectionString = builder.Configuration.GetValue<string>(_connectionStringVariableName);
builder.Services.AddDbContext<TestoriaContext>(opt
    => opt.UseSqlServer(connectionString));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(config =>
{
    config.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        Description = "JWT Authorization header using the Bearer scheme."

    });
    config.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                          {
                              Reference = new OpenApiReference
                              {
                                  Type = ReferenceType.SecurityScheme,
                                  Id = "Bearer"
                              }
                          },
                         new string[] {}
                    }
                });

    config.EnableAnnotations();
});

builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
builder.Services.AddScoped<IQuestionService, QuestionService>();

builder.Services.AddAutoMapper(typeof(AutoMapperApi), typeof(AutoMapperData));


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.UseMiddleware<GlobalExceptionHandler>();

app.Run();