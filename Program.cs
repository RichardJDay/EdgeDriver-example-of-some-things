﻿using System;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;



namespace LloydsDCAutomation
{
    class Program
    {
        //private readonly ElementList _elementList;

        public Program(ElementList elementList)
        {

        }


        static void Main(string[] args)
        {
            var options = new EdgeOptions();

            var driver = new EdgeDriver(options);


            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(40));
            var elements = new ElementList(driver, wait);



            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));


            elements.Launch();


            var insuranceRef = args[0].Substring(args[0].LastIndexOf(":", StringComparison.Ordinal) + 2);

            elements.Username.SendKeys("F000359");

            elements.Password.SendKeys("Coconut2!");

            elements.Login.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            elements.Supplier.Click();



            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120);





            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);

            var searchClaim = wait.Until(x =>
                x.FindElement(
                    By.XPath("//*[@id=\"application-ZSupplierSemObj-display-component---master--searchField-I\"]")));
            searchClaim.SendKeys(insuranceRef);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(110);







            Thread.Sleep(TimeSpan.FromSeconds(80));

            elements.Participants.Click();
            //var participantLisa = driver.FindElement(By.XPath(
            //    "/html/body/div[4]/div/div/div/div/div[2]/section/div/div[2]/div[3]/section/div/div/div/div[2]/div/div[2]/div[3]/section/div/div/div/div/div/div[3]/div/div/div/section/div[2]/div[2]/div/div/ul"));



            var participants =

                driver.FindElement(By.XPath(
                    "/html/body/div[4]/div/div/div/div/div[2]/section/div/div[2]/div[3]/section/div/div/div/div[2]/div/div[2]/div[3]/section/div/div/div/div/div/div[3]/div/div/div/section/div[2]/div[2]/div/div/ul"));


            Console.WriteLine(elements.Suppliers());


            elements.Attachments.Click();
            elements.AddAttachments.Click();

            //This is where I'm trying to switch to the popup

            driver.SwitchTo().Frame("id-1601915183555-71");

           
            elements.DescriptionOfAttachment.SendKeys("Polygon DC");

           


            elements.attachmentsChooseSupplier.SendKeys(elements.Suppliers());



            Console.WriteLine($"{participants.Text} This is from the p");



            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);



          



            Console.WriteLine("Hello World!");



        }








    }
}