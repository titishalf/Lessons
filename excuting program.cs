using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int c;
               var operation1 = new calculate();
               Console.WriteLine("enter first index");
               double index1 = Convert.ToDouble(Console.ReadLine());
               Console.WriteLine("enter second index");
               double index2 = Convert.ToDouble(Console.ReadLine());
               Console.Write("choose any operator continue:\n\n");
            Console.WriteLine("1. addition");
            Console.WriteLine("2. Divide");
            Console.WriteLine("3.substract ");
            Console.WriteLine("4. Multiply\n\n\n\n\n");
            int C = Convert.ToInt16(Console.ReadLine());
            
            if (C == 1)
            {
                operation1.Add(index1, index2);
                Console.WriteLine("the result of :{0} and {1}is equal to {2}", index1, index2, operation1.Add(index1, index2));
            }
  else if( C==2)
            {
                operation1.Divide(index1, index2);
                Console.WriteLine("the result of :{0} and {1}is equal to {2}", index1, index2, operation1.Divide(index1, index2));
            }
            else if (C == 3)
            {
                operation1.Substract(index1, index2);
                Console.WriteLine("the result of :{0} and {1}is equal to {2}", index1, index2, operation1.substract(index1, nindex2));
            }
            else if (C == 4)
            {
                operation1.Multiply(index1, index2);
                Console.WriteLine("the result of : {0} and {1}is equal to {2}", index1, index2, operation1.Multiply(index1, index2));
            }
            else
            {
                Console.WriteLine("impossible calculation");
            }
            Console.ReadKey();
               

         }

    }
}
