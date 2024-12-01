using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
namespace HappyJourneyAirline.Tabs
{
    public partial class EmployerTabs : UserControl
    {
        private TabControl tabControl1;
        private TabPage travellerFlightsTab;
        private Label label22;
        private Label label12;
        private Label label11;
        private TabPage travellerBookingsTab;
        private Label label13;
        private TabPage travellerSettingsTab;
        private Button button1;
        private Label label14;

        public EmployerTabs()
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.travellerFlightsTab.SuspendLayout();
            this.travellerBookingsTab.SuspendLayout();
            this.travellerSettingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.travellerFlightsTab);
            this.tabControl1.Controls.Add(this.travellerBookingsTab);
            this.tabControl1.Controls.Add(this.travellerSettingsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 728);
            this.tabControl1.TabIndex = 1;
            // 
            // travellerFlightsTab
            // 
            this.travellerFlightsTab.BackColor = System.Drawing.Color.White;
            this.travellerFlightsTab.Controls.Add(this.button1);
            this.travellerFlightsTab.Controls.Add(this.label22);
            this.travellerFlightsTab.Controls.Add(this.label12);
            this.travellerFlightsTab.Controls.Add(this.label11);
            this.travellerFlightsTab.Location = new System.Drawing.Point(23, 4);
            this.travellerFlightsTab.Name = "travellerFlightsTab";
            this.travellerFlightsTab.Padding = new System.Windows.Forms.Padding(3);
            this.travellerFlightsTab.Size = new System.Drawing.Size(891, 720);
            this.travellerFlightsTab.TabIndex = 0;
            this.travellerFlightsTab.Text = "Flights";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Location = new System.Drawing.Point(31, 84);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(333, 19);
            this.label22.TabIndex = 3;
<<<<<<< HEAD
            this.label22.Text = "Book Your Next Flight Easily Through This Page";
=======
            this.label22.Text = "Book Your Next Flight Easily Through This Page 22";
>>>>>>> 403526d830c3de5f5f685757dfba702a99287b59
            this.label22.Click += new System.EventHandler(this.label22_Click);
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
            this.travellerBookingsTab.Size = new System.Drawing.Size(891, 720);
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
            this.travellerSettingsTab.Size = new System.Drawing.Size(891, 720);
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
<<<<<<< HEAD
=======
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            // 
>>>>>>> 403526d830c3de5f5f685757dfba702a99287b59
            // EmployerTabs
            // 
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployerTabs";
            this.Size = new System.Drawing.Size(921, 728);
            this.tabControl1.ResumeLayout(false);
            this.travellerFlightsTab.ResumeLayout(false);
            this.travellerFlightsTab.PerformLayout();
            this.travellerBookingsTab.ResumeLayout(false);
            this.travellerBookingsTab.PerformLayout();
            this.travellerSettingsTab.ResumeLayout(false);
            this.travellerSettingsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }

}
