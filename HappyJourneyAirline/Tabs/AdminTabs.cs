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
        private Panel panel1;
        private PictureBox bookingTab;
        private PictureBox logoIcon;
        private PictureBox flightsTab;
        private PictureBox settingTab;
        private PictureBox logOutIcon;
        private TabPage tabPage1;
        private TextBox mtPhoneTxt;
        private TextBox mtEmailTxt;
        private TextBox mtLnameTxt;
        private TextBox mtFnameTxt;
        private Label label59;
        private Label label60;
        private Label label61;
        private Label label62;
        private TextBox mtUserIDTxt;
        private Label label63;
        private Label label18;
        private TabPage AddAirCityConTab;
        private Label addAirportErrorLbl;
        private Label addCityErrorLbl;
        private Label addContErrorLbl;
        private ComboBox addCityDrop;
        private ComboBox addConDrop;
        private Label label57;
        private Label label55;
        private Button addAddAirportBtn;
        private Label label58;
        private TextBox textBox6;
        private TextBox addCitytNameTxt;
        private TextBox addContIDTxt;
        private TextBox addContNameTxt;
        private Button addAddCityBtn;
        private Label label56;
        private Button addAddCountryBtn;
        private Label label53;
        private Label label54;
        private Label label52;
        private TabPage createUserTab;
        private Label cuErrorLbl;
        private ComboBox cuUserTypeDrop;
        private Label label51;
        private Label label50;
        private Button cuCancelBtn;
        private Button cuCreateUserBtn;
        private Label label44;
        private Label label45;
        private Label label46;
        private Label label47;
        private Label label48;
        private Label label49;
        private TextBox cuPhoneTxt;
        private TextBox cuEmailTxt;
        private TextBox cuLnameTxt;
        private TextBox cuFnameTxt;
        private TextBox cuPasswordTxt;
        private TextBox cuUsernameTxt;
        private TabPage editFlightTab;
        private Label efPriceErrorLbl;
        private Button efDeleteBtn;
        private DateTimePicker efArrTimePick;
        private DateTimePicker efDepTimePick;
        private TextBox efArrTxt;
        private TextBox efDepTxt;
        private TextBox efPriceTxt;
        private TextBox efFlightNumTxt;
        private Button efCancelBtn;
        private Button efEditBtn;
        private DateTimePicker efDatePick;
        private Label label4;
        private Label label26;
        private ComboBox efPlaneIdDrop;
        private Label label27;
        private Label label28;
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private TabPage createFlightTab;
        private Label cfPriceErrorLbl;
        private DateTimePicker cfArrTimePick;
        private DateTimePicker cfDepTimePick;
        private Button cfCancelBtn;
        private Button cfCreateBtn;
        private DateTimePicker cfDatePick;
        private Label label19;
        private TextBox cfPriceTxt;
        private TextBox cfFlightNumTxt;
        private Label label7;
        private ComboBox cfArrDrop;
        private ComboBox cfDepDrop;
        private ComboBox cfPlaneIdDrop;
        private Label label5;
        private Label label6;
        private Label label20;
        private Label label21;
        private Label label23;
        private Label label24;
        private Label label25;
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
        private TabPage travellerUsersTab;
        private Button userCreateUserBtn;
        private Label label2;
        private Label label3;
        private TabPage travellerSettingsTab;
        private Label setErrorLbl;
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
        private Button addAirCityCouBtn;
        private Button creatFlightBtn;
        private Label label22;
        private Label label11;
        private TabControl tabControler;
        private Button mtDeleteBtn;
        private Label label64;
        private Button mtCancelBtn;
        private TextBox mtUserTypeTxt;
        private Label label65;
        private Button addBackBtn;
        private PictureBox users;

        public AdminTabs()
        {
            InitializeComponent();
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights_Active;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTabs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.users = new System.Windows.Forms.PictureBox();
            this.logOutIcon = new System.Windows.Forms.PictureBox();
            this.settingTab = new System.Windows.Forms.PictureBox();
            this.flightsTab = new System.Windows.Forms.PictureBox();
            this.logoIcon = new System.Windows.Forms.PictureBox();
            this.bookingTab = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.AddAirCityConTab = new System.Windows.Forms.TabPage();
            this.label52 = new System.Windows.Forms.Label();
            this.addContNameTxt = new System.Windows.Forms.TextBox();
            this.addContIDTxt = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.addAddCountryBtn = new System.Windows.Forms.Button();
            this.addCitytNameTxt = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.addAddCityBtn = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.addAddAirportBtn = new System.Windows.Forms.Button();
            this.label55 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.addConDrop = new System.Windows.Forms.ComboBox();
            this.addCityDrop = new System.Windows.Forms.ComboBox();
            this.addContErrorLbl = new System.Windows.Forms.Label();
            this.addCityErrorLbl = new System.Windows.Forms.Label();
            this.addAirportErrorLbl = new System.Windows.Forms.Label();
            this.createUserTab = new System.Windows.Forms.TabPage();
            this.cuUsernameTxt = new System.Windows.Forms.TextBox();
            this.cuPasswordTxt = new System.Windows.Forms.TextBox();
            this.cuFnameTxt = new System.Windows.Forms.TextBox();
            this.cuLnameTxt = new System.Windows.Forms.TextBox();
            this.cuEmailTxt = new System.Windows.Forms.TextBox();
            this.cuPhoneTxt = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.cuCreateUserBtn = new System.Windows.Forms.Button();
            this.cuCancelBtn = new System.Windows.Forms.Button();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.cuUserTypeDrop = new System.Windows.Forms.ComboBox();
            this.cuErrorLbl = new System.Windows.Forms.Label();
            this.editFlightTab = new System.Windows.Forms.TabPage();
            this.label43 = new System.Windows.Forms.Label();
            this.efFlightNumTxt = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.efPlaneIdDrop = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.efPriceTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.efDatePick = new System.Windows.Forms.DateTimePicker();
            this.efEditBtn = new System.Windows.Forms.Button();
            this.efCancelBtn = new System.Windows.Forms.Button();
            this.efDepTxt = new System.Windows.Forms.TextBox();
            this.efArrTxt = new System.Windows.Forms.TextBox();
            this.efDepTimePick = new System.Windows.Forms.DateTimePicker();
            this.efArrTimePick = new System.Windows.Forms.DateTimePicker();
            this.efDeleteBtn = new System.Windows.Forms.Button();
            this.efPriceErrorLbl = new System.Windows.Forms.Label();
            this.createFlightTab = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.cfFlightNumTxt = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cfPlaneIdDrop = new System.Windows.Forms.ComboBox();
            this.cfDepDrop = new System.Windows.Forms.ComboBox();
            this.cfArrDrop = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cfPriceTxt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cfDatePick = new System.Windows.Forms.DateTimePicker();
            this.cfCreateBtn = new System.Windows.Forms.Button();
            this.cfCancelBtn = new System.Windows.Forms.Button();
            this.cfDepTimePick = new System.Windows.Forms.DateTimePicker();
            this.cfArrTimePick = new System.Windows.Forms.DateTimePicker();
            this.cfPriceErrorLbl = new System.Windows.Forms.Label();
            this.bookingDetailsTab = new System.Windows.Forms.TabPage();
            this.label37 = new System.Windows.Forms.Label();
            this.bdFlightNumTxt = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.bdDateTxt = new System.Windows.Forms.TextBox();
            this.bdDepTimeTxt = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.bdArrTimeTxt = new System.Windows.Forms.TextBox();
            this.bdFromTxt = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.bdToTxt = new System.Windows.Forms.TextBox();
            this.bdDepTxt = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.bdArrTxt = new System.Windows.Forms.TextBox();
            this.bdCancelBtn = new System.Windows.Forms.Button();
            this.bdBackBtn = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.bdIDTxt = new System.Windows.Forms.TextBox();
            this.travellerUsersTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userCreateUserBtn = new System.Windows.Forms.Button();
            this.travellerSettingsTab = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.setUsernameTxt = new System.Windows.Forms.TextBox();
            this.setPasswordTxt = new System.Windows.Forms.TextBox();
            this.setFirstNameTxt = new System.Windows.Forms.TextBox();
            this.setLastNameTxt = new System.Windows.Forms.TextBox();
            this.setEmailTxt = new System.Windows.Forms.TextBox();
            this.setPhoneTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.setSaveChanesBtn = new System.Windows.Forms.Button();
            this.setCancelBtn = new System.Windows.Forms.Button();
            this.setErrorLbl = new System.Windows.Forms.Label();
            this.travellerBookingsTab = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.travellerFlightsTab = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.creatFlightBtn = new System.Windows.Forms.Button();
            this.addAirCityCouBtn = new System.Windows.Forms.Button();
            this.tabControler = new System.Windows.Forms.TabControl();
            this.mtUserIDTxt = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.mtPhoneTxt = new System.Windows.Forms.TextBox();
            this.mtEmailTxt = new System.Windows.Forms.TextBox();
            this.mtLnameTxt = new System.Windows.Forms.TextBox();
            this.mtFnameTxt = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.mtDeleteBtn = new System.Windows.Forms.Button();
            this.label64 = new System.Windows.Forms.Label();
            this.mtCancelBtn = new System.Windows.Forms.Button();
            this.mtUserTypeTxt = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.addBackBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTab)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.AddAirCityConTab.SuspendLayout();
            this.createUserTab.SuspendLayout();
            this.editFlightTab.SuspendLayout();
            this.createFlightTab.SuspendLayout();
            this.bookingDetailsTab.SuspendLayout();
            this.travellerUsersTab.SuspendLayout();
            this.travellerSettingsTab.SuspendLayout();
            this.travellerBookingsTab.SuspendLayout();
            this.travellerFlightsTab.SuspendLayout();
            this.tabControler.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.users);
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
            // users
            // 
            this.users.Image = global::HappyJourneyAirline.Properties.Resources.Users;
            this.users.Location = new System.Drawing.Point(32, 392);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(104, 80);
            this.users.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.users.TabIndex = 8;
            this.users.TabStop = false;
            this.users.Click += new System.EventHandler(this.users_Click);
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
            this.bookingTab.Location = new System.Drawing.Point(32, 272);
            this.bookingTab.Name = "bookingTab";
            this.bookingTab.Size = new System.Drawing.Size(104, 80);
            this.bookingTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookingTab.TabIndex = 5;
            this.bookingTab.TabStop = false;
            this.bookingTab.Click += new System.EventHandler(this.bookingTab_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.mtUserTypeTxt);
            this.tabPage1.Controls.Add(this.label65);
            this.tabPage1.Controls.Add(this.mtCancelBtn);
            this.tabPage1.Controls.Add(this.mtDeleteBtn);
            this.tabPage1.Controls.Add(this.label64);
            this.tabPage1.Controls.Add(this.mtPhoneTxt);
            this.tabPage1.Controls.Add(this.mtEmailTxt);
            this.tabPage1.Controls.Add(this.mtLnameTxt);
            this.tabPage1.Controls.Add(this.mtFnameTxt);
            this.tabPage1.Controls.Add(this.label59);
            this.tabPage1.Controls.Add(this.label60);
            this.tabPage1.Controls.Add(this.label61);
            this.tabPage1.Controls.Add(this.label62);
            this.tabPage1.Controls.Add(this.mtUserIDTxt);
            this.tabPage1.Controls.Add(this.label63);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(755, 720);
            this.tabPage1.TabIndex = 9;
            this.tabPage1.Text = "Manage User";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(9, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(289, 59);
            this.label18.TabIndex = 115;
            this.label18.Text = "Manage User";
            // 
            // AddAirCityConTab
            // 
            this.AddAirCityConTab.BackColor = System.Drawing.Color.Gainsboro;
            this.AddAirCityConTab.Controls.Add(this.addBackBtn);
            this.AddAirCityConTab.Controls.Add(this.addAirportErrorLbl);
            this.AddAirCityConTab.Controls.Add(this.addCityErrorLbl);
            this.AddAirCityConTab.Controls.Add(this.addContErrorLbl);
            this.AddAirCityConTab.Controls.Add(this.addCityDrop);
            this.AddAirCityConTab.Controls.Add(this.addConDrop);
            this.AddAirCityConTab.Controls.Add(this.label57);
            this.AddAirCityConTab.Controls.Add(this.label55);
            this.AddAirCityConTab.Controls.Add(this.addAddAirportBtn);
            this.AddAirCityConTab.Controls.Add(this.label58);
            this.AddAirCityConTab.Controls.Add(this.textBox6);
            this.AddAirCityConTab.Controls.Add(this.addCitytNameTxt);
            this.AddAirCityConTab.Controls.Add(this.addContIDTxt);
            this.AddAirCityConTab.Controls.Add(this.addContNameTxt);
            this.AddAirCityConTab.Controls.Add(this.addAddCityBtn);
            this.AddAirCityConTab.Controls.Add(this.label56);
            this.AddAirCityConTab.Controls.Add(this.addAddCountryBtn);
            this.AddAirCityConTab.Controls.Add(this.label53);
            this.AddAirCityConTab.Controls.Add(this.label54);
            this.AddAirCityConTab.Controls.Add(this.label52);
            this.AddAirCityConTab.Location = new System.Drawing.Point(23, 4);
            this.AddAirCityConTab.Name = "AddAirCityConTab";
            this.AddAirCityConTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddAirCityConTab.Size = new System.Drawing.Size(755, 720);
            this.AddAirCityConTab.TabIndex = 8;
            this.AddAirCityConTab.Text = "Add ar/city/cont";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(19, 39);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(559, 59);
            this.label52.TabIndex = 108;
            this.label52.Text = "Add(Airport/City/Country)";
            // 
            // addContNameTxt
            // 
            this.addContNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addContNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addContNameTxt.Location = new System.Drawing.Point(27, 217);
            this.addContNameTxt.Name = "addContNameTxt";
            this.addContNameTxt.Size = new System.Drawing.Size(246, 33);
            this.addContNameTxt.TabIndex = 109;
            // 
            // addContIDTxt
            // 
            this.addContIDTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addContIDTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addContIDTxt.Location = new System.Drawing.Point(300, 217);
            this.addContIDTxt.Name = "addContIDTxt";
            this.addContIDTxt.Size = new System.Drawing.Size(246, 33);
            this.addContIDTxt.TabIndex = 110;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.Transparent;
            this.label54.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(27, 184);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(143, 32);
            this.label54.TabIndex = 111;
            this.label54.Text = "Country Name:";
            this.label54.UseCompatibleTextRendering = true;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(300, 184);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(109, 32);
            this.label53.TabIndex = 112;
            this.label53.Text = "Country ID:";
            this.label53.UseCompatibleTextRendering = true;
            // 
            // addAddCountryBtn
            // 
            this.addAddCountryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.addAddCountryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addAddCountryBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addAddCountryBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAddCountryBtn.ForeColor = System.Drawing.Color.White;
            this.addAddCountryBtn.Location = new System.Drawing.Point(27, 256);
            this.addAddCountryBtn.Name = "addAddCountryBtn";
            this.addAddCountryBtn.Size = new System.Drawing.Size(139, 43);
            this.addAddCountryBtn.TabIndex = 113;
            this.addAddCountryBtn.Text = "Add Country";
            this.addAddCountryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addAddCountryBtn.UseVisualStyleBackColor = false;
            // 
            // addCitytNameTxt
            // 
            this.addCitytNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addCitytNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCitytNameTxt.Location = new System.Drawing.Point(27, 367);
            this.addCitytNameTxt.Name = "addCitytNameTxt";
            this.addCitytNameTxt.Size = new System.Drawing.Size(246, 33);
            this.addCitytNameTxt.TabIndex = 115;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.BackColor = System.Drawing.Color.Transparent;
            this.label56.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(27, 334);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(106, 32);
            this.label56.TabIndex = 117;
            this.label56.Text = "City Name:";
            this.label56.UseCompatibleTextRendering = true;
            // 
            // addAddCityBtn
            // 
            this.addAddCityBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.addAddCityBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addAddCityBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addAddCityBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAddCityBtn.ForeColor = System.Drawing.Color.White;
            this.addAddCityBtn.Location = new System.Drawing.Point(27, 406);
            this.addAddCityBtn.Name = "addAddCityBtn";
            this.addAddCityBtn.Size = new System.Drawing.Size(139, 43);
            this.addAddCityBtn.TabIndex = 119;
            this.addAddCityBtn.Text = "Add City";
            this.addAddCityBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addAddCityBtn.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(27, 506);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(246, 33);
            this.textBox6.TabIndex = 121;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.BackColor = System.Drawing.Color.Transparent;
            this.label58.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(27, 473);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(136, 32);
            this.label58.TabIndex = 123;
            this.label58.Text = "Airport Name:";
            this.label58.UseCompatibleTextRendering = true;
            // 
            // addAddAirportBtn
            // 
            this.addAddAirportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.addAddAirportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addAddAirportBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addAddAirportBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAddAirportBtn.ForeColor = System.Drawing.Color.White;
            this.addAddAirportBtn.Location = new System.Drawing.Point(27, 545);
            this.addAddAirportBtn.Name = "addAddAirportBtn";
            this.addAddAirportBtn.Size = new System.Drawing.Size(139, 43);
            this.addAddAirportBtn.TabIndex = 125;
            this.addAddAirportBtn.Text = "Add Airport";
            this.addAddAirportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addAddAirportBtn.UseVisualStyleBackColor = false;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.BackColor = System.Drawing.Color.Transparent;
            this.label55.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(300, 334);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(143, 32);
            this.label55.TabIndex = 127;
            this.label55.Text = "Country Name:";
            this.label55.UseCompatibleTextRendering = true;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.BackColor = System.Drawing.Color.Transparent;
            this.label57.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(300, 473);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(106, 32);
            this.label57.TabIndex = 129;
            this.label57.Text = "City Name:";
            this.label57.UseCompatibleTextRendering = true;
            // 
            // addConDrop
            // 
            this.addConDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.addConDrop.FormattingEnabled = true;
            this.addConDrop.Location = new System.Drawing.Point(300, 366);
            this.addConDrop.Name = "addConDrop";
            this.addConDrop.Size = new System.Drawing.Size(246, 34);
            this.addConDrop.TabIndex = 130;
            // 
            // addCityDrop
            // 
            this.addCityDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.addCityDrop.FormattingEnabled = true;
            this.addCityDrop.Location = new System.Drawing.Point(300, 505);
            this.addCityDrop.Name = "addCityDrop";
            this.addCityDrop.Size = new System.Drawing.Size(246, 34);
            this.addCityDrop.TabIndex = 131;
            // 
            // addContErrorLbl
            // 
            this.addContErrorLbl.AutoSize = true;
            this.addContErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.addContErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addContErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.addContErrorLbl.Location = new System.Drawing.Point(249, 268);
            this.addContErrorLbl.Name = "addContErrorLbl";
            this.addContErrorLbl.Size = new System.Drawing.Size(247, 26);
            this.addContErrorLbl.TabIndex = 132;
            this.addContErrorLbl.Text = "Error: Country already Exist";
            this.addContErrorLbl.Visible = false;
            // 
            // addCityErrorLbl
            // 
            this.addCityErrorLbl.AutoSize = true;
            this.addCityErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.addCityErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCityErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.addCityErrorLbl.Location = new System.Drawing.Point(249, 423);
            this.addCityErrorLbl.Name = "addCityErrorLbl";
            this.addCityErrorLbl.Size = new System.Drawing.Size(212, 26);
            this.addCityErrorLbl.TabIndex = 133;
            this.addCityErrorLbl.Text = "Error: City already Exist";
            this.addCityErrorLbl.Visible = false;
            // 
            // addAirportErrorLbl
            // 
            this.addAirportErrorLbl.AutoSize = true;
            this.addAirportErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.addAirportErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAirportErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.addAirportErrorLbl.Location = new System.Drawing.Point(249, 562);
            this.addAirportErrorLbl.Name = "addAirportErrorLbl";
            this.addAirportErrorLbl.Size = new System.Drawing.Size(240, 26);
            this.addAirportErrorLbl.TabIndex = 134;
            this.addAirportErrorLbl.Text = "Error: Airport already Exist";
            this.addAirportErrorLbl.Visible = false;
            // 
            // createUserTab
            // 
            this.createUserTab.BackColor = System.Drawing.Color.Gainsboro;
            this.createUserTab.Controls.Add(this.cuErrorLbl);
            this.createUserTab.Controls.Add(this.cuUserTypeDrop);
            this.createUserTab.Controls.Add(this.label51);
            this.createUserTab.Controls.Add(this.label50);
            this.createUserTab.Controls.Add(this.cuCancelBtn);
            this.createUserTab.Controls.Add(this.cuCreateUserBtn);
            this.createUserTab.Controls.Add(this.label44);
            this.createUserTab.Controls.Add(this.label45);
            this.createUserTab.Controls.Add(this.label46);
            this.createUserTab.Controls.Add(this.label47);
            this.createUserTab.Controls.Add(this.label48);
            this.createUserTab.Controls.Add(this.label49);
            this.createUserTab.Controls.Add(this.cuPhoneTxt);
            this.createUserTab.Controls.Add(this.cuEmailTxt);
            this.createUserTab.Controls.Add(this.cuLnameTxt);
            this.createUserTab.Controls.Add(this.cuFnameTxt);
            this.createUserTab.Controls.Add(this.cuPasswordTxt);
            this.createUserTab.Controls.Add(this.cuUsernameTxt);
            this.createUserTab.Location = new System.Drawing.Point(23, 4);
            this.createUserTab.Name = "createUserTab";
            this.createUserTab.Padding = new System.Windows.Forms.Padding(3);
            this.createUserTab.Size = new System.Drawing.Size(755, 720);
            this.createUserTab.TabIndex = 7;
            this.createUserTab.Text = "Create User";
            // 
            // cuUsernameTxt
            // 
            this.cuUsernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuUsernameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuUsernameTxt.Location = new System.Drawing.Point(26, 245);
            this.cuUsernameTxt.Name = "cuUsernameTxt";
            this.cuUsernameTxt.Size = new System.Drawing.Size(246, 33);
            this.cuUsernameTxt.TabIndex = 37;
            // 
            // cuPasswordTxt
            // 
            this.cuPasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuPasswordTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuPasswordTxt.Location = new System.Drawing.Point(299, 245);
            this.cuPasswordTxt.Name = "cuPasswordTxt";
            this.cuPasswordTxt.Size = new System.Drawing.Size(246, 33);
            this.cuPasswordTxt.TabIndex = 38;
            // 
            // cuFnameTxt
            // 
            this.cuFnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuFnameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuFnameTxt.Location = new System.Drawing.Point(26, 314);
            this.cuFnameTxt.Name = "cuFnameTxt";
            this.cuFnameTxt.Size = new System.Drawing.Size(246, 33);
            this.cuFnameTxt.TabIndex = 39;
            // 
            // cuLnameTxt
            // 
            this.cuLnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuLnameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuLnameTxt.Location = new System.Drawing.Point(299, 314);
            this.cuLnameTxt.Name = "cuLnameTxt";
            this.cuLnameTxt.Size = new System.Drawing.Size(246, 33);
            this.cuLnameTxt.TabIndex = 40;
            // 
            // cuEmailTxt
            // 
            this.cuEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuEmailTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuEmailTxt.Location = new System.Drawing.Point(26, 383);
            this.cuEmailTxt.Name = "cuEmailTxt";
            this.cuEmailTxt.Size = new System.Drawing.Size(246, 33);
            this.cuEmailTxt.TabIndex = 41;
            // 
            // cuPhoneTxt
            // 
            this.cuPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuPhoneTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuPhoneTxt.Location = new System.Drawing.Point(299, 383);
            this.cuPhoneTxt.Name = "cuPhoneTxt";
            this.cuPhoneTxt.Size = new System.Drawing.Size(246, 33);
            this.cuPhoneTxt.TabIndex = 42;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(26, 210);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(106, 32);
            this.label49.TabIndex = 43;
            this.label49.Text = "Username:";
            this.label49.UseCompatibleTextRendering = true;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.Transparent;
            this.label48.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(299, 210);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(100, 32);
            this.label48.TabIndex = 44;
            this.label48.Text = "Password:";
            this.label48.UseCompatibleTextRendering = true;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(26, 279);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(111, 32);
            this.label47.TabIndex = 45;
            this.label47.Text = "First Name:";
            this.label47.UseCompatibleTextRendering = true;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(299, 279);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(108, 32);
            this.label46.TabIndex = 46;
            this.label46.Text = "Last Name:";
            this.label46.UseCompatibleTextRendering = true;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(26, 350);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(63, 32);
            this.label45.TabIndex = 47;
            this.label45.Text = "Email:";
            this.label45.UseCompatibleTextRendering = true;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(299, 350);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(149, 32);
            this.label44.TabIndex = 48;
            this.label44.Text = "Phone Number:";
            this.label44.UseCompatibleTextRendering = true;
            // 
            // cuCreateUserBtn
            // 
            this.cuCreateUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.cuCreateUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cuCreateUserBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cuCreateUserBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuCreateUserBtn.ForeColor = System.Drawing.Color.White;
            this.cuCreateUserBtn.Location = new System.Drawing.Point(26, 456);
            this.cuCreateUserBtn.Name = "cuCreateUserBtn";
            this.cuCreateUserBtn.Size = new System.Drawing.Size(139, 43);
            this.cuCreateUserBtn.TabIndex = 49;
            this.cuCreateUserBtn.Text = "Create User";
            this.cuCreateUserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cuCreateUserBtn.UseVisualStyleBackColor = false;
            // 
            // cuCancelBtn
            // 
            this.cuCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.cuCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cuCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cuCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuCancelBtn.ForeColor = System.Drawing.Color.White;
            this.cuCancelBtn.Location = new System.Drawing.Point(171, 456);
            this.cuCancelBtn.Name = "cuCancelBtn";
            this.cuCancelBtn.Size = new System.Drawing.Size(139, 43);
            this.cuCancelBtn.TabIndex = 50;
            this.cuCancelBtn.Text = "Cancel";
            this.cuCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cuCancelBtn.UseVisualStyleBackColor = false;
            this.cuCancelBtn.Click += new System.EventHandler(this.cuCancelBtn_Click);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(12, 25);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(256, 59);
            this.label50.TabIndex = 107;
            this.label50.Text = "Create User";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label51.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(26, 130);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(103, 32);
            this.label51.TabIndex = 109;
            this.label51.Text = "User Type:";
            this.label51.UseCompatibleTextRendering = true;
            // 
            // cuUserTypeDrop
            // 
            this.cuUserTypeDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cuUserTypeDrop.FormattingEnabled = true;
            this.cuUserTypeDrop.Location = new System.Drawing.Point(26, 166);
            this.cuUserTypeDrop.Name = "cuUserTypeDrop";
            this.cuUserTypeDrop.Size = new System.Drawing.Size(246, 34);
            this.cuUserTypeDrop.TabIndex = 110;
            // 
            // cuErrorLbl
            // 
            this.cuErrorLbl.AutoSize = true;
            this.cuErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.cuErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.cuErrorLbl.Location = new System.Drawing.Point(335, 473);
            this.cuErrorLbl.Name = "cuErrorLbl";
            this.cuErrorLbl.Size = new System.Drawing.Size(160, 26);
            this.cuErrorLbl.TabIndex = 111;
            this.cuErrorLbl.Text = "Error: Please fix..";
            this.cuErrorLbl.Visible = false;
            // 
            // editFlightTab
            // 
            this.editFlightTab.BackColor = System.Drawing.Color.Gainsboro;
            this.editFlightTab.Controls.Add(this.efPriceErrorLbl);
            this.editFlightTab.Controls.Add(this.efDeleteBtn);
            this.editFlightTab.Controls.Add(this.efArrTimePick);
            this.editFlightTab.Controls.Add(this.efDepTimePick);
            this.editFlightTab.Controls.Add(this.efArrTxt);
            this.editFlightTab.Controls.Add(this.efDepTxt);
            this.editFlightTab.Controls.Add(this.efPriceTxt);
            this.editFlightTab.Controls.Add(this.efFlightNumTxt);
            this.editFlightTab.Controls.Add(this.efCancelBtn);
            this.editFlightTab.Controls.Add(this.efEditBtn);
            this.editFlightTab.Controls.Add(this.efDatePick);
            this.editFlightTab.Controls.Add(this.label4);
            this.editFlightTab.Controls.Add(this.label26);
            this.editFlightTab.Controls.Add(this.efPlaneIdDrop);
            this.editFlightTab.Controls.Add(this.label27);
            this.editFlightTab.Controls.Add(this.label28);
            this.editFlightTab.Controls.Add(this.label39);
            this.editFlightTab.Controls.Add(this.label40);
            this.editFlightTab.Controls.Add(this.label41);
            this.editFlightTab.Controls.Add(this.label42);
            this.editFlightTab.Controls.Add(this.label43);
            this.editFlightTab.Location = new System.Drawing.Point(23, 4);
            this.editFlightTab.Name = "editFlightTab";
            this.editFlightTab.Padding = new System.Windows.Forms.Padding(3);
            this.editFlightTab.Size = new System.Drawing.Size(755, 720);
            this.editFlightTab.TabIndex = 6;
            this.editFlightTab.Text = "Edit Flight";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(9, 26);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(225, 59);
            this.label43.TabIndex = 106;
            this.label43.Text = "Edit Flight";
            // 
            // efFlightNumTxt
            // 
            this.efFlightNumTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.efFlightNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.efFlightNumTxt.Enabled = false;
            this.efFlightNumTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efFlightNumTxt.Location = new System.Drawing.Point(23, 164);
            this.efFlightNumTxt.Name = "efFlightNumTxt";
            this.efFlightNumTxt.ReadOnly = true;
            this.efFlightNumTxt.Size = new System.Drawing.Size(246, 26);
            this.efFlightNumTxt.TabIndex = 107;
            this.efFlightNumTxt.Text = "123";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(23, 127);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(142, 32);
            this.label42.TabIndex = 108;
            this.label42.Text = "Flight Number:";
            this.label42.UseCompatibleTextRendering = true;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(384, 129);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(88, 32);
            this.label41.TabIndex = 109;
            this.label41.Text = "Plane ID:";
            this.label41.UseCompatibleTextRendering = true;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(23, 226);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(155, 32);
            this.label40.TabIndex = 111;
            this.label40.Text = "Departure Time:";
            this.label40.UseCompatibleTextRendering = true;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(384, 226);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(123, 32);
            this.label39.TabIndex = 112;
            this.label39.Text = "Arrival Time:";
            this.label39.UseCompatibleTextRendering = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(23, 338);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(233, 32);
            this.label28.TabIndex = 114;
            this.label28.Text = "Departure Airport Name:";
            this.label28.UseCompatibleTextRendering = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(384, 338);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(192, 32);
            this.label27.TabIndex = 115;
            this.label27.Text = "Arrival Airport Time:";
            this.label27.UseCompatibleTextRendering = true;
            // 
            // efPlaneIdDrop
            // 
            this.efPlaneIdDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.efPlaneIdDrop.FormattingEnabled = true;
            this.efPlaneIdDrop.Location = new System.Drawing.Point(384, 164);
            this.efPlaneIdDrop.Name = "efPlaneIdDrop";
            this.efPlaneIdDrop.Size = new System.Drawing.Size(246, 34);
            this.efPlaneIdDrop.TabIndex = 116;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(23, 431);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 32);
            this.label26.TabIndex = 119;
            this.label26.Text = "Date:";
            this.label26.UseCompatibleTextRendering = true;
            // 
            // efPriceTxt
            // 
            this.efPriceTxt.BackColor = System.Drawing.Color.White;
            this.efPriceTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.efPriceTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efPriceTxt.Location = new System.Drawing.Point(384, 466);
            this.efPriceTxt.Name = "efPriceTxt";
            this.efPriceTxt.ReadOnly = true;
            this.efPriceTxt.Size = new System.Drawing.Size(246, 33);
            this.efPriceTxt.TabIndex = 120;
            this.efPriceTxt.Text = "300";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 32);
            this.label4.TabIndex = 121;
            this.label4.Text = "Price in BD";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // efDatePick
            // 
            this.efDatePick.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.efDatePick.Location = new System.Drawing.Point(23, 466);
            this.efDatePick.Name = "efDatePick";
            this.efDatePick.Size = new System.Drawing.Size(246, 33);
            this.efDatePick.TabIndex = 122;
            // 
            // efEditBtn
            // 
            this.efEditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.efEditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.efEditBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.efEditBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efEditBtn.ForeColor = System.Drawing.Color.White;
            this.efEditBtn.Location = new System.Drawing.Point(23, 546);
            this.efEditBtn.Name = "efEditBtn";
            this.efEditBtn.Size = new System.Drawing.Size(139, 43);
            this.efEditBtn.TabIndex = 123;
            this.efEditBtn.Text = "Edit Flight";
            this.efEditBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.efEditBtn.UseVisualStyleBackColor = false;
            // 
            // efCancelBtn
            // 
            this.efCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.efCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.efCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.efCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efCancelBtn.ForeColor = System.Drawing.Color.White;
            this.efCancelBtn.Location = new System.Drawing.Point(168, 546);
            this.efCancelBtn.Name = "efCancelBtn";
            this.efCancelBtn.Size = new System.Drawing.Size(139, 43);
            this.efCancelBtn.TabIndex = 124;
            this.efCancelBtn.Text = "Cancel";
            this.efCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.efCancelBtn.UseVisualStyleBackColor = false;
            this.efCancelBtn.Click += new System.EventHandler(this.efCancelBtn_Click);
            // 
            // efDepTxt
            // 
            this.efDepTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.efDepTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.efDepTxt.Enabled = false;
            this.efDepTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efDepTxt.Location = new System.Drawing.Point(23, 373);
            this.efDepTxt.Name = "efDepTxt";
            this.efDepTxt.ReadOnly = true;
            this.efDepTxt.Size = new System.Drawing.Size(246, 26);
            this.efDepTxt.TabIndex = 125;
            this.efDepTxt.Text = "Cairo International Airport";
            // 
            // efArrTxt
            // 
            this.efArrTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.efArrTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.efArrTxt.Enabled = false;
            this.efArrTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efArrTxt.Location = new System.Drawing.Point(384, 373);
            this.efArrTxt.Name = "efArrTxt";
            this.efArrTxt.ReadOnly = true;
            this.efArrTxt.Size = new System.Drawing.Size(246, 26);
            this.efArrTxt.TabIndex = 126;
            this.efArrTxt.Text = "Bahrain International Airport";
            // 
            // efDepTimePick
            // 
            this.efDepTimePick.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.efDepTimePick.Location = new System.Drawing.Point(23, 261);
            this.efDepTimePick.Name = "efDepTimePick";
            this.efDepTimePick.Size = new System.Drawing.Size(246, 33);
            this.efDepTimePick.TabIndex = 127;
            // 
            // efArrTimePick
            // 
            this.efArrTimePick.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.efArrTimePick.Location = new System.Drawing.Point(384, 261);
            this.efArrTimePick.Name = "efArrTimePick";
            this.efArrTimePick.Size = new System.Drawing.Size(246, 33);
            this.efArrTimePick.TabIndex = 128;
            // 
            // efDeleteBtn
            // 
            this.efDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.efDeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.efDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.efDeleteBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.efDeleteBtn.Location = new System.Drawing.Point(23, 615);
            this.efDeleteBtn.Name = "efDeleteBtn";
            this.efDeleteBtn.Size = new System.Drawing.Size(139, 43);
            this.efDeleteBtn.TabIndex = 129;
            this.efDeleteBtn.Text = "Delete Flight";
            this.efDeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.efDeleteBtn.UseVisualStyleBackColor = false;
            // 
            // efPriceErrorLbl
            // 
            this.efPriceErrorLbl.AutoSize = true;
            this.efPriceErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.efPriceErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efPriceErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.efPriceErrorLbl.Location = new System.Drawing.Point(379, 516);
            this.efPriceErrorLbl.Name = "efPriceErrorLbl";
            this.efPriceErrorLbl.Size = new System.Drawing.Size(260, 26);
            this.efPriceErrorLbl.TabIndex = 130;
            this.efPriceErrorLbl.Text = "Error: Input Must be number";
            this.efPriceErrorLbl.Visible = false;
            // 
            // createFlightTab
            // 
            this.createFlightTab.BackColor = System.Drawing.Color.Gainsboro;
            this.createFlightTab.Controls.Add(this.cfPriceErrorLbl);
            this.createFlightTab.Controls.Add(this.cfArrTimePick);
            this.createFlightTab.Controls.Add(this.cfDepTimePick);
            this.createFlightTab.Controls.Add(this.cfCancelBtn);
            this.createFlightTab.Controls.Add(this.cfCreateBtn);
            this.createFlightTab.Controls.Add(this.cfDatePick);
            this.createFlightTab.Controls.Add(this.label19);
            this.createFlightTab.Controls.Add(this.cfPriceTxt);
            this.createFlightTab.Controls.Add(this.cfFlightNumTxt);
            this.createFlightTab.Controls.Add(this.label7);
            this.createFlightTab.Controls.Add(this.cfArrDrop);
            this.createFlightTab.Controls.Add(this.cfDepDrop);
            this.createFlightTab.Controls.Add(this.cfPlaneIdDrop);
            this.createFlightTab.Controls.Add(this.label5);
            this.createFlightTab.Controls.Add(this.label6);
            this.createFlightTab.Controls.Add(this.label20);
            this.createFlightTab.Controls.Add(this.label21);
            this.createFlightTab.Controls.Add(this.label23);
            this.createFlightTab.Controls.Add(this.label24);
            this.createFlightTab.Controls.Add(this.label25);
            this.createFlightTab.Location = new System.Drawing.Point(23, 4);
            this.createFlightTab.Name = "createFlightTab";
            this.createFlightTab.Padding = new System.Windows.Forms.Padding(3);
            this.createFlightTab.Size = new System.Drawing.Size(755, 720);
            this.createFlightTab.TabIndex = 5;
            this.createFlightTab.Text = "Create Flight";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(8, 21);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(277, 59);
            this.label25.TabIndex = 75;
            this.label25.Text = "Create Flight";
            // 
            // cfFlightNumTxt
            // 
            this.cfFlightNumTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.cfFlightNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cfFlightNumTxt.Enabled = false;
            this.cfFlightNumTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfFlightNumTxt.Location = new System.Drawing.Point(22, 159);
            this.cfFlightNumTxt.Name = "cfFlightNumTxt";
            this.cfFlightNumTxt.ReadOnly = true;
            this.cfFlightNumTxt.Size = new System.Drawing.Size(246, 26);
            this.cfFlightNumTxt.TabIndex = 76;
            this.cfFlightNumTxt.Text = "123";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(22, 122);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(142, 32);
            this.label24.TabIndex = 77;
            this.label24.Text = "Flight Number:";
            this.label24.UseCompatibleTextRendering = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(383, 124);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 32);
            this.label23.TabIndex = 78;
            this.label23.Text = "Plane ID:";
            this.label23.UseCompatibleTextRendering = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(18, 223);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(155, 32);
            this.label21.TabIndex = 81;
            this.label21.Text = "Departure Time:";
            this.label21.UseCompatibleTextRendering = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(379, 223);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 32);
            this.label20.TabIndex = 82;
            this.label20.Text = "Arrival Time:";
            this.label20.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 32);
            this.label6.TabIndex = 89;
            this.label6.Text = "Departure Airport Name:";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 32);
            this.label5.TabIndex = 90;
            this.label5.Text = "Arrival Airport Time:";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // cfPlaneIdDrop
            // 
            this.cfPlaneIdDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cfPlaneIdDrop.FormattingEnabled = true;
            this.cfPlaneIdDrop.Location = new System.Drawing.Point(383, 159);
            this.cfPlaneIdDrop.Name = "cfPlaneIdDrop";
            this.cfPlaneIdDrop.Size = new System.Drawing.Size(246, 34);
            this.cfPlaneIdDrop.TabIndex = 96;
            // 
            // cfDepDrop
            // 
            this.cfDepDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cfDepDrop.FormattingEnabled = true;
            this.cfDepDrop.Location = new System.Drawing.Point(18, 364);
            this.cfDepDrop.Name = "cfDepDrop";
            this.cfDepDrop.Size = new System.Drawing.Size(246, 34);
            this.cfDepDrop.TabIndex = 97;
            // 
            // cfArrDrop
            // 
            this.cfArrDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cfArrDrop.FormattingEnabled = true;
            this.cfArrDrop.Location = new System.Drawing.Point(379, 364);
            this.cfArrDrop.Name = "cfArrDrop";
            this.cfArrDrop.Size = new System.Drawing.Size(246, 34);
            this.cfArrDrop.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 32);
            this.label7.TabIndex = 99;
            this.label7.Text = "Date:";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // cfPriceTxt
            // 
            this.cfPriceTxt.BackColor = System.Drawing.Color.White;
            this.cfPriceTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cfPriceTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfPriceTxt.Location = new System.Drawing.Point(379, 465);
            this.cfPriceTxt.Name = "cfPriceTxt";
            this.cfPriceTxt.ReadOnly = true;
            this.cfPriceTxt.Size = new System.Drawing.Size(246, 33);
            this.cfPriceTxt.TabIndex = 101;
            this.cfPriceTxt.Text = "300";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(379, 430);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 32);
            this.label19.TabIndex = 102;
            this.label19.Text = "Price in BD";
            this.label19.UseCompatibleTextRendering = true;
            // 
            // cfDatePick
            // 
            this.cfDatePick.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cfDatePick.Location = new System.Drawing.Point(18, 465);
            this.cfDatePick.Name = "cfDatePick";
            this.cfDatePick.Size = new System.Drawing.Size(246, 33);
            this.cfDatePick.TabIndex = 103;
            // 
            // cfCreateBtn
            // 
            this.cfCreateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.cfCreateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cfCreateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cfCreateBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfCreateBtn.ForeColor = System.Drawing.Color.White;
            this.cfCreateBtn.Location = new System.Drawing.Point(18, 545);
            this.cfCreateBtn.Name = "cfCreateBtn";
            this.cfCreateBtn.Size = new System.Drawing.Size(139, 43);
            this.cfCreateBtn.TabIndex = 104;
            this.cfCreateBtn.Text = "Create Flight";
            this.cfCreateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cfCreateBtn.UseVisualStyleBackColor = false;
            // 
            // cfCancelBtn
            // 
            this.cfCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.cfCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cfCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cfCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfCancelBtn.ForeColor = System.Drawing.Color.White;
            this.cfCancelBtn.Location = new System.Drawing.Point(163, 545);
            this.cfCancelBtn.Name = "cfCancelBtn";
            this.cfCancelBtn.Size = new System.Drawing.Size(139, 43);
            this.cfCancelBtn.TabIndex = 105;
            this.cfCancelBtn.Text = "Cancel";
            this.cfCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cfCancelBtn.UseVisualStyleBackColor = false;
            this.cfCancelBtn.Click += new System.EventHandler(this.cfCancelBtn_Click);
            // 
            // cfDepTimePick
            // 
            this.cfDepTimePick.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cfDepTimePick.Location = new System.Drawing.Point(18, 258);
            this.cfDepTimePick.Name = "cfDepTimePick";
            this.cfDepTimePick.Size = new System.Drawing.Size(246, 33);
            this.cfDepTimePick.TabIndex = 106;
            // 
            // cfArrTimePick
            // 
            this.cfArrTimePick.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cfArrTimePick.Location = new System.Drawing.Point(379, 258);
            this.cfArrTimePick.Name = "cfArrTimePick";
            this.cfArrTimePick.Size = new System.Drawing.Size(246, 33);
            this.cfArrTimePick.TabIndex = 107;
            // 
            // cfPriceErrorLbl
            // 
            this.cfPriceErrorLbl.AutoSize = true;
            this.cfPriceErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.cfPriceErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfPriceErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.cfPriceErrorLbl.Location = new System.Drawing.Point(378, 504);
            this.cfPriceErrorLbl.Name = "cfPriceErrorLbl";
            this.cfPriceErrorLbl.Size = new System.Drawing.Size(260, 26);
            this.cfPriceErrorLbl.TabIndex = 108;
            this.cfPriceErrorLbl.Text = "Error: Input Must be number";
            this.cfPriceErrorLbl.Visible = false;
            // 
            // bookingDetailsTab
            // 
            this.bookingDetailsTab.BackColor = System.Drawing.Color.Gainsboro;
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
            this.bookingDetailsTab.Location = new System.Drawing.Point(23, 4);
            this.bookingDetailsTab.Name = "bookingDetailsTab";
            this.bookingDetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.bookingDetailsTab.Size = new System.Drawing.Size(755, 720);
            this.bookingDetailsTab.TabIndex = 4;
            this.bookingDetailsTab.Text = "Booking Details";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(14, 18);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(337, 59);
            this.label37.TabIndex = 54;
            this.label37.Text = "Booking Details";
            // 
            // bdFlightNumTxt
            // 
            this.bdFlightNumTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdFlightNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdFlightNumTxt.Enabled = false;
            this.bdFlightNumTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdFlightNumTxt.Location = new System.Drawing.Point(30, 196);
            this.bdFlightNumTxt.Name = "bdFlightNumTxt";
            this.bdFlightNumTxt.ReadOnly = true;
            this.bdFlightNumTxt.Size = new System.Drawing.Size(246, 26);
            this.bdFlightNumTxt.TabIndex = 55;
            this.bdFlightNumTxt.Text = "123";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(30, 159);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(142, 32);
            this.label36.TabIndex = 56;
            this.label36.Text = "Flight Number:";
            this.label36.UseCompatibleTextRendering = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(391, 161);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(56, 32);
            this.label35.TabIndex = 57;
            this.label35.Text = "Date:";
            this.label35.UseCompatibleTextRendering = true;
            // 
            // bdDateTxt
            // 
            this.bdDateTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdDateTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdDateTxt.Enabled = false;
            this.bdDateTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdDateTxt.Location = new System.Drawing.Point(391, 196);
            this.bdDateTxt.Name = "bdDateTxt";
            this.bdDateTxt.ReadOnly = true;
            this.bdDateTxt.Size = new System.Drawing.Size(246, 26);
            this.bdDateTxt.TabIndex = 58;
            this.bdDateTxt.Text = "2024/12/30";
            // 
            // bdDepTimeTxt
            // 
            this.bdDepTimeTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdDepTimeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdDepTimeTxt.Enabled = false;
            this.bdDepTimeTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdDepTimeTxt.Location = new System.Drawing.Point(30, 271);
            this.bdDepTimeTxt.Name = "bdDepTimeTxt";
            this.bdDepTimeTxt.ReadOnly = true;
            this.bdDepTimeTxt.Size = new System.Drawing.Size(246, 26);
            this.bdDepTimeTxt.TabIndex = 59;
            this.bdDepTimeTxt.Text = "8:00 AM";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(30, 236);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(155, 32);
            this.label34.TabIndex = 60;
            this.label34.Text = "Departure Time:";
            this.label34.UseCompatibleTextRendering = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(391, 236);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(123, 32);
            this.label33.TabIndex = 61;
            this.label33.Text = "Arrival Time:";
            this.label33.UseCompatibleTextRendering = true;
            // 
            // bdArrTimeTxt
            // 
            this.bdArrTimeTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdArrTimeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdArrTimeTxt.Enabled = false;
            this.bdArrTimeTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdArrTimeTxt.Location = new System.Drawing.Point(391, 271);
            this.bdArrTimeTxt.Name = "bdArrTimeTxt";
            this.bdArrTimeTxt.ReadOnly = true;
            this.bdArrTimeTxt.Size = new System.Drawing.Size(246, 26);
            this.bdArrTimeTxt.TabIndex = 62;
            this.bdArrTimeTxt.Text = "11:00 AM";
            // 
            // bdFromTxt
            // 
            this.bdFromTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdFromTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdFromTxt.Enabled = false;
            this.bdFromTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdFromTxt.Location = new System.Drawing.Point(30, 359);
            this.bdFromTxt.Name = "bdFromTxt";
            this.bdFromTxt.ReadOnly = true;
            this.bdFromTxt.Size = new System.Drawing.Size(246, 26);
            this.bdFromTxt.TabIndex = 63;
            this.bdFromTxt.Text = "Cairo (Egypt)";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(30, 322);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(60, 32);
            this.label32.TabIndex = 64;
            this.label32.Text = "From:";
            this.label32.UseCompatibleTextRendering = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(391, 324);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(36, 32);
            this.label31.TabIndex = 65;
            this.label31.Text = "To:";
            this.label31.UseCompatibleTextRendering = true;
            // 
            // bdToTxt
            // 
            this.bdToTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdToTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdToTxt.Enabled = false;
            this.bdToTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdToTxt.Location = new System.Drawing.Point(391, 359);
            this.bdToTxt.Name = "bdToTxt";
            this.bdToTxt.ReadOnly = true;
            this.bdToTxt.Size = new System.Drawing.Size(246, 26);
            this.bdToTxt.TabIndex = 66;
            this.bdToTxt.Text = "Muharraq (Bahrain)";
            // 
            // bdDepTxt
            // 
            this.bdDepTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdDepTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdDepTxt.Enabled = false;
            this.bdDepTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdDepTxt.Location = new System.Drawing.Point(30, 439);
            this.bdDepTxt.Name = "bdDepTxt";
            this.bdDepTxt.ReadOnly = true;
            this.bdDepTxt.Size = new System.Drawing.Size(246, 26);
            this.bdDepTxt.TabIndex = 67;
            this.bdDepTxt.Text = "Cairo International Airport";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(30, 402);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(233, 32);
            this.label30.TabIndex = 68;
            this.label30.Text = "Departure Airport Name:";
            this.label30.UseCompatibleTextRendering = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(391, 402);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(192, 32);
            this.label29.TabIndex = 69;
            this.label29.Text = "Arrival Airport Time:";
            this.label29.UseCompatibleTextRendering = true;
            // 
            // bdArrTxt
            // 
            this.bdArrTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdArrTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdArrTxt.Enabled = false;
            this.bdArrTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdArrTxt.Location = new System.Drawing.Point(391, 439);
            this.bdArrTxt.Name = "bdArrTxt";
            this.bdArrTxt.ReadOnly = true;
            this.bdArrTxt.Size = new System.Drawing.Size(246, 26);
            this.bdArrTxt.TabIndex = 70;
            this.bdArrTxt.Text = "Bahrain International Airport";
            // 
            // bdCancelBtn
            // 
            this.bdCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.bdCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bdCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bdCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdCancelBtn.ForeColor = System.Drawing.Color.White;
            this.bdCancelBtn.Location = new System.Drawing.Point(30, 528);
            this.bdCancelBtn.Name = "bdCancelBtn";
            this.bdCancelBtn.Size = new System.Drawing.Size(175, 43);
            this.bdCancelBtn.TabIndex = 71;
            this.bdCancelBtn.Text = "Cancel the booking";
            this.bdCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bdCancelBtn.UseVisualStyleBackColor = false;
            // 
            // bdBackBtn
            // 
            this.bdBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bdBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bdBackBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bdBackBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdBackBtn.ForeColor = System.Drawing.Color.White;
            this.bdBackBtn.Location = new System.Drawing.Point(210, 528);
            this.bdBackBtn.Name = "bdBackBtn";
            this.bdBackBtn.Size = new System.Drawing.Size(173, 43);
            this.bdBackBtn.TabIndex = 72;
            this.bdBackBtn.Text = "Back to bookings";
            this.bdBackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bdBackBtn.UseVisualStyleBackColor = false;
            this.bdBackBtn.Click += new System.EventHandler(this.bdBackBtn_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(30, 105);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(108, 32);
            this.label38.TabIndex = 73;
            this.label38.Text = "Booking ID:";
            this.label38.UseCompatibleTextRendering = true;
            // 
            // bdIDTxt
            // 
            this.bdIDTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdIDTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdIDTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdIDTxt.Location = new System.Drawing.Point(137, 105);
            this.bdIDTxt.Name = "bdIDTxt";
            this.bdIDTxt.ReadOnly = true;
            this.bdIDTxt.Size = new System.Drawing.Size(246, 26);
            this.bdIDTxt.TabIndex = 74;
            this.bdIDTxt.Text = "123";
            // 
            // travellerUsersTab
            // 
            this.travellerUsersTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerUsersTab.Controls.Add(this.userCreateUserBtn);
            this.travellerUsersTab.Controls.Add(this.label2);
            this.travellerUsersTab.Controls.Add(this.label3);
            this.travellerUsersTab.Location = new System.Drawing.Point(23, 4);
            this.travellerUsersTab.Name = "travellerUsersTab";
            this.travellerUsersTab.Size = new System.Drawing.Size(755, 720);
            this.travellerUsersTab.TabIndex = 3;
            this.travellerUsersTab.Text = "Users";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 59);
            this.label3.TabIndex = 4;
            this.label3.Text = "Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Manage users in this Page";
            // 
            // userCreateUserBtn
            // 
            this.userCreateUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.userCreateUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userCreateUserBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.userCreateUserBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCreateUserBtn.ForeColor = System.Drawing.Color.White;
            this.userCreateUserBtn.Location = new System.Drawing.Point(512, 74);
            this.userCreateUserBtn.Name = "userCreateUserBtn";
            this.userCreateUserBtn.Size = new System.Drawing.Size(223, 55);
            this.userCreateUserBtn.TabIndex = 38;
            this.userCreateUserBtn.Text = "Create User";
            this.userCreateUserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.userCreateUserBtn.UseVisualStyleBackColor = false;
            this.userCreateUserBtn.Click += new System.EventHandler(this.userCreateUserBtn_Click);
            // 
            // travellerSettingsTab
            // 
            this.travellerSettingsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerSettingsTab.Controls.Add(this.setErrorLbl);
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
            this.travellerSettingsTab.Location = new System.Drawing.Point(23, 4);
            this.travellerSettingsTab.Name = "travellerSettingsTab";
            this.travellerSettingsTab.Size = new System.Drawing.Size(755, 720);
            this.travellerSettingsTab.TabIndex = 2;
            this.travellerSettingsTab.Text = "Settings";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(18, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Here you can customize your account";
            // 
            // setUsernameTxt
            // 
            this.setUsernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setUsernameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setUsernameTxt.Location = new System.Drawing.Point(23, 152);
            this.setUsernameTxt.Name = "setUsernameTxt";
            this.setUsernameTxt.Size = new System.Drawing.Size(246, 33);
            this.setUsernameTxt.TabIndex = 23;
            // 
            // setPasswordTxt
            // 
            this.setPasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setPasswordTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPasswordTxt.Location = new System.Drawing.Point(296, 152);
            this.setPasswordTxt.Name = "setPasswordTxt";
            this.setPasswordTxt.Size = new System.Drawing.Size(246, 33);
            this.setPasswordTxt.TabIndex = 24;
            // 
            // setFirstNameTxt
            // 
            this.setFirstNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setFirstNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setFirstNameTxt.Location = new System.Drawing.Point(23, 221);
            this.setFirstNameTxt.Name = "setFirstNameTxt";
            this.setFirstNameTxt.Size = new System.Drawing.Size(246, 33);
            this.setFirstNameTxt.TabIndex = 25;
            // 
            // setLastNameTxt
            // 
            this.setLastNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setLastNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setLastNameTxt.Location = new System.Drawing.Point(296, 221);
            this.setLastNameTxt.Name = "setLastNameTxt";
            this.setLastNameTxt.Size = new System.Drawing.Size(246, 33);
            this.setLastNameTxt.TabIndex = 26;
            // 
            // setEmailTxt
            // 
            this.setEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setEmailTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setEmailTxt.Location = new System.Drawing.Point(23, 290);
            this.setEmailTxt.Name = "setEmailTxt";
            this.setEmailTxt.Size = new System.Drawing.Size(246, 33);
            this.setEmailTxt.TabIndex = 27;
            // 
            // setPhoneTxt
            // 
            this.setPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setPhoneTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPhoneTxt.Location = new System.Drawing.Point(296, 290);
            this.setPhoneTxt.Name = "setPhoneTxt";
            this.setPhoneTxt.Size = new System.Drawing.Size(246, 33);
            this.setPhoneTxt.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 32);
            this.label9.TabIndex = 29;
            this.label9.Text = "Username:";
            this.label9.UseCompatibleTextRendering = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(296, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 32);
            this.label10.TabIndex = 30;
            this.label10.Text = "Password:";
            this.label10.UseCompatibleTextRendering = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 32);
            this.label12.TabIndex = 31;
            this.label12.Text = "First Name:";
            this.label12.UseCompatibleTextRendering = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(296, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 32);
            this.label15.TabIndex = 32;
            this.label15.Text = "Last Name:";
            this.label15.UseCompatibleTextRendering = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 257);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 32);
            this.label16.TabIndex = 33;
            this.label16.Text = "Email:";
            this.label16.UseCompatibleTextRendering = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(296, 257);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(149, 32);
            this.label17.TabIndex = 34;
            this.label17.Text = "Phone Number:";
            this.label17.UseCompatibleTextRendering = true;
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
            // setErrorLbl
            // 
            this.setErrorLbl.AutoSize = true;
            this.setErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.setErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.setErrorLbl.Location = new System.Drawing.Point(313, 380);
            this.setErrorLbl.Name = "setErrorLbl";
            this.setErrorLbl.Size = new System.Drawing.Size(160, 26);
            this.setErrorLbl.TabIndex = 39;
            this.setErrorLbl.Text = "Error: Please fix..";
            this.setErrorLbl.Visible = false;
            // 
            // travellerBookingsTab
            // 
            this.travellerBookingsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerBookingsTab.Controls.Add(this.label1);
            this.travellerBookingsTab.Controls.Add(this.label13);
            this.travellerBookingsTab.Location = new System.Drawing.Point(23, 4);
            this.travellerBookingsTab.Name = "travellerBookingsTab";
            this.travellerBookingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.travellerBookingsTab.Size = new System.Drawing.Size(755, 720);
            this.travellerBookingsTab.TabIndex = 1;
            this.travellerBookingsTab.Text = "Bookings";
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
            // travellerFlightsTab
            // 
            this.travellerFlightsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerFlightsTab.Controls.Add(this.addAirCityCouBtn);
            this.travellerFlightsTab.Controls.Add(this.creatFlightBtn);
            this.travellerFlightsTab.Controls.Add(this.label22);
            this.travellerFlightsTab.Controls.Add(this.label11);
            this.travellerFlightsTab.Location = new System.Drawing.Point(23, 4);
            this.travellerFlightsTab.Name = "travellerFlightsTab";
            this.travellerFlightsTab.Padding = new System.Windows.Forms.Padding(3);
            this.travellerFlightsTab.Size = new System.Drawing.Size(755, 720);
            this.travellerFlightsTab.TabIndex = 0;
            this.travellerFlightsTab.Text = "Flights";
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
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Location = new System.Drawing.Point(31, 84);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(187, 19);
            this.label22.TabIndex = 3;
            this.label22.Text = "Add and modify flights here";
            // 
            // creatFlightBtn
            // 
            this.creatFlightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.creatFlightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.creatFlightBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.creatFlightBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatFlightBtn.ForeColor = System.Drawing.Color.White;
            this.creatFlightBtn.Location = new System.Drawing.Point(480, 97);
            this.creatFlightBtn.Name = "creatFlightBtn";
            this.creatFlightBtn.Size = new System.Drawing.Size(223, 55);
            this.creatFlightBtn.TabIndex = 36;
            this.creatFlightBtn.Text = "Create Flight";
            this.creatFlightBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.creatFlightBtn.UseVisualStyleBackColor = false;
            this.creatFlightBtn.Click += new System.EventHandler(this.creatFlightBtn_Click);
            // 
            // addAirCityCouBtn
            // 
            this.addAirCityCouBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.addAirCityCouBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addAirCityCouBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addAirCityCouBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAirCityCouBtn.ForeColor = System.Drawing.Color.White;
            this.addAirCityCouBtn.Location = new System.Drawing.Point(480, 158);
            this.addAirCityCouBtn.Name = "addAirCityCouBtn";
            this.addAirCityCouBtn.Size = new System.Drawing.Size(223, 55);
            this.addAirCityCouBtn.TabIndex = 37;
            this.addAirCityCouBtn.Text = "Add(Airport/City/Country)";
            this.addAirCityCouBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addAirCityCouBtn.UseVisualStyleBackColor = false;
            this.addAirCityCouBtn.Click += new System.EventHandler(this.addAirCityCouBtn_Click);
            // 
            // tabControler
            // 
            this.tabControler.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControler.Controls.Add(this.travellerFlightsTab);
            this.tabControler.Controls.Add(this.travellerBookingsTab);
            this.tabControler.Controls.Add(this.travellerSettingsTab);
            this.tabControler.Controls.Add(this.travellerUsersTab);
            this.tabControler.Controls.Add(this.bookingDetailsTab);
            this.tabControler.Controls.Add(this.createFlightTab);
            this.tabControler.Controls.Add(this.editFlightTab);
            this.tabControler.Controls.Add(this.createUserTab);
            this.tabControler.Controls.Add(this.AddAirCityConTab);
            this.tabControler.Controls.Add(this.tabPage1);
            this.tabControler.Location = new System.Drawing.Point(136, 0);
            this.tabControler.Multiline = true;
            this.tabControler.Name = "tabControler";
            this.tabControler.SelectedIndex = 0;
            this.tabControler.Size = new System.Drawing.Size(782, 728);
            this.tabControler.TabIndex = 1;
            // 
            // mtUserIDTxt
            // 
            this.mtUserIDTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.mtUserIDTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtUserIDTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtUserIDTxt.Location = new System.Drawing.Point(103, 124);
            this.mtUserIDTxt.Name = "mtUserIDTxt";
            this.mtUserIDTxt.ReadOnly = true;
            this.mtUserIDTxt.Size = new System.Drawing.Size(92, 26);
            this.mtUserIDTxt.TabIndex = 118;
            this.mtUserIDTxt.Text = "123";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.BackColor = System.Drawing.Color.Transparent;
            this.label63.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(19, 124);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(78, 32);
            this.label63.TabIndex = 117;
            this.label63.Text = "User ID:";
            this.label63.UseCompatibleTextRendering = true;
            // 
            // mtPhoneTxt
            // 
            this.mtPhoneTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.mtPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtPhoneTxt.Enabled = false;
            this.mtPhoneTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtPhoneTxt.Location = new System.Drawing.Point(380, 283);
            this.mtPhoneTxt.Name = "mtPhoneTxt";
            this.mtPhoneTxt.ReadOnly = true;
            this.mtPhoneTxt.Size = new System.Drawing.Size(246, 26);
            this.mtPhoneTxt.TabIndex = 126;
            this.mtPhoneTxt.Text = "33333333";
            // 
            // mtEmailTxt
            // 
            this.mtEmailTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.mtEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtEmailTxt.Enabled = false;
            this.mtEmailTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtEmailTxt.Location = new System.Drawing.Point(19, 283);
            this.mtEmailTxt.Name = "mtEmailTxt";
            this.mtEmailTxt.ReadOnly = true;
            this.mtEmailTxt.Size = new System.Drawing.Size(246, 26);
            this.mtEmailTxt.TabIndex = 123;
            this.mtEmailTxt.Text = "Husain@example.com";
            // 
            // mtLnameTxt
            // 
            this.mtLnameTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.mtLnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtLnameTxt.Enabled = false;
            this.mtLnameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtLnameTxt.Location = new System.Drawing.Point(380, 208);
            this.mtLnameTxt.Name = "mtLnameTxt";
            this.mtLnameTxt.ReadOnly = true;
            this.mtLnameTxt.Size = new System.Drawing.Size(246, 26);
            this.mtLnameTxt.TabIndex = 122;
            this.mtLnameTxt.Text = "Sabba";
            // 
            // mtFnameTxt
            // 
            this.mtFnameTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.mtFnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtFnameTxt.Enabled = false;
            this.mtFnameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtFnameTxt.Location = new System.Drawing.Point(19, 208);
            this.mtFnameTxt.Name = "mtFnameTxt";
            this.mtFnameTxt.ReadOnly = true;
            this.mtFnameTxt.Size = new System.Drawing.Size(246, 26);
            this.mtFnameTxt.TabIndex = 119;
            this.mtFnameTxt.Text = "Husain";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.Color.Transparent;
            this.label59.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(380, 248);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(149, 32);
            this.label59.TabIndex = 125;
            this.label59.Text = "Phone Number:";
            this.label59.UseCompatibleTextRendering = true;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.BackColor = System.Drawing.Color.Transparent;
            this.label60.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(19, 248);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(63, 32);
            this.label60.TabIndex = 124;
            this.label60.Text = "Email:";
            this.label60.UseCompatibleTextRendering = true;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.Color.Transparent;
            this.label61.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(380, 173);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(108, 32);
            this.label61.TabIndex = 121;
            this.label61.Text = "Last Name:";
            this.label61.UseCompatibleTextRendering = true;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.BackColor = System.Drawing.Color.Transparent;
            this.label62.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(19, 171);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(111, 32);
            this.label62.TabIndex = 120;
            this.label62.Text = "First Name:";
            this.label62.UseCompatibleTextRendering = true;
            // 
            // mtDeleteBtn
            // 
            this.mtDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.mtDeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mtDeleteBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.mtDeleteBtn.Location = new System.Drawing.Point(19, 479);
            this.mtDeleteBtn.Name = "mtDeleteBtn";
            this.mtDeleteBtn.Size = new System.Drawing.Size(139, 43);
            this.mtDeleteBtn.TabIndex = 128;
            this.mtDeleteBtn.Text = "Delete Account";
            this.mtDeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mtDeleteBtn.UseVisualStyleBackColor = false;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label64.Location = new System.Drawing.Point(15, 446);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(652, 19);
            this.label64.TabIndex = 127;
            this.label64.Text = "Attention if you delete your account all your information will be deleted and can" +
    "t be restored";
            // 
            // mtCancelBtn
            // 
            this.mtCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.mtCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mtCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtCancelBtn.ForeColor = System.Drawing.Color.White;
            this.mtCancelBtn.Location = new System.Drawing.Point(164, 479);
            this.mtCancelBtn.Name = "mtCancelBtn";
            this.mtCancelBtn.Size = new System.Drawing.Size(139, 43);
            this.mtCancelBtn.TabIndex = 129;
            this.mtCancelBtn.Text = "Cancel";
            this.mtCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mtCancelBtn.UseVisualStyleBackColor = false;
            // 
            // mtUserTypeTxt
            // 
            this.mtUserTypeTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.mtUserTypeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtUserTypeTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtUserTypeTxt.Location = new System.Drawing.Point(308, 124);
            this.mtUserTypeTxt.Name = "mtUserTypeTxt";
            this.mtUserTypeTxt.ReadOnly = true;
            this.mtUserTypeTxt.Size = new System.Drawing.Size(246, 26);
            this.mtUserTypeTxt.TabIndex = 131;
            this.mtUserTypeTxt.Text = "Employer/Traveler";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BackColor = System.Drawing.Color.Transparent;
            this.label65.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(201, 124);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(101, 32);
            this.label65.TabIndex = 130;
            this.label65.Text = "User Type:";
            this.label65.UseCompatibleTextRendering = true;
            // 
            // addBackBtn
            // 
            this.addBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.addBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addBackBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addBackBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBackBtn.ForeColor = System.Drawing.Color.White;
            this.addBackBtn.Location = new System.Drawing.Point(29, 636);
            this.addBackBtn.Name = "addBackBtn";
            this.addBackBtn.Size = new System.Drawing.Size(139, 43);
            this.addBackBtn.TabIndex = 135;
            this.addBackBtn.Text = "Back To Flights";
            this.addBackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addBackBtn.UseVisualStyleBackColor = false;
            this.addBackBtn.Click += new System.EventHandler(this.addBackBtn_Click);
            // 
            // AdminTabs
            // 
            this.Controls.Add(this.tabControler);
            this.Controls.Add(this.panel1);
            this.Name = "AdminTabs";
            this.Size = new System.Drawing.Size(921, 728);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTab)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.AddAirCityConTab.ResumeLayout(false);
            this.AddAirCityConTab.PerformLayout();
            this.createUserTab.ResumeLayout(false);
            this.createUserTab.PerformLayout();
            this.editFlightTab.ResumeLayout(false);
            this.editFlightTab.PerformLayout();
            this.createFlightTab.ResumeLayout(false);
            this.createFlightTab.PerformLayout();
            this.bookingDetailsTab.ResumeLayout(false);
            this.bookingDetailsTab.PerformLayout();
            this.travellerUsersTab.ResumeLayout(false);
            this.travellerUsersTab.PerformLayout();
            this.travellerSettingsTab.ResumeLayout(false);
            this.travellerSettingsTab.PerformLayout();
            this.travellerBookingsTab.ResumeLayout(false);
            this.travellerBookingsTab.PerformLayout();
            this.travellerFlightsTab.ResumeLayout(false);
            this.travellerFlightsTab.PerformLayout();
            this.tabControler.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private void flightsTab_Click(object sender, EventArgs e)
        {
            tabControler.SelectTab(0);
            defultIcons();
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights_Active;
        }

        private void bookingTab_Click(object sender, EventArgs e)
        {
            tabControler.SelectTab(1);
            defultIcons();
            bookingTab.Image = global::HappyJourneyAirline.Properties.Resources.Bookings_Active;
        }

        private void settingTab_Click(object sender, EventArgs e)
        {
            tabControler.SelectTab(2);
            defultIcons();
            settingTab.Image = global::HappyJourneyAirline.Properties.Resources.Settings_Active;
        }

        private void users_Click(object sender, EventArgs e)
        {
            tabControler.SelectTab(3);
            defultIcons();
            users.Image = global::HappyJourneyAirline.Properties.Resources.Users_Active;
        }

        private void defultIcons()
        {
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights;
            bookingTab.Image = global::HappyJourneyAirline.Properties.Resources.Bookings;
            settingTab.Image = global::HappyJourneyAirline.Properties.Resources.Settings_Icon;
            users.Image = global::HappyJourneyAirline.Properties.Resources.Users;
        }

        private void creatFlightBtn_Click(object sender, EventArgs e)
        {
            tabControler.SelectTab(5);
        }

        private void cuCancelBtn_Click(object sender, EventArgs e)
        {
            tabControler.SelectTab(3);
        }

        private void userCreateUserBtn_Click(object sender, EventArgs e)
        {
            tabControler.SelectTab(7);
        }

        private void cfCancelBtn_Click(object sender, EventArgs e)
        {
            tabControler.SelectTab(0);
        }

        private void efCancelBtn_Click(object sender, EventArgs e)
        {
            tabControler.SelectTab(0);
        }

        private void bdBackBtn_Click(object sender, EventArgs e)
        {
            tabControler.SelectTab(1);
        }

        private void setCancelBtn_Click(object sender, EventArgs e)
        {
            tabControler.SelectTab(0);
            defultIcons();
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights_Active;
        }

        private void addAirCityCouBtn_Click(object sender, EventArgs e)
        {
            tabControler.SelectTab(8);
        }

        private void addBackBtn_Click(object sender, EventArgs e)
        {
            tabControler.SelectTab(0);
        }
    }

}
