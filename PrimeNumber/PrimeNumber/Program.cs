namespace PrimeNumber
{
    internal class Program
    {
        ///<summary>
        ///找出最大的质数
        ///</summary>
        const int N = 10000;
        static void Main(string[] args)
        {
            int i = 2;
            int j = 1;
            int max = 0;
            //记录开始时间
            double rectionTime = 0;
            DateTime dateTimeStart = DateTime.Now;

            //正式开始查找10000以内最大的质数
            for (i = 2; i <= N; i++)
            {
                for (j = 2; j < i; j++)
                { if (i % j == 0) break; }
                if (j >= i) max = i;
            }
            //记录结束时间
            DateTime dateTimeEnd = DateTime.Now;
            //总耗时
            TimeSpan s = dateTimeEnd - dateTimeStart;
            rectionTime = s.TotalMilliseconds;
            Console.WriteLine($"Total {rectionTime} seconds");
            Console.WriteLine($"Max Prime Number under {N} is: {max}");
            Console.ReadKey();
        }
    }
}