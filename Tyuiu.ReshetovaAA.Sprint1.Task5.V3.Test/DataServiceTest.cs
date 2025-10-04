using Tyuiu.ReshetovaAA.Sprint1.Task5.V3.Lib;
namespace Tyuiu.ReshetovaAA.Sprint1.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int h = 12134;
            DataService ds = new DataService();
            int res = ds.Calculate(h);
            int wait = 1;
            Assert.AreEqual(res, wait);
        }
    }
}
