using AventStack.ExtentReports;
using Live_Earth_Map.Core;
using Live_Earth_Map.Pages;
using NUnit.Framework;

namespace Live_Earth_Map.Test_Class
{
    [TestFixture]
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
        SolarInfo solarinfo;
        //ui with 1 page that has three sections
        [Test, Order(1)]
        public void UI1Test()
        {
            ExtentTest test = Extent.CreateTest(" UI1 Report");
            M = new UserInterface1(driver, test);
            M.SatelliteMapModule();
            M.RouteFinder();
            M.NearbyPlaces();
            M.TrafficMap();
            M.AddressFinder();
            M.ParkingSpotModule();
            M.MyLocation();
            M.GPSCamera();
            M.StreetView();
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


        [Test, Order(1)]
        //Satellite Map
        public void SatelliteMapTest()
        {
            ExtentTest test = Extent.CreateTest("SatelliteMapTest Report");
            SM = new SatelliteMap(driver, test);
            SM.SatelliteMapModule();
        }

        [Test, Order(2)]
        //RouteFinder
        public void RouteFinder()
        {
            ExtentTest test = Extent.CreateTest("Route Finder Report");
            RF = new RouteFinder(driver, test);
            RF.RouteFinderModule();
        }

        //NearBy Places
        [Test, Order(3)]
        public void NearByPlaces()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            AP = new NearByPlaces(driver, test);
            //   AP.NearByPlacesAirport();
            AP.NearByPlacesCases();
        }

        //Traffic Map
        [Test, Order(4)]
        public void TrafficMapTest()
        {
            ExtentTest test = Extent.CreateTest("TrafficMapTest Report");
            TrafficMap = new TrafficMap(driver, test);
            TrafficMap.TrafficMapMod();
        }

        //Address Finder
        [Test, Order(5)]
        public void AddressFinderTest()
        {
            ExtentTest test = Extent.CreateTest("AddressFinderTest Report");
            AddressFinder = new AddressFinder(driver, test);
            AddressFinder.AddressFinderModule();
        }

        //Parking Spot
        [Test, Order(6)]
        public void ParkingSpotTest()
        {
            ExtentTest test = Extent.CreateTest("ParkingSpotTest");
            ParkingSpot = new ParkingSpot(driver, test);
            ParkingSpot.ParkingSpotMethod();
        }

        //My location Finder
        [Test, Order(7)]
        public void MyLocationTest()
        {
            ExtentTest test = Extent.CreateTest("MyLocationTest");
            Mylocation = new MyLocation(driver, test);
            Mylocation.MyLocationMethod();
        }
        [Test, Order(8)]
        public void StreetView()
        {
            ExtentTest test = Extent.CreateTest("StreetView");
            SV = new StreetView(driver, test);
            //   SV.FamousPlaces();
            SV.SevenWondrs();
            //     SV.USAPanorama();
        }

        [Test, Order(9)]
        public void FamousPlaces()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            Famousplaces = new FamousPlaces(driver, test);
            Famousplaces.FamousPlacesMethod();
        }

        //Currency cnverter
        [Test, Order(10)]
        public void CurrencyConverter()
        {
            ExtentTest test = Extent.CreateTest("CurrencyConverter Report");
            currencyConverter = new CurrencyConverter(driver, test);
            currencyConverter.CurrencyConverterMethod();
        }

        //Language Translator
        [Test, Order(11)]
        public void LanguageTranslator()
        {
            ExtentTest test = Extent.CreateTest("LanguageTranslator  Report");
            languageTranslator = new LanguageTranslator(driver, test);
            languageTranslator.LanguageTranslatorMethod();
        }

        //SolarInfo
        [Test, Order(11)]
        public void SolarInfo()
        {
            ExtentTest test = Extent.CreateTest("solarInfo  Report");
            solarinfo = new SolarInfo(driver, test);
            solarinfo.SolarInfoMethod();
        }
    }
}
