using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace Live_Earth_Map.Pages
{
    class NearByPlaces
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        AdHelper AdHelper;

        //Constructor
        public NearByPlaces(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.AdHelper = new AdHelper(driver); // Initialize AdHelper with the correct driver type

        }

        public void NearByPlacesAirport()
        {
            ExtentTest test = Extent.CreateTest("NearBy Places Report 1");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            try
            {
                try
                {
                    // Wait for NearbyPlacesMenu to be displayed and then click
                    wait.Until(d => NearbyPlacesMenu.Displayed);
                    NearbyPlacesMenu.Click();
                }
                catch (Exception ex)
                {
                    HandleException("NearbyPlacesMenu.Click", ex);
                }

                // Pause between actions if necessary
                Thread.Sleep(2000); // Consider replacing with an explicit wait if there's a specific condition

                try
                {
                    // Wait for the potential ad to be present and handle it
                    wait.Until(d => AdHelper.IsAdPresent());
                    AdHelper.HandleAd();
                }
                catch (Exception ex)
                {
                    HandleException("AdHelper.HandleAd", ex);
                }

                try
                {
                    // Wait for Airport element to be clickable and then click
                    Airport.Click();
                    Thread.Sleep(2000);
                }
                catch (Exception ex)
                {
                    HandleException("Airport.Click", ex);
                }

                try
                {
                    // Wait for the back navigation to complete if needed
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    HandleException("driver.Navigate().Back", ex);
                }
            }
            catch (Exception ex)
            {
                HandleException("Airport ", ex);
            }
        }
        public void NearByPlacesRailway()
        {
            ExtentTest test = Extent.CreateTest("NearBy Places Report 1");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            try
            {


                try
                {
                    Railwaystation.Click();
                    Thread.Sleep(2000);
                }
                catch (Exception ex)
                {
                    HandleException("Railway.Click", ex);
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
                    HandleException(" - AdHelper.HandleAd", ex);
                }
                try
                {
                    // Wait for the back navigation to complete if needed
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    HandleException("driver.Navigate().Back", ex);
                }
            }
            catch (Exception ex)
            {
                HandleException(" driver.Navigate().Back", ex);
            }
            driver.Navigate().Back();

        }



        private void HandleException(string action, Exception ex)
        {
            Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
            Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
        }

        public void NearByPlacesCases()
        {
            ExtentTest test = Extent.CreateTest("NearBy Places Report 1");
            try
            {
                NearbyPlacesMenu.Click();
                Thread.Sleep(2000);
                try
                {
                    if (AdHelper.IsAdPresent())
                    {
                        AdHelper.HandleAd();
                    }
                }
                catch (Exception ex)
                {
                    HandleException("Satellite Map Scenario 1 - AdHelper.HandleAd", ex);
                }
                Airport.Click();
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Railwaystation.Click();
                driver.Navigate().Back();
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }


            try
            {
                Busstation.Click();
                // AdcloseInter.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Busstation: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Bank.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Bank: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                ATM.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking ATM: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Currency.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Currency: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Masjid.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Masjid: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Hospital.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Hospital: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Dentist.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Dentist: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Doctor.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Doctor: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Ambulance.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Ambulance: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                FireStation.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking FireStation: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                RescueCenter.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking RescueCenter: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                GasStation.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking GasStation: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                PetrolPump.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking PetrolPump: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Automechanic.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Automechanic: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Hotel.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Hotel: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Cafe.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Cafe: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Bakery.Click();
                Back();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Bakery: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                ShoppingMall.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking ShoppingMall: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                JewelryShop.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking JewelryShop: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Shoestore.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Shoestore: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                BeautySalon.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking BeautySalon: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Cinema.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Cinema: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                School.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking School: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                College.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking College: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                University.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking University: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                PetStore.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking PetStore: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Pharmacy.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Pharmacy: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Medical.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Medical: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Museum.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Museum: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Park.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Park: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Zoo.Click();
                BackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Zoo: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
        }



        public IWebElement Airport => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Airport\"]");
        public IWebElement BackButton => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/backButton");
        [Obsolete]
        private void Back()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//android.widget.Button[@content-desc=\"Back\"]/android.widget.ImageView")));
            element.Click();
        }

        public IWebElement Railwaystation => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Railway Station\"]");
        public IWebElement Busstation => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Bus Station\"]");
        public IWebElement Bank => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Bank\"]");
        public IWebElement ATM => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"ATM\"]");
        public IWebElement Currency => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Currency\"]");
        public IWebElement Masjid => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Masjid\"]");
        IWebElement AdcloseInter => driver.FindElementByXPath("//android.widget.RelativeLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View[1]/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[5]");
        public IWebElement MasjidBackButton => driver.FindElementByXPath("");
        public IWebElement Hospital => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Hospital\"]");
        public IWebElement HospitalBackButton => driver.FindElementByXPath("");
        public IWebElement Dentist => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Dentist\"]");
        public IWebElement DentistBackButton => driver.FindElementByXPath("");

        public IWebElement Doctor => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Doctor\"]");
        public IWebElement DoctorBackButton => driver.FindElementByXPath("");
        public IWebElement Ambulance => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Ambulance\"]");
        public IWebElement AmbulanceBackButton => driver.FindElementByXPath("");
        public IWebElement FireStation => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Fire Station\"]");
        public IWebElement FireStationBackButton => driver.FindElementByXPath("");
        public IWebElement RescueCenter => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Rescue Center\"]");
        public IWebElement RescueCenterButton => driver.FindElementByXPath("");
        public IWebElement GasStation => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Gas Station\"]");
        public IWebElement GasStationBackButton => driver.FindElementByXPath("");

        public IWebElement PetrolPump => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Petrol Pump\"]");
        public IWebElement PetrolPumpBackButton => driver.FindElementByXPath("");
        public IWebElement Automechanic => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Auto Mechanic\"]");
        public IWebElement AutomechanicBackButton => driver.FindElementByXPath("");
        public IWebElement Hotel => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Hotel\"]");
        public IWebElement HotelBackButton => driver.FindElementByXPath("");
        public IWebElement Cafe => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Cafe\"]");
        public IWebElement CafeBackButton => driver.FindElementByXPath("");
        public IWebElement Bakery => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Bakery\"]");
        public IWebElement BakeryBackButton => driver.FindElementByXPath("");
        public IWebElement ShoppingMall => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Shopping Mall\"]");
        public IWebElement ShoppingMallBackButton => driver.FindElementByXPath("");

        public IWebElement JewelryShop => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Jewelry Shop\"]");
        public IWebElement JewelryShopBackButton => driver.FindElementByXPath("");
        public IWebElement Shoestore => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Shoe Store\"]");
        public IWebElement ShoestoreBackButton => driver.FindElementByXPath("");
        public IWebElement BeautySalon => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Beauty Salon\"]");
        public IWebElement BeautySalonBackButton => driver.FindElementByXPath("");

        public IWebElement Cinema => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Cinema\"]");
        public IWebElement CinemaBackButton => driver.FindElementByXPath("");
        public IWebElement School => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"School\"]");
        public IWebElement SchoolBackButton => driver.FindElementByXPath("");
        public IWebElement College => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"College\"]");
        public IWebElement CollegeBackButton => driver.FindElementByXPath("");
        public IWebElement University => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"University\"]");
        public IWebElement UniversityBackButton => driver.FindElementByXPath("");
        public IWebElement PetStore => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Pet Store\"]");
        public IWebElement PetStoreBackButton => driver.FindElementByXPath("");
        public IWebElement Pharmacy => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Pharmacy\"]");
        public IWebElement PharmacyBackButton => driver.FindElementByXPath("");
        public IWebElement Medical => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Medical College\"]");
        public IWebElement MedicalBackButton => driver.FindElementByXPath("");
        public IWebElement Museum => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Museum\"]");
        public IWebElement MuseumBackButton => driver.FindElementByXPath("");
        public IWebElement Park => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Park\"]");
        public IWebElement ParkBackButton => driver.FindElementByXPath("");

        public IWebElement Zoo => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Zoo\"]");
        public IWebElement ZooBackButton => driver.FindElementByXPath("");

        IWebElement NearbyPlacesMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/nearbyPlacesBtn");

    }
}
