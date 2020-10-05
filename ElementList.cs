﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace LloydsDCAutomation
{
    public class ElementList
    {
        private readonly EdgeDriver _driver;
        private readonly WebDriverWait _wait;

        public ElementList(EdgeDriver driver, WebDriverWait wait)
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

            _driver.Manage().Window.Maximize();


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

        public IWebElement UploadFile
        {
            get
            {
                return _wait.Until(x =>
                    x.FindElement(By.XPath(
                        "/html/body/div[1]/div[2]/section/div/div/div/div/div/div/div[3]/div/div/div/div[2]/div/div/div/form/div/div[2]/input[1]")));
            }
        }

        public IWebElement Participants
        {
            get
            {
                return _wait.Until(x =>
                    x.FindElement(By.XPath(
                        "/html/body/div[4]/div/div/div/div/div[2]/section/div/div[2]/div[3]/section/div/div/div/div[2]/div/div[2]/div[3]/section/div/div/div/div/div/div[3]/div/div/div/section/div[2]/div[1]/div/div/div[5]/div[1]/span[1]")));
            }
        }

        public IWebElement ParticipantsList
        {
            get
            {
                return _driver.FindElement(By.XPath(
                        "/html/body/div[4]/div/div/div/div/div[2]/section/div/div[2]/div[3]/section/div/div/div/div[2]/div/div[2]/div[3]/section/div/div/div/div/div/div[3]/div/div/div/section/div[2]/div[2]/div/div/ul"));

                ;
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

        public IWebElement DescriptionOfAttachment
        {
            get
            {
                return _wait.Until(x =>
                    x.FindElement(By.XPath(
                        "/html/body/div[1]/div[2]/section/div/div/div/div/div/div/div[1]/div/div/div/div[2]/div/div/div")));
            }
        }

        public IWebElement attachmentsChooseSupplier
        {
            get
            {
                return _wait.Until(x => x.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/ul")));
            }
        }


        public string Suppliers()
        {

            var polygonSuppliers = new[]
            {
                $"Alpine Construction",
                "Armistead Buildings Services (ABS)",
                "Betacove Ltd",
                "Buildings Validation Solutions Ltd",
                "Camilleri Construction",
                "Capital Services",
                "Clark Contracts Ltd",
                "Crawfords General and Subs - LA",
                "Dale Building Maintenance",
                "EBL GROUP",
                "Alpine Construction",
                "Armistead Buildings Services (ABS)",
                "Betacove Ltd",
                "Buildings Validation Solutions Ltd",
                "Camilleri Construction",
                "Capital Services",
                "Clark Contracts Ltd",
                "Crawfords General and Subs - LA",
                "Dale Building Maintenance",
                "EBL GROUP",
                "Edinmore Contracts Ltd",
                "Heightvale",
                "Hemmings & Marshalsea",
                "HRNL",
                "Marlowe Industries Ltd",
                "McCane Construction",
                "MIDLANDS RESTORATION LTD",
                "Neways",
                "North East Building Services Ltd",
                "Phoenix Building Services",
                "Reeve Property Restoration Ltd",
                "Regent Develpoment",
                "RFM Group",
                "Roywood Contractors Ltd",
                "T Denman & Sons Ltd",
                "TBRN",
                "The Cotswold Group"
            };





            ReadOnlyCollection<IWebElement> participants = this.ParticipantsList.FindElements(By.ClassName("sapMSLITitle"));

            List<string> membersList = new List<string> { };

            var polygon = new string("");

            foreach (var company in participants)
            {
                
                string member = company.Text;

                membersList.Add(member);
                


            }

            
            foreach (var supplier in polygonSuppliers)
            {

                foreach (var member in membersList)
                {
                    if (supplier.Contains(member))
                    {
                        polygon = member;

                    }
                    else return null;

                }

            }

           return  polygon;



        }

    }

}










