
using System;
using System.Windows.Forms;

namespace Web_Browser
{
    partial class Bee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bee));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.goBackButton = new System.Windows.Forms.ToolStripButton();
            this.goForwadButton = new System.Windows.Forms.ToolStripButton();
            this.reloadButton = new System.Windows.Forms.ToolStripButton();
            this.stopLoadButton = new System.Windows.Forms.ToolStripButton();
            this.SEName = new System.Windows.Forms.ToolStripLabel();
            this.searchBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchButton = new System.Windows.Forms.ToolStripButton();
            this.bookmarkButton = new System.Windows.Forms.ToolStripButton();
            this.newTabButton = new System.Windows.Forms.ToolStripButton();
            this.closeTabButton = new System.Windows.Forms.ToolStripButton();
            this.moreButton = new System.Windows.Forms.ToolStripSplitButton();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllTabs = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarksMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookmarkButton = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBookmarkButton = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookmarkButton = new System.Windows.Forms.ToolStripMenuItem();
            this.historyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchEngineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSearchEngine = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSEButton = new System.Windows.Forms.ToolStripMenuItem();
            this.editSEButton = new System.Windows.Forms.ToolStripMenuItem();
            this.googleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alreadyBookmarkButton = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Maroon;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBackButton,
            this.goForwadButton,
            this.reloadButton,
            this.stopLoadButton,
            this.SEName,
            this.searchBox,
            this.searchButton,
            this.bookmarkButton,
            this.newTabButton,
            this.closeTabButton,
            this.moreButton,
            this.alreadyBookmarkButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1350, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // goBackButton
            // 
            this.goBackButton.AutoToolTip = false;
            this.goBackButton.BackColor = System.Drawing.Color.Maroon;
            this.goBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goBackButton.Image = ((System.Drawing.Image)(resources.GetObject("goBackButton.Image")));
            this.goBackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(34, 33);
            this.goBackButton.Text = "toolStripButton1";
            this.goBackButton.ToolTipText = "Click to go back";
            this.goBackButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // goForwadButton
            // 
            this.goForwadButton.AutoToolTip = false;
            this.goForwadButton.BackColor = System.Drawing.Color.Maroon;
            this.goForwadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goForwadButton.Image = ((System.Drawing.Image)(resources.GetObject("goForwadButton.Image")));
            this.goForwadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goForwadButton.Name = "goForwadButton";
            this.goForwadButton.Size = new System.Drawing.Size(34, 33);
            this.goForwadButton.Text = "toolStripButton2";
            this.goForwadButton.ToolTipText = "Click to go forward";
            this.goForwadButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.AutoToolTip = false;
            this.reloadButton.BackColor = System.Drawing.Color.Maroon;
            this.reloadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reloadButton.Image = ((System.Drawing.Image)(resources.GetObject("reloadButton.Image")));
            this.reloadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(34, 33);
            this.reloadButton.Text = "toolStripButton3";
            this.reloadButton.ToolTipText = "Reload this page";
            this.reloadButton.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // stopLoadButton
            // 
            this.stopLoadButton.AutoToolTip = false;
            this.stopLoadButton.BackColor = System.Drawing.Color.Maroon;
            this.stopLoadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopLoadButton.Image = ((System.Drawing.Image)(resources.GetObject("stopLoadButton.Image")));
            this.stopLoadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopLoadButton.Name = "stopLoadButton";
            this.stopLoadButton.Size = new System.Drawing.Size(34, 33);
            this.stopLoadButton.Text = "toolStripButton4";
            this.stopLoadButton.ToolTipText = "Stop loading this page";
            this.stopLoadButton.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // SEName
            // 
            this.SEName.BackColor = System.Drawing.Color.Maroon;
            this.SEName.BackgroundImage = global::Web_Browser.Properties.Resources.white;
            this.SEName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SEName.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEName.Name = "SEName";
            this.SEName.Size = new System.Drawing.Size(71, 33);
            this.SEName.Text = "Google";
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(562, 38);
            this.searchBox.ToolTipText = "Enter a keyword/url here";
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.AutoToolTip = false;
            this.searchButton.BackColor = System.Drawing.Color.Maroon;
            this.searchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(34, 33);
            this.searchButton.Text = "toolStripButton5";
            this.searchButton.ToolTipText = "Search keyword or Navigate URL";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // bookmarkButton
            // 
            this.bookmarkButton.AutoToolTip = false;
            this.bookmarkButton.BackColor = System.Drawing.Color.Maroon;
            this.bookmarkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("bookmarkButton.Image")));
            this.bookmarkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bookmarkButton.Name = "bookmarkButton";
            this.bookmarkButton.Size = new System.Drawing.Size(34, 33);
            this.bookmarkButton.Text = "toolStripButton6";
            this.bookmarkButton.ToolTipText = "Bookmark this tab";
            this.bookmarkButton.Click += new System.EventHandler(this.bookmarkButton_Click);
            // 
            // newTabButton
            // 
            this.newTabButton.AutoToolTip = false;
            this.newTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.newTabButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newTabButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTabButton.Image = ((System.Drawing.Image)(resources.GetObject("newTabButton.Image")));
            this.newTabButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newTabButton.Name = "newTabButton";
            this.newTabButton.Size = new System.Drawing.Size(87, 33);
            this.newTabButton.Text = "New tab";
            this.newTabButton.ToolTipText = "New tab";
            this.newTabButton.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // closeTabButton
            // 
            this.closeTabButton.AutoToolTip = false;
            this.closeTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.closeTabButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.closeTabButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeTabButton.Image = ((System.Drawing.Image)(resources.GetObject("closeTabButton.Image")));
            this.closeTabButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeTabButton.Name = "closeTabButton";
            this.closeTabButton.Size = new System.Drawing.Size(94, 33);
            this.closeTabButton.Text = "Close tab";
            this.closeTabButton.ToolTipText = "Close selected tab";
            this.closeTabButton.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // moreButton
            // 
            this.moreButton.AutoToolTip = false;
            this.moreButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moreButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem,
            this.closeTabToolStripMenuItem,
            this.closeAllTabs,
            this.bookmarksMenu,
            this.historyMenu,
            this.searchEngineToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.moreButton.Image = ((System.Drawing.Image)(resources.GetObject("moreButton.Image")));
            this.moreButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moreButton.Name = "moreButton";
            this.moreButton.Size = new System.Drawing.Size(41, 33);
            this.moreButton.Text = "toolStripSplitButton1";
            this.moreButton.ToolTipText = "More control of Bee";
            this.moreButton.ButtonClick += new System.EventHandler(this.moreButton_ButtonClick);
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.newTabToolStripMenuItem.Text = "New Tab";
            this.newTabToolStripMenuItem.Click += new System.EventHandler(this.newTabToolStripMenuItem_Click);
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            this.closeTabToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.closeTabToolStripMenuItem.Text = "Close Tab";
            this.closeTabToolStripMenuItem.Click += new System.EventHandler(this.closeTabToolStripMenuItem_Click);
            // 
            // closeAllTabs
            // 
            this.closeAllTabs.Name = "closeAllTabs";
            this.closeAllTabs.Size = new System.Drawing.Size(270, 34);
            this.closeAllTabs.Text = "Close all tabs";
            this.closeAllTabs.ToolTipText = "Close all tabs";
            this.closeAllTabs.Click += new System.EventHandler(this.closeAllTabs_Click);
            // 
            // bookmarksMenu
            // 
            this.bookmarksMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookmarkButton,
            this.deleteBookmarkButton,
            this.editBookmarkButton});
            this.bookmarksMenu.Name = "bookmarksMenu";
            this.bookmarksMenu.Size = new System.Drawing.Size(270, 34);
            this.bookmarksMenu.Text = "Bookmarks";
            this.bookmarksMenu.ToolTipText = "Options and list of bookmarks";
            this.bookmarksMenu.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bookmarkMenu_DropDownItemClicked);
            this.bookmarksMenu.Click += new System.EventHandler(this.bookmarks_Click);
            // 
            // addBookmarkButton
            // 
            this.addBookmarkButton.Name = "addBookmarkButton";
            this.addBookmarkButton.Size = new System.Drawing.Size(284, 34);
            this.addBookmarkButton.Text = "Add new bookmark...";
            this.addBookmarkButton.ToolTipText = "Add a new bookmark";
            this.addBookmarkButton.Click += new System.EventHandler(this.addBookmarkButton_Click);
            // 
            // deleteBookmarkButton
            // 
            this.deleteBookmarkButton.Name = "deleteBookmarkButton";
            this.deleteBookmarkButton.Size = new System.Drawing.Size(284, 34);
            this.deleteBookmarkButton.Text = "Delete bookmark...";
            this.deleteBookmarkButton.ToolTipText = "Delete a bookmark or all bookmarks";
            this.deleteBookmarkButton.Click += new System.EventHandler(this.deleteBookmarkButton_Click);
            // 
            // editBookmarkButton
            // 
            this.editBookmarkButton.Name = "editBookmarkButton";
            this.editBookmarkButton.Size = new System.Drawing.Size(284, 34);
            this.editBookmarkButton.Text = "Edit bookmark...";
            this.editBookmarkButton.ToolTipText = "Edit a bookmark";
            this.editBookmarkButton.Click += new System.EventHandler(this.editBookmarkButton_Click);
            // 
            // historyMenu
            // 
            this.historyMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem1,
            this.clearHistoryToolStripMenuItem,
            this.recentHistoryToolStripMenuItem});
            this.historyMenu.Name = "historyMenu";
            this.historyMenu.Size = new System.Drawing.Size(270, 34);
            this.historyMenu.Text = "History";
            this.historyMenu.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.historyMenu_DropDownItemClicked);
            this.historyMenu.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem1
            // 
            this.historyToolStripMenuItem1.Name = "historyToolStripMenuItem1";
            this.historyToolStripMenuItem1.Size = new System.Drawing.Size(248, 34);
            this.historyToolStripMenuItem1.Text = "History...";
            this.historyToolStripMenuItem1.ToolTipText = "Open history tabview";
            this.historyToolStripMenuItem1.Click += new System.EventHandler(this.historyToolStripMenuItem1_Click);
            // 
            // clearHistoryToolStripMenuItem
            // 
            this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.clearHistoryToolStripMenuItem.Text = "Clear history...";
            this.clearHistoryToolStripMenuItem.ToolTipText = "Clear history";
            this.clearHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearHistoryToolStripMenuItem_Click);
            // 
            // recentHistoryToolStripMenuItem
            // 
            this.recentHistoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.recentHistoryToolStripMenuItem.Enabled = false;
            this.recentHistoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.recentHistoryToolStripMenuItem.Name = "recentHistoryToolStripMenuItem";
            this.recentHistoryToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.recentHistoryToolStripMenuItem.Text = "Recent history:";
            // 
            // searchEngineToolStripMenuItem
            // 
            this.searchEngineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSearchEngine,
            this.deleteSEButton,
            this.editSEButton,
            this.googleToolStripMenuItem});
            this.searchEngineToolStripMenuItem.Name = "searchEngineToolStripMenuItem";
            this.searchEngineToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.searchEngineToolStripMenuItem.Text = "Search Engine";
            this.searchEngineToolStripMenuItem.ToolTipText = "Options and list of search engines";
            this.searchEngineToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.SearchEngineToolStripMenuItem_DropDownItemClicked);
            this.searchEngineToolStripMenuItem.Click += new System.EventHandler(this.searchEngineToolStripMenuItem_Click);
            // 
            // addSearchEngine
            // 
            this.addSearchEngine.Name = "addSearchEngine";
            this.addSearchEngine.Size = new System.Drawing.Size(289, 34);
            this.addSearchEngine.Text = "Add search engine...";
            this.addSearchEngine.ToolTipText = "Add a new search engine";
            this.addSearchEngine.Click += new System.EventHandler(this.addSearchEngine_Click);
            // 
            // deleteSEButton
            // 
            this.deleteSEButton.Name = "deleteSEButton";
            this.deleteSEButton.Size = new System.Drawing.Size(289, 34);
            this.deleteSEButton.Text = "Delete search engine...";
            this.deleteSEButton.ToolTipText = "Delete a search engine or all search engines";
            this.deleteSEButton.Click += new System.EventHandler(this.deleteSEButton_Click);
            // 
            // editSEButton
            // 
            this.editSEButton.Name = "editSEButton";
            this.editSEButton.Size = new System.Drawing.Size(289, 34);
            this.editSEButton.Text = "Edit search engine...";
            this.editSEButton.ToolTipText = "Edit a search engine";
            this.editSEButton.Click += new System.EventHandler(this.editSEButton_Click);
            // 
            // googleToolStripMenuItem
            // 
            this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
            this.googleToolStripMenuItem.Size = new System.Drawing.Size(289, 34);
            this.googleToolStripMenuItem.Text = "Google";
            this.googleToolStripMenuItem.ToolTipText = "https://www.google.com/search?q=";
            this.googleToolStripMenuItem.Click += new System.EventHandler(this.googleToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.ToolTipText = "Some info about this web browser";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.addAbout_Click);
            // 
            // alreadyBookmarkButton
            // 
            this.alreadyBookmarkButton.BackColor = System.Drawing.Color.Maroon;
            this.alreadyBookmarkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alreadyBookmarkButton.Enabled = false;
            this.alreadyBookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("alreadyBookmarkButton.Image")));
            this.alreadyBookmarkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alreadyBookmarkButton.Name = "alreadyBookmarkButton";
            this.alreadyBookmarkButton.Size = new System.Drawing.Size(34, 33);
            this.alreadyBookmarkButton.Text = "toolStripButton1";
            this.alreadyBookmarkButton.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage1.Size = new System.Drawing.Size(1342, 774);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Tab";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 38);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1350, 807);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // Bee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1350, 845);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Bee";
            this.Text = "Bee";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripButton goBackButton;
        private System.Windows.Forms.ToolStripButton goForwadButton;
        private System.Windows.Forms.ToolStripButton reloadButton;
        private System.Windows.Forms.ToolStripButton stopLoadButton;
        private System.Windows.Forms.ToolStripTextBox searchBox;
        private System.Windows.Forms.ToolStripButton searchButton;
        private System.Windows.Forms.ToolStripButton bookmarkButton;
        private System.Windows.Forms.ToolStripSplitButton moreButton;
        private System.Windows.Forms.ToolStripMenuItem bookmarksMenu;
        private System.Windows.Forms.ToolStripMenuItem historyMenu;
        private System.Windows.Forms.ToolStripMenuItem searchEngineToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newTabButton;
        private System.Windows.Forms.ToolStripButton closeTabButton;
        private ToolStripMenuItem googleToolStripMenuItem;
        private ToolStripLabel SEName;
        private ToolStripMenuItem closeAllTabs;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem addSearchEngine;
        private ToolStripMenuItem deleteSEButton;
        private ToolStripMenuItem editSEButton;
        private ToolStripMenuItem addBookmarkButton;
        private ToolStripMenuItem deleteBookmarkButton;
        private ToolStripMenuItem editBookmarkButton;
        private ToolStripButton alreadyBookmarkButton;
        private ToolStripMenuItem newTabToolStripMenuItem;
        private ToolStripMenuItem closeTabToolStripMenuItem;
        private ToolStripMenuItem clearHistoryToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem1;
        private ToolStripMenuItem recentHistoryToolStripMenuItem;
    }
}

