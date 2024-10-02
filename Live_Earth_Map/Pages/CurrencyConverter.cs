
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Live_Earth_Map.Pages
{
    class CurrencyConverter
    {
        private AppiumDriver<AndroidElement> driver;
        ExtentReports Extent = new ExtentReports();
        ReusableMethods ReusableMethods;

        //Constructor
        public CurrencyConverter(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            ReusableMethods = new ReusableMethods(driver, test);
        }

        public void CurrencyConverterMethod()
        {
            ReusableMethods.ScrollToElementByText("Currency Converter");
            // Click on the Currency Converter Menu with ad handling
            ReusableMethods.ClickwithAd(CurrencyConverterMenu, "Currency Converter Menu");

            // Enter 5000 in the Currency Converter text field
            CurrencyConverterText.SendKeys("5000");

            // Click on the Convert Button
            ReusableMethods.ElementClick(ConvertBtn, "Convert Button");
            Thread.Sleep(1000); // Wait for conversion results

            // Navigate back twice
            ReusableMethods.NavigateBack("Navigation Back after Currency Conversion");
            ReusableMethods.NavigateBack("Second Navigation Back after Currency Conversion");
        }




        //Elements

        public IWebElement? CurrencyConverterMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/currencyBtn"), "CurrencyConverterMenu");

        public IWebElement? CurrencyConverterText => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/amount_edittext"), "CurrencyConverterText");

        public IWebElement? ConvertBtn => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/convert"), "ConvertBtn");


    }
}
