using NUnit.Framework;
using HelloLexaMayson;
using System.IO;
using System;

namespace Lexa
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.Main(null);
                Assert.AreEqual(sw.ToString(), "Привет Лёха!\r\n");
            }
        }
        [Test]
        public void TestOutPut()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.Main(null);
                Assert.IsTrue(sw.ToString().Equals("Привет Лёха!\r\n"));
            }
        }
    }
}