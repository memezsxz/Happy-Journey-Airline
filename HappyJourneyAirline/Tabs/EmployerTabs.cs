using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using HappyJourneyAirline.Lib;
using System.Data.SqlClient;
using HappyJourneyAirline.Models;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
namespace HappyJourneyAirline.Tabs
{
    public partial class EmployerTabs : UserControl
    {
        private Panel panel1;
        private PictureBox logOutIcon;
        private PictureBox settingTab;
        private PictureBox flightsTab;
        private PictureBox logoIcon;
        private PictureBox notificationTab;
        private TabPage flightDetails;
        private Button fdPayAllBtn;
        private Button fdAddTravelerBtn;
        private Button fdCancelBtn;
        private Button fdBookAllBtn;
        private TextBox fdArrTxt;
        private TextBox fdDepTxt;
        private TextBox fdToTxt;
        private TextBox fdFromTxt;
        private TextBox fdArrTimeTxt;
        private TextBox fdDepTimeTxt;
        private TextBox fdDateTxt;
        private TextBox fdFlightNumTxt;
        private Label label27;
        private Label label28;
        private Label label25;
        private Label label26;
        private Label label23;
        private Label label24;
        private Label label20;
        private Label label21;
        private Label label19;
        private TabPage bookingDetailsTab;
        private TextBox bdIDTxt;
        private TextBox bdArrTxt;
        private TextBox bdDepTxt;
        private TextBox bdToTxt;
        private TextBox bdFromTxt;
        private TextBox bdArrTimeTxt;
        private TextBox bdDepTimeTxt;
        private TextBox bdDateTxt;
        private TextBox bdFlightNumTxt;
        private Label label38;
        private Button bdBackBtn;
        private Button bdCancelBtn;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private TabPage travellerNotificationTab;
        private Label label2;
        private Label label3;
        private TabPage travellerSettingsTab;
        private Label setErrorLbl;
        private Button setDeleteBtn;
        private Label label18;
        private Button setCancelBtn;
        private Button setSaveChanesBtn;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label12;
        private Label label10;
        private Label label9;
        private TextBox setPhoneTxt;
        private TextBox setEmailTxt;
        private TextBox setLastNameTxt;
        private TextBox setFirstNameTxt;
        private TextBox setPasswordTxt;
        private TextBox setUsernameTxt;
        private Label label8;
        private Label label14;
        private TabPage travellerBookingsTab;
        private Label label1;
        private Label label13;
        private TabPage travellerFlightsTab;
        private CheckBox dateCheck;
        private CheckBox timeCheck;
        private DateTimePicker date;
        private PictureBox cancelIcon;
        private Label label4;
        private Label label5;
        private PictureBox searchIcon;
        private Label label6;
        private ComboBox arrivalDrop;
        private Label label7;
        private ComboBox depDrop;
        private Label label22;
        private Label label11;
        private TabControl tabController;
        private Button bdAddTravelerBtn;
        private DataGridView gridflightsData;
        private ComboBox time;
        private PictureBox bookingTab;

        public EmployerTabs()
        {
            InitializeComponent();
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights_Active;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployerTabs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.notificationTab = new System.Windows.Forms.PictureBox();
            this.logOutIcon = new System.Windows.Forms.PictureBox();
            this.settingTab = new System.Windows.Forms.PictureBox();
            this.flightsTab = new System.Windows.Forms.PictureBox();
            this.logoIcon = new System.Windows.Forms.PictureBox();
            this.bookingTab = new System.Windows.Forms.PictureBox();
            this.flightDetails = new System.Windows.Forms.TabPage();
            this.fdPayAllBtn = new System.Windows.Forms.Button();
            this.fdAddTravelerBtn = new System.Windows.Forms.Button();
            this.fdCancelBtn = new System.Windows.Forms.Button();
            this.fdBookAllBtn = new System.Windows.Forms.Button();
            this.fdArrTxt = new System.Windows.Forms.TextBox();
            this.fdDepTxt = new System.Windows.Forms.TextBox();
            this.fdToTxt = new System.Windows.Forms.TextBox();
            this.fdFromTxt = new System.Windows.Forms.TextBox();
            this.fdArrTimeTxt = new System.Windows.Forms.TextBox();
            this.fdDepTimeTxt = new System.Windows.Forms.TextBox();
            this.fdDateTxt = new System.Windows.Forms.TextBox();
            this.fdFlightNumTxt = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.bookingDetailsTab = new System.Windows.Forms.TabPage();
            this.bdAddTravelerBtn = new System.Windows.Forms.Button();
            this.bdIDTxt = new System.Windows.Forms.TextBox();
            this.bdArrTxt = new System.Windows.Forms.TextBox();
            this.bdDepTxt = new System.Windows.Forms.TextBox();
            this.bdToTxt = new System.Windows.Forms.TextBox();
            this.bdFromTxt = new System.Windows.Forms.TextBox();
            this.bdArrTimeTxt = new System.Windows.Forms.TextBox();
            this.bdDepTimeTxt = new System.Windows.Forms.TextBox();
            this.bdDateTxt = new System.Windows.Forms.TextBox();
            this.bdFlightNumTxt = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.bdBackBtn = new System.Windows.Forms.Button();
            this.bdCancelBtn = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.travellerNotificationTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.travellerSettingsTab = new System.Windows.Forms.TabPage();
            this.setErrorLbl = new System.Windows.Forms.Label();
            this.setDeleteBtn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.setCancelBtn = new System.Windows.Forms.Button();
            this.setSaveChanesBtn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.setPhoneTxt = new System.Windows.Forms.TextBox();
            this.setEmailTxt = new System.Windows.Forms.TextBox();
            this.setLastNameTxt = new System.Windows.Forms.TextBox();
            this.setFirstNameTxt = new System.Windows.Forms.TextBox();
            this.setPasswordTxt = new System.Windows.Forms.TextBox();
            this.setUsernameTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.travellerBookingsTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.travellerFlightsTab = new System.Windows.Forms.TabPage();
            this.gridflightsData = new System.Windows.Forms.DataGridView();
            this.dateCheck = new System.Windows.Forms.CheckBox();
            this.timeCheck = new System.Windows.Forms.CheckBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cancelIcon = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.arrivalDrop = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.depDrop = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabController = new System.Windows.Forms.TabControl();
            this.time = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notificationTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTab)).BeginInit();
            this.flightDetails.SuspendLayout();
            this.bookingDetailsTab.SuspendLayout();
            this.travellerNotificationTab.SuspendLayout();
            this.travellerSettingsTab.SuspendLayout();
            this.travellerBookingsTab.SuspendLayout();
            this.travellerFlightsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridflightsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            this.tabController.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.notificationTab);
            this.panel1.Controls.Add(this.logOutIcon);
            this.panel1.Controls.Add(this.settingTab);
            this.panel1.Controls.Add(this.flightsTab);
            this.panel1.Controls.Add(this.logoIcon);
            this.panel1.Controls.Add(this.bookingTab);
            this.panel1.Location = new System.Drawing.Point(1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 736);
            this.panel1.TabIndex = 6;
            // 
            // notificationTab
            // 
            this.notificationTab.Image = global::HappyJourneyAirline.Properties.Resources.Notification;
            this.notificationTab.Location = new System.Drawing.Point(34, 402);
            this.notificationTab.Name = "notificationTab";
            this.notificationTab.Size = new System.Drawing.Size(98, 80);
            this.notificationTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.notificationTab.TabIndex = 9;
            this.notificationTab.TabStop = false;
            this.notificationTab.Click += new System.EventHandler(this.notificationTab_Click);
            // 
            // logOutIcon
            // 
            this.logOutIcon.Image = ((System.Drawing.Image)(resources.GetObject("logOutIcon.Image")));
            this.logOutIcon.Location = new System.Drawing.Point(33, 640);
            this.logOutIcon.Name = "logOutIcon";
            this.logOutIcon.Size = new System.Drawing.Size(100, 50);
            this.logOutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logOutIcon.TabIndex = 7;
            this.logOutIcon.TabStop = false;
            // 
            // settingTab
            // 
            this.settingTab.Image = ((System.Drawing.Image)(resources.GetObject("settingTab.Image")));
            this.settingTab.Location = new System.Drawing.Point(31, 525);
            this.settingTab.Name = "settingTab";
            this.settingTab.Size = new System.Drawing.Size(104, 72);
            this.settingTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingTab.TabIndex = 6;
            this.settingTab.TabStop = false;
            this.settingTab.Click += new System.EventHandler(this.settingTab_Click);
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
            this.flightsTab.Click += new System.EventHandler(this.flightsTab_Click);
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
            // 
            // bookingTab
            // 
            this.bookingTab.Image = ((System.Drawing.Image)(resources.GetObject("bookingTab.Image")));
            this.bookingTab.Location = new System.Drawing.Point(31, 279);
            this.bookingTab.Name = "bookingTab";
            this.bookingTab.Size = new System.Drawing.Size(104, 80);
            this.bookingTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookingTab.TabIndex = 5;
            this.bookingTab.TabStop = false;
            this.bookingTab.Click += new System.EventHandler(this.bookingTab_Click);
            // 
            // flightDetails
            // 
            this.flightDetails.BackColor = System.Drawing.Color.Gainsboro;
            this.flightDetails.Controls.Add(this.fdPayAllBtn);
            this.flightDetails.Controls.Add(this.fdAddTravelerBtn);
            this.flightDetails.Controls.Add(this.fdCancelBtn);
            this.flightDetails.Controls.Add(this.fdBookAllBtn);
            this.flightDetails.Controls.Add(this.fdArrTxt);
            this.flightDetails.Controls.Add(this.fdDepTxt);
            this.flightDetails.Controls.Add(this.fdToTxt);
            this.flightDetails.Controls.Add(this.fdFromTxt);
            this.flightDetails.Controls.Add(this.fdArrTimeTxt);
            this.flightDetails.Controls.Add(this.fdDepTimeTxt);
            this.flightDetails.Controls.Add(this.fdDateTxt);
            this.flightDetails.Controls.Add(this.fdFlightNumTxt);
            this.flightDetails.Controls.Add(this.label27);
            this.flightDetails.Controls.Add(this.label28);
            this.flightDetails.Controls.Add(this.label25);
            this.flightDetails.Controls.Add(this.label26);
            this.flightDetails.Controls.Add(this.label23);
            this.flightDetails.Controls.Add(this.label24);
            this.flightDetails.Controls.Add(this.label20);
            this.flightDetails.Controls.Add(this.label21);
            this.flightDetails.Controls.Add(this.label19);
            this.flightDetails.Location = new System.Drawing.Point(25, 4);
            this.flightDetails.Name = "flightDetails";
            this.flightDetails.Padding = new System.Windows.Forms.Padding(3);
            this.flightDetails.Size = new System.Drawing.Size(753, 720);
            this.flightDetails.TabIndex = 5;
            this.flightDetails.Text = "Flight Details";
            // 
            // fdPayAllBtn
            // 
            this.fdPayAllBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(201)))), ((int)(((byte)(5)))));
            this.fdPayAllBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fdPayAllBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fdPayAllBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdPayAllBtn.ForeColor = System.Drawing.Color.White;
            this.fdPayAllBtn.Location = new System.Drawing.Point(592, 587);
            this.fdPayAllBtn.Name = "fdPayAllBtn";
            this.fdPayAllBtn.Size = new System.Drawing.Size(139, 43);
            this.fdPayAllBtn.TabIndex = 53;
            this.fdPayAllBtn.Text = "Pay for all";
            this.fdPayAllBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.fdPayAllBtn.UseVisualStyleBackColor = false;
            // 
            // fdAddTravelerBtn
            // 
            this.fdAddTravelerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.fdAddTravelerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fdAddTravelerBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fdAddTravelerBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdAddTravelerBtn.ForeColor = System.Drawing.Color.White;
            this.fdAddTravelerBtn.Location = new System.Drawing.Point(592, 490);
            this.fdAddTravelerBtn.Name = "fdAddTravelerBtn";
            this.fdAddTravelerBtn.Size = new System.Drawing.Size(139, 43);
            this.fdAddTravelerBtn.TabIndex = 52;
            this.fdAddTravelerBtn.Text = "AddTraveler";
            this.fdAddTravelerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.fdAddTravelerBtn.UseVisualStyleBackColor = false;
            // 
            // fdCancelBtn
            // 
            this.fdCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.fdCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fdCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fdCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdCancelBtn.ForeColor = System.Drawing.Color.White;
            this.fdCancelBtn.Location = new System.Drawing.Point(592, 636);
            this.fdCancelBtn.Name = "fdCancelBtn";
            this.fdCancelBtn.Size = new System.Drawing.Size(139, 43);
            this.fdCancelBtn.TabIndex = 51;
            this.fdCancelBtn.Text = "Cancel";
            this.fdCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.fdCancelBtn.UseVisualStyleBackColor = false;
            this.fdCancelBtn.Click += new System.EventHandler(this.fdCancelBtn_Click);
            // 
            // fdBookAllBtn
            // 
            this.fdBookAllBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.fdBookAllBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fdBookAllBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fdBookAllBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdBookAllBtn.ForeColor = System.Drawing.Color.White;
            this.fdBookAllBtn.Location = new System.Drawing.Point(592, 539);
            this.fdBookAllBtn.Name = "fdBookAllBtn";
            this.fdBookAllBtn.Size = new System.Drawing.Size(139, 43);
            this.fdBookAllBtn.TabIndex = 50;
            this.fdBookAllBtn.Text = "Book for all";
            this.fdBookAllBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.fdBookAllBtn.UseVisualStyleBackColor = false;
            // 
            // fdArrTxt
            // 
            this.fdArrTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.fdArrTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fdArrTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdArrTxt.Location = new System.Drawing.Point(378, 418);
            this.fdArrTxt.Name = "fdArrTxt";
            this.fdArrTxt.ReadOnly = true;
            this.fdArrTxt.Size = new System.Drawing.Size(246, 33);
            this.fdArrTxt.TabIndex = 49;
            this.fdArrTxt.Text = "Bahrain International Airport";
            // 
            // fdDepTxt
            // 
            this.fdDepTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.fdDepTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fdDepTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdDepTxt.Location = new System.Drawing.Point(17, 418);
            this.fdDepTxt.Name = "fdDepTxt";
            this.fdDepTxt.ReadOnly = true;
            this.fdDepTxt.Size = new System.Drawing.Size(246, 33);
            this.fdDepTxt.TabIndex = 46;
            this.fdDepTxt.Text = "Cairo International Airport";
            // 
            // fdToTxt
            // 
            this.fdToTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.fdToTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fdToTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdToTxt.Location = new System.Drawing.Point(378, 338);
            this.fdToTxt.Name = "fdToTxt";
            this.fdToTxt.ReadOnly = true;
            this.fdToTxt.Size = new System.Drawing.Size(246, 33);
            this.fdToTxt.TabIndex = 45;
            this.fdToTxt.Text = "Muharraq (Bahrain)";
            // 
            // fdFromTxt
            // 
            this.fdFromTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.fdFromTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fdFromTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdFromTxt.Location = new System.Drawing.Point(17, 338);
            this.fdFromTxt.Name = "fdFromTxt";
            this.fdFromTxt.ReadOnly = true;
            this.fdFromTxt.Size = new System.Drawing.Size(246, 33);
            this.fdFromTxt.TabIndex = 42;
            this.fdFromTxt.Text = "Cairo (Egypt)";
            // 
            // fdArrTimeTxt
            // 
            this.fdArrTimeTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.fdArrTimeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fdArrTimeTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdArrTimeTxt.Location = new System.Drawing.Point(378, 250);
            this.fdArrTimeTxt.Name = "fdArrTimeTxt";
            this.fdArrTimeTxt.ReadOnly = true;
            this.fdArrTimeTxt.Size = new System.Drawing.Size(246, 33);
            this.fdArrTimeTxt.TabIndex = 41;
            this.fdArrTimeTxt.Text = "11:00 AM";
            // 
            // fdDepTimeTxt
            // 
            this.fdDepTimeTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.fdDepTimeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fdDepTimeTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdDepTimeTxt.Location = new System.Drawing.Point(17, 250);
            this.fdDepTimeTxt.Name = "fdDepTimeTxt";
            this.fdDepTimeTxt.ReadOnly = true;
            this.fdDepTimeTxt.Size = new System.Drawing.Size(246, 33);
            this.fdDepTimeTxt.TabIndex = 38;
            this.fdDepTimeTxt.Text = "8:00 AM";
            // 
            // fdDateTxt
            // 
            this.fdDateTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.fdDateTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fdDateTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdDateTxt.Location = new System.Drawing.Point(378, 175);
            this.fdDateTxt.Name = "fdDateTxt";
            this.fdDateTxt.ReadOnly = true;
            this.fdDateTxt.Size = new System.Drawing.Size(246, 33);
            this.fdDateTxt.TabIndex = 37;
            this.fdDateTxt.Text = "2024/12/30";
            // 
            // fdFlightNumTxt
            // 
            this.fdFlightNumTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.fdFlightNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fdFlightNumTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdFlightNumTxt.Location = new System.Drawing.Point(17, 175);
            this.fdFlightNumTxt.Name = "fdFlightNumTxt";
            this.fdFlightNumTxt.ReadOnly = true;
            this.fdFlightNumTxt.Size = new System.Drawing.Size(246, 33);
            this.fdFlightNumTxt.TabIndex = 34;
            this.fdFlightNumTxt.Text = "123";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(378, 381);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(240, 39);
            this.label27.TabIndex = 48;
            this.label27.Text = "Arrival Airport Time:";
            this.label27.UseCompatibleTextRendering = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(17, 381);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(292, 39);
            this.label28.TabIndex = 47;
            this.label28.Text = "Departure Airport Name:";
            this.label28.UseCompatibleTextRendering = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(378, 303);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(45, 39);
            this.label25.TabIndex = 44;
            this.label25.Text = "To:";
            this.label25.UseCompatibleTextRendering = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(17, 301);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 39);
            this.label26.TabIndex = 43;
            this.label26.Text = "From:";
            this.label26.UseCompatibleTextRendering = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(378, 215);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(153, 39);
            this.label23.TabIndex = 40;
            this.label23.Text = "Arrival Time:";
            this.label23.UseCompatibleTextRendering = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(17, 215);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(194, 39);
            this.label24.TabIndex = 39;
            this.label24.Text = "Departure Time:";
            this.label24.UseCompatibleTextRendering = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(378, 140);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 39);
            this.label20.TabIndex = 36;
            this.label20.Text = "Date:";
            this.label20.UseCompatibleTextRendering = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(17, 138);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(177, 39);
            this.label21.TabIndex = 35;
            this.label21.Text = "Flight Number:";
            this.label21.UseCompatibleTextRendering = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(7, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(356, 73);
            this.label19.TabIndex = 33;
            this.label19.Text = "Flight Details";
            // 
            // bookingDetailsTab
            // 
            this.bookingDetailsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.bookingDetailsTab.Controls.Add(this.bdAddTravelerBtn);
            this.bookingDetailsTab.Controls.Add(this.bdIDTxt);
            this.bookingDetailsTab.Controls.Add(this.bdArrTxt);
            this.bookingDetailsTab.Controls.Add(this.bdDepTxt);
            this.bookingDetailsTab.Controls.Add(this.bdToTxt);
            this.bookingDetailsTab.Controls.Add(this.bdFromTxt);
            this.bookingDetailsTab.Controls.Add(this.bdArrTimeTxt);
            this.bookingDetailsTab.Controls.Add(this.bdDepTimeTxt);
            this.bookingDetailsTab.Controls.Add(this.bdDateTxt);
            this.bookingDetailsTab.Controls.Add(this.bdFlightNumTxt);
            this.bookingDetailsTab.Controls.Add(this.label38);
            this.bookingDetailsTab.Controls.Add(this.bdBackBtn);
            this.bookingDetailsTab.Controls.Add(this.bdCancelBtn);
            this.bookingDetailsTab.Controls.Add(this.label29);
            this.bookingDetailsTab.Controls.Add(this.label30);
            this.bookingDetailsTab.Controls.Add(this.label31);
            this.bookingDetailsTab.Controls.Add(this.label32);
            this.bookingDetailsTab.Controls.Add(this.label33);
            this.bookingDetailsTab.Controls.Add(this.label34);
            this.bookingDetailsTab.Controls.Add(this.label35);
            this.bookingDetailsTab.Controls.Add(this.label36);
            this.bookingDetailsTab.Controls.Add(this.label37);
            this.bookingDetailsTab.Location = new System.Drawing.Point(25, 4);
            this.bookingDetailsTab.Name = "bookingDetailsTab";
            this.bookingDetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.bookingDetailsTab.Size = new System.Drawing.Size(753, 720);
            this.bookingDetailsTab.TabIndex = 4;
            this.bookingDetailsTab.Text = "Booking Details";
            // 
            // bdAddTravelerBtn
            // 
            this.bdAddTravelerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.bdAddTravelerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bdAddTravelerBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bdAddTravelerBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdAddTravelerBtn.ForeColor = System.Drawing.Color.White;
            this.bdAddTravelerBtn.Location = new System.Drawing.Point(30, 517);
            this.bdAddTravelerBtn.Name = "bdAddTravelerBtn";
            this.bdAddTravelerBtn.Size = new System.Drawing.Size(175, 43);
            this.bdAddTravelerBtn.TabIndex = 75;
            this.bdAddTravelerBtn.Text = "Add/list Travelers";
            this.bdAddTravelerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bdAddTravelerBtn.UseVisualStyleBackColor = false;
            // 
            // bdIDTxt
            // 
            this.bdIDTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdIDTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdIDTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdIDTxt.Location = new System.Drawing.Point(137, 107);
            this.bdIDTxt.Name = "bdIDTxt";
            this.bdIDTxt.ReadOnly = true;
            this.bdIDTxt.Size = new System.Drawing.Size(246, 33);
            this.bdIDTxt.TabIndex = 74;
            this.bdIDTxt.Text = "123";
            // 
            // bdArrTxt
            // 
            this.bdArrTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdArrTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdArrTxt.Enabled = false;
            this.bdArrTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdArrTxt.Location = new System.Drawing.Point(391, 441);
            this.bdArrTxt.Name = "bdArrTxt";
            this.bdArrTxt.ReadOnly = true;
            this.bdArrTxt.Size = new System.Drawing.Size(246, 33);
            this.bdArrTxt.TabIndex = 70;
            this.bdArrTxt.Text = "Bahrain International Airport";
            // 
            // bdDepTxt
            // 
            this.bdDepTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdDepTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdDepTxt.Enabled = false;
            this.bdDepTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdDepTxt.Location = new System.Drawing.Point(30, 441);
            this.bdDepTxt.Name = "bdDepTxt";
            this.bdDepTxt.ReadOnly = true;
            this.bdDepTxt.Size = new System.Drawing.Size(246, 33);
            this.bdDepTxt.TabIndex = 67;
            this.bdDepTxt.Text = "Cairo International Airport";
            // 
            // bdToTxt
            // 
            this.bdToTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdToTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdToTxt.Enabled = false;
            this.bdToTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdToTxt.Location = new System.Drawing.Point(391, 361);
            this.bdToTxt.Name = "bdToTxt";
            this.bdToTxt.ReadOnly = true;
            this.bdToTxt.Size = new System.Drawing.Size(246, 33);
            this.bdToTxt.TabIndex = 66;
            this.bdToTxt.Text = "Muharraq (Bahrain)";
            // 
            // bdFromTxt
            // 
            this.bdFromTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdFromTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdFromTxt.Enabled = false;
            this.bdFromTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdFromTxt.Location = new System.Drawing.Point(30, 361);
            this.bdFromTxt.Name = "bdFromTxt";
            this.bdFromTxt.ReadOnly = true;
            this.bdFromTxt.Size = new System.Drawing.Size(246, 33);
            this.bdFromTxt.TabIndex = 63;
            this.bdFromTxt.Text = "Cairo (Egypt)";
            // 
            // bdArrTimeTxt
            // 
            this.bdArrTimeTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdArrTimeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdArrTimeTxt.Enabled = false;
            this.bdArrTimeTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdArrTimeTxt.Location = new System.Drawing.Point(391, 273);
            this.bdArrTimeTxt.Name = "bdArrTimeTxt";
            this.bdArrTimeTxt.ReadOnly = true;
            this.bdArrTimeTxt.Size = new System.Drawing.Size(246, 33);
            this.bdArrTimeTxt.TabIndex = 62;
            this.bdArrTimeTxt.Text = "11:00 AM";
            // 
            // bdDepTimeTxt
            // 
            this.bdDepTimeTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdDepTimeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdDepTimeTxt.Enabled = false;
            this.bdDepTimeTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdDepTimeTxt.Location = new System.Drawing.Point(30, 273);
            this.bdDepTimeTxt.Name = "bdDepTimeTxt";
            this.bdDepTimeTxt.ReadOnly = true;
            this.bdDepTimeTxt.Size = new System.Drawing.Size(246, 33);
            this.bdDepTimeTxt.TabIndex = 59;
            this.bdDepTimeTxt.Text = "8:00 AM";
            // 
            // bdDateTxt
            // 
            this.bdDateTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdDateTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdDateTxt.Enabled = false;
            this.bdDateTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdDateTxt.Location = new System.Drawing.Point(391, 198);
            this.bdDateTxt.Name = "bdDateTxt";
            this.bdDateTxt.ReadOnly = true;
            this.bdDateTxt.Size = new System.Drawing.Size(246, 33);
            this.bdDateTxt.TabIndex = 58;
            this.bdDateTxt.Text = "2024/12/30";
            // 
            // bdFlightNumTxt
            // 
            this.bdFlightNumTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdFlightNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdFlightNumTxt.Enabled = false;
            this.bdFlightNumTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdFlightNumTxt.Location = new System.Drawing.Point(30, 198);
            this.bdFlightNumTxt.Name = "bdFlightNumTxt";
            this.bdFlightNumTxt.ReadOnly = true;
            this.bdFlightNumTxt.Size = new System.Drawing.Size(246, 33);
            this.bdFlightNumTxt.TabIndex = 55;
            this.bdFlightNumTxt.Text = "123";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(30, 107);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(135, 39);
            this.label38.TabIndex = 73;
            this.label38.Text = "Booking ID:";
            this.label38.UseCompatibleTextRendering = true;
            // 
            // bdBackBtn
            // 
            this.bdBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bdBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bdBackBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bdBackBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdBackBtn.ForeColor = System.Drawing.Color.White;
            this.bdBackBtn.Location = new System.Drawing.Point(210, 566);
            this.bdBackBtn.Name = "bdBackBtn";
            this.bdBackBtn.Size = new System.Drawing.Size(173, 43);
            this.bdBackBtn.TabIndex = 72;
            this.bdBackBtn.Text = "Back to bookings";
            this.bdBackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bdBackBtn.UseVisualStyleBackColor = false;
            this.bdBackBtn.Click += new System.EventHandler(this.bdBackBtn_Click);
            // 
            // bdCancelBtn
            // 
            this.bdCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.bdCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bdCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bdCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdCancelBtn.ForeColor = System.Drawing.Color.White;
            this.bdCancelBtn.Location = new System.Drawing.Point(30, 566);
            this.bdCancelBtn.Name = "bdCancelBtn";
            this.bdCancelBtn.Size = new System.Drawing.Size(175, 43);
            this.bdCancelBtn.TabIndex = 71;
            this.bdCancelBtn.Text = "Cancel the booking";
            this.bdCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bdCancelBtn.UseVisualStyleBackColor = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(391, 404);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(240, 39);
            this.label29.TabIndex = 69;
            this.label29.Text = "Arrival Airport Time:";
            this.label29.UseCompatibleTextRendering = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(30, 404);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(292, 39);
            this.label30.TabIndex = 68;
            this.label30.Text = "Departure Airport Name:";
            this.label30.UseCompatibleTextRendering = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(391, 326);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(45, 39);
            this.label31.TabIndex = 65;
            this.label31.Text = "To:";
            this.label31.UseCompatibleTextRendering = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(30, 324);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(75, 39);
            this.label32.TabIndex = 64;
            this.label32.Text = "From:";
            this.label32.UseCompatibleTextRendering = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(391, 238);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(153, 39);
            this.label33.TabIndex = 61;
            this.label33.Text = "Arrival Time:";
            this.label33.UseCompatibleTextRendering = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(30, 238);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(194, 39);
            this.label34.TabIndex = 60;
            this.label34.Text = "Departure Time:";
            this.label34.UseCompatibleTextRendering = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(391, 163);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(70, 39);
            this.label35.TabIndex = 57;
            this.label35.Text = "Date:";
            this.label35.UseCompatibleTextRendering = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(30, 161);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(177, 39);
            this.label36.TabIndex = 56;
            this.label36.Text = "Flight Number:";
            this.label36.UseCompatibleTextRendering = true;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(14, 20);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(420, 73);
            this.label37.TabIndex = 54;
            this.label37.Text = "Booking Details";
            // 
            // travellerNotificationTab
            // 
            this.travellerNotificationTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerNotificationTab.Controls.Add(this.label2);
            this.travellerNotificationTab.Controls.Add(this.label3);
            this.travellerNotificationTab.Location = new System.Drawing.Point(25, 4);
            this.travellerNotificationTab.Name = "travellerNotificationTab";
            this.travellerNotificationTab.Size = new System.Drawing.Size(753, 720);
            this.travellerNotificationTab.TabIndex = 3;
            this.travellerNotificationTab.Text = "Notification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "See all your Notifications";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 73);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notification";
            // 
            // travellerSettingsTab
            // 
            this.travellerSettingsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerSettingsTab.Controls.Add(this.setErrorLbl);
            this.travellerSettingsTab.Controls.Add(this.setDeleteBtn);
            this.travellerSettingsTab.Controls.Add(this.label18);
            this.travellerSettingsTab.Controls.Add(this.setCancelBtn);
            this.travellerSettingsTab.Controls.Add(this.setSaveChanesBtn);
            this.travellerSettingsTab.Controls.Add(this.label17);
            this.travellerSettingsTab.Controls.Add(this.label16);
            this.travellerSettingsTab.Controls.Add(this.label15);
            this.travellerSettingsTab.Controls.Add(this.label12);
            this.travellerSettingsTab.Controls.Add(this.label10);
            this.travellerSettingsTab.Controls.Add(this.label9);
            this.travellerSettingsTab.Controls.Add(this.setPhoneTxt);
            this.travellerSettingsTab.Controls.Add(this.setEmailTxt);
            this.travellerSettingsTab.Controls.Add(this.setLastNameTxt);
            this.travellerSettingsTab.Controls.Add(this.setFirstNameTxt);
            this.travellerSettingsTab.Controls.Add(this.setPasswordTxt);
            this.travellerSettingsTab.Controls.Add(this.setUsernameTxt);
            this.travellerSettingsTab.Controls.Add(this.label8);
            this.travellerSettingsTab.Controls.Add(this.label14);
            this.travellerSettingsTab.Location = new System.Drawing.Point(25, 4);
            this.travellerSettingsTab.Name = "travellerSettingsTab";
            this.travellerSettingsTab.Size = new System.Drawing.Size(753, 720);
            this.travellerSettingsTab.TabIndex = 2;
            this.travellerSettingsTab.Text = "Settings";
            // 
            // setErrorLbl
            // 
            this.setErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.setErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.setErrorLbl.Location = new System.Drawing.Point(18, 427);
            this.setErrorLbl.Name = "setErrorLbl";
            this.setErrorLbl.Size = new System.Drawing.Size(708, 77);
            this.setErrorLbl.TabIndex = 39;
            this.setErrorLbl.Text = "Error: Please fix..";
            this.setErrorLbl.Visible = false;
            // 
            // setDeleteBtn
            // 
            this.setDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.setDeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.setDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.setDeleteBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.setDeleteBtn.Location = new System.Drawing.Point(23, 592);
            this.setDeleteBtn.Name = "setDeleteBtn";
            this.setDeleteBtn.Size = new System.Drawing.Size(139, 43);
            this.setDeleteBtn.TabIndex = 38;
            this.setDeleteBtn.Text = "Delete Account";
            this.setDeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.setDeleteBtn.UseVisualStyleBackColor = false;
            this.setDeleteBtn.Click += new System.EventHandler(this.setDeleteBtn_Click);
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(19, 521);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(707, 62);
            this.label18.TabIndex = 37;
            this.label18.Text = "Attention if you delete your account all your information will be deleted and can" +
    "t be restored";
            // 
            // setCancelBtn
            // 
            this.setCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.setCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.setCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.setCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setCancelBtn.ForeColor = System.Drawing.Color.White;
            this.setCancelBtn.Location = new System.Drawing.Point(168, 363);
            this.setCancelBtn.Name = "setCancelBtn";
            this.setCancelBtn.Size = new System.Drawing.Size(139, 43);
            this.setCancelBtn.TabIndex = 36;
            this.setCancelBtn.Text = "Cancel";
            this.setCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.setCancelBtn.UseVisualStyleBackColor = false;
            this.setCancelBtn.Click += new System.EventHandler(this.setCancelBtn_Click);
            // 
            // setSaveChanesBtn
            // 
            this.setSaveChanesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.setSaveChanesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.setSaveChanesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.setSaveChanesBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setSaveChanesBtn.ForeColor = System.Drawing.Color.White;
            this.setSaveChanesBtn.Location = new System.Drawing.Point(23, 363);
            this.setSaveChanesBtn.Name = "setSaveChanesBtn";
            this.setSaveChanesBtn.Size = new System.Drawing.Size(139, 43);
            this.setSaveChanesBtn.TabIndex = 35;
            this.setSaveChanesBtn.Text = "Save Changes";
            this.setSaveChanesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.setSaveChanesBtn.UseVisualStyleBackColor = false;
            this.setSaveChanesBtn.Click += new System.EventHandler(this.setSaveChanesBtn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(296, 257);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(186, 39);
            this.label17.TabIndex = 34;
            this.label17.Text = "Phone Number:";
            this.label17.UseCompatibleTextRendering = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 257);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 39);
            this.label16.TabIndex = 33;
            this.label16.Text = "Email:";
            this.label16.UseCompatibleTextRendering = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(296, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 39);
            this.label15.TabIndex = 32;
            this.label15.Text = "Last Name:";
            this.label15.UseCompatibleTextRendering = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 39);
            this.label12.TabIndex = 31;
            this.label12.Text = "First Name:";
            this.label12.UseCompatibleTextRendering = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(296, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 39);
            this.label10.TabIndex = 30;
            this.label10.Text = "Password:";
            this.label10.UseCompatibleTextRendering = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 39);
            this.label9.TabIndex = 29;
            this.label9.Text = "Username:";
            this.label9.UseCompatibleTextRendering = true;
            // 
            // setPhoneTxt
            // 
            this.setPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setPhoneTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPhoneTxt.Location = new System.Drawing.Point(296, 290);
            this.setPhoneTxt.Name = "setPhoneTxt";
            this.setPhoneTxt.Size = new System.Drawing.Size(246, 40);
            this.setPhoneTxt.TabIndex = 28;
            // 
            // setEmailTxt
            // 
            this.setEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setEmailTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setEmailTxt.Location = new System.Drawing.Point(23, 290);
            this.setEmailTxt.Name = "setEmailTxt";
            this.setEmailTxt.Size = new System.Drawing.Size(246, 40);
            this.setEmailTxt.TabIndex = 27;
            // 
            // setLastNameTxt
            // 
            this.setLastNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setLastNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setLastNameTxt.Location = new System.Drawing.Point(296, 221);
            this.setLastNameTxt.Name = "setLastNameTxt";
            this.setLastNameTxt.Size = new System.Drawing.Size(246, 40);
            this.setLastNameTxt.TabIndex = 26;
            // 
            // setFirstNameTxt
            // 
            this.setFirstNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setFirstNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setFirstNameTxt.Location = new System.Drawing.Point(23, 221);
            this.setFirstNameTxt.Name = "setFirstNameTxt";
            this.setFirstNameTxt.Size = new System.Drawing.Size(246, 40);
            this.setFirstNameTxt.TabIndex = 25;
            // 
            // setPasswordTxt
            // 
            this.setPasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setPasswordTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPasswordTxt.Location = new System.Drawing.Point(296, 152);
            this.setPasswordTxt.Name = "setPasswordTxt";
            this.setPasswordTxt.Size = new System.Drawing.Size(246, 40);
            this.setPasswordTxt.TabIndex = 24;
            // 
            // setUsernameTxt
            // 
            this.setUsernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setUsernameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setUsernameTxt.Location = new System.Drawing.Point(23, 152);
            this.setUsernameTxt.Name = "setUsernameTxt";
            this.setUsernameTxt.Size = new System.Drawing.Size(246, 40);
            this.setUsernameTxt.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(18, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(322, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Here you can customize your account";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(228, 73);
            this.label14.TabIndex = 3;
            this.label14.Text = "Settings";
            // 
            // travellerBookingsTab
            // 
            this.travellerBookingsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerBookingsTab.Controls.Add(this.label1);
            this.travellerBookingsTab.Controls.Add(this.label13);
            this.travellerBookingsTab.Location = new System.Drawing.Point(25, 4);
            this.travellerBookingsTab.Name = "travellerBookingsTab";
            this.travellerBookingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.travellerBookingsTab.Size = new System.Drawing.Size(753, 720);
            this.travellerBookingsTab.TabIndex = 1;
            this.travellerBookingsTab.Text = "Bookings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(24, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "You can here modify bookings easily";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(258, 73);
            this.label13.TabIndex = 2;
            this.label13.Text = "Bookings";
            // 
            // travellerFlightsTab
            // 
            this.travellerFlightsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerFlightsTab.Controls.Add(this.time);
            this.travellerFlightsTab.Controls.Add(this.gridflightsData);
            this.travellerFlightsTab.Controls.Add(this.dateCheck);
            this.travellerFlightsTab.Controls.Add(this.timeCheck);
            this.travellerFlightsTab.Controls.Add(this.date);
            this.travellerFlightsTab.Controls.Add(this.cancelIcon);
            this.travellerFlightsTab.Controls.Add(this.label4);
            this.travellerFlightsTab.Controls.Add(this.label5);
            this.travellerFlightsTab.Controls.Add(this.searchIcon);
            this.travellerFlightsTab.Controls.Add(this.label6);
            this.travellerFlightsTab.Controls.Add(this.arrivalDrop);
            this.travellerFlightsTab.Controls.Add(this.label7);
            this.travellerFlightsTab.Controls.Add(this.depDrop);
            this.travellerFlightsTab.Controls.Add(this.label22);
            this.travellerFlightsTab.Controls.Add(this.label11);
            this.travellerFlightsTab.Location = new System.Drawing.Point(25, 4);
            this.travellerFlightsTab.Name = "travellerFlightsTab";
            this.travellerFlightsTab.Padding = new System.Windows.Forms.Padding(3);
            this.travellerFlightsTab.Size = new System.Drawing.Size(753, 720);
            this.travellerFlightsTab.TabIndex = 0;
            this.travellerFlightsTab.Text = "Flights";
            this.travellerFlightsTab.Click += new System.EventHandler(this.travellerFlightsTab_Click);
            this.travellerFlightsTab.Paint += new System.Windows.Forms.PaintEventHandler(this.travellerFlightsTab_Paint);
            // 
            // gridflightsData
            // 
            this.gridflightsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridflightsData.Location = new System.Drawing.Point(16, 317);
            this.gridflightsData.Name = "gridflightsData";
            this.gridflightsData.RowHeadersWidth = 51;
            this.gridflightsData.RowTemplate.Height = 24;
            this.gridflightsData.Size = new System.Drawing.Size(721, 346);
            this.gridflightsData.TabIndex = 59;
            // 
            // dateCheck
            // 
            this.dateCheck.AutoSize = true;
            this.dateCheck.Location = new System.Drawing.Point(16, 275);
            this.dateCheck.Name = "dateCheck";
            this.dateCheck.Size = new System.Drawing.Size(18, 17);
            this.dateCheck.TabIndex = 58;
            this.dateCheck.UseVisualStyleBackColor = true;
            this.dateCheck.CheckedChanged += new System.EventHandler(this.dateCheck_CheckedChanged);
            // 
            // timeCheck
            // 
            this.timeCheck.AutoSize = true;
            this.timeCheck.Location = new System.Drawing.Point(333, 275);
            this.timeCheck.Name = "timeCheck";
            this.timeCheck.Size = new System.Drawing.Size(18, 17);
            this.timeCheck.TabIndex = 57;
            this.timeCheck.UseVisualStyleBackColor = true;
            this.timeCheck.CheckedChanged += new System.EventHandler(this.timeCheck_CheckedChanged);
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(37, 266);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(284, 29);
            this.date.TabIndex = 55;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // cancelIcon
            // 
            this.cancelIcon.Image = ((System.Drawing.Image)(resources.GetObject("cancelIcon.Image")));
            this.cancelIcon.Location = new System.Drawing.Point(666, 254);
            this.cancelIcon.Name = "cancelIcon";
            this.cancelIcon.Size = new System.Drawing.Size(72, 52);
            this.cancelIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cancelIcon.TabIndex = 54;
            this.cancelIcon.TabStop = false;
            this.cancelIcon.Click += new System.EventHandler(this.cancelIcon_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 31);
            this.label4.TabIndex = 53;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 31);
            this.label5.TabIndex = 52;
            this.label5.Text = "Date";
            // 
            // searchIcon
            // 
            this.searchIcon.Image = ((System.Drawing.Image)(resources.GetObject("searchIcon.Image")));
            this.searchIcon.Location = new System.Drawing.Point(665, 180);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(72, 52);
            this.searchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchIcon.TabIndex = 51;
            this.searchIcon.TabStop = false;
            this.searchIcon.Click += new System.EventHandler(this.searchIcon_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(350, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 31);
            this.label6.TabIndex = 50;
            this.label6.Text = "Arrival Airport";
            // 
            // arrivalDrop
            // 
            this.arrivalDrop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalDrop.FormattingEnabled = true;
            this.arrivalDrop.Location = new System.Drawing.Point(356, 188);
            this.arrivalDrop.Name = "arrivalDrop";
            this.arrivalDrop.Size = new System.Drawing.Size(287, 32);
            this.arrivalDrop.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 31);
            this.label7.TabIndex = 48;
            this.label7.Text = "Departure Airport";
            // 
            // depDrop
            // 
            this.depDrop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depDrop.FormattingEnabled = true;
            this.depDrop.Location = new System.Drawing.Point(21, 188);
            this.depDrop.Name = "depDrop";
            this.depDrop.Size = new System.Drawing.Size(300, 32);
            this.depDrop.TabIndex = 47;
            this.depDrop.SelectedIndexChanged += new System.EventHandler(this.depDrop_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Location = new System.Drawing.Point(31, 84);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(400, 24);
            this.label22.TabIndex = 3;
            this.label22.Text = "Book Your Next Flight Easily Through This Page";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 73);
            this.label11.TabIndex = 1;
            this.label11.Text = "Flights";
            // 
            // tabController
            // 
            this.tabController.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabController.Controls.Add(this.travellerFlightsTab);
            this.tabController.Controls.Add(this.travellerBookingsTab);
            this.tabController.Controls.Add(this.travellerSettingsTab);
            this.tabController.Controls.Add(this.travellerNotificationTab);
            this.tabController.Controls.Add(this.bookingDetailsTab);
            this.tabController.Controls.Add(this.flightDetails);
            this.tabController.Location = new System.Drawing.Point(137, -4);
            this.tabController.Multiline = true;
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(782, 728);
            this.tabController.TabIndex = 5;
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.FormattingEnabled = true;
            this.time.Items.AddRange(new object[] {
            "Morning",
            "Night"});
            this.time.Location = new System.Drawing.Point(356, 263);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(287, 32);
            this.time.TabIndex = 61;
            // 
            // EmployerTabs
            // 
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.panel1);
            this.Name = "EmployerTabs";
            this.Size = new System.Drawing.Size(921, 728);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notificationTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTab)).EndInit();
            this.flightDetails.ResumeLayout(false);
            this.flightDetails.PerformLayout();
            this.bookingDetailsTab.ResumeLayout(false);
            this.bookingDetailsTab.PerformLayout();
            this.travellerNotificationTab.ResumeLayout(false);
            this.travellerNotificationTab.PerformLayout();
            this.travellerSettingsTab.ResumeLayout(false);
            this.travellerSettingsTab.PerformLayout();
            this.travellerBookingsTab.ResumeLayout(false);
            this.travellerBookingsTab.PerformLayout();
            this.travellerFlightsTab.ResumeLayout(false);
            this.travellerFlightsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridflightsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            this.tabController.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private void flightsTab_Click(object sender, EventArgs e)
        {
            tabController.SelectTab(0);
            defultIcons();
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights_Active;
            try
            {
                depDrop.Items.Clear();
                arrivalDrop.Items.Clear();

                List<Airport> airportList = new List<Airport>();
                Airport handeler = new Airport();


                airportList = handeler.GetAllAirports();
                Console.WriteLine("list: " + airportList);


                if (airportList == null || airportList.Count == 0)
                {
                    Console.WriteLine("No airports found.");
                    return;
                }
                else
                {
                    depDrop.DataSource = airportList;
                    depDrop.DisplayMember = "Name";

                    arrivalDrop.DataSource = airportList;
                    arrivalDrop.DisplayMember = "Name";
                }
            }
            catch (Exception ex)
            {

            }


        }

        private void bookingTab_Click(object sender, EventArgs e)
        {
            tabController.SelectTab(1);
            defultIcons();
            bookingTab.Image = global::HappyJourneyAirline.Properties.Resources.Bookings_Active;
        }

        private void settingTab_Click(object sender, EventArgs e)
        {
            tabController.SelectTab(2);
            defultIcons();
            settingTab.Image = global::HappyJourneyAirline.Properties.Resources.Settings_Active;

            long id = AuthService.GetCurrentUserId();
            User handler = new User();
            User currentUser = handler.GetUserById(id);

            setUsernameTxt.Text = currentUser.Username;
            setFirstNameTxt.Text = currentUser.FirstName;
            setLastNameTxt.Text = currentUser.LastName;
            setEmailTxt.Text = currentUser.Email;
            setPasswordTxt.Text = currentUser.Password;
            setPhoneTxt.Text = currentUser.PhoneNumber;

        }

        private void notificationTab_Click(object sender, EventArgs e)
        {
            tabController.SelectTab(3);
            defultIcons();
            notificationTab.Image = global::HappyJourneyAirline.Properties.Resources.Notification_Active;
        }

        private void defultIcons()
        {
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights;
            bookingTab.Image = global::HappyJourneyAirline.Properties.Resources.Bookings;
            settingTab.Image = global::HappyJourneyAirline.Properties.Resources.Settings_Icon;
            notificationTab.Image = global::HappyJourneyAirline.Properties.Resources.Notification;
        }


        private void setCancelBtn_Click(object sender, EventArgs e)
        {
            tabController.SelectTab(0);
            defultIcons();
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights_Active;
            long id = AuthService.GetCurrentUserId();
            User handler = new User();
            User currentUser = handler.GetUserById(id);

            setUsernameTxt.Text = currentUser.Username;
            setFirstNameTxt.Text = currentUser.FirstName;
            setLastNameTxt.Text = currentUser.LastName;
            setEmailTxt.Text = currentUser.Email;
            setPasswordTxt.Text = currentUser.Password;
            setPhoneTxt.Text = currentUser.PhoneNumber;

        }

        private void bdBackBtn_Click(object sender, EventArgs e)
        {
            tabController.SelectTab(1);
        }

        private void fdCancelBtn_Click(object sender, EventArgs e)
        {
            tabController.SelectTab(0);
            defultIcons();
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights_Active;
        }

        private void setSaveChanesBtn_Click(object sender, EventArgs e)
        {

            long id = AuthService.GetCurrentUserId();
            User handler = new User();
            User currentUser = handler.GetUserById(id);

            List<string> list = new List<string>();
            Boolean valid = true;

            if (setUsernameTxt.Text == "")
            {
                list.Add("username");
                valid = false;
            }

            if (setFirstNameTxt.Text == "")
            {
                list.Add("First Name");
                valid = false;
            }

            if (setLastNameTxt.Text == "")
            {
                list.Add("Last Name");
                valid = false;
            }

            if (setPasswordTxt.Text == "")
            {
                list.Add("Password");
                valid = false;
            }

            if (setEmailTxt.Text == "")
            {
                list.Add("Email");
                valid = false;
            }

            if (setPhoneTxt.Text == "")
            {
                list.Add("Phone Number");
                valid = false;
            }

            if (valid == false)
            {

                string message = list[0];

                for (int i = 1; i < list.Count(); i++)
                {
                    message += " ," + list[i].ToString();
                }

                setErrorLbl.Visible = true;
                setErrorLbl.Text = "Error: Please fill the follwing fileds: " + message;

                MessageBox.Show("Error", "All fileds are required", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {


                currentUser.PhoneNumber = setPhoneTxt.Text;
                currentUser.Username = setUsernameTxt.Text;
                currentUser.Email = setEmailTxt.Text;
                currentUser.Password = setPasswordTxt.Text;
                currentUser.FirstName = setFirstNameTxt.Text;
                currentUser.LastName = setLastNameTxt.Text;
                currentUser.UpdateUser(currentUser);

                MessageBox.Show("User Info Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void setDeleteBtn_Click(object sender, EventArgs e)
        {
            long id = AuthService.GetCurrentUserId();
            User handler = new User();
            User currentUser = handler.GetUserById(id);

            DialogResult result = MessageBox.Show(
        "Warning! Are you sure you want to delete this user? This action cannot be undone.",
        "Delete Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                if (currentUser.DeleteUser(currentUser.Id))
                {
                    MessageBox.Show("User has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("An error occurred while deleting the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Delete operation canceled.", "Cancellation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void depDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void travellerFlightsTab_Click(object sender, EventArgs e)
        {

        }

        private void travellerFlightsTab_Paint(object sender, PaintEventArgs e)
        {
            time.Enabled = false;
            flightDataLoad();
        }

        private void searchIcon_Click(object sender, EventArgs e)
        {

            // Get selected dropdown values
            Airport selectedSource = depDrop.SelectedItem as Airport;
            Airport selectedDestination = arrivalDrop.SelectedItem as Airport;

            // Validate selections
            if (selectedSource == null || selectedDestination == null)
            {
                MessageBox.Show("Please select valid departure and arrival airports.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Initialize SQL connection and command
            using (SqlConnection conn = new SqlConnection(Database.connectionString))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                // Base query
                string query = @"
            SELECT f.Id, 
                   sa.name AS sourceAirportName, 
                   da.name AS destinationAirportName, 
                   f.departureTimestamp, 
                   f.arrivalTimestamp, 
                   fs.name AS flightStatus, 
                   f.planeID, 
                   f.BasePrice
            FROM flights f
            LEFT JOIN flight_statuses fs ON f.flightStatusID = fs.Id
            LEFT JOIN airports sa ON f.sourceAirportID = sa.Id
            LEFT JOIN airports da ON f.destinationAirportID = da.Id
            WHERE 1 = 1"; // Always true to simplify adding conditions

                // Add conditions for airports
                if (selectedSource.Name != "All")
                {
                    query += " AND sa.Id = @sourceID";
                    cmd.Parameters.AddWithValue("@sourceID", selectedSource.Id);
                }
                if (selectedDestination.Name != "All")
                {
                    query += " AND da.Id = @destinationID";
                    cmd.Parameters.AddWithValue("@destinationID", selectedDestination.Id);
                }

                // Add condition for date and time if checked
                if (dateCheck.Checked || timeCheck.Checked)
                {
                    string dateAndTime = " ";

                    if (dateCheck.Checked)
                    {
                        dateAndTime = date.Value.ToString("MM/dd/yyyy");

                        query += " AND CAST(f.departureTimestamp AS DATE) = CONVERT(DATE, @selectedDate, 101)";
                        string checkDate = date.Value.ToString();
                        cmd.Parameters.AddWithValue("@selectedDate", checkDate);
                        // Ensure proper date format
                    }

                    if (timeCheck.Checked)
                    {
                        // Append the condition to the query
                        string selectedTime = time.Text;
                        if (selectedTime == "Morning")
                        {
                            query += " AND RIGHT(CONVERT(VARCHAR, f.departureTimestamp, 100), 2) = 'AM'";

                        }
                        else if (selectedTime == "Night")
                        {
                            query += " AND RIGHT(CONVERT(VARCHAR, f.departureTimestamp, 100), 2) = 'PM'";
                        }
                        else {
                            MessageBox.Show("Value must be selected in the Time filed", "Missing Field", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }


                    }

                }

                try
                {
                    Console.WriteLine(query);
                    // Assign final query to command
                    cmd.CommandText = query;

                    // Execute the query and bind the results to the grid
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    gridflightsData.DataSource = dt;
                }
                catch { 
                
                }
            }
        }

        private void flightDataLoad()
        {

            try
            {

                List<Airport> airportList = new List<Airport>();
                Airport handeler = new Airport();


                airportList = handeler.GetAllAirports();
                List<Airport> airportList2 = handeler.GetAllAirports();

                if (airportList == null || airportList.Count == 0)
                {
                    Console.WriteLine("No airports found.");
                    return;
                }
                else
                {
                    Airport allOption = new Airport
                    {
                        Id = 0, // Use an ID that won't conflict with real airport IDs
                        Name = "All"
                    };

                    // Insert the "All" option at the beginning of the airportList
                    airportList.Insert(0, allOption);
                    airportList2.Insert(0, allOption);

                    depDrop.DataSource = null;
                    depDrop.DataSource = airportList;
                    depDrop.DisplayMember = "Name";

                    arrivalDrop.DataSource = null;
                    arrivalDrop.DataSource = airportList2;
                    arrivalDrop.DisplayMember = "Name";
                }




                SqlConnection conn = new SqlConnection(Database.connectionString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT f.Id, sa.name AS sourceAirportName, da.name AS destinationAirportName, f.departureTimestamp, f.arrivalTimestamp, fs.name, f.planeID, f.BasePrice FROM flights f LEFT JOIN flight_statuses fs ON f.flightStatusID = fs.Id LEFT JOIN airports sa ON f.sourceAirportID = sa.Id LEFT JOIN airports da ON f.destinationAirportID = da.Id";
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);


                gridflightsData.DataSource = dt;


            }
            catch (Exception ex)
            {

            }
        }

        private void cancelIcon_Click(object sender, EventArgs e)
        {
            dateCheck.CheckState = CheckState.Unchecked;
            timeCheck.CheckState = CheckState.Unchecked;
            arrivalDrop.SelectedIndex = 0;
            depDrop.SelectedIndex = 0;

            depDrop.SelectedIndex = 0;
            arrivalDrop.SelectedIndex = 0;
            flightDataLoad();
            return;
        }

        private void dateCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (dateCheck.Checked)
            {
                date.Enabled = true;
            }
            else
            {
                date.Enabled = false;
            }

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (timeCheck.Checked)
            {
                time.Enabled = true;
                time.Text = "Select Time";
            }
            else
            {
                time.Enabled = false;
            }
        }
    }

}
