using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Live_Earth_Map.Pages
{
    class MyLocation
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        AdHelper AdHelper;
        //Constructor
        public MyLocation(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.AdHelper = new AdHelper(driver); // Initialize AdHelper with the correct driver type
        }


        public void MyLocationMethod()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                try
                {
                    MyLocationMenu.Click();
                }
                catch (Exception ex)
                {
                    HandleException("MyLocation Scenario 1 - MyLocation.Click", ex);
                }


                try
                {
                    if (AdHelper.IsAdPresent())
                    {
                        AdHelper.HandleAd();
                    }
                }
                catch (Exception ex)
                {
                    HandleException("MyLocation  Scenario 1 - AdHelper.HandleAd", ex);
                }

                Thread.Sleep(3000);

                try
                {
                    MapStyleButton.Click();
                    Thread.Sleep(2000);
                }
                catch (Exception ex)
                {
                    HandleException("Satellite Map Scenario 1 - MapStyleButton.Click", ex);
                }

                try
                {
                    TypicalMapView.Click();
                    Thread.Sleep(2000);
                }
                catch (Exception ex)
                {
                    HandleException("Satellite Map Scenario 1 - TypicalMapView.Click", ex);
                }

                try
                {
                    SatelliteMapview.Click();
                    Thread.Sleep(2000);
                }
                catch (Exception ex)
                {
                    HandleException("Satellite Map Scenario 1 - SatelliteMapview.Click", ex);
                }

                try
                {
                    TerrainMap.Click();
                    Thread.Sleep(2000);
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    HandleException("Satellite Map Scenario 1 - TerrainMap.Click", ex);
                }
            }
            catch (Exception ex)
            {
                HandleException("Satellite Map Scenario", ex);
            }
        }

        private void HandleException(string action, Exception ex)
        {
            Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
            Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
        }


        //Elements

        IWebElement MyLocationMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/myLocationBtn");
        IWebElement MapStyleButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/fab");
        IWebElement SatelliteMapview => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_sat");

        IWebElement TerrainMap => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_terrain");
        IWebElement TypicalMapView => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_typical");
        public IWebElement BackButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/backButton");
        public IWebElement School => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"School\"]");

    }
}
