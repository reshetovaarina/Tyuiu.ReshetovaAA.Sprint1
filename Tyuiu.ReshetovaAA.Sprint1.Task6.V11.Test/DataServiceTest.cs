using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint1.Task6.V11.Lib;

namespace Tyuiu.ReshetovaAA.Sprintf.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckFirstLetterRepetition()
        {
            DataService ds = new DataService();
            string value = "hello";
            bool res = ds.CheckeFirstLetterRepetition(value);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckFirstLetterNoRepetition()
        {
            DataService ds = new DataService();
            string value = "world";
            bool res = ds.CheckeFirstLetterRepetition(value);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckEmptyString()
        {
            DataService ds = new DataService();
            string value = "";
            bool res = ds.CheckeFirstLetterRepetition(value);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckSingleCharacter()
        {
            DataService ds = new DataService();
            string value = "a";
            bool res = ds.CheckeFirstLetterRepetition(value);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}