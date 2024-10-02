using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Live_Earth_Map.Pages
{
    public class StreetView
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        AdHelper AdHelper;

        //Constructor
        public StreetView(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.AdHelper = new AdHelper(driver); // Initialize AdHelper with the correct driver type

        }


        //Methods
        public void FamousPlaces()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report 1");

            try
            {
                //StreetViewmenu.Click();
                //Thread.Sleep(3000);
                //AdHelper.HandleAd();
                FamousPlace.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Acropolos.Click();
                //   WaitForElementToBeVisible(By.Id("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/backButton"), 10);

                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                BigBen.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
                Thread.Sleep(4000);

                driver.Navigate().Back();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                BurjKhalifa.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                BraindenBurg.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                Georges.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                EiffelTower.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                LondonEye.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                Kinderdijik.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                Louvire.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                Kaabah.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                Mountfuji.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                NatreDameDe.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                RomanForum.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                SaintBasils.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                StatueOf.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                Stonehenge.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                Colosseum.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                MachuPicchu.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                TowerBridge.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                SydneyOpera.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                TajMehel.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
                FamousPlacesBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
        }
        public void SevenWondrs()
        {
            try
            {
                //  SevenWonders.Click();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                Petra.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                GreatWall.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                TajMahal.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                TheColloseum.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                TheMachu.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                ChichenItza.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                Christtheredeemer.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
                BackSevenWonders.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
        }
        public void USAPanorama()
        {
            try
            {
                USAPanoramaMenu.Click();
                Thread.Sleep(6000);
                CBannerQuit.Click();
                NationalPark.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                CBannerQuit.Click();

                Antelope.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                BellagioHotel.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                DisneyKingdom.Click();

                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                DisneyWorld.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                FloridaKeys.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                GoldenGateBridge.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                GrandCanyon.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                GrandTetonPark.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                LakeTahoe.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                MagicKingdomPark.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                MonumentValley.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                Maui.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                RedwoodNationaland.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                SouthBeachFlorida.Click();
                Thread.Sleep(8000);

                driver.Navigate().Back();
                Thread.Sleep(4000);

                driver.Navigate().Back();
                AppopenAdBack.Click();
                USABack.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
        }
        public void GermanyPanorama()
        {
            try
            {
                NationalPark.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                Antelope.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                BellagioHotel.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                DisneyKingdom.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                DisneyWorld.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                FloridaKeys.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                GoldenGateBridge.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                GrandCanyon.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                GrandTetonPark.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                LakeTahoe.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                MagicKingdomPark.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                MonumentValley.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                Maui.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                RedwoodNationaland.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                SouthBeachFlorida.Click();
                GermanyBackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
        }
        public void Pakistani()
        {
            try
            {
                PakistaniPanoramaMenu.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Pakistani Panorama Menu: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Pakistani Panorama Menu due to: {ex.Message}");
            }

            try
            {
                AttabadLake.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Attabad Lake: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Attabad Lake due to: {ex.Message}");
            }

            try
            {
                FaisalMasjid.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Faisal Masjid: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Faisal Masjid due to: {ex.Message}");
            }

            try
            {
                MazareQaid.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Mazare Qaid: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Mazare Qaid due to: {ex.Message}");
            }

            try
            {
                BadshahiMosque.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Badshahi Mosque: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Badshahi Mosque due to: {ex.Message}");
            }

            try
            {
                MahodandLake.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Mahodand Lake: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Mahodand Lake due to: {ex.Message}");
            }

            try
            {
                MinarePakistan.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Minare Pakistan: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Minare Pakistan due to: {ex.Message}");
            }

            try
            {
                MargallaHills.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Margalla Hills: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Margalla Hills due to: {ex.Message}");
            }

            try
            {
                MoenjoDaro.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Moenjo Daro: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Moenjo Daro due to: {ex.Message}");
            }

            try
            {
                LakeSaifulMalook.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Lake Saiful Malook: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Lake Saiful Malook due to: {ex.Message}");
            }

            try
            {
                SheeshMehal.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Sheesh Mehal: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Sheesh Mehal due to: {ex.Message}");
            }

            try
            {
                PassuCones.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Passu Cones: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Passu Cones due to: {ex.Message}");
            }

            try
            {
                SiriPaemedows.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Siri Paemedows: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Siri Paemedows due to: {ex.Message}");
            }

            try
            {
                UshuForest.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Ushu Forest: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Ushu Forest due to: {ex.Message}");
            }

            try
            {
                KumratValley.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Kumrat Valley: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Kumrat Valley due to: {ex.Message}");
            }

            try
            {
                Lulusarlake.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Lulusar Lake: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Lulusar Lake due to: {ex.Message}");
            }

            try
            {
                KundMalirBeach.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Kund Malir Beach: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Kund Malir Beach due to: {ex.Message}");
            }

            try
            {
                WhitePalace.Click();
                PakistanBackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking White Palace: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on White Palace due to: {ex.Message}");
            }
        }
        public void France()
        {
            try
            {
                FrancePanoramaMenu.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking France Panorama Menu: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on France Panorama Menu due to: {ex.Message}");
            }

            try
            {
                FranceEifferTower.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking France Eiffer Tower: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on France Eiffer Tower due to: {ex.Message}");
            }

            try
            {
                FrancLouvire.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Franc Louvire: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Franc Louvire due to: {ex.Message}");
            }

            try
            {
                FrancPalaceofVersalies.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Franc Palace of Versalies: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Franc Palace of Versalies due to: {ex.Message}");
            }

            try
            {
                FrenchRiveria.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking French Riveria: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on French Riveria due to: {ex.Message}");
            }

            try
            {
                MantSaint_Michel.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Mant Saint_Michel: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Mant Saint_Michel due to: {ex.Message}");
            }

            try
            {
                LoireValleyChateu.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Loire Valley Chateu: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Loire Valley Chateu due to: {ex.Message}");
            }

            try
            {
                Villandry.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Villandry: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Villandry due to: {ex.Message}");
            }

            try
            {
                FrancNatreDame.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Franc Natre Dame: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Franc Natre Dame due to: {ex.Message}");
            }

            try
            {
                Mont_Blanc.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Mont Blanc: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Mont Blanc due to: {ex.Message}");
            }

            try
            {
                Carcassonne.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Carcassonne: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Carcassonne due to: {ex.Message}");
            }

            try
            {
                Brittany.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Brittany: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Brittany due to: {ex.Message}");
            }

            try
            {
                Rocamadour.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Rocamadour: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Rocamadour due to: {ex.Message}");
            }

            try
            {
                PrehistoricCavePaintings.Click();
                FranceBackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Prehistoric Cave Paintings: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Prehistoric Cave Paintings due to: {ex.Message}");
            }
        }
        public void UK()
        {
            try
            {
                UKPanoramaMenu.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking UK Panorama Menu: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on UK Panorama Menu due to: {ex.Message}");
            }

            try
            {
                London.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking London: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on London due to: {ex.Message}");
            }

            try
            {
                EdinBurgh.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking EdinBurgh: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on EdinBurgh due to: {ex.Message}");
            }

            try
            {
                RomanBaths.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Roman Baths: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Roman Baths due to: {ex.Message}");
            }

            try
            {
                StoneheigeUK.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Stoneheige UK: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Stoneheige UK due to: {ex.Message}");
            }

            try
            {
                WindsorCastle.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Windsor Castle: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Windsor Castle due to: {ex.Message}");
            }

            try
            {
                Cotswolds.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Cotswolds: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Cotswolds due to: {ex.Message}");
            }

            try
            {
                LakeDistrictNPark.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Lake District National Park: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Lake District National Park due to: {ex.Message}");
            }

            try
            {
                York.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking York: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on York due to: {ex.Message}");
            }

            try
            {
                Canterbury.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Canterbury: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Canterbury due to: {ex.Message}");
            }

            try
            {
                LochNess.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Loch Ness: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Loch Ness due to: {ex.Message}");
            }

            try
            {
                GiantsCauseway.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Giants Causeway: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Giants Causeway due to: {ex.Message}");
            }

            try
            {
                ChannelIslandsUK.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Channel Islands UK: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Channel Islands UK due to: {ex.Message}");
            }

            try
            {
                Belfast.Click();
                UKBackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Belfast: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Belfast due to: {ex.Message}");
            }
        }
        public void ItalyPanorama()
        {
            try
            {
                ItalyPanoramaMenu.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Italy Panorama Menu: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Italy Panorama Menu due to: {ex.Message}");
            }

            try
            {
                FlorenceItaly.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Florence Italy: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Florence Italy due to: {ex.Message}");
            }

            try
            {
                CanalVenice.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Canal Venice: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Canal Venice due to: {ex.Message}");
            }

            try
            {
                LeaningTowerofPiso.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Leaning Tower of Piso: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Leaning Tower of Piso due to: {ex.Message}");
            }

            try
            {
                VacationCity.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Vacation City: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Vacation City due to: {ex.Message}");
            }

            try
            {
                UffiziGallery.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Uffizi Gallery: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Uffizi Gallery due to: {ex.Message}");
            }

            try
            {
                ClinqueTerre.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Clinque Terre: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Clinque Terre due to: {ex.Message}");
            }

            try
            {
                LakeComoItaly.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Lake Como Italy: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Lake Como Italy due to: {ex.Message}");
            }

            try
            {
                Pantheon.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Pantheon: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Pantheon due to: {ex.Message}");
            }

            try
            {
                VeronaArena.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Verona Arena: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Verona Arena due to: {ex.Message}");
            }

            try
            {
                TreviFountain.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Trevi Fountain: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Trevi Fountain due to: {ex.Message}");
            }

            try
            {
                AmalfiCoast.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Amalfi Coast: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Amalfi Coast due to: {ex.Message}");
            }

            try
            {
                PompeiiMount.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Pompeii Mount: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Pompeii Mount due to: {ex.Message}");
            }

            try
            {
                ItalyRomanForum.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Italy Roman Forum: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Italy Roman Forum due to: {ex.Message}");
            }

            try
            {
                DuomodiMilano.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Duomo di Milano: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Duomo di Milano due to: {ex.Message}");
            }

            try
            {
                ItalyValleyofTemple.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Italy Valley of Temple: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Italy Valley of Temple due to: {ex.Message}");
            }

            try
            {
                RialtoBridge.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Rialto Bridge: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Rialto Bridge due to: {ex.Message}");
            }

            try
            {
                Capri.Click();
                ItalyBackButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while clicking Capri: {ex.Message}");
                Test.Log(Status.Fail, $"Failed to click on Capri due to: {ex.Message}");
            }
        }


        //Identifiers
        //Famous Places
        IWebElement SevenWondersBack => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/backButton");

        IWebElement FamousPlacesBack => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/backButton");
        IWebElement Back => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/backButton");
        IWebElement MapBack => driver.FindElementByXPath("//android.widget.LinearLayout[@resource-id=\"com.google.android.apps.maps:id/compass_container\"]/android.widget.LinearLayout");

        IWebElement FamousPlace => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_places_bt");
        IWebElement AppopenAdBack => driver.FindElementByXPath("//android.widget.RelativeLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View[1]/android.view.View");
        IWebElement Acropolos => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Acropolos of Athens\"]");
        IWebElement BigBen => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[2]");
        IWebElement BurjKhalifa => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[3]");
        IWebElement BraindenBurg => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[4]");
        IWebElement Georges => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[5]");
        IWebElement EiffelTower => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[6]");
        IWebElement LondonEye => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[7]");
        IWebElement Kinderdijik => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[8]");
        IWebElement Louvire => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[9]");
        IWebElement Kaabah => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Kaabah\"]");
        IWebElement Mountfuji => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Mount Fuji\"]");
        IWebElement NatreDameDe => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Notre Dame De Paris\"]");
        IWebElement RomanForum => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Roman Forum\"]");
        IWebElement SaintBasils => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Saint Basil's Cathedral\"]");
        IWebElement StatueOf => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Statue of Liberty\"]");
        IWebElement Stonehenge => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Stonehenge\"]");
        IWebElement Colosseum => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Colosseum\"]");
        IWebElement MachuPicchu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Machu Picchu\"]");
        IWebElement TowerBridge => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Tower Bridge\"]");
        IWebElement SydneyOpera => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Sydney Opera House\"]");
        IWebElement TajMehel => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Taj Mahal\"]");

        //Seven Wonders
        IWebElement SevenWonders => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/seven_wonders_bt");
        IWebElement BackSevenWonders => driver.FindElementByXPath("//android.widget.LinearLayout[@resource-id=\"com.google.android.apps.maps:id/compass_container\"]/android.widget.LinearLayout");

        IWebElement Petra => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[1]");
        IWebElement GreatWall => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[2]");
        IWebElement TajMahal => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[3]");
        IWebElement TheColloseum => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[4]");
        IWebElement TheMachu => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[3]");
        IWebElement ChichenItza => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[4]");
        IWebElement Christtheredeemer => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[5]");

        IWebElement USAPanoramaMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/us_panorama_bt");
        //-------------------------------------------------------
        public IWebElement USABack => driver.FindElementById("");

        IWebElement NationalPark => driver.FindElementByXPath("(//android.view.ViewGroup[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/parentCl\"])[1]");
        IWebElement CBannerQuit => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[12]");
        IWebElement Antelope => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[2]");
        IWebElement BellagioHotel => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[3]");
        IWebElement DisneyKingdom => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[4]");
        IWebElement DisneyWorld => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[5]");
        IWebElement FloridaKeys => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[6]");
        IWebElement GoldenGateBridge => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[7]");
        IWebElement GrandCanyon => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[8]");
        IWebElement GrandTetonPark => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[9]");
        IWebElement LakeTahoe => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[4]");
        IWebElement MagicKingdomPark => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[5]");
        IWebElement MonumentValley => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[6]");
        IWebElement Maui => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[7]");
        IWebElement RedwoodNationaland => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[8]");
        IWebElement SouthBeachFlorida => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[9]");

        //-------------------------------------------------------
        IWebElement GermanyPanoramaMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/german_pan_bt");
        //-------------------------------------------------------
        public IWebElement GermanyBackButton => driver.FindElementById("");

        //Same As USA Panorama
        //-------------------------------------------------------
        public IWebElement PakistanBackButton => driver.FindElementById("");

        IWebElement PakistaniPanoramaMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/pak_pan_bt");
        //-------------------------------------------------------
        IWebElement AttabadLake => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[1]");
        IWebElement FaisalMasjid => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[2]");
        IWebElement MazareQaid => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[3]");
        IWebElement BadshahiMosque => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[4]");
        IWebElement MahodandLake => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[5]");
        IWebElement MinarePakistan => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[6]");
        IWebElement MargallaHills => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[7]");
        IWebElement MoenjoDaro => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[8]");
        IWebElement LakeSaifulMalook => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[9]");
        IWebElement SheeshMehal => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[1]");
        IWebElement PassuCones => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[2]");
        IWebElement SiriPaemedows => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[3]");
        IWebElement UshuForest => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[4]");
        IWebElement KumratValley => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[5]");
        IWebElement Lulusarlake => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[6]");
        IWebElement KundMalirBeach => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[7]");
        IWebElement WhitePalace => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[8]");

        //-------------------------------------------------------
        IWebElement FrancePanoramaMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView11");
        //-------------------------------------------------------
        public IWebElement FranceBackButton => driver.FindElementById("");

        IWebElement FranceEifferTower => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[1]");
        IWebElement FrancLouvire => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[2]");
        IWebElement FrancPalaceofVersalies => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[3]");
        IWebElement FrenchRiveria => driver.FindElementByXPath("(//android.view.View[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/view3\"])[4]");
        IWebElement MantSaint_Michel => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Mont Saint-Michel\"]");
        IWebElement LoireValleyChateu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Loire Valley Châteaux\"]");
        IWebElement Villandry => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Château de Villandry\"]");
        IWebElement FrancNatreDame => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Notre Dame\"]");
        IWebElement Mont_Blanc => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Chamonix-Mont-Blanc\"]");
        IWebElement Carcassonne => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Carcassonne\"]");
        IWebElement Brittany => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Brittany\"]");
        IWebElement Rocamadour => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Rocamadour\"]");
        IWebElement PrehistoricCavePaintings => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Prehistoric Cave Paintings in Lascaux\"]");

        //-------------------------------------------------------

        IWebElement UKPanoramaMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/textView12");
        //-------------------------------------------------------
        public IWebElement UKBackButton => driver.FindElementById("");

        IWebElement London => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"London\"]");
        IWebElement EdinBurgh => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Edinburgh\"]");
        IWebElement RomanBaths => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"The Roman Baths\"]");
        IWebElement StoneheigeUK => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Stonehenge\"]");
        IWebElement WindsorCastle => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Windsor Castle\"]");
        IWebElement Cotswolds => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Cotswolds\"]");
        IWebElement LakeDistrictNPark => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Lake District National Park\"]");
        IWebElement York => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"York\"]");
        IWebElement Canterbury => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Canterbury\"]");
        IWebElement LochNess => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Loch Ness\"]");
        IWebElement GiantsCauseway => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Giant's Causeway\"]");
        IWebElement ChannelIslandsUK => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Channel Islands\"]");
        IWebElement Belfast => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Belfast\"]");

        //-------------------------------------------------------

        IWebElement ItalyPanoramaMenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/italy_pan_bt");
        //-------------------------------------------------------//
        public IWebElement ItalyBackButton => driver.FindElementById("");

        IWebElement FlorenceItaly => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Florence Duomo\"]");
        IWebElement CanalVenice => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"The Grand Canal Venice\"]");
        IWebElement LeaningTowerofPiso => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Leaning Tower of Pisa\"]");
        IWebElement VacationCity => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Vatican City\"]");
        IWebElement UffiziGallery => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Uffizi Gallery\"]");
        IWebElement ClinqueTerre => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\" Cinque Terre\"]");
        IWebElement LakeComoItaly => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Lake Como\"]");
        IWebElement Pantheon => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Pantheon\"]");
        IWebElement VeronaArena => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Verona Arena\"]");
        IWebElement TreviFountain => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Trevi Fountain\"]");
        IWebElement AmalfiCoast => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Amalfi Coast\"]");
        IWebElement PompeiiMount => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Pompeii and Mount Vesuvius\"]");
        IWebElement ItalyRomanForum => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Roman Forum\"]");
        IWebElement DuomodiMilano => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Duomo di Milano\"]");
        IWebElement ItalyValleyofTemple => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"The Valley of Temples in Agrigento\"]");
        IWebElement RialtoBridge => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Rialto Bridge\"]");
        IWebElement Capri => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/famous_place_tv\" and @text=\"Capri\"]");

        IWebElement StreetViewmenu => driver.FindElementById("com.satellitemap.voice.navigation.gps.locationfinder.driving.directions:id/streetViewBtn");

        //-------------------------------------------------------//



    }
}
