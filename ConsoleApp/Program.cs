using ConsoleApp;
using ConsoleApp.Contexts;
using ConsoleApp.Repositories;
using ConsoleApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>

{
    services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\projects\G.Assigment.EFC\ConsoleApp\Data\Database.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"));
   
    services.AddScoped<UserRepository>();
    services.AddScoped<RolesRepository>();
    services.AddScoped<ProfilesRepository>();
    services.AddScoped<LoansRepository>();
    services.AddScoped<BooksRepository>();

    services.AddScoped<UserService>();
    services.AddScoped<RolesService>();
    services.AddScoped<ProfilesService>();
    services.AddScoped<LoansService>();
    services.AddScoped<BookService>();

    services.AddSingleton<ConsoleUI>();

}).Build();


var consoleUI = builder.Services.GetRequiredService<ConsoleUI>();
consoleUI.CreateProfile_UI();


