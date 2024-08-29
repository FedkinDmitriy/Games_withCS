using System;

namespace GuessNumber_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Randomizer randomizer = new Randomizer(0,1000);
            randomizer.RegisterDelegats(UserInput,StringHandler);
            randomizer.LetsPlay();
        }

        static int UserInput()
        {
            int.TryParse(Console.ReadLine(), out int num);
            return num;
        }
        static void StringHandler(string input)
        {
            Console.WriteLine(input);
        }
    }
}
