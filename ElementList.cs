using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace LloydsDCAutomation
{
    public class ElementList
    {
        private readonly ChromeDriver _driver;
        private readonly WebDriverWait _wait;

        public ElementList(ChromeDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }


        public void Launch()
        {

            _driver.Navigate()
                .GoToUrl("https://homeclaims.lloydsbank.com/sap/bc/ui5_ui5/ui2/ushell/shells/abap/Fiorilaunchpad.html");

            _driver.Manage().Cookies.DeleteAllCookies();

            _driver.Navigate().Refresh();


        }

        public IWebElement Username
        {
            get
            {
                return _wait.Until(x =>
                    x.FindElement(By.XPath("/html/body/div/div[4]/form/div[1]/div[1]/div/input")));
            }

        }

        public IWebElement Password
        {
            get
            {
                return _wait.Until(x =>
                    x.FindElement(By.XPath("/html/body/div/div[4]/form/div[1]/div[2]/div/input")));
            }
        }

        public IWebElement Login
        {
            get
            {
                return _wait.Until(x => x.FindElement(By.XPath("/html/body/div/div[4]/form/div[3]/div[1]/button/span[1]")));
            }

        }

        public IWebElement Supplier
        {
            get
            {
                return _wait.Until(x =>
                    x.FindElement(By.XPath(
                        "/html/body/div[4]/div/div/div/div/div[2]/section/div/div[2]/div[3]/section/div/div/div/div[2]/div/div/div/div/div/div/div/section/div/div[2]/div/div/ul/li/div[2]/div/div/div[4]/div/div[1]/div/span")));

            }
        }

        public IWebElement Attachments
        {
            get
            {
                return _wait.Until(x =>
                    x.FindElement(By.XPath(
                        "/html/body/div[4]/div/div/div/div/div[2]/section/div/div[2]/div[3]/section/div/div/div/div[2]/div/div[2]/div[3]/section/div/div/div/div/div/div[3]/div/div/div/section/div[2]/div[1]/div/div/div[4]/div[1]/span[1]")));
            }

        }

        public IWebElement AddAttachments
        {
            get
            {
                return _wait.Until(x =>
                    x.FindElement(By.XPath(
                        "/html/body/div[4]/div/div/div/div/div[2]/section/div/div[2]/div[3]/section/div/div/div/div[2]/div/div[2]/div[3]/section/div/div/div/div/div/div[3]/div/div/div/section/div[2]/div[2]/div/div/div[1]/button/div/span")));
            }
        }

        public Func<IWebDriver, IWebElement> ElementIsClickable(By locator)
        {

            return driver =>
            {
                var element = driver.FindElement(locator);
                return (element != null && element.Displayed && element.Enabled) ? element : null;
            };

        }



    }

}










