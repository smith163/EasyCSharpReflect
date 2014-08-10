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
            var test = ReflectionConvert.GetFields(typeof(TestClass));
            var properties = ReflectionConvert.GetProperties(typeof(TestClass));

            var methods = ReflectionConvert.GetMethods(typeof(TestClass));

            foreach(var val in test)
            {
                Console.WriteLine(val.Name + ":" + val.Type.Name);
            }

            foreach (var val in properties)
            {
                Console.WriteLine(val.Name + ":" + val.Type.Name);
            }


            Console.ReadLine();
        }
    }
}
