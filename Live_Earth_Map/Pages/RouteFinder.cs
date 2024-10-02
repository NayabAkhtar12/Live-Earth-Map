using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Live_Earth_Map.Pages
{
    class RouteFinder
    {
        private AppiumDriver<AndroidElement>? driver;
        ReusableMethods ReusableMethods;
        private ExtentTest Test;

        // Constructor
        public RouteFinder(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            ReusableMethods = new ReusableMethods(driver, test);
        }

        public void RouteFinderModule()
        {
            ReusableMethods.ClickwithAd(RouteFinderMenu, "Route Finder Menu");
            ReusableMethods.ElementClick(RouteMyLoc, "Route My Location");
            RouteMyDestination?.SendKeys("Kahuta");

            ReusableMethods.ElementClick(FindRouteBtn, "Find Route Button");
            Thread.Sleep(3000);

            ReusableMethods.ElementClick(MapStyleButton, "Map Style Button");
            ReusableMethods.ElementClick(TypicalMapView, "Typical Map View");
            Thread.Sleep(2000);

            ReusableMethods.ElementClick(SatelliteMapview, "Satellite Map View");
            Thread.Sleep(2000);

            ReusableMethods.ElementClick(TerrainMap, "Terrain Map");
            Thread.Sleep(2000);

            ReusableMethods.ElementClick(StartNavigation, "Start Navigation");
            Thread.Sleep(7000);

            ReusableMethods.NavigateBack("Back  Nav issue");
            ReusableMethods.NavigateBack("Back  Nav issue");
            Thread.Sleep(5000);

            ReusableMethods.NavigateBack("Back  Nav issue");
            ReusableMethods.NavigateBack("Back  Nav issue");
        }

        // Elements
        public IWebElement? RouteMyLoc => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/my_address_bt"), "RouteMyLoc");
        public IWebElement? RouteMyDestination => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/destination_search"), "RouteMyDestination");
        public IWebElement? StartNavigation => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/search"), "StartNavigation");
        public IWebElement? FindRouteBtn => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/search"), "FindRouteBtn");
        public IWebElement? RouteFinderMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/routeFinderBtn"), "RouteFinderMenu");
        public IWebElement? MapStyleButton => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/fab"), "MapStyleButton");
        public IWebElement? SatelliteMapview => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_sat"), "SatelliteMapview");
        public IWebElement? TerrainMap => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_terrain"), "TerrainMap");
        public IWebElement? TypicalMapView => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_typical"), "TypicalMapView");
        public IWebElement? CurrentLocationButton => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/my_location_bt"), "CurrentLocationButton");
        public IWebElement? ClearTextSearch => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/clear_bt"), "ClearTextSearch");
    }
}













//using AventStack.ExtentReports;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Appium;
//using OpenQA.Selenium.Appium.Android;
//using OpenQA.Selenium.Support.UI;

//namespace Live_Earth_Map.Pages
//{
//    class RouteFinder
//    {
//        private AppiumDriver<AndroidElement> driver;
//        private ExtentTest Test;
//        ExtentReports Extent = new ExtentReports();
//        AdHelper AdHelper;
//        //Constructor
//        public RouteFinder(AppiumDriver<AndroidElement> driver, ExtentTest test)
//        {
//            this.driver = driver;
//            this.Test = test;
//            this.AdHelper = new AdHelper(driver); // Initialize AdHelper with the correct driver type
//        }

//        public void RouteFinderModule1()
//        {
//            ExtentTest test = Extent.CreateTest("Report 1");
//            try
//            {
//                try
//                {
//                    RouteFinderMenu.Click();
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in RouteFinderMenu.Click(): {e.Message}");
//                }

//                Thread.Sleep(3000);

//                try
//                {
//                    AdHelper.HandleAd();
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in AdHelper.HandleAd(): {e.Message}");
//                }

//                Thread.Sleep(3000);

//                try
//                {
//                    RouteMyLoc.Click();
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in RouteMyLoc.Click(): {e.Message}");
//                }

//                try
//                {
//                    RouteMyDestination.SendKeys("Kahuta");
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in RouteMyDestination.SendKeys(\"Kahuta\"): {e.Message}");
//                }

//                try
//                {
//                    FindRouteBtn.Click();
//                    Thread.Sleep(5000);

//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in SearchButton.Click(): {e.Message}");
//                }


//                try
//                {
//                    MapStyleButton.Click();
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in MapStyleButton.Click(): {e.Message}");
//                }

//                Thread.Sleep(2000);

//                try
//                {
//                    TypicalMapView.Click();
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in TypicalMapView.Click(): {e.Message}");
//                }

//                Thread.Sleep(2000);

//                try
//                {
//                    SatelliteMapview.Click();
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in SatelliteMapview.Click(): {e.Message}");
//                }

//                Thread.Sleep(2000);

//                try
//                {
//                    TerrainMap.Click();
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in TerrainMap.Click(): {e.Message}");
//                }

//                Thread.Sleep(2000);

//                try
//                {
//                    StartNavigation.Click();
//                    Thread.Sleep(4000);
//                    driver.Navigate().Back();
//                    driver.Navigate().Back();
//                    Thread.Sleep(2000);

//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in CurrentLocationButton.Click(): {e.Message}");
//                }


//                try
//                {
//                    CurrentLocationButton.Click();
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in CurrentLocationButton.Click(): {e.Message}");
//                }

//                Thread.Sleep(2000);

//                try
//                {
//                    ClearTextSearch.Click();
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in ClearTextSearch.Click(): {e.Message}");
//                }

//                Thread.Sleep(2000);

//                try
//                {
//                    driver.Navigate().Back();
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in driver.Navigate().Back(): {e.Message}");
//                }

//            }

//            catch (Exception ex)
//            {
//                HandleException("Route Finder", ex);
//            }
//        }
//        public void RouteFinderModule()
//        {
//            ExtentTest test = Extent.CreateTest("Report 1");
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

//            try
//            {
//                try
//                {
//                    wait.Until(d => RouteFinderMenu.Displayed);  // Wait for RouteFinderMenu to be displayed
//                    RouteFinderMenu.Click();
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in RouteFinderMenu.Click(): {e.Message}");
//                }

//                // Explicit wait for any possible ads
//                try
//                {
//                    wait.Until(d => AdHelper.IsAdPresent());  // Check if ad is present
//                    AdHelper.HandleAd();
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in AdHelper.HandleAd(): {e.Message}");
//                }

//                try
//                {
//                    wait.Until(d => RouteMyLoc.Displayed);  // Wait for RouteMyLoc to be displayed
//                    RouteMyLoc.Click();
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in RouteMyLoc.Click(): {e.Message}");
//                }

//                try
//                {
//                    wait.Until(d => RouteMyDestination.Displayed);  // Wait for RouteMyDestination to be displayed
//                    RouteMyDestination.SendKeys("Kahuta");
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in RouteMyDestination.SendKeys(\"Kahuta\"): {e.Message}");
//                }

//                try
//                {
//                    wait.Until(d => FindRouteBtn.Displayed);  // Wait for SearchButton to be displayed
//                    FindRouteBtn.Click();
//                    Thread.Sleep(3000);
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in SearchButton.Click(): {e.Message}");
//                }

//                try
//                {
//                    wait.Until(d => MapStyleButton.Displayed);  // Wait for MapStyleButton to be displayed
//                    MapStyleButton.Click();
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in MapStyleButton.Click(): {e.Message}");
//                }

//                // Pause between map view changes
//                try
//                {
//                    wait.Until(d => TypicalMapView.Displayed);  // Wait for TypicalMapView to be displayed
//                    TypicalMapView.Click();
//                    Thread.Sleep(2000);  // Pause for 2 seconds before moving to the next map view
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in TypicalMapView.Click(): {e.Message}");
//                }

//                try
//                {
//                    wait.Until(d => SatelliteMapview.Displayed);  // Wait for SatelliteMapview to be displayed
//                    SatelliteMapview.Click();
//                    Thread.Sleep(2000);  // Pause for 2 seconds before moving to the next map view
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in SatelliteMapview.Click(): {e.Message}");
//                }

//                try
//                {
//                    wait.Until(d => TerrainMap.Displayed);  // Wait for TerrainMap to be displayed
//                    TerrainMap.Click();
//                    Thread.Sleep(2000);  // Pause for 2 seconds before moving to the next map view
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in TerrainMap.Click(): {e.Message}");
//                }

//                try
//                {
//                    wait.Until(d => StartNavigation.Displayed);  // Wait for TerrainMap to be displayed
//                    StartNavigation.Click();
//                    Thread.Sleep(5000);  // Pause for 2 seconds before moving to the next map view
//                    driver.Navigate().Back();
//                    driver.Navigate().Back();
//                    Thread.Sleep(5000);  // Pause for 2 seconds before moving to the next map view


//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"StartNavigation.Click(): {e.Message}");
//                }


//                //try
//                //{
//                //    wait.Until(d => ClearTextSearch.Displayed);  // Wait for ClearTextSearch to be displayed
//                //    ClearTextSearch.Click();
//                //}
//                //catch (Exception e)
//                //{
//                //    Console.WriteLine($"Error in ClearTextSearch.Click(): {e.Message}");
//                //}
//                //try
//                //{
//                //    wait.Until(d => CurrentLocationButton.Displayed);  // Wait for CurrentLocationButton to be displayed
//                //    CurrentLocationButton.Click();
//                //}
//                //catch (Exception e)
//                //{
//                //    Console.WriteLine($"Error in CurrentLocationButton.Click(): {e.Message}");
//                //}

//                try
//                {
//                    driver.Navigate().Back();
//                    driver.Navigate().Back();

//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine($"Error in driver.Navigate().Back(): {e.Message}");
//                }
//            }
//            catch (Exception ex)
//            {
//                HandleException("Route Finder", ex);
//            }
//        }

//        private void HandleException(string action, Exception ex)
//        {
//            Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
//            Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
//        }


//        //Elements
//        IWebElement RouteMyLoc => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/my_address_bt");
//        IWebElement RouteMyDestination => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/destination_search");
//        IWebElement StartNavigation => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/search");

//        IWebElement FindRouteBtn => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/search");

//        IWebElement RouteFinderMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/routeFinderBtn");

//        //Route Finder
//        IWebElement SearchText => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/editText_address");
//        IWebElement SearchButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/search_bt");

//        IWebElement MapStyleButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/fab");
//        IWebElement SatelliteMapview => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_sat");

//        IWebElement TerrainMap => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_terrain");
//        IWebElement TypicalMapView => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_typical");

//        IWebElement CurrentLocationButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/my_location_bt");

//        IWebElement ClearTextSearch => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/clear_bt");

//        public IWebElement BackButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/backButton");

//        public IWebElement School => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"School\"]");

//    }
//}
