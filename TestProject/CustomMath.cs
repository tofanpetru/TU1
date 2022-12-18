namespace TestProject
{
    [TestFixture]
    public class CustomMath
    {
        [Test]
        public void TestSum()
        {
            Console.WriteLine("TestSum");

            int nbr1 = 0, nbr2 = 0;
            int result = nbr1 + nbr2;
            Assert.Multiple(() =>
            {
                Assert.IsTrue(result == 0);
                Assert.That(result, Is.EqualTo(0));
            });
        }

        [Test, TestCaseSource(typeof(TestData), nameof(TestData.DivideByZeroDataProvider))]
        public void TestDivisionByZero(int num1, int num2, double expected)
        {
            if (num1.Equals(0) || num2.Equals(0))
            {
                Assert.Throws<DivideByZeroException>(() => TestData.DivideByZeroNumbers(num1, num2));
            }
            else
            {
                Assert.That(expected, Is.EqualTo(TestData.DivideByZeroNumbers(num1, num2)));
            }
        }
    }
}
