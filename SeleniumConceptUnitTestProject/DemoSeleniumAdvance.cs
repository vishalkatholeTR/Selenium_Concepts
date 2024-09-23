using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Internal;

namespace SeleniumConceptUnitTestProject
{
    public class DemoSeleniumAdvance
    {
        [Test]
        public void demose()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.db4free.net/";
           // driver.FindElement(By.LinkText("phpMyAdmin")).Click();
            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.Id("input_username")).SendKeys("admin");
            // driver.Close();
            driver.FindElement(By.Id("input_password")).SendKeys("admin123");
            driver.FindElement(By.Id("input_go")).Click();
            driver.Quit();
        }

        [Test]
        public void demose2()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://www.online.citibank.co.in/";
            //close all popup
            driver.FindElement(By.XPath("//div[@class='popup-1']/a")).Click();
            driver.FindElement(By.XPath("//div[@class='popup-2']/a")).Click();

            //click on Banking
            driver.FindElement(By.Id("topMnubanking")).Click();
            //click on Citi Commercial Bank
            driver.FindElement(By.LinkText("Citi Commercial Bank")).Click();
            //Switched to second tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            //click on Branch/ATM
            driver.FindElement(By.XPath("//a[@title='Branch/ATM']")).Click();

          
        }

    }
}
