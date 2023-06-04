using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Web_Browser
{
    public partial class Bee : Form
    {
        #region initial

        public Bee()
        {
            InitializeComponent();
        }

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bee));
        string searchText, searchEngineDefault = "https://www.google.com/search?q=";//search engine mặc định
        WebView2 webB;
        int defItemOfSE = 4, defItemOfBM = 3, defItemOfH = 3;
        string myIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where<IPAddress>(x => x.AddressFamily == AddressFamily.InterNetwork).FirstOrDefault().ToString();
        System.Windows.Forms.ListView lv;

        private async void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("SE_Name.txt"))//check file SE
                File.Create("SE_Name.txt");
            if (!File.Exists("SE_URL.txt"))
                File.Create("SE_URL.txt");
            if (!File.Exists("BM_Name.txt"))//check file BM
                File.Create("BM_Name.txt");
            if (!File.Exists("BM_URL.txt"))
                File.Create("BM_URL.txt");
            if (!File.Exists("H_Name.txt"))//check file History
                File.Create("H_Name.txt");
            if (!File.Exists("H_DateTime.txt"))
                File.Create("H_DateTime.txt");
            if (!File.Exists("H_URL.txt"))
                File.Create("H_URL.txt");

            string[] lines = File.ReadAllLines("SE_Name.txt"), linesURL = File.ReadAllLines("SE_URL.txt");//update SE from file
            for (int i = 0; i < lines.Length; i++)
            {
                addSE(i, lines[i], linesURL[i]);
            }
            lines = File.ReadAllLines("BM_Name.txt");//update BM from file
            linesURL = File.ReadAllLines("BM_URL.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                addBM(i, lines[i], linesURL[i]);
            }
            lines = File.ReadAllLines("H_Name.txt");//update H from file
            linesURL = File.ReadAllLines("H_URL.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                addH(i, lines[i], linesURL[i]);
            }

            webB = new WebView2() { Parent = tabControl1.SelectedTab, Dock = DockStyle.Fill };
            await webB.EnsureCoreWebView2Async();
            webB.CoreWebView2.DOMContentLoaded += WebView_ContentLoaded;
        }
        #endregion

        #region button lv1

        private void toolStripButton1_Click(object sender, EventArgs e)//nút quay lại trang trước
        {
            webB.GoBack();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)//nút đi đến trang sau
        {
            webB.GoForward();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)//nút tải lại
        {
            webB.Refresh();
        }
        private void toolStripButton4_Click(object sender, EventArgs e)//nút dừng tải
        {
            webB.Stop();
        }
        private void searchButton_Click(object sender, EventArgs e)//nút tìm kiếm
        {
            searchText = searchBox.Text;
            if (searchText.Contains("www.") || searchText.Contains("http"))
                webB.CoreWebView2.Navigate(searchText);
            else
                webB.CoreWebView2.Navigate(searchEngineDefault + searchText);
        }
        private void bookmarkButton_Click(object sender, EventArgs e)//bookmark
        {
            if (webB.Source.ToString() == "about:blank") return;
            bool bookmarked = isBookmarked(webB.Source.ToString());
            if (!bookmarked)
            {
                bookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("alreadyBookmarkButton.Image")));
                addThisBookmark();
            }
            else
            {
                bookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("bookmarkButton.Image")));
                deleteLineOfFile(webB.CoreWebView2.DocumentTitle, "BM_Name.txt");
                deleteLineOfFile(webB.Source.ToString(), "BM_URL.txt");
            }
            updateBM();
        }
        private void toolStripButton7_Click(object sender, EventArgs e)//nút new tab
        {
            addNewTab();
        }
        private void toolStripButton8_Click(object sender, EventArgs e)//nút close tab
        {
            closeTab();
        }
        private void moreButton_ButtonClick(object sender, EventArgs e)
        {

        }

        #endregion

        #region button lv2
            #region moreButton's buttons
        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)//new tab button
        {
            addNewTab();
        }
        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)//close tab button
        {
            closeTab();
        }
        private void closeAllTabs_Click(object sender, EventArgs e)//đóng tất cả tabs
        {
            tabControl1.TabPages.Clear();
            if (tabControl1.TabCount == 0)
            {
                newTabButton.PerformClick();
            }
        }
        private void bookmarks_Click(object sender, EventArgs e)
        {

        }
        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void searchEngineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void addAbout_Click(object sender, EventArgs e)//about
        {
            MessageBox.Show("Web browser do Nhóm 4 phát triển");
        }

        #endregion
        #endregion

        #region button lv3
        #region BM's buttons
        private void addBookmarkButton_Click(object sender, EventArgs e)//add bookmark button
        {
            Form form = new addBookmark_F();
            form.ShowDialog();
            updateBM();
        }
        private void deleteBookmarkButton_Click(object sender, EventArgs e)//delete bookmark button
        {
            Form form = new deleteBM_F();
            form.ShowDialog();
            updateBM();
        }
        private void editBookmarkButton_Click(object sender, EventArgs e)//edit bookmark button
        {
            Form form = new editBM_F();
            form.ShowDialog();
            updateBM();
        }
        private void bookmarkMenu_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.AccessibleDescription == null) return;
            searchBox.Text = e.ClickedItem.ToolTipText;
            searchButton.PerformClick();
        }

        #endregion

        #region SE's buttons
        private void addSearchEngine_Click(object sender, EventArgs e)//add SE button
        {
            Form f = new addSearchEngine_F();
            f.ShowDialog();
            updateSE();
        }
        private void deleteSEButton_Click(object sender, EventArgs e)//delete SE button
        {
            Form f = new deleteSE_F();
            f.ShowDialog();
            updateSE();
        }

        private void editSEButton_Click(object sender, EventArgs e)//edit SE button
        {
            Form form = new editSE_F();
            form.ShowDialog();
            updateSE();
        }
        private void googleToolStripMenuItem_Click(object sender, EventArgs e)//SE google button
        {
            searchEngineDefault = "https://www.google.com/search?q=";
            SEName.Text = "Google";
        }
        private void SearchEngineToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)//search engines as items button
        {
            if (e.ClickedItem.AccessibleDescription == null) return;

            searchEngineDefault = File.ReadAllLines("SE_URL.txt")[int.Parse(e.ClickedItem.AccessibleDescription)];//change SE
            SEName.Text = e.ClickedItem.Text;
        }

        #endregion

        #region H's buttons

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)//Clear history
        {
            File.Delete("H_Name.txt");
            File.Delete("H_URL.txt");
            File.Delete("H_DateTime.txt");
            using (var s = File.Create("H_Name.txt"))
            using (var s1 = File.Create("H_URL.txt"))
            using (var s2 = File.Create("H_DateTime.txt")) { }
            updateH();
        }
        private void historyToolStripMenuItem1_Click(object sender, EventArgs e)//open history view
        {
            TabPage newTab = new TabPage();
            newTab.Size = new System.Drawing.Size(1192, 620);
            newTab.Text = "History";
            newTab.UseVisualStyleBackColor = true;

            lv=new System.Windows.Forms.ListView() { Dock=DockStyle.Fill, 
                FullRowSelect = true, 
                HideSelection = false ,
                MultiSelect = false,
                View = System.Windows.Forms.View.Details,
                 
            };
            lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            new ColumnHeader(){ Text = "Time", Width = 205 },
            new ColumnHeader(){ Text = "Page\'s title", Width = 205 },
            new ColumnHeader(){ Text = "Page\'s URL", Width = 427 },
            });
            string[] linesName = File.ReadAllLines("H_Name.txt"), linesURL = File.ReadAllLines("H_URL.txt"), linesDT = File.ReadAllLines("H_DateTime.txt");
            for (int i = 0; i < linesName.Count(); i++)
            {
                string[] row = { linesDT[i], linesName[i], linesURL[i] };
                ListViewItem lvi = new ListViewItem(row);
                lv.Items.Add(lvi); 
            }

            newTab.Controls.Add(lv);

            tabControl1.Controls.Add(newTab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);

            searchBox.Text = "";
            lv.MouseDoubleClick += new MouseEventHandler(historyViewItem_DoubleClicked);
        }

        private async void historyViewItem_DoubleClicked(object sender, MouseEventArgs e)//Navigate web from history view
        {
            ListViewHitTestInfo info = lv.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                TabPage newTab = new TabPage();
                newTab.Size = new System.Drawing.Size(1192, 620);
                newTab.Text = "New Tab";
                newTab.UseVisualStyleBackColor = true;

                webB = new WebView2() { Dock = DockStyle.Fill };
                newTab.Controls.Add(webB);

                tabControl1.Controls.Add(newTab);
                tabControl1.SelectTab(tabControl1.TabCount - 1);

                await webB.EnsureCoreWebView2Async();
                webB.CoreWebView2.DOMContentLoaded += WebView_ContentLoaded;
                searchBox.Text = item.SubItems[2].Text;
                searchButton.PerformClick();
            }
        }

        private void historyMenu_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)//Navigate web from recent history
        {
            if (e.ClickedItem.AccessibleDescription == null) return;
            searchBox.Text = e.ClickedItem.ToolTipText;
            searchButton.PerformClick();
        }


        #endregion

        #endregion

        #region support buttons/functions functions

        private async void addNewTab()//new tab
        {
            TabPage newTab = new TabPage();
            newTab.Size = new System.Drawing.Size(1192, 620);
            newTab.Text = "New Tab";
            newTab.UseVisualStyleBackColor = true;

            webB = new WebView2() { Dock = DockStyle.Fill };
            newTab.Controls.Add(webB);

            tabControl1.Controls.Add(newTab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);

            await webB.EnsureCoreWebView2Async();
            webB.CoreWebView2.DOMContentLoaded += WebView_ContentLoaded;
            searchBox.Text = "";
        }
        private void closeTab()//close tab
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            if (tabControl1.TabCount == 0)
            {
                newTabButton.PerformClick();
            }
        }
        void addThisBookmark()//bookmark current tab
        {
            using (StreamWriter sw = File.AppendText("BM_Name.txt"))
            {
                sw.WriteLine(webB.CoreWebView2.DocumentTitle);
            }
            using (StreamWriter sw = File.AppendText("BM_URL.txt"))
            {
                sw.WriteLine(webB.Source.ToString());
            }
        }
        void deleteLineOfFile(string lineND, string FileName)//delete line of file, use for delete bookmark
        {
            string tempF = Path.GetTempFileName();
            using (StreamReader sr = new StreamReader(FileName))
            using (StreamWriter sw = new StreamWriter(tempF))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != lineND)
                        sw.WriteLine(line);
                }
            }
            File.Delete(FileName);
            File.Move(tempF, FileName);
        }
        void addSE(int index, string name, string url)//add SE
        {
            searchEngineToolStripMenuItem.DropDownItems.Add(name);
            searchEngineToolStripMenuItem.DropDownItems[index + defItemOfSE].AccessibleDescription = index.ToString();
            searchEngineToolStripMenuItem.DropDownItems[index + defItemOfSE].ToolTipText = url;
        }
        void addBM(int index, string name, string url)//add BM
        {
            bookmarksMenu.DropDownItems.Add(name);
            bookmarksMenu.DropDownItems[index + defItemOfBM].AccessibleDescription = index.ToString();
            bookmarksMenu.DropDownItems[index + defItemOfBM].ToolTipText = url;
        }
        void addH(int index, string name, string url)//add H
        {
            historyMenu.DropDownItems.Add(name);
            historyMenu.DropDownItems[index + defItemOfH].AccessibleDescription = index.ToString();
            historyMenu.DropDownItems[index + defItemOfH].ToolTipText = url;
        }
        bool isBookmarked(string URL)//check bookmark
        {
            if (URL == null) return false;
            string[] bmURLs = File.ReadAllLines("BM_URL.txt");
            foreach (string bmURL in bmURLs)
            {
                if (URL == bmURL) return true;
            }
            return false;
        }
        void recordHistory2LocalFile(string Name, string URL)//Record history
        {
            if (Name == "") return;
            string tempF = Path.GetTempFileName();
            using(var sw=new StreamWriter(tempF))
            {
                sw.WriteLine(Name);
            }
            using (Stream input = File.OpenRead("H_Name.txt"))
            using (Stream output = new FileStream(tempF, FileMode.Append, FileAccess.Write, FileShare.None))
            {
                input.CopyTo(output);
            }
            File.Delete("H_Name.txt");
            File.Move(tempF, "H_Name.txt");
            tempF = Path.GetTempFileName();
            using (var sw = new StreamWriter(tempF))
            {
                sw.WriteLine(URL);
            }
            using (Stream input = File.OpenRead("H_URL.txt"))
            using (Stream output = new FileStream(tempF, FileMode.Append, FileAccess.Write, FileShare.None))
            {
                input.CopyTo(output);
            }
            File.Delete("H_URL.txt");
            File.Move(tempF, "H_URL.txt");
            tempF = Path.GetTempFileName();
            using (var sw = new StreamWriter(tempF))
            {
                sw.WriteLine(DateTime.Now.ToString());
            }
            using (Stream input = File.OpenRead("H_DateTime.txt"))
            using (Stream output = new FileStream(tempF, FileMode.Append, FileAccess.Write, FileShare.None))
            {
                input.CopyTo(output);
            }
            File.Delete("H_DateTime.txt");
            File.Move(tempF, "H_DateTime.txt");
        }

        #endregion

        #region support user experience

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)//nhấn enter tìm kiếm
        {
            if (e.KeyChar == (char)Keys.Enter)
                searchButton.PerformClick();
        }
        private void WebView_ContentLoaded(object sender, CoreWebView2DOMContentLoadedEventArgs e)//cập nhật tên tab, URL, bookmark
        {
            tabControl1.SelectedTab.Text = webB.CoreWebView2.DocumentTitle;
            searchBox.Text = webB.Source.ToString();
            tabControl1.SelectedTab.AccessibleDescription = searchBox.Text;
            recordHistory2LocalFile(webB.CoreWebView2.DocumentTitle, webB.Source.ToString());
            if (isBookmarked(webB.Source.ToString())) bookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("alreadyBookmarkButton.Image")));
            else bookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("bookmarkButton.Image")));
            webB.Select();
            updateH();
        }
        void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)//update URL, bookmark when change tab
        {
            TabPage current = (sender as TabControl).SelectedTab;
            if (current != null)
            {
                if (!string.IsNullOrEmpty(current.AccessibleDescription))
                {
                    searchBox.Text = current.AccessibleDescription;
                    if (isBookmarked(current.AccessibleDescription))
                    {
                        bookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("alreadyBookmarkButton.Image")));
                    }
                    else
                    {
                        bookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("bookmarkButton.Image")));
                    }
                }
            }
        }
        void updateSE()//update SE after user interact with SE
        {
            while (searchEngineToolStripMenuItem.DropDownItems.Count > defItemOfSE)
            {
                searchEngineToolStripMenuItem.DropDownItems.RemoveAt(defItemOfSE);
            }
            string[] lines = File.ReadAllLines("SE_Name.txt"), linesURL = File.ReadAllLines("SE_URL.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                addSE(searchEngineToolStripMenuItem.DropDownItems.Count - defItemOfSE, lines[i], linesURL[i]);
            }
        }
        void updateBM()//update BM after user interact with BM
        {
            while (bookmarksMenu.DropDownItems.Count > defItemOfBM)
            {
                bookmarksMenu.DropDownItems.RemoveAt(defItemOfBM);
            }
            string[] lines = File.ReadAllLines("BM_Name.txt"), linesURL = File.ReadAllLines("BM_URL.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                addBM(bookmarksMenu.DropDownItems.Count - defItemOfBM, lines[i], linesURL[i]);
            }
        }
        void updateH()//update H after user interact with H
        {
            while (historyMenu.DropDownItems.Count > defItemOfH)
            {
                historyMenu.DropDownItems.RemoveAt(defItemOfH);
            }
            string[] lines = File.ReadAllLines("H_Name.txt"), linesURL = File.ReadAllLines("H_URL.txt");
            for (int i = 0; i < 10; i++)
                try { addH(historyMenu.DropDownItems.Count - defItemOfH, lines[i], linesURL[i]); } 
                catch { continue; }
        }

        #endregion
    }
}
