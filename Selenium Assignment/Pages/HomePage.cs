using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Assignment.Pages
{
    public class HomePage
    {
        IWebDriver driver;
        By kiwisaverNavTab = By.Id("ubermenu-section-link-kiwisaver-ps");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;    
        }

        //Click Kiwisaver menu tab
        public void clickKiwisaver()
        {
            driver.FindElement(kiwisaverNavTab).Click();
        }
    }

}
