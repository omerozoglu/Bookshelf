using Bookshelf.API.Business.Containers.MicrosoftIoC;
using Bookshelf.API.DataAccess.Concrete.MongoDB.Context;
using Bookshelf.API.Entities.Concrete.Interfaces;
using Bookshelf.API.Middlewares;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDependencies();
builder.Services.Configure<Mongosettings>(options =>
{
    options.Connection = builder.Configuration["Mongosettings:Connection"];
    options.DatabaseName = builder.Configuration["Mongosettings:DatabaseName"];
});

builder.Services.AddSingleton<IMongoLogDBContext, MongoDBContext>();

builder.Services.AddCors(cors =>
{
    cors.AddPolicy("LocalHost", policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Custom middleware example.
app.UseCustomExtension();
// Status code page
app.UseStatusCodePages();

// Configure the HTTP request pipeline.
    app.UseSwagger();
    app.UseSwaggerUI();

app.UseCors("LocalHost");
app.UseAuthorization();

app.MapControllers();

app.Run();