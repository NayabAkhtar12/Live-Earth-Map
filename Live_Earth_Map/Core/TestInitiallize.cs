using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace Live_Earth_Map.Core
{
    public class TestInitiallize
    {
        public AndroidDriver<IWebElement> driver;
        //  public ExtentReports Extent;


        public TestInitiallize()
        {
            var ExtentSparkReports = new ExtentSparkReporter("");
            var Extent = new ExtentReports();
            Extent.AttachReporter(ExtentSparkReports);
        }
        public void Setup()
        {
            try
            {
                AppiumOptions cap = new AppiumOptions();
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
                cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Galaxy s7");
                cap.AddAdditionalCapability(MobileCapabilityType.Udid, "");
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "8.0");
                cap.AddAdditionalCapability("appium:automationName", AutomationName.AndroidUIAutomator2);
                driver = new AndroidDriver<IWebElement>(new Uri(""), cap, TimeSpan.FromSeconds(5));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to initialize driver: {e.Message}");
                throw;
            }
        }

        [TestCleanup]
        public void CleanUp()
        {
            try
            {
                if (driver != null)
                {
                    driver.Quit();
                    driver.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to initialize driver: {e.Message}");
                throw;
            }

        }
    }
}
