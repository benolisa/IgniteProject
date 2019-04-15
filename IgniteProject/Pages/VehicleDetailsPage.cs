using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IgniteProject.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace IgniteProject.Pages
{
    class VehicleDetailsPage : BaseClass 
    {
       IList<IWebElement> make;
        IWebElement logo;



        public void AndAmOnVehicleDetailPage()
        {
            logo = GetElementById("imgCompanyLogo");
            Assert.IsTrue(logo.Displayed,"Vehicle detail page is nort displayed");
        }

        public void ClickOnMake()
        {
           make = GetElementsById("ctl00$masterContentPlaceholder$ddlMake$ddlList");
           make.ElementAt(0).Click();
           SelectByIndex(make,15);
          

        }

        
    }
}
