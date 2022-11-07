using System;

    namespace test4
    {
        class Program
        {
            static void Main(string[] args)
            {
                static int factorial(int n) // ф-ция вычисления факториала числа для формулы С
                {
                    int x = 1;
                    for (int i = 1; i <= n; i++)
                    {
                        x *= i;
                    }
                    return x;
                }

                Console.Write("Enter count of rows: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Your triangle");
                Console.WriteLine("---------------------------------");

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j <= (n - i); j++) // для формы треугольника (слева пустые места)
                    {
                        Console.Write(" "); 
                    }
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(" ");
                        Console.Write(factorial(i) / (factorial(j) * factorial(i - j))); // формула С
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("---------------------------------");
            }
        }
    }