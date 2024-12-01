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
        private Label label12;
        private Label label11;
        private TabPage travellerBookingsTab;
        private Label label13;
        private TabPage travellerSettingsTab;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label14;

        public AdminTabs()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.travellerFlightsTab = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.travellerBookingsTab = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.travellerSettingsTab = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.travellerFlightsTab.SuspendLayout();
            this.travellerBookingsTab.SuspendLayout();
            this.travellerSettingsTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.travellerFlightsTab.Controls.Add(this.label12);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(367, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 59);
            this.label12.TabIndex = 2;
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
            this.travellerBookingsTab.Controls.Add(this.label13);
            this.travellerBookingsTab.Location = new System.Drawing.Point(23, 4);
            this.travellerBookingsTab.Name = "travellerBookingsTab";
            this.travellerBookingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.travellerBookingsTab.Size = new System.Drawing.Size(755, 720);
            this.travellerBookingsTab.TabIndex = 1;
            this.travellerBookingsTab.Text = "Bookings";
            this.travellerBookingsTab.UseVisualStyleBackColor = true;
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
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 736);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::HappyJourneyAirline.Properties.Resources.log_out;
            this.pictureBox5.Location = new System.Drawing.Point(32, 640);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HappyJourneyAirline.Properties.Resources.Settings_Icon;
            this.pictureBox4.Location = new System.Drawing.Point(32, 520);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(104, 72);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HappyJourneyAirline.Properties.Resources.Flights_Icon;
            this.pictureBox3.Location = new System.Drawing.Point(31, 156);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(104, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HappyJourneyAirline.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(24, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HappyJourneyAirline.Properties.Resources.BookingsIcon;
            this.pictureBox1.Location = new System.Drawing.Point(32, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }

}
