namespace BrowserX
{
	partial class MetroMainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetroMainForm));
			this.btnBackward = new DevComponents.DotNetBar.ButtonX();
			this.btnForward = new DevComponents.DotNetBar.ButtonX();
			this.btnRefresh = new DevComponents.DotNetBar.ButtonX();
			this.btnStop = new DevComponents.DotNetBar.ButtonX();
			this.btnGo = new DevComponents.DotNetBar.ButtonX();
			this.tbUrl = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.pContent = new DevComponents.DotNetBar.PanelEx();
			this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
			this.rtbResourceIntercepter = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
			this.btnitemResourceInsContextMenu = new DevComponents.DotNetBar.ButtonItem();
			this.biRiClear = new DevComponents.DotNetBar.ButtonItem();
			this.pZoom = new DevComponents.DotNetBar.PanelEx();
			this.btnZoomClose = new DevComponents.DotNetBar.ButtonX();
			this.numudTextZoom = new System.Windows.Forms.NumericUpDown();
			this.labTextZoom = new DevComponents.DotNetBar.LabelX();
			this.numudPageZoom = new System.Windows.Forms.NumericUpDown();
			this.labPageZoom = new DevComponents.DotNetBar.LabelX();
			this.pFindPanel = new DevComponents.DotNetBar.PanelEx();
			this.btnFind = new DevComponents.DotNetBar.ButtonX();
			this.btnFindClose = new DevComponents.DotNetBar.ButtonX();
			this.tbFindBox = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.pPreference = new DevComponents.DotNetBar.PanelEx();
			this.btnPrefPanelClose = new DevComponents.DotNetBar.ButtonX();
			this.cbAllowPlugins = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.cbAllowJavaScript = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.cbAllowCookies = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.tcContent = new DevComponents.DotNetBar.SuperTabControl();
			this.tcpContent = new DevComponents.DotNetBar.SuperTabControlPanel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tsslStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.addTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.resourceIntercepterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadALanguageViaLanguageLoaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.openPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.savePageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.showPageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showPrintPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showPrintDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.testDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.privateBrowsingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.applyCSSFromLocalFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setDefaultCSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.customMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blockPopupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.switchButtonItem1 = new DevComponents.DotNetBar.SwitchButtonItem();
			this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
			this.pContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
			this.pZoom.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numudTextZoom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numudPageZoom)).BeginInit();
			this.pFindPanel.SuspendLayout();
			this.pPreference.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tcContent)).BeginInit();
			this.tcContent.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnBackward
			// 
			this.btnBackward.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btnBackward.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnBackward.FocusCuesEnabled = false;
			this.btnBackward.Location = new System.Drawing.Point(12, 12);
			this.btnBackward.Name = "btnBackward";
			this.btnBackward.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 10, 2);
			this.btnBackward.Size = new System.Drawing.Size(35, 23);
			this.btnBackward.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnBackward.TabIndex = 0;
			this.btnBackward.Text = "<b>◀</b>";
			this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
			// 
			// btnForward
			// 
			this.btnForward.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btnForward.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnForward.FocusCuesEnabled = false;
			this.btnForward.Location = new System.Drawing.Point(54, 12);
			this.btnForward.Name = "btnForward";
			this.btnForward.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
			this.btnForward.Size = new System.Drawing.Size(35, 23);
			this.btnForward.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnForward.TabIndex = 1;
			this.btnForward.Text = "<b>▶</b>";
			this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btnRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnRefresh.FocusCuesEnabled = false;
			this.btnRefresh.Location = new System.Drawing.Point(96, 12);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
			this.btnRefresh.Size = new System.Drawing.Size(35, 23);
			this.btnRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnRefresh.TabIndex = 2;
			this.btnRefresh.Text = "<b>◎</b>";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnStop
			// 
			this.btnStop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btnStop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnStop.FocusCuesEnabled = false;
			this.btnStop.Location = new System.Drawing.Point(138, 12);
			this.btnStop.Name = "btnStop";
			this.btnStop.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
			this.btnStop.Size = new System.Drawing.Size(35, 23);
			this.btnStop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnStop.TabIndex = 3;
			this.btnStop.Text = "<b>✖</b>";
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnGo
			// 
			this.btnGo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnGo.FocusCuesEnabled = false;
			this.btnGo.Location = new System.Drawing.Point(578, 12);
			this.btnGo.Name = "btnGo";
			this.btnGo.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 2, 10);
			this.btnGo.Size = new System.Drawing.Size(35, 23);
			this.btnGo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnGo.TabIndex = 4;
			this.btnGo.Text = "Go";
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// tbUrl
			// 
			this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbUrl.BackColor = System.Drawing.SystemColors.Control;
			// 
			// 
			// 
			this.tbUrl.Border.Class = "TextBoxBorder";
			this.tbUrl.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.tbUrl.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tbUrl.Location = new System.Drawing.Point(180, 12);
			this.tbUrl.Name = "tbUrl";
			this.tbUrl.Size = new System.Drawing.Size(392, 22);
			this.tbUrl.TabIndex = 5;
			this.tbUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUrl_KeyDown);
			// 
			// pContent
			// 
			this.pContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pContent.CanvasColor = System.Drawing.SystemColors.Control;
			this.pContent.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.pContent.Controls.Add(this.contextMenuBar1);
			this.pContent.Controls.Add(this.pZoom);
			this.pContent.Controls.Add(this.pFindPanel);
			this.pContent.Controls.Add(this.pPreference);
			this.pContent.Controls.Add(this.tcContent);
			this.pContent.Controls.Add(this.rtbResourceIntercepter);
			this.pContent.Controls.Add(this.statusStrip1);
			this.pContent.Location = new System.Drawing.Point(0, 42);
			this.pContent.Name = "pContent";
			this.pContent.Size = new System.Drawing.Size(624, 382);
			this.pContent.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.pContent.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.pContent.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.pContent.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.pContent.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.pContent.Style.GradientAngle = 90;
			this.pContent.TabIndex = 6;
			// 
			// contextMenuBar1
			// 
			this.contextMenuBar1.AntiAlias = true;
			this.contextMenuBar1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnitemResourceInsContextMenu});
			this.contextMenuBar1.Location = new System.Drawing.Point(346, 269);
			this.contextMenuBar1.Name = "contextMenuBar1";
			this.contextMenuBar1.Size = new System.Drawing.Size(75, 25);
			this.contextMenuBar1.Stretch = true;
			this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.contextMenuBar1.TabIndex = 5;
			this.contextMenuBar1.TabStop = false;
			this.contextMenuBar1.Text = "contextMenuBar1";
			// 
			// rtbResourceIntercepter
			// 
			// 
			// 
			// 
			this.rtbResourceIntercepter.BackgroundStyle.Class = "RichTextBoxBorder";
			this.rtbResourceIntercepter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.contextMenuBar1.SetContextMenuEx(this.rtbResourceIntercepter, this.btnitemResourceInsContextMenu);
			this.rtbResourceIntercepter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.rtbResourceIntercepter.Location = new System.Drawing.Point(0, 239);
			this.rtbResourceIntercepter.Name = "rtbResourceIntercepter";
			this.rtbResourceIntercepter.Size = new System.Drawing.Size(624, 121);
			this.rtbResourceIntercepter.TabIndex = 4;
			this.rtbResourceIntercepter.Visible = false;
			this.rtbResourceIntercepter.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbResourceIntercepter_LinkClicked);
			// 
			// btnitemResourceInsContextMenu
			// 
			this.btnitemResourceInsContextMenu.Name = "btnitemResourceInsContextMenu";
			this.btnitemResourceInsContextMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.biRiClear});
			this.btnitemResourceInsContextMenu.Text = "ResourceInspectorContext";
			// 
			// biRiClear
			// 
			this.biRiClear.Name = "biRiClear";
			this.biRiClear.Text = "Clear";
			this.biRiClear.Click += new System.EventHandler(this.biRiClear_Click);
			// 
			// pZoom
			// 
			this.pZoom.CanvasColor = System.Drawing.SystemColors.Control;
			this.pZoom.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.pZoom.Controls.Add(this.btnZoomClose);
			this.pZoom.Controls.Add(this.numudTextZoom);
			this.pZoom.Controls.Add(this.labTextZoom);
			this.pZoom.Controls.Add(this.numudPageZoom);
			this.pZoom.Controls.Add(this.labPageZoom);
			this.pZoom.Location = new System.Drawing.Point(3, 0);
			this.pZoom.Name = "pZoom";
			this.pZoom.Size = new System.Drawing.Size(242, 29);
			this.pZoom.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.pZoom.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.pZoom.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.pZoom.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.pZoom.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.pZoom.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.pZoom.Style.GradientAngle = 90;
			this.pZoom.TabIndex = 0;
			this.pZoom.Visible = false;
			// 
			// btnZoomClose
			// 
			this.btnZoomClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btnZoomClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnZoomClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnZoomClose.Location = new System.Drawing.Point(214, 4);
			this.btnZoomClose.Name = "btnZoomClose";
			this.btnZoomClose.Size = new System.Drawing.Size(25, 23);
			this.btnZoomClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnZoomClose.TabIndex = 4;
			this.btnZoomClose.Text = "<b>✘</b>";
			this.btnZoomClose.Click += new System.EventHandler(this.btnZoomClose_Click);
			// 
			// numudTextZoom
			// 
			this.numudTextZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numudTextZoom.Location = new System.Drawing.Point(180, 4);
			this.numudTextZoom.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numudTextZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numudTextZoom.Name = "numudTextZoom";
			this.numudTextZoom.Size = new System.Drawing.Size(31, 22);
			this.numudTextZoom.TabIndex = 3;
			this.numudTextZoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numudTextZoom.ValueChanged += new System.EventHandler(this.numudTextZoom_ValueChanged);
			// 
			// labTextZoom
			// 
			this.labTextZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.labTextZoom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.labTextZoom.Location = new System.Drawing.Point(114, 4);
			this.labTextZoom.Name = "labTextZoom";
			this.labTextZoom.Size = new System.Drawing.Size(60, 23);
			this.labTextZoom.TabIndex = 2;
			this.labTextZoom.Text = "Text Zoom:";
			// 
			// numudPageZoom
			// 
			this.numudPageZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numudPageZoom.Location = new System.Drawing.Point(75, 4);
			this.numudPageZoom.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numudPageZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numudPageZoom.Name = "numudPageZoom";
			this.numudPageZoom.Size = new System.Drawing.Size(33, 22);
			this.numudPageZoom.TabIndex = 1;
			this.numudPageZoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numudPageZoom.ValueChanged += new System.EventHandler(this.numudPageZoom_ValueChanged);
			// 
			// labPageZoom
			// 
			this.labPageZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			// 
			// 
			// 
			this.labPageZoom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.labPageZoom.Location = new System.Drawing.Point(4, 4);
			this.labPageZoom.Name = "labPageZoom";
			this.labPageZoom.Size = new System.Drawing.Size(65, 23);
			this.labPageZoom.TabIndex = 0;
			this.labPageZoom.Text = "Page Zoom:";
			// 
			// pFindPanel
			// 
			this.pFindPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pFindPanel.CanvasColor = System.Drawing.SystemColors.Control;
			this.pFindPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.pFindPanel.Controls.Add(this.btnFind);
			this.pFindPanel.Controls.Add(this.btnFindClose);
			this.pFindPanel.Controls.Add(this.tbFindBox);
			this.pFindPanel.Location = new System.Drawing.Point(343, 0);
			this.pFindPanel.Name = "pFindPanel";
			this.pFindPanel.Size = new System.Drawing.Size(281, 29);
			this.pFindPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.pFindPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.pFindPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.pFindPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.pFindPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.pFindPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.pFindPanel.Style.GradientAngle = 90;
			this.pFindPanel.TabIndex = 0;
			this.pFindPanel.Visible = false;
			// 
			// btnFind
			// 
			this.btnFind.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFind.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnFind.FocusCuesEnabled = false;
			this.btnFind.Location = new System.Drawing.Point(221, 3);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(25, 23);
			this.btnFind.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnFind.TabIndex = 2;
			this.btnFind.Text = "<b>✔</b>";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// btnFindClose
			// 
			this.btnFindClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btnFindClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFindClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnFindClose.FocusCuesEnabled = false;
			this.btnFindClose.Location = new System.Drawing.Point(252, 2);
			this.btnFindClose.Name = "btnFindClose";
			this.btnFindClose.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 2, 10);
			this.btnFindClose.Size = new System.Drawing.Size(25, 23);
			this.btnFindClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnFindClose.TabIndex = 1;
			this.btnFindClose.Text = "<b>✘</b>";
			this.btnFindClose.Click += new System.EventHandler(this.btnFindClose_Click);
			// 
			// tbFindBox
			// 
			this.tbFindBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbFindBox.BackColor = System.Drawing.SystemColors.Control;
			// 
			// 
			// 
			this.tbFindBox.Border.Class = "TextBoxBorder";
			this.tbFindBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.tbFindBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tbFindBox.Location = new System.Drawing.Point(3, 3);
			this.tbFindBox.Name = "tbFindBox";
			this.tbFindBox.Size = new System.Drawing.Size(212, 22);
			this.tbFindBox.TabIndex = 0;
			// 
			// pPreference
			// 
			this.pPreference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pPreference.CanvasColor = System.Drawing.SystemColors.Control;
			this.pPreference.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.pPreference.Controls.Add(this.btnPrefPanelClose);
			this.pPreference.Controls.Add(this.cbAllowPlugins);
			this.pPreference.Controls.Add(this.cbAllowJavaScript);
			this.pPreference.Controls.Add(this.cbAllowCookies);
			this.pPreference.Location = new System.Drawing.Point(3, 257);
			this.pPreference.Name = "pPreference";
			this.pPreference.Size = new System.Drawing.Size(200, 100);
			this.pPreference.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.pPreference.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.pPreference.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.pPreference.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.pPreference.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.pPreference.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.pPreference.Style.GradientAngle = 90;
			this.pPreference.TabIndex = 0;
			this.pPreference.Visible = false;
			// 
			// btnPrefPanelClose
			// 
			this.btnPrefPanelClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btnPrefPanelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPrefPanelClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btnPrefPanelClose.FocusCuesEnabled = false;
			this.btnPrefPanelClose.Location = new System.Drawing.Point(173, 3);
			this.btnPrefPanelClose.Name = "btnPrefPanelClose";
			this.btnPrefPanelClose.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
			this.btnPrefPanelClose.Size = new System.Drawing.Size(23, 23);
			this.btnPrefPanelClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btnPrefPanelClose.TabIndex = 3;
			this.btnPrefPanelClose.Text = "<b>✘</b>";
			this.btnPrefPanelClose.Click += new System.EventHandler(this.btnPrefPanelClose_Click);
			// 
			// cbAllowPlugins
			// 
			// 
			// 
			// 
			this.cbAllowPlugins.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.cbAllowPlugins.Checked = true;
			this.cbAllowPlugins.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbAllowPlugins.CheckValue = "Y";
			this.cbAllowPlugins.FocusCuesEnabled = false;
			this.cbAllowPlugins.Location = new System.Drawing.Point(6, 73);
			this.cbAllowPlugins.Name = "cbAllowPlugins";
			this.cbAllowPlugins.Size = new System.Drawing.Size(100, 23);
			this.cbAllowPlugins.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbAllowPlugins.TabIndex = 2;
			this.cbAllowPlugins.Text = "Allow Plugins";
			this.cbAllowPlugins.CheckedChanged += new System.EventHandler(this.cbAllowPlugins_CheckedChanged);
			// 
			// cbAllowJavaScript
			// 
			// 
			// 
			// 
			this.cbAllowJavaScript.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.cbAllowJavaScript.Checked = true;
			this.cbAllowJavaScript.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbAllowJavaScript.CheckValue = "Y";
			this.cbAllowJavaScript.FocusCuesEnabled = false;
			this.cbAllowJavaScript.Location = new System.Drawing.Point(6, 43);
			this.cbAllowJavaScript.Name = "cbAllowJavaScript";
			this.cbAllowJavaScript.Size = new System.Drawing.Size(100, 23);
			this.cbAllowJavaScript.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbAllowJavaScript.TabIndex = 1;
			this.cbAllowJavaScript.Text = "Allow JavaScript";
			this.cbAllowJavaScript.CheckedChanged += new System.EventHandler(this.cbAllowJavaScript_CheckedChanged);
			// 
			// cbAllowCookies
			// 
			// 
			// 
			// 
			this.cbAllowCookies.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.cbAllowCookies.Checked = true;
			this.cbAllowCookies.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbAllowCookies.CheckValue = "Y";
			this.cbAllowCookies.FocusCuesEnabled = false;
			this.cbAllowCookies.Location = new System.Drawing.Point(6, 13);
			this.cbAllowCookies.Name = "cbAllowCookies";
			this.cbAllowCookies.Size = new System.Drawing.Size(100, 23);
			this.cbAllowCookies.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbAllowCookies.TabIndex = 0;
			this.cbAllowCookies.Text = "Allow Cookies";
			this.cbAllowCookies.CheckedChanged += new System.EventHandler(this.cbAllowCookies_CheckedChanged);
			// 
			// tcContent
			// 
			this.tcContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
			this.tcContent.CloseButtonOnTabsVisible = true;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcContent.ControlBox.CloseBox.Name = "";
			// 
			// 
			// 
			this.tcContent.ControlBox.MenuBox.Name = "";
			this.tcContent.ControlBox.Name = "";
			this.tcContent.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tcContent.ControlBox.MenuBox,
            this.tcContent.ControlBox.CloseBox});
			this.tcContent.Controls.Add(this.tcpContent);
			this.tcContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcContent.ForeColor = System.Drawing.Color.Black;
			this.tcContent.Location = new System.Drawing.Point(0, 0);
			this.tcContent.Name = "tcContent";
			this.tcContent.ReorderTabsEnabled = true;
			this.tcContent.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
			this.tcContent.SelectedTabIndex = 0;
			this.tcContent.Size = new System.Drawing.Size(624, 239);
			this.tcContent.TabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tcContent.TabIndex = 0;
			this.tcContent.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.OneNote2007;
			this.tcContent.Text = "superTabControl1";
			this.tcContent.SelectedTabChanged += new System.EventHandler<DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs>(this.tcContent_SelectedTabChanged);
			// 
			// tcpContent
			// 
			this.tcpContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tcpContent.Location = new System.Drawing.Point(0, 0);
			this.tcpContent.Name = "tcpContent";
			this.tcpContent.Size = new System.Drawing.Size(618, 211);
			this.tcpContent.TabIndex = 1;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatusLabel,
            this.toolStripProgressBar1,
            this.toolStripDropDownButton1});
			this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.statusStrip1.Location = new System.Drawing.Point(0, 360);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(624, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tsslStatusLabel
			// 
			this.tsslStatusLabel.Name = "tsslStatusLabel";
			this.tsslStatusLabel.Size = new System.Drawing.Size(84, 17);
			this.tsslStatusLabel.Text = "tsslStatusLabel";
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
			this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTabToolStripMenuItem,
            this.removeTabToolStripMenuItem,
            this.toolStripSeparator3,
            this.resourceIntercepterToolStripMenuItem,
            this.loadALanguageViaLanguageLoaderToolStripMenuItem,
            this.toolStripSeparator4,
            this.openPageToolStripMenuItem,
            this.savePageAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.showPageSetupToolStripMenuItem,
            this.showPrintPreviewToolStripMenuItem,
            this.showPrintDialogToolStripMenuItem,
            this.toolStripSeparator5,
            this.testDownloadToolStripMenuItem,
            this.toolStripSeparator6,
            this.privateBrowsingToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.findToolStripMenuItem,
            this.toolStripSeparator2,
            this.applyCSSFromLocalFileToolStripMenuItem,
            this.setDefaultCSSToolStripMenuItem,
            this.toolStripSeparator7,
            this.customMenuToolStripMenuItem,
            this.blockPopupsToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
			this.toolStripDropDownButton1.Text = "Menu";
			// 
			// addTabToolStripMenuItem
			// 
			this.addTabToolStripMenuItem.Name = "addTabToolStripMenuItem";
			this.addTabToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
			this.addTabToolStripMenuItem.Text = "Add Tab";
			this.addTabToolStripMenuItem.Click += new System.EventHandler(this.addTabToolStripMenuItem_Click);
			// 
			// removeTabToolStripMenuItem
			// 
			this.removeTabToolStripMenuItem.Name = "removeTabToolStripMenuItem";
			this.removeTabToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
			this.removeTabToolStripMenuItem.Text = "Remove Tab";
			this.removeTabToolStripMenuItem.Click += new System.EventHandler(this.removeTabToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(267, 6);
			// 
			// resourceIntercepterToolStripMenuItem
			// 
			this.resourceIntercepterToolStripMenuItem.CheckOnClick = true;
			this.resourceIntercepterToolStripMenuItem.Name = "resourceIntercepterToolStripMenuItem";
			this.resourceIntercepterToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
			this.resourceIntercepterToolStripMenuItem.Text = "Resource Intercepter";
			this.resourceIntercepterToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.resourceIntercepterToolStripMenuItem_CheckStateChanged);
			// 
			// loadALanguageViaLanguageLoaderToolStripMenuItem
			// 
			this.loadALanguageViaLanguageLoaderToolStripMenuItem.Name = "loadALanguageViaLanguageLoaderToolStripMenuItem";
			this.loadALanguageViaLanguageLoaderToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
			this.loadALanguageViaLanguageLoaderToolStripMenuItem.Text = "Load a language via LanguageLoader";
			this.loadALanguageViaLanguageLoaderToolStripMenuItem.Click += new System.EventHandler(this.loadALanguageViaLanguageLoaderToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(267, 6);
			// 
			// openPageToolStripMenuItem
			// 
			this.openPageToolStripMenuItem.Name = "openPageToolStripMenuItem";
			this.openPageToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
			this.openPageToolStripMenuItem.Text = "Open Page...";
			this.openPageToolStripMenuItem.Click += new System.EventHandler(this.openPageToolStripMenuItem_Click);
			// 
			// savePageAsToolStripMenuItem
			// 
			this.savePageAsToolStripMenuItem.Name = "savePageAsToolStripMenuItem";
			this.savePageAsToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
			this.savePageAsToolStripMenuItem.Text = "Save Page As...";
			this.savePageAsToolStripMenuItem.Click += new System.EventHandler(this.savePageAsToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
			// 
			// showPageSetupToolStripMenuItem
			// 
			this.showPageSetupToolStripMenuItem.Name = "showPageSetupToolStripMenuItem";
			this.showPageSetupToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
			this.showPageSetupToolStripMenuItem.Text = "Show Page Setup";
			this.showPageSetupToolStripMenuItem.Click += new System.EventHandler(this.showPageSetupToolStripMenuItem_Click);
			// 
			// showPrintPreviewToolStripMenuItem
			// 
			this.showPrintPreviewToolStripMenuItem.Name = "showPrintPreviewToolStripMenuItem";
			this.showPrintPreviewToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
			this.showPrintPreviewToolStripMenuItem.Text = "Show Print Preview";
			this.showPrintPreviewToolStripMenuItem.Click += new System.EventHandler(this.showPrintPreviewToolStripMenuItem_Click);
			// 
			// showPrintDialogToolStripMenuItem
			// 
			this.showPrintDialogToolStripMenuItem.Name = "showPrintDialogToolStripMenuItem";
			this.showPrintDialogToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
			this.showPrintDialogToolStripMenuItem.Text = "Show Print Dialog";
			this.showPrintDialogToolStripMenuItem.Click += new System.EventHandler(this.showPrintDialogToolStripMenuItem_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(267, 6);
			// 
			// testDownloadToolStripMenuItem
			// 
			this.testDownloadToolStripMenuItem.Name = "testDownloadToolStripMenuItem";
			this.testDownloadToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
			this.testDownloadToolStripMenuItem.Text = "Test Download";
			this.testDownloadToolStripMenuItem.Click += new System.EventHandler(this.testDownloadToolStripMenuItem_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(267, 6);
			// 
			// privateBrowsingToolStripMenuItem
			// 
			this.privateBrowsingToolStripMenuItem.CheckOnClick = true;
			this.privateBrowsingToolStripMenuItem.Name = "privateBrowsingToolStripMenuItem";
			this.privateBrowsingToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
			this.privateBrowsingToolStripMenuItem.Text = "Private Browsing";
			this.privateBrowsingToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.privateBrowsingToolStripMenuItem_CheckStateChanged);
			// 
			// zoomToolStripMenuItem
			// 
			this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
			this.zoomToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
			this.zoomToolStripMenuItem.Text = "Zoom";
			this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
			// 
			// preferencesToolStripMenuItem
			// 
			this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
			this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
			this.preferencesToolStripMenuItem.Text = "Preferences";
			this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
			// 
			// findToolStripMenuItem
			// 
			this.findToolStripMenuItem.Name = "findToolStripMenuItem";
			this.findToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
			this.findToolStripMenuItem.Text = "Find";
			this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(267, 6);
			// 
			// applyCSSFromLocalFileToolStripMenuItem
			// 
			this.applyCSSFromLocalFileToolStripMenuItem.Name = "applyCSSFromLocalFileToolStripMenuItem";
			this.applyCSSFromLocalFileToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
			this.applyCSSFromLocalFileToolStripMenuItem.Text = "Apply CSS from Local File";
			this.applyCSSFromLocalFileToolStripMenuItem.Click += new System.EventHandler(this.applyCSSFromLocalFileToolStripMenuItem_Click);
			// 
			// setDefaultCSSToolStripMenuItem
			// 
			this.setDefaultCSSToolStripMenuItem.Name = "setDefaultCSSToolStripMenuItem";
			this.setDefaultCSSToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
			this.setDefaultCSSToolStripMenuItem.Text = "Set Default CSS";
			this.setDefaultCSSToolStripMenuItem.Click += new System.EventHandler(this.setDefaultCSSToolStripMenuItem_Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(267, 6);
			// 
			// customMenuToolStripMenuItem
			// 
			this.customMenuToolStripMenuItem.CheckOnClick = true;
			this.customMenuToolStripMenuItem.Name = "customMenuToolStripMenuItem";
			this.customMenuToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
			this.customMenuToolStripMenuItem.Text = "Custom Menu";
			this.customMenuToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.customMenuToolStripMenuItem_CheckStateChanged);
			// 
			// blockPopupsToolStripMenuItem
			// 
			this.blockPopupsToolStripMenuItem.Checked = true;
			this.blockPopupsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.blockPopupsToolStripMenuItem.Name = "blockPopupsToolStripMenuItem";
			this.blockPopupsToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
			this.blockPopupsToolStripMenuItem.Text = "Block Popups";
			this.blockPopupsToolStripMenuItem.Click += new System.EventHandler(this.blockPopupsToolStripMenuItem1_Click);
			// 
			// switchButtonItem1
			// 
			this.switchButtonItem1.Name = "switchButtonItem1";
			// 
			// styleManager1
			// 
			this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Silver;
			this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
			// 
			// MetroMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(625, 425);
			this.Controls.Add(this.tbUrl);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnForward);
			this.Controls.Add(this.btnBackward);
			this.Controls.Add(this.pContent);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MetroMainForm";
			this.Text = "BrowserX";
			this.Load += new System.EventHandler(this.MetroMainForm_Load);
			this.pContent.ResumeLayout(false);
			this.pContent.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
			this.pZoom.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numudTextZoom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numudPageZoom)).EndInit();
			this.pFindPanel.ResumeLayout(false);
			this.pPreference.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tcContent)).EndInit();
			this.tcContent.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DevComponents.DotNetBar.ButtonX btnBackward;
		private DevComponents.DotNetBar.ButtonX btnForward;
		private DevComponents.DotNetBar.ButtonX btnRefresh;
		private DevComponents.DotNetBar.ButtonX btnStop;
		private DevComponents.DotNetBar.ButtonX btnGo;
		private DevComponents.DotNetBar.Controls.TextBoxX tbUrl;
		private DevComponents.DotNetBar.PanelEx pContent;
		private DevComponents.DotNetBar.SuperTabControl tcContent;
		private DevComponents.DotNetBar.SuperTabControlPanel tcpContent;
		private DevComponents.DotNetBar.SwitchButtonItem switchButtonItem1;
		private DevComponents.DotNetBar.StyleManager styleManager1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tsslStatusLabel;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem openPageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem savePageAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem blockPopupsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem applyCSSFromLocalFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem setDefaultCSSToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem loadALanguageViaLanguageLoaderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showPageSetupToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showPrintPreviewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showPrintDialogToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem testDownloadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem privateBrowsingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addTabToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeTabToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem resourceIntercepterToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private DevComponents.DotNetBar.PanelEx pPreference;
		private DevComponents.DotNetBar.Controls.CheckBoxX cbAllowCookies;
		private DevComponents.DotNetBar.Controls.CheckBoxX cbAllowJavaScript;
		private DevComponents.DotNetBar.Controls.CheckBoxX cbAllowPlugins;
		private DevComponents.DotNetBar.Controls.RichTextBoxEx rtbResourceIntercepter;
		private System.Windows.Forms.ToolStripMenuItem customMenuToolStripMenuItem;
		private DevComponents.DotNetBar.PanelEx pFindPanel;
		private DevComponents.DotNetBar.Controls.TextBoxX tbFindBox;
		private DevComponents.DotNetBar.ButtonX btnFind;
		private DevComponents.DotNetBar.ButtonX btnFindClose;
		private DevComponents.DotNetBar.ButtonX btnPrefPanelClose;
		private DevComponents.DotNetBar.PanelEx pZoom;
		private DevComponents.DotNetBar.LabelX labPageZoom;
		private System.Windows.Forms.NumericUpDown numudPageZoom;
		private DevComponents.DotNetBar.LabelX labTextZoom;
		private System.Windows.Forms.NumericUpDown numudTextZoom;
		private DevComponents.DotNetBar.ButtonX btnZoomClose;
		private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
		private DevComponents.DotNetBar.ButtonItem btnitemResourceInsContextMenu;
		private DevComponents.DotNetBar.ButtonItem biRiClear;
	}
}