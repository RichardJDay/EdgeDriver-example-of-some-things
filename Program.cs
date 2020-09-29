using System;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            var options = new ChromeOptions();
            var driver = new ChromeDriver(options);

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            var elements = new ElementList(driver, wait);



            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));


            elements.Launch();


            var insuranceRef = args[0].Substring(57, 9);

            elements.Username.SendKeys("F000254");

            elements.Password.SendKeys("Zovan18!");

            elements.Login.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

           
            elements.Supplier.Click();



            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120);

            
            


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);

            var searchClaim = wait.Until(x =>
                x.FindElement(
                    By.XPath("//*[@id=\"application-ZSupplierSemObj-display-component---master--searchField-I\"]")));
            searchClaim.SendKeys(insuranceRef);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);







            Thread.Sleep(TimeSpan.FromSeconds(100));


            elements.Attachments.Click();

            elements.AddAttachments.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);


            //builder.SendKeys(Keys.Enter);



            Console.WriteLine("Hello World!");


            //        }
            //}
            //}
        }
    }
}