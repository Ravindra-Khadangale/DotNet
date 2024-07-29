using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  SYMBIOSIS_Assignment 1
{
    public delegate void Operation(int a, int b);
    
    internal class Arithmetic
    {
        public  static int x, y,i=1;

        private static void add(int a,int b)
        {
            Console.WriteLine("Addition :"+(a+b));
        }
        private static void multiply(int a,int b)
        {
            Console.WriteLine("Multiplication :"+(a*b));
        }
        public static void ExecutableDeligatae(Operation d)
        {
            d(x,y);
        }

        static void Main(string[] args)

        {

            Console.WriteLine("!!!!!!!!! MENU !!!!!!!!!!" +
                              "\n1.Addition\n2.Substraction\n3.Both");

           
                Console.WriteLine("Enter 1st number:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number:");
            y = Convert.ToInt32(Console.ReadLine());

            while (i <= 3)
            {

                Console.WriteLine("Enter your choice:");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Operation del = add;
                       ExecutableDeligatae(del);
                       break;

                     case 2:
                        Operation del1 = multiply;
                        ExecutableDeligatae(del1);
                        break;

                     case 3:
                        Operation del2 = add;
                        del2 += multiply;
                        ExecutableDeligatae(del2);
                        break;
                     default: Console.WriteLine("Enter valid choice");
                        break;

                }
                i++;
            }
        }
    }
    
}
