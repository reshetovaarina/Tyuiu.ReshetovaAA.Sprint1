using Tyuiu.ReshetovaAA.Sprint1.Task1.V22.Lib;
namespace Tyuiu.ReshetovaAA.Sprint1.Task1.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3, res);
        }
    }
}
