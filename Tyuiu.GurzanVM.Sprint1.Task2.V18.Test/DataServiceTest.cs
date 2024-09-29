using Tyuiu.GurzanVM.Sprint1.Task2.V18.Lib;

namespace Tyuiu.GurzanVM.Sprint1.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Validexpression()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 2;
            int z = 3;
            var res = ds.CalculateSideSquareParallelepiped(x, y, z);
            Assert.AreEqual(5, res);
        }
    }
}