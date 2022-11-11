namespace D
{
    internal class Даты_туда_сюда
    {
        public static void Даты_сюда()
        {
           if (Стрелочки.button.Key == ConsoleKey.LeftArrow)
           {
                Стрелочки.Date = Стрелочки.Date.AddDays(-1);
                Заметки.FirstDate = Стрелочки.Date.ToShortDateString();
                program.Main();
           }
        }
        public static void Даты_туда()
        {
            if (Стрелочки.button.Key == ConsoleKey.RightArrow)
            {
                Стрелочки.Date = Стрелочки.Date.AddDays(1);
                Заметки.FirstDate = Стрелочки.Date.ToShortDateString();
                program.Main();
            }
        }
    }
}
