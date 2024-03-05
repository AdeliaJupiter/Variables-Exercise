namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize variables
            string myName = "Adelia";
            int myAge = 29;
            char middleInitial = 'A';
            bool isAlive = true;
            double currentTemp = 63;
            decimal currentPrice = 91352.95m;

            //Interpolate variables in a Console.Writeline()
            Console.WriteLine($"Name: {myName}");
            Console.WriteLine($"Age: {myAge}");
            Console.WriteLine($"Middle Initial: {middleInitial}");
            Console.WriteLine($"Is Alive: {isAlive}");
            Console.WriteLine($"Current Temp: {currentTemp}");
            Console.WriteLine($"Current Price: {currentPrice}");
        }
    }
}
