using AutomationFramework;
using NUnit.Framework;
using TestConfigurator.Models.UI;
using TestConfigurator.Workflows.API;

namespace TestConfigurator.TestFixtures
{
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class RegressionUiTestsBase : UIParallelTestBase
    {
        [OneTimeSetUp]
        public override void OneTimeSetUpParallelExec()
        {
            base.OneTimeSetUpParallelExec();
        }
    }
}