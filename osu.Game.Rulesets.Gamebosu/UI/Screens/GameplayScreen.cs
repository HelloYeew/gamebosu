﻿// gamebosu! ruleset. Copyright (c) Game4all 2020 Licensed under GPLv3.
// See LICENSE at root of repo for more information on licensing.

using Emux.GameBoy.Cartridge;
using osu.Framework.Allocation;
using osu.Framework.Bindables;
using osu.Framework.Graphics;
using osu.Game.Rulesets.Gamebosu.Configuration;
using osu.Game.Rulesets.Gamebosu.UI.Gameboy;
using osu.Game.Rulesets.Gamebosu.UI.Screens.Gameplay;

namespace osu.Game.Rulesets.Gamebosu.UI.Screens
{
    public class GameplayScreen : GamebosuScreen
    {
        private readonly DrawableGameboy gameboy;

        private readonly ClockRateIndicator indicator;

        private Bindable<float> gameboyScale;

        public GameplayScreen(ICartridge cart)
        {
            Children = new Drawable[]
            {
                gameboy = new DrawableGameboy(cart)
                {
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                    RelativeSizeAxes = Axes.Both,
                },
                indicator = new ClockRateIndicator
                {
                    Anchor = Anchor.BottomCentre,
                    Origin = Anchor.BottomCentre,
                    Margin = new MarginPadding { Bottom = 20 }
                }
            };
        }

        [BackgroundDependencyLoader]
        private void load(GamebosuConfigManager config)
        {
            gameboyScale = config.GetBindable<float>(GamebosuSetting.GameboyScale);
            gameboyScale.BindValueChanged(e => gameboy.ScaleTo(e.NewValue, 400, Easing.OutQuint), true);
            config.BindWith(GamebosuSetting.ClockRate, indicator.Rate);
            gameboy.Start();
        }
    }
}