using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace Live_Earth_Map.Pages
{
    class SolarInfo
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        AdHelper AdHelper;
        //Constructor
        public SolarInfo(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.AdHelper = new AdHelper(driver); // Initialize AdHelper with the correct driver type
        }

        public void SolarInfoMethod()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            try
            {
                try
                {
                    ParkingSpotMenu.Click();
                }
                catch (Exception ex)
                {
                    HandleException("ParkingSpotMenu Scenario 1 - ParkingSpotMenu.Click", ex);
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
                    HandleException("AddressFinder Scenario 1 - AdHelper.HandleAd", ex);
                }

                Thread.Sleep(3000);

                try
                {
                    wait.Until(d => AddParkingSpot.Displayed);

                    AddParkingSpot.Click();
                }
                catch (Exception ex)
                {
                    HandleException("Add Button -", ex);
                }

                try
                {
                    Addbus.Click();

                }
                catch (Exception ex)
                {
                    HandleException("Add Bus - Click", ex);
                }

                try
                {
                    AddParkingtoSave.Click();
                    Thread.Sleep(3000);
                }
                catch (Exception ex)
                {
                    HandleException(" Save Parking - Click", ex);
                }
            }
            catch (Exception ex)
            {
                HandleException("Address Finder", ex);
            }

            driver.Navigate().Back();

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
        IWebElement TrafficMapMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView16");
        IWebElement ParkingSpotMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/parkingBtn");
        IWebElement AddParkingSpot => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/addParkingBtn");
        IWebElement Addbus => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/radio_bus");
        IWebElement AddParkingtoSave => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/save_btn");

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

        IWebElement SearchText => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/editText_address");
        IWebElement SearchButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/search_item");

        IWebElement MapStyleButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/layers_bt");
        IWebElement SatelliteMapview => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_sat");

        IWebElement TerrainMap => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_terrain");
        IWebElement TypicalMapView => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_typical");

        IWebElement CurrentLocationButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/location_btn");

        IWebElement ClearTextSearch => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/clear_bt");

        public IWebElement BackButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/backButton");




    }
}
