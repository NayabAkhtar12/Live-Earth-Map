using AventStack.ExtentReports;
using Live_Earth_Map.Core;
using Live_Earth_Map.Pages;

namespace Live_Earth_Map.Test_Class
{
    [TestClass]
    public class Test_Class : TestInitiallize
    {
        Identifiers Id;
        [TestMethod]
        public void StreetView()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            Id = new Identifiers(driver, test);
            Id.FamousPlaces();
        }
    }
}
