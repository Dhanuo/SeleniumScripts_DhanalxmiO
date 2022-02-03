using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScriptsJoinAssembly.TestSetUp
{
    public static class SetUp
    { 
            public static string projectPath = (Directory.GetParent(Directory.GetCurrentDirectory()).FullName + "\\").Replace("\\bin\\Debug\\", "");
            public static string driverPath = projectPath + "\\TestWebHelp\\Drivers\\";
            public static string resultsPath = projectPath + "\\TestResults\\";
            public static string resultName = "JoinAssemblyTestCases" + DateTime.Now.ToString("yyyy-MM-ddHHmmss") + "_";
            public static string MainURL = "https://www.joinassembly.com/";
       
    }
}
