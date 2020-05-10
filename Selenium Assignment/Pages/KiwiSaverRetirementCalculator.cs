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
        By currentAgeInfoIcon = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[1]/div/div/div/div[2]/div[2]/div/div/div/button");
        By employmenStatusInfoIcon = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[2]/div/div/div/div[2]/div[2]/div/div/div/button");
        By pirInfoIcon = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[3]/div/div/div/div[2]/div[2]/div/div/div/button");
        By currentKiwiSaverBalanceInfoIcon = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[5]/div/div/div/div[2]/div[2]/div/div/div/button");
        By voluntaryContributionsInfoIcon = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[6]/div/div/div/div[2]/div[2]/div/div/div/button");
        By riskProfileInfoIcon = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[7]/div/div/div/div[2]/div[2]/div/div/div/button");
        By savingsGoalInfoIcon = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[8]/div/div/div/div[2]/div[2]/div/div/div/button");
        By currentAgeInfoText = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[1]/div/div/div/div[2]/div[1]/div[2]/div/p");
        
        By currentAge = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[1]/div/div/div/div[2]/div[1]/div[1]/div/div[1]/div/div[1]/div/div/input");
        By employmentStatus = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[2]/div/div/div/div[2]/div[1]/div[1]/div/div/div/div[1]");
        By employedStatus = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[2]/div/div/div/div[2]/div[1]/div[1]/div/div/div/div[2]/ul/li[2]/div/span");
        By notEmployedStatus = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[2]/div/div/div/div[2]/div[1]/div[1]/div/div/div/div[2]/ul/li[3]/div/span");
        By selfEmployedStatus = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[2]/div/div/div/div[2]/div[1]/div[1]/div/div/div/div[2]/ul/li[2]/div/span");

        By salaryPerYear = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[3]/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]/div/div/input");
        By memberContribution3 = By.Id("radio-option-07L");
        By memberContribution4 = By.Id("radio-option-07O");
        By memberContribution6 = By.Id("radio-option-07R");
        By memberContribution8 = By.Id("radio-option-07U");
        By prescribedInvestorRate = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[5]/div/div/div/div[2]/div[1]/div[1]/div/div[1]/div/div");
        By currentKiwisaverBalance = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[7]/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]/div/div/input");
        By voluntaryContributions = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[8]/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]/div[1]/div/input");
        By contributionFrequency = By.Id("/html/body/div/div/div/div[1]/div/div[1]/div/div[8]/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]/div[2]/div");
        By riskProfileLow = By.Id("radio-option-01V");
        By riskProfileMedium = By.Id("radio-option-01Y");
        By riskProfileHigh = By.XPath("radio-option-021");
        By savingsGoal = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[10]/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]/div/div/input");

        public KiwiSaverRetirementCalculator(IWebDriver driver)
        {
            this.driver = driver;
            driver.SwitchTo().Frame(0);
        }

        public String getCurrentAgeInfoText()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return driver.FindElement(currentAgeInfoText).Text;    
        }

        public void ClickCurrentAgeInfoIcon()
        {
            driver.FindElement(currentAgeInfoIcon).Click();
        }
        public void SelectEmploymentStatus(String status)
        {
            driver.FindElement(employmentStatus).Click();
            switch(status)
            { 
            case "Employed":
                    driver.FindElement(employedStatus).Click();
                    break;
            case "Self-employed":
                    driver.FindElement(selfEmployedStatus).Click();
                    break;
            case "Not employed":
                    driver.FindElement(notEmployedStatus).Click();
                    break;
            }
        }

        public void SetCurrentAge(String currentAgeInput)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(currentAge).SendKeys(currentAgeInput);
        }

        public bool CurrentAgeInfoIconDisplayed()
        {
            return driver.FindElement(currentAgeInfoIcon).Displayed;
        }
        public bool EmploymenStatusInfoIconDisplayed()
        {
            return driver.FindElement(employmenStatusInfoIcon).Displayed;
        }
        public bool PIRInfoIconDisplayed()
        {
            return driver.FindElement(pirInfoIcon).Displayed;        
        }
        public bool CurrentKiwiSaverBalanceInfoIconDisplayed()
        {
            return driver.FindElement(currentKiwiSaverBalanceInfoIcon).Displayed;
        }
        public bool VoluntaryContributionsInfoIconDisplayed()
        {
            return driver.FindElement(voluntaryContributionsInfoIcon).Displayed;
        }
        public bool RiskProfileInfoIconDisplayed()
        {
            return driver.FindElement(riskProfileInfoIcon).Displayed;
        }
        public bool SavingsGoalInfoIconDisplayed()
        {
            return driver.FindElement(savingsGoalInfoIcon).Displayed;
        }


    }
}
