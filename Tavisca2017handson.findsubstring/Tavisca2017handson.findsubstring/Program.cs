using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca2017handson.findsubstring
{
   

    class Program
    {

        static void Main(string[] args)
        {
            Program p = new Program();
            int top = -1;
            int[] arr;
            Console.WriteLine("ENTER THE SIZE OF STACK");
            int Stack = Convert.ToInt32(Console.ReadLine());
            

            void push(int n)
            {
                if (top == Stack - 1)
                {
                    Console.WriteLine("stack got overflowed");


                }
                else
                {
                    Console.WriteLine("enter the number to be pushed");
                    n = Convert.ToInt32(Console.ReadLine());
                    arr[top] = n;
                    top++;
                    Console.WriteLine("printing the pushed string");

                }
            }
            Console.ReadKey();
        }



    }



                





}

    
