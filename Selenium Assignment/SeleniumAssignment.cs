using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Selenium_Assignment.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Assignment
{
    class SeleniumAssignment
    {
        IWebDriver driver;
        HomePage objHomePage;
        KiwiSaverPage objKiwiSaverMenu;
        KiwiSaverCalculators objKiwiSaverCalculators;
        KiwiSaverRetirementCalculator objKiwiSaverRetirementCalculator;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();            
        }

        [Test]
        public void TestUserStory1()
        {
            driver.Url = "http://www.westpac.co.nz/";
            //Create Home Page object
            objHomePage = new HomePage(driver);
            //Navigate to Kiwisaver page
            objHomePage.clickKiwisaver();

            //Create KiwiSaver Menu object
            objKiwiSaverMenu = new KiwiSaverPage(driver);
            //Navigate to KiwiSaver Calculators page
            objKiwiSaverMenu.clickProfileAndRetirementCalculator();

            //Create KiwiSaver Calculators object
            objKiwiSaverCalculators = new KiwiSaverCalculators(driver);
            //Navigate to Retirement Calculator page
            objKiwiSaverCalculators.clickRetirementCalculator();

            //Create KiwiSaver Retirement Calculator object
            objKiwiSaverRetirementCalculator = new KiwiSaverRetirementCalculator(driver);
            //verify that info icons are displayed
            Assert.IsTrue(objKiwiSaverRetirementCalculator.CurrentAgeInfoIconDisplayed());
            Assert.IsTrue(objKiwiSaverRetirementCalculator.EmploymenStatusInfoIconDisplayed());
            Assert.IsTrue(objKiwiSaverRetirementCalculator.PIRInfoIconDisplayed());
            Assert.IsTrue(objKiwiSaverRetirementCalculator.CurrentKiwiSaverBalanceInfoIconDisplayed());
            Assert.IsTrue(objKiwiSaverRetirementCalculator.VoluntaryContributionsInfoIconDisplayed());
            Assert.IsTrue(objKiwiSaverRetirementCalculator.RiskProfileInfoIconDisplayed());
            Assert.IsTrue(objKiwiSaverRetirementCalculator.SavingsGoalInfoIconDisplayed());

            //Click on Current Age info icon
            objKiwiSaverRetirementCalculator.ClickCurrentAgeInfoIcon();
            //Verify that correct message is displayed
            String currentAgeiInfoText = objKiwiSaverRetirementCalculator.getCurrentAgeInfoText();
            Assert.IsTrue(currentAgeiInfoText.Contains("This calculator has an age limit of 84 years old."));
        }

        [Test]
        public void TestUserStory2_S1()
        {
            driver.Url = "https://www.westpac.co.nz/kiwisaver/calculators/kiwisaver-calculator/";
           
            //Create KiwiSaver Retirement Calculator object
            objKiwiSaverRetirementCalculator = new KiwiSaverRetirementCalculator(driver);
            objKiwiSaverRetirementCalculator.SetCurrentAge("30");
            objKiwiSaverRetirementCalculator.SelectEmploymentStatus("Employed");
        }



        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
