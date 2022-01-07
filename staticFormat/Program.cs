using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resultString = String.Format("{0:P2}",0.5);
            Console.WriteLine(resultString);
            Console.ReadKey();

        }
    }
}
