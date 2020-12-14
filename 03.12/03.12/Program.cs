using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._12
{
    class Program
    {
        delegate void Oper(int A, int B);
        static void Main(string[] args)
        {
            int A = 8, B = 4;
            Oper operation; //переменная делегата
            
            operation = Div;
            operation += Sub;
            operation += Mult;
            operation += Add;
            
            operation(A, B);
            operation -= Div;
            operation(A, B);
            Console.ReadKey();
        }
        public static void Sub(int A, int B)
        {
            Console.WriteLine(A - B);
        }
        public static void Add(int A, int B)
        {
            Console.WriteLine(A + B);
        }
        public static void Mult(int A, int B)
        {
            Console.WriteLine(A * B);
        }
        public static void Div(int A, int B)
        {
            Console.WriteLine(A / B);
        }
    }
}
