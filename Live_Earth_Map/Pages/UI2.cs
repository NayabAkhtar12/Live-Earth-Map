﻿using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;

namespace Live_Earth_Map.Pages
{
    class UI2
    {
        private AppiumDriver<IWebElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        //Constructor
        public UI2(AppiumDriver<IWebElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
        }

        public void SatelliteMapModule()
        {
            ExtentTest test = Extent.CreateTest("NearBy Places Report 1");
            try
            {
                SatelliteMapMenu.Click();
                SearchText.SendKeys("Gulistan Colony Lane 3");
                SearchButton.Click();
                Thread.Sleep(1000);
                MapStyleButton.Click();
                TypicalMapView.Click();
                SatelliteMapview.Click();
                TerrainMap.Click();
                CurrentLocationButton.Click();
                ClearTextSearch.Click();
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            //try
            //{
            //    SearchText.SendKeys("Kahuta");
            //    SearchButton.Click();
            //    Thread.Sleep(1000);
            //    MapStyleButton.Click();
            //    TypicalMapView.Click();
            //    SatelliteMapview.Click();
            //    TerrainMap.Click();
            //    CurrentLocationButton.Click();
            //    ClearTextSearch.Click();
            //}
            //catch (Exception ex)
            //{
            //    HandleException("Satellite Map", ex);
            //}
        }

        public void RouteFinder()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                RouteFinderMenu.Click();
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("Route Finder", ex);
            }
        }
        public void AddressFinder()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                AddressFinderMenu.Click();
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("Address Finder", ex);
            }
        }
        public void NearbyPlaces()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                NearbyPlacesMenu.Click();
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
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("TrafficMapMenu", ex);
            }
        }
        public void MyLocation()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                MyLocationMenu.Click();
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
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("StreetViewmenu", ex);
            }
        }

        //Map tools
        public void MeasureArea()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                MapTools.Click();
                MeasureAreamenu.Click();
                driver.Navigate().Back();
            }

            catch (Exception ex)
            {
                HandleException("MeasureAreamenu", ex);
            }
        }
        public void FamousPlaces()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                FamousPlacesMenu.Click();
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("FamousPlacesMenu", ex);
            }
        }

        public void LanguageTranslator()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                LanguagetranslatorMenu.Click();
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("LanguageTranslator", ex);
            }
        }
        public void CountryInfo()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                CountryInfoMenu.Click();
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("CountryInfoMenu", ex);
            }
        }

        public void CurrencyConverter()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                CurrencyConverterMenu.Click();
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
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("DailyLiveWeatherMenu", ex);
            }
        }
        public void SpeedoMeter()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                SpeedoMeterMenu.Click();
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
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("Compass", ex);
            }
        }


        public void ParkingSpot()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                ParkingSpotMenu.Click();
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("ParkingSpotMenu", ex);
            }
        }


        public void SolarInfo()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            try
            {
                SolarInfoMenu.Click();
                driver.Navigate().Back();

            }

            catch (Exception ex)
            {
                HandleException("SolarInfomenu", ex);
            }
        }


        private void HandleException(string action, Exception ex)
        {
            Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
            Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
        }


        //Elements
        IWebElement SatelliteMapMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView");

        IWebElement RouteFinderMenu => driver.FindElementByXPath("//android.widget.TextView[@text=\"Route Finder\"]");
        IWebElement AddressFinderMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView14");

        IWebElement NearbyPlacesMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView15");
        IWebElement TrafficMapMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView16");
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
