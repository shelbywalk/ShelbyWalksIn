namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер1:");
            Number1();
            Console.WriteLine("Номер2:");
            Number2();
            Console.ReadKey();
        }
        static void Number1()
        {
            Console.WriteLine("Счетчик:");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 18 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("цикл с постусловием:");
            int a = 0;
            do
            {
                a++;
                if (a % 20 == 0)
                {
                    Console.WriteLine(a);
                }
            }
            while (a <= 100);

            Console.WriteLine("цикл с предусловием:");
            int b = 0;
            while (b < 100)
            {
                b++;
                if (b % 18 == 0)
                {
                    Console.WriteLine(b);
                }
            }
            Console.ReadKey();
        }
        static void Number2()
        {
            int c = 0;
            for (int i = 0; i < 100; i++)
            {
                if (1 % 2 != 0)
                {
                    c += i;
                }
            }
            Console.WriteLine("Сумма нечетных чисел от 1 до 30=" + c);
        }
    }
}
