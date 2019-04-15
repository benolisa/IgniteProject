using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IgniteProject.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace IgniteProject.Pages
{
    class HomePage : BaseClass
    {
        IWebElement logo;
        IList<IWebElement> quote;


        public void AmOnPolicyWiseHomePage()
        {
            logo = GetElementById("imgCompanyLogo");
            Assert.IsTrue(logo.Displayed, "Policy Wise Home page is not displayed");
        }

        public VehicleDetailsPage ClickOnGetQuoteButton()
        {
            quote = GetElementsByCssSelector(".btn.btn-primary");
            quote.ElementAt(1).Click();

            return new VehicleDetailsPage();

           
        }
    }
}
