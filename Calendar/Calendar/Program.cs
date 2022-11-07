namespace Calendar
{
    internal class Program
    {
        ///<summary>
        ///日历
        ///</summary>
        static void Main(string[] args)
        {
            //日历的长度为8，宽度为35
            const int monthWidth = 35;
            const int monthHeight = 8;
            int x = 0, y = 0;
            int theDayOfFirstDay = 0;
            int theDate = 0;
            DateTime atDay;
            for (atDay = new DateTime(2022,1,1); atDay.Year == 2022; atDay = atDay.AddDays(1))
            {
                //每月开始时作用一次
                if (atDay.Day == 1)
                {
                    //先输出月份
                    x = 6 + (atDay.Month - 1) % 3 * monthWidth;
                    y = ((atDay.Month - 1) / 3) * monthHeight;
                    Console.SetCursorPosition(x, y);
                    Console.Write("{0}", atDay.Month);
                    //在输出星期
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write("Sun Mon Tue Wed Thu Fri Sat");
                    //记录每月的第一天
                    theDayOfFirstDay = Convert.ToInt32(atDay.DayOfWeek);
                }
                //每天是星期几可以用x来表示出位置
                theDate = Convert.ToInt32(atDay.DayOfWeek);
                Console.SetCursorPosition(x + theDate * 4, y + 1 + ((theDayOfFirstDay + atDay.Day - 1) / 7 + 1));
                Console.Write(atDay.Day);
            }
        }
    }
}