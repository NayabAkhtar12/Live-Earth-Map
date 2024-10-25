using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Live_Earth_Map.Pages
{
    class TrafficMap
    {
        private AppiumDriver<AndroidElement> driver;
        ExtentReports Extent = new ExtentReports();
        ReusableMethods ReusableMethods;

        //Constructor
        public TrafficMap(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            ReusableMethods = new ReusableMethods(driver, test);

        }

        public void TrafficMapMod()
        {
            ReusableMethods.ClickwithAd(TrafficMapMenu, "Traffic Map Menu");

            // Scenario 1
            SearchText?.SendKeys("Gulistan Colony Lane 3");
            ReusableMethods.ElementClick(SearchButton, "Search Button - Scenario 1");

            ReusableMethods.ElementClick(MapStyleButton, "Map Style Button - Scenario 1");
            Thread.Sleep(2000);

            ReusableMethods.ElementClick(TypicalMapView, "Typical Map View - Scenario 1");
            Thread.Sleep(2000);

            ReusableMethods.ElementClick(SatelliteMapview, "Satellite Map View - Scenario 1");
            Thread.Sleep(2000);

            ReusableMethods.ElementClick(TerrainMap, "Terrain Map - Scenario 1");
            Thread.Sleep(2000);

            ReusableMethods.ElementClick(MapStyleButton, "Map Style Button - Scenario 2");

            ReusableMethods.ElementClick(ClearTextSearch, "Clear Search Text - Scenario 1");

            // Scenario 2
            SearchText?.SendKeys("Kahuta");
            Thread.Sleep(1000);

            try
            {
                ReusableMethods.ElementClick(SearchButton, "Search Button - Scenario 2");
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Search Button - Scenario 2", ex);
            }

            ReusableMethods.ElementClick(MapStyleButton, "Map Style Button - Scenario 2");
            Thread.Sleep(2000);

            ReusableMethods.ElementClick(TypicalMapView, "Typical Map View - Scenario 2");
            Thread.Sleep(2000);

            ReusableMethods.ElementClick(SatelliteMapview, "Satellite Map View - Scenario 2");
            Thread.Sleep(2000);

            ReusableMethods.ElementClick(TerrainMap, "Terrain Map - Scenario 2");
            Thread.Sleep(2000);

            ReusableMethods.ElementClick(ClearTextSearch, "Clear Search Text - Scenario 2");

            ReusableMethods.NavigateBack("Back to Previous Screen");

            // ReusableMethods.NavigateBack("Back  Nav issue");
            ReusableMethods.InterAdHandle();
        }


        //Elements
        public IWebElement? RouteMyLoc => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/my_address_bt"), "RouteMyLoc");
        public IWebElement? RouteMyDestination => ReusableMethods.FindElement(By.Id("om.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/destination_search"), "RouteMyDestination");
        public IWebElement? SatelliteMapMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView"), "SatelliteMapMenu");
        public IWebElement? RouteFinderMenu => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@text=\"Route Finder\"]"), "RouteFinderMenu");
        public IWebElement? AddressFinderMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView14"), "AddressFinderMenu");
        public IWebElement? NearbyPlacesMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView15"), "NearbyPlacesMenu");
        public IWebElement? TrafficMapMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/trafficMapBtn"), "TrafficMapMenu");
        public IWebElement? ParkingSpotMenu => ReusableMethods.FindElement(By.Id(""), "ParkingSpotMenu");
        public IWebElement? MyLocationMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView17"), "MyLocationMenu");
        public IWebElement? GPSCameraMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView18"), "GPSCameraMenu");
        public IWebElement? StreetViewmenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView19"), "StreetViewmenu");
        public IWebElement? FamousPlacesMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView14"), "FamousPlacesMenu");
        public IWebElement? MeasureAreamenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView25"), "MeasureAreamenu");
        public IWebElement? SolarInfoMenu => ReusableMethods.FindElement(By.Id(""), "SolarInfoMenu");
        public IWebElement? CurrencyConverterMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView21"), "CurrencyConverterMenu");
        public IWebElement? DailyLiveWeatherMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView22"), "DailyLiveWeatherMenu");
        public IWebElement? LanguagetranslatorMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView20"), "LanguagetranslatorMenu");
        public IWebElement? CompassMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView24"), "CompassMenu");
        public IWebElement? SpeedoMeterMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView23"), "SpeedoMeterMenu");
        public IWebElement? CountryInfoMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView26"), "CountryInfoMenu");
        public IWebElement? Premium => ReusableMethods.FindElement(By.Id(""), "Premium");
        public IWebElement? Menu => ReusableMethods.FindElement(By.Id(""), "Menu");
        public IWebElement? ChooseLanguage => ReusableMethods.FindElement(By.Id(""), "ChooseLanguage");
        public IWebElement? ApplyLanguage => ReusableMethods.FindElement(By.Id(""), "ApplyLanguage");
        public IWebElement? RateUs => ReusableMethods.FindElement(By.Id(""), "RateUs");
        public IWebElement? MoreApps => ReusableMethods.FindElement(By.Id(""), "MoreApps");
        public IWebElement? PrivacySettings => ReusableMethods.FindElement(By.Id(""), "PrivacySettings");
        public IWebElement? ReadPrivacyPolicyHere => ReusableMethods.FindElement(By.Id(""), "ReadPrivacyPolicyHere");
        public IWebElement? ExitApp => ReusableMethods.FindElement(By.Id(""), "ExitApp");
        public IWebElement? ExitAppYes => ReusableMethods.FindElement(By.Id(""), "ExitAppYes");
        public IWebElement? ExitAppNo => ReusableMethods.FindElement(By.Id(""), "ExitAppNo");
        // public IWebElement? MapTools => ReusableMethods.FindElement(By.AccessibilityId("Map tools"), "MapTools");

        public IWebElement? SearchText => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/search_for_traffic"), "SearchText");
        public IWebElement? SearchButton => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/search_bt"), "SearchButton");

        public IWebElement? MapStyleButton => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/fab"), "MapStyleButton");
        public IWebElement? SatelliteMapview => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_sat"), "SatelliteMapview");

        public IWebElement? TerrainMap => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_terrain"), "TerrainMap");
        public IWebElement? TypicalMapView => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_typical"), "TypicalMapView");

        public IWebElement? CurrentLocationButton => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/location_btn"), "CurrentLocationButton");

        public IWebElement? ClearTextSearch => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/clear_bt"), "ClearTextSearch");

        public IWebElement? School => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"School\"]"), "School");


    }
}
