namespace RQReporter
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonButton button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.configButton = this.Factory.CreateRibbonButton();
            this.bassButton = this.Factory.CreateRibbonButton();
            button1 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            button1.Label = "Report Phish to SOC";
            button1.Name = "button1";
            button1.ShowImage = true;
            button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "PhishPhinder";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(button1);
            this.group1.Items.Add(this.separator1);
            this.group1.Items.Add(this.configButton);
            this.group1.Items.Add(this.bassButton);
            this.group1.Label = "What should we do?";
            this.group1.Name = "group1";
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // configButton
            // 
            this.configButton.Image = ((System.Drawing.Image)(resources.GetObject("configButton.Image")));
            this.configButton.Label = "Configure Settings";
            this.configButton.Name = "configButton";
            this.configButton.ShowImage = true;
            this.configButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.configButton_Click);
            // 
            // bassButton
            // 
            this.bassButton.Image = ((System.Drawing.Image)(resources.GetObject("bassButton.Image")));
            this.bassButton.Label = "Drop the Bass";
            this.bassButton.Name = "bassButton";
            this.bassButton.ShowImage = true;
            this.bassButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bassButton_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton configButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton bassButton;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
