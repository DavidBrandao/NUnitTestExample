using NUnit.Framework;
using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace ByteBankAppTest
{
    public class TestIntroduction
    {
        string fileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).Replace(@"bin\Debug\net48", @"Logs\example.txt");

        [OneTimeSetUp]
        public void TestOneTimeSetup()
        {
            Console.WriteLine("One Time Setup");
        }

        [SetUp]
        public void TestSetup()
        {
            Console.WriteLine("Test Setup");

        }

        [Test]
        public void Test01()
        {
            Console.WriteLine("First Test");
        }

        [Test]
        public void Test02()
        {
            Console.WriteLine("Second Test");
        }

        [Test]
        public void Test03()
        {
            Console.WriteLine("Third Test");
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Test Tear Down");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("One Time Tear Down");
        }
    }
}
