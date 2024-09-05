using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace Live_Earth_Map.Pages
{
    class CurrencyConverter
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        AdHelper AdHelper;
        //Constructor
        public CurrencyConverter(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.AdHelper = new AdHelper(driver); // Initialize AdHelper with the correct driver type
        }

        public void CurrencyConverterMethod()
        {
            ExtentTest test = Extent.CreateTest("Report 1");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            try
            {
                try
                {
                    CurrencyConverterMenu.Click();
                }
                catch (Exception ex)
                {
                    HandleException("CurrencyConverterMenu Scenario 1 - CurrencyConverterMenu.Click", ex);
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
                    HandleException("AddressFinder Scenario 1 - AdHelper.HandleAd", ex);
                }

                Thread.Sleep(3000);

                try
                {
                    // wait.Until(d => AddParkingSpot.Displayed);

                    CurrencyConverterText.SendKeys("5000");
                }
                catch (Exception ex)
                {
                    HandleException("CurrencyConverterText ", ex);
                }

                try
                {
                    ConverBtn.Click();
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    HandleException("Add Bus - Click", ex);
                }
            }
            catch (Exception ex)
            {
                HandleException("Currency Converter", ex);
            }

            driver.Navigate().Back();

        }

        private void HandleException(string action, Exception ex)
        {
            Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
            Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
        }


        //Elements

        IWebElement CurrencyConverterMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/currencyBtn");

        IWebElement CurrencyConverterText => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/amount_edittext");
        IWebElement ConverBtn => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/convert");
        public IWebElement BackButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/backButton");




    }
}
