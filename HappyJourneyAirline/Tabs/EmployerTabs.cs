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
using System.Drawing;
using System.Reflection;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Collections;
using System.ComponentModel;
namespace HappyJourneyAirline.Tabs
{
    public partial class EmployerTabs : UserControl
    {
        TabControl appTabs;
        BindingList<User> tempUsers = new BindingList<User>();
        BindingList<TicketClass> tempUsersTicketClass = new BindingList<TicketClass>();
        BindingList<User> sysUsers = new BindingList<User>();
        BindingList<User> allUsers = new BindingList<User>();
        BindingList<Flight> bookedFlights = new BindingList<Flight>();
        User selectedTraveller = null;
        Ticket selectedTicket = null;
        Flight selectedFlight = null;
        int previosTab = 0;

        #region Fields
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
        private Button fdDeleteTravellerBtn;
        private TextBox fdArrTxt;
        private TextBox fdDepTxt;
        private TextBox fdToTxt;
        private TextBox fdFromTxt;
        private TextBox fdArrTimeTxt;
        private TextBox fdDepTimeTxt;
        private TextBox fdFlightNumTxt;
        private TabPage bookingDetailsTab;
        private TextBox bdIDTxt;
        private TextBox bdArrTxt;
        private TextBox bdDepTxt;
        private TextBox bdToTxt;
        private TextBox bdFromTxt;
        private TextBox bdArrTimeTxt;
        private TextBox bdDepTimeTxt;
        private TextBox bdFlightNumTxt;
        private Label label38;
        private Button bdBackBtn;
        private Button bdCancelBtn;
        private TabPage travellerNotificationTab;
        private TabPage travellerSettingsTab;
        private Label setErrorLbl;
        private Button setDeleteBtn;
        private Button setCancelBtn;
        private Button setSaveChanesBtn;
        private TextBox setPhoneTxt;
        private TextBox setEmailTxt;
        private TextBox setLastNameTxt;
        private TextBox setFirstNameTxt;
        private TextBox setPasswordTxt;
        private TextBox setUsernameTxt;
        private TabPage travellerBookingsTab;
        private CheckBox dateCheck;
        private CheckBox timeCheck;
        private DateTimePicker date;
        private PictureBox cancelIcon;
        private PictureBox searchIcon;
        private ComboBox arrivalDrop;
        private ComboBox depDrop;
        private TabControl tabController;
        private DataGridView gridflightsData;
        private ComboBox time;
        private DataGridView dataGridViewNotification;
        private Button vnShowSelectedBtn;
        private DataGridView fdTravellersDataGridView;
        private TabPage addTraveler;
        private TextBox cuFnameTxt;
        private TextBox cuLnameTxt;
        private TextBox cuPhoneTxt;
        private TextBox cuEmailTxt;
        private Button cuCancelBtn;
        private Button cuCreateUserBtn;
        private Label atErrorLbl;
        private DataGridView bookingTable;
        private ComboBox cuTickitClassDrop;
        private TabPage payment;
        private Label ppTotaLbl;
        private DateTimePicker ppDatePick;
        private Button ppCancelBtn;
        private Button ppPayBtn;
        private TextBox ppCvvTxt;
        private TextBox ppNameCardTxt;
        private TextBox ppCardNumTxt;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private RadioButton ppAeRadio;
        private RadioButton ppVisaRadio;
        private RadioButton ppCcRadio;
        private TextBox ppFlightNumTxt;
        private TextBox ppNewTravellersNumTxt;
        private Label paymentErrorLbl;
        private TextBox cuCPRTxt;
        private TextBox bdEmailTxt;
        private TextBox bdFNameTxt;
        private TextBox bdTicketClassNameTxt;
        private TextBox bdPhoneNumberTxt;
        private TextBox bdLNameTxt;
        private TextBox bdCPRTxt;
        private TextBox bdTotalPriceTxt;
        private TextBox bdSeatNumTxt;
        private DataGridViewTextBoxColumn Edit;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn from;
        private DataGridViewTextBoxColumn to;
        private DataGridViewTextBoxColumn dateTime;
        private PictureBox bookingTab;
        #endregion
        public EmployerTabs(TabControl appTabs)
        {
            InitializeComponent();
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights_Active;
            allUsers = new BindingList<User>(Flight.GetTravellersForFlightByAgencyID(0, 0));
            fdTravellersDataGridView.DataSource = allUsers;
            fdTravellersDataGridView.Columns.Insert(0, AddEditColumn());
            bookingTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bookingTable.Columns[0].DefaultCellStyle.ForeColor = Color.Blue;

            this.appTabs = appTabs;
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.Label label27;
            System.Windows.Forms.Label label28;
            System.Windows.Forms.Label label25;
            System.Windows.Forms.Label label26;
            System.Windows.Forms.Label label23;
            System.Windows.Forms.Label label24;
            System.Windows.Forms.Label label21;
            System.Windows.Forms.Label label19;
            System.Windows.Forms.Label label29;
            System.Windows.Forms.Label label30;
            System.Windows.Forms.Label label31;
            System.Windows.Forms.Label label32;
            System.Windows.Forms.Label label33;
            System.Windows.Forms.Label label34;
            System.Windows.Forms.Label label36;
            System.Windows.Forms.Label label37;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.TabPage travellerFlightsTab;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployerTabs));
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label22;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label label50;
            System.Windows.Forms.Label label47;
            System.Windows.Forms.Label label46;
            System.Windows.Forms.Label label44;
            System.Windows.Forms.Label label45;
            System.Windows.Forms.Label label49;
            System.Windows.Forms.Label label48;
            System.Windows.Forms.Label label39;
            System.Windows.Forms.Label label40;
            System.Windows.Forms.Label label41;
            System.Windows.Forms.Label label42;
            System.Windows.Forms.Label label43;
            System.Windows.Forms.Label label53;
            System.Windows.Forms.Label label54;
            System.Windows.Forms.Label label51;
            System.Windows.Forms.Label label52;
            System.Windows.Forms.Label label55;
            System.Windows.Forms.Label label56;
            System.Windows.Forms.Label label57;
            System.Windows.Forms.Label label58;
            System.Windows.Forms.Label label59;
            System.Windows.Forms.Label label60;
            System.Windows.Forms.Label label35;
            System.Windows.Forms.Label label61;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.time = new System.Windows.Forms.ComboBox();
            this.gridflightsData = new System.Windows.Forms.DataGridView();
            this.dateCheck = new System.Windows.Forms.CheckBox();
            this.timeCheck = new System.Windows.Forms.CheckBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cancelIcon = new System.Windows.Forms.PictureBox();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.arrivalDrop = new System.Windows.Forms.ComboBox();
            this.depDrop = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notificationTab = new System.Windows.Forms.PictureBox();
            this.logOutIcon = new System.Windows.Forms.PictureBox();
            this.settingTab = new System.Windows.Forms.PictureBox();
            this.flightsTab = new System.Windows.Forms.PictureBox();
            this.logoIcon = new System.Windows.Forms.PictureBox();
            this.bookingTab = new System.Windows.Forms.PictureBox();
            this.flightDetails = new System.Windows.Forms.TabPage();
            this.fdTravellersDataGridView = new System.Windows.Forms.DataGridView();
            this.fdPayAllBtn = new System.Windows.Forms.Button();
            this.fdAddTravelerBtn = new System.Windows.Forms.Button();
            this.fdCancelBtn = new System.Windows.Forms.Button();
            this.fdDeleteTravellerBtn = new System.Windows.Forms.Button();
            this.fdArrTxt = new System.Windows.Forms.TextBox();
            this.fdDepTxt = new System.Windows.Forms.TextBox();
            this.fdToTxt = new System.Windows.Forms.TextBox();
            this.fdFromTxt = new System.Windows.Forms.TextBox();
            this.fdArrTimeTxt = new System.Windows.Forms.TextBox();
            this.fdDepTimeTxt = new System.Windows.Forms.TextBox();
            this.fdFlightNumTxt = new System.Windows.Forms.TextBox();
            this.bookingDetailsTab = new System.Windows.Forms.TabPage();
            this.bdSeatNumTxt = new System.Windows.Forms.TextBox();
            this.bdTotalPriceTxt = new System.Windows.Forms.TextBox();
            this.bdTicketClassNameTxt = new System.Windows.Forms.TextBox();
            this.bdPhoneNumberTxt = new System.Windows.Forms.TextBox();
            this.bdLNameTxt = new System.Windows.Forms.TextBox();
            this.bdCPRTxt = new System.Windows.Forms.TextBox();
            this.bdEmailTxt = new System.Windows.Forms.TextBox();
            this.bdFNameTxt = new System.Windows.Forms.TextBox();
            this.bdIDTxt = new System.Windows.Forms.TextBox();
            this.bdArrTxt = new System.Windows.Forms.TextBox();
            this.bdDepTxt = new System.Windows.Forms.TextBox();
            this.bdToTxt = new System.Windows.Forms.TextBox();
            this.bdFromTxt = new System.Windows.Forms.TextBox();
            this.bdArrTimeTxt = new System.Windows.Forms.TextBox();
            this.bdDepTimeTxt = new System.Windows.Forms.TextBox();
            this.bdFlightNumTxt = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.bdBackBtn = new System.Windows.Forms.Button();
            this.bdCancelBtn = new System.Windows.Forms.Button();
            this.travellerNotificationTab = new System.Windows.Forms.TabPage();
            this.vnShowSelectedBtn = new System.Windows.Forms.Button();
            this.dataGridViewNotification = new System.Windows.Forms.DataGridView();
            this.travellerSettingsTab = new System.Windows.Forms.TabPage();
            this.setErrorLbl = new System.Windows.Forms.Label();
            this.setDeleteBtn = new System.Windows.Forms.Button();
            this.setCancelBtn = new System.Windows.Forms.Button();
            this.setSaveChanesBtn = new System.Windows.Forms.Button();
            this.setPhoneTxt = new System.Windows.Forms.TextBox();
            this.setEmailTxt = new System.Windows.Forms.TextBox();
            this.setLastNameTxt = new System.Windows.Forms.TextBox();
            this.setFirstNameTxt = new System.Windows.Forms.TextBox();
            this.setPasswordTxt = new System.Windows.Forms.TextBox();
            this.setUsernameTxt = new System.Windows.Forms.TextBox();
            this.travellerBookingsTab = new System.Windows.Forms.TabPage();
            this.bookingTable = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabController = new System.Windows.Forms.TabControl();
            this.addTraveler = new System.Windows.Forms.TabPage();
            this.cuCPRTxt = new System.Windows.Forms.TextBox();
            this.cuTickitClassDrop = new System.Windows.Forms.ComboBox();
            this.atErrorLbl = new System.Windows.Forms.Label();
            this.cuCancelBtn = new System.Windows.Forms.Button();
            this.cuCreateUserBtn = new System.Windows.Forms.Button();
            this.cuFnameTxt = new System.Windows.Forms.TextBox();
            this.cuLnameTxt = new System.Windows.Forms.TextBox();
            this.cuPhoneTxt = new System.Windows.Forms.TextBox();
            this.cuEmailTxt = new System.Windows.Forms.TextBox();
            this.payment = new System.Windows.Forms.TabPage();
            this.paymentErrorLbl = new System.Windows.Forms.Label();
            this.ppNewTravellersNumTxt = new System.Windows.Forms.TextBox();
            this.ppTotaLbl = new System.Windows.Forms.Label();
            this.ppDatePick = new System.Windows.Forms.DateTimePicker();
            this.ppCancelBtn = new System.Windows.Forms.Button();
            this.ppPayBtn = new System.Windows.Forms.Button();
            this.ppCvvTxt = new System.Windows.Forms.TextBox();
            this.ppNameCardTxt = new System.Windows.Forms.TextBox();
            this.ppCardNumTxt = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ppAeRadio = new System.Windows.Forms.RadioButton();
            this.ppVisaRadio = new System.Windows.Forms.RadioButton();
            this.ppCcRadio = new System.Windows.Forms.RadioButton();
            this.ppFlightNumTxt = new System.Windows.Forms.TextBox();
            label27 = new System.Windows.Forms.Label();
            label28 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            label26 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label29 = new System.Windows.Forms.Label();
            label30 = new System.Windows.Forms.Label();
            label31 = new System.Windows.Forms.Label();
            label32 = new System.Windows.Forms.Label();
            label33 = new System.Windows.Forms.Label();
            label34 = new System.Windows.Forms.Label();
            label36 = new System.Windows.Forms.Label();
            label37 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            travellerFlightsTab = new System.Windows.Forms.TabPage();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label50 = new System.Windows.Forms.Label();
            label47 = new System.Windows.Forms.Label();
            label46 = new System.Windows.Forms.Label();
            label44 = new System.Windows.Forms.Label();
            label45 = new System.Windows.Forms.Label();
            label49 = new System.Windows.Forms.Label();
            label48 = new System.Windows.Forms.Label();
            label39 = new System.Windows.Forms.Label();
            label40 = new System.Windows.Forms.Label();
            label41 = new System.Windows.Forms.Label();
            label42 = new System.Windows.Forms.Label();
            label43 = new System.Windows.Forms.Label();
            label53 = new System.Windows.Forms.Label();
            label54 = new System.Windows.Forms.Label();
            label51 = new System.Windows.Forms.Label();
            label52 = new System.Windows.Forms.Label();
            label55 = new System.Windows.Forms.Label();
            label56 = new System.Windows.Forms.Label();
            label57 = new System.Windows.Forms.Label();
            label58 = new System.Windows.Forms.Label();
            label59 = new System.Windows.Forms.Label();
            label60 = new System.Windows.Forms.Label();
            label35 = new System.Windows.Forms.Label();
            label61 = new System.Windows.Forms.Label();
            travellerFlightsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridflightsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notificationTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTab)).BeginInit();
            this.flightDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fdTravellersDataGridView)).BeginInit();
            this.bookingDetailsTab.SuspendLayout();
            this.travellerNotificationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotification)).BeginInit();
            this.travellerSettingsTab.SuspendLayout();
            this.travellerBookingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTable)).BeginInit();
            this.tabController.SuspendLayout();
            this.addTraveler.SuspendLayout();
            this.payment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = System.Drawing.Color.Transparent;
            label27.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label27.Location = new System.Drawing.Point(378, 381);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(240, 39);
            label27.TabIndex = 48;
            label27.Text = "Arrival Airport Time:";
            label27.UseCompatibleTextRendering = true;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.BackColor = System.Drawing.Color.Transparent;
            label28.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label28.Location = new System.Drawing.Point(17, 381);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(292, 39);
            label28.TabIndex = 47;
            label28.Text = "Departure Airport Name:";
            label28.UseCompatibleTextRendering = true;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = System.Drawing.Color.Transparent;
            label25.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label25.Location = new System.Drawing.Point(378, 303);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(45, 39);
            label25.TabIndex = 44;
            label25.Text = "To:";
            label25.UseCompatibleTextRendering = true;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = System.Drawing.Color.Transparent;
            label26.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label26.Location = new System.Drawing.Point(17, 301);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(75, 39);
            label26.TabIndex = 43;
            label26.Text = "From:";
            label26.UseCompatibleTextRendering = true;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = System.Drawing.Color.Transparent;
            label23.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label23.Location = new System.Drawing.Point(378, 215);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(153, 39);
            label23.TabIndex = 40;
            label23.Text = "Arrival Time:";
            label23.UseCompatibleTextRendering = true;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = System.Drawing.Color.Transparent;
            label24.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label24.Location = new System.Drawing.Point(17, 215);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(194, 39);
            label24.TabIndex = 39;
            label24.Text = "Departure Time:";
            label24.UseCompatibleTextRendering = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = System.Drawing.Color.Transparent;
            label21.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label21.Location = new System.Drawing.Point(17, 138);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(177, 39);
            label21.TabIndex = 35;
            label21.Text = "Flight Number:";
            label21.UseCompatibleTextRendering = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label19.Location = new System.Drawing.Point(7, 35);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(356, 73);
            label19.TabIndex = 33;
            label19.Text = "Flight Details";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = System.Drawing.Color.Transparent;
            label29.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label29.Location = new System.Drawing.Point(396, 306);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(240, 39);
            label29.TabIndex = 69;
            label29.Text = "Arrival Airport Time:";
            label29.UseCompatibleTextRendering = true;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = System.Drawing.Color.Transparent;
            label30.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label30.Location = new System.Drawing.Point(35, 306);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(292, 39);
            label30.TabIndex = 68;
            label30.Text = "Departure Airport Name:";
            label30.UseCompatibleTextRendering = true;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.BackColor = System.Drawing.Color.Transparent;
            label31.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label31.Location = new System.Drawing.Point(396, 240);
            label31.Name = "label31";
            label31.Size = new System.Drawing.Size(45, 39);
            label31.TabIndex = 65;
            label31.Text = "To:";
            label31.UseCompatibleTextRendering = true;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.BackColor = System.Drawing.Color.Transparent;
            label32.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label32.Location = new System.Drawing.Point(35, 238);
            label32.Name = "label32";
            label32.Size = new System.Drawing.Size(75, 39);
            label32.TabIndex = 64;
            label32.Text = "From:";
            label32.UseCompatibleTextRendering = true;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.BackColor = System.Drawing.Color.Transparent;
            label33.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label33.Location = new System.Drawing.Point(396, 169);
            label33.Name = "label33";
            label33.Size = new System.Drawing.Size(213, 39);
            label33.TabIndex = 61;
            label33.Text = "Arrival Date Time:";
            label33.UseCompatibleTextRendering = true;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.BackColor = System.Drawing.Color.Transparent;
            label34.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label34.Location = new System.Drawing.Point(35, 169);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(253, 39);
            label34.TabIndex = 60;
            label34.Text = "Departure Date Time:";
            label34.UseCompatibleTextRendering = true;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.BackColor = System.Drawing.Color.Transparent;
            label36.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label36.Location = new System.Drawing.Point(396, 107);
            label36.Name = "label36";
            label36.Size = new System.Drawing.Size(109, 39);
            label36.TabIndex = 56;
            label36.Text = "Flight ID:";
            label36.UseCompatibleTextRendering = true;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label37.Location = new System.Drawing.Point(14, 20);
            label37.Name = "label37";
            label37.Size = new System.Drawing.Size(420, 73);
            label37.TabIndex = 54;
            label37.Text = "Booking Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label2.Location = new System.Drawing.Point(14, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(217, 24);
            label2.TabIndex = 5;
            label2.Text = "See all your Notifications";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(7, 12);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(325, 73);
            label3.TabIndex = 4;
            label3.Text = "Notification";
            // 
            // label18
            // 
            label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label18.Location = new System.Drawing.Point(19, 521);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(707, 62);
            label18.TabIndex = 37;
            label18.Text = "Attention if you delete your account all your information will be deleted and can" +
    "t be restored";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = System.Drawing.Color.Transparent;
            label17.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.Location = new System.Drawing.Point(382, 257);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(186, 39);
            label17.TabIndex = 34;
            label17.Text = "Phone Number:";
            label17.UseCompatibleTextRendering = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = System.Drawing.Color.Transparent;
            label16.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.Location = new System.Drawing.Point(23, 257);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(79, 39);
            label16.TabIndex = 33;
            label16.Text = "Email:";
            label16.UseCompatibleTextRendering = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = System.Drawing.Color.Transparent;
            label15.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(382, 186);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(135, 39);
            label15.TabIndex = 32;
            label15.Text = "Last Name:";
            label15.UseCompatibleTextRendering = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = System.Drawing.Color.Transparent;
            label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(23, 186);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(138, 39);
            label12.TabIndex = 31;
            label12.Text = "First Name:";
            label12.UseCompatibleTextRendering = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(382, 117);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(125, 39);
            label10.TabIndex = 30;
            label10.Text = "Password:";
            label10.UseCompatibleTextRendering = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(23, 117);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(132, 39);
            label9.TabIndex = 29;
            label9.Text = "Username:";
            label9.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label8.Location = new System.Drawing.Point(18, 88);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(322, 24);
            label8.TabIndex = 22;
            label8.Text = "Here you can customize your account";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(12, 18);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(228, 73);
            label14.TabIndex = 3;
            label14.Text = "Settings";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label1.Location = new System.Drawing.Point(24, 80);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(313, 24);
            label1.TabIndex = 4;
            label1.Text = "You can here modify bookings easily";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(16, 21);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(258, 73);
            label13.TabIndex = 2;
            label13.Text = "Bookings";
            // 
            // travellerFlightsTab
            // 
            travellerFlightsTab.BackColor = System.Drawing.Color.Gainsboro;
            travellerFlightsTab.Controls.Add(this.time);
            travellerFlightsTab.Controls.Add(this.gridflightsData);
            travellerFlightsTab.Controls.Add(this.dateCheck);
            travellerFlightsTab.Controls.Add(this.timeCheck);
            travellerFlightsTab.Controls.Add(this.date);
            travellerFlightsTab.Controls.Add(this.cancelIcon);
            travellerFlightsTab.Controls.Add(label4);
            travellerFlightsTab.Controls.Add(label5);
            travellerFlightsTab.Controls.Add(this.searchIcon);
            travellerFlightsTab.Controls.Add(label6);
            travellerFlightsTab.Controls.Add(this.arrivalDrop);
            travellerFlightsTab.Controls.Add(label7);
            travellerFlightsTab.Controls.Add(this.depDrop);
            travellerFlightsTab.Controls.Add(label22);
            travellerFlightsTab.Controls.Add(label11);
            travellerFlightsTab.Location = new System.Drawing.Point(25, 4);
            travellerFlightsTab.Name = "travellerFlightsTab";
            travellerFlightsTab.Padding = new System.Windows.Forms.Padding(3);
            travellerFlightsTab.Size = new System.Drawing.Size(753, 720);
            travellerFlightsTab.TabIndex = 0;
            travellerFlightsTab.Text = "Flights";
            travellerFlightsTab.Paint += new System.Windows.Forms.PaintEventHandler(this.travellerFlightsTab_Paint);
            // 
            // time
            // 
            this.time.Enabled = false;
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
            // gridflightsData
            // 
            this.gridflightsData.AllowUserToAddRows = false;
            this.gridflightsData.AllowUserToDeleteRows = false;
            this.gridflightsData.AllowUserToOrderColumns = true;
            this.gridflightsData.AllowUserToResizeRows = false;
            this.gridflightsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridflightsData.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridflightsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridflightsData.ColumnHeadersHeight = 40;
            this.gridflightsData.Location = new System.Drawing.Point(16, 317);
            this.gridflightsData.Name = "gridflightsData";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridflightsData.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gridflightsData.RowHeadersVisible = false;
            this.gridflightsData.RowHeadersWidth = 50;
            this.gridflightsData.RowTemplate.Height = 50;
            this.gridflightsData.Size = new System.Drawing.Size(721, 346);
            this.gridflightsData.TabIndex = 59;
            this.gridflightsData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridflightsData_CellClick);
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
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(353, 231);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(74, 31);
            label4.TabIndex = 53;
            label4.Text = "Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(13, 231);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(72, 31);
            label5.TabIndex = 52;
            label5.Text = "Date";
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
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(350, 157);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(178, 31);
            label6.TabIndex = 50;
            label6.Text = "Arrival Airport";
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
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(15, 157);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(222, 31);
            label7.TabIndex = 48;
            label7.Text = "Departure Airport";
            // 
            // depDrop
            // 
            this.depDrop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depDrop.FormattingEnabled = true;
            this.depDrop.Location = new System.Drawing.Point(21, 188);
            this.depDrop.Name = "depDrop";
            this.depDrop.Size = new System.Drawing.Size(300, 32);
            this.depDrop.TabIndex = 47;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label22.Location = new System.Drawing.Point(31, 84);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(400, 24);
            label22.TabIndex = 3;
            label22.Text = "Book Your Next Flight Easily Through This Page";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(24, 25);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(194, 73);
            label11.TabIndex = 1;
            label11.Text = "Flights";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = System.Drawing.Color.Transparent;
            label20.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label20.Location = new System.Drawing.Point(342, 349);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(146, 39);
            label20.TabIndex = 125;
            label20.Text = "Ticket Class:";
            label20.UseCompatibleTextRendering = true;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label50.Location = new System.Drawing.Point(18, 61);
            label50.Name = "label50";
            label50.Size = new System.Drawing.Size(360, 73);
            label50.TabIndex = 120;
            label50.Text = "Add Traveller";
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.BackColor = System.Drawing.Color.Transparent;
            label47.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label47.Location = new System.Drawing.Point(25, 169);
            label47.Name = "label47";
            label47.Size = new System.Drawing.Size(138, 39);
            label47.TabIndex = 116;
            label47.Text = "First Name:";
            label47.UseCompatibleTextRendering = true;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.BackColor = System.Drawing.Color.Transparent;
            label46.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label46.Location = new System.Drawing.Point(338, 169);
            label46.Name = "label46";
            label46.Size = new System.Drawing.Size(135, 39);
            label46.TabIndex = 117;
            label46.Text = "Last Name:";
            label46.UseCompatibleTextRendering = true;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.BackColor = System.Drawing.Color.Transparent;
            label44.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label44.Location = new System.Drawing.Point(342, 259);
            label44.Name = "label44";
            label44.Size = new System.Drawing.Size(186, 39);
            label44.TabIndex = 119;
            label44.Text = "Phone Number:";
            label44.UseCompatibleTextRendering = true;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.BackColor = System.Drawing.Color.Transparent;
            label45.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label45.Location = new System.Drawing.Point(25, 258);
            label45.Name = "label45";
            label45.Size = new System.Drawing.Size(79, 39);
            label45.TabIndex = 118;
            label45.Text = "Email:";
            label45.UseCompatibleTextRendering = true;
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.BackColor = System.Drawing.Color.Transparent;
            label49.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label49.Location = new System.Drawing.Point(222, 594);
            label49.Name = "label49";
            label49.Size = new System.Drawing.Size(162, 39);
            label49.TabIndex = 80;
            label49.Text = "BD (VAT inc.) ";
            label49.UseCompatibleTextRendering = true;
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.BackColor = System.Drawing.Color.Transparent;
            label48.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label48.Location = new System.Drawing.Point(24, 594);
            label48.Name = "label48";
            label48.Size = new System.Drawing.Size(154, 39);
            label48.TabIndex = 79;
            label48.Text = "Total will be:";
            label48.UseCompatibleTextRendering = true;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.BackColor = System.Drawing.Color.Transparent;
            label39.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label39.Location = new System.Drawing.Point(303, 411);
            label39.Name = "label39";
            label39.Size = new System.Drawing.Size(56, 39);
            label39.TabIndex = 75;
            label39.Text = "CVV";
            label39.UseCompatibleTextRendering = true;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.BackColor = System.Drawing.Color.Transparent;
            label40.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label40.Location = new System.Drawing.Point(24, 412);
            label40.Name = "label40";
            label40.Size = new System.Drawing.Size(169, 39);
            label40.TabIndex = 73;
            label40.Text = "Name on Card";
            label40.UseCompatibleTextRendering = true;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.BackColor = System.Drawing.Color.Transparent;
            label41.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label41.Location = new System.Drawing.Point(303, 326);
            label41.Name = "label41";
            label41.Size = new System.Drawing.Size(149, 39);
            label41.TabIndex = 71;
            label41.Text = "Expiary date";
            label41.UseCompatibleTextRendering = true;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.BackColor = System.Drawing.Color.Transparent;
            label42.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label42.Location = new System.Drawing.Point(24, 327);
            label42.Name = "label42";
            label42.Size = new System.Drawing.Size(159, 39);
            label42.TabIndex = 69;
            label42.Text = "Card Number";
            label42.UseCompatibleTextRendering = true;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.BackColor = System.Drawing.Color.Transparent;
            label43.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label43.Location = new System.Drawing.Point(24, 209);
            label43.Name = "label43";
            label43.Size = new System.Drawing.Size(213, 39);
            label43.TabIndex = 61;
            label43.Text = "Credit card details";
            label43.UseCompatibleTextRendering = true;
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.BackColor = System.Drawing.Color.Transparent;
            label53.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label53.Location = new System.Drawing.Point(24, 115);
            label53.Name = "label53";
            label53.Size = new System.Drawing.Size(177, 39);
            label53.TabIndex = 56;
            label53.Text = "Flight Number:";
            label53.UseCompatibleTextRendering = true;
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label54.Location = new System.Drawing.Point(14, 23);
            label54.Name = "label54";
            label54.Size = new System.Drawing.Size(383, 73);
            label54.TabIndex = 54;
            label54.Text = "Payment Page";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.BackColor = System.Drawing.Color.Transparent;
            label51.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label51.Location = new System.Drawing.Point(351, 115);
            label51.Name = "label51";
            label51.Size = new System.Drawing.Size(334, 39);
            label51.TabIndex = 83;
            label51.Text = "Number of Added Travellers:";
            label51.UseCompatibleTextRendering = true;
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.BackColor = System.Drawing.Color.Transparent;
            label52.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label52.Location = new System.Drawing.Point(25, 345);
            label52.Name = "label52";
            label52.Size = new System.Drawing.Size(61, 39);
            label52.TabIndex = 127;
            label52.Text = "CPR:";
            label52.UseCompatibleTextRendering = true;
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.BackColor = System.Drawing.Color.Transparent;
            label55.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label55.Location = new System.Drawing.Point(35, 507);
            label55.Name = "label55";
            label55.Size = new System.Drawing.Size(61, 39);
            label55.TabIndex = 133;
            label55.Text = "CPR:";
            label55.UseCompatibleTextRendering = true;
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.BackColor = System.Drawing.Color.Transparent;
            label56.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label56.Location = new System.Drawing.Point(396, 507);
            label56.Name = "label56";
            label56.Size = new System.Drawing.Size(146, 39);
            label56.TabIndex = 132;
            label56.Text = "Ticket Class:";
            label56.UseCompatibleTextRendering = true;
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.BackColor = System.Drawing.Color.Transparent;
            label57.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label57.Location = new System.Drawing.Point(35, 381);
            label57.Name = "label57";
            label57.Size = new System.Drawing.Size(138, 39);
            label57.TabIndex = 128;
            label57.Text = "First Name:";
            label57.UseCompatibleTextRendering = true;
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.BackColor = System.Drawing.Color.Transparent;
            label58.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label58.Location = new System.Drawing.Point(396, 381);
            label58.Name = "label58";
            label58.Size = new System.Drawing.Size(135, 39);
            label58.TabIndex = 129;
            label58.Text = "Last Name:";
            label58.UseCompatibleTextRendering = true;
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.BackColor = System.Drawing.Color.Transparent;
            label59.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label59.Location = new System.Drawing.Point(396, 443);
            label59.Name = "label59";
            label59.Size = new System.Drawing.Size(186, 39);
            label59.TabIndex = 131;
            label59.Text = "Phone Number:";
            label59.UseCompatibleTextRendering = true;
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.BackColor = System.Drawing.Color.Transparent;
            label60.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label60.Location = new System.Drawing.Point(35, 443);
            label60.Name = "label60";
            label60.Size = new System.Drawing.Size(79, 39);
            label60.TabIndex = 130;
            label60.Text = "Email:";
            label60.UseCompatibleTextRendering = true;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.BackColor = System.Drawing.Color.Transparent;
            label35.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label35.Location = new System.Drawing.Point(30, 577);
            label35.Name = "label35";
            label35.Size = new System.Drawing.Size(136, 39);
            label35.TabIndex = 140;
            label35.Text = "Total Price:";
            label35.UseCompatibleTextRendering = true;
            // 
            // label61
            // 
            label61.AutoSize = true;
            label61.BackColor = System.Drawing.Color.Transparent;
            label61.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label61.Location = new System.Drawing.Point(396, 577);
            label61.Name = "label61";
            label61.Size = new System.Drawing.Size(164, 39);
            label61.TabIndex = 142;
            label61.Text = "Seat Number:";
            label61.UseCompatibleTextRendering = true;
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
            this.logOutIcon.Click += new System.EventHandler(this.logOutIcon_Click);
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
            this.flightDetails.Controls.Add(this.fdTravellersDataGridView);
            this.flightDetails.Controls.Add(this.fdPayAllBtn);
            this.flightDetails.Controls.Add(this.fdAddTravelerBtn);
            this.flightDetails.Controls.Add(this.fdCancelBtn);
            this.flightDetails.Controls.Add(this.fdDeleteTravellerBtn);
            this.flightDetails.Controls.Add(this.fdArrTxt);
            this.flightDetails.Controls.Add(this.fdDepTxt);
            this.flightDetails.Controls.Add(this.fdToTxt);
            this.flightDetails.Controls.Add(this.fdFromTxt);
            this.flightDetails.Controls.Add(this.fdArrTimeTxt);
            this.flightDetails.Controls.Add(this.fdDepTimeTxt);
            this.flightDetails.Controls.Add(this.fdFlightNumTxt);
            this.flightDetails.Controls.Add(label27);
            this.flightDetails.Controls.Add(label28);
            this.flightDetails.Controls.Add(label25);
            this.flightDetails.Controls.Add(label26);
            this.flightDetails.Controls.Add(label23);
            this.flightDetails.Controls.Add(label24);
            this.flightDetails.Controls.Add(label21);
            this.flightDetails.Controls.Add(label19);
            this.flightDetails.Location = new System.Drawing.Point(25, 4);
            this.flightDetails.Name = "flightDetails";
            this.flightDetails.Padding = new System.Windows.Forms.Padding(3);
            this.flightDetails.Size = new System.Drawing.Size(753, 720);
            this.flightDetails.TabIndex = 5;
            this.flightDetails.Text = "Flight Details";
            // 
            // fdTravellersDataGridView
            // 
            this.fdTravellersDataGridView.AllowUserToAddRows = false;
            this.fdTravellersDataGridView.AllowUserToDeleteRows = false;
            this.fdTravellersDataGridView.AllowUserToOrderColumns = true;
            this.fdTravellersDataGridView.AllowUserToResizeRows = false;
            this.fdTravellersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fdTravellersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.fdTravellersDataGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fdTravellersDataGridView.DefaultCellStyle = dataGridViewCellStyle13;
            this.fdTravellersDataGridView.Location = new System.Drawing.Point(17, 462);
            this.fdTravellersDataGridView.MultiSelect = false;
            this.fdTravellersDataGridView.Name = "fdTravellersDataGridView";
            this.fdTravellersDataGridView.RowHeadersWidth = 70;
            this.fdTravellersDataGridView.RowTemplate.Height = 40;
            this.fdTravellersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.fdTravellersDataGridView.Size = new System.Drawing.Size(562, 239);
            this.fdTravellersDataGridView.TabIndex = 54;
            this.fdTravellersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fdTravellersDataGridView_CellClick);
            this.fdTravellersDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.fdTravellersDataGridView_DataBindingComplete);
            // 
            // fdPayAllBtn
            // 
            this.fdPayAllBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(201)))), ((int)(((byte)(5)))));
            this.fdPayAllBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fdPayAllBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fdPayAllBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdPayAllBtn.ForeColor = System.Drawing.Color.White;
            this.fdPayAllBtn.Location = new System.Drawing.Point(585, 592);
            this.fdPayAllBtn.Name = "fdPayAllBtn";
            this.fdPayAllBtn.Size = new System.Drawing.Size(139, 43);
            this.fdPayAllBtn.TabIndex = 53;
            this.fdPayAllBtn.Text = "Pay for all";
            this.fdPayAllBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.fdPayAllBtn.UseVisualStyleBackColor = false;
            this.fdPayAllBtn.Click += new System.EventHandler(this.fdPayAllBtn_Click);
            // 
            // fdAddTravelerBtn
            // 
            this.fdAddTravelerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.fdAddTravelerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fdAddTravelerBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fdAddTravelerBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdAddTravelerBtn.ForeColor = System.Drawing.Color.White;
            this.fdAddTravelerBtn.Location = new System.Drawing.Point(585, 462);
            this.fdAddTravelerBtn.Name = "fdAddTravelerBtn";
            this.fdAddTravelerBtn.Size = new System.Drawing.Size(139, 43);
            this.fdAddTravelerBtn.TabIndex = 52;
            this.fdAddTravelerBtn.Text = "Add Traveler";
            this.fdAddTravelerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.fdAddTravelerBtn.UseVisualStyleBackColor = false;
            this.fdAddTravelerBtn.Click += new System.EventHandler(this.fdAddTravelerBtn_Click);
            // 
            // fdCancelBtn
            // 
            this.fdCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.fdCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fdCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fdCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdCancelBtn.ForeColor = System.Drawing.Color.White;
            this.fdCancelBtn.Location = new System.Drawing.Point(585, 657);
            this.fdCancelBtn.Name = "fdCancelBtn";
            this.fdCancelBtn.Size = new System.Drawing.Size(139, 43);
            this.fdCancelBtn.TabIndex = 51;
            this.fdCancelBtn.Text = "Cancel";
            this.fdCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.fdCancelBtn.UseVisualStyleBackColor = false;
            this.fdCancelBtn.Click += new System.EventHandler(this.fdCancelBtn_Click);
            // 
            // fdDeleteTravellerBtn
            // 
            this.fdDeleteTravellerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.fdDeleteTravellerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fdDeleteTravellerBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fdDeleteTravellerBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdDeleteTravellerBtn.ForeColor = System.Drawing.Color.White;
            this.fdDeleteTravellerBtn.Location = new System.Drawing.Point(585, 527);
            this.fdDeleteTravellerBtn.Name = "fdDeleteTravellerBtn";
            this.fdDeleteTravellerBtn.Size = new System.Drawing.Size(139, 43);
            this.fdDeleteTravellerBtn.TabIndex = 50;
            this.fdDeleteTravellerBtn.Text = "Delete Traveller";
            this.fdDeleteTravellerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.fdDeleteTravellerBtn.UseVisualStyleBackColor = false;
            this.fdDeleteTravellerBtn.Click += new System.EventHandler(this.fdDeleteTravellerBtn_Click);
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
            // bookingDetailsTab
            // 
            this.bookingDetailsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.bookingDetailsTab.Controls.Add(this.bdSeatNumTxt);
            this.bookingDetailsTab.Controls.Add(label61);
            this.bookingDetailsTab.Controls.Add(this.bdTotalPriceTxt);
            this.bookingDetailsTab.Controls.Add(label35);
            this.bookingDetailsTab.Controls.Add(this.bdTicketClassNameTxt);
            this.bookingDetailsTab.Controls.Add(this.bdPhoneNumberTxt);
            this.bookingDetailsTab.Controls.Add(this.bdLNameTxt);
            this.bookingDetailsTab.Controls.Add(this.bdCPRTxt);
            this.bookingDetailsTab.Controls.Add(this.bdEmailTxt);
            this.bookingDetailsTab.Controls.Add(this.bdFNameTxt);
            this.bookingDetailsTab.Controls.Add(label55);
            this.bookingDetailsTab.Controls.Add(label56);
            this.bookingDetailsTab.Controls.Add(label57);
            this.bookingDetailsTab.Controls.Add(label58);
            this.bookingDetailsTab.Controls.Add(label59);
            this.bookingDetailsTab.Controls.Add(label60);
            this.bookingDetailsTab.Controls.Add(this.bdIDTxt);
            this.bookingDetailsTab.Controls.Add(this.bdArrTxt);
            this.bookingDetailsTab.Controls.Add(this.bdDepTxt);
            this.bookingDetailsTab.Controls.Add(this.bdToTxt);
            this.bookingDetailsTab.Controls.Add(this.bdFromTxt);
            this.bookingDetailsTab.Controls.Add(this.bdArrTimeTxt);
            this.bookingDetailsTab.Controls.Add(this.bdDepTimeTxt);
            this.bookingDetailsTab.Controls.Add(this.bdFlightNumTxt);
            this.bookingDetailsTab.Controls.Add(this.label38);
            this.bookingDetailsTab.Controls.Add(this.bdBackBtn);
            this.bookingDetailsTab.Controls.Add(this.bdCancelBtn);
            this.bookingDetailsTab.Controls.Add(label29);
            this.bookingDetailsTab.Controls.Add(label30);
            this.bookingDetailsTab.Controls.Add(label31);
            this.bookingDetailsTab.Controls.Add(label32);
            this.bookingDetailsTab.Controls.Add(label33);
            this.bookingDetailsTab.Controls.Add(label34);
            this.bookingDetailsTab.Controls.Add(label36);
            this.bookingDetailsTab.Controls.Add(label37);
            this.bookingDetailsTab.Location = new System.Drawing.Point(25, 4);
            this.bookingDetailsTab.Name = "bookingDetailsTab";
            this.bookingDetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.bookingDetailsTab.Size = new System.Drawing.Size(753, 720);
            this.bookingDetailsTab.TabIndex = 4;
            this.bookingDetailsTab.Text = "Booking Details";
            // 
            // bdSeatNumTxt
            // 
            this.bdSeatNumTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdSeatNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdSeatNumTxt.Enabled = false;
            this.bdSeatNumTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdSeatNumTxt.Location = new System.Drawing.Point(401, 602);
            this.bdSeatNumTxt.Name = "bdSeatNumTxt";
            this.bdSeatNumTxt.ReadOnly = true;
            this.bdSeatNumTxt.Size = new System.Drawing.Size(246, 33);
            this.bdSeatNumTxt.TabIndex = 143;
            this.bdSeatNumTxt.Text = "Cairo International Airport";
            // 
            // bdTotalPriceTxt
            // 
            this.bdTotalPriceTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdTotalPriceTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdTotalPriceTxt.Enabled = false;
            this.bdTotalPriceTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdTotalPriceTxt.Location = new System.Drawing.Point(35, 602);
            this.bdTotalPriceTxt.Name = "bdTotalPriceTxt";
            this.bdTotalPriceTxt.ReadOnly = true;
            this.bdTotalPriceTxt.Size = new System.Drawing.Size(246, 33);
            this.bdTotalPriceTxt.TabIndex = 141;
            this.bdTotalPriceTxt.Text = "Cairo International Airport";
            // 
            // bdTicketClassNameTxt
            // 
            this.bdTicketClassNameTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdTicketClassNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdTicketClassNameTxt.Enabled = false;
            this.bdTicketClassNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdTicketClassNameTxt.Location = new System.Drawing.Point(396, 530);
            this.bdTicketClassNameTxt.Name = "bdTicketClassNameTxt";
            this.bdTicketClassNameTxt.ReadOnly = true;
            this.bdTicketClassNameTxt.Size = new System.Drawing.Size(246, 33);
            this.bdTicketClassNameTxt.TabIndex = 139;
            this.bdTicketClassNameTxt.Text = "Cairo International Airport";
            // 
            // bdPhoneNumberTxt
            // 
            this.bdPhoneNumberTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdPhoneNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdPhoneNumberTxt.Enabled = false;
            this.bdPhoneNumberTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdPhoneNumberTxt.Location = new System.Drawing.Point(396, 470);
            this.bdPhoneNumberTxt.Name = "bdPhoneNumberTxt";
            this.bdPhoneNumberTxt.ReadOnly = true;
            this.bdPhoneNumberTxt.Size = new System.Drawing.Size(246, 33);
            this.bdPhoneNumberTxt.TabIndex = 138;
            this.bdPhoneNumberTxt.Text = "Cairo International Airport";
            // 
            // bdLNameTxt
            // 
            this.bdLNameTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdLNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdLNameTxt.Enabled = false;
            this.bdLNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdLNameTxt.Location = new System.Drawing.Point(396, 410);
            this.bdLNameTxt.Name = "bdLNameTxt";
            this.bdLNameTxt.ReadOnly = true;
            this.bdLNameTxt.Size = new System.Drawing.Size(246, 33);
            this.bdLNameTxt.TabIndex = 137;
            this.bdLNameTxt.Text = "Cairo International Airport";
            // 
            // bdCPRTxt
            // 
            this.bdCPRTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdCPRTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdCPRTxt.Enabled = false;
            this.bdCPRTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdCPRTxt.Location = new System.Drawing.Point(35, 530);
            this.bdCPRTxt.Name = "bdCPRTxt";
            this.bdCPRTxt.ReadOnly = true;
            this.bdCPRTxt.Size = new System.Drawing.Size(246, 33);
            this.bdCPRTxt.TabIndex = 136;
            this.bdCPRTxt.Text = "Cairo International Airport";
            // 
            // bdEmailTxt
            // 
            this.bdEmailTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdEmailTxt.Enabled = false;
            this.bdEmailTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdEmailTxt.Location = new System.Drawing.Point(35, 470);
            this.bdEmailTxt.Name = "bdEmailTxt";
            this.bdEmailTxt.ReadOnly = true;
            this.bdEmailTxt.Size = new System.Drawing.Size(246, 33);
            this.bdEmailTxt.TabIndex = 135;
            this.bdEmailTxt.Text = "Cairo International Airport";
            // 
            // bdFNameTxt
            // 
            this.bdFNameTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdFNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdFNameTxt.Enabled = false;
            this.bdFNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdFNameTxt.Location = new System.Drawing.Point(35, 410);
            this.bdFNameTxt.Name = "bdFNameTxt";
            this.bdFNameTxt.ReadOnly = true;
            this.bdFNameTxt.Size = new System.Drawing.Size(246, 33);
            this.bdFNameTxt.TabIndex = 134;
            this.bdFNameTxt.Text = "Cairo International Airport";
            // 
            // bdIDTxt
            // 
            this.bdIDTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdIDTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdIDTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdIDTxt.Location = new System.Drawing.Point(137, 107);
            this.bdIDTxt.Name = "bdIDTxt";
            this.bdIDTxt.ReadOnly = true;
            this.bdIDTxt.Size = new System.Drawing.Size(139, 33);
            this.bdIDTxt.TabIndex = 74;
            this.bdIDTxt.Text = "123";
            // 
            // bdArrTxt
            // 
            this.bdArrTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdArrTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdArrTxt.Enabled = false;
            this.bdArrTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdArrTxt.Location = new System.Drawing.Point(396, 337);
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
            this.bdDepTxt.Location = new System.Drawing.Point(35, 337);
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
            this.bdToTxt.Location = new System.Drawing.Point(396, 267);
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
            this.bdFromTxt.Location = new System.Drawing.Point(35, 267);
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
            this.bdArrTimeTxt.Location = new System.Drawing.Point(396, 197);
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
            this.bdDepTimeTxt.Location = new System.Drawing.Point(35, 197);
            this.bdDepTimeTxt.Name = "bdDepTimeTxt";
            this.bdDepTimeTxt.ReadOnly = true;
            this.bdDepTimeTxt.Size = new System.Drawing.Size(246, 33);
            this.bdDepTimeTxt.TabIndex = 59;
            this.bdDepTimeTxt.Text = "8:00 AM";
            // 
            // bdFlightNumTxt
            // 
            this.bdFlightNumTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdFlightNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdFlightNumTxt.Enabled = false;
            this.bdFlightNumTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdFlightNumTxt.Location = new System.Drawing.Point(477, 107);
            this.bdFlightNumTxt.Name = "bdFlightNumTxt";
            this.bdFlightNumTxt.ReadOnly = true;
            this.bdFlightNumTxt.Size = new System.Drawing.Size(136, 33);
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
            this.bdBackBtn.Location = new System.Drawing.Point(210, 667);
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
            this.bdCancelBtn.Location = new System.Drawing.Point(30, 667);
            this.bdCancelBtn.Name = "bdCancelBtn";
            this.bdCancelBtn.Size = new System.Drawing.Size(175, 43);
            this.bdCancelBtn.TabIndex = 71;
            this.bdCancelBtn.Text = "Cancel the booking";
            this.bdCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bdCancelBtn.UseVisualStyleBackColor = false;
            this.bdCancelBtn.Click += new System.EventHandler(this.bdCancelBtn_Click);
            // 
            // travellerNotificationTab
            // 
            this.travellerNotificationTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerNotificationTab.Controls.Add(this.vnShowSelectedBtn);
            this.travellerNotificationTab.Controls.Add(this.dataGridViewNotification);
            this.travellerNotificationTab.Controls.Add(label2);
            this.travellerNotificationTab.Controls.Add(label3);
            this.travellerNotificationTab.Location = new System.Drawing.Point(25, 4);
            this.travellerNotificationTab.Name = "travellerNotificationTab";
            this.travellerNotificationTab.Size = new System.Drawing.Size(753, 720);
            this.travellerNotificationTab.TabIndex = 3;
            this.travellerNotificationTab.Text = "Notification";
            this.travellerNotificationTab.Paint += new System.Windows.Forms.PaintEventHandler(this.travellerNotificationTab_Paint);
            // 
            // vnShowSelectedBtn
            // 
            this.vnShowSelectedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.vnShowSelectedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vnShowSelectedBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.vnShowSelectedBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vnShowSelectedBtn.ForeColor = System.Drawing.Color.White;
            this.vnShowSelectedBtn.Location = new System.Drawing.Point(469, 617);
            this.vnShowSelectedBtn.Name = "vnShowSelectedBtn";
            this.vnShowSelectedBtn.Size = new System.Drawing.Size(257, 43);
            this.vnShowSelectedBtn.TabIndex = 76;
            this.vnShowSelectedBtn.Text = "Show Selected Notification ";
            this.vnShowSelectedBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.vnShowSelectedBtn.UseVisualStyleBackColor = false;
            this.vnShowSelectedBtn.Click += new System.EventHandler(this.vnShowSelectedBtn_Click);
            // 
            // dataGridViewNotification
            // 
            this.dataGridViewNotification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNotification.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewNotification.ColumnHeadersHeight = 40;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNotification.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewNotification.Location = new System.Drawing.Point(20, 121);
            this.dataGridViewNotification.Name = "dataGridViewNotification";
            this.dataGridViewNotification.RowHeadersVisible = false;
            this.dataGridViewNotification.RowHeadersWidth = 51;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewNotification.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewNotification.RowTemplate.Height = 50;
            this.dataGridViewNotification.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotification.Size = new System.Drawing.Size(706, 472);
            this.dataGridViewNotification.TabIndex = 8;
            // 
            // travellerSettingsTab
            // 
            this.travellerSettingsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerSettingsTab.Controls.Add(this.setErrorLbl);
            this.travellerSettingsTab.Controls.Add(this.setDeleteBtn);
            this.travellerSettingsTab.Controls.Add(label18);
            this.travellerSettingsTab.Controls.Add(this.setCancelBtn);
            this.travellerSettingsTab.Controls.Add(this.setSaveChanesBtn);
            this.travellerSettingsTab.Controls.Add(label17);
            this.travellerSettingsTab.Controls.Add(label16);
            this.travellerSettingsTab.Controls.Add(label15);
            this.travellerSettingsTab.Controls.Add(label12);
            this.travellerSettingsTab.Controls.Add(label10);
            this.travellerSettingsTab.Controls.Add(label9);
            this.travellerSettingsTab.Controls.Add(this.setPhoneTxt);
            this.travellerSettingsTab.Controls.Add(this.setEmailTxt);
            this.travellerSettingsTab.Controls.Add(this.setLastNameTxt);
            this.travellerSettingsTab.Controls.Add(this.setFirstNameTxt);
            this.travellerSettingsTab.Controls.Add(this.setPasswordTxt);
            this.travellerSettingsTab.Controls.Add(this.setUsernameTxt);
            this.travellerSettingsTab.Controls.Add(label8);
            this.travellerSettingsTab.Controls.Add(label14);
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
            // setPhoneTxt
            // 
            this.setPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setPhoneTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPhoneTxt.Location = new System.Drawing.Point(382, 290);
            this.setPhoneTxt.Name = "setPhoneTxt";
            this.setPhoneTxt.Size = new System.Drawing.Size(326, 40);
            this.setPhoneTxt.TabIndex = 28;
            // 
            // setEmailTxt
            // 
            this.setEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setEmailTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setEmailTxt.Location = new System.Drawing.Point(23, 290);
            this.setEmailTxt.Name = "setEmailTxt";
            this.setEmailTxt.Size = new System.Drawing.Size(317, 40);
            this.setEmailTxt.TabIndex = 27;
            // 
            // setLastNameTxt
            // 
            this.setLastNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setLastNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setLastNameTxt.Location = new System.Drawing.Point(382, 221);
            this.setLastNameTxt.Name = "setLastNameTxt";
            this.setLastNameTxt.Size = new System.Drawing.Size(326, 40);
            this.setLastNameTxt.TabIndex = 26;
            // 
            // setFirstNameTxt
            // 
            this.setFirstNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setFirstNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setFirstNameTxt.Location = new System.Drawing.Point(23, 221);
            this.setFirstNameTxt.Name = "setFirstNameTxt";
            this.setFirstNameTxt.Size = new System.Drawing.Size(317, 40);
            this.setFirstNameTxt.TabIndex = 25;
            // 
            // setPasswordTxt
            // 
            this.setPasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setPasswordTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPasswordTxt.Location = new System.Drawing.Point(382, 152);
            this.setPasswordTxt.Name = "setPasswordTxt";
            this.setPasswordTxt.Size = new System.Drawing.Size(326, 40);
            this.setPasswordTxt.TabIndex = 24;
            // 
            // setUsernameTxt
            // 
            this.setUsernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setUsernameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setUsernameTxt.Location = new System.Drawing.Point(23, 152);
            this.setUsernameTxt.Name = "setUsernameTxt";
            this.setUsernameTxt.Size = new System.Drawing.Size(317, 40);
            this.setUsernameTxt.TabIndex = 23;
            // 
            // travellerBookingsTab
            // 
            this.travellerBookingsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerBookingsTab.Controls.Add(this.bookingTable);
            this.travellerBookingsTab.Controls.Add(label1);
            this.travellerBookingsTab.Controls.Add(label13);
            this.travellerBookingsTab.Location = new System.Drawing.Point(25, 4);
            this.travellerBookingsTab.Name = "travellerBookingsTab";
            this.travellerBookingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.travellerBookingsTab.Size = new System.Drawing.Size(753, 720);
            this.travellerBookingsTab.TabIndex = 1;
            this.travellerBookingsTab.Text = "Bookings";
            // 
            // bookingTable
            // 
            this.bookingTable.AllowUserToAddRows = false;
            this.bookingTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookingTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.bookingTable.ColumnHeadersHeight = 40;
            this.bookingTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.ID,
            this.from,
            this.to,
            this.dateTime});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookingTable.DefaultCellStyle = dataGridViewCellStyle18;
            this.bookingTable.Location = new System.Drawing.Point(28, 152);
            this.bookingTable.Name = "bookingTable";
            this.bookingTable.ReadOnly = true;
            this.bookingTable.RowHeadersVisible = false;
            this.bookingTable.RowHeadersWidth = 51;
            this.bookingTable.RowTemplate.Height = 50;
            this.bookingTable.Size = new System.Drawing.Size(686, 519);
            this.bookingTable.TabIndex = 7;
            this.bookingTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookingTable_CellClick);
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 70;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 57;
            // 
            // from
            // 
            this.from.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.from.HeaderText = "From";
            this.from.MinimumWidth = 6;
            this.from.Name = "from";
            this.from.ReadOnly = true;
            // 
            // to
            // 
            this.to.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.to.HeaderText = "To";
            this.to.MinimumWidth = 6;
            this.to.Name = "to";
            this.to.ReadOnly = true;
            // 
            // dateTime
            // 
            this.dateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateTime.HeaderText = "Date and Time";
            this.dateTime.MinimumWidth = 6;
            this.dateTime.Name = "dateTime";
            this.dateTime.ReadOnly = true;
            // 
            // tabController
            // 
            this.tabController.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabController.Controls.Add(travellerFlightsTab);
            this.tabController.Controls.Add(this.travellerBookingsTab);
            this.tabController.Controls.Add(this.travellerSettingsTab);
            this.tabController.Controls.Add(this.travellerNotificationTab);
            this.tabController.Controls.Add(this.bookingDetailsTab);
            this.tabController.Controls.Add(this.flightDetails);
            this.tabController.Controls.Add(this.addTraveler);
            this.tabController.Controls.Add(this.payment);
            this.tabController.Location = new System.Drawing.Point(137, -4);
            this.tabController.Multiline = true;
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(782, 728);
            this.tabController.TabIndex = 5;
            // 
            // addTraveler
            // 
            this.addTraveler.BackColor = System.Drawing.Color.Gainsboro;
            this.addTraveler.Controls.Add(label52);
            this.addTraveler.Controls.Add(this.cuCPRTxt);
            this.addTraveler.Controls.Add(label20);
            this.addTraveler.Controls.Add(this.cuTickitClassDrop);
            this.addTraveler.Controls.Add(this.atErrorLbl);
            this.addTraveler.Controls.Add(this.cuCancelBtn);
            this.addTraveler.Controls.Add(this.cuCreateUserBtn);
            this.addTraveler.Controls.Add(label50);
            this.addTraveler.Controls.Add(label47);
            this.addTraveler.Controls.Add(this.cuFnameTxt);
            this.addTraveler.Controls.Add(label46);
            this.addTraveler.Controls.Add(this.cuLnameTxt);
            this.addTraveler.Controls.Add(label44);
            this.addTraveler.Controls.Add(label45);
            this.addTraveler.Controls.Add(this.cuPhoneTxt);
            this.addTraveler.Controls.Add(this.cuEmailTxt);
            this.addTraveler.Location = new System.Drawing.Point(25, 4);
            this.addTraveler.Name = "addTraveler";
            this.addTraveler.Padding = new System.Windows.Forms.Padding(3);
            this.addTraveler.Size = new System.Drawing.Size(753, 720);
            this.addTraveler.TabIndex = 6;
            this.addTraveler.Text = "Add Traveller";
            // 
            // cuCPRTxt
            // 
            this.cuCPRTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuCPRTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuCPRTxt.Location = new System.Drawing.Point(25, 378);
            this.cuCPRTxt.Name = "cuCPRTxt";
            this.cuCPRTxt.Size = new System.Drawing.Size(283, 40);
            this.cuCPRTxt.TabIndex = 126;
            // 
            // cuTickitClassDrop
            // 
            this.cuTickitClassDrop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuTickitClassDrop.FormattingEnabled = true;
            this.cuTickitClassDrop.Items.AddRange(new object[] {
            "Morning",
            "Night"});
            this.cuTickitClassDrop.Location = new System.Drawing.Point(342, 384);
            this.cuTickitClassDrop.Name = "cuTickitClassDrop";
            this.cuTickitClassDrop.Size = new System.Drawing.Size(271, 32);
            this.cuTickitClassDrop.TabIndex = 124;
            // 
            // atErrorLbl
            // 
            this.atErrorLbl.AutoSize = true;
            this.atErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.atErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.atErrorLbl.Location = new System.Drawing.Point(24, 540);
            this.atErrorLbl.Name = "atErrorLbl";
            this.atErrorLbl.Size = new System.Drawing.Size(206, 33);
            this.atErrorLbl.TabIndex = 123;
            this.atErrorLbl.Text = "Error: Please fix..";
            this.atErrorLbl.Visible = false;
            // 
            // cuCancelBtn
            // 
            this.cuCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.cuCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cuCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cuCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuCancelBtn.ForeColor = System.Drawing.Color.White;
            this.cuCancelBtn.Location = new System.Drawing.Point(170, 435);
            this.cuCancelBtn.Name = "cuCancelBtn";
            this.cuCancelBtn.Size = new System.Drawing.Size(139, 43);
            this.cuCancelBtn.TabIndex = 122;
            this.cuCancelBtn.Text = "Cancel";
            this.cuCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cuCancelBtn.UseVisualStyleBackColor = false;
            this.cuCancelBtn.Click += new System.EventHandler(this.cuCancelBtn_Click);
            // 
            // cuCreateUserBtn
            // 
            this.cuCreateUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.cuCreateUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cuCreateUserBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cuCreateUserBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuCreateUserBtn.ForeColor = System.Drawing.Color.White;
            this.cuCreateUserBtn.Location = new System.Drawing.Point(25, 435);
            this.cuCreateUserBtn.Name = "cuCreateUserBtn";
            this.cuCreateUserBtn.Size = new System.Drawing.Size(139, 43);
            this.cuCreateUserBtn.TabIndex = 121;
            this.cuCreateUserBtn.Text = "Add Traveller";
            this.cuCreateUserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cuCreateUserBtn.UseVisualStyleBackColor = false;
            this.cuCreateUserBtn.Click += new System.EventHandler(this.cuCreateUserBtn_Click);
            // 
            // cuFnameTxt
            // 
            this.cuFnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuFnameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuFnameTxt.Location = new System.Drawing.Point(25, 204);
            this.cuFnameTxt.Name = "cuFnameTxt";
            this.cuFnameTxt.Size = new System.Drawing.Size(281, 40);
            this.cuFnameTxt.TabIndex = 110;
            // 
            // cuLnameTxt
            // 
            this.cuLnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuLnameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuLnameTxt.Location = new System.Drawing.Point(342, 204);
            this.cuLnameTxt.Name = "cuLnameTxt";
            this.cuLnameTxt.Size = new System.Drawing.Size(271, 40);
            this.cuLnameTxt.TabIndex = 111;
            // 
            // cuPhoneTxt
            // 
            this.cuPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuPhoneTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuPhoneTxt.Location = new System.Drawing.Point(342, 291);
            this.cuPhoneTxt.Name = "cuPhoneTxt";
            this.cuPhoneTxt.Size = new System.Drawing.Size(271, 40);
            this.cuPhoneTxt.TabIndex = 113;
            // 
            // cuEmailTxt
            // 
            this.cuEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuEmailTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuEmailTxt.Location = new System.Drawing.Point(25, 291);
            this.cuEmailTxt.Name = "cuEmailTxt";
            this.cuEmailTxt.Size = new System.Drawing.Size(283, 40);
            this.cuEmailTxt.TabIndex = 112;
            // 
            // payment
            // 
            this.payment.BackColor = System.Drawing.Color.Gainsboro;
            this.payment.Controls.Add(this.paymentErrorLbl);
            this.payment.Controls.Add(label51);
            this.payment.Controls.Add(this.ppNewTravellersNumTxt);
            this.payment.Controls.Add(this.ppTotaLbl);
            this.payment.Controls.Add(label49);
            this.payment.Controls.Add(label48);
            this.payment.Controls.Add(this.ppDatePick);
            this.payment.Controls.Add(this.ppCancelBtn);
            this.payment.Controls.Add(this.ppPayBtn);
            this.payment.Controls.Add(label39);
            this.payment.Controls.Add(this.ppCvvTxt);
            this.payment.Controls.Add(label40);
            this.payment.Controls.Add(this.ppNameCardTxt);
            this.payment.Controls.Add(label41);
            this.payment.Controls.Add(label42);
            this.payment.Controls.Add(this.ppCardNumTxt);
            this.payment.Controls.Add(this.pictureBox3);
            this.payment.Controls.Add(this.pictureBox2);
            this.payment.Controls.Add(this.pictureBox1);
            this.payment.Controls.Add(this.ppAeRadio);
            this.payment.Controls.Add(this.ppVisaRadio);
            this.payment.Controls.Add(this.ppCcRadio);
            this.payment.Controls.Add(label43);
            this.payment.Controls.Add(label53);
            this.payment.Controls.Add(this.ppFlightNumTxt);
            this.payment.Controls.Add(label54);
            this.payment.Location = new System.Drawing.Point(25, 4);
            this.payment.Name = "payment";
            this.payment.Padding = new System.Windows.Forms.Padding(3);
            this.payment.Size = new System.Drawing.Size(753, 720);
            this.payment.TabIndex = 7;
            this.payment.Text = "Payment";
            // 
            // paymentErrorLbl
            // 
            this.paymentErrorLbl.AutoSize = true;
            this.paymentErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.paymentErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.paymentErrorLbl.Location = new System.Drawing.Point(343, 655);
            this.paymentErrorLbl.Name = "paymentErrorLbl";
            this.paymentErrorLbl.Size = new System.Drawing.Size(206, 33);
            this.paymentErrorLbl.TabIndex = 84;
            this.paymentErrorLbl.Text = "Error: Please fix..";
            this.paymentErrorLbl.Visible = false;
            // 
            // ppNewTravellersNumTxt
            // 
            this.ppNewTravellersNumTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.ppNewTravellersNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ppNewTravellersNumTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppNewTravellersNumTxt.Location = new System.Drawing.Point(351, 152);
            this.ppNewTravellersNumTxt.Name = "ppNewTravellersNumTxt";
            this.ppNewTravellersNumTxt.ReadOnly = true;
            this.ppNewTravellersNumTxt.Size = new System.Drawing.Size(246, 33);
            this.ppNewTravellersNumTxt.TabIndex = 82;
            this.ppNewTravellersNumTxt.Text = "123";
            // 
            // ppTotaLbl
            // 
            this.ppTotaLbl.AutoSize = true;
            this.ppTotaLbl.BackColor = System.Drawing.Color.Transparent;
            this.ppTotaLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppTotaLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ppTotaLbl.Location = new System.Drawing.Point(142, 594);
            this.ppTotaLbl.Name = "ppTotaLbl";
            this.ppTotaLbl.Size = new System.Drawing.Size(64, 39);
            this.ppTotaLbl.TabIndex = 81;
            this.ppTotaLbl.Text = "1500";
            this.ppTotaLbl.UseCompatibleTextRendering = true;
            // 
            // ppDatePick
            // 
            this.ppDatePick.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.ppDatePick.Location = new System.Drawing.Point(303, 362);
            this.ppDatePick.Name = "ppDatePick";
            this.ppDatePick.Size = new System.Drawing.Size(391, 40);
            this.ppDatePick.TabIndex = 78;
            // 
            // ppCancelBtn
            // 
            this.ppCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.ppCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ppCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ppCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppCancelBtn.ForeColor = System.Drawing.Color.White;
            this.ppCancelBtn.Location = new System.Drawing.Point(169, 655);
            this.ppCancelBtn.Name = "ppCancelBtn";
            this.ppCancelBtn.Size = new System.Drawing.Size(139, 43);
            this.ppCancelBtn.TabIndex = 77;
            this.ppCancelBtn.Text = "Cancel";
            this.ppCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ppCancelBtn.UseVisualStyleBackColor = false;
            this.ppCancelBtn.Click += new System.EventHandler(this.ppCancelBtn_Click);
            // 
            // ppPayBtn
            // 
            this.ppPayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(201)))), ((int)(((byte)(5)))));
            this.ppPayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ppPayBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ppPayBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppPayBtn.ForeColor = System.Drawing.Color.White;
            this.ppPayBtn.Location = new System.Drawing.Point(24, 655);
            this.ppPayBtn.Name = "ppPayBtn";
            this.ppPayBtn.Size = new System.Drawing.Size(139, 43);
            this.ppPayBtn.TabIndex = 76;
            this.ppPayBtn.Text = "Pay";
            this.ppPayBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ppPayBtn.UseVisualStyleBackColor = false;
            this.ppPayBtn.Click += new System.EventHandler(this.ppPayBtn_Click);
            // 
            // ppCvvTxt
            // 
            this.ppCvvTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ppCvvTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppCvvTxt.Location = new System.Drawing.Point(303, 446);
            this.ppCvvTxt.Name = "ppCvvTxt";
            this.ppCvvTxt.Size = new System.Drawing.Size(391, 40);
            this.ppCvvTxt.TabIndex = 74;
            // 
            // ppNameCardTxt
            // 
            this.ppNameCardTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ppNameCardTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppNameCardTxt.Location = new System.Drawing.Point(24, 447);
            this.ppNameCardTxt.Name = "ppNameCardTxt";
            this.ppNameCardTxt.Size = new System.Drawing.Size(246, 40);
            this.ppNameCardTxt.TabIndex = 72;
            // 
            // ppCardNumTxt
            // 
            this.ppCardNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ppCardNumTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppCardNumTxt.Location = new System.Drawing.Point(24, 362);
            this.ppCardNumTxt.Name = "ppCardNumTxt";
            this.ppCardNumTxt.Size = new System.Drawing.Size(246, 40);
            this.ppCardNumTxt.TabIndex = 68;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HappyJourneyAirline.Properties.Resources.AmericanExpress;
            this.pictureBox3.Location = new System.Drawing.Point(276, 234);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 67;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HappyJourneyAirline.Properties.Resources.Visa;
            this.pictureBox2.Location = new System.Drawing.Point(157, 234);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HappyJourneyAirline.Properties.Resources.CreditCard;
            this.pictureBox1.Location = new System.Drawing.Point(44, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // ppAeRadio
            // 
            this.ppAeRadio.AutoSize = true;
            this.ppAeRadio.Location = new System.Drawing.Point(256, 260);
            this.ppAeRadio.Name = "ppAeRadio";
            this.ppAeRadio.Size = new System.Drawing.Size(17, 16);
            this.ppAeRadio.TabIndex = 64;
            this.ppAeRadio.TabStop = true;
            this.ppAeRadio.UseVisualStyleBackColor = true;
            // 
            // ppVisaRadio
            // 
            this.ppVisaRadio.AutoSize = true;
            this.ppVisaRadio.Location = new System.Drawing.Point(137, 260);
            this.ppVisaRadio.Name = "ppVisaRadio";
            this.ppVisaRadio.Size = new System.Drawing.Size(17, 16);
            this.ppVisaRadio.TabIndex = 63;
            this.ppVisaRadio.TabStop = true;
            this.ppVisaRadio.UseVisualStyleBackColor = true;
            // 
            // ppCcRadio
            // 
            this.ppCcRadio.AutoSize = true;
            this.ppCcRadio.Location = new System.Drawing.Point(24, 260);
            this.ppCcRadio.Name = "ppCcRadio";
            this.ppCcRadio.Size = new System.Drawing.Size(17, 16);
            this.ppCcRadio.TabIndex = 62;
            this.ppCcRadio.TabStop = true;
            this.ppCcRadio.UseVisualStyleBackColor = true;
            // 
            // ppFlightNumTxt
            // 
            this.ppFlightNumTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.ppFlightNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ppFlightNumTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppFlightNumTxt.Location = new System.Drawing.Point(24, 152);
            this.ppFlightNumTxt.Name = "ppFlightNumTxt";
            this.ppFlightNumTxt.ReadOnly = true;
            this.ppFlightNumTxt.Size = new System.Drawing.Size(246, 33);
            this.ppFlightNumTxt.TabIndex = 55;
            this.ppFlightNumTxt.Text = "123";
            // 
            // EmployerTabs
            // 
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.panel1);
            this.Name = "EmployerTabs";
            this.Size = new System.Drawing.Size(921, 728);
            travellerFlightsTab.ResumeLayout(false);
            travellerFlightsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridflightsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notificationTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTab)).EndInit();
            this.flightDetails.ResumeLayout(false);
            this.flightDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fdTravellersDataGridView)).EndInit();
            this.bookingDetailsTab.ResumeLayout(false);
            this.bookingDetailsTab.PerformLayout();
            this.travellerNotificationTab.ResumeLayout(false);
            this.travellerNotificationTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotification)).EndInit();
            this.travellerSettingsTab.ResumeLayout(false);
            this.travellerSettingsTab.PerformLayout();
            this.travellerBookingsTab.ResumeLayout(false);
            this.travellerBookingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTable)).EndInit();
            this.tabController.ResumeLayout(false);
            this.addTraveler.ResumeLayout(false);
            this.addTraveler.PerformLayout();
            this.payment.ResumeLayout(false);
            this.payment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #region Navigation
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


                airportList = Airport.GetAllAirports();


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
            catch
            {

            }


        }

        private void bookingTab_Click(object sender, EventArgs e)
        {
            
            tabController.SelectTab(1);
            defultIcons();
            bookingTab.Image = global::HappyJourneyAirline.Properties.Resources.Bookings_Active;

            loadBookingTable();
        }

        private void loadBookingTable()
        {
            bookingTable.Rows.Clear();
            // display Booking list
            List<Ticket> tickets = new List<Ticket>();

            tickets = Ticket.GetTicketsByAgencyId((int)AuthService.GetCurrentUserId());
            HashSet<long> flightIds = new HashSet<long>();
            tickets.ForEach( T => { flightIds.Add(T.FlightID); });

            foreach (long f_id in flightIds)
            {
                Flight flight = Flight.GetFlightById(f_id);
                Airport source = Airport.GetAirportById(flight.SourceAirportID);
                Airport destination = Airport.GetAirportById(flight.DestinationAirportID);
                bookingTable.Rows.Add("Edit", flight.Id, source.Name, destination.Name, flight.DepartureTimestamp);
            }
        }

        private void settingTab_Click(object sender, EventArgs e)
        {
            tabController.SelectTab(2);
            defultIcons();
            settingTab.Image = global::HappyJourneyAirline.Properties.Resources.Settings_Active;

            long id = AuthService.GetCurrentUserId();
            User currentUser = User.GetUserById(id);

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
            User currentUser = User.GetUserById(id);

            setUsernameTxt.Text = currentUser.Username;
            setFirstNameTxt.Text = currentUser.FirstName;
            setLastNameTxt.Text = currentUser.LastName;
            setEmailTxt.Text = currentUser.Email;
            setPasswordTxt.Text = currentUser.Password;
            setPhoneTxt.Text = currentUser.PhoneNumber;

        }

        private void bdBackBtn_Click(object sender, EventArgs e)
        {
            tabController.SelectTab(5);
        }

        private void fdCancelBtn_Click(object sender, EventArgs e)
        {
            tabController.SelectTab(previosTab);
            defultIcons();
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights_Active;
            tempUsers.Clear();
        }

        private void travellerFlightsTab_Paint(object sender, PaintEventArgs e)
        {
            flightDataLoad();
        }
        #endregion Navigation

        #region Setings
        private void setSaveChanesBtn_Click(object sender, EventArgs e)
        {

            long id = AuthService.GetCurrentUserId();
            User currentUser = User.GetUserById(id);

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


                // email validation
                string txt = setEmailTxt.Text.Trim().ToLower();
                string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                if (!Regex.IsMatch(txt, emailPattern))
                {
                    setErrorLbl.Text = "Error: Invalid email.";
                    setErrorLbl.Visible = true;
                    return;
                }


                // phone Number validation
                string pattern = @"^\d{8}$";
                Regex regex = new Regex(pattern);

                if (!regex.IsMatch(setPhoneTxt.Text.Trim()))
                {
                    setErrorLbl.Text = "Error: Phone number must contain exactly 8 digits.";
                    setErrorLbl.Visible = true;
                    return;
                }



                // Username availability check
                if (User.GetAllUsers().Any(user => user.Username == setUsernameTxt.Text && user.Username != currentUser.Username))
                {
                    setErrorLbl.Text = "Error: Username is not available.";
                    setErrorLbl.Visible = true;
                    return;
                }

                setErrorLbl.Text = "";

                currentUser.PhoneNumber = setPhoneTxt.Text;
                currentUser.Username = setUsernameTxt.Text;
                currentUser.Email = setEmailTxt.Text;
                currentUser.Password = setPasswordTxt.Text;
                currentUser.FirstName = setFirstNameTxt.Text;
                currentUser.LastName = setLastNameTxt.Text;
                User.UpdateUser(currentUser);

                MessageBox.Show("User Info Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void setDeleteBtn_Click(object sender, EventArgs e)
        {
            long id = AuthService.GetCurrentUserId();
            User currentUser = User.GetUserById(id);

            DialogResult result = MessageBox.Show(
        "Warning! Are you sure you want to delete this user? This action cannot be undone.",
        "Delete Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                if (User.DeleteUser(currentUser.Id))
                {
                    MessageBox.Show("User has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AuthService.LogoutCurrentUser();
                    appTabs.SelectTab(0);
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
        #endregion Setings

        #region Flights
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
                string query = @"SELECT 
                    'View' as 'View', 
                    f.Id AS 'Flight ID',
                    sa.name AS 'Source Airport Name', 
                    da.name AS 'Destination Airport Name',
                    f.departureTimestamp AS 'Departure Timestamp', 
                    f.arrivalTimestamp AS 'Arrival Timestamp', 
                    fs.name AS 'Flight Status', 
                    f.planeID AS 'Plane ID',
                    f.BasePrice AS 'Base Price'
            FROM flights f
            LEFT JOIN flight_statuses fs ON f.flightStatusID = fs.Id
            LEFT JOIN airports sa ON f.sourceAirportID = sa.Id
            LEFT JOIN airports da ON f.destinationAirportID = da.Id
            WHERE fs.name IN ('Scheduled', 'Delayed')"; // Always true to simplify adding conditions

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
                        else
                        {
                            MessageBox.Show("Value must be selected in the Time filed", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                    }

                }

                try
                {
                    // Assign final query to command
                    cmd.CommandText = query;

                    // Execute the query and bind the results to the grid
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    int availableTickets = 0;
                    // Check ticket availability and add a column for availability
                    dt.Columns.Add("Available Tickets", typeof(string));
                    foreach (DataRow row in dt.Rows)
                    {
                        int planeId = Convert.ToInt32(row["Plane ID"]);
                        int flightId = Convert.ToInt32(row["Flight ID"]);
                        int capacity = Plane.GetPlaneById(planeId).Capacity;
                        int ticketCount = Ticket.GetTicketsByFlightId(flightId).Count;

                        // Add availability info
                        availableTickets = capacity - ticketCount;
                        row["Available Tickets"] = availableTickets;
                    }



                    gridflightsData.DataSource = dt;
                    DataGridViewColumn viewColumn = gridflightsData.Columns[0];
                    viewColumn.DefaultCellStyle = gridflightsData.Columns[2].DefaultCellStyle.Clone();
                    viewColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    viewColumn.DefaultCellStyle.ForeColor = Color.Blue;
                }
                catch
                {

                }
            }
        }

        private void flightDataLoad()
        {

            try
            {

                List<Airport> airportList = new List<Airport>();
                Airport handeler = new Airport();


                airportList = Airport.GetAllAirports();
                List<Airport> airportList2 = Airport.GetAllAirports();

                if (airportList == null || airportList.Count == 0)
                {
                    Console.WriteLine("No airports found.");
                    return;
                }
                else
                {
                    Airport allOption = new Airport
                    {
                        Id = 0,
                        Name = "All"
                    };


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
                cmd.CommandText = $"SELECT " +
                    $"'View' as 'View', " +
                    $"f.Id AS 'Flight ID', " +
                    $"sa.name AS 'Source Airport Name', " +
                    $"da.name AS 'Destination Airport Name', " +
                    $"f.departureTimestamp AS 'Departure Timestamp', " +
                    $"f.arrivalTimestamp AS 'Arrival Timestamp', " +
                    $"fs.name AS 'Flight Status', " +
                    $"f.planeID AS 'Plane ID', " +
                    $"f.BasePrice AS 'Base Price'" +
                    $"FROM flights f " +
                    $"LEFT JOIN flight_statuses fs ON f.flightStatusID = fs.Id " +
                    $"LEFT JOIN airports sa ON f.sourceAirportID = sa.Id " +
                    $"LEFT JOIN airports da ON f.destinationAirportID = da.Id " +
                    $"WHERE fs.name IN ('Scheduled', 'Delayed')";
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);


                int availableTickets = 0;
                // Check ticket availability and add a column for availability
                dt.Columns.Add("Available Tickets", typeof(string));
                foreach (DataRow row in dt.Rows)
                {
                    int planeId = Convert.ToInt32(row["Plane ID"]);
                    int flightId = Convert.ToInt32(row["Flight ID"]);
                    int capacity = Plane.GetPlaneById(planeId).Capacity;
                    int ticketCount = Ticket.GetTicketsByFlightId(flightId).Count;

                    // Add availability info
                    availableTickets = capacity - ticketCount;
                    row["Available Tickets"] = availableTickets;
                }




                gridflightsData.DataSource = dt;

                DataGridViewColumn viewColumn = gridflightsData.Columns[0];
                viewColumn.DefaultCellStyle = gridflightsData.Columns[2].DefaultCellStyle.Clone();
                viewColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                viewColumn.DefaultCellStyle.ForeColor = Color.Blue;
            }
            catch
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

        private void gridflightsData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                previosTab = 0;
                selectedFlight = Flight.GetFlightById((int)(gridflightsData.Rows[e.RowIndex].Cells[1].Value));
                sutupFlightDetails();
                cuLoadTravleres();
                tabController.SelectTab(5);
            }
        }
        #endregion Flights


        #region Flight Details
        private void sutupFlightDetails()
        {
            fdFlightNumTxt.Text = $"{selectedFlight.Id}";

            Airport depAirport = Airport.GetAirportById(selectedFlight.SourceAirportID);
            Airport destAirport = Airport.GetAirportById(selectedFlight.DestinationAirportID);

            City depCity = City.GetCityById(depAirport.CityId);
            City destCity = City.GetCityById(destAirport.CityId);

            Country depCountry = Country.GetCountryById(depCity.CountryId);
            Country destCountry = Country.GetCountryById(destCity.CountryId);

            fdArrTxt.Text = destAirport.Name;
            fdDepTxt.Text = depAirport.Name;

            fdFromTxt.Text = $"{depCity.Name} ({depCountry.Name})";
            fdToTxt.Text = $"{destCity.Name} ({destCountry.Name})";

            fdArrTimeTxt.Text = $"{selectedFlight.ArrivalTimestamp}";
            fdDepTimeTxt.Text = $"{selectedFlight.DepartureTimestamp}";

            //long id = AuthService.GetCurrentUserId();
            //fdTravellersDataGridView.DataSource = new BindingList<User>(Flight.GetTravellersForFlightByAgencyID(id, selectedFlight.Id));

            //fdTravellersDataGridView.Columns["Id"].HeaderText = "Traveller ID";
            //fdTravellersDataGridView.Columns["FirstName"].HeaderText = "First Name";
            //fdTravellersDataGridView.Columns["LastName"].HeaderText = "Last Name";
            //fdTravellersDataGridView.Columns["PhoneNumber"].HeaderText = "Phone Number";
            //fdTravellersDataGridView.Columns["Cpr"].HeaderText = "CPR";


            //fdTravellersDataGridView.Columns["Username"].Visible = false;
            //fdTravellersDataGridView.Columns["Password"].Visible = false;
            //fdTravellersDataGridView.Columns["Type"].Visible = false;
            //fdTravellersDataGridView.Columns["AgencyID"].Visible = false;
            //fdTravellersDataGridView.Columns["CompanyName"].Visible = false;
        }
        private void fdTravellersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (!string.IsNullOrEmpty(fdTravellersDataGridView.SelectedCells[0].Value as string))
                {
                    selectedTraveller = fdTravellersDataGridView.Rows[e.RowIndex].DataBoundItem as User;
                    previosTab = 5;
                    setupBookingDetails();
                    tabController.SelectTab(4);
                }

            }
        }
        private void fdTravellersDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow row in fdTravellersDataGridView.Rows)
            {
                User u = allUsers[i];
                i++;

                if (tempUsers.Contains(u))
                {
                    continue;
                }

                row.Cells[0].Value = "Edit";
            }

        }
        private void fdDeleteTravellerBtn_Click(object sender, EventArgs e)
        {
            // Check if a single row or cell is selected
            if (fdTravellersDataGridView.SelectedRows.Count == 1 || fdTravellersDataGridView.SelectedCells.Count > 0)
            {
                // Identify the row based on the selected cell if no full row is selected
                DataGridViewRow selectedRow;
                if (fdTravellersDataGridView.SelectedRows.Count == 1)
                {
                    selectedRow = fdTravellersDataGridView.SelectedRows[0];
                }
                else
                {
                    int rowIndex = fdTravellersDataGridView.SelectedCells[0].RowIndex;
                    selectedRow = fdTravellersDataGridView.Rows[rowIndex];
                }

                int userId = Convert.ToInt32(selectedRow.Cells[1].Value);
                if (userId != null)
                {
                    // Ask for confirmation before deleting
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete the traveler with ID {userId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Remove the selected row
                        if (userId != 0)
                        {
                            User.DeleteUser(userId);
                            foreach (User user in allUsers)
                            {
                                if (user.Id == userId)
                                {
                                    sysUsers.Remove(user);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            foreach (User user in tempUsers)
                            {
                                if (user.FirstName == selectedRow.Cells[2].Value && user.LastName == selectedRow.Cells[3].Value)
                                {
                                    tempUsers.Remove(user);
                                    break;
                                }
                            }

                        }
                        cuLoadTravleres();
                    }
                }
                else
                {
                    MessageBox.Show("User ID not found in the selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // No row or cell selected; show an alert
                MessageBox.Show("Please select a row or a cell to delete.", "Delete Traveler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion Flight details

        #region Notification 
        private void travellerNotificationTab_Paint(object sender, PaintEventArgs e)
        {

            dataGridViewNotification.RowTemplate.Height = 60; // Sets all rows to 40 pixels

            List<Notification> list = Notification.GetNotificationsByUserId(AuthService.GetCurrentUserId());

            dataGridViewNotification.DataSource = list;

            dataGridViewNotification.AutoGenerateColumns = false;

            // Clear existing columns
            dataGridViewNotification.Columns.Clear();

            // Add the "title" column
            dataGridViewNotification.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "title",
                HeaderText = "Title",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            // Add the "description" column
            dataGridViewNotification.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "description",
                HeaderText = "Description",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Bind the data
            dataGridViewNotification.DataSource = list;
        }

        private void vnShowSelectedBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedObject = dataGridViewNotification.SelectedCells[0].OwningRow.DataBoundItem as Notification;

                if (selectedObject != null)
                {
                    MessageBox.Show(selectedObject.Description, selectedObject.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch { }
        }

        #endregion Notification

        #region Create Traveller
        private void fdAddTravelerBtn_Click(object sender, EventArgs e)
        {
            cuFnameTxt.Text = "";
            cuLnameTxt.Text = "";
            cuEmailTxt.Text = "";
            cuPhoneTxt.Text = "";
            cuCPRTxt.Text = "";
            atErrorLbl.Visible = false;
            cuTickitClassDrop.DataSource = TicketClass.GetAllTicketClasses();
            cuTickitClassDrop.DisplayMember = "Name";
            sutupFlightDetails();
            tabController.SelectTab(6);
        }

        private void cuCreateUserBtn_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Type = "traveller";

            // first Name validation
            if (string.IsNullOrEmpty(cuFnameTxt.Text.Trim()))
            {
                atErrorLbl.Text = "Error: First name cannot be empty";
                atErrorLbl.Visible = true;
                return;
            }
            else
            {
                user.FirstName = cuFnameTxt.Text.Trim();
            }

            // last Name validation
            if (string.IsNullOrEmpty(cuLnameTxt.Text.Trim()))
            {
                atErrorLbl.Text = "Error: Last name cannot be empty";
                atErrorLbl.Visible = true;
                return;
            }
            else
            {
                user.LastName = cuLnameTxt.Text.Trim();
            }
            
            // email validation
            string txt = cuEmailTxt.Text.Trim().ToLower();
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(txt, emailPattern))
            {
                atErrorLbl.Text = "Error: Invalid email.";
                atErrorLbl.Visible = true;
                return;
            }
            else
            {
                user.Email = txt;
            }


            // phone Number validation
            string pattern = @"^\+?(\d{1,4})?[\s.-]?\(?\d{1,4}\)?[\s.-]?\d{1,4}[\s.-]?\d{1,4}$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(cuPhoneTxt.Text.Trim()))
            {
                atErrorLbl.Text = "Error: Invalid phone number";
                atErrorLbl.Visible = true;
                return;
            }
            else
            {
                user.PhoneNumber = cuPhoneTxt.Text.Trim();
            }

            // cpr Number validation
            if (!regex.IsMatch(cuCPRTxt.Text.Trim()))
            {
                atErrorLbl.Text = "Error: Invalid CPR number";
                atErrorLbl.Visible = true;
                return;
            }
            else
            {
                user.Cpr = cuCPRTxt.Text.Trim();
            }

            user.AgencyID = AuthService.GetCurrentUserId();
            user.Username = null;

            tempUsers.Add(user);
            tempUsersTicketClass.Add(cuTickitClassDrop.SelectedItem as TicketClass);
            cuLoadTravleres();
            tabController.SelectTab(5);
        }

        private void cuLoadTravleres()
        {

            sysUsers.Clear();


            sysUsers = new BindingList<User>( Flight.GetTravellersForFlightByAgencyID(AuthService.GetCurrentUserId(), selectedFlight.Id));

            allUsers.Clear();

            foreach (User user in sysUsers)
            {
                allUsers.Add(user);
            }

            foreach (User user in tempUsers)
            {
                allUsers.Add(user);
            }
            fdTravellersDataGridView.DataSource = allUsers;

                fdTravellersDataGridView.DataSource = allUsers;

                
            
            fdTravellersDataGridView.Columns["Id"].HeaderText = "Traveller ID";
            fdTravellersDataGridView.Columns["FirstName"].HeaderText = "First Name";
            fdTravellersDataGridView.Columns["LastName"].HeaderText = "Last Name";
            fdTravellersDataGridView.Columns["PhoneNumber"].HeaderText = "Phone Number";
            fdTravellersDataGridView.Columns["Cpr"].HeaderText = "CPR";


            fdTravellersDataGridView.Columns["Username"].Visible = false;
            fdTravellersDataGridView.Columns["Password"].Visible = false;
            fdTravellersDataGridView.Columns["Type"].Visible = false;
            fdTravellersDataGridView.Columns["AgencyID"].Visible = false;
            fdTravellersDataGridView.Columns["CompanyName"].Visible = false;

        }
        private void cuCancelBtn_Click(object sender, EventArgs e)
        {
            tabController.SelectTab(5);
        }

        #endregion Create Traveller

        #region Booking
        private void bookingTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                int Ticketid = Convert.ToInt32(bookingTable.Rows[e.RowIndex].Cells[0].Value);

                Ticket ticket = Ticket.GetTicketById(Ticketid);
                Flight flight = Flight.GetFlightById(ticket.FlightID);

                string dep = flight.DepartureTimestamp.ToString();
                string arr = flight.ArrivalTimestamp.ToString();

                Airport source = Airport.GetAirportById(flight.SourceAirportID);
                Airport destination = Airport.GetAirportById(flight.DestinationAirportID);

                City sourceCity = City.GetCityById(source.CityId);
                City destinationCity = City.GetCityById(destination.CityId);
                Country sourceCountry = Country.GetCountryById(sourceCity.CountryId);
                Country destinationCountry = Country.GetCountryById(destinationCity.CountryId);

                bdIDTxt.Text = ticket.Id.ToString();
                bdFlightNumTxt.Text = ticket.FlightID.ToString();
                bdDepTimeTxt.Text = dep;
                bdArrTimeTxt.Text = arr;
                bdFromTxt.Text = sourceCity.Name.ToString() + " (" + sourceCountry.Name.ToString() + ")";
                bdToTxt.Text = destinationCity.Name.ToString() + " (" + destinationCountry.Name.ToString() + ")";
                bdDepTxt.Text = source.Name.ToString();
                bdArrTxt.Text = destination.Name.ToString();
                tabController.SelectTab(5);
            }
        }


        #endregion Booking

        #region Booking Details

       private void  setupBookingDetails()
        {
            bdFlightNumTxt.Text = selectedFlight.Id.ToString();
            bdDepTimeTxt.Text = fdDepTimeTxt.Text;
            bdArrTimeTxt.Text = fdArrTimeTxt.Text;
            bdFromTxt.Text = fdFromTxt.Text;
            bdToTxt.Text = fdToTxt.Text;
            bdDepTxt.Text = fdDepTxt.Text;
            bdArrTxt.Text = fdArrTxt.Text;

            selectedTicket = Ticket.GetTicketByFlightAndUserID(selectedFlight.Id, selectedTraveller.Id);

            bdIDTxt.Text = selectedTicket.Id.ToString();
            bdFNameTxt.Text = selectedTraveller.FirstName;
            bdLNameTxt.Text = selectedTraveller.LastName;
            bdEmailTxt.Text = selectedTraveller.Email;
            bdPhoneNumberTxt.Text = selectedTraveller.PhoneNumber;
            bdCPRTxt.Text = selectedTraveller.Cpr;
            bdSeatNumTxt.Text = selectedTicket.Seat;
            bdTicketClassNameTxt.Text = TicketClass.GetTicketClassById(selectedTicket.TicketClassID).Name;
            bdTotalPriceTxt.Text = $"{Payment.GetPaymentById(selectedTicket.PaymentID).Amount}";
        }
        private void bdCancelBtn_Click(object sender, EventArgs e)
        {
            // Confirm deletion with the user
            var confirmResult = MessageBox.Show(
                $"Are you sure you want to delete Ticket ID {selectedTicket.Id}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Attempt to delete the ticket
                    bool isDeleted = Ticket.DeleteTicket(selectedTicket.Id);

                    if (isDeleted)
                    {
                        MessageBox.Show("Ticket deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cuLoadTravleres();
                        tabController.SelectTab(5);
                    }
                    else
                    {
                        MessageBox.Show("Ticket could not be deleted. Please check if the Ticket ID is correct.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Handle any unexpected errors
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Deletion cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion Booking Details


        private DataGridViewTextBoxColumn AddEditColumn()
        {
            DataGridViewTextBoxColumn editColumn = new DataGridViewTextBoxColumn
            {
                Name = "EditColumn",
                HeaderText = "Edit",
                ReadOnly = true,
                DefaultCellStyle = fdTravellersDataGridView.Columns[2].DefaultCellStyle.Clone()
            };
            editColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            editColumn.DefaultCellStyle.ForeColor = Color.Blue;
            return editColumn;
        }




        #region Payment
        private void fdPayAllBtn_Click(object sender, EventArgs e)
        {
            if (tempUsers.Count == 0)
            {
                MessageBox.Show("All registered travellers are paid for already", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Populate the booking form with the selected flight's details
            ppFlightNumTxt.Text = $"{selectedFlight.Id}";
            ppNewTravellersNumTxt.Text = $"{tempUsers.Count}";

            decimal totalPrice = 0;
            foreach (TicketClass tc in tempUsersTicketClass)
            {
                totalPrice += selectedFlight.BasePrice + tc.ExtraPrice;
            }

            ppTotaLbl.Text = $"{totalPrice}";

            // Clear the payment input fields
            ppCardNumTxt.Text = "";
            ppNameCardTxt.Text = "";
            ppCvvTxt.Text = "";

            // Hide any payment error messages
            paymentErrorLbl.Visible = false;

            // Navigate to the payment tab
            tabController.SelectTab(7);
        }

        private void ppPayBtn_Click(object sender, EventArgs e)
        {
            paymentErrorLbl.Visible = false;
            // Validate input
            if ( ppCardNumTxt.Text == "" || ppNameCardTxt.Text == "" || ppCvvTxt.Text == "")
            {
                paymentErrorLbl.Visible = true;
                paymentErrorLbl.Text = "Please fill all the fields";
                return;
            }

            // Parse flight ID
            int flightId = Convert.ToInt32(ppFlightNumTxt.Text);


            // Determine selected payment method
            int paymentMethod;

            if (ppCcRadio.Checked)
            {
                paymentMethod = 1; // MasterCard
            }
            else if (ppVisaRadio.Checked)
            {
                paymentMethod = 2; // Visa
            }
            else if (ppAeRadio.Checked)
            {
                paymentMethod = 3; // American Express
            }
            else
            {
                paymentErrorLbl.Visible = true;
                paymentErrorLbl.Text = "Please select a Payment Method.";
                return;
            }

            for (int i = 0; i < tempUsers.Count; i++)
            {
                long id = User.AddUser(tempUsers[i]);

                if (id == -1)
                {
                    MessageBox.Show("Problem saving to database user, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Generate a random seat assignment
                string assignedSeat = GenerateRandomSeat();

                // Create a new Payment object
                Payment payment = new Payment
                {
                    Amount = selectedFlight.BasePrice + tempUsersTicketClass[i].ExtraPrice,
                    Date = DateTime.Now,
                    PaymentStatusID = 1, // Paid
                    PaymentMethodID = paymentMethod
                };
                int p_id = Payment.AddPayment(payment);
                if (p_id == -1)
                {
                    MessageBox.Show("Problem saving to database payment, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a new Ticket object
                Ticket ticket = new Ticket
                {
                    FlightID = selectedFlight.Id,
                    UserID = id,
                    Seat = assignedSeat,
                    TicketClassID = tempUsersTicketClass[i].Id,
                    TicketStatusID = 1, // Confirmed
                    PaymentID = p_id, // Add payment and get its ID
                    AgencyID = AuthService.GetCurrentUserId()
                };

                // Insert the ticket into the database
                int t_id = Ticket.AddTicket(ticket);

                if (t_id == -1)
                {
                    MessageBox.Show("Problem saving to database ticket, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            // Display success message to the user
            MessageBox.Show($"Tickets purchased successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Return to the booking tab
            defultIcons();
            bookingTab.Image = global::HappyJourneyAirline.Properties.Resources.Bookings_Active;
            loadBookingTable();
            tempUsers.Clear();
            tempUsersTicketClass.Clear();
            cuLoadTravleres();
            tabController.SelectTab(5);
        }


        private string GenerateRandomSeat()
        {
            Random random = new Random();
            int row = random.Next(1, 31); // Random row number (1-30)
            char column = (char)random.Next('A', 'F' + 1); // Random column letter (A-F)
            return $"{row}{column}";
        }

        private void ppCancelBtn_Click(object sender, EventArgs e)
        {
            cuLoadTravleres();
            tabController.SelectTab(5); // return to the flight tab 
        }
        #endregion Payment

        private void bookingTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) {
                previosTab = 1;
selectedFlight = Flight.GetFlightById((int) ((sender as DataGridView).Rows[e.RowIndex].Cells[1].Value));
                sutupFlightDetails();
                cuLoadTravleres();
                tabController.SelectTab(5);
            }
        

        }

        private void logOutIcon_Click(object sender, EventArgs e)
        {
            AuthService.LogoutCurrentUser();
            appTabs.SelectTab(0);
        }
    }

}