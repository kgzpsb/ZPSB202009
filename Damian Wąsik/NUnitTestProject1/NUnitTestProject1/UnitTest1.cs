using NUnit.Framework;
using System;
using NUnit.Samples.Cash;


namespace NUnitTestProject1
{
    public class Tests
    {
        private Cash f14CHF;
        [SetUp]
        public void Setup()
        {
            f14CHF = new Cash(14, "CHF");
            Console.WriteLine("This is Setup in CLI");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [SetUp]
        protected void SetUp()
        {
            Console.WriteLine("This is setUp");
        }

        [TearDown]
        protected void Teardown()
        {
            Console.WriteLine("This is Teardown");
        }

        [Category("Smoke")]
        [Test]
        public void xxx()
        {
            var x = 1;
            var y = 2;
            Assert.AreEqual(x, y);
        }

        [Category("Smoke")]
        [Test]
        public void xxy()
        {
            var x = 1;
            var y = 1;
            Assert.AreEqual(x, y);
        }

        /// <summary>
        /// Assert that multiplying currency in cach happens correctly
        /// </summary>
        [Test]
        public void SimpleMultiply()
        {
            // [14 CHF] *2 == [28 CHF]
            Cash expected = new Cash(28, "CHF");
            Assert.AreEqual(expected, f14CHF.Multiply(2));
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void SimpleAdd()
        {
            // [14 CHF] *2 == [28 CHF]
            //     Cash expected = new Cash(28, "CHF");
            //     Assert.AreEqual(expected, f14CHF.Multiply(2));
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Simple()
        {
            // [14 CHF] *2 == [28 CHF]
            //    Cash expected = new Cash(28, "CHF");
            //    Assert.AreEqual(expected, f14CHF.Multiply(2));
        }

        /// <summary>
        /// Test set Currency , Data-Driven Testing
        /// </summary>
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void SetCurrency_ChangeCurrencyToCHF_ThreeObjectCurrenciesAreEqual(int value)
        {
            //removing
            // if (value == 3)
            //  {
            //      Assert.Fail();
            //  }
            //  var curr = "CHF";

            // arrange
            Cash c2 = new Cash(value, "CHF");
            Cash c = new Cash(value, "PLN");

            // act
            c.SetCurrency("CHF");

            // assert
            Assert.AreEqual(c2.Currency, c.Currency);
        }

      


    }
}