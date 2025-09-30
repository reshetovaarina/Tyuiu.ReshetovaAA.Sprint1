using  Tyuiu.ReshetovaAA.Sprint1.Task4.V26.Lib;
namespace Tyuiu.ReshetovaAA.Sprint1.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = -0.666;
            double wait = Math.Round((Math.Atan(x) + y) / Math.Exp(y), 3);

            var res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}
