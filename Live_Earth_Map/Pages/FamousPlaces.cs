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
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        AdHelper AdHelper;
        //Constructor
        public FamousPlaces(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.AdHelper = new AdHelper(driver); // Initialize AdHelper with the correct driver type
        }

        public void FamousPlacesMethod()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            try
            {
                try
                {
                    FamousPlace.Click();
                }
                catch (Exception ex)
                {
                    HandleException("FamousPlace Scenario 1 - FamousPlace.Click", ex);
                }


                try
                {
                    if (AdHelper.IsAdPresent())
                    {
                        AdHelper.HandleAd();
                    }
                }
                catch (Exception ex)
                {
                    HandleException("FamousPlace Scenario 1 - AdHelper.HandleAd", ex);
                }

                Thread.Sleep(3000);


                try
                {
                    Acropolos.Click();
                    //   WaitForElementToBeVisible(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/backButton"), 10);

                    Thread.Sleep(8000);

                    driver.Navigate().Back();
                    Thread.Sleep(4000);

                    driver.Navigate().Back();
                    Thread.Sleep(4000);
                    AppopenAdBack.Click();

                }
                catch (Exception ex)
                {
                    HandleException("Acroplos.click", ex);

                }

                try
                {
                    BigBen.Click();
                    Thread.Sleep(8000);

                    driver.Navigate().Back();
                    Thread.Sleep(4000);

                    driver.Navigate().Back();
                    Thread.Sleep(4000);
                    AppopenAdBack.Click();
                    Thread.Sleep(4000);

                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    BurjKhalifa.Click();
                    Thread.Sleep(8000);

                    driver.Navigate().Back();
                    Thread.Sleep(4000);

                    driver.Navigate().Back();
                    Thread.Sleep(4000);
                    AppopenAdBack.Click();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    BraindenBurg.Click();
                    Thread.Sleep(8000);

                    driver.Navigate().Back();
                    Thread.Sleep(4000);

                    driver.Navigate().Back();
                    Thread.Sleep(4000);
                    AppopenAdBack.Click();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
                try
                {
                    Georges.Click();
                    Thread.Sleep(8000);

                    driver.Navigate().Back();
                    Thread.Sleep(4000);

                    driver.Navigate().Back();
                    Thread.Sleep(4000);
                    AppopenAdBack.Click();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
                try
                {
                    EiffelTower.Click();
                    Thread.Sleep(8000);

                    driver.Navigate().Back();
                    Thread.Sleep(4000);

                    driver.Navigate().Back();
                    Thread.Sleep(4000);
                    AppopenAdBack.Click();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
                try
                {
                    LondonEye.Click();
                    Thread.Sleep(8000);

                    driver.Navigate().Back();
                    Thread.Sleep(4000);

                    driver.Navigate().Back();
                    Thread.Sleep(4000);
                    AppopenAdBack.Click();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
                try
                {
                    Kinderdijik.Click();
                    Thread.Sleep(8000);

                    driver.Navigate().Back();
                    Thread.Sleep(4000);

                    driver.Navigate().Back();
                    Thread.Sleep(4000);
                    AppopenAdBack.Click();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
                try
                {
                    Louvire.Click();
                    Thread.Sleep(8000);

                    driver.Navigate().Back();
                    Thread.Sleep(4000);

                    driver.Navigate().Back();
                    Thread.Sleep(4000);
                    AppopenAdBack.Click();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Kaabah.Click();
                    Thread.Sleep(8000);

                    driver.Navigate().Back();
                    Thread.Sleep(4000);

                    driver.Navigate().Back();
                    Thread.Sleep(4000);
                    AppopenAdBack.Click();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }


                //try
                //{
                //    Mountfuji.Click();
                //    Thread.Sleep(8000);

                //    driver.Navigate().Back();
                //    Thread.Sleep(4000);

                //    driver.Navigate().Back();
                //    AppopenAdBack.Click();

                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Exception occurred: " + ex.Message);
                //    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                //}
                //try
                //{
                //    NatreDameDe.Click();
                //    Thread.Sleep(8000);

                //    driver.Navigate().Back();
                //    Thread.Sleep(4000);

                //    driver.Navigate().Back();
                //    AppopenAdBack.Click();
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Exception occurred: " + ex.Message);
                //    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                //}
                //try
                //{
                //    RomanForum.Click();
                //    Thread.Sleep(8000);

                //    driver.Navigate().Back();
                //    Thread.Sleep(4000);

                //    driver.Navigate().Back();
                //    AppopenAdBack.Click();
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Exception occurred: " + ex.Message);
                //    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                //}
                //try
                //{
                //    SaintBasils.Click();
                //    Thread.Sleep(8000);

                //    driver.Navigate().Back();
                //    Thread.Sleep(4000);

                //    driver.Navigate().Back();
                //    AppopenAdBack.Click();
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Exception occurred: " + ex.Message);
                //    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                //}
                //try
                //{
                //    StatueOf.Click();
                //    Thread.Sleep(8000);

                //    driver.Navigate().Back();
                //    Thread.Sleep(4000);

                //    driver.Navigate().Back();
                //    AppopenAdBack.Click();
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Exception occurred: " + ex.Message);
                //    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                //}
                //try
                //{
                //    Stonehenge.Click();
                //    Thread.Sleep(8000);

                //    driver.Navigate().Back();
                //    Thread.Sleep(4000);

                //    driver.Navigate().Back();
                //    AppopenAdBack.Click();
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Exception occurred: " + ex.Message);
                //    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                //}
                //try
                //{
                //    Colosseum.Click();
                //    Thread.Sleep(8000);

                //    driver.Navigate().Back();
                //    Thread.Sleep(4000);

                //    driver.Navigate().Back();
                //    AppopenAdBack.Click();
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Exception occurred: " + ex.Message);
                //    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                //}
                //try
                //{
                //    MachuPicchu.Click();
                //    Thread.Sleep(8000);

                //    driver.Navigate().Back();
                //    Thread.Sleep(4000);

                //    driver.Navigate().Back();
                //    AppopenAdBack.Click();
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Exception occurred: " + ex.Message);
                //    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                //}
                //try
                //{
                //    TowerBridge.Click();
                //    Thread.Sleep(8000);

                //    driver.Navigate().Back();
                //    Thread.Sleep(4000);

                //    driver.Navigate().Back();
                //    AppopenAdBack.Click();
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Exception occurred: " + ex.Message);
                //    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                //}
                //try
                //{
                //    SydneyOpera.Click();
                //    Thread.Sleep(8000);

                //    driver.Navigate().Back();
                //    Thread.Sleep(4000);

                //    driver.Navigate().Back();
                //    AppopenAdBack.Click();
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Exception occurred: " + ex.Message);
                //    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                //}
                //try
                //{
                //    TajMehel.Click();
                //    Thread.Sleep(8000);

                //    driver.Navigate().Back();
                //    Thread.Sleep(4000);

                //    driver.Navigate().Back();
                //    AppopenAdBack.Click();
                //    FamousPlacesBack.Click();
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Exception occurred: " + ex.Message);
                //    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                //}
            }
            catch (Exception ex)
            {
                HandleException("Address Finder", ex);
            }

            driver.Navigate().Back();

        }

        private void HandleException(string action, Exception ex)
        {
            Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
            Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
        }


        //Elements
        IWebElement FamousPlace => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famousplacesBtn");

        public IWebElement BackButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/backButton");
        IWebElement Acropolos => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Acropolos of Athens\"]");
        IWebElement AppopenAdBack => driver.FindElementByXPath("//android.widget.RelativeLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View[1]/android.view.View");
        IWebElement BigBen => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Big Ben\"]");
        IWebElement BraindenBurg => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Brandenburg Gate\"]");
        IWebElement Georges => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Georges Pompidou\"]");
        IWebElement EiffelTower => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Eiffel tower\"]");
        IWebElement LondonEye => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"London Eye\"]");
        IWebElement Kinderdijik => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Kinderdijk Windmills\"]");
        IWebElement Louvire => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Louvire Museum\"]");
        IWebElement Kaabah => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Kaabah\"]");
        IWebElement Mountfuji => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Mount Fuji\"]");
        IWebElement NatreDameDe => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Notre Dame De Paris\"]");
        IWebElement RomanForum => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Roman Forum\"]");
        IWebElement SaintBasils => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Saint Basil's Cathedral\"]");
        IWebElement StatueOf => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Statue of Liberty\"]");
        IWebElement Stonehenge => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Stonehenge\"]");
        IWebElement Colosseum => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Colosseum\"]");
        IWebElement MachuPicchu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Machu Picchu\"]");
        IWebElement TowerBridge => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Tower Bridge\"]");
        IWebElement SydneyOpera => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Sydney Opera House\"]");
        IWebElement TajMehel => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Taj Mahal\"]");
        IWebElement FamousPlacesBack => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/backButton");
        IWebElement BurjKhalifa => driver.FindElementById("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Burj khalifa\"]");

    }
}
