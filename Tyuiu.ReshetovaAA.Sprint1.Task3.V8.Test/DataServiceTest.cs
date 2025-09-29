using Tyuiu.ReshetovaAA.Sprint1.Task3.V8.Lib;
namespace Tyuiu.ReshetovaAA.Sprint1.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double deposit = 2500;
            double percent = 20;
            double days = 30;

            double wait = 41.096;

            var res = ds.IncomeAmount(deposit, percent, days);

            Assert.AreEqual(wait, res);
        }
    }
}
