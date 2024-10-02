using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Live_Earth_Map.Pages
{
    class SolarInfo
    {

        private AppiumDriver<AndroidElement> driver;
        ExtentReports Extent = new ExtentReports();
        ReusableMethods ReusableMethods;

        //Constructor
        public SolarInfo(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            ReusableMethods = new ReusableMethods(driver, test);
        }

        public void SolarInfoMethod()
        {
            // Click on the Solar Info Menu with ad handling
            ReusableMethods.ClickwithAd(SolarInfoMenu, "Solar Info Menu");
            Thread.Sleep(3000); // Wait for any loading effects
            ReusableMethods.NavigateBack("Navigation Back from Solar Info"); // Navigate back
        }

        // Elements
        public IWebElement? SolarInfoMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/solarBtn"), "SolarInfoMenu");
    }
}





