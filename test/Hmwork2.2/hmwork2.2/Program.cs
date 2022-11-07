using System;

    namespace test2
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Write your 1st number to convert in 2 base: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Write your 2nd number to convert in 2 base: ");
                int b = Convert.ToInt32(Console.ReadLine());
                string answerA = "";
                string answerB = "";
                Console.WriteLine("----------------------------------");

                while(a>0){ // конвертация первого числа в 2ую
                    answerA = (Convert.ToString(a%2))+answerA;
                    a = a/2;
                }
                while(b>0){ // конвертация второго числа в 2ую
                    answerB = (Convert.ToString(b%2))+answerB;
                    b = b/2;
                }

                if (answerB.Length>answerA.Length) //подравнивание нулями если длины разные
                {
                    answerA = (String.Concat(Enumerable.Repeat("0",answerB.Length-answerA.Length)))+answerA;
                    
                }
                if (answerA.Length>answerB.Length)
                {
                    answerB = (String.Concat(Enumerable.Repeat("0",answerA.Length-answerB.Length)))+answerB;
                    
                }

                // подсчёт суммы чисел
                String NumberA = answerA;
                int nForSum1 = 0;
                String NumberB = answerB;
                int nForSum2 = 0;
                
                for (int i = 0; i < NumberA.Length; i++)
                {
                    if (NumberA[NumberA.Length - i - 1] == '0') continue;
                    nForSum1 += (int)Math.Pow(2, i);
                }

                for (int i = 0; i < NumberB.Length; i++)
                {
                    if (NumberB[NumberB.Length - i - 1] == '0') continue;
                    nForSum2 += (int)Math.Pow(2, i);
                }
                
                
                int TotalAnswer = nForSum1+nForSum2;
                string answer = "";
                while(TotalAnswer>0){ 
                    answer = (Convert.ToString(TotalAnswer%2))+answer;
                    TotalAnswer = TotalAnswer/2;
                }


                // подравнивание чисел если длина суммы больше чисел
                if (answer.Length>answerA.Length)
                {
                    answerA = (String.Concat(Enumerable.Repeat("0",answer.Length-answerA.Length)))+answerA;
                    
                }

                if (answer.Length>answerB.Length)
                {
                    answerB = (String.Concat(Enumerable.Repeat("0",answer.Length-answerB.Length)))+answerB;
                    
                }
                Console.WriteLine(answerA+" - your 1st number in 2 base");
                Console.WriteLine(answerB+" - your 2nd number in 2 base");
                Console.WriteLine(answer+ " - your answer ");
                Console.WriteLine("----------------------------------");
            }
        }
    }