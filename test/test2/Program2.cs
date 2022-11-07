using System;

    namespace test2
    {
        class Program2
        {
            static void Main(string[] args)
            {
                Console.Write("Enter your number: ");
                string userNum = Console.ReadLine();
                Console.WriteLine("---------------");

                if (userNum.Length>1 || userNum.Length<1) //проверка на главную цифру диагонали (должна быть одна цифра<10)
                {
                    Console.WriteLine("Error!");
                    
                }

                else
                {
                    Console.WriteLine("Your "+userNum+"*"+userNum+" matrix");
                    Console.WriteLine("---------------");

                    int num = Convert.ToInt32(userNum);
                    int len=num; // кол-во столбиков
                    int tmpx = 0; // переменная, отвечающая за столбики в данной строке
                    int tmpy = 0; // переменная, отвечающая за строки в данном столбце
                    int localy = 0; //  переменная, отвечающая за цифры, стоящие до Главной цифры диагонали
                    int POSafterNum=1; // переменная, отвечающая за цифры, после Главной цифры цифры диагонали
                    while (tmpx!=len & tmpy!=len) // цикл, работающий до момента, когда кол-во столбцов и строк будет равно заданной цифре
                    {
                        if (tmpx == tmpy) // в этой точке находится Главная цифра диагонали
                        {
                            Console.Write(num);
                            tmpx++;
                            while (tmpx!=len) // заполнение столбцов в строке (После Гл.цифры диагонали)
                            {
                                if ((tmpx+1)==len & tmpy!=num) // если все столбы заполнены, то перенос на след строку
                                {
                                    Console.Write(num-POSafterNum+"\n");
                                    POSafterNum++;
                                    tmpx++;
                                }
                                else
                                {
                                    Console.Write(num-POSafterNum);
                                    POSafterNum++;
                                    tmpx++;

                                }
                            }

                        }
                        else // запись цифр до Главной цифры диагонали
                        {
                            Console.Write(num-tmpy+localy);
                            tmpx++;
                            localy++;
                        }
                        if (tmpx==len & tmpy != len) // Если все столбцы в строке заполнены, то обнуляются счетчики столбцов 
                        {                           //  (tmpx,localy,PoSafterNum) и счетчик строк +1 (tmpy+1)
                            tmpx=0;
                            localy=0;
                            POSafterNum=1;
                            tmpy++;

                        }

                    }
                }
                Console.WriteLine("\n---------------");
            }

        }
    }







            // if (tmpy == 0) // 
        // {
        //     if ((tmpx+1)==len & tmpy!=num)
        //     {
        //         Console.Write(num-tmpx + "\n");
        //         tmpx++;  
        //     }
        //     else
        //     {
        //         Console.Write(num-tmpx);
        //         tmpx++;
        //     }
        // }