using System;
using NUnit.Framework;

namespace MyDemoApp.Tests
{

    public class CalculatorTests
    {
        [Test]
        public void MathStillWorks()
        {
            var result = 1 + 1;
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
