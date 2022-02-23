using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace Zelta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string url = "https://google.com";

        private void Form1_Load(object sender, EventArgs e)
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            richTextBox1.Text = "https://www.google.com";
            ChromiumWebBrowser chrome = new ChromiumWebBrowser(richTextBox1.Text);
            chrome.Parent = tabControl1.SelectedTab;
            chrome.Dock = DockStyle.Fill;
            chrome.AddressChanged += Chrome_AddressChanged;
            chrome.TitleChanged += Chrome_TitleChanged;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void Chrome_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            //Update url in multiple thread
            this.Invoke(new MethodInvoker(() =>
            {
                richTextBox1.Text = e.Address;
            }));
        }

        private void Chrome_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                richTextBox2.Text = e.Title;
            }));
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (!groupBox1.Visible)
                groupBox1.Visible = true;
            else
                groupBox1.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage();
            tabPage.Text = "New Tab";
            tabControl1.Controls.Add(tabPage);
            tabControl1.SelectTab(tabControl1.TabCount - 1);
            ChromiumWebBrowser chrome = new ChromiumWebBrowser(url);
            chrome.Parent = tabPage;
            chrome.Dock = DockStyle.Fill;
            richTextBox1.Text = url;
            chrome.AddressChanged += Chrome_AddressChanged;
            chrome.TitleChanged += Chrome_TitleChanged;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chrome = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;

            if (chrome != null)
                chrome.Load(richTextBox1.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chrome = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;

            if (chrome != null)
            {
                if (chrome.CanGoBack)
                    chrome.Back();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chrome = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;

            if (chrome != null)
            {
                if (chrome.CanGoForward)

                    chrome.Forward();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chrome = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;

            if (chrome != null)
                chrome.Refresh();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChromiumWebBrowser chrome = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;

                if (chrome != null)
                    chrome.Load(richTextBox1.Text);
            }
        }

        private void richTextBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            richTextBox1.SelectAll();
        }
    }
}
