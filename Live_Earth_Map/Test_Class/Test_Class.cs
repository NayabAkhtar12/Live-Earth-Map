using AventStack.ExtentReports;
using Live_Earth_Map.Core;
using Live_Earth_Map.Pages;

namespace Live_Earth_Map.Test_Class
{
    [TestClass]
    public class Test_Class : TestInitiallize
    {
        StreetView SV;

        NearByPlaces Airport;
        //   [TestMethod]
        public void NearByPlaces()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            Airport = new NearByPlaces(driver, test);
            Airport.NearByPlacesHome();
        }

        [TestMethod]
        public void StreetView()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            SV = new StreetView(driver, test);
            SV.FamousPlaces();
            // SV.SevenWondrs();
        }
    }
}
