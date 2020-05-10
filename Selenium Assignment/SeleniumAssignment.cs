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
            driver.Url = "http://www.westpac.co.nz/";
        }

        [Test]
        public void test()
        {
            //Create Home Page object
            objHomePage = new HomePage(driver);
            objHomePage.clickKiwisaver();

            //Create KiwiSaver Menu object
            objKiwiSaverMenu = new KiwiSaverPage(driver);
            objKiwiSaverMenu.clickProfileAndRetirementCalculator();

            //Create KiwiSaver Calculators object
            objKiwiSaverCalculators = new KiwiSaverCalculators(driver);
            objKiwiSaverCalculators.clickRetirementCalculator();

            //Create KiwiSaver Retirement Calculator
            objKiwiSaverRetirementCalculator = new KiwiSaverRetirementCalculator(driver);
            String calculatorPageTitle = objKiwiSaverRetirementCalculator.getCalculatorTitle();
            Assert.IsTrue(calculatorPageTitle.Contains("KiwiSaver Retirement Calculator"));

        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
