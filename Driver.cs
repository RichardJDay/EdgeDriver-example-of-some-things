//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.UI;

//namespace LloydsDCAutomation
//{
//     public class Driver : IDriver
//    {

//        public ChromeDriver ChromeDriver()
//        {
            
//                var options = new ChromeOptions();
//                var driver = new ChromeDriver(options);
//                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
//                return driver;
//        }

//        public WebDriverWait Wait()
//        {
//            var wait = new WebDriverWait(this.ChromeDriver(), TimeSpan.FromSeconds(10));
//            return wait;
//        }
//    }
//}
