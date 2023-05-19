using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using Web_Browser.Properties;
using System.Resources;
using System.Runtime.CompilerServices;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Security.Policy;
using System.Xml.Linq;
using System.Threading;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;
namespace Web_Browser
{
    public partial class Bee : Form
    {
        public Bee()
        {
            InitializeComponent();
        }

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bee));
        string searchText, searchEngineDefault = "https://www.google.com/search?q=";//search engine mặc định
        WebView2 webB;
        int defItemOfSE = 4,defItemOfBM=3;
        string myIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where<IPAddress>(x => x.AddressFamily == AddressFamily.InterNetwork).FirstOrDefault().ToString();

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

            string[] lines = File.ReadAllLines("SE_Name.txt"), linesURL=File.ReadAllLines("SE_URL.txt");//update SE from file
            for(int i=0; i<lines.Length; i++)
            {
                addSE(i, lines[i], linesURL[i]);
            }
            lines = File.ReadAllLines("BM_Name.txt");//update BM from file
            linesURL= File.ReadAllLines("BM_URL.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                addBM(i, lines[i], linesURL[i]);
            }
            webB = new WebView2() { Parent=tabPage1,Dock=DockStyle.Fill };//tạo web browser mới
            await webB.EnsureCoreWebView2Async();

        }
        void addSE(int index, string name,string url)//add SE
        {
            searchEngineToolStripMenuItem.DropDownItems.Add(name);
            searchEngineToolStripMenuItem.DropDownItems[index + defItemOfSE].AccessibleDescription = index.ToString();
            searchEngineToolStripMenuItem.DropDownItems[index + defItemOfSE].ToolTipText = url;
        }
        void addBM(int index, string name,string url)//add BM
        {
            bookmarksMenu.DropDownItems.Add(name);
            bookmarksMenu.DropDownItems[index + defItemOfBM].AccessibleDescription = index.ToString();
            bookmarksMenu.DropDownItems[index + defItemOfBM].ToolTipText = url;
        }

        private void SearchEngineToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.AccessibleDescription==null) return;

            searchEngineDefault= File.ReadAllLines("SE_URL.txt")[int.Parse(e.ClickedItem.AccessibleDescription)];//change SE
            SEName.Text = e.ClickedItem.Text;
            
        }
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

        private void addAbout_Click(object sender, EventArgs e)//about
        {
            MessageBox.Show("Web browser do Nhóm 4 phát triển");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)//nút tìm kiếm
        {
            searchText = searchBox.Text;
            if (searchText.Contains("www.")||searchText.Contains("http"))
                webB.CoreWebView2.Navigate(searchText);
            else
                webB.CoreWebView2.Navigate(searchEngineDefault + searchText);
            webB.NavigationCompleted += WebView_NavigationCompleted;
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)//nhấn enter tìm kiếm
        {
            if (e.KeyChar == (char)Keys.Enter) 
                toolStripButton5_Click(null,EventArgs.Empty);
       }
        private void addNewTab()
        {
            TabPage newTab = new TabPage();
            newTab.Text = "New Tab";
            tabControl1.Controls.Add(newTab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);
            webB = new WebView2() { Parent = newTab, Dock = DockStyle.Fill };
            searchBox.Text = "";
        }
        private void toolStripButton7_Click(object sender, EventArgs e)//nút new tab
        {
            addNewTab();
        }
        private void closeTab()
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            if (tabControl1.TabCount == 0)
            {
                newTabButton.PerformClick();
            }
        }
        private void toolStripButton8_Click(object sender, EventArgs e)//nút close tab
        {
            closeTab();
        }

        private void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)//cập nhật tên tab
        {
            tabControl1.SelectedTab.Text = webB.CoreWebView2.DocumentTitle;
            searchBox.Text = webB.Source.ToString();

            tabControl1.SelectedTab.AccessibleDescription = searchBox.Text;
                if (isBookmarked(webB.Source.ToString())) bookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("alreadyBookmarkButton.Image")));
                else bookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("bookmarkButton.Image")));
        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)//SE google
        {
            searchEngineDefault = "https://www.google.com/search?q=";
            SEName.Text = "Google";
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
        private void bookmarkButton_Click(object sender, EventArgs e)//bookmark
        {
            if (webB.Source == null) return;
            bool bookmarked = isBookmarked(webB.Source.ToString());
            if (!bookmarked)
            {
                bookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("alreadyBookmarkButton.Image")));
                addThisBookmark();
            }
            else { 
                bookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("bookmarkButton.Image")));
                deleteLineOfFile(webB.CoreWebView2.DocumentTitle, "BM_Name.txt");
                deleteLineOfFile(webB.Source.ToString(), "BM_URL.txt");
            }
            updateBM();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.F5)
                webB.Refresh();
        }

        private void addSearchEngine_Click(object sender, EventArgs e)//show form to add SE
        {
            Form f = new addSearchEngine_F();
            f.ShowDialog();
            updateSE();
        }


        void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
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

        private void deleteSEButton_Click(object sender, EventArgs e)//delete SE
        {
            Form f = new deleteSE_F();
            f.ShowDialog();
            updateSE();
        }

        private void editSEButton_Click(object sender, EventArgs e)//edit SE
        {
            Form form = new editSE_F();
            form.ShowDialog();
            updateSE();
        }

        void updateSE()//update SE
        {
            while(searchEngineToolStripMenuItem.DropDownItems.Count>defItemOfSE)
            {
                searchEngineToolStripMenuItem.DropDownItems.RemoveAt(defItemOfSE);
            }
            string[] lines = File.ReadAllLines("SE_Name.txt"),linesURL= File.ReadAllLines("SE_URL.txt");
            for(int i=0;i<lines.Length;i++)
            {
                addSE(searchEngineToolStripMenuItem.DropDownItems.Count - defItemOfSE, lines[i], linesURL[i]);
            }
        }
        void updateBM()//update BM
        {
            while (bookmarksMenu.DropDownItems.Count > defItemOfBM)
            {
                bookmarksMenu.DropDownItems.RemoveAt(defItemOfBM);
            }
            string[] lines = File.ReadAllLines("BM_Name.txt"), linesURL = File.ReadAllLines("BM_URL.txt");
            for(int i=0;i<lines.Length;i++)
            {
                addBM(bookmarksMenu.DropDownItems.Count - defItemOfBM, lines[i], linesURL[i]);
            }
        }

        bool isBookmarked(string URL)//check bookmark
        {
            if (URL == null) return false;
            string[] bmURLs = File.ReadAllLines("BM_URL.txt");
            foreach (string bmURL in bmURLs)
            {
                if(URL==bmURL) return true;
            }
            return false;
        }

        private void addBookmarkButton_Click(object sender, EventArgs e)
        {
            Form form = new addBookmark_F();
            form.ShowDialog();
            updateBM();
        }

        private void deleteBookmarkButton_Click(object sender, EventArgs e)//delete bookmark
        {
            Form form = new deleteBM_F();
            form.ShowDialog();
            updateBM();
        }

        private void editBookmarkButton_Click(object sender, EventArgs e)
        {
            Form form = new editBM_F();
            form.ShowDialog();
            updateBM();
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNewTab();
        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeTab();
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
                    if (line!=lineND)
                        sw.WriteLine(line);
                }
            }
            File.Delete(FileName);
            File.Move(tempF, FileName);
        }
    }
}
