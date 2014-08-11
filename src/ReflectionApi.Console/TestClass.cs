using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionApi.TestConsole
{
    public class TestClass
    {
        public string Test1 { get; set; }
        public int Test2 { get; set; }
        public double Test3;
        public string Test4;

        public TestSubClass TestSub { get; set; }

        public int TestMethod1()
        {
            return 0;
        }
    }

    public class TestSubClass
    {
        public string TestSub { get; set; }
    }
}
