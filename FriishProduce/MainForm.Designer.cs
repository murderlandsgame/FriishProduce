﻿
using System.Drawing;

namespace FriishProduce
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.NewProject = new System.Windows.Forms.RibbonOrbMenuItem();
            this.CreateProject_List1 = new System.Windows.Forms.RibbonSeparator();
            this.CreateProject_NES = new System.Windows.Forms.RibbonButton();
            this.CreateProject_SNES = new System.Windows.Forms.RibbonButton();
            this.CreateProject_N64 = new System.Windows.Forms.RibbonButton();
            this.orbMenuSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.MenuItem_Settings = new System.Windows.Forms.RibbonOrbMenuItem();
            this.orbMenuSeparator2 = new System.Windows.Forms.RibbonSeparator();
            this.MenuItem_About = new System.Windows.Forms.RibbonOrbMenuItem();
            this.MenuItem_Exit = new System.Windows.Forms.RibbonOrbMenuItem();
            this.RibbonButton_Settings = new System.Windows.Forms.RibbonButton();
            this.RibbonButton_About = new System.Windows.Forms.RibbonButton();
            this.ribbonTab_Home = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel_Import = new System.Windows.Forms.RibbonPanel();
            this.OpenROM = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonList1 = new System.Windows.Forms.RibbonButtonList();
            this.OpenImage = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.UseLibRetro = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel_Export = new System.Windows.Forms.RibbonPanel();
            this.ExportWAD = new System.Windows.Forms.RibbonButton();
            this.tabControl = new MdiTabControl.TabControl();
            this.BrowseROM = new System.Windows.Forms.OpenFileDialog();
            this.SaveWAD = new System.Windows.Forms.SaveFileDialog();
            this.BrowseImage = new System.Windows.Forms.OpenFileDialog();
            this.TabContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Strip_OpenROM = new System.Windows.Forms.ToolStripMenuItem();
            this.Strip_OpenImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Strip_UseLibRetro = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Strip_ExportWAD = new System.Windows.Forms.ToolStripMenuItem();
            this.TabContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.HideSingleTabIfTextEmpty = false;
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.NewProject);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.orbMenuSeparator1);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.MenuItem_Settings);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.orbMenuSeparator2);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.MenuItem_About);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.MenuItem_Exit);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 254);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbon1.OrbText = "File";
            // 
            // 
            // 
            this.ribbon1.QuickAccessToolbar.DropDownButtonVisible = false;
            this.ribbon1.QuickAccessToolbar.Items.Add(this.RibbonButton_Settings);
            this.ribbon1.QuickAccessToolbar.Items.Add(this.RibbonButton_About);
            this.ribbon1.QuickAccessToolbar.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbon1.QuickAccessToolbar.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbon1.QuickAccessToolbar.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.ribbon1.QuickAccessToolbar.Visible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1114, 130);
            this.ribbon1.TabIndex = 1;
            this.ribbon1.Tabs.Add(this.ribbonTab_Home);
            this.ribbon1.TabSpacing = 3;
            this.ribbon1.Text = "FriishProduce";
            this.ribbon1.UseAlwaysStandardTheme = true;
            // 
            // NewProject
            // 
            this.NewProject.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.NewProject.DropDownItems.Add(this.CreateProject_List1);
            this.NewProject.DropDownItems.Add(this.CreateProject_NES);
            this.NewProject.DropDownItems.Add(this.CreateProject_SNES);
            this.NewProject.DropDownItems.Add(this.CreateProject_N64);
            this.NewProject.DropDownResizable = true;
            this.NewProject.Image = global::FriishProduce.Properties.Resources.document_empty_large;
            this.NewProject.LargeImage = global::FriishProduce.Properties.Resources.document_empty_large;
            this.NewProject.Name = "NewProject";
            this.NewProject.SmallImage = global::FriishProduce.Properties.Resources.document_empty_large;
            this.NewProject.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.NewProject.Tag = "r012";
            this.NewProject.Text = "New...";
            // 
            // CreateProject_List1
            // 
            this.CreateProject_List1.Name = "CreateProject_List1";
            this.CreateProject_List1.Text = "Nintendo";
            // 
            // CreateProject_NES
            // 
            this.CreateProject_NES.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.CreateProject_NES.Image = global::FriishProduce.Properties.Resources.icon_16x16_nes;
            this.CreateProject_NES.LargeImage = global::FriishProduce.Properties.Resources.icon_16x16_nes;
            this.CreateProject_NES.Name = "CreateProject_NES";
            this.CreateProject_NES.SmallImage = global::FriishProduce.Properties.Resources.icon_16x16_nes;
            this.CreateProject_NES.Tag = "NES";
            this.CreateProject_NES.Text = "NES";
            // 
            // CreateProject_SNES
            // 
            this.CreateProject_SNES.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.CreateProject_SNES.Image = global::FriishProduce.Properties.Resources.icon_16x16_snes;
            this.CreateProject_SNES.LargeImage = global::FriishProduce.Properties.Resources.icon_16x16_snes;
            this.CreateProject_SNES.Name = "CreateProject_SNES";
            this.CreateProject_SNES.SmallImage = global::FriishProduce.Properties.Resources.icon_16x16_snes;
            this.CreateProject_SNES.Tag = "SNES";
            this.CreateProject_SNES.Text = "SNES";
            // 
            // CreateProject_N64
            // 
            this.CreateProject_N64.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.CreateProject_N64.Image = global::FriishProduce.Properties.Resources.icon_16x16_n64;
            this.CreateProject_N64.LargeImage = global::FriishProduce.Properties.Resources.icon_16x16_n64;
            this.CreateProject_N64.Name = "CreateProject_N64";
            this.CreateProject_N64.SmallImage = global::FriishProduce.Properties.Resources.icon_16x16_n64;
            this.CreateProject_N64.Tag = "N64";
            this.CreateProject_N64.Text = "N64";
            // 
            // orbMenuSeparator1
            // 
            this.orbMenuSeparator1.Name = "orbMenuSeparator1";
            // 
            // MenuItem_Settings
            // 
            this.MenuItem_Settings.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.MenuItem_Settings.Image = global::FriishProduce.Properties.Resources.wrench_orange_large;
            this.MenuItem_Settings.LargeImage = global::FriishProduce.Properties.Resources.wrench_orange_large;
            this.MenuItem_Settings.Name = "MenuItem_Settings";
            this.MenuItem_Settings.SmallImage = global::FriishProduce.Properties.Resources.wrench_orange_large;
            this.MenuItem_Settings.Tag = "g001";
            this.MenuItem_Settings.Text = "Settings";
            this.MenuItem_Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // orbMenuSeparator2
            // 
            this.orbMenuSeparator2.Name = "orbMenuSeparator2";
            // 
            // MenuItem_About
            // 
            this.MenuItem_About.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.MenuItem_About.Image = global::FriishProduce.Properties.Resources.mario_large;
            this.MenuItem_About.LargeImage = global::FriishProduce.Properties.Resources.mario_large;
            this.MenuItem_About.Name = "MenuItem_About";
            this.MenuItem_About.SmallImage = global::FriishProduce.Properties.Resources.mario_large;
            this.MenuItem_About.Tag = "r002";
            this.MenuItem_About.Text = "About";
            // 
            // MenuItem_Exit
            // 
            this.MenuItem_Exit.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.MenuItem_Exit.Image = global::FriishProduce.Properties.Resources.door_open;
            this.MenuItem_Exit.LargeImage = global::FriishProduce.Properties.Resources.door_open;
            this.MenuItem_Exit.Name = "MenuItem_Exit";
            this.MenuItem_Exit.SmallImage = global::FriishProduce.Properties.Resources.door_open;
            this.MenuItem_Exit.Tag = "r003";
            this.MenuItem_Exit.Text = "Exit";
            this.MenuItem_Exit.Click += new System.EventHandler(this.MenuItem_Exit_Click);
            // 
            // RibbonButton_Settings
            // 
            this.RibbonButton_Settings.DrawDropDownIconsBar = false;
            this.RibbonButton_Settings.Image = ((System.Drawing.Image)(resources.GetObject("RibbonButton_Settings.Image")));
            this.RibbonButton_Settings.LargeImage = ((System.Drawing.Image)(resources.GetObject("RibbonButton_Settings.LargeImage")));
            this.RibbonButton_Settings.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.RibbonButton_Settings.Name = "RibbonButton_Settings";
            this.RibbonButton_Settings.SmallImage = global::FriishProduce.Properties.Resources.wrench_orange_large;
            this.RibbonButton_Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // RibbonButton_About
            // 
            this.RibbonButton_About.DrawDropDownIconsBar = false;
            this.RibbonButton_About.Image = ((System.Drawing.Image)(resources.GetObject("RibbonButton_About.Image")));
            this.RibbonButton_About.LargeImage = ((System.Drawing.Image)(resources.GetObject("RibbonButton_About.LargeImage")));
            this.RibbonButton_About.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.RibbonButton_About.Name = "RibbonButton_About";
            this.RibbonButton_About.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibbonButton_About.SmallImage")));
            // 
            // ribbonTab_Home
            // 
            this.ribbonTab_Home.Name = "ribbonTab_Home";
            this.ribbonTab_Home.Panels.Add(this.ribbonPanel_Import);
            this.ribbonTab_Home.Panels.Add(this.ribbonPanel_Export);
            this.ribbonTab_Home.Tag = "r001";
            this.ribbonTab_Home.Text = "Home";
            // 
            // ribbonPanel_Import
            // 
            this.ribbonPanel_Import.ButtonMoreVisible = false;
            this.ribbonPanel_Import.Items.Add(this.OpenROM);
            this.ribbonPanel_Import.Items.Add(this.OpenImage);
            this.ribbonPanel_Import.Items.Add(this.ribbonSeparator1);
            this.ribbonPanel_Import.Items.Add(this.UseLibRetro);
            this.ribbonPanel_Import.Name = "ribbonPanel_Import";
            this.ribbonPanel_Import.Tag = "r004";
            this.ribbonPanel_Import.Text = "Import";
            // 
            // OpenROM
            // 
            this.OpenROM.DropDownItems.Add(this.ribbonButtonList1);
            this.OpenROM.Enabled = false;
            this.OpenROM.Image = global::FriishProduce.Properties.Resources.joystick_add_large;
            this.OpenROM.LargeImage = global::FriishProduce.Properties.Resources.joystick_add_large;
            this.OpenROM.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.OpenROM.MinimumSize = new System.Drawing.Size(100, 0);
            this.OpenROM.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.OpenROM.Name = "OpenROM";
            this.OpenROM.SmallImage = global::FriishProduce.Properties.Resources.joystick_add;
            this.OpenROM.Tag = "r005";
            this.OpenROM.Text = "Open ROM";
            this.OpenROM.Click += new System.EventHandler(this.OpenROM_Click);
            // 
            // ribbonButtonList1
            // 
            this.ribbonButtonList1.ButtonsSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.ribbonButtonList1.FlowToBottom = false;
            this.ribbonButtonList1.ItemsSizeInDropwDownMode = new System.Drawing.Size(7, 5);
            this.ribbonButtonList1.Name = "ribbonButtonList1";
            this.ribbonButtonList1.Text = "ribbonButtonList1";
            // 
            // OpenImage
            // 
            this.OpenImage.Enabled = false;
            this.OpenImage.Image = global::FriishProduce.Properties.Resources.image_add_large;
            this.OpenImage.LargeImage = global::FriishProduce.Properties.Resources.image_add_large;
            this.OpenImage.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.OpenImage.MinimumSize = new System.Drawing.Size(100, 0);
            this.OpenImage.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.SmallImage = global::FriishProduce.Properties.Resources.image_add;
            this.OpenImage.Tag = "r006";
            this.OpenImage.Text = "Open Image";
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // UseLibRetro
            // 
            this.UseLibRetro.Enabled = false;
            this.UseLibRetro.Image = global::FriishProduce.Properties.Resources.retroarch;
            this.UseLibRetro.LargeImage = global::FriishProduce.Properties.Resources.retroarch;
            this.UseLibRetro.MinimumSize = new System.Drawing.Size(175, 0);
            this.UseLibRetro.Name = "UseLibRetro";
            this.UseLibRetro.SmallImage = ((System.Drawing.Image)(resources.GetObject("UseLibRetro.SmallImage")));
            this.UseLibRetro.Tag = "r010";
            this.UseLibRetro.Text = "Use LibRetro data";
            this.UseLibRetro.Click += new System.EventHandler(this.UseLibRetro_Click);
            // 
            // ribbonPanel_Export
            // 
            this.ribbonPanel_Export.ButtonMoreVisible = false;
            this.ribbonPanel_Export.Items.Add(this.ExportWAD);
            this.ribbonPanel_Export.Name = "ribbonPanel_Export";
            this.ribbonPanel_Export.Tag = "r007";
            this.ribbonPanel_Export.Text = "Export";
            // 
            // ExportWAD
            // 
            this.ExportWAD.Enabled = false;
            this.ExportWAD.Image = global::FriishProduce.Properties.Resources.factory_large;
            this.ExportWAD.LargeImage = global::FriishProduce.Properties.Resources.factory_large;
            this.ExportWAD.MinimumSize = new System.Drawing.Size(175, 0);
            this.ExportWAD.Name = "ExportWAD";
            this.ExportWAD.SmallImage = ((System.Drawing.Image)(resources.GetObject("ExportWAD.SmallImage")));
            this.ExportWAD.Tag = "r008";
            this.ExportWAD.Text = "Save as WAD";
            this.ExportWAD.Click += new System.EventHandler(this.ExportWAD_Click);
            // 
            // tabControl
            // 
            this.tabControl.BackgroundImage = global::FriishProduce.Properties.Resources.bg;
            this.tabControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 130);
            this.tabControl.MenuRenderer = null;
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(1114, 531);
            this.tabControl.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.tabControl.TabBorderEnhanced = true;
            this.tabControl.TabBorderEnhanceWeight = MdiTabControl.TabControl.Weight.Soft;
            this.tabControl.TabCloseButtonImage = null;
            this.tabControl.TabCloseButtonImageDisabled = null;
            this.tabControl.TabCloseButtonImageHot = null;
            this.tabControl.TabCloseButtonSize = new System.Drawing.Size(14, 14);
            this.tabControl.TabHeight = 25;
            this.tabControl.TabIndex = 3;
            this.tabControl.TabMaximumWidth = 300;
            this.tabControl.Visible = false;
            this.tabControl.SelectedTabChanged += new System.EventHandler(this.TabChanged);
            this.tabControl.TabIndexChanged += new System.EventHandler(this.TabChanged);
            // 
            // SaveWAD
            // 
            this.SaveWAD.DefaultExt = "wad";
            // 
            // BrowseImage
            // 
            this.BrowseImage.Filter = "img|*.bmp;*.jpg;*.jpeg;*.png|bmp|*.bmp|jpeg|*.jpg;*.jpeg|png|*.png";
            // 
            // TabContextMenu
            // 
            this.TabContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Strip_OpenROM,
            this.Strip_OpenImage,
            this.toolStripSeparator1,
            this.Strip_UseLibRetro,
            this.toolStripSeparator2,
            this.Strip_ExportWAD});
            this.TabContextMenu.Name = "contextMenuStrip1";
            this.TabContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TabContextMenu.Size = new System.Drawing.Size(166, 104);
            // 
            // Strip_OpenROM
            // 
            this.Strip_OpenROM.Enabled = false;
            this.Strip_OpenROM.Image = global::FriishProduce.Properties.Resources.joystick_add;
            this.Strip_OpenROM.Name = "Strip_OpenROM";
            this.Strip_OpenROM.Size = new System.Drawing.Size(165, 22);
            this.Strip_OpenROM.Tag = "r005";
            this.Strip_OpenROM.Text = "Open ROM";
            this.Strip_OpenROM.Click += new System.EventHandler(this.OpenROM_Click);
            // 
            // Strip_OpenImage
            // 
            this.Strip_OpenImage.Enabled = false;
            this.Strip_OpenImage.Image = global::FriishProduce.Properties.Resources.image_add;
            this.Strip_OpenImage.Name = "Strip_OpenImage";
            this.Strip_OpenImage.Size = new System.Drawing.Size(165, 22);
            this.Strip_OpenImage.Tag = "r006";
            this.Strip_OpenImage.Text = "Open Image";
            this.Strip_OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // Strip_UseLibRetro
            // 
            this.Strip_UseLibRetro.Enabled = false;
            this.Strip_UseLibRetro.Name = "Strip_UseLibRetro";
            this.Strip_UseLibRetro.Size = new System.Drawing.Size(165, 22);
            this.Strip_UseLibRetro.Tag = "r010";
            this.Strip_UseLibRetro.Text = "Get LibRetro data";
            this.Strip_UseLibRetro.Click += new System.EventHandler(this.UseLibRetro_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(162, 6);
            // 
            // Strip_ExportWAD
            // 
            this.Strip_ExportWAD.Enabled = false;
            this.Strip_ExportWAD.Image = ((System.Drawing.Image)(resources.GetObject("Strip_ExportWAD.Image")));
            this.Strip_ExportWAD.Name = "Strip_ExportWAD";
            this.Strip_ExportWAD.Size = new System.Drawing.Size(165, 22);
            this.Strip_ExportWAD.Tag = "r008";
            this.Strip_ExportWAD.Text = "Save as WAD";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FriishProduce.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1114, 661);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ribbon1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "g000";
            this.Text = "g000";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.TabContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab_Home;
        private System.Windows.Forms.RibbonPanel ribbonPanel_Import;
        private System.Windows.Forms.RibbonButton OpenROM;
        private System.Windows.Forms.RibbonOrbMenuItem MenuItem_Settings;
        private System.Windows.Forms.RibbonSeparator orbMenuSeparator1;
        private MdiTabControl.TabControl tabControl;
        private System.Windows.Forms.RibbonPanel ribbonPanel_Export;
        private System.Windows.Forms.RibbonButton ExportWAD;
        internal System.Windows.Forms.OpenFileDialog BrowseROM;
        internal System.Windows.Forms.SaveFileDialog SaveWAD;
        private System.Windows.Forms.RibbonButtonList ribbonButtonList1;
        private System.Windows.Forms.RibbonButton OpenImage;
        private System.Windows.Forms.OpenFileDialog BrowseImage;
        private System.Windows.Forms.RibbonButton RibbonButton_Settings;
        private System.Windows.Forms.RibbonButton RibbonButton_About;
        private System.Windows.Forms.ContextMenuStrip TabContextMenu;
        private System.Windows.Forms.ToolStripMenuItem Strip_OpenROM;
        private System.Windows.Forms.ToolStripMenuItem Strip_OpenImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Strip_ExportWAD;
        private System.Windows.Forms.RibbonButton UseLibRetro;
        private System.Windows.Forms.ToolStripMenuItem Strip_UseLibRetro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.RibbonOrbMenuItem MenuItem_About;
        private System.Windows.Forms.RibbonOrbMenuItem MenuItem_Exit;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonOrbMenuItem NewProject;
        private System.Windows.Forms.RibbonSeparator orbMenuSeparator2;
        private System.Windows.Forms.RibbonButton CreateProject_NES;
        private System.Windows.Forms.RibbonSeparator CreateProject_List1;
        private System.Windows.Forms.RibbonButton CreateProject_SNES;
        private System.Windows.Forms.RibbonButton CreateProject_N64;
    }
}
