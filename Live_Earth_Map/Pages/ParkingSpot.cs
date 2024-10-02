using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Live_Earth_Map.Pages
{
    class ParkingSpot
    {
        private AppiumDriver<AndroidElement> driver;
        ExtentReports Extent = new ExtentReports();
        ReusableMethods ReusableMethods;

        //Constructor
        public ParkingSpot(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            ReusableMethods = new ReusableMethods(driver, test);

        }

        public void ParkingSpotMethod()
        {
            ReusableMethods.ClickwithAd(ParkingSpotMenu, "Parking Spot Menu");

            // Scenario 1

            ReusableMethods.ElementClick(AddParkingSpot, "Add Parking Spot Button - Scenario 1");
            ReusableMethods.ElementClick(AddBus, "Add Bus Button - Scenario 1");

            ReusableMethods.ElementClick(AddParkingtoSave, "Save Parking Button - Scenario 1");
            Thread.Sleep(3000);

            // Navigate back to the previous screen
            ReusableMethods.NavigateBack("Back to Previous Screen");
        }


        //Elements



        IWebElement? ParkingSpotMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/parkingBtn"), "ParkingSpotMenu");

        IWebElement? AddParkingSpot => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/addParkingBtn"), "AddParkingSpot");

        IWebElement? AddBus => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/radio_bus"), "AddBus");

        IWebElement? AddParkingtoSave => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/save_btn"), "AddParkingToSave");

    }
}
