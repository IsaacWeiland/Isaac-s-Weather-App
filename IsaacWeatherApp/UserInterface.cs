namespace IsaacWeatherApp;

public class UserInterface
{
    public static void Run()
    {
        while (true)
        {

            Console.WriteLine("Welcome to Isaac's Weather App. Currently reading weather for:\n");
            OpenWeatherMapAPI.Where();
            Console.WriteLine("Please make a selection:");
            Console.WriteLine("[1] Current Temperature\n[2] High and low\n[3] Humidity\n[4] Exit the program");
            switch (UserInputParse())
            {
                case 1:
                    OpenWeatherMapAPI.Temperature();
                    Thread.Sleep(1500);
                    break;
                case 2:
                    OpenWeatherMapAPI.TempMinMax();
                    Thread.Sleep(1500);
                    break;
                case 3:
                    OpenWeatherMapAPI.Humidity();
                    Thread.Sleep(1500);
                    break;
                case 4:
                    Console.WriteLine("Thank you for using Isaac's Weather App.");
                    Environment.Exit(0);
                    break;
            }
            
        }
    }
    public static int UserInputParse()
    {
        var inputSuccess = int.TryParse(Console.ReadLine(), out int parseSucceed);
        while (!inputSuccess || parseSucceed > 4 || parseSucceed < 1)
        {
            Console.WriteLine("Please enter a number 1 - 4.");
            inputSuccess = int.TryParse(Console.ReadLine(), out parseSucceed);
        }
        return parseSucceed;
    }
}