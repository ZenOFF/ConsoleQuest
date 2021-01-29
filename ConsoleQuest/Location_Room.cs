using System;

namespace ConsoleQuest
{
    internal class Location_Room : IBaseLocation
    {
      

        public void StartDialog()
        {
            Console.WriteLine("Вы находитесь в комнате...");
            Console.WriteLine("Варианты действий:");
            Console.WriteLine("1) Осмотреться");
            Console.WriteLine("2) Выйти ");
        }

        public void Variant(byte Option)
        {
            switch (Option)
            {
                case 1:
                    {
                        Console.WriteLine("Вы выбрали \"Осмотреться\" ");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("Вокруг ничего нет просто пустая комната");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Вы вырали \"Выйти\" ");
                        Location_Road RoadLoc = Location_Road.GetInstance();
                        Program.Location = RoadLoc;
                        Program.StartQuest(RoadLoc);
                        break;
                    }
            }
        }
    }
}