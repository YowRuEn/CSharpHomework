namespace Hanoi
{
    internal class Program
    {
        ///<summary>
        ///Hanoi解法
        ///</summary>
        public static void Move(int piles, char x, char y, char z)
        {
            if (piles == 1)
            {
                Console.WriteLine($"Piles number {piles} {x}-->{y}");
            }
            else
            {
                Move(piles - 1, x, z, y);
                Console.WriteLine($"Piles number {piles} {x}-->{y}");
                Move(piles - 1, z, y, x);
            }
        }
        static void Main(string[] args)
        {
            int piles = 0;
            Console.WriteLine("Please key in layer of Hanoi:");
            piles = int.Parse(Console.ReadLine());
            if (piles > 0)
            {
                Move(piles, 'x', 'y', 'z');
                Console.ReadKey();
                return;
            }
        }
    }
}