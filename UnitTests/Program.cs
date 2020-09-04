using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;

namespace UnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            // seed for guerrilla test framework :) 
            // 
            //var allTestMethods = Assembly
            //    .GetEntryAssembly()
            //    .GetTypes()
            //    .Where(t => t.IsPublic)
            //    .Where(t => t.IsAbstract == false)
            //    .SelectMany(t => t.GetMethods())
            //    .Where(m => m.IsPublic)
            //    .Where(m => m.CustomAttributes.Contains());

        }



        // test
        [MyTestMethod]
        private static void DivTest()
        {
            var expected = 3;

            // AAA 

            // arrange

            // act
            var result = Div(9, 3);

            // assert
            var isOk = result == expected;

            Console.WriteLine(isOk);
        }

        // code under test
        
        private static int Div(int a, int b)
        {
            return a / b;
        }
    }

    // mark attribute for tests
}
