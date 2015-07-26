using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonFuncs;

namespace CallingDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                System.Console.WriteLine("Usage: CallingDLL <num1> <num2>");
                return;
            }

            long num1, num2;
            
            try
            {
                num1 = long.Parse(args[0]);
                num2 = long.Parse(args[1]);
            }
            catch (System.FormatException e)
            {

                Console.WriteLine("Format of input insn't valid, only integers allowed. {0}", e.Message);
                return;
            }



            long sum = AddClass.Add(num1, num2);
            long product = MultiplyClass.Multiply(num1, num2);
           


            float div = DivideClass.Divide(num1 / 1L, num2 / 1L);

            System.Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
            System.Console.WriteLine("{0} * {1} = {2}", num1, num2, product);
            System.Console.WriteLine("{0} / {1} = {2}", num1, num2, div);



        }




    }
}
