using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScriptsJoinAssembly.TestWebPages
{
    public static class Pricing
    {
        public static string xPathPricingLink ="//a[contains(text(),'Pricing')]";
        public static string xPathPricePlans = "//div[@class='pricing-table-header bg-white']//div[@class='pricing-fourths']";
        public static string xPathPriceLists = "//div[@class='pricing-annual-row bg-white']";
    }
}
