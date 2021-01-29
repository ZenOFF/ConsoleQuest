using System;

namespace ConsoleQuest
{
    internal class Location_Road : IBaseLocation
    {
        private bool First_dialog = true;

        private Location_Road() { }

        private static Location_Road _instance;
        //синглтон для сохранения всех действий 
        public static Location_Road GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Location_Road();
            }
            return _instance;
        }
        public void StartDialog()
        {
            Console.WriteLine("Вы стоите на дороге...");
            Console.WriteLine("Варианты действий:");
            Console.WriteLine("1) Осмотреть окрестности");
            Console.WriteLine("2) Поговорить с бродягой ");
        }

        public void Variant(byte Option)
        {
            switch (Option)
            {
                case 1:
                    {
                        Console.WriteLine("Вы выбрали \"Осмотреть окрестности\" ");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("Вы видите ДОМ из которго вы вышли, неподолёку от вас стоит бродяга");

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Вы вырали \"Поговорить с бродягой\" ");

                        if (First_dialog)
                        {
                            Console.WriteLine("Он что-то бормочит под нос ");
                            Console.WriteLine("и вручает вам медальон и 50 монет");
                            First_dialog = false;
                        }
                        else
                        {
                            Console.WriteLine("Бродяга молчит и никак на вас не реагирует");
                        }

                        break;
                    }
            }
        }

        public void NewOptions()
        {
            Console.WriteLine("Вы стоите на дорое...");
            Console.WriteLine("Варианты действий:");
            Console.WriteLine("1) Осмотреть окрестности");
            Console.WriteLine("2) Поговорить с бродягой ");
        }
    }
}