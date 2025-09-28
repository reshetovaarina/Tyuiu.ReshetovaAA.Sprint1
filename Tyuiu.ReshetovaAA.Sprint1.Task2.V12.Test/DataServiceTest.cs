using Tyuiu.ReshetovaAA.Sprint1.Task2.V12.Lib;
namespace Tyuiu.ReshetovaAA.Sprint1.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 2;
            int valueTwo = 3;
            int valueThree = 4;

            var res = ds.CalculateParallelepipedVolume(value, valueTwo, valueThree);
            Assert.AreEqual(24, res);
        }
    }
}
