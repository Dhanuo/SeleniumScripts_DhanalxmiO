using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScriptsJoinAssembly.TestWebPages
{
    class Integrations
    {
        public static string xPathIntegrationLnk = "//a[contains(text(),'Integrations')]";
        public static string xPathSSOandHRISLink = "//a[@class='integration-category-wrapper w-inline-block']//div[contains(text(),'SSO & HRIS Sync')]";
        public static string xPathProductIntegrationsLinks = "//div[@class='integrations-grid w-dyn-items']/div/a[@class='card integration-page w-inline-block']";
        
    }
}
