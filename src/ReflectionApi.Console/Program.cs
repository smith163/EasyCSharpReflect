using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReflectionApi.Api;


namespace ReflectionApi.TestConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var test = ReflectionGetter.GetFields(typeof(TestClass));
            //var properties = ReflectionGetter.GetProperties(typeof(TestClass));

            var temp = new TestClass()
            {
                Test1 = "Test1String",
                Test2 = 2,
                Test3 = 2.5,
                Test4 = "Test4String",
                TestSub = new TestSubClass() { TestSub = "TestSub", TestSub2 = new TestSubClass2() { TestSub3 = "TestSub3"} }
            };

            var testList = ReflectionConvert.SerializeToDictionary<TestClass>(temp);
            foreach(var val in testList)
            {
                Console.WriteLine(val.Key + ":" + val.Value.Value);
            }
               
            /*
            var methods = ReflectionGetter.GetMethods(typeof(TestClass));

            foreach(var val in test)
            {
                Console.WriteLine(val.Name + ":" + val.Type.Name + ":" + val.ReflectedType.Name);
            }

            foreach (var val in properties)
            {
                Console.WriteLine(val.Name + ":" + val.Type.Name + ":" + val.ReflectedType.Name);
            }*/


            Console.ReadLine();
        }
    }
}
