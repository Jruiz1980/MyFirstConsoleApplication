// See https://aka.ms/new-console-template for more information

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your location?");
            var location = Console.ReadLine();
            var currentDate = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine($"{Environment.NewLine}Hello, my name is {name}. I am from {location}. The current date is {currentDate}");
            Console.WriteLine();

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("What is the width of the window?");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("What is the height of the window?");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine($"{Environment.NewLine} The length of the wood is {woodLength} feet");

            Console.WriteLine($"{Environment.NewLine} The area of the glass is {glassArea} square meters");     
            
            Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}