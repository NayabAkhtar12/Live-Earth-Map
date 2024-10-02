using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Live_Earth_Map.Pages
{
    class LanguageTranslator
    {
        private AppiumDriver<AndroidElement> driver;
        ExtentReports Extent = new ExtentReports();
        ReusableMethods ReusableMethods;

        //Constructor
        public LanguageTranslator(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            ReusableMethods = new ReusableMethods(driver, test);
        }

        public void LanguageTranslatorMethod()
        {
            ReusableMethods.ScrollToElementByText("Language Translator");

            // Click on the Language Translator Menu with ad handling
            ReusableMethods.ClickwithAd(LanguagetranslatorMenu, "Language Translator Menu");

            // Enter text into the language text field
            ReusableMethods.ElementClick(LanguageText, "Language Text Field");
            LanguageText?.SendKeys("Welcome to the Health Tracker App! This application helps you monitor your blood pressure, sugar levels, weight, and BMI. Stay hydrated with our water reminder feature and keep track of your daily steps. Get better sleep by monitoring your sleep duration. Your health is our priority!");

            // Click on the Translate Button
            ReusableMethods.ElementClick(Translate, "Translate Button");
            Thread.Sleep(1000); // Wait for the translation to complete

            // Navigate back to the previous screen
            ReusableMethods.NavigateBack("Navigation Back from Language Translator");
        }




        //Elements

        public IWebElement? LanguagetranslatorMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/translatorBtn"), "LanguageTranslatorMenu");
        public IWebElement? LanguageText => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/to_translate_text_container"), "LanguageText");
        public IWebElement? Translate => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/translate"), "Translate");

    }
}
