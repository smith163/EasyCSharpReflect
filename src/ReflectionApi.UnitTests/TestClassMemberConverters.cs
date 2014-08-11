using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReflectionApi.Api;
using ReflectionApi.ClassMembers;
using NUnit.Framework;

namespace ReflectionApi.UnitTests
{
    [TestFixture]
    public class TestClassMemberConverters
    {
        [SetUp]
        public void SetUp()
        {
            testClass = new TestClass()
            {
                Test1 = "Test1String",
                Test2 = 2,
                Test3 = 2.5,
                Test4 = "Test4String"
            };
        }

        private TestClass testClass;

        [TearDown]
        public void CleanUp()
        {

        }

        [Test]
        public void TestSerializeIntoList()
        {
            var memberList = ReflectionConvert.SerializeToList<TestClass>(testClass);

            Assert.IsTrue(memberList.Contains(new Field() { Name = "Test4", Type = typeof(string), ReflectedType = typeof(TestClass), Value = (object)"Test1String" }));
            Assert.IsTrue(memberList.Contains(new Field() { Name = "Test3", Type = typeof(string), ReflectedType = typeof(TestClass), Value = (object)2 }));
        }

        [Test]
        public void TestSerializeIntoDictionary()
        {
            var memberList = ReflectionConvert.SerializeToDictionary<TestClass>(testClass);

            Assert.AreEqual("Test1String", memberList["Test1"]);
            Assert.AreEqual("2", memberList["Test2"]);
            Assert.AreEqual("2.5", memberList["Test3"]);
            Assert.AreEqual("Test4String", memberList["Test4"]);
        }

        public class TestClass
        {
            public string Test1 { get; set; }
            public int Test2 { get; set; }
            public double Test3;
            public string Test4;

            public int TestMethod1()
            {
                return 0;
            }
        }

    }
}
