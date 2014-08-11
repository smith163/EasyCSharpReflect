using System;
using System.Collections.Generic;
using NUnit.Framework;
using ReflectionApi.Convert;
using ReflectionApi.ClassMembers;

namespace ReflectionApi.UnitTests
{
    [TestFixture]
    public class TestClassMemberGetters
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
        public void TestGetFields()
        {
            var fieldList = ReflectionConvert.GetFields(typeof(TestClass));

            var testField = new Field()
            {
                Name = "Test1"
            };

            Assert.IsTrue(fieldList.Contains(new Field() { Name = "Test4", Type = typeof(string), ReflectedType = typeof(TestClass) }));
        }

        
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
