using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
namespace HappyJourneyAirline.Tabs
{
    public partial class AdminTabs : UserControl
    {
        private TabControl tabControl1;
        private TabPage travellerFlightsTab;
        private Label label22;
        private Label label11;
        private TabPage travellerBookingsTab;
        private Label label13;
        private TabPage travellerSettingsTab;
        private Panel panel1;
        private PictureBox bookingTab;
        private PictureBox logoIcon;
        private PictureBox flightsTab;
        private PictureBox settingTab;
        private PictureBox logOutIcon;
        private Label label1;
        private Label label14;

        public AdminTabs()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTabs));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.travellerFlightsTab = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.travellerBookingsTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.travellerSettingsTab = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutIcon = new System.Windows.Forms.PictureBox();
            this.settingTab = new System.Windows.Forms.PictureBox();
            this.flightsTab = new System.Windows.Forms.PictureBox();
            this.logoIcon = new System.Windows.Forms.PictureBox();
            this.bookingTab = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.travellerFlightsTab.SuspendLayout();
            this.travellerBookingsTab.SuspendLayout();
            this.travellerSettingsTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logOutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTab)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.travellerFlightsTab);
            this.tabControl1.Controls.Add(this.travellerBookingsTab);
            this.tabControl1.Controls.Add(this.travellerSettingsTab);
            this.tabControl1.Location = new System.Drawing.Point(136, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 728);
            this.tabControl1.TabIndex = 1;
            // 
            // travellerFlightsTab
            // 
            this.travellerFlightsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerFlightsTab.Controls.Add(this.label22);
            this.travellerFlightsTab.Controls.Add(this.label11);
            this.travellerFlightsTab.Location = new System.Drawing.Point(23, 4);
            this.travellerFlightsTab.Name = "travellerFlightsTab";
            this.travellerFlightsTab.Padding = new System.Windows.Forms.Padding(3);
            this.travellerFlightsTab.Size = new System.Drawing.Size(755, 720);
            this.travellerFlightsTab.TabIndex = 0;
            this.travellerFlightsTab.Text = "Flights";
            this.travellerFlightsTab.Click += new System.EventHandler(this.travellerFlightsTab_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Location = new System.Drawing.Point(31, 84);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(313, 19);
            this.label22.TabIndex = 3;
            this.label22.Text = "Book Your Next Flight Easily Through This Page";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 59);
            this.label11.TabIndex = 1;
            this.label11.Text = "Flights";
            // 
            // travellerBookingsTab
            // 
            this.travellerBookingsTab.Controls.Add(this.label1);
            this.travellerBookingsTab.Controls.Add(this.label13);
            this.travellerBookingsTab.Location = new System.Drawing.Point(23, 4);
            this.travellerBookingsTab.Name = "travellerBookingsTab";
            this.travellerBookingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.travellerBookingsTab.Size = new System.Drawing.Size(755, 720);
            this.travellerBookingsTab.TabIndex = 1;
            this.travellerBookingsTab.Text = "Bookings";
            this.travellerBookingsTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(24, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "You can here modify bookings easily";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 59);
            this.label13.TabIndex = 2;
            this.label13.Text = "Bookings";
            // 
            // travellerSettingsTab
            // 
            this.travellerSettingsTab.Controls.Add(this.label14);
            this.travellerSettingsTab.Location = new System.Drawing.Point(23, 4);
            this.travellerSettingsTab.Name = "travellerSettingsTab";
            this.travellerSettingsTab.Size = new System.Drawing.Size(755, 720);
            this.travellerSettingsTab.TabIndex = 2;
            this.travellerSettingsTab.Text = "Settings";
            this.travellerSettingsTab.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 59);
            this.label14.TabIndex = 3;
            this.label14.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.logOutIcon);
            this.panel1.Controls.Add(this.settingTab);
            this.panel1.Controls.Add(this.flightsTab);
            this.panel1.Controls.Add(this.logoIcon);
            this.panel1.Controls.Add(this.bookingTab);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 736);
            this.panel1.TabIndex = 4;
            // 
            // logOutIcon
            // 
            this.logOutIcon.Image = ((System.Drawing.Image)(resources.GetObject("logOutIcon.Image")));
            this.logOutIcon.Location = new System.Drawing.Point(32, 640);
            this.logOutIcon.Name = "logOutIcon";
            this.logOutIcon.Size = new System.Drawing.Size(100, 50);
            this.logOutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logOutIcon.TabIndex = 7;
            this.logOutIcon.TabStop = false;
            this.logOutIcon.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // settingTab
            // 
            this.settingTab.Image = ((System.Drawing.Image)(resources.GetObject("settingTab.Image")));
            this.settingTab.Location = new System.Drawing.Point(32, 520);
            this.settingTab.Name = "settingTab";
            this.settingTab.Size = new System.Drawing.Size(104, 72);
            this.settingTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingTab.TabIndex = 6;
            this.settingTab.TabStop = false;
            this.settingTab.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // flightsTab
            // 
            this.flightsTab.Image = ((System.Drawing.Image)(resources.GetObject("flightsTab.Image")));
            this.flightsTab.Location = new System.Drawing.Point(31, 156);
            this.flightsTab.Name = "flightsTab";
            this.flightsTab.Size = new System.Drawing.Size(104, 80);
            this.flightsTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flightsTab.TabIndex = 4;
            this.flightsTab.TabStop = false;
            this.flightsTab.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // logoIcon
            // 
            this.logoIcon.Image = global::HappyJourneyAirline.Properties.Resources.logo;
            this.logoIcon.Location = new System.Drawing.Point(24, 16);
            this.logoIcon.Name = "logoIcon";
            this.logoIcon.Size = new System.Drawing.Size(113, 108);
            this.logoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoIcon.TabIndex = 4;
            this.logoIcon.TabStop = false;
            this.logoIcon.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bookingTab
            // 
            this.bookingTab.Image = ((System.Drawing.Image)(resources.GetObject("bookingTab.Image")));
            this.bookingTab.Location = new System.Drawing.Point(32, 272);
            this.bookingTab.Name = "bookingTab";
            this.bookingTab.Size = new System.Drawing.Size(104, 80);
            this.bookingTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookingTab.TabIndex = 5;
            this.bookingTab.TabStop = false;
            this.bookingTab.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AdminTabs
            // 
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminTabs";
            this.Size = new System.Drawing.Size(921, 728);
            this.tabControl1.ResumeLayout(false);
            this.travellerFlightsTab.ResumeLayout(false);
            this.travellerFlightsTab.PerformLayout();
            this.travellerBookingsTab.ResumeLayout(false);
            this.travellerBookingsTab.PerformLayout();
            this.travellerSettingsTab.ResumeLayout(false);
            this.travellerSettingsTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logOutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTab)).EndInit();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void travellerFlightsTab_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

}
