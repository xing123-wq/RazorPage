using ConsoleApp3;
using NUnit.Framework;
using Umbraco.Core.Composing;

namespace Junit
{
    public class DoublelinkedTest
    {
        [SetUp]
        public void Setup()
        {
        }
        /// <summary>
        /// ≤‚ ‘”√¿˝
        /// </summary>
        [Test]
        public void Test1()
        {
        }
        [Test]
        public void InsertAfer()
        {
            DoubleLinked old = new DoubleLinked();
            DoubleLinked current_1 = new DoubleLinked();
            current_1.InsretAfter(old);

            Assert.AreEqual(current_1.Preivous,old);
            Assert.AreEqual(old.Next, current_1);

            DoubleLinked current_2 = new DoubleLinked();
            current_2.InsretAfter(old);

            Assert.AreEqual(old.Next,current_2);
            Assert.AreEqual(current_2.Next, current_1);
            Assert.AreEqual(current_1.Preivous,current_2);
            Assert.AreEqual(current_2.Preivous,old);
        }
        [Test]
        public void InsertBefore()
        {

        }
    }
}