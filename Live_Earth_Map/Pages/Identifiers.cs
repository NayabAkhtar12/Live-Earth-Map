using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Live_Earth_Map.Pages
{
    public class Identifiers
    {
        private AppiumDriver<IWebElement> driver;
        //Constructor
        public Identifiers(AppiumDriver<IWebElement> driver)
        {
            this.driver = driver;
        }


        //Methods
        public void Method1()
        {
            FamousPlaces.Click();
        }

        //Identifiers
        //Famous Places
        IWebElement FamousPlaces => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_places_bt");
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
        //Seven Wonders
        IWebElement USAPanorama => driver.FindElementById("");
        IWebElement GermanyPanorama => driver.FindElementById("");
        IWebElement PakistaniPanorama => driver.FindElementById("");
        IWebElement FrancePanorama => driver.FindElementById("");
        IWebElement UKPanorama => driver.FindElementById("");
        IWebElement ItalyPanorama => driver.FindElementById("");



    }
}
