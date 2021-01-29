using System;

namespace ConsoleQuest
{
    internal class Program
    {
        //стартовая локация

        public static IBaseLocation Location;

        private static void Main(string[] args)
        {
            //перывание CTRL+C
            Console.TreatControlCAsInput = true;
            ConsoleKeyInfo keyPressed;

            Location = new Location_Room();

            StartQuest(Location);
            do
            {
                keyPressed = Console.ReadKey();
                Console.WriteLine();
                
                byte UserVariant = ChosenVariant(keyPressed);
                LocationVariant(Location, UserVariant);
            }
            while (keyPressed.Key != ConsoleKey.Escape);
        }

        public static void StartQuest(IBaseLocation LocationClass)
        {
            LocationClass.StartDialog();
        }

        public static void LocationVariant(IBaseLocation LocationClass, byte keyPressed)
        {
            LocationClass.Variant(keyPressed);
        }

        private static byte ChosenVariant(ConsoleKeyInfo key)
        {
        
            switch (key.KeyChar.ToString())
            {
                case "1":
                    //Console.WriteLine("Case 1");
                    return 1;

                case "2":
                    //Console.WriteLine("Case 2");
                    return 2;
                case "0":
                    Console.WriteLine(Location.ToString());
                    return 0;
                default:
                    Console.WriteLine("Действие недоступно");
                    return 0;
            }
        }
    }
}