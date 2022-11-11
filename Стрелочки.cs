namespace D
{
    internal class Стрелочки
    {
        public static DateTime Date = DateTime.Now;
        public static ConsoleKeyInfo button = Console.ReadKey();
        public static int cursorpos = 3;
        public static void Cursor()
        {         
            int minpos = 2;
            while (true)
            {
                if (button.Key == ConsoleKey.UpArrow)
                {
                    cursorpos--;
                    if (cursorpos == minpos)
                    {
                        cursorpos++;
                        Console.SetCursorPosition(0, cursorpos);
                    }
                }
                if (button.Key == ConsoleKey.DownArrow)
                {
                    cursorpos++;
                }
                Console.Clear();
                Console.WriteLine(Date.ToShortDateString());
                Console.WriteLine("------------------------------");
                Console.WriteLine("Выберите заметку: ");
                Заметки.Notes();
                Console.SetCursorPosition(0, cursorpos);
                Console.WriteLine("->");
                button = Console.ReadKey();
                if (button.Key == ConsoleKey.LeftArrow)
                    Даты_туда_сюда.Даты_сюда();
                if (button.Key == ConsoleKey.RightArrow)
                    Даты_туда_сюда.Даты_туда();
            }
        }
    }
}
