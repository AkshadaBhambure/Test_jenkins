using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_jenkins
{
    internal class Program
    {
        public void Addition()
        {
            int a=10, b=20;
            int c = a + b;
            Console.WriteLine("Addition:",c);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Addition();
        }
    }
}
