using System;
using System.Windows.Forms;
using WebKit;



namespace BrowserX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void webKitBrowser1_CloseWindowRequest(object sender, EventArgs e)
        {
            this.tabControl1.Controls.Remove((sender as WebKitBrowser).Parent);
        }

        private void webKitBrowser1_DangerousSiteDetected(object sender, EventArgs e)
        {
            MessageBox.Show("The site " + (sender as WebKitBrowser).Url.ToString() + " is considered dangerous and it is recommended that you leave.");
        }

        private void webKitBrowser1_FormSubmit(object sender, WebKit.FormDelegateFormEventArgs e)
        {
            //e.Listener.continueSubmit();  from 1.5 Beta 2 this is automatically called
        }

        private void webKitBrowser1_NewWindowCreated(object sender, WebKit.NewWindowCreatedEventArgs e)
        {
            this.AddTab(e.WebKitBrowser);
        }

        void wb_DocumentTitleChanged(object sender, EventArgs e)
        {
            ((Form)((WebKitBrowser)sender).Parent).Text = ((WebKitBrowser)sender).DocumentTitle;
        }

        void wb_FaviconAvaiable(object sender, FaviconAvailableEventArgs e)
        {
            ((Form)((WebKitBrowser)sender).Parent).Icon = e.Favicon;
        }

        private void webKitBrowser1_StatusTextChanged(object sender, WebKit.WebKitBrowserStatusChangedEventArgs e)
        {
            if (sender.Equals(this.webKitBrowser1))
            this.statusLabel.Text = e.StatusText; // link hovering status text is only supported in nightly builds
        }

        private void webKitBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.urlBar.AutoCompleteCustomSource.Add(e.Url.ToString());
            if (sender.Equals(this.webKitBrowser1))
                this.urlBar.Text = e.Url.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.webKitBrowser1.Navigate(this.urlBar.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.webKitBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.webKitBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.webKitBrowser1.Reload();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.webKitBrowser1.Stop();
        }

        private void webKitBrowser1_ProgressChanged(object sender, WebKit.ProgressChangesEventArgs e)
        {
            this.toolStripProgressBar1.Value = e.Percent;
        }

        private void webKitBrowser1_DocumentTitleChanged(object sender, EventArgs e)
        {
            string ft;
            string dt = (sender as WebKitBrowser).DocumentTitle;
            if (dt.Length > 30)
                ft = dt.Substring(0, 30) + "...";
            else
                ft = dt;
            (sender as WebKitBrowser).Parent.Text = ft;
        }

        private void webKitBrowser1_FaviconAvaiable(object sender, WebKit.FaviconAvailableEventArgs e)
        {
            if (e.Favicon != null)
            {
                this.fav.Visible = true;
                this.fav.Image = e.Favicon.ToBitmap();
            }
            else
                this.fav.Visible = false;
        }

        private void webKitBrowser1_ShowJavaScriptPromptPanel(object sender, WebKit.ShowJavaScriptPromptPanelEventArgs e)
        {
            e.ReturnValue = Microsoft.VisualBasic.Interaction.InputBox(e.Message, "", e.DefaultValue);
        }

        private void webKitBrowser1_ShowJavaScriptAlertPanel(object sender, WebKit.ShowJavaScriptAlertPanelEventArgs e)
        {
            MessageBox.Show(e.Message);
        }

        private void webKitBrowser1_ShowJavaScriptConfirmPanel(object sender, WebKit.ShowJavaScriptConfirmPanelEventArgs e)
        {
            bool val = (MessageBox.Show(e.Message,"OpenWebKitSharp Example",MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK);
            e.ReturnValue = val;
        }

        private void openPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opn = new OpenFileDialog())
            {
                opn.Filter = "HTML Files (*.html; *.htm)|*.htm; *.htm";
                if (opn.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.webKitBrowser1.OpenDocument(opn.FileName);
                }
            }
        }

        private void savePageAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webKitBrowser1.ShowSaveAsDialog();
        }

        private void showPageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webKitBrowser1.ShowPageSetupDialog();
        }

        private void showPrintPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webKitBrowser1.ShowPrintPreviewDialog();
        }

        private void showPrintDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webKitBrowser1.ShowPrintDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will test the downloading of GT Web Browser 3 installer.");
            this.webKitBrowser1.Navigate("http://gtwebbrowser.webs.com//Downloads/GT%20Web%20Browser%203%20Setup.msi");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.webKitBrowser1 != null)
            {
                this.webKitBrowser1.AllowCookies = this.checkBox1.Checked;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.webKitBrowser1 != null)
            {
                this.webKitBrowser1.UseJavaScript = this.checkBox2.Checked;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.webKitBrowser1 != null)
            {
                this.webKitBrowser1.Preferences.AllowPlugins = this.checkBox3.Checked;
            }
        }


        private void toolStripMenuItem2_CheckStateChanged(object sender, EventArgs e)
        {
            this.webKitBrowser1.PrivateBrowsing = this.toolStripMenuItem2.Checked;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           this.AddTab("http://code.google.com/p/open-webkit-sharp/");
        }

        void ResourceIntercepter_ResourceFailedLoading(object sender, WebKitResourceErrorEventArgs e)
        {
            this.richTextBox1.Text = this.richTextBox1.Text + e.Resource.Url + " with the type " + e.Resource.MimeType + " failed to load because of this error: " + e.ErrorDescription + "\r\n";
        }

        void ResourceIntercepter_ResourcesSendRequest(object sender, WebKitResourceRequestEventArgs e)
        {
            // here you can handle Resources' Requests

            //Examples (Uncomment so that they take effect):

            //if (e.ResourceUrl.EndsWith(".js")) // Block all scripts
            //    e.SendRequest = false;

            //if (e.ResourceUrl.EndsWith(".css")) // Block all css
            //    e.SendRequest = false;

            //if (e.ResourceUrl.EndsWith(".swf")) // Block flash
            //    e.SendRequest = false;

            //if (e.ResourceUrl.EndsWith(".jpg")) // Block all jpg images
            //    e.SendRequest = false;
        }

        void ResourceIntercepter_ResourceStartedLoadingEvent(object sender, WebKitResourcesEventArgs e)
        {
            this.richTextBox1.Text = this.richTextBox1.Text + e.Resource.Url + " with the type " + e.Resource.MimeType + " has started loading." + "\r\n";
        }

        void ResourceIntercepter_ResourceFinishedLoadingEvent(object sender, WebKitResourcesEventArgs e)
        {
            this.richTextBox1.Text = this.richTextBox1.Text + e.Resource.Url + " has finished loading." + "\r\n";
        }

        void ResourceIntercepter_ResourceProgressChangedEvent(object sender, WebKitLoadingResourceEventArgs e)
        {
            if (e.Received > -1)
                this.richTextBox1.Text = this.richTextBox1.Text + e.Received + " bytes have been received" + "\r\n";
            else
                this.richTextBox1.Text = this.richTextBox1.Text + " the number of the bytes that have been received is not available" + "\r\n";
        }

        

        void CustomContextMenuManager_ShowContextMenu(object sender, ShowContextMenuEventArgs e)
        {
            if (!this.webKitBrowser1.UseDefaultContextMenu)
            {
                ContextMenu tst = new ContextMenu();
                MenuItem mn = new MenuItem("Test1");
                tst.MenuItems.Add(mn);
                MenuItem mn2 = new MenuItem("Test2");
                tst.MenuItems.Add(mn2);
                MenuItem mn3 = new MenuItem("-");
                tst.MenuItems.Add(mn3);
                MenuItem mn4 = new MenuItem("Test3");
                tst.MenuItems.Add(mn4);
                tst.Show(this.webKitBrowser1, e.Location);
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.panel2.Visible = false;
            this.webKitBrowser1.UnmarkTextMatches();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            uint totalmatches; // this is how many matches of the find method are found
            this.webKitBrowser1.Find(this.textBox1.Text, out totalmatches);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (this.webKitBrowser1 != null)
               this.webKitBrowser1.SetPageZoom((float)this.numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (this.webKitBrowser1 != null)
               this.webKitBrowser1.SetTextZoom((float)this.numericUpDown2.Value);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.panel3.Visible = false;
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel3.Visible = true;
        }


        private void webKitBrowser1_ShowJavaScriptPromptBeforeUnload(object sender, ShowJavaScriptPromptBeforeUnloadEventArgs e)
        {
            if (MessageBox.Show(e.Message, "OpenWebKitSharp Example", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
            {
                e.ReturnValue = true;
            }
            else
            {
                e.ReturnValue = false;
            }
        }

        private void applyCSSFromLocalFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opn = new OpenFileDialog())
            {
                opn.Filter = "CSS Files (*.css)|*.css";
                if (opn.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.webKitBrowser1.CSSManager.SetPageStyleSheetFromLocalFile(opn.FileName);
                }
            }
        }

        private void setDefaultCSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webKitBrowser1.CSSManager.SetPageDefaultStyleSheet();
        }

        private void webKitBrowser1_CanGoBackChanged(object sender, CanGoBackChangedEventArgs e)
        {
            if (sender.Equals(this.webKitBrowser1))
            this.button1.Enabled = e.CanGoBack;
        }

        private void webKitBrowser1_CanGoForwardChanged(object sender, CanGoForwardChangedEventArgs e)
        {
            if (sender.Equals(this.webKitBrowser1))
            this.button2.Enabled = e.CanGoForward;
        }
        private void customMenuExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customMenuExampleToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                this.webKitBrowser1.UseDefaultContextMenu = !this.customMenuExampleToolStripMenuItem.Checked;
            }
            catch { }
        }

        private void webKitBrowser1_PopupCreated(object sender, NewWindowCreatedEventArgs e)
        {
            if (this.blockPopupsToolStripMenuItem.Checked)
                MessageBox.Show("A popup has been blocked");
            else
            {
                Form f = new Form();
                f.Show();
                WebKitBrowser wb = e.WebKitBrowser;
                wb.AllowDownloads = true;
                wb.Visible = true;
                wb.Name = "browser";
                wb.Dock = DockStyle.Fill;
                wb.DocumentTitleChanged += new EventHandler(this.wb_DocumentTitleChanged);
                wb.FaviconAvailable += new FaviconAvailable(this.wb_FaviconAvaiable);
                f.Controls.Add(wb);
            }
        }

        private void urlBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.webKitBrowser1.Navigate(this.urlBar.Text);
        }

        private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void test1ToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            this.richTextBox1.Visible = this.test1ToolStripMenuItem.Checked;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opn = new OpenFileDialog())
            {
                opn.Filter = "INI Files (*.ini)|*.ini";
                opn.InitialDirectory = Application.StartupPath + @"\LanguageLoader.resources";
                if (opn.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    WebKit.LanguageLoader.SetLanguageFromINIFile(opn.FileName);
                }
            }
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            this.webKitBrowser1.Navigate(e.LinkText);
        }

        public WebKitBrowser webKitBrowser1
        {
            get { return this.tabControl1.SelectedTab.Controls[0] as WebKitBrowser; }
        }

        private void addTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddTab("http://www.gt-web-software.webs.com/");
        }

        void AddEvents(WebKitBrowser browser)
        {
            browser.Navigating += new WebKitBrowserNavigatingEventHandler(this.webKitBrowser1_Navigating);
            browser.DocumentCompleted +=new WebBrowserDocumentCompletedEventHandler(this.webKitBrowser1_DocumentCompleted);
            browser.CanGoBackChanged +=new CanGoBackChanged(this.webKitBrowser1_CanGoBackChanged);
            browser.GeolocationPositionRequest += new GeolocationRequest(this.browser_GeolocationPositionRequest);
            browser.CanGoForwardChanged +=new CanGoForwardChanged(this.webKitBrowser1_CanGoForwardChanged);
            browser.CloseWindowRequest +=new EventHandler(this.webKitBrowser1_CloseWindowRequest);
            browser.DangerousSiteDetected +=new EventHandler(this.webKitBrowser1_DangerousSiteDetected);
            browser.DocumentTitleChanged +=new EventHandler(this.webKitBrowser1_DocumentTitleChanged);
            browser.FaviconAvailable +=new FaviconAvailable(this.webKitBrowser1_FaviconAvaiable);
            browser.HeadersAvailable += new HeadersAvailableEventHandler(this.browser_HeadersAvailable);
            browser.FormSubmit +=new WillSubmitForm(this.webKitBrowser1_FormSubmit);
            browser.NewWindowCreated +=new NewWindowCreatedEventHandler(this.webKitBrowser1_NewWindowCreated);
            browser.PopupCreated +=new NewWindowCreatedEventHandler(this.webKitBrowser1_PopupCreated);
            browser.ProgressChanged +=new WebKit.ProgressChangedEventHandler(this.webKitBrowser1_ProgressChanged);
            browser.ShowJavaScriptAlertPanel +=new ShowJavaScriptAlertPanelEventHandler(this.webKitBrowser1_ShowJavaScriptAlertPanel);
            browser.ShowJavaScriptConfirmPanel +=new ShowJavaScriptConfirmPanelEventHandler(this.webKitBrowser1_ShowJavaScriptConfirmPanel);
            browser.ShowJavaScriptPromptBeforeUnload +=new ShowJavaScriptPromptBeforeUnloadEventHandler(this.webKitBrowser1_ShowJavaScriptPromptBeforeUnload);
            browser.ShowJavaScriptPromptPanel +=new ShowJavaScriptPromptPanelEventHandler(this.webKitBrowser1_ShowJavaScriptPromptPanel);
            browser.StatusTextChanged +=new StatusTextChanged(this.webKitBrowser1_StatusTextChanged);
            browser.CustomContextMenuManager.ShowContextMenu += new ShowContextMenu(this.CustomContextMenuManager_ShowContextMenu);
            browser.ResourceIntercepter.ResourceSizeAvailableEvent += new ResourceSizeAvailable(this.ResourceIntercepter_ResourceProgressChangedEvent);
            browser.ResourceIntercepter.ResourceFinishedLoadingEvent += new ResourceFinishedLoadingHandler(this.ResourceIntercepter_ResourceFinishedLoadingEvent);
            browser.ResourceIntercepter.ResourceStartedLoadingEvent += new ResourceStartedLoadingHandler(this.ResourceIntercepter_ResourceStartedLoadingEvent);
            browser.ResourceIntercepter.ResourcesSendRequest += new ResourceSendRequestEventHandler(this.ResourceIntercepter_ResourcesSendRequest);
            browser.ResourceIntercepter.ResourceFailedLoading += new ResourceFailedHandler(this.ResourceIntercepter_ResourceFailedLoading);
        
        }

        void browser_GeolocationPositionRequest(object sender, GeolocationRequestEventArgs e)
        {
            e.Allow = true;
        }

        void browser_HeadersAvailable(object sender, HeadersAvailableEventArgs e)
        {
            // here you can interfere with headers

            // uncomment the following to see how a message box will show
            // all headers with their fields and values
            
            //string tomes = "";
            //foreach (Header h in e.Headers)
            //{
            //    tomes = tomes + h.Field + ":" + h.Value + "\r\n";
            //}
            //MessageBox.Show(tomes);
        }


        void webKitBrowser1_Navigating(object sender, WebKitBrowserNavigatingEventArgs e)
        {
            // here you can interfere with the WebKitBrowser object before it attempts to load a web page
            // You can cancel the navigation progress and get the Url and TargetFrameName
        }

        void AddTab(string url)
        {
            WebKitBrowser browser = new WebKitBrowser();
            TabPage tab = new TabPage();
            tab.Controls.Add(browser);
            browser.Name = "WebKitBrowser";
            browser.Dock = DockStyle.Fill;
            this.tabControl1.Controls.Add(tab);
            this.tabControl1.SelectedTab = tab;
            this.AddEvents(browser);
            browser.Navigate(url);
        }
        void AddTab(WebKitBrowser browser)
        {
            TabPage tab = new TabPage();
            tab.Controls.Add(browser);
            browser.Name = "WebKitBrowser";
            browser.Dock = DockStyle.Fill;
            this.tabControl1.Controls.Add(tab);
            this.tabControl1.SelectedTab = tab;
            this.AddEvents(browser);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            this.statusLabel.Text = this.webKitBrowser1.StatusText;
            this.toolStripProgressBar1.Value = (int)this.webKitBrowser1.WebView.estimatedProgress() * 100;
            this.button1.Enabled = this.webKitBrowser1.CanGoBack;
            this.button2.Enabled = this.webKitBrowser1.CanGoForward;
            if (this.webKitBrowser1.Url != null)
                this.urlBar.Text = this.webKitBrowser1.Url.ToString();
            else
                this.urlBar.Text = "about:blank";
        }

        private void removeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Controls.Remove(this.tabControl1.SelectedTab);
		}
    }
}
