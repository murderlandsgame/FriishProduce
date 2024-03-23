﻿using System;
using System.Collections.Generic;
using System.Drawing;
using static FriishProduce.Properties.Settings;

namespace FriishProduce
{
    public partial class Options_VC_SEGA : ContentOptions
    {
        public bool IsSMS { get; set; }

        public Options_VC_SEGA() : base()
        {
            InitializeComponent();

            Settings = new SortedDictionary<string, string>
            {
                { "console.brightness", Default.Default_SEGA_Brightness },
                { "console.disable_resetbutton", null },
                { "country", Language.Current.Name.StartsWith("ja") ? "jp" : Default.Default_SEGA_Region },
                { "dev.mdpad.enable_6b", Default.Default_SEGA_6B },
                { "save_sram", Default.Default_SEGA_SRAM },
                { "machine_md.use_4ptap", null },
                { "nplayers", null }
            };

            // Cosmetic
            // *******
            if (!DesignMode)
            {
                Language.Localize(this);
                toggleSwitchL1.Text = Language.Get(toggleSwitch1, this);

                comboBox1.Items.Clear();
                comboBox1.Items.Add(Language.Get("Region.U"));
                comboBox1.Items.Add(Language.Get("Region.E"));
                comboBox1.Items.Add(Language.Get("Region.J"));
            }
        }

        // ---------------------------------------------------------------------------------------------------------------

        protected override void ResetOptions()
        {
            // Console/emulator-specific tools
            // *******
            toggleSwitchL1.Enabled = toggleSwitch1.Enabled = !IsSMS;
            // label1.Enabled = BrightnessValue.Enabled = EmuType >= 2 || IsSMS;

            // Form control
            // *******
            if (Settings != null)
            {
                if (IsSMS) Settings["dev.mdpad.enable_6b"] = null;

                if (Settings["console.brightness"] == null || int.Parse(Settings["console.brightness"]) < 0) Settings["console.brightness"] = Default.Default_SEGA_Brightness;

                BrightnessValue.Value = int.Parse(Settings["console.brightness"]);
                comboBox1.SelectedIndex = Settings["country"] == "jp" ? 2 : Settings["country"] == "eu" ? 1 : 0;
                toggleSwitch1.Checked = Settings["dev.mdpad.enable_6b"] == "1";
                checkBox1.Checked = Settings["save_sram"] == "1";
                ChangeBrightness();
            }
        }

        protected override void SaveOptions()
        {
            Settings["console.brightness"] = BrightnessValue.Enabled ? label1.Text : null;
            Settings["save_sram"] = checkBox1.Checked ? "1" : null;
            Settings["country"] = comboBox1.SelectedIndex == 2 ? "jp" : comboBox1.SelectedIndex == 1 ? "eu" : "us";
            Settings["dev.mdpad.enable_6b"] = toggleSwitch1.Checked ? "1" : null;
        }

        // ---------------------------------------------------------------------------------------------------------------

        private void BrightnessValue_Set(object sender, EventArgs e) => ChangeBrightness();
        private void ChangeBrightness()
        {
            double factor = BrightnessValue.Value * 0.01;
            var orig = Properties.Resources.screen_smd;
            Bitmap changed = new Bitmap(orig.Width, orig.Height);

            using (Graphics g = Graphics.FromImage(changed))
            using (Brush darkness = new SolidBrush(Color.FromArgb(255 - (int)Math.Round(factor * 255), Color.Black)))
            {
                g.DrawImage(orig, 0, 0);
                g.FillRectangle(darkness, new Rectangle(0, 0, orig.Width, orig.Height));
                g.Dispose();
            }
            pictureBox1.Image = changed;

            label1.Text = BrightnessValue.Value.ToString();

            if (!BrightnessValue.Enabled) Settings["console.brightness"] = null;
        }

        private void ToggleSwitchChanged(object sender, EventArgs e)
        {
            if (sender == toggleSwitch1) toggleSwitchL1.Text = Language.Get(toggleSwitch1, this);
        }
    }
}
