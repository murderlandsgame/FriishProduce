﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using libWiiSharp;

namespace FriishProduce.WiiVC
{
    public class MSX : InjectorWiiVC
    {
        protected override void Load()
        {
            NeedsMainDOL = false;
            MainContentIndex = 5;
            NeedsManualLoaded = true;

            base.Load();
        }

        /// <summary>
        /// Replaces ROM within extracted content5 directory.
        /// </summary>
        protected override void ReplaceROM()
        {
            ROM.CheckSize();

            // -----------------------
            // Check for ROM string file name index and replace original ROM
            // -----------------------

            int index = MainContent.GetNodeIndex("SLOT1.ROM") != -1 ? MainContent.GetNodeIndex("SLOT1.ROM") : MainContent.GetNodeIndex("MEGAROM.ROM");
            if (index == -1) throw new Exception(Language.Get("Error.002"));

            MainContent.ReplaceFile(index, ROM.Bytes);
        }

        // ADDITIONAL INFO:
        // In the 00000005.app you will find a series of region code .arc files (e.g. CHN, EUR, JPN, KOR, USA.) These are actually the emanual files containing the HTML data.
        //
        // Also, a config file called msx2config.bin, no idea what it does yet, although feel free to edit this code for those who already do know
        // Other ROM files include DISK, FMBIOS, MSX2P, MSX2PEXT, KNJFNT and KNJDRV
        // ****************

        /// <summary>
        /// This is the same process as in NeoGeo
        /// </summary>
        protected override void ReplaceSaveData(string[] lines, ImageHelper Img)
        {
            // -----------------------
            // TEXT
            // -----------------------

            byte[] contents = null;

            try { contents = MainContent.Data[MainContent.GetNodeIndex("banner.bin")]; } catch { }
            if (contents == null) return;

            // Text addition format: UTF-16 (Big Endian)
            // ****************
            for (int i = 32; i < 96; i++)
            {
                try { contents[i] = Encoding.BigEndianUnicode.GetBytes(lines[0])[i - 32]; }
                catch { contents[i] = 0x00; }
            }

            for (int i = 96; i < 160; i++)
            {
                try { contents[i] = Encoding.BigEndianUnicode.GetBytes(lines[1])[i - 96]; }
                catch { contents[i] = 0x00; }
            }

            // -----------------------
            // IMAGE
            // -----------------------

            // TPL contents in banner.bin does not have TPL header, so it has to be manually added
            // ****************
            var header = new byte[] { 0x00, 0x20, 0xAF, 0x30, 0x00, 0x00, 0x00, 0x09, 0x00, 0x00, 0x00, 0x0C, 0x00, 0x00, 0x00, 0x54, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x78, 0x00, 0x00,
                                      0x00, 0x00, 0x00, 0x00, 0x00, 0x9C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xE4, 0x00, 0x00, 0x00, 0x00,
                                      0x00, 0x00, 0x01, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x50, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                      0x01, 0x74, 0x00, 0x00, 0x00, 0x00, 0x00, 0x40, 0x00, 0xC0, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00, 0x01, 0xA0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                      0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x30, 0x00, 0x30, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00,
                                      0x61, 0xA0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                      0x00, 0x30, 0x00, 0x30, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00, 0x73, 0xA0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00,
                                      0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x30, 0x00, 0x30, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00, 0x85, 0xA0, 0x00, 0x00, 0x00, 0x00,
                                      0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x30, 0x00, 0x30, 0x00, 0x00,
                                      0x00, 0x05, 0x00, 0x00, 0x97, 0xA0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00,
                                      0x00, 0x00, 0x00, 0x00, 0x00, 0x30, 0x00, 0x30, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00, 0xA9, 0xA0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                      0x00, 0x01, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x30, 0x00, 0x30, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00, 0xBB, 0xA0,
                                      0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x30,
                                      0x00, 0x30, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00, 0xCD, 0xA0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x01,
                                      0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x30, 0x00, 0x30, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00, 0xDF, 0xA0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                      0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            var placeholder = new List<byte>();

            // Create TPL byte array
            // ****************
            placeholder.AddRange(header);
            placeholder.AddRange(contents.Skip(160).Take(contents.Length - 160).ToArray());

            // Inject new TPL
            // ___________________
            // There seems to be a bug where the savedata icon is saved as a TPL, but does not display correctly after being injected into the banner.bin (i.e. glitched on Wii Menu Save Data Management)
            // ****************
            Img.CreateSaveTPL(placeholder.ToArray()).ToByteArray().Skip(header.Length).ToArray().CopyTo(contents, 160);

            // Replace original savebanner
            // ****************
            MainContent.ReplaceFile(MainContent.GetNodeIndex("banner.bin"), contents);
        }

        protected override void ModifyEmulatorSettings()
        {
            // Not exists
            return;
        }
    }
}
