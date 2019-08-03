using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pageObjectLibrary.AutomationPractice.ContacUs
{
    class ContactUsPage
    {
        IWebDriver webDriver;
        public ContactUsPage(IWebDriver)
        {
            this.webDriver = webDriver;
        }
        public enum Options
        {
            ByText,
            ByValue,
            ByIndex
        }


        public void SelectHeadingCombobox(Options option, string value) {
                    IWebElement subjectHeading = webDriver.FindElement(By.Id("id_contact"));
                SelectElement subjectHeadingCombobox = new SelectElement(subjectHeading);
                subjectHeadingCombobox.SelectByText("Customer service");
            switch (option)
            {
                case Options.ByText:
                    subjectHeadingCombobox.SelectByText(value);
                    break;

                case Options.ByValue:
                    subjectHeadingCombobox.SelectByValue(value);
                    break;
                case Options.ByIndex:
                    subjectHeadingCombobox.SelectByIndex();
                    break;
            }

        }
        public void SetEmailAddress(string email)
        {
            IWebElement emailAddressInput = webDriver.FindElement(By.Name("from"));
             emailAddressInput.SendKeys("daniel.terceros.b@gmail.com");
        }

        public void SetOrderReference(string OrderReference)
        {
            //id_order
              IWebElement orderReferenceInput = webDriver.FindElement(By.Name("id_order"));
              orderReferenceInput.SendKeys("1234");
        }
        public void SetAttachFile(string FilePatch)
        {

        }

        public void FillContactUsForm(Options option, string value, string email)
        {
            SelectHeadingCombobox(option, value);
            SetEmailAddress(email);
        }
        //ctrl+k+c
        //capture contact Us button
        //    IWebElement contactUsButton = webDriver.FindElement(By.Id("contact-link"));
        //    contactUsButton.Click();

        //        //capture subject heading combo box
        //        IWebElement subjectHeading = webDriver.FindElement(By.Id("id_contact"));
        //    SelectElement subjectHeadingCombobox = new SelectElement(subjectHeading);
        //    subjectHeadingCombobox.SelectByText("Customer service");

        //        //capture email address input
        //        IWebElement emailAddressInput = webDriver.FindElement(By.Name("from"));
        //    emailAddressInput.SendKeys("daniel.terceros.b@gmail.com");

        //        //id_order
        //        IWebElement orderReferenceInput = webDriver.FindElement(By.Name("id_order"));
        //    orderReferenceInput.SendKeys("1234");

        //        //fileUpload
        //        IWebElement attachFile = webDriver.FindElement(By.Id("fileUpload"));
        //    attachFile.SendKeys(@"D:\gggg.txt");

        //        //message
        //        IWebElement messageInput = webDriver.FindElement(By.Id("message"));
        //    messageInput.SendKeys("Test message");

        //        //submitMessage
        //        IWebElement SendButton = webDriver.FindElement(By.Id("submitMessage"));
        //    SendButton.Click();

        //}
    }
