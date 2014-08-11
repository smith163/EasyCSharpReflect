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

            Assert.IsTrue(fieldList.Contains(new Field() { Name = "Test4", Type = typeof(string), ReflectedType = typeof(TestClass) }));
            Assert.IsTrue(fieldList.Contains(new Field() { Name = "Test3", Type = typeof(double), ReflectedType = typeof(TestClass) }));
        }

        [Test]
        public void TestGetProperties()
        {
            var fieldList = ReflectionConvert.GetProperties(typeof(TestClass));

            Assert.IsTrue(fieldList.Contains(new Property() { Name = "Test1", Type = typeof(string), ReflectedType = typeof(TestClass) }));
            Assert.IsTrue(fieldList.Contains(new Property() { Name = "Test2", Type = typeof(int), ReflectedType = typeof(TestClass) }));
        }

        [Test]
        public void TestGetVariableMember()
        {
            var variableList = ReflectionConvert.GetVariableMembers(typeof(TestClass));

            Assert.IsTrue(variableList.Contains(new Property() { Name = "Test1", Type = typeof(string), ReflectedType = typeof(TestClass) }));
            Assert.IsTrue(variableList.Contains(new Property() { Name = "Test2", Type = typeof(int), ReflectedType = typeof(TestClass) }));
            Assert.IsTrue(variableList.Contains(new Field() { Name = "Test4", Type = typeof(string), ReflectedType = typeof(TestClass) }));
            Assert.IsTrue(variableList.Contains(new Field() { Name = "Test3", Type = typeof(double), ReflectedType = typeof(TestClass) }));
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
