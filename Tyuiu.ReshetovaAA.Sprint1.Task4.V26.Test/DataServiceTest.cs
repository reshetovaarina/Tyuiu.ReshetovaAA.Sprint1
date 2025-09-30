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
            double x = 0.1;
            double y = 0.29;
            double expected = -0.062;
            double wait = Math.Round((Math.Atan(x) + y) / Math.Exp(y+z), 3);

            var res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}
