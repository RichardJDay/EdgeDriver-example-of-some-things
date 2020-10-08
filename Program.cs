using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SimplyAutomationLloydsDC;


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
            var attachmentsElementsList = new AttachmentsElementsList(driver, wait);
            var infoElemtsList = new InfoElementsList(driver, wait);
            var notesElementsList = new NotesElementsList(driver, wait);
            var getSuppliersList = new GetSupplierList();






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

            elements.SearchButton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(110);







            Thread.Sleep(TimeSpan.FromSeconds(100));

            //elements.Participants.Click();

            //ReadOnlyCollection<IWebElement> participants = elements.ParticipantsList.FindElements(By.ClassName("sapMSLITitle"));



            //var suppliers = elements.Suppliers();





            elements.Attachments.Click();
            elements.AddAttachments.Click();


            Thread.Sleep(TimeSpan.FromSeconds(3));
            driver.SwitchTo().ActiveElement();

            var frame = driver.SwitchTo().ActiveElement().TagName;
            Thread.Sleep(TimeSpan.FromSeconds(3));
            elements.DescriptionOfAttachment.SendKeys("Polygon DC");

            //Thread.Sleep(TimeSpan.FromSeconds(60));
            elements.AttachmentText.SendKeys(args[1]);

            elements.AttachmentsSupplierDropdown.Click();



            ReadOnlyCollection<IWebElement> participantsList = elements.ParticipantsList.FindElements(By.XPath("/html/body/div[1]/div[3]/div/div/ul/li"));
            var attachmentsSuppliersList = getSuppliersList.Suppliers(participantsList);
           


            var supplierDropdown = wait.Until(x => x.FindElement(By.XPath("//*[@id=\"idSupplierSelect-cont0_1\"]")));
            var supplier = attachmentsSuppliersList.First();

            var look = driver.SwitchTo().ActiveElement().Text;



            var attachmentsSupplierDropdown = driver.FindElement(By.XPath($"//li[text()='{supplier}']"));
            attachmentsSupplierDropdown.Click();



            attachmentsElementsList.FileUpload.SendKeys($@"c:\temp\{args[1]}.pdf");


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);




            Console.ReadLine();
            
            notesElementsList.Notes.Click();

            Thread.Sleep(TimeSpan.FromSeconds(3));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            notesElementsList.AddNote.Click();

            Thread.Sleep(TimeSpan.FromSeconds(3));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);


            notesElementsList.NotesSupplierDropdown.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);



            driver.SwitchTo().ActiveElement();

            Thread.Sleep(TimeSpan.FromSeconds(3));

            var waitforthis = wait.Until(x =>
                x.FindElement(
                    By.XPath($"/html/body/div[1]/div[3]/div/div/ul/li[text()='{supplier}']")));
            waitforthis.Click();

           
            notesElementsList.NoteTitle.SendKeys("Polygon Drying Certificate");

            
            notesElementsList.NoteText.SendKeys("Polygon Drying Certificate");


            var lookhere = driver.SwitchTo().ActiveElement().TagName;
            Console.ReadLine();


            infoElemtsList.Info.Click();


            Console.WriteLine("Hello World!");



        }








    }
}