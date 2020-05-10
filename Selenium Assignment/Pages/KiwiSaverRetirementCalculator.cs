using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Assignment.Pages
{
    public class KiwiSaverRetirementCalculator
    {
        IWebDriver driver;
        By titleText = By.TagName("h1");
        By currentAgeInfoIcon = By.XPath("//*[@id='widget']/div/div[1]/div/div[1]/div/div[2]/div/div/div/div[2]/div[2]/div/div/div/button");
        By employmenStatusInfoIcon = By.XPath("//*[@id='widget']/div/div[1]/div/div[1]/div/div[3]/div/div/div/div[2]/div[2]/div/div/div/button");
        By currentKiwiSaverBalanceInfoIcon = By.XPath("//*[@id='widget']/div/div[1]/div/div[1]/div/div[5]/div/div/div/div[2]/div[2]/div/div/div/button");
        By voluntaryContributionsInfoIcon = By.XPath("//*[@id='widget']/div/div[1]/div/div[1]/div/div[6]/div/div/div/div[2]/div[2]/div/div/div/button");
        By riskProfileInfoIcon = By.XPath("//*[@id='widget']/div/div[1]/div/div[1]/div/div[7]/div/div/div/div[2]/div[2]/div/div/div/button");
        By savingsGoalInfoIcon = By.XPath("//*[@id='widget']/div/div[1]/div/div[1]/div/div[8]/div/div/div/div[2]/div[2]/div/div/div/button");

        public KiwiSaverRetirementCalculator(IWebDriver driver)
        {
            this.driver = driver;    
        }

        public String getCalculatorTitle()
        {
            return driver.FindElement(titleText).Text;    
        }
    }
}
