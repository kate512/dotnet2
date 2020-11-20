using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_13._11
{
    class Program
    {
       static public (int, bool) Prov(string a, string b) { 
            try
            {
                int c = Convert.ToInt32(a);
                int d = Convert.ToInt32(b);
            }
            catch 
            {
                while()
                throw new MyException();
                
            }
            return (1, true);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите два целых числа:");
            try
            {
               var t =  Prov("","");
            }
            catch(MyException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
           /* string a = Console.ReadLine();
            string b = Console.ReadLine();*/
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите 1, если +");
            Console.WriteLine("        2, если -");
            Console.WriteLine("        3, если *");
            Console.WriteLine("        4, если /");
            var typeOperation = (Oper)Convert.ToInt32(Console.ReadLine());
            int result = -1;

            if (!Enum.IsDefined(typeof(Oper), typeOperation))
            {
                Console.WriteLine("Sad");
                return;
            }

            switch (typeOperation)
            {
                    case Oper.Add:
                    result = a + b;
                    break;
                    case Oper.Substr:
                    result = a - b;
                    break;
                    case Oper.Mult:
                    result = a * b;
                    break;
                    case Oper.Del:
                   //выявление ошибки
                    try
                    {
                        result = a / b;
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка, на 0 делить нельзя!");
                        break;

                    }
                    
                    break;
            }
            
            Console.WriteLine($"Полученный результат операции {(int)typeOperation} = {result}");
            Console.ReadKey();
            
        }
    }
}
