namespace Лабораторная_работа__2
{
    class Program
    {
        static void Main(string[] args)
        //zadanie 1
        {
            int number;
            while (true)
            {
                {
                    Console.WriteLine("Введите число от 1 до 7");
                    bool isNumber = false;
                    isNumber = int.TryParse(Console.ReadLine(), out number);
                    if (isNumber == true)
                    {
                        if (number > 0 && number < 8)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Введенное число не в диапазоне");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Число не выбрано");
                    }

                }
            }
            string day = "";
            switch (number)
            {
                case 1:
                    Console.WriteLine("понедельник");
                    break;
                case 2:
                    Console.WriteLine("вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
            }
            Console.WriteLine(day);

            //zadanie 2

            Console.WriteLine("Введите число");
            int num = 15;
            if ((num % 3 == 0) && (num % 5 == 0))
            {
                Console.WriteLine("BuzzFizz");
            }
            else if (num % 3 == 1) 
            {
                Console.WriteLine("Buzz");
            }
            else if (num % 5 == 1) 
            {
                Console.WriteLine("Fizz");
            }

            //zadanie 3

            Console.WriteLine();
            int a1 = Console.Read();
            int b2 = Console.Read();
            int c3 = Convert.ToInt32(Console.ReadLine());
            if (c3 == '+')
            {
                Console.WriteLine(a1 + b2);
            }
            if (c3 == '-')
            {
                Console.WriteLine(a1 - b2);
            }
            if (c3 == '*')
            {
                Console.WriteLine(a1 * b2);
            }
            if (c3 == '%')
            {
                Console.WriteLine(a1 % b2);
            }
            
         
        }
    }
}

