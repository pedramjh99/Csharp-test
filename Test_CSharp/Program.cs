using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1:OddOrEvenNumber\n2:Max Number\n3:Average of Numbers\n4:Prime Number\n5:The Complete Number");
            Console.WriteLine("\nEnter a Number :");
            int a = Convert.ToInt32(Console.ReadLine());
            switch(a)
            { 
                case 1:
                Console.WriteLine("Enter a Number For get Odd or Even : ");
                int number = Convert.ToInt32(Console.ReadLine());
                EvenOrOdd(number);
                break;
                case 2:
                    MaxOrMin();
                    break;
                case 3:
                    Avg();
                    break;
                case 4:
                    Console.WriteLine("Enter a number for get prime before that :");
                    int n =Convert.ToInt32 (Console.ReadLine());
                    for (int i = 2; i <= n; i++)
                    {
                        if (Prime_Number(i))
                            Console.Write(i + " ");
                    }
                    break;
                case 5:
                    Console.WriteLine("Enter a number for get prime or not :");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if(Prime_Number(num))
                    {
                        Console.WriteLine(num + " is prime");
                    }
                    else
                    {
                        Console.WriteLine(num + " is not prime");
                    }
                    break;
                default:
                    Console.WriteLine("Sorry!!! Enter a Number between 1-5");
                    break;
            }
        }
        static void EvenOrOdd(int number)
        {
            if(number%2==0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
        static void MaxOrMin()
        {
            int n;
            Console.WriteLine("Enter count numbers :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int min = 0, max = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter num {0} :", i+1);
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Max is : " + max + "\n" + "Min is : " + min);
        }
        static void Avg()
        {
            int n;
            float sum = 0;
            Console.WriteLine("Enter count numbers :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter num {0} :", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
                sum += a[i];
            }
            float avg = sum / n;
            Console.WriteLine("Avg is : " + avg);
        }
        static bool Prime_Number(int n)
        {
            if (n <= 1)
            { 
                return false;
            }
            for (int i = 2; i < n; i++)
            { 
                if (n % i == 0)
                { 
                    return false;
                }
            }
            return true;
        }
    }
}
