using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace SimplyAutomationLloydsDC
{
    class AttachmentsElementsList
    {
        private readonly EdgeDriver _driver;
        private readonly WebDriverWait _wait;


        public AttachmentsElementsList(EdgeDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        public IWebElement FileUpload
        {
            get
            {
                return _wait.Until(x => x.FindElement(By.XPath("//*[@id=\"idFileUploader-fu\"]")));

            }
        }

       
    }
}
