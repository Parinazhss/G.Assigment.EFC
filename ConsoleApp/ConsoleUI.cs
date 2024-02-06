

using ConsoleApp.Services;

namespace ConsoleApp;

internal class ConsoleUI
{
    private readonly ProfilesService _profilesService;

    public ConsoleUI(ProfilesService profilesService)
    {
        _profilesService = profilesService;
    }

    public void CreateProfile_UI()
    {
        Console.Clear();
        Console.WriteLine("----CREATE YOUR PROFILE----");

      
        Console.Write("First Name: ");
        var firstName = Console.ReadLine()!;

        Console.Write("Last Name: ");
        var lastName = Console.ReadLine()!;

        Console.Write("Address Street: ");
        var streetName = Console.ReadLine()!;

        Console.Write("City: ");
        var cityName = Console.ReadLine()!;

        Console.Write("Email: ");
        var email = Console.ReadLine()!;

        Console.Write("Password: ");
        var password = Console.ReadLine()!;

        var result =_profilesService.CreateProfile(firstName, lastName, cityName, email, streetName, password);
        if (result != null)
        {
            Console.Clear() ;
            Console.WriteLine("Profile Was Created");
            Console.ReadKey();

        }
    }
}
