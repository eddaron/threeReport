using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestSolution
{
    [TestClass]
    public class Test
    {
        //framework base: c#
        //ui framework: Selenium webdriver
        //unit framework: MSTest

        IWebDriver webDriver;

        public Test()
        {
            webDriver = new ChromeDriver(@"C:\SeleniumWebDrivers");
        }

        [TestMethod]
        public void MyFirstTest()
        {
            //navigate to automation practice site
            webDriver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            //capture contact Us button
            IWebElement contactUsButton = webDriver.FindElement(By.Id("contact-link"));
            contactUsButton.Click();

            //capture subject heading combo box
            IWebElement subjectHeading = webDriver.FindElement(By.Id("id_contact"));
            SelectElement subjectHeadingCombobox = new SelectElement(subjectHeading);
            subjectHeadingCombobox.SelectByText("Customer service");

            //capture email address input
            IWebElement emailAddressInput = webDriver.FindElement(By.Name("from"));
            emailAddressInput.SendKeys("daniel.terceros.b@gmail.com");

            //id_order
            IWebElement orderReferenceInput = webDriver.FindElement(By.Name("id_order"));
            orderReferenceInput.SendKeys("1234");

            //fileUpload
            IWebElement attachFile = webDriver.FindElement(By.Id("fileUpload"));
            attachFile.SendKeys(@"D:\gggg.txt");

            //message
            IWebElement messageInput = webDriver.FindElement(By.Id("message"));
            messageInput.SendKeys("Test message");

            //submitMessage
            IWebElement SendButton = webDriver.FindElement(By.Id("submitMessage"));
            SendButton.Click();

            //Your message has been successfully sent to our team.
            //p[@class='alert alert-success']
            IWebElement confirmatioLabel = webDriver.FindElement(By.XPath("//p[@class='alert alert-success']"));
            string actualMessage = confirmatioLabel.Text; //system data
            string expectedMessage = "Your message has been successfully sent to our team."; //expected data

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
