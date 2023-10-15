using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using TestNinja.Fundamentals;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinjaUnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;
        [SetUp] 
        public void SetUp()
        {
            _math = new Math();
        }
        

        [Test]
        
        public void Add_WhenCalled_ReturnSumOfBothArguments()
        { 
            var result = _math.Add(1, 2);
            NUnit.Framework.Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_FirstArgumentIsGreater_ReturnFirstArgument(int a, int b, int expactedvalue)
        {
            var result = _math.Max(a, b);
            NUnit.Framework.Assert.That(result, Is.EqualTo(expactedvalue));
        }
        
    }
}
