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

            var participantsDropdown = wait.Until(x => x.FindElement(By.XPath("/html/body/div[1]/div[2]/section/div/div/div/div/div/div/div[2]/div/div/div/div[2]/div/div/div/label")));

            participantsDropdown.Click();



            ReadOnlyCollection<IWebElement> participantsList = elements.ParticipantsList.FindElements(By.XPath("/html/body/div[1]/div[3]/div/div/ul/li"));
            var suppliers = elements.Suppliers(participantsList);


            var supplierDropdown = wait.Until(x => x.FindElement(By.XPath("//*[@id=\"idSupplierSelect-cont0_1\"]")));
            var supplierToNotify = suppliers.First();

            var look = driver.SwitchTo().ActiveElement().Text;


            var attachmentsSupplierDropdown = driver.FindElement(By.XPath($"//li[text()='{supplierToNotify}']"));
            attachmentsSupplierDropdown.Click();


            var fileUpload = wait.Until(x => x.FindElement(By.XPath("//*[@id=\"idFileUploader-fu\"]")));

            fileUpload.SendKeys($@"c:\temp\{args[1]}.pdf");


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);




            Console.ReadLine();
            var notes = wait.Until(x =>
                x.FindElement(By.XPath(
                    "/html/body/div[4]/div/div/div/div/div[2]/section/div/div[2]/div[3]/section/div/div/div/div[2]/div/div[2]/div[3]/section/div/div/div/div/div/div[3]/div/div/div/section/div[2]/div[1]/div/div/div[3]/div[1]/span[1]")));
            notes.Click();

            Thread.Sleep(TimeSpan.FromSeconds(3));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            var addNote = wait.Until(x =>
                x.FindElement(By.XPath(
                    "/html/body/div[4]/div/div/div/div/div[2]/section/div/div[2]/div[3]/section/div/div/div/div[2]/div/div[2]/div[3]/section/div/div/div/div/div/div[3]/div/div/div/section/div[2]/div[2]/div/div/div[1]/button/div/span")));
            addNote.Click();

            Thread.Sleep(TimeSpan.FromSeconds(3));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            var notesSupplierNoteDropdown = wait.Until(x =>
                x.FindElement(By.XPath(
                    "//*[@id=\"application-ZSupplierSemObj-display-component---detail--idSupplier2-label\"]")));

            notesSupplierNoteDropdown.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);



            driver.SwitchTo().ActiveElement();

            Thread.Sleep(TimeSpan.FromSeconds(3));

            var waitforthis = wait.Until(x =>
                x.FindElement(
                    By.XPath($"/html/body/div[1]/div[3]/div/div/ul/li[text()='{supplierToNotify}']")));
            waitforthis.Click();

            var noteTitle = wait.Until(x =>
                x.FindElement(By.XPath(
                    "//*[@id=\"application-ZSupplierSemObj-display-component---detail--idNotetabNoteTitle-inner\"]")));
            noteTitle.SendKeys("Polygon Drying Certificate");

            var noteText = wait.Until(x =>
                x.FindElement(By.XPath(
                    "//*[@id=\"application-ZSupplierSemObj-display-component---detail--idFeedNote-inner\"]")));
            noteText.SendKeys("Polygon Drying Certificate");


            var lookhere = driver.SwitchTo().ActiveElement().TagName;




            Console.WriteLine("Hello World!");



        }








    }
}