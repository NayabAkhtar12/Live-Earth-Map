﻿using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace Live_Earth_Map.Core
{
    public class TestInitiallize
    {
        public AndroidDriver<AndroidElement>? driver;
        public static ExtentReports Extent;
        private static ExtentSparkReporter _reporter;

        //  Static constructor for initializing ExtentReports
        static TestInitiallize()
        {
            string reportPath = @"D:\Reports\LiveEarthMapDdefectReport.html";
            _reporter = new ExtentSparkReporter(reportPath);
            Extent = new ExtentReports();
            Extent.AttachReporter(_reporter);
        }

        [SetUp]
        public void Setup()
        {
            try
            {
                AppiumOptions cap = new AppiumOptions();
                cap.PageLoadStrategy = PageLoadStrategy.Normal;

                cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
                cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Galaxy s7");
                cap.AddAdditionalCapability(MobileCapabilityType.Udid, "e7c7d60c");
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "8.0");
                cap.AddAdditionalCapability("appium:automationName", AutomationName.AndroidUIAutomator2);
                driver = new AndroidDriver<AndroidElement>(new Uri("http://192.168.100.14:4723/"), cap, TimeSpan.FromSeconds(180));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to initialize driver: {e.Message}");
                throw;
            }
        }

        [TearDown]
        public void CleanUp()
        {
            try
            {
                if (driver != null)
                {
                    driver.CloseApp();
                    driver.Quit();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to initialize driver: {e.Message}");
                throw;
            }
            Extent.Flush();

        }
    }
}
