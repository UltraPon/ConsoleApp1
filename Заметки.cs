namespace D
{
    internal class Заметки
    {
        public static string FirstDate = Стрелочки.Date.ToShortDateString();
        public static void Notes()
        {
            switch (FirstDate)
            {
                case "15.11.2022":
                    Note1();
                    Note2();
                    break;
                case "20.11.2022":
                    Note3();
                    Note4();
                    break;
                case "25.11.2022":
                    Note5();
                    break;               
            }
        }
        public static void Note1()
        {
            Console.WriteLine("  Дота");
            if (Стрелочки.button.Key == ConsoleKey.Enter && Стрелочки.cursorpos == 3)
            {
                description1();
            }
        }
        public static void Note2()
        {
            Console.WriteLine("  C#");
            if (Стрелочки.button.Key == ConsoleKey.Enter && Стрелочки.cursorpos == 4)
            {
                description2();
            }
        }
        public static void Note3()
        {
            Console.WriteLine("  ААС");
            if (Стрелочки.button.Key == ConsoleKey.Enter && Стрелочки.cursorpos == 3)
            {
                description3();
            }
        }
        public static void Note4()
        {
            Console.WriteLine("  КС");
            if (Стрелочки.button.Key == ConsoleKey.Enter && Стрелочки.cursorpos == 4)
            {
                description4();
            }
        }
        public static void Note5()
        {
            Console.WriteLine("  Дискордик");
            if (Стрелочки.button.Key == ConsoleKey.Enter && Стрелочки.cursorpos == 3)
            {
                description5();
            }
        }
        public static void description1()
        {
            List <string> descr1 = new List <string> ();
            descr1.Add("  18:00\n  Поиграть в комп");
            Console.Clear();
            foreach (string i in descr1)
                Console.WriteLine(i);
            Стрелочки.button = Console.ReadKey();
            program.Main();
        }
        public static void description2()
        {
            List<string> descr2 = new List<string>();
            descr2.Add("  22:00\n  Сделать практическую по шарпу");
            Console.Clear();
            foreach (string i in descr2)
                Console.WriteLine(i);
            Стрелочки.button = Console.ReadKey();
            program.Main();
        }
        public static void description3()
        {
            List<string> descr3 = new List<string>();
            descr3.Add("  14:00\n  Выучить лекцию по ААС");
            Console.Clear();
            foreach (string i in descr3)
                Console.WriteLine(i);
            Стрелочки.button = Console.ReadKey();
            program.Main();
        }
        public static void description4()
        {
            List<string> descr4 = new List<string>();
            descr4.Add("  19:00\n  Выучить лекцию по КС");
            Console.Clear();
            foreach (string i in descr4)
                Console.WriteLine(i);
            Стрелочки.button = Console.ReadKey();
            program.Main();
        }
        public static void description5()
        {
            List<string> descr5 = new List<string>();
            descr5.Add("  20:00\n  Посидеть с кентиками в дискордике");
            Console.Clear();
            foreach (string i in descr5)
                Console.WriteLine(i);
            Стрелочки.button = Console.ReadKey();
            program.Main();
        }
    }
}
