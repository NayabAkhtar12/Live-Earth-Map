using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace Live_Earth_Map.Pages
{
    class FamousPlaces
    {
        private AppiumDriver<AndroidElement> driver;
        ReusableMethods ReusableMethods;

        //Constructor
        public FamousPlaces(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            ReusableMethods = new ReusableMethods(driver, test);
        }


        public void FamousPlacesMethod()
        {
            ReusableMethods.ClickwithAd(FamousPlace, "FamousPlace");

            // Acropolis of Athens
            ReusableMethods.ElementClick(Acropolos, "Acropolis of Athens");
            Thread.Sleep(8000);
            ReusableMethods.NavigateBack("Navigation Back from Map screen");
            Thread.Sleep(4000);
            ReusableMethods.NavigateBack("Final Navigation Back from Map Screen");
            Thread.Sleep(6000);
            AppopenAdBack.Click();

            // Big Ben
            ReusableMethods.ElementClick(BigBen, "Big Ben");
            Thread.Sleep(8000);
            ReusableMethods.NavigateBack("Navigation Back from Map screen");
            Thread.Sleep(6000);
            ReusableMethods.NavigateBack("Final Navigation Back from Map Screen");
            Thread.Sleep(4000);
            AppopenAdBack.Click();

            // Burj Khalifa
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(BurjKhalifa));
            ReusableMethods.ElementClick(BurjKhalifa, "Burj Khalifa");
            Thread.Sleep(8000);
            ReusableMethods.NavigateBack("Navigation Back from Map screen");
            Thread.Sleep(6000);
            ReusableMethods.NavigateBack("Final Navigation Back from Map Screen");
            Thread.Sleep(4000);
            AppopenAdBack.Click();

            // Brandenburg Gate
            ReusableMethods.ElementClick(BraindenBurg, "Brandenburg Gate");
            Thread.Sleep(8000);
            ReusableMethods.NavigateBack("Navigation Back from Map screen");
            Thread.Sleep(4000);
            ReusableMethods.NavigateBack("Final Navigation Back from Map Screen");
            Thread.Sleep(4000);
            AppopenAdBack.Click();

            // Georges
            ReusableMethods.ElementClick(Georges, "Georges");
            Thread.Sleep(8000);
            ReusableMethods.NavigateBack("Navigation Back from Map screen");
            Thread.Sleep(4000);
            ReusableMethods.NavigateBack("Final Navigation Back from Map Screen");
            Thread.Sleep(4000);
            AppopenAdBack.Click();

            // Eiffel Tower
            ReusableMethods.ElementClick(EiffelTower, "Eiffel Tower");
            Thread.Sleep(8000);
            ReusableMethods.NavigateBack("Navigation Back from Map screen");
            Thread.Sleep(4000);
            ReusableMethods.NavigateBack("Final Navigation Back from Map Screen");
            Thread.Sleep(4000);
            AppopenAdBack.Click();

            // London Eye
            ReusableMethods.ElementClick(LondonEye, "London Eye");
            Thread.Sleep(8000);
            ReusableMethods.NavigateBack("Navigation Back from Map screen");
            Thread.Sleep(4000);
            ReusableMethods.NavigateBack("Final Navigation Back from Map Screen");
            Thread.Sleep(4000);
            AppopenAdBack.Click();

            // Kinderdijk
            ReusableMethods.ElementClick(Kinderdijik, "Kinderdijk");
            Thread.Sleep(8000);
            ReusableMethods.NavigateBack("Navigation Back from Map screen");
            Thread.Sleep(4000);
            ReusableMethods.NavigateBack("Final Navigation Back from Map Screen");
            Thread.Sleep(4000);
            AppopenAdBack.Click();

            // Louvre
            ReusableMethods.ElementClick(Louvire, "Louvre");
            Thread.Sleep(8000);
            ReusableMethods.NavigateBack("Navigation Back from Map screen");
            Thread.Sleep(4000);
            ReusableMethods.NavigateBack("Final Navigation Back from Map Screen");
            Thread.Sleep(4000);
            AppopenAdBack.Click();

            // Kaabah
            ReusableMethods.ElementClick(Kaabah, "Kaabah");
            Thread.Sleep(8000);
            ReusableMethods.NavigateBack("Navigation Back from Map screen");
            Thread.Sleep(4000);
            ReusableMethods.NavigateBack("Final Navigation Back from Map Screen");
            Thread.Sleep(4000);
            AppopenAdBack.Click();
            ReusableMethods.NavigateBack("Final Navigation Back from Map Screen");
        }

        // Elements
        public IWebElement? FamousPlace => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famousplacesBtn"), "FamousPlace");
        public IWebElement? BackButton => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/backButton"), "BackButton");

        public IWebElement? Acropolos => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='Acropolos of Athens']"), "Acropolos");
        public IWebElement? AppopenAdBack => ReusableMethods.FindElement(By.XPath("//android.widget.RelativeLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View[1]/android.view.View"), "AppopenAdBack");
        public IWebElement? BigBen => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='Big Ben']"), "BigBen");
        public IWebElement? BraindenBurg => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='Brandenburg Gate']"), "BraindenBurg");
        public IWebElement? Georges => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='Georges Pompidou']"), "Georges");
        public IWebElement? EiffelTower => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='Eiffel tower']"), "EiffelTower");
        public IWebElement? LondonEye => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='London Eye']"), "LondonEye");
        public IWebElement? Kinderdijik => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='Kinderdijk Windmills']"), "Kinderdijik");
        public IWebElement? Louvire => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='Louvire Museum']"), "Louvire");
        public IWebElement? Kaabah => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='Kaabah']"), "Kaabah");
        public IWebElement? Mountfuji => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='Mount Fuji']"), "Mountfuji");
        public IWebElement? NatreDameDe => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='Notre Dame De Paris']"), "NatreDameDe");
        public IWebElement? RomanForum => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='Roman Forum']"), "RomanForum");
        public IWebElement? SaintBasils => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='Saint Basil's Cathedral']"), "SaintBasils");
        public IWebElement? StatueOf => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='Statue of Liberty']"), "StatueOf");
        public IWebElement? Stonehenge => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='Stonehenge']"), "Stonehenge");
        public IWebElement? Colosseum => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='Colosseum']"), "Colosseum");
        public IWebElement? MachuPicchu => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='Machu Picchu']"), "MachuPicchu");
        public IWebElement? TowerBridge => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='Tower Bridge']"), "TowerBridge");
        public IWebElement? SydneyOpera => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='Sydney Opera House']"), "SydneyOpera");
        public IWebElement? TajMehel => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='Taj Mahal']"), "TajMehel");

        // Back button in Famous Places
        public IWebElement? FamousPlacesBack => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/backButton"), "FamousPlacesBack");

        // Burj Khalifa element
        public IWebElement? BurjKhalifa => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Burj khalifa\"]"), "Burj Khalifa");



    }
}
