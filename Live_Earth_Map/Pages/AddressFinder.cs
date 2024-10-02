using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Live_Earth_Map.Pages
{
    class AddressFinder
    {
        private AppiumDriver<AndroidElement> driver;
        ExtentReports Extent = new ExtentReports();
        ReusableMethods ReusableMethods;

        //Constructor
        public AddressFinder(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            ReusableMethods = new ReusableMethods(driver, test);
        }

        public void AddressFinderModule()
        {
            ReusableMethods.ClickwithAd(AddressFinderMenu, "Address Finder Menu");

            RouteMyLoc?.SendKeys("Kahuta");

            ReusableMethods.ElementClick(FindThisAddress, "Find Route Button");
            Thread.Sleep(3000);

            ReusableMethods.ElementClick(MapStyleButton, "Map Style Button");
            ReusableMethods.ElementClick(TypicalMapView, "Typical Map View");
            Thread.Sleep(2000);

            ReusableMethods.ElementClick(SatelliteMapview, "Satellite Map View");
            Thread.Sleep(2000);

            ReusableMethods.ElementClick(TerrainMap, "Terrain Map");
            Thread.Sleep(2000);

            ReusableMethods.NavigateBack("Back  Nav issue");
            ReusableMethods.NavigateBack("Back  Nav issue");
        }


        // Elements
        public IWebElement? RouteMyLoc => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/source_search"), "RouteMyLoc");
        public IWebElement? AddressFinderMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView14"), "AddressFinderMenu");
        public IWebElement? FindThisAddress => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/search"), "FindThisAddress");
        public IWebElement? Location => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/search_item"), "Location");

        public IWebElement? MapStyleButton => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/layers_bt"), "MapStyleButton");
        public IWebElement? SatelliteMapview => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_sat"), "SatelliteMapview");

        public IWebElement? TerrainMap => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_terrain"), "TerrainMap");
        public IWebElement? TypicalMapView => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_typical"), "TypicalMapView");

        public IWebElement? CurrentLocationButton => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/location_btn"), "CurrentLocationButton");

        public IWebElement? ClearTextSearch => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/clear_bt"), "ClearTextSearch");
    }
}
