using System;

namespace Lesson6_14_08_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //ДЗ 2
                Console.Write("Введите размер массива : ");
                int n=int.Parse(Console.ReadLine());
                double[] mas = new double [n];
               double sum=0,min=0,max=0;
               Console.WriteLine("Введите элемены массива : ");
                for(int i=0; i<n; ++i)
                {
                    mas[i]=double.Parse(Console.ReadLine());
                    if(i==0){min=mas[i];}
                    else if(min>mas[i])min=mas[i];
                }
                 Console.Write($"Нечетные значения  массива :");
                for(int i=0; i<n; ++i)
                {
                    sum+=mas[i];
                    if(i==0)max=mas[i];
                    else if(max<mas[i])max=mas[i];
                    if(mas[i]%2!=0)
                    {
                        Console.Write($"\t{mas[i]}");
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"Наибольшее значение массива : {max}");
                Console.WriteLine($"Наименьшее значение массива : {min}");
                Console.WriteLine($"Общую сумму всех элементов : {sum}");
                Console.WriteLine($"Среднее арифметическое всех элементов : {sum/n}");
            }
            {
                //ДЗ 3
                  Console.Write("Введите размер массива : ");
                int n=int.Parse(Console.ReadLine());
                   int[] mas = new int [n];
                      Console.WriteLine("Введите элемены массива : ");
                for(int i=0; i<n; ++i)
                {
                    mas[i]=int.Parse(Console.ReadLine());
                 }
                 Console.Write("Элементы массива в обратном порядке :");
                 for(int i=n-1; i>=0; --i)
                Console.Write($"\t{mas[i]}");
            }
            Console.WriteLine();
            {
              //ДЗ 4  
               Console.Write("Введите размер массива : ");
                int n=int.Parse(Console.ReadLine()),t=0;
                   int[] mas = new int [n];
                      Console.WriteLine("Введите элемены массива : ");
                for(int i=0; i<n; ++i)
                {
                    mas[i]=int.Parse(Console.ReadLine());
                 }
                Console.Write("Введите значения count : ");
                int count=int.Parse(Console.ReadLine());
                 Console.Write("Введите значения index : ");
                int index=int.Parse(Console.ReadLine());
                 int[] newMas=new int [count];
                 for(int i=index; t<count; ++i) 
                  {
                        if(i<n)     
                         newMas[t]=mas[i];
                         else newMas[t]=1;
                         ++t;
                  }
                  Console.Write("Значение новый массив :");
                  for(int i=0;i<count; ++i)Console.Write($"\t{newMas[i]}");
            }

        }
    }
}
