using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IgniteProject.Helper;
using TechTalk.SpecFlow;

namespace IgniteProject.Hooks
{
    [Binding]
    public sealed class IgniteHooks : BaseClass
    {
        

        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("Chrome");
            LaunchUrl("http://policywisetest.ignite.systems/Login.aspx");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CloseBrowser();
        }
    }
}
