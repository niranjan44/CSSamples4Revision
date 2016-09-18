using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodParameterDelegate
{
    class Program
    {
        //passing delegate in function parameters or passing methods to function
        //if you have mathematical equation and want to evaluate the equaton with input parametes this is really useful
        static void Main(string[] args)
        {

            int sum = Caluculation(2, 5, (x, y) => (x + y));
            int diff = Caluculation(2, 5, (x, y) => (x - y));

            Console.WriteLine(sum);
            Console.WriteLine(diff);
        }

        static int Caluculation(int x,int y, Func<int,int, int> predicate)
        {
            return predicate(x,y);
        }

    }
}
