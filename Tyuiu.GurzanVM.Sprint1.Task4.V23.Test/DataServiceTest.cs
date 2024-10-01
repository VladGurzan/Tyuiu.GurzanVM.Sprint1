using Tyuiu.GurzanVM.Sprint1.Task4.V23.Lib;

namespace Tyuiu.GurzanVM.Sprint1.Task4.V23.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        double x = 7;
        double y = 9;
        double wait = 1;
        var res = ds.Calculate(x, y);
        Assert.AreEqual(wait, res);
    }
}