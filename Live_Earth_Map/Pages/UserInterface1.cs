using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Live_Earth_Map.Pages
{
    class UserInterface1
    {
        private AppiumDriver<AndroidElement> driver;
        ReusableMethods ReusableMethods;

        //Constructor
        public UserInterface1(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            ReusableMethods = new ReusableMethods(driver, test);
        }

        public void SatelliteMapModule()
        {
            ReusableMethods.ScrollToElementByText("Satellite Map");
            ReusableMethods.ClickwithAd(SatelliteMapMenu, "Satellite Map Menu");
            Thread.Sleep(3000);
            ReusableMethods.NavigateBack("Navigation Back from Satellite Map");
        }

        // Route Finder
        public void RouteFinder()
        {
            ReusableMethods.ScrollToElementByText("Route Finder");
            ReusableMethods.ClickwithAd(RouteFinderMenu, "Route Finder Menu");
            Thread.Sleep(3000);
            ReusableMethods.NavigateBack("Navigation Back from Route Finder");
        }

        // Nearby Places
        public void NearbyPlaces()
        {
            ReusableMethods.ScrollToElementByText("Nearby Places");
            ReusableMethods.ClickwithAd(NearbyPlacesMenu, "Nearby Places Menu");
            Thread.Sleep(3000);
            ReusableMethods.NavigateBack("Navigation Back from Nearby Places");
        }

        // Traffic Map
        public void TrafficMap()
        {
            ReusableMethods.ScrollToElementByText("Traffic Map");
            ReusableMethods.ClickwithAd(TrafficMapMenu, "Traffic Map Menu");
            Thread.Sleep(3000);
            ReusableMethods.NavigateBack("Navigation Back from Traffic Map");
        }

        // Address Finder
        public void AddressFinder()
        {
            ReusableMethods.ScrollToElementByText("Address Finder");
            ReusableMethods.ClickwithAd(AddressFinderMenu, "Address Finder Menu");
            Thread.Sleep(3000);
            ReusableMethods.NavigateBack("Navigation Back from Address Finder");
        }

        // Parking Spot Module
        public void ParkingSpotModule()
        {
            ReusableMethods.ScrollToElementByText("Parking Spot");
            ReusableMethods.ClickwithAd(ParkingSpotMenu, "Parking Spot Menu");
            Thread.Sleep(3000);
            ReusableMethods.NavigateBack("Navigation Back from Parking Spot");
        }

        // My Location
        public void MyLocation()
        {
            ReusableMethods.ScrollToElementByText("My Location");
            ReusableMethods.ClickwithAd(MyLocationMenu, "My Location Menu");
            Thread.Sleep(3000);
            ReusableMethods.NavigateBack("Navigation Back from My Location");
        }

        // GPS Camera
        public void GPSCamera()
        {
            ReusableMethods.ScrollToElementByText("GPS Camera");
            ReusableMethods.ClickwithAd(GPSCameraMenu, "GPS Camera Menu");
            Thread.Sleep(3000);
            ReusableMethods.NavigateBack("Navigation Back from GPS Camera");
        }

        // Street View
        public void StreetView()
        {
            ReusableMethods.ScrollToElementByText("Street View");
            ReusableMethods.ClickwithAd(StreetViewMenu, "Street View Menu");
            Thread.Sleep(3000);
            ReusableMethods.NavigateBack("Navigation Back from Street View");
        }

        // Famous Places
        public void FamousPlaces()
        {
            ReusableMethods.ScrollToElementByText("Famous Places");
            ReusableMethods.ClickwithAd(FamousPlacesMenu, "Famous Places Menu");
            Thread.Sleep(3000);
            ReusableMethods.NavigateBack("Navigation Back from Famous Places");
        }

        // Measure Area
        public void MeasureArea()
        {
            ReusableMethods.ScrollToElementByText("Measure Area");
            ReusableMethods.ClickwithAd(MeasureAreaMenu, "Measure Area Menu");
            Thread.Sleep(3000);
            ReusableMethods.NavigateBack("Navigation Back from Measure Area");
        }

        // Solar Info
        public void SolarInfo()
        {
            ReusableMethods.ScrollToElementByText("Solar Info");
            ReusableMethods.ClickwithAd(SolarInfoMenu, "Solar Info Menu");
            Thread.Sleep(3000);
            ReusableMethods.NavigateBack("Navigation Back from Solar Info");
        }

        // Currency Converter
        public void CurrencyConverter()
        {
            ReusableMethods.ScrollToElementByText("Currency Converter");
            ReusableMethods.ClickwithAd(CurrencyConverterMenu, "Currency Converter Menu");
            Thread.Sleep(3000);
            ReusableMethods.NavigateBack("Navigation Back from Currency Converter");
        }

        // Daily Live Weather
        public void DailyLiveWeather()
        {
            ReusableMethods.ScrollToElementByText("Daily Live Weather");
            ReusableMethods.ClickwithAd(DailyLiveWeatherMenu, "Daily Live Weather Menu");
            Thread.Sleep(3000);
            ReusableMethods.NavigateBack("Navigation Back from Daily Live Weather");
        }

        // Language Translator
        public void LanguageTranslator()
        {
            ReusableMethods.ScrollToElementByText("Language Translator");
            ReusableMethods.ClickwithAd(LanguageTranslatorMenu, "Language Translator Menu");
            Thread.Sleep(3000);
            ReusableMethods.NavigateBack("Navigation Back from Language Translator");
        }

        // Speedometer
        public void SpeedoMeter()
        {
            ReusableMethods.ScrollToElementByText("Speedometer");
            ReusableMethods.ClickwithAd(SpeedometerMenu, "SpeedoMeter Menu");
            Thread.Sleep(3000);
            ReusableMethods.NavigateBack("Navigation Back from SpeedoMeter");
        }

        // Compass
        public void Compass()
        {
            ReusableMethods.ScrollToElementByText("Compass");
            ReusableMethods.ClickwithAd(CompassMenu, "Compass Menu");
            Thread.Sleep(3000);
            ReusableMethods.NavigateBack("Navigation Back from Compass");
        }

        // Country Info
        public void CountryInfo()
        {
            ReusableMethods.ScrollToElementByText("Country Info");
            ReusableMethods.ClickwithAd(CountryInfoMenu, "Country Info Menu");
            Thread.Sleep(3000);
            ReusableMethods.NavigateBack("Navigation Back from Country Info");
        }

        public IWebElement? RouteMyLoc => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/my_address_bt"), "RouteMyLoc");
        public IWebElement? RouteMyDestination => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/destination_search"), "RouteMyDestination");
        public IWebElement? SatelliteMapMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/sateliteBtn"), "SatelliteMapMenu");
        public IWebElement? RouteFinderMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/routeFinderBtn"), "RouteFinderMenu");
        public IWebElement? AddressFinderMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/addressFinderBtn"), "AddressFinderMenu");
        public IWebElement? NearbyPlacesMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/nearbyPlacesBtn"), "NearbyPlacesMenu");
        public IWebElement? TrafficMapMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/trafficMapBtn"), "TrafficMapMenu");
        public IWebElement? ParkingSpotMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/parkingBtn"), "ParkingSpotMenu");
        public IWebElement? MyLocationMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/myLocationBtn"), "MyLocationMenu");
        public IWebElement? GPSCameraMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/gpsCameraBtn"), "GPSCameraMenu");
        public IWebElement? StreetViewMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/streetViewBtn"), "StreetViewMenu");
        public IWebElement? FamousPlacesMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famousplacesBtn"), "FamousPlacesMenu");
        public IWebElement? MeasureAreaMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/areaBtn"), "MeasureAreaMenu");
        public IWebElement? SolarInfoMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/solarBtn"), "SolarInfoMenu");
        public IWebElement? CurrencyConverterMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/currencyBtn"), "CurrencyConverterMenu");
        public IWebElement? DailyLiveWeatherMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/weatherBtn"), "DailyLiveWeatherMenu");
        public IWebElement? LanguageTranslatorMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/translatorBtn"), "LanguageTranslatorMenu");
        public IWebElement? CompassMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/compassBtn"), "CompassMenu");
        public IWebElement? SpeedometerMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/speedometerBtn"), "SpeedometerMenu");
        public IWebElement? CountryInfoMenu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/countryInfoBtn"), "CountryInfoMenu");
        public IWebElement? Premium => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/premiumBtn"), "Premium");
        public IWebElement? PremiumCrossButton => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/premiumBtn"), "PremiumCrossButton");
        public IWebElement? Menu => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/menuBtn"), "Menu");
        public IWebElement? ChooseLanguage => ReusableMethods.FindElement(By.Id(""), "ChooseLanguage");
        public IWebElement? ApplyLanguage => ReusableMethods.FindElement(By.Id(""), "ApplyLanguage");
        public IWebElement? RateUs => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@text='Rate us']"), "RateUs");
        public IWebElement? MoreApps => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@text='More apps']"), "MoreApps");
        public IWebElement? PrivacySettings => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@text='Privacy Settings']"), "PrivacySettings");
        public IWebElement? ReadPrivacyPolicyHere => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/privacyPolicyBtn"), "ReadPrivacyPolicyHere");
        public IWebElement? ExitApp => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@text='Exit App']"), "ExitApp");
        public IWebElement? ExitAppYes => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/exit"), "ExitAppYes");
        public IWebElement? ExitAppNo => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/cancel"), "ExitAppNo");
        public IWebElement? MapTools => ReusableMethods.FindElement(By.Id("Map tools"), "MapTools");
        public IWebElement? SearchText => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/editText_address"), "SearchText");
        public IWebElement? SearchButton => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/search_item"), "SearchButton");
        public IWebElement? MapStyleButton => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/layers_bt"), "MapStyleButton");
        public IWebElement? SatelliteMapView => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_sat"), "SatelliteMapView");
        public IWebElement? TerrainMap => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_terrain"), "TerrainMap");
        public IWebElement? TypicalMapView => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/image_typical"), "TypicalMapView");
        public IWebElement? CurrentLocationButton => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/location_btn"), "CurrentLocationButton");
        public IWebElement? ClearTextSearch => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/clear_bt"), "ClearTextSearch");
        public IWebElement? BackButton => ReusableMethods.FindElement(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/backButton"), "BackButton");
        public IWebElement? School => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv' and @text='School']"), "School");

    }
}
