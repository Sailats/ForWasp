using System;

    namespace test3   
    {
        class Program3
        {
            static void Main(string[] args)
            {
                int mxsX = 0; // определение размеров массива по максимальным значениям (х и у)
                int mxsY = 0;
                
                Console.Write("Enter first point(x): ");  // введение координат точек и вычисление их максимума
                int point1x = Convert.ToInt32(Console.ReadLine());
                if (point1x>mxsX){
                    mxsX = point1x;
                }
                Console.Write("Enter first point(y): ");
                int point1y = Convert.ToInt32(Console.ReadLine());
                if (point1y>mxsY){
                    mxsY = point1y;
                }
                Console.Write("Enter second point(x): ");
                int point2x = Convert.ToInt32(Console.ReadLine());
                if (point2x>mxsX){
                    mxsX = point2x;
                }
                Console.Write("Enter second point(y): ");
                int point2y = Convert.ToInt32(Console.ReadLine());
                if (point2y>mxsY){
                    mxsY = point2y;
                }
                Console.Write("Enter third point(x): ");
                int point3x = Convert.ToInt32(Console.ReadLine());
                if (point3x>mxsX){
                    mxsX = point3x;
                }
                Console.Write("Enter third point(y): ");
                int point3y = Convert.ToInt32(Console.ReadLine());
                if (point3y>mxsY){
                    mxsY = point3y;
                }
                Console.WriteLine("----------------------");

                Console.WriteLine("First point: "+"("+point1x+","+point1y+")");
                Console.WriteLine("Second point: "+"("+point2x+","+point2y+")");
                Console.WriteLine("Third point: "+"("+point3x+","+point3y+")");
                Console.WriteLine("----------------------");
                ////////////////////////////////////////////////////////////////////////////////////
                string[,] mass = new string[mxsY,mxsX]; // создание двумерного массива
                if (point1x!=0){point1x=point1x-1;} // уменьшение значений точек из-за индексов массива
                if (point1y!=0){point1y=point1y-1;}
                if (point2x!=0){point2x=point2x-1;}
                if (point2y!=0){point2y=point2y-1;}
                if (point3x!=0){point3x=point3x-1;}
                if (point3y!=0){point3y=point3y-1;}

                mass[point1y,point1x]="*"; //расстановка базовых точек
                mass[point2y,point2x]="*";
                mass[point3y,point3x]="*";
                
                // тут были жалкие попытки решить это другим способом (соединяет боковые линиями)
                // int tmp1y=point1y+1;
                // int tmp2y=point2y+1;
                // int tmp3y=point3y+1;
                // int tmp1x=point1x+1;
                // int tmp2x=point2x+1;
                // int tmp3x=point3x+1;
                // if (point1x==point2x){while(tmp1y!=point2y){mass[tmp1y,point1x] = "*";tmp1y++;}}
                // if (point1y==point2y){while(tmp1x!=point2x){mass[point1y,tmp1x] = "*";tmp1x++;}}
                // if (point2x==point3x){while(tmp2y!=point3y){mass[tmp2y,point2x] = "*";tmp2y++;}}
                // if (point2y==point3y){while(tmp2x!=point3x){mass[point2y,tmp2x] = "*";tmp2x++;}}

                int tmpy = point3y; // временные переменные для заполнения массива звездочками
                int tmp = 0;

                 while(tmpy>=0){
                    int tmpx = point3x-tmp;
                    if(point1x==point2x){ //если у второй вершины у такой же как у первой
                        mass[point3y-tmp,point3x-tmp]="*";
                        for (int i=tmpx;i>=0;i--){
                            mass[point3y-tmp,i]="*";
                        }
                        tmp++;
                        tmpy--;
                    }
                    else{ // если у второй х такой же как у первой
                        mass[point3y-tmp,point3x-tmp]="*";
                        for (int i=tmpx;i-1!=point3x;i++){
                            mass[point3y-tmp,i]="*";
                        }
                        tmp++;
                        tmpy--;
                    }
                 }
                for (int i=0;i<mxsY;i++) //вывод 
                {
                    for (int j=0;j<mxsX;j++)
                    {
                        Console.Write(mass[i,j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }