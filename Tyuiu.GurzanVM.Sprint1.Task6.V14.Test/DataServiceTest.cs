using Tyuiu.GurzanVM.Sprint1.Task6.V14.Lib;

namespace Tyuiu.GurzanVM.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "� � A B a b � �";
            DataService ds = new DataService();
            bool res = ds.CheckLowerCaseRusLetters(strTest);           
            bool wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}   