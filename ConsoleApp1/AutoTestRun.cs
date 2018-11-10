using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoTest;
namespace ConsoleApp1
{
    class AutoTestRun
    {
        static void Main(string[] args)
        {
            FirstTest test = new FirstTest();
            test.Test1();
            Console.ReadLine();
        }
    }
}
