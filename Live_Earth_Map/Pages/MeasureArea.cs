using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace Live_Earth_Map.Pages
{
    class MeasureArea
    {
        private AppiumDriver<AndroidElement> driver;
        ExtentReports Extent = new ExtentReports();
        ReusableMethods ReusableMethods;

        //Constructor
        public MeasureArea(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            ReusableMethods = new ReusableMethods(driver, test);
        }



        public void MeasureAreaMethod()
        {
            // Create the test report
            ExtentTest test = Extent.CreateTest("Report 1");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Click on the Measure Area Menu with ad handling
            ReusableMethods.ClickwithAd(MeasureAreaMenu, "Measure Area Menu");

            // Wait for the Add Parking Spot element to be displayed
            wait.Until(d => AddParkingSpot.Displayed);
            ReusableMethods.ElementClick(AddParkingSpot, "Add Parking Spot");

            // Click on the Add Bus button
            ReusableMethods.ElementClick(Addbus, "Add Bus Button");

            // Click on the Save Parking button and wait for 3 seconds
            ReusableMethods.ElementClick(AddParkingtoSave, "Save Parking Button");
            Thread.Sleep(3000); // Wait for any actions to complete

            // Navigate back to the previous screen
            ReusableMethods.NavigateBack("Navigation Back from Measure Area");
        }





        //Elements
        IWebElement AddParkingSpot => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/addParkingBtn");
        IWebElement Addbus => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/radio_bus");
        IWebElement AddParkingtoSave => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/save_btn");

        public IWebElement? MeasureAreaMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/areaBtn"), "MeasureAreaMenu");


    }
}
