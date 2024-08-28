using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Live_Earth_Map.Pages
{
    class SatelliteMap
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        AdHelper AdHelper;
        //Constructor
        public SatelliteMap(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.AdHelper = new AdHelper(driver); // Initialize AdHelper with the correct driver type
        }

        public void SatelliteMapModule()
        {
            ExtentTest test = Extent.CreateTest("NearBy Places Report 1");
            try
            {
                try
                {
                    SatelliteMapMenu.Click();
                }
                catch (Exception ex)
                {
                    HandleException("Satellite Map Scenario 1 - SatelliteMapMenu.Click", ex);
                }

                Thread.Sleep(3000);

                try
                {
                    if (AdHelper.IsAdPresent())
                    {
                        AdHelper.HandleAd();
                    }
                }
                catch (Exception ex)
                {
                    HandleException("Satellite Map Scenario 1 - AdHelper.HandleAd", ex);
                }

                Thread.Sleep(3000);

                try
                {
                    SearchText.SendKeys("Gulistan Colony Lane 3");
                }
                catch (Exception ex)
                {
                    HandleException("Satellite Map Scenario 1 - SearchText.SendKeys", ex);
                }

                try
                {
                    SearchButton.Click();
                }
                catch (Exception ex)
                {
                    HandleException("Satellite Map Scenario 1 - SearchButton.Click", ex);
                }

                Thread.Sleep(1000);

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
                }
                catch (Exception ex)
                {
                    HandleException("Satellite Map Scenario 1 - TerrainMap.Click", ex);
                }

                try
                {
                    CurrentLocationButton.Click();
                    Thread.Sleep(2000);
                }
                catch (Exception ex)
                {
                    HandleException("Satellite Map Scenario 1 - CurrentLocationButton.Click", ex);
                }

                try
                {
                    ClearTextSearch.Click();
                }
                catch (Exception ex)
                {
                    HandleException("Satellite Map Scenario 1 - ClearTextSearch.Click", ex);
                }
            }
            catch (Exception ex)
            {
                HandleException("Satellite Map Scenario 1", ex);
            }
            ClearTextSearch.Click();

            //Scenario 2
            try
            {
                try
                {
                    SearchText.SendKeys("Kahuta");
                    Thread.Sleep(1000);

                }
                catch (Exception ex)
                {
                    HandleException("Satellite Map Scenario 2 - SearchText.SendKeys", ex);
                }
                try
                {
                    SearchButton.Click();
                    Thread.Sleep(2000);
                }
                catch (Exception ex)
                {
                    HandleException("Satellite Map Scenario 1 - SearchButton.Click", ex);
                }


                Thread.Sleep(1000);

                try
                {
                    MapStyleButton.Click();
                    Thread.Sleep(2000);
                }
                catch (Exception ex)
                {
                    HandleException("Satellite Map Scenario 2 - MapStyleButton.Click", ex);
                }

                try
                {
                    TypicalMapView.Click();
                    Thread.Sleep(2000);
                }
                catch (Exception ex)
                {
                    HandleException("Satellite Map Scenario 2 - TypicalMapView.Click", ex);
                }

                try
                {
                    SatelliteMapview.Click();
                    Thread.Sleep(2000);
                }
                catch (Exception ex)
                {
                    HandleException("Satellite Map Scenario 2 - SatelliteMapview.Click", ex);
                }

                try
                {
                    TerrainMap.Click();
                    Thread.Sleep(2000);
                }
                catch (Exception ex)
                {
                    HandleException("Satellite Map Scenario 2 - TerrainMap.Click", ex);
                }

                try
                {
                    ClearTextSearch.Click();
                }
                catch (Exception ex)
                {
                    HandleException("Satellite Map Scenario 2 - ClearTextSearch.Click", ex);
                }
            }
            catch (Exception ex)
            {
                HandleException("Satellite Map Scenario 2", ex);
            }
            try
            {
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Satellite Map Scenario 1 - driver.Navigate().Back", ex);
            }

        }

        private void HandleException(string action, Exception ex)
        {
            Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
            Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
        }


        //Elements

        IWebElement SatelliteMapMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView");
        IWebElement MapTools => driver.FindElementByAccessibilityId("Map tools");

        IWebElement SearchText => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/editText_address");
        IWebElement SearchButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/search_item");

        IWebElement MapStyleButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/layers_bt");
        IWebElement SatelliteMapview => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_sat");

        IWebElement TerrainMap => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_terrain");
        IWebElement TypicalMapView => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_typical");

        IWebElement CurrentLocationButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/location_btn");

        IWebElement ClearTextSearch => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/clear_bt");




    }
}
