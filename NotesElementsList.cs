using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace SimplyAutomationLloydsDC
{
    class NotesElementsList
    {
        private readonly EdgeDriver _driver;
        private readonly WebDriverWait _wait;


        public NotesElementsList(EdgeDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }


        public IWebElement Notes
        {
            get
            {
                return _wait.Until(x =>
                    x.FindElement(By.XPath(
                        "/html/body/div[4]/div/div/div/div/div[2]/section/div/div[2]/div[3]/section/div/div/div/div[2]/div/div[2]/div[3]/section/div/div/div/div/div/div[3]/div/div/div/section/div[2]/div[1]/div/div/div[3]/div[1]/span[1]")));
            }
        }

        public IWebElement AddNote
        {
            get
            {

                return _wait.Until(x =>
                    x.FindElement(By.XPath(
                        "/html/body/div[4]/div/div/div/div/div[2]/section/div/div[2]/div[3]/section/div/div/div/div[2]/div/div[2]/div[3]/section/div/div/div/div/div/div[3]/div/div/div/section/div[2]/div[2]/div/div/div[1]/button/div/span")));
            }
        }

        public IWebElement NotesSupplierDropdown
        {
            get
            {

                return _wait.Until(x =>
                    x.FindElement(By.XPath(
                        "//*[@id=\"application-ZSupplierSemObj-display-component---detail--idSupplier2-label\"]")));
            }
        }

        public IWebElement NoteTitle
        {
            get
            {
                return _wait.Until(x =>
                    x.FindElement(By.XPath(
                        "//*[@id=\"application-ZSupplierSemObj-display-component---detail--idNotetabNoteTitle-inner\"]")));
            }
        }

        public IWebElement NoteText
        {
            get
            {
               return _wait.Until(x =>
                    x.FindElement(By.XPath(
                        "//*[@id=\"application-ZSupplierSemObj-display-component---detail--idFeedNote-inner\"]")));
            }
        }


    }
}
