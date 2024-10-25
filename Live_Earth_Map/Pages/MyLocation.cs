using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Live_Earth_Map.Pages
{
    class MyLocation
    {
        private AppiumDriver<AndroidElement> driver;
        ExtentReports Extent = new ExtentReports();
        ReusableMethods ReusableMethods;

        //Constructor
        public MyLocation(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            ReusableMethods = new ReusableMethods(driver, test);

        }

        public void MyLocationMethod()
        {
            ReusableMethods.ScrollToElementByText("My Location");

            // Click on the My Location Menu with ad handling
            ReusableMethods.ClickwithAd(MyLocationMenu, "My Location Menu");

            // Wait for 3 seconds to ensure the ad is handled
            Thread.Sleep(3000);

            // Click on the Map Style Button and wait for 2 seconds
            ReusableMethods.ElementClick(MapStyleButton, "Map Style Button");
            Thread.Sleep(2000);

            // Click on the Typical Map View and wait for 2 seconds
            ReusableMethods.ElementClick(TypicalMapView, "Typical Map View");
            Thread.Sleep(2000);

            // Click on the Satellite Map View and wait for 2 seconds
            ReusableMethods.ElementClick(SatelliteMapView, "Satellite Map View");
            Thread.Sleep(2000);

            // Click on the Terrain Map and wait for 2 seconds, then navigate back
            ReusableMethods.ElementClick(TerrainMap, "Terrain Map");
            Thread.Sleep(2000);
            ReusableMethods.NavigateBack("Navigation Back from Terrain Map");
            //    ReusableMethods.NavigateBack("Back  Nav issue");
            ReusableMethods.InterAdHandle();
        }



        //Elements

        public IWebElement? MyLocationMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/myLocationBtn"), "MyLocationMenu");
        public IWebElement? MapStyleButton => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/fab"), "MapStyleButton");
        public IWebElement? SatelliteMapView => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_sat"), "SatelliteMapView");
        public IWebElement? TerrainMap => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_terrain"), "TerrainMap");
        public IWebElement? TypicalMapView => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_typical"), "TypicalMapView");
        public IWebElement? BackButton => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/backButton"), "BackButton");
        public IWebElement? School => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"School\"]"), "School");

    }
}
