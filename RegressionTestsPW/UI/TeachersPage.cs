﻿using NUnit.Framework;
using TestsConfigurator_PW.Fixtures;

namespace RegressionTests_PW.UI
{
    public class TeachersPage : UITestsSuitFixture
    {
        [Test]
        public async Task TheUser_CanNavigateTo_Teachers_Page()
        {
            await HomePage.Click_Tachers_Button()
                .Result.IsAtPage();
        }
    }
}