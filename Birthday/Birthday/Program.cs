namespace Birthday
{
    internal class Program
    {
        ///<summary>
        ///出生日期距离现在多少天
        ///</summary>
        static void Main(string[] args)
        {
            var birthday = new DateTime(2001, 06, 06);
            var day = DateTime.Today - birthday;
            Console.WriteLine("{0} day passed since my birthday");
        }
    }
}