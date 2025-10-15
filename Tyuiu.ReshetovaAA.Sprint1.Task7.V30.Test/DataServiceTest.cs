using Tyuiu.ReshetovaAA.Sprint1.Task7.V30.Lib;
namespace Tyuiu.ReshetovaAA.Sprint1.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = Math.Round(x + Math.Exp(x) + (Math.Sin(Math.Pow(x, 5)) + Math.Pow(x, 3)) / Math.Pow(3, x) + Math.Pow(y, 5) / Math.Pow(5, y), 3);
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
