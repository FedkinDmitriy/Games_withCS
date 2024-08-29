using System;

namespace GuessNumber_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Randomizer randomizer = new Randomizer(0,1000); //создаем экземпляр и вручную задаём диапазон для загаданного числа
            randomizer.RegisterDelegats(UserInput,StringHandler); // регистрируем делегаты
            randomizer.LetsPlay(); //запускаем игру
        }

        // два метода для работы с игрой: для ввода и для обработки сообщений о статусе игры
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
