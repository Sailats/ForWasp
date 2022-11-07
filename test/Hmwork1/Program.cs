using System;

    namespace test1
    {
        class Program
        {
            static void Main(string[] args)
            {
                for (int num=1000;num<10000;num++)
                {
                    string n = Convert.ToString(num);
                    int temp1 = num%10;
                    int temp2 = num/10%10;
                    int temp3 = num/100%10;
                    int temp4 = num/1000%10;
                    if (temp1<temp2 & temp2<temp3 & temp3<temp4)
                    {
                        Console.WriteLine("Number = " + num);
                    }
                    }
                }

            }


        }
    