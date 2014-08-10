using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReflectionApi.Convert;


namespace ReflectionApi.TestConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var test = ReflectionConvert.GetVariables(typeof(TestClass));

            foreach(var val in test)
            {
                Console.WriteLine(val);
            }

            Console.ReadLine();
        }
    }
}
