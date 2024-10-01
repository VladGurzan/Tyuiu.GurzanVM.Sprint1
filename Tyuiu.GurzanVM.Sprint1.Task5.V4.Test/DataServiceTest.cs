using Tyuiu.GurzanVM.Sprint1.Task5.V4.Lib;

namespace Tyuiu.GurzanVM.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double time = 3600;
            DataService ds = new DataService();
            double res = ds.SecondsToHours(12000);

            int result = Convert.ToInt32(res);

            int wait = 3;
            Assert.AreEqual(wait, result);
        }
    }
}