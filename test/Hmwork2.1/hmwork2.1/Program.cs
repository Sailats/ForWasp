using System;

    namespace test
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Write your number to convert in 2 base: ");
                int x = Convert.ToInt32(Console.ReadLine());
                string answer = "";
                while(x>0){
                    answer = (Convert.ToString(x%2))+answer;
                    x = x/2;
                }
                Console.WriteLine("Your number in 2 base: " + answer);
            }
        }
    }