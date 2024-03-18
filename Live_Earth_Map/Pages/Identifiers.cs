using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Live_Earth_Map.Pages
{
    public class Identifiers
    {
        private AppiumDriver<IWebElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        //Constructor
        public Identifiers(AppiumDriver<IWebElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
        }


        //Methods
        public void FamousPlaces()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report 1");

            try
            {
                FamousPlace.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                BigBen.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                BurjKhalifa.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                BraindenBurg.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Kinderdijik.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Kaabah.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                Mountfuji.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                NatreDameDe.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                RomanForum.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                SaintBasils.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                StatueOf.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                Stonehenge.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                Colosseum.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                MachuPicchu.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                TowerBridge.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                SydneyOpera.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                TajMehel.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
        }
        public void SevenWondrs()
        {
            try
            {
                Petra.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                GreatWall.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                TajMahal.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                TheColloseum.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                TheMachu.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                ChichenItza.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                Christtheredeemer.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
        }
        public void USAPanorama()
        {
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
        }
        public void Germany()
        {
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
        }
        public void Pakistani()
        {
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
        }
        public void France()
        {
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
        }

        //Identifiers
        //Famous Places
        public IWebElement FamousPlace => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_places_bt");
        IWebElement Acropolos => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[1]");
        IWebElement BigBen => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[2]");
        IWebElement BurjKhalifa => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[3]");
        IWebElement BraindenBurg => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[4]");
        IWebElement Georges => driver.FindElementById("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[5]");
        IWebElement EiffelTower => driver.FindElementById("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[6]");
        IWebElement LondonEye => driver.FindElementById("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[7]");
        IWebElement Kinderdijik => driver.FindElementById("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[8]");
        IWebElement Louvire => driver.FindElementById("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[9]");
        IWebElement Kaabah => driver.FindElementById("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[1]");
        IWebElement Mountfuji => driver.FindElementById("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[2]");
        IWebElement NatreDameDe => driver.FindElementById("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[3]");
        IWebElement RomanForum => driver.FindElementById("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[4]");
        IWebElement SaintBasils => driver.FindElementById("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[5]");
        IWebElement StatueOf => driver.FindElementById("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[6]");
        IWebElement Stonehenge => driver.FindElementById("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[7]");
        IWebElement Colosseum => driver.FindElementById("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[8]");
        IWebElement MachuPicchu => driver.FindElementById("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[9]");
        IWebElement TowerBridge => driver.FindElementById("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[10]");
        IWebElement SydneyOpera => driver.FindElementById("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[11]");
        IWebElement TajMehel => driver.FindElementById("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[12]");

        //Seven Wonders
        IWebElement SevenWonders => driver.FindElementById("");
        IWebElement Petra => driver.FindElementById("");
        IWebElement GreatWall => driver.FindElementById("");
        IWebElement TajMahal => driver.FindElementById("");
        IWebElement TheColloseum => driver.FindElementById("");
        IWebElement TheMachu => driver.FindElementById("");
        IWebElement ChichenItza => driver.FindElementById("");
        IWebElement Christtheredeemer => driver.FindElementById("");

        IWebElement USAPanoramaMenu => driver.FindElementById("");
        //-------------------------------------------------------
        IWebElement NationalPark => driver.FindElementById("");

        IWebElement Antelope => driver.FindElementById("");
        IWebElement BellagioHotel => driver.FindElementById("");
        IWebElement DisneyKingdom => driver.FindElementById("");
        IWebElement DisneyWorld => driver.FindElementById("");
        IWebElement FloridaKeys => driver.FindElementById("");
        IWebElement GoldenGateBridge => driver.FindElementById("");
        IWebElement GrandCanyon => driver.FindElementById("");
        IWebElement GroundTetonPark => driver.FindElementById("");
        IWebElement LakeTahoe => driver.FindElementById("");
        IWebElement MagicKingdomPark => driver.FindElementById("");
        IWebElement MonumentValley => driver.FindElementById("");
        IWebElement Maui => driver.FindElementById("");
        IWebElement RedwoodNationaland => driver.FindElementById("");
        IWebElement SouthBeachFlorida => driver.FindElementById("");

        //-------------------------------------------------------
        IWebElement GermanyPanoramaMenu => driver.FindElementById("");
        IWebElement PakistaniPanoramaMenu => driver.FindElementById("");
        IWebElement FrancePanoramaMenu => driver.FindElementById("");
        IWebElement UKPanoramaMenu => driver.FindElementById("");
        IWebElement ItalyPanoramaMenu => driver.FindElementById("");



    }
}
