using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace Live_Earth_Map.Pages
{
    class UserInterface1
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        AdHelper AdHelper;
        //Constructor
        public UserInterface1(AppiumDriver<AndroidElement> driver, ExtentTest test)
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
                SatelliteMapMenu.Click();
                if (AdHelper.IsAdPresent())
                {
                    AdHelper.HandleAd();
                }
                Thread.Sleep(3000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
        }
        public void RouteFinder()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                try
                {
                    RouteFinderMenu.Click();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error in RouteFinderMenu.Click(): {e.Message}");
                }


                try
                {
                    if (AdHelper.IsAdPresent())
                    {
                        AdHelper.HandleAd();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error in AdHelper.HandleAd(): {e.Message}");
                }

                Thread.Sleep(3000);

                try
                {
                    driver.Navigate().Back();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error in driver.Navigate().Back(): {e.Message}");
                }

            }

            catch (Exception ex)
            {
                HandleException("Route Finder", ex);
            }
        }
        public void NearbyPlaces()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                NearbyPlacesMenu.Click();
                if (AdHelper.IsAdPresent())
                {
                    AdHelper.HandleAd();
                }
                Thread.Sleep(3000);
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("Nearby PLaces", ex);
            }
        }
        public void TrafficMap()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                TrafficMapMenu.Click();
                // Thread.Sleep(3000);
                if (AdHelper.IsAdPresent())
                {
                    AdHelper.HandleAd();
                }
                Thread.Sleep(3000);
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("TrafficMapMenu", ex);
            }
        }
        public void AddressFinder()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                AddressFinderMenu.Click();
                // Thread.Sleep(3000);
                if (AdHelper.IsAdPresent())
                {
                    AdHelper.HandleAd();
                }
                Thread.Sleep(3000);
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("Address Finder", ex);
            }
        }
        public void ParkingSpotModule()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                ParkingSpotMenu.Click();
                //     Thread.Sleep(3000);
                if (AdHelper.IsAdPresent())
                {
                    AdHelper.HandleAd();
                }
                Thread.Sleep(3000);
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("ParkingSpotMenu", ex);
            }
        }
        public void MyLocation()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                MyLocationMenu.Click();
                //    Thread.Sleep(3000);
                if (AdHelper.IsAdPresent())
                {
                    AdHelper.HandleAd();
                }
                Thread.Sleep(3000);
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("MyLocationMenu", ex);
            }
        }
        public void GPSCamera()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                GPSCameraMenu.Click();
                Thread.Sleep(3000);
                if (AdHelper.IsAdPresent())
                {
                    AdHelper.HandleAd();
                }
                Thread.Sleep(3000);
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("GPSCameraMenu", ex);
            }
        }
        public void Streeview()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                StreetViewmenu.Click();
                //      Thread.Sleep(3000);
                if (AdHelper.IsAdPresent())
                {
                    AdHelper.HandleAd();
                }
                Thread.Sleep(3000);
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("StreetViewmenu", ex);
            }
        }
        public void FamousPlaces()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                FamousPlacesMenu.Click();
                //     Thread.Sleep(3000);
                if (AdHelper.IsAdPresent())
                {
                    AdHelper.HandleAd();
                }
                Thread.Sleep(3000);
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("FamousPlacesMenu", ex);
            }
        }
        public void MeasureArea()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                MeasureAreamenu.Click();
                //    Thread.Sleep(3000);
                if (AdHelper.IsAdPresent())
                {
                    AdHelper.HandleAd();
                }
                Thread.Sleep(3000);
                driver.Navigate().Back();
            }

            catch (Exception ex)
            {
                HandleException("MeasureAreamenu", ex);
            }
        }
        public void SolarInfo()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                SolarInfoMenu.Click();
                //   Thread.Sleep(3000);
                if (AdHelper.IsAdPresent())
                {
                    AdHelper.HandleAd();
                }
                Thread.Sleep(3000);
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("SolarInfomenu", ex);
            }
        }
        public void CurrencyConverter()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                CurrencyConverterMenu.Click();
                //       Thread.Sleep(3000);
                if (AdHelper.IsAdPresent())
                {
                    AdHelper.HandleAd();
                }
                Thread.Sleep(3000);
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("CurrencyConverterMenu", ex);
            }
        }
        public void DailyLiveWeather()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                DailyLiveWeatherMenu.Click();
                //    Thread.Sleep(3000);
                if (AdHelper.IsAdPresent())
                {
                    AdHelper.HandleAd();
                }
                Thread.Sleep(3000);
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("DailyLiveWeatherMenu", ex);
            }
        }
        public void LanguageTranslator()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                LanguagetranslatorMenu.Click();
                //  Thread.Sleep(3000);
                if (AdHelper.IsAdPresent())
                {
                    AdHelper.HandleAd();
                }
                Thread.Sleep(3000);
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("LanguageTranslator", ex);
            }
        }
        public void SpeedoMeter()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                SpeedoMeterMenu.Click();
                //   Thread.Sleep(3000);
                if (AdHelper.IsAdPresent())
                {
                    AdHelper.HandleAd();
                }
                Thread.Sleep(3000);
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("SpeedoMeterMenu", ex);
            }
        }
        public void Compass()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                CompassMenu.Click();
                //   Thread.Sleep(3000);
                if (AdHelper.IsAdPresent())
                {
                    AdHelper.HandleAd();
                }
                Thread.Sleep(3000);
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("Compass", ex);
            }
        }
        public void CountryInfo()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                CountryInfoMenu.Click();
                //    Thread.Sleep(3000);
                if (AdHelper.IsAdPresent())
                {
                    AdHelper.HandleAd();
                }
                Thread.Sleep(3000);
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("CountryInfoMenu", ex);
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

        IWebElement SatelliteMapMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/sateliteBtn");

        IWebElement RouteFinderMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/routeFinderBtn");
        IWebElement AddressFinderMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/addressFinderBtn");

        IWebElement NearbyPlacesMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/nearbyPlacesBtn");
        IWebElement TrafficMapMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/trafficMapBtn");
        IWebElement ParkingSpotMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/parkingBtn");
        IWebElement MyLocationMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/myLocationBtn");
        IWebElement GPSCameraMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/gpsCameraBtn");
        IWebElement StreetViewmenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/streetViewBtn");
        IWebElement FamousPlacesMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famousplacesBtn");
        IWebElement MeasureAreamenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/areaBtn");
        IWebElement SolarInfoMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/solarBtn");
        IWebElement CurrencyConverterMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/currencyBtn");
        IWebElement DailyLiveWeatherMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/weatherBtn");
        IWebElement LanguagetranslatorMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/translatorBtn");
        IWebElement CompassMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/compassBtn");
        IWebElement SpeedoMeterMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/speedometerBtn");
        IWebElement CountryInfoMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/countryInfoBtn");
        IWebElement Premium => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/premiumBtn");
        IWebElement PremiumCrossButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/premiumBtn");

        IWebElement Menu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/menuBtn");
        IWebElement ChooseLanguage => driver.FindElementById("");
        IWebElement ApplyLanguage => driver.FindElementById("");
        IWebElement RateUs => driver.FindElementByXPath("//android.widget.TextView[@text=\"Rate us\"]");
        IWebElement MoreApps => driver.FindElementByXPath("//android.widget.TextView[@text=\"More apps\"]");
        IWebElement PrivacySettings => driver.FindElementByXPath("//android.widget.TextView[@text=\"Privacy Settings\"]");
        IWebElement ReadPrivacyPolicyHere => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/privacyPolicyBtn");
        IWebElement ExitApp => driver.FindElementByXPath("//android.widget.TextView[@text=\"Exit App\"]");
        IWebElement ExitAppYes => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/exit");
        IWebElement ExitAppNo => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/cancel");
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
