using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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

        By iFrame = By.XPath("/html/body/div[1]/div[1]/div/div[2]/div/div[2]/div/iframe");
        //Info icons
        By currentAgeInfoIcon = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[1]/div/div/div/div[2]/div[2]/div/div/div/button");
        By employmenStatusInfoIcon = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[2]/div/div/div/div[2]/div[2]/div/div/div/button");
        By pirInfoIcon = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[3]/div/div/div/div[2]/div[2]/div/div/div/button");
        By currentKiwiSaverBalanceInfoIcon = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[5]/div/div/div/div[2]/div[2]/div/div/div/button");
        By voluntaryContributionsInfoIcon = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[6]/div/div/div/div[2]/div[2]/div/div/div/button");
        By riskProfileInfoIcon = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[7]/div/div/div/div[2]/div[2]/div/div/div/button");
        By savingsGoalInfoIcon = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[8]/div/div/div/div[2]/div[2]/div/div/div/button");
        By currentAgeInfoText = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[1]/div/div/div/div[2]/div[1]/div[2]/div/p");

        By currentAge = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[1]/div/div/div/div[2]/div[1]/div[1]/div/div[1]/div/div[1]/div/div/input");
        //Employment status
        By employmentStatus = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[2]/div/div/div/div[2]/div[1]/div[1]/div/div/div/div[1]");
        By employedStatus = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[2]/div/div/div/div[2]/div[1]/div[1]/div/div/div/div[2]/ul/li[2]/div/span");
        By notEmployedStatus = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[2]/div/div/div/div[2]/div[1]/div[1]/div/div/div/div[2]/ul/li[3]/div/span");
        By selfEmployedStatus = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[2]/div/div/div/div[2]/div[1]/div[1]/div/div/div/div[2]/ul/li[2]/div/span");
        //Member contribution
        By salaryPerYear = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[3]/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]/div/div/input");
        By contribution3Percent = By.Id("radio-option-06B");
        By contribution4Percent = By.Id("radio-option-06E");
        By contribution6Percent = By.Id("radio-option-06H");
        By contribution8Percent = By.Id("radio-option-06K");
        By contribution10Percent = By.Id("radio-option-06N");
        //PIR
        By prescribedInvestorRate = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[5]/div/div/div/div[2]/div[1]/div[1]/div/div[1]/div/div");
        By rate10AndHalfPercent = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[5]/div/div/div/div[2]/div[1]/div[1]/div/div[1]/div/div/div[2]/ul/div[1]/li/div/span");
        By rate17AndHalfPercent = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[5]/div/div/div/div[2]/div[1]/div[1]/div/div[1]/div/div/div[2]/ul/div[2]/li/div/span");
        By rate28Percent = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[5]/div/div/div/div[2]/div[1]/div[1]/div/div[1]/div/div/div[2]/ul/div[3]/li/div/span");

        By currentKiwisaverBalance = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[7]/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]/div/div/input");
        By voluntaryContributions = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[8]/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]/div[1]/div/input");
        By contributionFrequency = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[6]/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]/div[2]/div/div[1]");
        By savingsGoal = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[10]/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]/div/div/input");
        //Risk profiles
        By riskProfileLow = By.Id("radio-option-01V");
        By riskProfileMedium = By.Id("radio-option-01Y");
        By riskProfileHigh = By.Id("radio-option-021");
        //Contribution frequency
        By oneOff = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[8]/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]/div[2]/div/div[2]/ul/li[2]/div/span");
        By weekly = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[8]/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]/div[2]/div/div[2]/ul/li[3]/div/span");
        By fortnightly = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[8]/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]/div[2]/div/div[2]/ul/li[4]/div/span");
        By monthly = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[8]/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]/div[2]/div/div[2]/ul/li[5]/div/span");
        By annually = By.XPath("/html/body/div/div/div/div[1]/div/div[1]/div/div[8]/div/div/div/div[2]/div[1]/div[1]/div/div/div[1]/div[2]/div/div[2]/ul/li[6]/div/span");

        By retirementPropjectionsButton = By.ClassName("btn-results-reveal");
        By resultsTitle = By.ClassName("result-title");
        By resultValue = By.ClassName("result-value");

        public KiwiSaverRetirementCalculator(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 20));
            var element = wait.Until(c => c.FindElement(iFrame));
            driver.SwitchTo().Frame(0);
        }
        
        public String getCurrentAgeInfoText()
        {
            return driver.FindElement(currentAgeInfoText).Text;
        }
        public String getResultsTitleText()
        {
            return driver.FindElement(resultsTitle).Text;
        }
        public String getResultValue()
        {
            return driver.FindElement(resultValue).Text;
        }

        public void ClickCurrentAgeInfoIcon()
        {
            driver.FindElement(currentAgeInfoIcon).Click();
        }

        public void SelectEmploymentStatus(String status)
        {
            driver.FindElement(employmentStatus).Click();
            switch (status)
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

        public void SelectContributionPercent(String percent)
        {           
            switch (percent)
            {
                case "3%":
                    driver.FindElement(contribution3Percent).Click();
                    break;
                case "4%":
                    driver.FindElement(contribution4Percent).Click();
                    break;
                case "6%":
                    driver.FindElement(contribution6Percent).Click();
                    break;
                case "8%":
                    driver.FindElement(contribution8Percent).Click();
                    break;
                case "10%":
                    driver.FindElement(contribution10Percent).Click();
                    break;
            }
        }

        public void SelectPIR(String pir)
        {
            driver.FindElement(prescribedInvestorRate).Click();
            switch (pir)
            {
                case "10.5%":
                    driver.FindElement(rate10AndHalfPercent).Click();
                    break;
                case "17.5%":
                    driver.FindElement(rate17AndHalfPercent).Click();
                    break;
                case "28%":
                    driver.FindElement(rate28Percent).Click();
                    break;
            }
        }
        public void SelectRiskProfile(String risk)
        {
            switch (risk)
            {
                case "Low":
                    driver.FindElement(riskProfileLow).Click();
                    break;
                case "Medium":
                    driver.FindElement(riskProfileMedium).Click();
                    break;
                case "High":
                    driver.FindElement(riskProfileHigh).Click();
                    break;
            }
        }

        public void SetCurrentAge(String currentAgeInput)
        {           
            driver.FindElement(currentAge).SendKeys(currentAgeInput);
        }
        public void SetSalaryPerYear(String salaryInput)
        {           
            driver.FindElement(salaryPerYear).SendKeys(salaryInput);
        }
        public void SetCurrentKiwisaverBalance(String currentBalance)
        {
            driver.FindElement(currentKiwisaverBalance).SendKeys(currentBalance);
        }
        public void SetSavingsGoal(String goal)
        {
            driver.FindElement(savingsGoal).SendKeys(goal);
        }

        public void SetVoluntaryContibution(String contibutionAmount, String frequency)
        {
            driver.FindElement(voluntaryContributions).SendKeys(contibutionAmount);
            driver.FindElement(contributionFrequency).Click();
            switch (frequency)
            {
                case "One-off":
                    driver.FindElement(oneOff).Click();
                    break;
                case "Weekly":
                    driver.FindElement(weekly).Click();
                    break;
                case "Fortnightly":
                    driver.FindElement(fortnightly).Click();
                    break;
                case "Monthly":
                    driver.FindElement(monthly).Click();
                    break;
                case "Annually":
                    driver.FindElement(annually).Click();
                    break;
            }
        }
        public void ClickRetirementProjectionsButton()
        {
            driver.FindElement(retirementPropjectionsButton).Click();
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
        public bool ResultsTitleDisplayed()
        {
            return driver.FindElement(resultsTitle).Displayed;
        }
        public bool ResultValueDisplayed()
        {
            return driver.FindElement(resultValue).Displayed;
        }

    }       
}
