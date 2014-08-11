﻿using System;
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
            var test = ReflectionGetter.GetFields(typeof(TestClass));
            var properties = ReflectionGetter.GetProperties(typeof(TestClass));

            var methods = ReflectionGetter.GetMethods(typeof(TestClass));

            foreach(var val in test)
            {
                Console.WriteLine(val.Name + ":" + val.Type.Name + ":" + val.ReflectedType.Name);
            }

            foreach (var val in properties)
            {
                Console.WriteLine(val.Name + ":" + val.Type.Name + ":" + val.ReflectedType.Name);
            }


            Console.ReadLine();
        }
    }
}
