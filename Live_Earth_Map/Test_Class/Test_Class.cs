using Live_Earth_Map.Core;
using Live_Earth_Map.Pages;

namespace Live_Earth_Map.Test_Class
{
    [TestClass]
    public class Test_Class : TestInitiallize
    {

        [TestMethod]
        public void m1()
        {
            var Id = new Identifiers(driver);
            Id.Method1();
        }
    }
}
