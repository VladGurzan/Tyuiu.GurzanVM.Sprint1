using Tyuiu.GurzanVM.Sprint1.Task3.V12.Lib;

namespace Tyuiu.GurzanVM.Sprint1.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 3;
            var res = ds.TriangleArea(x, y);
            Assert.AreEqual(wait, res); 
        }
    }
}