using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Live_Earth_Map.Pages
{

    class SatelliteMap
    {
        private AppiumDriver<AndroidElement>? driver;
        ReusableMethods ReusableMethods;

        // Constructor
        public SatelliteMap(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            ReusableMethods = new ReusableMethods(driver, test);
        }

        public void SatelliteMapModule()
        {
            ReusableMethods.ClickwithAd(SatelliteMapMenu, "Satellite Map Menu");

            //   ReusableMethods.HandleCBanner("C Banner Satellite Map Menu Module");

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
                ReusableMethods.HandleException("Search button", ex);
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
        }

        // Elements
        public IWebElement? SatelliteMapMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView"), "SatelliteMapMenu");
        public IWebElement? SearchText => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/editText_address"), "SearchText");
        public IWebElement? SearchButton => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/search_item"), "SearchButton");
        public IWebElement? MapStyleButton => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/layers_bt"), "MapStyleButton");
        public IWebElement? SatelliteMapview => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_sat"), "SatelliteMapview");
        public IWebElement? TerrainMap => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_terrain"), "TerrainMap");
        public IWebElement? TypicalMapView => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_typical"), "TypicalMapView");
        public IWebElement? CurrentLocationButton => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/location_btn"), "CurrentLocationButton");
        public IWebElement? ClearTextSearch => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/clear_bt"), "ClearTextSearch");
    }
}
