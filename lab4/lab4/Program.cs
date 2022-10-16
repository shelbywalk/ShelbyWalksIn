namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Number1();
            Number2();
            Number3();

        }
        static void Number1()
        {
            Console.WriteLine("Номер1:");
            int[] mass = new int[10];
            Random random = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(0, 100);
                Console.WriteLine("\t" + mass[i]);
            }
        }
        static void Number2()
        {
            Console.WriteLine("Номер2:");
            string str = "awd 23 f 4 rg3 3";
            string[] strArr = str.Split(' ');
            foreach (string el in strArr)
            {
                Console.WriteLine(el);
            }
        }
        static void Number3()
        {
                Console.WriteLine("Номер3:");
                int[] a = new int[] { 1, 2, 4, 5, 13, 15, 23, 3, 7, 8, 67 };
                int temp = 0;
            for (int b = 0; b < a.Length - 1; b++)
            {
                for (int c = 0; c < a.Length - 1; c++)
                {
                    if (a[c] > a[c + 1])
                    {
                        temp = a[c + 1];
                        a[c + 1] = a[c];
                        a[c] = temp;
                    }
                }
                Console.WriteLine("{0}", a[b]);
                }
        }
    }
}
