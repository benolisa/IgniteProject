using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IgniteProject.Helper;
using IgniteProject.Pages;
using TechTalk.SpecFlow;

namespace IgniteProject.StepDrfinition
{
    [Binding]
    public sealed class QuoteSteps : BaseClass
    {
        HomePage homePage = new HomePage();
        VehicleDetailsPage vehicleDetailsPage = new VehicleDetailsPage();

        [Given(@"Am on policywise homepage")]
        public void GivenAmOnPolicywiseHomepage()
        {
            homePage.AmOnPolicyWiseHomePage();
        }

        [When(@"I click on get quote buttton")]
        public void WhenIClickOnGetQuoteButtton()
        {
            homePage.ClickOnGetQuoteButton();
        }

        [When(@"I click on select make fileld")]
        public void WhenIClickOnSelectMakeFileld()
        {
            vehicleDetailsPage.ClickOnMake();
        }

        [When(@"I click on select model field")]
        public void WhenIClickOnSelectModelField()
        {
            
        }

        [When(@"I enter the cubic capacity as (.*)cc")]
        public void WhenIEnterTheCubicCapacityAsCc(string number)
        {
            vehicleDetailsPage.EnterCubicCapacity();
        }

        [When(@"I enter postcode as sk(.*)tb")]
        public void WhenIEnterPostcodeAsSktb(string postcode)
        {
            vehicleDetailsPage.EnterPostCode();
        }

        [When(@"I enter house number as (.*)")]
        public void WhenIEnterHouseNumberAs(string number)
        {
            vehicleDetailsPage.EnterHouseNumber();
        }

        [When(@"I click on find")]
        public void WhenIClickOnFind()
        {
            vehicleDetailsPage.ClickFind();
        }

        [When(@"I select overnight park location as Garaged\(steel\) from dropdown")]
        public void WhenISelectOvernightParkLocationAsGaragedSteelFromDropdown()
        {
            vehicleDetailsPage.SelectOverNightPark();
        }

        [When(@"I enter year of make as (.*)")]
        public void WhenIEnterYearOfMakeAs(string number)
        {
            vehicleDetailsPage.EnterYearOfMake();
        }

        [When(@"I enter date first registered as (.*)/(.*)")]
        public void WhenIEnterDateFirstRegisteredAs(string po, int p1)
        {
            vehicleDetailsPage.EnterDateFirstRegistered();
        }

        [When(@"I enter date of purchase as (.*)/(.*)")]
        public void WhenIEnterDateOfPurchaseAs(string po, int p1)
        {
            vehicleDetailsPage.EnterDateOfPurchase();
        }

        [When(@"I select vehicle type as saloon from dropdown")]
        public void WhenISelectVehicleTypeAsSaloonFromDropdown()
        {
            vehicleDetailsPage.SelectVehicleType();
        }

        [When(@"I select vehicle owner as company director from dropdown")]
        public void WhenISelectVehicleOwnerAsCompanyDirectorFromDropdown()
        {
            vehicleDetailsPage.SelectVehicleOnwer();
        }

        [When(@"I select registered keeper as company director from dropdown")]
        public void WhenISelectRegisteredKeeperAsCompanyDirectorFromDropdown()
        {
            vehicleDetailsPage.SelectRegisteredKeeper();
        }

        [When(@"I select transmission as automatic from dropdown")]
        public void WhenISelectTransmissionAsAutomaticFromDropdown()
        {
            vehicleDetailsPage.SelectTransmission();
        }

        [When(@"I select fuel type as petrol from dropdown")]
        public void WhenISelectFuelTypeAsPetrolFromDropdown()
        {
            vehicleDetailsPage.SelectTransmission();
        }

        [When(@"I enter vehicle colour as black")]
        public void WhenIEnterVehicleColourAsBlack()
        {
            vehicleDetailsPage.SelectVehicleColour();
        }

        [When(@"I click No on radio q-plated button")]
        public void WhenIClickOnRadioQ_PlatedButtonNo()
        {
            vehicleDetailsPage.ClickOnQPlate();
        }

        [When(@"I click No on Imported radio button")]
        public void WhenIClickOnImportedRadioButtonNo()
        {
            vehicleDetailsPage.ClickOnImported();
        }

        [When(@"I select number of seats as (.*) from dropdown")]
        public void WhenISelectNumberOfSeatsAsFromDropdown(string number)
        {
            vehicleDetailsPage.SelectNumberOfSeat();
        }

        [When(@"I click Yes on Is the Vehicle Right Hand Drive radio button")]
        public void WhenIClickOnIsTheVehicleRightHandDriveRadioButtonYes()
        {
            vehicleDetailsPage.ClickOnVehicleHand();
        }

        [When(@"I enter Estimated annual millage as (.*)")]
        public void WhenIEnterEstimatedAnnualMillageAs(string number)
        {
            vehicleDetailsPage.AnnualMilleage();
        }

        [When(@"I enter Estimated business millage as (.*)")]
        public void WhenIEnterEstimatedBusinessMillageAs(string number)
        {
            vehicleDetailsPage.BusinessMilleage();
        }

        [When(@"I enter Current Vehicle millage as (.*)")]
        public void WhenIEnterCurrentVehicleMillageAs(string number)
        {
            vehicleDetailsPage.VehicleMilleage();
        }

        [When(@"I enter value as £(.*)")]
        public void WhenIEnterValueAs(string amount)
        {
            vehicleDetailsPage.CarValue();
        }

        [When(@"I click No on Is modified radio button")]
        public void WhenIClickOnIsModifiedRadioButtonNo()
        {
            vehicleDetailsPage.IsModified();
        }

        [When(@"I enter Purchase Price as £(.*)")]
        public void WhenIEnterPurchasePriceAs(string amount)
        {
            vehicleDetailsPage.PurchasePrice();
        }

        [When(@"I enter Chasis Number as (.*)HGBH(.*)JKMN(.*)")]
        public void WhenIEnterChasisNumberAsHGBHJKMN(string p0, int p1, int p2)
        {
            vehicleDetailsPage.EnterChasisNumber();
        }

        [When(@"I select alarm Type as Thatcham Catergory (.*) Device from dropdown")]
        public void WhenISelectAlarmTypeAsThatchamCatergoryDeviceFromDropdown(string number)
        {
            vehicleDetailsPage.SelectAlarmType();
        }

        [When(@"I select Fitted Tracker as None from dropdown")]
        public void WhenISelectFittedTrackerAsNoneFromDropdown()
        {
            vehicleDetailsPage.SelectFittedTracker();
        }

        [When(@"I click on next button")]
        public void WhenIClickOnNextButton()
        {
            vehicleDetailsPage.ClickOnNextButton();
        }

        [Then(@"quote and Buy page is displayed")]
        public void ThenQuoteAndBuyPageIsDisplayed()
        {
            
        }
      
    }
}
