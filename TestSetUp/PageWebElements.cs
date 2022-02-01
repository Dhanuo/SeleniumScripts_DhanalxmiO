using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScriptsJoinAssembly.TestSetUp
{
    public static class PageWebElements
    {
        public static string CurrentPageName = null;

        public static string getElementLocator(string ElementName)
        {

            switch (CurrentPageName)
            {
                case "Integrations":
                    {
                        return TestWebPages.Integrations.ElementLocators[ElementName];
                    }
                case "Pricing":
                    {
                        return TestWebPages.Pricing.ElementLocators[ElementName];
                    }
                default:
                    {
                        Console.WriteLine("No such a webpage exists in JoinAssembly");
                        return null;
                    }
            }
        }
    }
}
