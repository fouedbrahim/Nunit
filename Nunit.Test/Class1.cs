using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nunit;

namespace Nunit.Test
{
    [TestFixture] //This is the attribute that marks a class that contains tests
    public class Class1
    {
        [Test] // an indication that it is a test method
        public void AddTest() {
            Program t = new Program();
            int result = t.Add(20, 10);
            Assert.AreEqual(30, result); }

        [Ignore("We're skipping this one for now.")]
        public void SubtractTest()
        {
            Program t = new Program();
            int result = t.Subtract(20, 10);
            Assert.AreEqual(10, result);
        }
            // Assert.AreEqual Verifies that two specified generic type data are equal by using the equality operator. The assertion fails if they are not equal. Displays a message if the assertion fails. }
[Test]
        public void Addition() { Program t = new Program(); Assert.AreEqual(8, t.Add(2, 3)); }
        [Test]
        public void Substraction()
        {
            Program t = new Program(); Assert.AreEqual(0, t.Subtract(2, 2));
        }
        [Test]
        public void Divide() { Program t = new Program(); Assert.AreEqual(1, t.Devide(2, 0)); }
    }
}
