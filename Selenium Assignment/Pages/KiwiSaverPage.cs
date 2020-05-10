using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Assignment.Pages
{
    public class KiwiSaverPage
    {
        IWebDriver driver;
        By riskProfileAndRetirementCalculator = By.Id("sidenav-responsive-children-title-4825-ps");

        public KiwiSaverPage(IWebDriver driver)
        {
            this.driver = driver;    
        }

        //Click KiwiSaver Calculator button
        public void clickProfileAndRetirementCalculator()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(riskProfileAndRetirementCalculator).Click(); 
        }
    }

}
