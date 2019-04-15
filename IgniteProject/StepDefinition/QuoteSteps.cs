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
            
        }

        [When(@"I enter postcode as sk(.*)tb")]
        public void WhenIEnterPostcodeAsSktb(string postcode)
        {
            
        }

        [When(@"I enter house number as (.*)")]
        public void WhenIEnterHouseNumberAs(string number)
        {
            
        }

        [When(@"I click on find")]
        public void WhenIClickOnFind()
        {
            
        }

        [When(@"I select overnight park location as Garaged\(steel\) from dropdown")]
        public void WhenISelectOvernightParkLocationAsGaragedSteelFromDropdown()
        {
            
        }

        [When(@"I enter year of make as (.*)")]
        public void WhenIEnterYearOfMakeAs(string year)
        {
            
        }

        [When(@"I enter date first registered as (.*)/(.*)")]
        public void WhenIEnterDateFirstRegisteredAs(string p0, int p1)
        {
            
        }

        [When(@"I enter date of purchase as (.*)/(.*)")]
        public void WhenIEnterDateOfPurchaseAs(string p0, int p1)
        {
            
        }

        [When(@"I select vehicle type as saloon from dropdown")]
        public void WhenISelectVehicleTypeAsSaloonFromDropdown()
        {
           
        }

        [When(@"I select vehicle owner as company director from dropdown")]
        public void WhenISelectVehicleOwnerAsCompanyDirectorFromDropdown()
        {
            
        }

        [When(@"I select registered keeper as company director from dropdown")]
        public void WhenISelectRegisteredKeeperAsCompanyDirectorFromDropdown()
        {
            
        }

        [When(@"I select transmission as automatic from dropdown")]
        public void WhenISelectTransmissionAsAutomaticFromDropdown()
        {
            
        }

        [When(@"I select fuel type as petrol from dropdown")]
        public void WhenISelectFuelTypeAsPetrolFromDropdown()
        {
            
        }

        [When(@"I enter vehicle colour as black")]
        public void WhenIEnterVehicleColourAsBlack()
        {
            
        }

        [When(@"I click No on radio q-plated button")]
        public void WhenIClickOnRadioQ_PlatedButtonNo()
        {
            
        }

        [When(@"I click No on Imported radio button")]
        public void WhenIClickOnImportedRadioButtonNo()
        {
            
        }

        [When(@"I select number of seats as (.*) from dropdown")]
        public void WhenISelectNumberOfSeatsAsFromDropdown(string number)
        {
            
        }

        [When(@"I click Yes on Is the Vehicle Right Hand Drive radio button")]
        public void WhenIClickOnIsTheVehicleRightHandDriveRadioButtonYes()
        {
           
        }

        [When(@"I enter Estimated annual millage as (.*)")]
        public void WhenIEnterEstimatedAnnualMillageAs(string number)
        {
            
        }

        [When(@"I enter Estimated business millage as (.*)")]
        public void WhenIEnterEstimatedBusinessMillageAs(string number)
        {
            
        }

        [When(@"I enter Current Vehicle millage as (.*)")]
        public void WhenIEnterCurrentVehicleMillageAs(string number)
        {
            
        }

        [When(@"I enter value as £(.*)")]
        public void WhenIEnterValueAs(string amount)
        {
            
        }

        [When(@"I click No on Is modified radio button")]
        public void WhenIClickOnIsModifiedRadioButtonNo()
        {
            
        }

        [When(@"I enter Purchase Price as £(.*)")]
        public void WhenIEnterPurchasePriceAs(string amount)
        {
            
        }

        [When(@"I enter Chasis Number as (.*)HGBH(.*)JKMN(.*)")]
        public void WhenIEnterChasisNumberAsHGBHJKMN(string p0, int p1, int p2)
        {
            
        }

        [When(@"I select alarm Type as Thatcham Catergory (.*) Device from dropdown")]
        public void WhenISelectAlarmTypeAsThatchamCatergoryDeviceFromDropdown(string number)
        {
            
        }

        [When(@"I select Fitted Tracker as None from dropdown")]
        public void WhenISelectFittedTrackerAsNoneFromDropdown()
        {
            
        }

        [When(@"I click on next button")]
        public void WhenIClickOnNextButton()
        {
            
        }

        [Then(@"quote and Buy page is displayed")]
        public void ThenQuoteAndBuyPageIsDisplayed()
        {
            
        }
      
    }
}
