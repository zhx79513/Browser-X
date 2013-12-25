using System;
using System.Reflection;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using Microsoft.VisualBasic;
using WebKit;



namespace BrowserX
{
	public partial class MetroMainForm : MetroForm
	{
		private readonly ContextMenuStrip customContextMenu = new ContextMenuStrip();


		#region Constructor
		public MetroMainForm()
		{
			this.InitializeComponent();

			this.AddControlButton();
			this.AddSkinOption();

			ToolStripMenuItem item = new ToolStripMenuItem("Test1") {Text = "Test 1"};
			this.customContextMenu.Items.Add(item);
			item = new ToolStripMenuItem("Test2") {Text = "Test 2"};
			this.customContextMenu.Items.Add(item);
			item = new ToolStripMenuItem("-");
			this.customContextMenu.Items.Add(item);
			item = new ToolStripMenuItem("Test3") {Text = "Test 3"};
			this.customContextMenu.Items.Add(item);
		}

		private void AddControlButton()
		{
			ButtonItem bi = new ButtonItem {Text = "гл"};
			bi.Click += btnAddTab_Click;
			this.tcContent.ControlBox.SubItems.Add(bi);
		}

		private void AddSkinOption()
		{
			var fields = typeof(eStyle).GetFields(BindingFlags.Static | BindingFlags.Public);

			foreach (var f in fields)
			{
				ToolStripMenuItem menuItem = new ToolStripMenuItem {Text = f.Name};
				menuItem.Click += itemSkinMenu_Click;
				this.skinsToolStripMenuItem.DropDownItems.Add(menuItem);
			}
		}

		private void itemSkinMenu_Click(object sender, EventArgs e)
		{
			var source = sender as ToolStripMenuItem;
			if (source == null)
				return;

			var fields = typeof(eStyle).GetFields(BindingFlags.Static | BindingFlags.Public);
			var style = (eStyle)Array.Find(fields, (f) => f.Name.Equals(source.Text)).GetValue(null);
			this.styleManager.ManagerStyle = style;
			this.Refresh();
		}
		#endregion


		#region Properties
		private WebKitBrowser webKitBrowser
		{
			get
			{
				if (this.tcContent.SelectedTab.AttachedControl.Controls.Count == 0)
					return null;
				return this.tcContent.SelectedTab.AttachedControl.Controls[0] as WebKitBrowser;
			}
		}
		#endregion


		#region WebKitEvents
		private void AddEvents(WebKitBrowser browser)
		{
			browser.Navigating += this.WebKitBrowser_Navigating;
			browser.DocumentCompleted += this.WebKitBrowser_DocumentCompleted;
			browser.CanGoBackChanged += this.WebKitBrowser_CanGoBackChanged;
			browser.GeolocationPositionRequest += this.WebKitBrowser_GeolocationPositionRequest;
			browser.CanGoForwardChanged += this.WebKitBrowser_CanGoForwardChanged;
			browser.CloseWindowRequest += this.WebKitBrowser_CloseWindowRequest;
			browser.DangerousSiteDetected += this.WebKitBrowser_DangerousSiteDetected;
			browser.DocumentTitleChanged += this.WebKitBrowser_DocumentTitleChanged;
			browser.FaviconAvailable += this.WebKitBrowser_FaviconAvaiable;
			browser.HeadersAvailable += this.WebKitBrowser_HeadersAvailable;
			//browser.FormSubmit += new WillSubmitForm(this.WebKitBrowser_FormSubmit);
			browser.NewWindowCreated += this.WebKitBrowser_NewWindowCreated;
			browser.PopupCreated += this.WebKitBrowser_PopupCreated;
			browser.ProgressChanged += this.WebKitBrowser_ProgressChanged;
			browser.ShowJavaScriptAlertPanel +=
				this.WebKitBrowser_ShowJavaScriptAlertPanel;
			browser.ShowJavaScriptConfirmPanel +=
				this.WebKitBrowser_ShowJavaScriptConfirmPanel;
			browser.ShowJavaScriptPromptBeforeUnload +=
				this.WebKitBrowser_ShowJavaScriptPromptBeforeUnload;
			browser.ShowJavaScriptPromptPanel +=
				this.WebKitBrowser_ShowJavaScriptPromptPanel;
			browser.StatusTextChanged += this.WebKitBrowser_StatusTextChanged;
			browser.CustomContextMenuManager.ShowContextMenu += this.CustomContextMenuManager_ShowContextMenu;
			browser.ResourceIntercepter.ResourceSizeAvailableEvent +=
				this.ResourceIntercepter_ResourceProgressChangedEvent;
			browser.ResourceIntercepter.ResourceFinishedLoadingEvent +=
				this.ResourceIntercepter_ResourceFinishedLoadingEvent;
			browser.ResourceIntercepter.ResourceStartedLoadingEvent +=
				this.ResourceIntercepter_ResourceStartedLoadingEvent;
			browser.ResourceIntercepter.ResourcesSendRequest +=
				this.ResourceIntercepter_ResourcesSendRequest;
			browser.ResourceIntercepter.ResourceFailedLoading +=
				this.ResourceIntercepter_ResourceFailedLoading;
		}


		private void WebKitBrowser_Navigating(object sender, WebKitBrowserNavigatingEventArgs e)
		{
			// here you can interfere with the WebKitBrowser object before it attempts to load a web page
			// You can cancel the navigation progress and get the Url and TargetFrameName
		}

		private void WebKitBrowser_HeadersAvailable(object sender, HeadersAvailableEventArgs e)
		{
			// here you can interfere with headers

			// uncomment the following to see how a message box will show
			// all headers with their fields and values

			//string tomes = e.Headers.Cast<Header>().Aggregate("", (current, h) => current + h.Field + ":" + h.Value + "\r\n");
			//MessageBox.Show(tomes);
		}

		private void WebKitBrowser_GeolocationPositionRequest(object sender, GeolocationRequestEventArgs e)
		{
			e.Allow = true;
		}

		private void WebKitBrowser_PopupCreated(object sender, NewWindowCreatedEventArgs e)
		{
			if (this.blockPopupsToolStripMenuItem.Checked)
				MessageBoxEx.Show("A popup has been blocked");
			else
			{
				Form f = new Form();
				f.Show();
				WebKitBrowser wb = e.WebKitBrowser;
				wb.AllowDownloads = true;
				wb.Visible = true;
				wb.Name = "browser";
				wb.Dock = DockStyle.Fill;
				wb.DocumentTitleChanged += this.wb_DocumentTitleChanged;
				wb.FaviconAvailable += this.wb_FaviconAvailable;
				f.Controls.Add(wb);
			}
		}

		private void WebKitBrowser_CanGoForwardChanged(object sender, CanGoForwardChangedEventArgs e)
		{
			if (sender.Equals(this.webKitBrowser))
				this.btnForward.Enabled = e.CanGoForward;
		}

		private void WebKitBrowser_CanGoBackChanged(object sender, CanGoBackChangedEventArgs e)
		{
			if (sender.Equals(this.webKitBrowser))
				this.btnBackward.Enabled = e.CanGoBack;
		}

		private void WebKitBrowser_ShowJavaScriptPromptBeforeUnload(object sender, ShowJavaScriptPromptBeforeUnloadEventArgs e)
		{
			e.ReturnValue = MessageBox.Show(e.Message, "BrowserX Example", MessageBoxButtons.YesNoCancel) == DialogResult.Yes;
		}

		private void ResourceIntercepter_ResourceProgressChangedEvent(object sender, WebKitLoadingResourceEventArgs e)
		{
			if (e.Received > -1)
				this.rtbResourceIntercepter.Text = this.rtbResourceIntercepter.Text + e.Received + " bytes have been received\r\n";
			else
			{
				this.rtbResourceIntercepter.Text = this.rtbResourceIntercepter.Text
				                                   + " the number of the bytes that have been received is not available\r\n";
			}
		}

		private void ResourceIntercepter_ResourceFinishedLoadingEvent(object sender, WebKitResourcesEventArgs e)
		{
			this.rtbResourceIntercepter.Text = this.rtbResourceIntercepter.Text + e.Resource.Url + " has finished loading."
			                                   + "\r\n";
		}

		private void ResourceIntercepter_ResourceStartedLoadingEvent(object sender, WebKitResourcesEventArgs e)
		{
			this.rtbResourceIntercepter.Text = this.rtbResourceIntercepter.Text + e.Resource.Url + " with the type "
			                                   + e.Resource.MimeType + " has started loading." + "\r\n";
		}

		private void ResourceIntercepter_ResourcesSendRequest(object sender, WebKitResourceRequestEventArgs e)
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

		private void ResourceIntercepter_ResourceFailedLoading(object sender, WebKitResourceErrorEventArgs e)
		{
			this.rtbResourceIntercepter.Text = this.rtbResourceIntercepter.Text + e.Resource.Url + " with the type "
			                                   + e.Resource.MimeType + " failed to load because of this error: "
			                                   + e.ErrorDescription + "\r\n";
		}

		private void WebKitBrowser_ShowJavaScriptConfirmPanel(object sender, ShowJavaScriptConfirmPanelEventArgs e)
		{
			bool val = (MessageBox.Show(e.Message, "BrowserX", MessageBoxButtons.OKCancel)) == DialogResult.OK;
			e.ReturnValue = val;
		}

		private void WebKitBrowser_ShowJavaScriptAlertPanel(object sender, ShowJavaScriptAlertPanelEventArgs e)
		{
			MessageBox.Show(e.Message);
		}

		private void WebKitBrowser_ShowJavaScriptPromptPanel(object sender, ShowJavaScriptPromptPanelEventArgs e)
		{
			e.ReturnValue = Interaction.InputBox(e.Message, "", e.DefaultValue);
		}

		private void WebKitBrowser_FaviconAvaiable(object sender, FaviconAvailableEventArgs e)
		{
			if (e.Favicon != null)
			{
				this.toolStripDropDownButtonOptionMenu.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
				this.toolStripDropDownButtonOptionMenu.Image = e.Favicon.ToBitmap();
			}
			else
				this.toolStripDropDownButtonOptionMenu.DisplayStyle = ToolStripItemDisplayStyle.Text;
		}

		private void WebKitBrowser_DocumentTitleChanged(object sender, EventArgs e)
		{
			WebKitBrowser webKitBrowser = sender as WebKitBrowser;
			if (webKitBrowser != null)
			{
				string dt = webKitBrowser.DocumentTitle;

				string ft = dt.Length > 30 ? dt.Substring(0, 30) + "..." : dt;
				SuperTabControlPanel panel = webKitBrowser.Parent as SuperTabControlPanel;
				if (panel != null)
					panel.TabItem.Text = ft;
			}
		}

		private void WebKitBrowser_ProgressChanged(object sender, ProgressChangesEventArgs e)
		{
			this.toolStripProgressBar1.Value = e.Percent;
		}

		private void WebKitBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			this.tbUrl.AutoCompleteCustomSource.Add(e.Url.ToString());
			if (sender.Equals(this.webKitBrowser))
				this.tbUrl.Text = e.Url.ToString();
		}

		private void WebKitBrowser_StatusTextChanged(object sender, WebKitBrowserStatusChangedEventArgs e)
		{
			if (sender.Equals(this.webKitBrowser))
				this.tsslStatusLabel.Text = e.StatusText; // link hovering status text is only supported in nightly builds
		}


		private void WebKitBrowser_NewWindowCreated(object sender, NewWindowCreatedEventArgs e)
		{
			this.AddTab(e.WebKitBrowser);
		}

		private void WebKitBrowser_CloseWindowRequest(object sender, EventArgs e)
		{
			WebKitBrowser webKitBrowser = sender as WebKitBrowser;
			if (webKitBrowser != null)
				this.tcContent.Controls.Remove(webKitBrowser.Parent);
		}

		private void WebKitBrowser_DangerousSiteDetected(object sender, EventArgs e)
		{
			WebKitBrowser webKitBrowser = sender as WebKitBrowser;
			if (webKitBrowser != null)
				MessageBox.Show("The site " + webKitBrowser.Url + " is considered dangerous and it is recommended that you leave.");
		}


		private void CustomContextMenuManager_ShowContextMenu(object sender, ShowContextMenuEventArgs e)
		{
			if (!this.webKitBrowser.UseDefaultContextMenu)
				this.customContextMenu.Show(this.webKitBrowser, e.Location, ToolStripDropDownDirection.Default);
		}

		private void wb_FaviconAvailable(object sender, FaviconAvailableEventArgs e)
		{
			((Form)((WebKitBrowser)sender).Parent).Icon = e.Favicon;
		}

		private void wb_DocumentTitleChanged(object sender, EventArgs e)
		{
			((WebKitBrowser)sender).Parent.Text = ((WebKitBrowser)sender).DocumentTitle;
		}
		#endregion


		#region FormEvents
		private void btnAddTab_Click(object sender, EventArgs e)
		{
			this.AddTab("about:blank");
		}
		private void btnGo_Click(object sender, EventArgs e)
		{
			this.webKitBrowser.Navigate(this.tbUrl.Text);
		}

		private void btnBackward_Click(object sender, EventArgs e)
		{
			this.webKitBrowser.GoBack();
		}

		private void btnForward_Click(object sender, EventArgs e)
		{
			this.webKitBrowser.GoForward();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			this.webKitBrowser.Reload();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			this.webKitBrowser.Stop();
		}


		private void blockPopupsToolStripMenuItem1_Click(object sender, EventArgs e) {}

		private void showPageSetupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.webKitBrowser.ShowPageSetupDialog();
		}

		private void showPrintPreviewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.webKitBrowser.ShowPrintPreviewDialog();
		}

		private void showPrintDialogToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.webKitBrowser.ShowPrintDialog();
		}

		private void testDownloadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This will test the downloading of GT Web Browser 3 installer.");
			this.webKitBrowser.Navigate("http://gtwebbrowser.webs.com//Downloads/GT%20Web%20Browser%203%20Setup.msi");
		}

		private void cbAllowCookies_CheckedChanged(object sender, EventArgs e)
		{
			if (this.webKitBrowser != null)
				this.webKitBrowser.AllowCookies = this.cbAllowCookies.Checked;
		}

		private void cbAllowJavaScript_CheckedChanged(object sender, EventArgs e)
		{
			if (this.webKitBrowser != null)
				this.webKitBrowser.UseJavaScript = this.cbAllowJavaScript.Checked;
		}

		private void cbAllowPlugins_CheckedChanged(object sender, EventArgs e)
		{
			if (this.webKitBrowser != null)
				this.webKitBrowser.Preferences.AllowPlugins = this.cbAllowPlugins.Checked;
		}

		private void privateBrowsingToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
		{
			if (this.webKitBrowser != null)
				this.webKitBrowser.PrivateBrowsing = this.privateBrowsingToolStripMenuItem.Checked;
		}

		private void MetroMainForm_Load(object sender, EventArgs e)
		{
			this.AddTab("http://www.baidu.com/");
		}

		private void findToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.pFindPanel.Visible = true;
			this.pFindPanel.Controls[2].Focus();
		}

		private void btnFindClose_Click(object sender, EventArgs e)
		{
			this.pFindPanel.Visible = false;
			this.webKitBrowser.UnmarkTextMatches();
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			uint totalMatches; // TODO: display in somewhere
			this.webKitBrowser.Find(this.tbFindBox.Text, out totalMatches);
		}

		private void btnPrefPanelClose_Click(object sender, EventArgs e)
		{
			this.pPreference.Visible = false;
		}

		private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.pPreference.Visible = true;
		}

		private void numudPageZoom_ValueChanged(object sender, EventArgs e)
		{
			if (this.webKitBrowser != null)
				this.webKitBrowser.SetPageZoom((float)this.numudPageZoom.Value);
		}

		private void numudTextZoom_ValueChanged(object sender, EventArgs e)
		{
			if (this.webKitBrowser != null)
				this.webKitBrowser.SetTextZoom((float)this.numudTextZoom.Value);
		}

		private void btnZoomClose_Click(object sender, EventArgs e)
		{
			this.pZoom.Visible = false;
		}

		private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.pZoom.Visible = true;
		}

		private void applyCSSFromLocalFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog opn = new OpenFileDialog())
			{
				opn.Filter = "CSS Files (*.css)|*.css";
				if (opn.ShowDialog() == DialogResult.OK)
					this.webKitBrowser.CSSManager.SetPageStyleSheetFromLocalFile(opn.FileName);
			}
		}

		private void setDefaultCSSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.webKitBrowser.CSSManager.SetPageDefaultStyleSheet();
		}

		private void customMenuToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
		{
			try
			{
				this.webKitBrowser.UseDefaultContextMenu = !this.customMenuToolStripMenuItem.Checked;
			}
			catch (Exception ex)
			{
				MessageBoxEx.Show(ex.Message);
			}
		}

		private void tbUrl_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				this.webKitBrowser.Navigate(this.tbUrl.Text);
		}

		private void resourceIntercepterToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
		{
			this.rtbResourceIntercepter.Visible = this.resourceIntercepterToolStripMenuItem.Checked;
		}

		private void biRiClear_Click(object sender, EventArgs e)
		{
			this.rtbResourceIntercepter.Text = "";
		}

		private void loadALanguageViaLanguageLoaderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog opn = new OpenFileDialog())
			{
				opn.Filter = "INI Files (*.ini)|*.ini";
				opn.InitialDirectory = Application.StartupPath + @"\LanguageLoader.resources";
				if (opn.ShowDialog() == DialogResult.OK)
					LanguageLoader.SetLanguageFromINIFile(opn.FileName);
			}
		}

		private void rtbResourceIntercepter_LinkClicked(object sender, LinkClickedEventArgs e)
		{
			this.webKitBrowser.Navigate(e.LinkText);
		}

		private void addTabToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.AddTab("about:blank");
		}

		private void tcContent_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
		{
			if (this.webKitBrowser == null)
				return;

			this.tsslStatusLabel.Text = this.webKitBrowser.StatusText;
			this.toolStripProgressBar1.Value = (int)this.webKitBrowser.WebView.estimatedProgress() * 100;
			this.btnBackward.Enabled = this.webKitBrowser.CanGoBack;
			this.btnForward.Enabled = this.webKitBrowser.CanGoForward;

			this.tbUrl.Text = this.webKitBrowser.Url != null ? this.webKitBrowser.Url.ToString() : "about:blank";

			((SuperTabItem)e.NewValue).AttachedControl.Controls[0].Focus();
		}

		private void removeTabToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SuperTabItem tabToRemove = this.tcContent.SelectedTab;
			this.tcContent.Tabs.Remove(tabToRemove);
			this.tcContent.Controls.Remove(tabToRemove.AttachedControl);
			this.tcContent.RecalcLayout();
		}
		private void tcContent_TabItemClose(object sender, SuperTabStripTabItemCloseEventArgs e)
		{
			if (this.tcContent.Tabs.Count == 1)
				this.AddTab("about:blank");
		}
		#endregion


		#region Methods
		private void AddTab(string url)
		{
			WebKitBrowser browser = new WebKitBrowser();
			this.AddTab(browser);
			browser.Navigate(url);
		}

		private void AddTab(WebKitBrowser browser)
		{
			SuperTabItem tabItem = this.tcContent.CreateTab("");
			tabItem.AttachedControl.Controls.Add(browser);
			browser.Name = "WebKitBrowser";
			browser.Dock = DockStyle.Fill;
			this.tcContent.SelectedTab = tabItem;
			this.AddEvents(browser);
		}
		#endregion


		#region ToolStripMenuItemEvents
		private void openPageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog opn = new OpenFileDialog())
			{
				opn.Filter = "HTML Files (*.html, *.htm)|*.html, *.htm";
				if (opn.ShowDialog() == DialogResult.OK)
					this.webKitBrowser.OpenDocument(opn.FileName);
			}
		}

		private void savePageAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.webKitBrowser.ShowSaveAsDialog();
		}
		#endregion
	}
}