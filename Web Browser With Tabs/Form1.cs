using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser_With_Tabs
{
    public partial class Form1 : Form
    {
        int n = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void select_url_Click(object sender, EventArgs e)
        {
            
            TabPage tabPage1 = new TabPage("tabPage1");
            if (tabControl1.TabPages.Contains("tabPage1"))
            then     
                    WebBrowser webBrowser1 = new WebBrowser()
                {
                    Parent = tabPage1,
                    Dock = DockStyle.Fill,
                    ScriptErrorsSuppressed = true,
                };
                webBrowser1.Navigate("https://agrimetsoft.com");
            };
        }
        private void add_tab_Click(object sender, EventArgs e)
        {
            n++;
            TabPage addedTabPage = new TabPage("tab title" + n.ToString());
            tabControl1.TabPages.Add(addedTabPage);
            WebBrowser addedWebBrowser = new WebBrowser()
            {
                Parent = addedTabPage,
                Dock = DockStyle.Fill,
                ScriptErrorsSuppressed = true,
            };
            addedWebBrowser.Name = "wb" + n.ToString();
            addedWebBrowser.Navigate("www.google.com");
            tabControl1.SelectedIndex = n - 1;
        }
    }
}



