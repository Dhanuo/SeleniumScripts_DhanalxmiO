using TechTalk.SpecFlow;

namespace TestScriptsJoinAssembly.TestHooks
{
    [Binding]
    public sealed class Hooks_For_JoinAssemblyTesting
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            TestWebHelp.WebHelp.StartWebDriver("Chrome");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            TestWebHelp.WebHelp.StopWebDriver();
        }
    }
}