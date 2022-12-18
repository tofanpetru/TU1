namespace TestProject.ExternalTestData
{
    public static class TestData
    {
        public static int DivideByZeroNumbers(int num1, int num2)
        {
            return num1 / num2;
        }

        public static IEnumerable<TestCaseData> DivideByZeroDataProvider()
        {
            yield return new TestCaseData(2, 2, 1);
            yield return new TestCaseData(3000, 0, 0);//will throw exception
        }
    }
}
