using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Live_Earth_Map.Pages
{
    class NearByPlaces
    {
        private AppiumDriver<IWebElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        //Constructor
        public NearByPlaces(AppiumDriver<IWebElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
        }

        public void FamousPlaces()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report 1");

            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
        }
        public IWebElement Airport => driver.FindElementByXPath("");
        public IWebElement AirportBackButton => driver.FindElementByXPath("");

        public IWebElement Railwaystation => driver.FindElementByXPath("");
        public IWebElement RailwaystationBackButton => driver.FindElementByXPath("");
        public IWebElement Busstation => driver.FindElementByXPath("");
        public IWebElement BusstationBackButton => driver.FindElementByXPath("");
        public IWebElement Bank => driver.FindElementByXPath("");
        public IWebElement BankBackButton => driver.FindElementByXPath("");
        public IWebElement ATM => driver.FindElementByXPath("");
        public IWebElement ATMBackButton => driver.FindElementByXPath("");
        public IWebElement Currency => driver.FindElementByXPath("");
        public IWebElement CurrencyBackButton => driver.FindElementByXPath("");
        public IWebElement Masjid => driver.FindElementByXPath("");
        public IWebElement MasjidBackButton => driver.FindElementByXPath("");
        public IWebElement Hospital => driver.FindElementByXPath("");
        public IWebElement HospitalBackButton => driver.FindElementByXPath("");
        public IWebElement Dentist => driver.FindElementByXPath("");
        public IWebElement DentistBackButton => driver.FindElementByXPath("");

        public IWebElement Doctor => driver.FindElementByXPath("");
        public IWebElement DoctorBackButton => driver.FindElementByXPath("");
        public IWebElement Ambulance => driver.FindElementByXPath("");
        public IWebElement AmbulanceBackButton => driver.FindElementByXPath("");
        public IWebElement FireStation => driver.FindElementByXPath("");
        public IWebElement FireStationBackButton => driver.FindElementByXPath("");
        public IWebElement RescueCenter => driver.FindElementByXPath("");
        public IWebElement RescueCenterButton => driver.FindElementByXPath("");
        public IWebElement GasStation => driver.FindElementByXPath("");
        public IWebElement GasStationBackButton => driver.FindElementByXPath("");

        public IWebElement PetrolPump => driver.FindElementByXPath("");
        public IWebElement PetrolPumpBackButton => driver.FindElementByXPath("");
        public IWebElement Automechanic => driver.FindElementByXPath("");
        public IWebElement AutomechanicBackButton => driver.FindElementByXPath("");
        public IWebElement Hotel => driver.FindElementByXPath("");
        public IWebElement HotelBackButton => driver.FindElementByXPath("");
        public IWebElement Cafe => driver.FindElementByXPath("");
        public IWebElement CafeBackButton => driver.FindElementByXPath("");
        public IWebElement Bakery => driver.FindElementByXPath("");
        public IWebElement BakeryBackButton => driver.FindElementByXPath("");
        public IWebElement ShoppingMall => driver.FindElementByXPath("");
        public IWebElement ShoppingMallBackButton => driver.FindElementByXPath("");

        public IWebElement JewelryShop => driver.FindElementByXPath("");
        public IWebElement JewelryShopBackButton => driver.FindElementByXPath("");
        public IWebElement Shoestore => driver.FindElementByXPath("");
        public IWebElement ShoestoreBackButton => driver.FindElementByXPath("");
        public IWebElement BeautySalon => driver.FindElementByXPath("");
        public IWebElement BeautySalonBackButton => driver.FindElementByXPath("");

        public IWebElement Cinema => driver.FindElementByXPath("");
        public IWebElement CinemaBackButton => driver.FindElementByXPath("");
        public IWebElement School => driver.FindElementByXPath("");
        public IWebElement SchoolBackButton => driver.FindElementByXPath("");
        public IWebElement College => driver.FindElementByXPath("");
        public IWebElement CollegeBackButton => driver.FindElementByXPath("");
        public IWebElement University => driver.FindElementByXPath("");
        public IWebElement UniversityBackButton => driver.FindElementByXPath("");
        public IWebElement PetStore => driver.FindElementByXPath("");
        public IWebElement PetStoreBackButton => driver.FindElementByXPath("");
        public IWebElement Pharmacy => driver.FindElementByXPath("");
        public IWebElement PharmacyBackButton => driver.FindElementByXPath("");
        public IWebElement Medical => driver.FindElementByXPath("");
        public IWebElement MedicalBackButton => driver.FindElementByXPath("");
        public IWebElement Museum => driver.FindElementByXPath("");
        public IWebElement MuseumBackButton => driver.FindElementByXPath("");
        public IWebElement Park => driver.FindElementByXPath("");
        public IWebElement ParkBackButton => driver.FindElementByXPath("");

        public IWebElement Zoo => driver.FindElementByXPath("");
        public IWebElement ZooBackButton => driver.FindElementByXPath("");
    }
}
