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
        public void TUS1_S1()
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
        public void TUS2_User1()
        {
            driver.Url = "https://www.westpac.co.nz/kiwisaver/calculators/kiwisaver-calculator/";
           
            //Create KiwiSaver Retirement Calculator object
            objKiwiSaverRetirementCalculator = new KiwiSaverRetirementCalculator(driver);
            //Input all parameters
            objKiwiSaverRetirementCalculator.SetCurrentAge("30");
            objKiwiSaverRetirementCalculator.SelectEmploymentStatus("Employed");
            objKiwiSaverRetirementCalculator.SetSalaryPerYear("82000");
            objKiwiSaverRetirementCalculator.SelectContributionPercent("4%");
            objKiwiSaverRetirementCalculator.SelectPIR("17.5%");
            objKiwiSaverRetirementCalculator.SelectRiskProfile("High");
            //Click retirement projections button
            objKiwiSaverRetirementCalculator.ClickRetirementProjectionsButton();
            //Verify that projected balance is displayed
            Assert.IsTrue(objKiwiSaverRetirementCalculator.ResultsTitleDisplayed());
            String resultsTitleText = objKiwiSaverRetirementCalculator.getResultsTitleText();
            Assert.IsTrue(resultsTitleText.Contains("At age 65, your KiwiSaver balance is estimated to be:"));
            Assert.IsTrue(objKiwiSaverRetirementCalculator.ResultValueDisplayed());
            String resultValue = objKiwiSaverRetirementCalculator.getResultValue();
            Assert.IsTrue(resultValue.Contains("279,558"));
                       
        }

        [Test]
        public void TUS2_User2()
        {
            driver.Url = "https://www.westpac.co.nz/kiwisaver/calculators/kiwisaver-calculator/";

            //Create KiwiSaver Retirement Calculator object
            objKiwiSaverRetirementCalculator = new KiwiSaverRetirementCalculator(driver);
            //Input all parameters
            objKiwiSaverRetirementCalculator.SetCurrentAge("45");
            objKiwiSaverRetirementCalculator.SelectEmploymentStatus("SelfEmployed");
            objKiwiSaverRetirementCalculator.SelectPIR("10.5%");
            objKiwiSaverRetirementCalculator.SetCurrentKiwisaverBalance("100000");
            objKiwiSaverRetirementCalculator.SetVoluntaryContribution("90","Fortnightly");
            objKiwiSaverRetirementCalculator.SelectRiskProfile("Medium");
            objKiwiSaverRetirementCalculator.SetSavingsGoal("290000");
            //Click retirement projections button
            objKiwiSaverRetirementCalculator.ClickRetirementProjectionsButton();
            //Verify that projected balance is displayed
            Assert.IsTrue(objKiwiSaverRetirementCalculator.ResultsTitleDisplayed());
            String resultsTitleText = objKiwiSaverRetirementCalculator.getResultsTitleText();
            Assert.IsTrue(resultsTitleText.Contains("At age 65, your KiwiSaver balance is estimated to be:"));
            Assert.IsTrue(objKiwiSaverRetirementCalculator.ResultValueDisplayed());
            String resultValue = objKiwiSaverRetirementCalculator.getResultValue();
            Assert.IsTrue(resultValue.Contains("212,440"));
        }

        [Test]
        public void TUS2_User3()
        {
            driver.Url = "https://www.westpac.co.nz/kiwisaver/calculators/kiwisaver-calculator/";

            //Create KiwiSaver Retirement Calculator object
            objKiwiSaverRetirementCalculator = new KiwiSaverRetirementCalculator(driver);
            //Input all parameters
            objKiwiSaverRetirementCalculator.SetCurrentAge("55");
            objKiwiSaverRetirementCalculator.SelectEmploymentStatus("Not employed");
            objKiwiSaverRetirementCalculator.SelectPIR("10.5%");
            objKiwiSaverRetirementCalculator.SetCurrentKiwisaverBalance("140000");
            objKiwiSaverRetirementCalculator.SetVoluntaryContribution("10", "Annually");
            objKiwiSaverRetirementCalculator.SelectRiskProfile("Medium");
            objKiwiSaverRetirementCalculator.SetSavingsGoal("200000");
            //Click retirement projections button
            objKiwiSaverRetirementCalculator.ClickRetirementProjectionsButton();
            //Verify that projected balance is displayed
            Assert.IsTrue(objKiwiSaverRetirementCalculator.ResultsTitleDisplayed());
            String resultsTitleText = objKiwiSaverRetirementCalculator.getResultsTitleText();
            Assert.IsTrue(resultsTitleText.Contains("At age 65, your KiwiSaver balance is estimated to be:"));
            Assert.IsTrue(objKiwiSaverRetirementCalculator.ResultValueDisplayed());
            String resultValue = objKiwiSaverRetirementCalculator.getResultValue();
            Assert.IsTrue(resultValue.Contains("168,425"));
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
