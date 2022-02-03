using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TestScriptsJoinAssembly.TestWebPages;

namespace TestScriptsJoinAssembly.StepDefinitions
{
    [Binding]
    public class TestScriptsForTestCasesStepDefinitions
    {
        
        [Given(@"I go to joinassembly\.com")]
        public void GivenIGoToJoinassembly_Com()
        {
            TestWebHelp.WebHelp.NavigateTo(TestSetUp.SetUp.MainURL);
        }

        [When(@"Navigate to the Integrations > SSO & HRIS Sync webpage")]
        public void WhenNavigateToTheIntegrationsSSOHRISSyncWebpage()
        {
            TestWebHelp.WebHelp.SafeSelectWebelement(TestWebPages.Integrations.xPathIntegrationLnk, "click");
            TestWebHelp.WebHelp.SafeSelectWebelement(TestWebPages.Integrations.xPathSSOandHRISLink, "click");
        }

        [Then(@"Verify the number of lists available under the Integrations and Print atleast two Integrations")]
        public void ThenVerifyTheNumberOfListsAvailableUnderTheIntegrationsAndPrintAtleastTwoIntegrations()
        {
            TestWebHelp.WebHelp.SelectWebelementsFromList(TestWebPages.Integrations.xPathProductIntegrationsLinks, "Total number of Integrations #", "Name of Each Integrations");
            TestWebHelp.WebHelp.ITakesScreenshot();
        }

        [Given(@"I go to joinassemblydotcom")]
        public void GivenIGoToJoinassemblydotcom()
        {
            TestWebHelp.WebHelp.NavigateTo(TestSetUp.SetUp.MainURL);
        }

        [When(@"Navigate to Pricing webpage")]
        public void WhenNavigateToPricingWebpage()
        {
            TestWebHelp.WebHelp.SafeSelectWebelement(TestWebPages.Pricing.xPathPricingLink,"click");
            Thread.Sleep(2000);
        }

        [Then(@"Verify different pricing sections and Print billing Price of each plan")]
        public void ThenVerifyDifferentPricingSectionsAndPrintBillingPriceOfEachPlan()
        {
            TestWebHelp.WebHelp.SelectWebelementsFromList(TestWebPages.Pricing.xPathPricePlans, "Total number of Product plans #", "Name of Each plan" + "\n");
            Thread.Sleep(2000);
            TestWebHelp.WebHelp.SelectWebelementsFromList(TestWebPages.Pricing.xPathPriceLists, "Total number of Price plans #", "Price of Each plan "+"\n");
            TestWebHelp.WebHelp.ITakesScreenshot();
        }

    }
    
}
