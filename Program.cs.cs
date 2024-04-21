using System;

namespace HomeTask19
{
    internal class Program
    {
        private static bool boolean;

        static void Main(string[] args)
        {

            #region Task 1: Verilmiş N tam ədədinin rəqəmləri cəmini tapan metod.
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ededin reqemleri cemi " + showSumOfTheDigits(number));
            #endregion

            #region Task 2: Verilmiş M dəyərindən verilmiş N dəyərinədək 21-ə bölünən ədədlərin ədədi ortasını tapan metod.
            Console.WriteLine("Please enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if ((averDigits(num1, num2))  == 0)
            {
                Console.WriteLine("Bu araliqda 21 e bolunen eded yoxdur");
            }
            else
            {
                Console.WriteLine($"21 e bolunen ededlerin ededi ortasi: {averDigits(num1, num2)}");
            }

            #endregion


            #region: Task 2 other
            Console.WriteLine("Please enter the first number");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int numb2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"21 e bolunen ededlerin ededi ortasi: {sumDigit(numb1, numb2)}");
            #endregion


            #region Task 3: Verilmis yazıda a herfi olub olmadigini tapan metod.
            Console.WriteLine("Please enter a word");
            string wordStr = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Bu yazida a herfi: " + wordLetter(wordStr));
            
          
            #endregion
        }

        static int showSumOfTheDigits(int number)
        {
            int sum = 0;
            int digit = 0;
            while (number > 0)
            {
                digit = number % 10;
                number /= 10;
                sum += digit;
            }
            return sum;
        }

        static double averDigits(int n, int m)
        {
            int sum = 0;
            double count = 0;
            if (n < m)
            {
                for (int i = n; i < m; i++)
                {
                    if (i % 21 == 0)
                    {
                        count++;
                        sum += i;
                    }
                }
            }
            return sum / count;
        }

        static bool wordLetter(string wordStr)
        {
            bool polo = false;
            for (int i = 0; i < wordStr.Length; i++)
            {
                if (wordStr[i] == 'a')
                {
                    polo = true;
                    break;
                }
            }
            return polo;
        }

        static double sumDigit(int a, int b)
        {
            int sum = 0;
            double count = 0;
            if (a < b)
            {
                for (int i = a; i < b; i++)
                {
                    if (i % 21 == 0)
                    {
                        count++;
                        sum += i;
                    }
                }
            }
            return sum / count;
        }
    }
}
