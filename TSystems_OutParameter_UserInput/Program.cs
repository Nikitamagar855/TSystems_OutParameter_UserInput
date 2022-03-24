using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_OutParameter_UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First No");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second No");
            int b = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            int add, mul, sub, div;
            obj.ArithmaticOP(a,b,out add, out sub, out div, out mul);
            Console.ReadLine();





        }
        public void ArithmaticOP(int a,int b,out int add, out int sub, out int mul, out int div)
        {
           
           
            add = a + b;
            Console.WriteLine($"addition is {add}");
            sub = a - b;
            Console.WriteLine($"Substraction  is {sub}");
            mul = a * b;
            Console.WriteLine($"Multiplication  is {mul}");
            div = a / b;
            Console.WriteLine($"Division is {div}");

        }


        }
    }
