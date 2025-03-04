﻿// gamebosu! ruleset. Copyright Lucas ARRIESSE aka Game4all. Licensed under GPLv3.
// See LICENSE at root of repo for more information on licensing.

using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Game.Rulesets.Gamebosu.UI.Screens;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.Gamebosu.UI
{
    [Cached]
    public class GamebosuPlayfield : Playfield
    {
        [BackgroundDependencyLoader]
        private void load()
        {
            AddRangeInternal(new Drawable[] 
            { 
                HitObjectContainer,
                new MovingNotice
                {
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                    Size = new osuTK.Vector2(512, 256)
                }
            });
        }
    }
}