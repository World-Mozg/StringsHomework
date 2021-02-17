using System;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //1
            /*
            string symbol = "";
            int numberOfSpaces = 0;
            while(symbol!=".")
            {
                symbol = Console.ReadLine();
                if (symbol == " ")
                    numberOfSpaces++;
            }
            Console.WriteLine($"Колличество введённых пробелов: {numberOfSpaces}");
            */



            //2 
            /*
            Console.Write("Введите номер трамвайного билета:");
            int ticketNumber = int.Parse(Console.ReadLine());
            int[] numbers = new int[6];
            for(int i=0;i<6;i++)
            {
                numbers[i] = ticketNumber % 10;
                ticketNumber = ticketNumber / 10;
            }
            if (numbers[0] + numbers[1] + numbers[2] == numbers[3] + numbers[4] + numbers[5])
            {
                Console.WriteLine("Билет счастливый");
            }
            else
                Console.WriteLine("Билет не счастливый");
            */





            //3    
            /*
            string text = Console.ReadLine();
            char[] letters = text.ToCharArray();
            for (int i=0;i<text.Length;i++)
            {
                if (letters[i]>=65 && letters[i]<=90)
                {
                    letters[i] = (char)(letters[i] + 32);
                }
                else if (letters[i]>=97 && letters[i]<=122)
                {
                    letters[i] = (char)(letters[i] - 32);
                }
            }
            text = Convert.ToString(letters);
            Console.WriteLine(letters);
            */







            //4
            /*
            Console.WriteLine("Введите число A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Число B должно быть больше числа A. ");
            Console.WriteLine("Введите число B: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            */






            //5
            /*
            Console.WriteLine("Введите число : ");
            int n = int.Parse(Console.ReadLine());
            string invertedNumber = "";
            while (n>0)
            {
                invertedNumber = $"{invertedNumber}{Convert.ToString(n % 10)}";
                n = n / 10;
            }
            n = int.Parse(invertedNumber);
            Console.WriteLine(n);
            */
        }
    }
}
