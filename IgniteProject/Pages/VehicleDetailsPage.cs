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
        IWebElement make;
        IWebElement logo;
        IWebElement capacity;
        IWebElement postCode;
        IWebElement houseNumber;
        IWebElement find;
        IWebElement nightParking;
        IWebElement year;
        IWebElement dateRegistered;
        IWebElement dateOfPurchase;
        IWebElement vehicleType;
        IWebElement vehicleOnwer;
        IWebElement keeper;
        IWebElement transmission;
        IWebElement fuelType;
        IWebElement vehicleColour;
        IWebElement plate;
        IWebElement imported;
        IWebElement seatNumber;
        IWebElement vehicleHand;
        IWebElement anMilleage;
        IWebElement busMilleage;
        IWebElement vehMilleage;
        IWebElement value;
        IWebElement modified;
        IWebElement price;
        IWebElement chasis;
        IWebElement alarm;
        IWebElement tracker;
        IWebElement nxtButton;


        public void AndAmOnVehicleDetailPage()
        {
            logo = GetElementById("imgCompanyLogo");
            Assert.IsTrue(logo.Displayed, "Vehicle detail page is nort displayed");
        }

        public void ClickOnMake()
        {
            //make = GetElementByName("ctl00$masterContentPlaceholder$ddlMake$ddlList");
            // SelectByIndex(make, 15);
            // make.Click();  
        }
        public void EnterCubicCapacity()
        {
            capacity = GetElementById("ctl00_masterContentPlaceholder_txtCubicCapacity_txtBox");
            capacity.SendKeys("1998cc");
            capacity.Click();

        }
        public void EnterPostCode()
        {
            postCode = GetElementById("ctl00_masterContentPlaceholder_ucAddress_ctl00_txtPostCode_txtBox");
            postCode.SendKeys("SK4 1TB");
            postCode.Click();
        }
        public void EnterHouseNumber()
        {
            houseNumber = GetElementById("ctl00_masterContentPlaceholder_ucAddress_ctl00_txtHouseFlatNumber_txtBox");
            houseNumber.SendKeys("13");
            houseNumber.Click();
        }
        public void ClickFind()
        {
            //find = GetElementByName("ctl00$masterContentPlaceholder$ucAddress$ctl00$btnFindMyAddress$btn_input");
            //find.Click();
        }
        public void SelectOverNightPark()
        {
            //nightParking = GetElementByName("ctl00$masterContentPlaceholder$ddlOvernightParkLocation$ddlList");
            //SelectByIndex(nightParking, 3);
            //nightParking.Click();
        }
        public void EnterYearOfMake()
        {
            year = GetElementById("ctl00_masterContentPlaceholder_txtYearOfMake_txtBox");
            year.SendKeys("2017");
            year.Click();
        }
        public void EnterDateFirstRegistered()
        {
            dateRegistered = GetElementById("ctl00_masterContentPlaceholder_dtDateFirstRegistered_dtPicker_dateInput");
            dateRegistered.Clear();
            dateRegistered.SendKeys("10/11/2017");
            dateRegistered.Click();
        }
        public void EnterDateOfPurchase()
        {
            dateOfPurchase = GetElementById("ctl00_masterContentPlaceholder_dtPurchaseDate_dtPicker_dateInput");
            dateOfPurchase.Clear();
            dateOfPurchase.SendKeys("14/06/2018");
            dateOfPurchase.Click();
        }
        public void SelectVehicleType()
        {
            vehicleType = GetElementById("ctl00_masterContentPlaceholder_ddlNonClassicVehicleType_ddlList_Input");
            SelectByIndex(vehicleType, 8);
            vehicleType.Click();
        }
        public void SelectVehicleOnwer()
        {
            vehicleOnwer = GetElementById("ctl00_masterContentPlaceholder_ddlRegisteredOwner_ddlList_Input");
             SelectByIndex(vehicleOnwer, 4);
             vehicleOnwer.Click();
        }
        public void SelectRegisteredKeeper()
        {
             keeper = GetElementById("ctl00_masterContentPlaceholder_ddlRegisteredKeeper_ddlList_Input");
             SelectByIndex(keeper, 4);
             keeper.Click();
        }
        public void SelectTransmission()
        {
            transmission = GetElementById("ctl00_masterContentPlaceholder_ddlTransmission_ddlList_Input");
            SelectByIndex(transmission, 1);
            transmission.Click();
        }
        public void SelectFuelType()
        {
            fuelType = GetElementById("ctl00_masterContentPlaceholder_ddlFuelType_ddlList_Input");
            SelectByIndex(fuelType, 6);
            fuelType.Click();
        }
        public void SelectVehicleColour()
        {
            vehicleColour = GetElementById("ctl00_masterContentPlaceholder_txtVehicleColour_txtBox");
            vehicleColour.SendKeys("Black");
            vehicleColour.Click();
        }
        public void ClickOnQPlate()
        {
            plate = GetElementById("masterContentPlaceholder_boolQPlated_rbtnList_1");
            plate.Click();
        }
        public void ClickOnImported()
        {
            imported = GetElementById("masterContentPlaceholder_boolImported_rbtnList_1");
            imported.Click();
        }
        public void SelectNumberOfSeat()
        {
            seatNumber = GetElementById("ctl00_masterContentPlaceholder_ddlNumberOfSeats_ddlList_Input");
            SelectByIndex(seatNumber, 5);
            seatNumber.Click();
        }
        public void ClickOnVehicleHand()
        {
            vehicleHand = GetElementById("masterContentPlaceholder_boolRightHandDrive_rbtnList_0");
            vehicleHand.Click();
        }
        public void AnnualMilleage()
        {
            anMilleage= GetElementById("ctl00_masterContentPlaceholder_txtEstimatedMileage_txtBox");
            anMilleage.SendKeys("10000");
            anMilleage.Click();
        }
        public void BusinessMilleage()
        {
            busMilleage = GetElementById("ctl00_masterContentPlaceholder_txtBusinessMileage_txtBox");
            busMilleage.SendKeys("4000");
            busMilleage.Click();
        }
        public void VehicleMilleage()
        {
            vehMilleage = GetElementById("ctl00_masterContentPlaceholder_txtCurrentMileage_txtBox");
            vehMilleage.SendKeys("33000");
            vehMilleage.Click();
        }
        public void CarValue()
        {
            value = GetElementById("ctl00_masterContentPlaceholder_txtValue_txtBox");
            value.SendKeys("£18000");
            value.Click();
        }
        public void IsModified()
        {
            modified = GetElementById("masterContentPlaceholder_boolVehicleIsModified_rbtnList_1");
            modified.Click();
        }
        public void PurchasePrice()
        {
            price = GetElementById("ctl00_masterContentPlaceholder_txtPurchasePrice_txtBox");
            price.SendKeys("£16500");
            price.Click();
        }
        public void EnterChasisNumber()
        {
            chasis = GetElementById("ctl00_masterContentPlaceholder_txtChassisNumber_txtBox");
            chasis.SendKeys("3HGBH45JKMN106434");
            chasis.Click();
        }
        public void SelectAlarmType()
        {
            alarm = GetElementById("ctl00_masterContentPlaceholder_ddlModernCarAlarmType_ddlList_Input");
            SelectByIndex(alarm, 1);
            alarm.Click();
        }
        public void SelectFittedTracker()
        {
            tracker = GetElementById("ctl00_masterContentPlaceholder_ddlTrackerType_ddlList_Input");
            SelectByIndex(tracker, 2);
            tracker.Click();
        }
        public QuoteAndBuyPage ClickOnNextButton()
        {
            nxtButton = GetElementById("ctl00_masterContentPlaceholder_btnNext_btn_input");
            nxtButton.Click();


            return new QuoteAndBuyPage();
        }
         
    }

 }
