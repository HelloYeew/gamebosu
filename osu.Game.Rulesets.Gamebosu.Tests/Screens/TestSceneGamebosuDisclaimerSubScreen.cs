﻿// gamebosu! ruleset. Copyright Lucas ARRIESSE aka Game4all. Licensed under GPLv3.
// See LICENSE at root of repo for more information on licensing.

using osu.Game.Rulesets.Gamebosu.UI.Screens;

namespace osu.Game.Rulesets.Gamebosu.Tests.Screens
{
    public class TestSceneGamebosuDisclaimerSubScreen : TestSceneGamebosuScreenStack
    {
        protected override GamebosuSubScreen CreateSubScreen() => new DisclaimerSubScreen();
    }
}
