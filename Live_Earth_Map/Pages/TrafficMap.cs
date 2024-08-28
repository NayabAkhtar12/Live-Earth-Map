using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace Live_Earth_Map.Pages
{
    class TrafficMap
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        AdHelper AdHelper;
        //Constructor
        public TrafficMap(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.AdHelper = new AdHelper(driver); // Initialize AdHelper with the correct driver type
        }


        public void TrafficMapMod()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            //try
            //{
            //    TrafficMapMenu.Click();
            //    Thread.Sleep(3000);
            //    AdHelper.HandleAd();
            //    Thread.Sleep(3000);
            //    driver.Navigate().Back();

            //}
            try
            {
                try
                {
                    TrafficMapMenu.Click();
                }
                catch (Exception ex)
                {
                    HandleException("TrafficMapMenu Scenario 1 - TrafficMapMenu.Click", ex);
                }

                //Thread.Sleep(5000);

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
                    HandleException("Traffic  Map Scenario 1 - SearchText.SendKeys", ex);
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
        IWebElement RouteMyLoc => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/my_address_bt");
        IWebElement RouteMyDestination => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/destination_search");

        IWebElement SatelliteMapMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView");

        IWebElement RouteFinderMenu => driver.FindElementByXPath("//android.widget.TextView[@text=\"Route Finder\"]");
        IWebElement AddressFinderMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView14");

        IWebElement NearbyPlacesMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView15");
        IWebElement TrafficMapMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/trafficMapBtn");
        IWebElement ParkingSpotMenu => driver.FindElementById("");
        IWebElement MyLocationMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView17");
        IWebElement GPSCameraMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView18");
        IWebElement StreetViewmenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView19");
        IWebElement FamousPlacesMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView14");
        IWebElement MeasureAreamenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView25");
        IWebElement SolarInfoMenu => driver.FindElementById("");
        IWebElement CurrencyConverterMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView21");
        IWebElement DailyLiveWeatherMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView22");
        IWebElement LanguagetranslatorMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView20");
        IWebElement CompassMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView24");
        IWebElement SpeedoMeterMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView23");
        IWebElement CountryInfoMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView26");
        IWebElement Premium => driver.FindElementById("");
        IWebElement Menu => driver.FindElementById("");
        IWebElement ChooseLanguage => driver.FindElementById("");
        IWebElement ApplyLanguage => driver.FindElementById("");
        IWebElement RateUs => driver.FindElementById("");
        IWebElement MoreApps => driver.FindElementById("");
        IWebElement PrivacySettings => driver.FindElementById("");
        IWebElement ReadPrivacyPolicyHere => driver.FindElementById("");
        IWebElement ExitApp => driver.FindElementById("");
        IWebElement ExitAppYes => driver.FindElementById("");
        IWebElement ExitAppNo => driver.FindElementById("");
        IWebElement MapTools => driver.FindElementByAccessibilityId("Map tools");

        IWebElement SearchText => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/search_for_traffic");
        IWebElement SearchButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/search_bt");

        IWebElement MapStyleButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/fab");
        IWebElement SatelliteMapview => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_sat");

        IWebElement TerrainMap => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_terrain");
        IWebElement TypicalMapView => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_typical");

        IWebElement CurrentLocationButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/location_btn");

        IWebElement ClearTextSearch => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/clear_bt");

        public IWebElement BackButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/backButton");


        [Obsolete]
        private void Back()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//android.widget.Button[@content-desc=\"Back\"]/android.widget.ImageView")));
            element.Click();
        }

        public IWebElement School => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"School\"]");

    }
}
