using AventStack.ExtentReports;
using Live_Earth_Map.Core;
using Live_Earth_Map.Pages;

namespace Live_Earth_Map.Test_Class
{
    [TestClass]
    public class Test_Class : TestInitiallize
    {
        UserInterface1 M;

        SatelliteMap SM;
        RouteFinder RF;
        NearByPlaces AP;
        TrafficMap TrafficMap;
        AddressFinder AddressFinder;
        ParkingSpot ParkingSpot;
        MyLocation Mylocation;
        StreetView SV;
        FamousPlaces Famousplaces;
        CurrencyConverter currencyConverter;
        LanguageTranslator languageTranslator;

        //ui with 1 page that has three sections
        [TestMethod]
        public void UI1Test()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            M = new UserInterface1(driver, test);
            M.SatelliteMapModule();
            M.RouteFinder();
            M.NearbyPlaces();
            M.TrafficMap();
            M.AddressFinder();
            M.ParkingSpotModule();
            M.MyLocation();
            M.GPSCamera();
            M.Streeview();
            M.FamousPlaces();
            M.MeasureArea();
            M.SolarInfo();
            M.CurrencyConverter();
            M.DailyLiveWeather();
            M.LanguageTranslator();
            M.Compass();
            M.SpeedoMeter();
            M.CountryInfo();
        }


        [TestMethod]
        //Satellite Map
        public void SatelliteMapTest()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            SM = new SatelliteMap(driver, test);
            SM.SatelliteMapModule();
        }

        [TestMethod]
        //RouteFinder
        public void RouteFinder()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            RF = new RouteFinder(driver, test);
            RF.RouteFinderModule();
        }

        //NearBy Places
        [TestMethod]
        public void NearByPlaces()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            AP = new NearByPlaces(driver, test);
            AP.NearByPlacesAirport();
            AP.NearByPlacesRailway();
        }

        //Traffic Map
        [TestMethod]
        public void TrafficMapTest()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            TrafficMap = new TrafficMap(driver, test);
            TrafficMap.TrafficMapMod();
        }

        //Address Finder
        [TestMethod]
        public void AddressFinderTest()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            AddressFinder = new AddressFinder(driver, test);
            AddressFinder.AddressFinderModule();
        }

        //Parking Spot
        [TestMethod]
        public void ParkingSpotTest()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            ParkingSpot = new ParkingSpot(driver, test);
            ParkingSpot.ParkingSpotMethod();
        }

        //My location Finder
        [TestMethod]
        public void MyLocationTest()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            Mylocation = new MyLocation(driver, test);
            Mylocation.MyLocationMethod();
        }
        [TestMethod]
        public void StreetView()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            SV = new StreetView(driver, test);
            SV.FamousPlaces();
            SV.SevenWondrs();
            SV.USAPanorama();
        }

        [TestMethod]
        public void FamousPlaces()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            Famousplaces = new FamousPlaces(driver, test);
            Famousplaces.FamousPlacesMethod();
        }

        //Currency cnverter
        [TestMethod]
        public void CurrencyConverter()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            currencyConverter = new CurrencyConverter(driver, test);
            currencyConverter.CurrencyConverterMethod();
        }

        //Language Translator
        [TestMethod]
        public void LanguageTranslator()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            languageTranslator = new LanguageTranslator(driver, test);
            languageTranslator.LanguageTranslatorMethod();
        }
    }
}
