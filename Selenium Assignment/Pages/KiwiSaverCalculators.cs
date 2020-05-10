using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Assignment.Pages
{
    public class KiwiSaverCalculators
    {
        IWebDriver driver;
        By titleText = By.ClassName("sw-page-heading");
        By retirementCalculatorButton = By.Id("responsive-children-title-3956-ps");

        public KiwiSaverCalculators(IWebDriver driver)
        {
            this.driver = driver;    
        }

        //Click on Retirement Calculator
        public void clickRetirementCalculator()
        {
            driver.FindElement(retirementCalculatorButton).Click();
        }
    }
}
