using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace SimplyAutomationLloydsDC
{
    class InfoElementsList
    {
        private readonly EdgeDriver _driver;
        private readonly WebDriverWait _wait;

        public InfoElementsList(EdgeDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        public IWebElement Info
        {
            get
            {
                return _wait.Until(x =>
                    x.FindElement(By.XPath(
                        "//*[@id=\"application-ZSupplierSemObj-display-component---detail--iconTabBarFilter11-icon\"]")));
            }
        }


    }
}
