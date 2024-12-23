using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using HappyJourneyAirline.Models;
using HappyJourneyAirline.Lib;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
namespace HappyJourneyAirline.Tabs
{

    /// <summary>
    /// This class include all the Trveller controls and methods. Meaning Everything related to the Traveller side will be in this class
    /// </summary>
    /// 

    public partial class TravellerTabs : UserControl
    {
        TabControl appTabs;
        #region fields
        private TabPage travellerFlightsTab;
        private TabControl tabController;
        private TabPage travellerBookingsTab;
        private TabPage travellerSettingsTab;
        private Panel panel1;
        private PictureBox logOutIcon;
        private PictureBox settingTab;
        private PictureBox flightsTab;
        private PictureBox logoIcon;
        private PictureBox cancelIcon;
        private PictureBox searchIcon;
        //private System.ComponentModel.IContainer components;
        private PictureBox notificationTab;
        private TabPage travellerNotificationTab;
        private CheckBox dateCheck;
        private CheckBox timeCheck;
        private TextBox setPhoneTxt;
        private TextBox setEmailTxt;
        private TextBox setLastNameTxt;
        private TextBox setFirstNameTxt;
        private TextBox setPasswordTxt;
        private TextBox setUsernameTxt;
        private Button setSaveChanesBtn;
        private Button setCancelBtn;
        private Button setDeleteBtn;
        private TabPage flightDetails;
        private TextBox fdArrTxt;
        private TextBox fdDepTxt;
        private TextBox fdToTxt;
        private TextBox fdFromTxt;
        private TextBox fdArrTimeTxt;
        private TextBox fdDepTimeTxt;
        private TextBox fdFlightNumTxt;
        private Label label19;
        private Button fdCancelBtn;
        private Button fdBookBtn;
        private TabPage bookingDetailsTab;
        private TextBox bdIDTxt;
        private Button bdBackBtn;
        private Button bdCancelBtn;
        private TextBox bdArrTxt;
        private TextBox bdDepTxt;
        private TextBox bdToTxt;
        private TextBox bdFromTxt;
        private TextBox bdArrTimeTxt;
        private TextBox bdDepTimeTxt;
        private TextBox bdFlightNumTxt;
        private TabPage payment;
        private TextBox ppPasportNumTxt;
        private TextBox ppFlightNumTxt;
        private RadioButton ppAeRadio;
        private RadioButton ppVisaRadio;
        private RadioButton ppCcRadio;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button ppCancelBtn;
        private Button ppPayBtn;
        private TextBox ppCvvTxt;
        private TextBox ppNameCardTxt;
        private TextBox ppCardNumTxt;
        private DateTimePicker ppDatePick;
        private Label ppTotaLbl;
        private Label setErrorLbl;
        private Label paymentErrorLbl;
        private DataGridView bookingTable;
        private ComboBox depDrop;
        private ComboBox arrivalDrop;
        private DateTimePicker date;
        private ComboBox time;
        private DataGridView gridflightsData;
        private DataGridView dataGridViewNotification;
        private Button button2;
        private PictureBox bookingTab;
        private ComboBox ppTicketClassDrop;
        int previosTab = 0;
        private TextBox bdSeatNumberTxt;
        private TextBox bdTicketClassTxt;
        private DataGridViewTextBoxColumn View;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn from;
        private DataGridViewTextBoxColumn to;
        private DataGridViewTextBoxColumn dateTime;
        private TextBox bdTotalPriceTxt;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox bdFlightStatusTxt;

        #endregion

        #region Added Atrebutes
        private Flight selectedFlight = null;

        public TravellerTabs(TabControl appTabs)
        {
            InitializeComponent();
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights_Active;
            this.appTabs = appTabs;
            bookingTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bookingTable.Columns[0].DefaultCellStyle.ForeColor = Color.Blue;
        }
        #endregion

        private void InitializeComponent()
        {
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label22;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label27;
            System.Windows.Forms.Label label28;
            System.Windows.Forms.Label label25;
            System.Windows.Forms.Label label26;
            System.Windows.Forms.Label label23;
            System.Windows.Forms.Label label24;
            System.Windows.Forms.Label label21;
            System.Windows.Forms.Label label38;
            System.Windows.Forms.Label label29;
            System.Windows.Forms.Label label30;
            System.Windows.Forms.Label label31;
            System.Windows.Forms.Label label32;
            System.Windows.Forms.Label label33;
            System.Windows.Forms.Label label34;
            System.Windows.Forms.Label label36;
            System.Windows.Forms.Label label37;
            System.Windows.Forms.Label label49;
            System.Windows.Forms.Label label48;
            System.Windows.Forms.Label label46;
            System.Windows.Forms.Label label47;
            System.Windows.Forms.Label label45;
            System.Windows.Forms.Label label44;
            System.Windows.Forms.Label label43;
            System.Windows.Forms.Label label42;
            System.Windows.Forms.Label label41;
            System.Windows.Forms.Label label39;
            System.Windows.Forms.Label label40;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label label50;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravellerTabs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label label51;
            System.Windows.Forms.Label label35;
            this.travellerFlightsTab = new System.Windows.Forms.TabPage();
            this.gridflightsData = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.arrivalDrop = new System.Windows.Forms.ComboBox();
            this.depDrop = new System.Windows.Forms.ComboBox();
            this.dateCheck = new System.Windows.Forms.CheckBox();
            this.timeCheck = new System.Windows.Forms.CheckBox();
            this.cancelIcon = new System.Windows.Forms.PictureBox();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.tabController = new System.Windows.Forms.TabControl();
            this.travellerBookingsTab = new System.Windows.Forms.TabPage();
            this.bookingTable = new System.Windows.Forms.DataGridView();
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
            this.travellerNotificationTab = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewNotification = new System.Windows.Forms.DataGridView();
            this.flightDetails = new System.Windows.Forms.TabPage();
            this.fdCancelBtn = new System.Windows.Forms.Button();
            this.fdBookBtn = new System.Windows.Forms.Button();
            this.fdArrTxt = new System.Windows.Forms.TextBox();
            this.fdDepTxt = new System.Windows.Forms.TextBox();
            this.fdToTxt = new System.Windows.Forms.TextBox();
            this.fdFromTxt = new System.Windows.Forms.TextBox();
            this.fdArrTimeTxt = new System.Windows.Forms.TextBox();
            this.fdDepTimeTxt = new System.Windows.Forms.TextBox();
            this.fdFlightNumTxt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.bookingDetailsTab = new System.Windows.Forms.TabPage();
            this.bdSeatNumberTxt = new System.Windows.Forms.TextBox();
            this.bdTicketClassTxt = new System.Windows.Forms.TextBox();
            this.bdIDTxt = new System.Windows.Forms.TextBox();
            this.bdBackBtn = new System.Windows.Forms.Button();
            this.bdCancelBtn = new System.Windows.Forms.Button();
            this.bdArrTxt = new System.Windows.Forms.TextBox();
            this.bdDepTxt = new System.Windows.Forms.TextBox();
            this.bdToTxt = new System.Windows.Forms.TextBox();
            this.bdFromTxt = new System.Windows.Forms.TextBox();
            this.bdArrTimeTxt = new System.Windows.Forms.TextBox();
            this.bdDepTimeTxt = new System.Windows.Forms.TextBox();
            this.bdFlightNumTxt = new System.Windows.Forms.TextBox();
            this.payment = new System.Windows.Forms.TabPage();
            this.ppTicketClassDrop = new System.Windows.Forms.ComboBox();
            this.paymentErrorLbl = new System.Windows.Forms.Label();
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
            this.ppPasportNumTxt = new System.Windows.Forms.TextBox();
            this.ppFlightNumTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notificationTab = new System.Windows.Forms.PictureBox();
            this.logOutIcon = new System.Windows.Forms.PictureBox();
            this.settingTab = new System.Windows.Forms.PictureBox();
            this.flightsTab = new System.Windows.Forms.PictureBox();
            this.logoIcon = new System.Windows.Forms.PictureBox();
            this.bookingTab = new System.Windows.Forms.PictureBox();
            this.View = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdTotalPriceTxt = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bdFlightStatusTxt = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            label28 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            label26 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            label38 = new System.Windows.Forms.Label();
            label29 = new System.Windows.Forms.Label();
            label30 = new System.Windows.Forms.Label();
            label31 = new System.Windows.Forms.Label();
            label32 = new System.Windows.Forms.Label();
            label33 = new System.Windows.Forms.Label();
            label34 = new System.Windows.Forms.Label();
            label36 = new System.Windows.Forms.Label();
            label37 = new System.Windows.Forms.Label();
            label49 = new System.Windows.Forms.Label();
            label48 = new System.Windows.Forms.Label();
            label46 = new System.Windows.Forms.Label();
            label47 = new System.Windows.Forms.Label();
            label45 = new System.Windows.Forms.Label();
            label44 = new System.Windows.Forms.Label();
            label43 = new System.Windows.Forms.Label();
            label42 = new System.Windows.Forms.Label();
            label41 = new System.Windows.Forms.Label();
            label39 = new System.Windows.Forms.Label();
            label40 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label50 = new System.Windows.Forms.Label();
            label51 = new System.Windows.Forms.Label();
            label35 = new System.Windows.Forms.Label();
            this.travellerFlightsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridflightsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            this.tabController.SuspendLayout();
            this.travellerBookingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTable)).BeginInit();
            this.travellerSettingsTab.SuspendLayout();
            this.travellerNotificationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotification)).BeginInit();
            this.flightDetails.SuspendLayout();
            this.bookingDetailsTab.SuspendLayout();
            this.payment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notificationTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTab)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(367, 246);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 40);
            label3.TabIndex = 40;
            label3.Text = "Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(43, 246);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(93, 40);
            label4.TabIndex = 39;
            label4.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(344, 154);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(235, 40);
            label2.TabIndex = 37;
            label2.Text = "Arrival Airport";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(17, 154);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(293, 40);
            label5.TabIndex = 35;
            label5.Text = "Departure Airport";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label22.Location = new System.Drawing.Point(31, 84);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(541, 35);
            label22.TabIndex = 3;
            label22.Text = "Book Your Next Flight Easily Through This Page";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(24, 25);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(263, 100);
            label11.TabIndex = 1;
            label11.Text = "Flights";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label1.Location = new System.Drawing.Point(24, 80);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(426, 35);
            label1.TabIndex = 4;
            label1.Text = "You can here modify bookings easily";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(16, 21);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(351, 100);
            label13.TabIndex = 2;
            label13.Text = "Bookings";
            // 
            // label18
            // 
            label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label18.Location = new System.Drawing.Point(18, 574);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(717, 24);
            label18.TabIndex = 20;
            label18.Text = "Attention if you delete your account all your information will be deleted and can" +
    "t be restored";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = System.Drawing.Color.Transparent;
            label17.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.Location = new System.Drawing.Point(410, 272);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(253, 51);
            label17.TabIndex = 17;
            label17.Text = "Phone Number:";
            label17.UseCompatibleTextRendering = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = System.Drawing.Color.Transparent;
            label16.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.Location = new System.Drawing.Point(22, 272);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(106, 51);
            label16.TabIndex = 16;
            label16.Text = "Email:";
            label16.UseCompatibleTextRendering = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = System.Drawing.Color.Transparent;
            label15.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(410, 201);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(183, 51);
            label15.TabIndex = 15;
            label15.Text = "Last Name:";
            label15.UseCompatibleTextRendering = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = System.Drawing.Color.Transparent;
            label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(22, 201);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(188, 51);
            label12.TabIndex = 14;
            label12.Text = "First Name:";
            label12.UseCompatibleTextRendering = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(410, 132);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(169, 51);
            label10.TabIndex = 13;
            label10.Text = "Password:";
            label10.UseCompatibleTextRendering = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(22, 132);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(179, 51);
            label9.TabIndex = 12;
            label9.Text = "Username:";
            label9.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label8.Location = new System.Drawing.Point(18, 77);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(441, 35);
            label8.TabIndex = 5;
            label8.Text = "Here you can customize your account";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(12, 18);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(310, 100);
            label14.TabIndex = 3;
            label14.Text = "Settings";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label6.Location = new System.Drawing.Point(14, 92);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(453, 35);
            label6.TabIndex = 5;
            label6.Text = "Here you will find all your notifications";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(7, 33);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(442, 100);
            label7.TabIndex = 4;
            label7.Text = "Notification";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = System.Drawing.Color.Transparent;
            label27.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label27.Location = new System.Drawing.Point(378, 369);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(326, 51);
            label27.TabIndex = 29;
            label27.Text = "Arrival Airport Time:";
            label27.UseCompatibleTextRendering = true;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.BackColor = System.Drawing.Color.Transparent;
            label28.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label28.Location = new System.Drawing.Point(17, 369);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(396, 51);
            label28.TabIndex = 28;
            label28.Text = "Departure Airport Name:";
            label28.UseCompatibleTextRendering = true;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = System.Drawing.Color.Transparent;
            label25.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label25.Location = new System.Drawing.Point(378, 291);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(60, 51);
            label25.TabIndex = 25;
            label25.Text = "To:";
            label25.UseCompatibleTextRendering = true;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = System.Drawing.Color.Transparent;
            label26.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label26.Location = new System.Drawing.Point(17, 289);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(102, 51);
            label26.TabIndex = 24;
            label26.Text = "From:";
            label26.UseCompatibleTextRendering = true;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = System.Drawing.Color.Transparent;
            label23.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label23.Location = new System.Drawing.Point(378, 203);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(303, 51);
            label23.TabIndex = 21;
            label23.Text = "Arrival Timestamp:";
            label23.UseCompatibleTextRendering = true;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = System.Drawing.Color.Transparent;
            label24.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label24.Location = new System.Drawing.Point(17, 203);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(358, 51);
            label24.TabIndex = 20;
            label24.Text = "Departure Timestamp:";
            label24.UseCompatibleTextRendering = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = System.Drawing.Color.Transparent;
            label21.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label21.Location = new System.Drawing.Point(17, 126);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(241, 51);
            label21.TabIndex = 16;
            label21.Text = "Flight Number:";
            label21.UseCompatibleTextRendering = true;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.BackColor = System.Drawing.Color.Transparent;
            label38.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label38.Location = new System.Drawing.Point(32, 106);
            label38.Name = "label38";
            label38.Size = new System.Drawing.Size(183, 51);
            label38.TabIndex = 52;
            label38.Text = "Booking ID:";
            label38.UseCompatibleTextRendering = true;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = System.Drawing.Color.Transparent;
            label29.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label29.Location = new System.Drawing.Point(393, 343);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(326, 51);
            label29.TabIndex = 48;
            label29.Text = "Arrival Airport Time:";
            label29.UseCompatibleTextRendering = true;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = System.Drawing.Color.Transparent;
            label30.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label30.Location = new System.Drawing.Point(32, 343);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(396, 51);
            label30.TabIndex = 47;
            label30.Text = "Departure Airport Name:";
            label30.UseCompatibleTextRendering = true;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.BackColor = System.Drawing.Color.Transparent;
            label31.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label31.Location = new System.Drawing.Point(393, 265);
            label31.Name = "label31";
            label31.Size = new System.Drawing.Size(60, 51);
            label31.TabIndex = 44;
            label31.Text = "To:";
            label31.UseCompatibleTextRendering = true;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.BackColor = System.Drawing.Color.Transparent;
            label32.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label32.Location = new System.Drawing.Point(33, 272);
            label32.Name = "label32";
            label32.Size = new System.Drawing.Size(102, 51);
            label32.TabIndex = 43;
            label32.Text = "From:";
            label32.UseCompatibleTextRendering = true;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.BackColor = System.Drawing.Color.Transparent;
            label33.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label33.Location = new System.Drawing.Point(393, 177);
            label33.Name = "label33";
            label33.Size = new System.Drawing.Size(208, 51);
            label33.TabIndex = 40;
            label33.Text = "Arrival Time:";
            label33.UseCompatibleTextRendering = true;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.BackColor = System.Drawing.Color.Transparent;
            label34.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label34.Location = new System.Drawing.Point(32, 177);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(263, 51);
            label34.TabIndex = 39;
            label34.Text = "Departure Time:";
            label34.UseCompatibleTextRendering = true;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.BackColor = System.Drawing.Color.Transparent;
            label36.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label36.Location = new System.Drawing.Point(393, 106);
            label36.Name = "label36";
            label36.Size = new System.Drawing.Size(236, 51);
            label36.TabIndex = 35;
            label36.Text = "Flight Number:";
            label36.UseCompatibleTextRendering = true;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label37.Location = new System.Drawing.Point(16, 19);
            label37.Name = "label37";
            label37.Size = new System.Drawing.Size(569, 100);
            label37.TabIndex = 33;
            label37.Text = "Booking Details";
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.BackColor = System.Drawing.Color.Transparent;
            label49.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label49.Location = new System.Drawing.Point(222, 594);
            label49.Name = "label49";
            label49.Size = new System.Drawing.Size(220, 51);
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
            label48.Size = new System.Drawing.Size(210, 51);
            label48.TabIndex = 79;
            label48.Text = "Total will be:";
            label48.UseCompatibleTextRendering = true;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.BackColor = System.Drawing.Color.Transparent;
            label46.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label46.Location = new System.Drawing.Point(351, 497);
            label46.Name = "label46";
            label46.Size = new System.Drawing.Size(75, 51);
            label46.TabIndex = 75;
            label46.Text = "CVV";
            label46.UseCompatibleTextRendering = true;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.BackColor = System.Drawing.Color.Transparent;
            label47.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label47.Location = new System.Drawing.Point(24, 497);
            label47.Name = "label47";
            label47.Size = new System.Drawing.Size(229, 51);
            label47.TabIndex = 73;
            label47.Text = "Name on Card";
            label47.UseCompatibleTextRendering = true;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.BackColor = System.Drawing.Color.Transparent;
            label45.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label45.Location = new System.Drawing.Point(351, 412);
            label45.Name = "label45";
            label45.Size = new System.Drawing.Size(202, 51);
            label45.TabIndex = 71;
            label45.Text = "Expiary date";
            label45.UseCompatibleTextRendering = true;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.BackColor = System.Drawing.Color.Transparent;
            label44.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label44.Location = new System.Drawing.Point(24, 412);
            label44.Name = "label44";
            label44.Size = new System.Drawing.Size(216, 51);
            label44.TabIndex = 69;
            label44.Text = "Card Number";
            label44.UseCompatibleTextRendering = true;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.BackColor = System.Drawing.Color.Transparent;
            label43.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label43.Location = new System.Drawing.Point(24, 294);
            label43.Name = "label43";
            label43.Size = new System.Drawing.Size(289, 51);
            label43.TabIndex = 61;
            label43.Text = "Credit card details";
            label43.UseCompatibleTextRendering = true;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.BackColor = System.Drawing.Color.Transparent;
            label42.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label42.Location = new System.Drawing.Point(351, 200);
            label42.Name = "label42";
            label42.Size = new System.Drawing.Size(211, 51);
            label42.TabIndex = 60;
            label42.Text = "CPR number:";
            label42.UseCompatibleTextRendering = true;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.BackColor = System.Drawing.Color.Transparent;
            label41.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label41.Location = new System.Drawing.Point(24, 200);
            label41.Name = "label41";
            label41.Size = new System.Drawing.Size(198, 51);
            label41.TabIndex = 58;
            label41.Text = "Ticket Class:";
            label41.UseCompatibleTextRendering = true;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.BackColor = System.Drawing.Color.Transparent;
            label39.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label39.Location = new System.Drawing.Point(24, 115);
            label39.Name = "label39";
            label39.Size = new System.Drawing.Size(241, 51);
            label39.TabIndex = 56;
            label39.Text = "Flight Number:";
            label39.UseCompatibleTextRendering = true;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label40.Location = new System.Drawing.Point(14, 23);
            label40.Name = "label40";
            label40.Size = new System.Drawing.Size(521, 100);
            label40.TabIndex = 54;
            label40.Text = "Payment Page";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = System.Drawing.Color.Transparent;
            label20.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label20.Location = new System.Drawing.Point(393, 430);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(223, 51);
            label20.TabIndex = 56;
            label20.Text = "Seat Number:";
            label20.UseCompatibleTextRendering = true;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.BackColor = System.Drawing.Color.Transparent;
            label50.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label50.Location = new System.Drawing.Point(32, 430);
            label50.Name = "label50";
            label50.Size = new System.Drawing.Size(198, 51);
            label50.TabIndex = 55;
            label50.Text = "Ticket Class:";
            label50.UseCompatibleTextRendering = true;
            // 
            // travellerFlightsTab
            // 
            this.travellerFlightsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerFlightsTab.Controls.Add(this.gridflightsData);
            this.travellerFlightsTab.Controls.Add(this.time);
            this.travellerFlightsTab.Controls.Add(this.date);
            this.travellerFlightsTab.Controls.Add(this.arrivalDrop);
            this.travellerFlightsTab.Controls.Add(this.depDrop);
            this.travellerFlightsTab.Controls.Add(this.dateCheck);
            this.travellerFlightsTab.Controls.Add(this.timeCheck);
            this.travellerFlightsTab.Controls.Add(this.cancelIcon);
            this.travellerFlightsTab.Controls.Add(label3);
            this.travellerFlightsTab.Controls.Add(label4);
            this.travellerFlightsTab.Controls.Add(this.searchIcon);
            this.travellerFlightsTab.Controls.Add(label2);
            this.travellerFlightsTab.Controls.Add(label5);
            this.travellerFlightsTab.Controls.Add(label22);
            this.travellerFlightsTab.Controls.Add(label11);
            this.travellerFlightsTab.Location = new System.Drawing.Point(31, 4);
            this.travellerFlightsTab.Name = "travellerFlightsTab";
            this.travellerFlightsTab.Padding = new System.Windows.Forms.Padding(3);
            this.travellerFlightsTab.Size = new System.Drawing.Size(749, 720);
            this.travellerFlightsTab.TabIndex = 0;
            this.travellerFlightsTab.Text = "Flights";
            this.travellerFlightsTab.Paint += new System.Windows.Forms.PaintEventHandler(this.travellerFlightsTab_Paint);
            // 
            // gridflightsData
            // 
            this.gridflightsData.AllowUserToAddRows = false;
            this.gridflightsData.AllowUserToDeleteRows = false;
            this.gridflightsData.AllowUserToOrderColumns = true;
            this.gridflightsData.AllowUserToResizeRows = false;
            this.gridflightsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridflightsData.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridflightsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridflightsData.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridflightsData.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridflightsData.Location = new System.Drawing.Point(17, 337);
            this.gridflightsData.Name = "gridflightsData";
            this.gridflightsData.RowHeadersVisible = false;
            this.gridflightsData.RowHeadersWidth = 51;
            this.gridflightsData.RowTemplate.Height = 50;
            this.gridflightsData.Size = new System.Drawing.Size(721, 346);
            this.gridflightsData.TabIndex = 63;
            this.gridflightsData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridflightsData_CellClick);
            this.gridflightsData.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridflightsData_DataBindingComplete);
            // 
            // time
            // 
            this.time.Enabled = false;
            this.time.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.FormattingEnabled = true;
            this.time.Items.AddRange(new object[] {
            "Morning",
            "Night"});
            this.time.Location = new System.Drawing.Point(373, 277);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(287, 41);
            this.time.TabIndex = 62;
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(49, 280);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(284, 37);
            this.date.TabIndex = 56;
            // 
            // arrivalDrop
            // 
            this.arrivalDrop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalDrop.FormattingEnabled = true;
            this.arrivalDrop.Location = new System.Drawing.Point(350, 188);
            this.arrivalDrop.Name = "arrivalDrop";
            this.arrivalDrop.Size = new System.Drawing.Size(300, 41);
            this.arrivalDrop.TabIndex = 49;
            // 
            // depDrop
            // 
            this.depDrop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depDrop.FormattingEnabled = true;
            this.depDrop.Location = new System.Drawing.Point(23, 188);
            this.depDrop.Name = "depDrop";
            this.depDrop.Size = new System.Drawing.Size(300, 41);
            this.depDrop.TabIndex = 48;
            // 
            // dateCheck
            // 
            this.dateCheck.AutoSize = true;
            this.dateCheck.Location = new System.Drawing.Point(25, 286);
            this.dateCheck.Name = "dateCheck";
            this.dateCheck.Size = new System.Drawing.Size(22, 21);
            this.dateCheck.TabIndex = 46;
            this.dateCheck.UseVisualStyleBackColor = true;
            this.dateCheck.CheckedChanged += new System.EventHandler(this.dateCheck_CheckedChanged);
            // 
            // timeCheck
            // 
            this.timeCheck.AutoSize = true;
            this.timeCheck.Location = new System.Drawing.Point(350, 286);
            this.timeCheck.Name = "timeCheck";
            this.timeCheck.Size = new System.Drawing.Size(22, 21);
            this.timeCheck.TabIndex = 45;
            this.timeCheck.UseVisualStyleBackColor = true;
            this.timeCheck.CheckedChanged += new System.EventHandler(this.timeCheck_CheckedChanged);
            // 
            // cancelIcon
            // 
            this.cancelIcon.Image = ((System.Drawing.Image)(resources.GetObject("cancelIcon.Image")));
            this.cancelIcon.Location = new System.Drawing.Point(666, 257);
            this.cancelIcon.Name = "cancelIcon";
            this.cancelIcon.Size = new System.Drawing.Size(72, 52);
            this.cancelIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cancelIcon.TabIndex = 41;
            this.cancelIcon.TabStop = false;
            this.cancelIcon.Click += new System.EventHandler(this.cancelIcon_Click);
            // 
            // searchIcon
            // 
            this.searchIcon.Image = ((System.Drawing.Image)(resources.GetObject("searchIcon.Image")));
            this.searchIcon.Location = new System.Drawing.Point(666, 180);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(72, 52);
            this.searchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchIcon.TabIndex = 38;
            this.searchIcon.TabStop = false;
            this.searchIcon.Click += new System.EventHandler(this.searchIcon_Click);
            // 
            // tabController
            // 
            this.tabController.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabController.Controls.Add(this.travellerFlightsTab);
            this.tabController.Controls.Add(this.travellerBookingsTab);
            this.tabController.Controls.Add(this.travellerSettingsTab);
            this.tabController.Controls.Add(this.travellerNotificationTab);
            this.tabController.Controls.Add(this.flightDetails);
            this.tabController.Controls.Add(this.bookingDetailsTab);
            this.tabController.Controls.Add(this.payment);
            this.tabController.Location = new System.Drawing.Point(137, -4);
            this.tabController.Multiline = true;
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(784, 728);
            this.tabController.TabIndex = 7;
            // 
            // travellerBookingsTab
            // 
            this.travellerBookingsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerBookingsTab.Controls.Add(this.bookingTable);
            this.travellerBookingsTab.Controls.Add(label1);
            this.travellerBookingsTab.Controls.Add(label13);
            this.travellerBookingsTab.Location = new System.Drawing.Point(31, 4);
            this.travellerBookingsTab.Name = "travellerBookingsTab";
            this.travellerBookingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.travellerBookingsTab.Size = new System.Drawing.Size(749, 720);
            this.travellerBookingsTab.TabIndex = 1;
            this.travellerBookingsTab.Text = "Bookings";
            // 
            // bookingTable
            // 
            this.bookingTable.AllowUserToAddRows = false;
            this.bookingTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookingTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.bookingTable.ColumnHeadersHeight = 40;
            this.bookingTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.View,
            this.ID,
            this.from,
            this.to,
            this.dateTime});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookingTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.bookingTable.Location = new System.Drawing.Point(52, 166);
            this.bookingTable.Name = "bookingTable";
            this.bookingTable.ReadOnly = true;
            this.bookingTable.RowHeadersVisible = false;
            this.bookingTable.RowHeadersWidth = 51;
            this.bookingTable.RowTemplate.Height = 50;
            this.bookingTable.Size = new System.Drawing.Size(650, 441);
            this.bookingTable.TabIndex = 5;
            this.bookingTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookingTable_CellClick);
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
            this.travellerSettingsTab.Location = new System.Drawing.Point(31, 4);
            this.travellerSettingsTab.Name = "travellerSettingsTab";
            this.travellerSettingsTab.Size = new System.Drawing.Size(749, 720);
            this.travellerSettingsTab.TabIndex = 2;
            this.travellerSettingsTab.Text = "Settings";
            // 
            // setErrorLbl
            // 
            this.setErrorLbl.AutoSize = true;
            this.setErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.setErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.setErrorLbl.Location = new System.Drawing.Point(19, 448);
            this.setErrorLbl.Name = "setErrorLbl";
            this.setErrorLbl.Size = new System.Drawing.Size(274, 44);
            this.setErrorLbl.TabIndex = 22;
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
            this.setDeleteBtn.Location = new System.Drawing.Point(22, 607);
            this.setDeleteBtn.Name = "setDeleteBtn";
            this.setDeleteBtn.Size = new System.Drawing.Size(152, 46);
            this.setDeleteBtn.TabIndex = 21;
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
            this.setCancelBtn.Location = new System.Drawing.Point(169, 378);
            this.setCancelBtn.Name = "setCancelBtn";
            this.setCancelBtn.Size = new System.Drawing.Size(138, 48);
            this.setCancelBtn.TabIndex = 19;
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
            this.setSaveChanesBtn.Location = new System.Drawing.Point(25, 378);
            this.setSaveChanesBtn.Name = "setSaveChanesBtn";
            this.setSaveChanesBtn.Size = new System.Drawing.Size(138, 48);
            this.setSaveChanesBtn.TabIndex = 18;
            this.setSaveChanesBtn.Text = "Save Changes";
            this.setSaveChanesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.setSaveChanesBtn.UseVisualStyleBackColor = false;
            this.setSaveChanesBtn.Click += new System.EventHandler(this.setSaveChanesBtn_Click);
            // 
            // setPhoneTxt
            // 
            this.setPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setPhoneTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPhoneTxt.Location = new System.Drawing.Point(410, 305);
            this.setPhoneTxt.Name = "setPhoneTxt";
            this.setPhoneTxt.Size = new System.Drawing.Size(325, 51);
            this.setPhoneTxt.TabIndex = 11;
            // 
            // setEmailTxt
            // 
            this.setEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setEmailTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setEmailTxt.Location = new System.Drawing.Point(22, 305);
            this.setEmailTxt.Name = "setEmailTxt";
            this.setEmailTxt.Size = new System.Drawing.Size(362, 51);
            this.setEmailTxt.TabIndex = 10;
            // 
            // setLastNameTxt
            // 
            this.setLastNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setLastNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setLastNameTxt.Location = new System.Drawing.Point(410, 236);
            this.setLastNameTxt.Name = "setLastNameTxt";
            this.setLastNameTxt.Size = new System.Drawing.Size(325, 51);
            this.setLastNameTxt.TabIndex = 9;
            // 
            // setFirstNameTxt
            // 
            this.setFirstNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setFirstNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setFirstNameTxt.Location = new System.Drawing.Point(22, 236);
            this.setFirstNameTxt.Name = "setFirstNameTxt";
            this.setFirstNameTxt.Size = new System.Drawing.Size(362, 51);
            this.setFirstNameTxt.TabIndex = 8;
            // 
            // setPasswordTxt
            // 
            this.setPasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setPasswordTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPasswordTxt.Location = new System.Drawing.Point(410, 167);
            this.setPasswordTxt.Name = "setPasswordTxt";
            this.setPasswordTxt.Size = new System.Drawing.Size(325, 51);
            this.setPasswordTxt.TabIndex = 7;
            // 
            // setUsernameTxt
            // 
            this.setUsernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setUsernameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setUsernameTxt.Location = new System.Drawing.Point(22, 167);
            this.setUsernameTxt.Name = "setUsernameTxt";
            this.setUsernameTxt.Size = new System.Drawing.Size(362, 51);
            this.setUsernameTxt.TabIndex = 6;
            // 
            // travellerNotificationTab
            // 
            this.travellerNotificationTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerNotificationTab.Controls.Add(this.button2);
            this.travellerNotificationTab.Controls.Add(this.dataGridViewNotification);
            this.travellerNotificationTab.Controls.Add(label6);
            this.travellerNotificationTab.Controls.Add(label7);
            this.travellerNotificationTab.Location = new System.Drawing.Point(31, 4);
            this.travellerNotificationTab.Name = "travellerNotificationTab";
            this.travellerNotificationTab.Size = new System.Drawing.Size(749, 720);
            this.travellerNotificationTab.TabIndex = 3;
            this.travellerNotificationTab.Text = "Notification";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(474, 633);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 43);
            this.button2.TabIndex = 77;
            this.button2.Text = "Show Selected Notification ";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewNotification
            // 
            this.dataGridViewNotification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNotification.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewNotification.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNotification.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewNotification.Location = new System.Drawing.Point(25, 124);
            this.dataGridViewNotification.Name = "dataGridViewNotification";
            this.dataGridViewNotification.RowHeadersVisible = false;
            this.dataGridViewNotification.RowHeadersWidth = 51;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewNotification.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewNotification.RowTemplate.Height = 50;
            this.dataGridViewNotification.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewNotification.Size = new System.Drawing.Size(706, 472);
            this.dataGridViewNotification.TabIndex = 9;
            // 
            // flightDetails
            // 
            this.flightDetails.BackColor = System.Drawing.Color.Gainsboro;
            this.flightDetails.Controls.Add(this.fdCancelBtn);
            this.flightDetails.Controls.Add(this.fdBookBtn);
            this.flightDetails.Controls.Add(this.fdArrTxt);
            this.flightDetails.Controls.Add(label27);
            this.flightDetails.Controls.Add(label28);
            this.flightDetails.Controls.Add(this.fdDepTxt);
            this.flightDetails.Controls.Add(this.fdToTxt);
            this.flightDetails.Controls.Add(label25);
            this.flightDetails.Controls.Add(label26);
            this.flightDetails.Controls.Add(this.fdFromTxt);
            this.flightDetails.Controls.Add(this.fdArrTimeTxt);
            this.flightDetails.Controls.Add(label23);
            this.flightDetails.Controls.Add(label24);
            this.flightDetails.Controls.Add(this.fdDepTimeTxt);
            this.flightDetails.Controls.Add(label21);
            this.flightDetails.Controls.Add(this.fdFlightNumTxt);
            this.flightDetails.Controls.Add(this.label19);
            this.flightDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flightDetails.Location = new System.Drawing.Point(31, 4);
            this.flightDetails.Name = "flightDetails";
            this.flightDetails.Padding = new System.Windows.Forms.Padding(3);
            this.flightDetails.Size = new System.Drawing.Size(749, 720);
            this.flightDetails.TabIndex = 4;
            this.flightDetails.Text = "Flight Details";
            // 
            // fdCancelBtn
            // 
            this.fdCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.fdCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fdCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fdCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdCancelBtn.ForeColor = System.Drawing.Color.White;
            this.fdCancelBtn.Location = new System.Drawing.Point(162, 491);
            this.fdCancelBtn.Name = "fdCancelBtn";
            this.fdCancelBtn.Size = new System.Drawing.Size(139, 43);
            this.fdCancelBtn.TabIndex = 32;
            this.fdCancelBtn.Text = "Back";
            this.fdCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.fdCancelBtn.UseVisualStyleBackColor = false;
            this.fdCancelBtn.Click += new System.EventHandler(this.fdCancelBtn_Click);
            // 
            // fdBookBtn
            // 
            this.fdBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.fdBookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fdBookBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fdBookBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdBookBtn.ForeColor = System.Drawing.Color.White;
            this.fdBookBtn.Location = new System.Drawing.Point(17, 491);
            this.fdBookBtn.Name = "fdBookBtn";
            this.fdBookBtn.Size = new System.Drawing.Size(139, 43);
            this.fdBookBtn.TabIndex = 31;
            this.fdBookBtn.Text = "Book";
            this.fdBookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.fdBookBtn.UseVisualStyleBackColor = false;
            this.fdBookBtn.Click += new System.EventHandler(this.fdBookBtn_Click);
            // 
            // fdArrTxt
            // 
            this.fdArrTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.fdArrTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fdArrTxt.Enabled = false;
            this.fdArrTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdArrTxt.Location = new System.Drawing.Point(378, 406);
            this.fdArrTxt.Name = "fdArrTxt";
            this.fdArrTxt.ReadOnly = true;
            this.fdArrTxt.Size = new System.Drawing.Size(246, 44);
            this.fdArrTxt.TabIndex = 30;
            this.fdArrTxt.Text = "Bahrain International Airport";
            // 
            // fdDepTxt
            // 
            this.fdDepTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.fdDepTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fdDepTxt.Enabled = false;
            this.fdDepTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdDepTxt.Location = new System.Drawing.Point(17, 406);
            this.fdDepTxt.Name = "fdDepTxt";
            this.fdDepTxt.ReadOnly = true;
            this.fdDepTxt.Size = new System.Drawing.Size(246, 44);
            this.fdDepTxt.TabIndex = 27;
            this.fdDepTxt.Text = "Cairo International Airport";
            // 
            // fdToTxt
            // 
            this.fdToTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.fdToTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fdToTxt.Enabled = false;
            this.fdToTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdToTxt.Location = new System.Drawing.Point(378, 326);
            this.fdToTxt.Name = "fdToTxt";
            this.fdToTxt.ReadOnly = true;
            this.fdToTxt.Size = new System.Drawing.Size(246, 44);
            this.fdToTxt.TabIndex = 26;
            this.fdToTxt.Text = "Muharraq (Bahrain)";
            // 
            // fdFromTxt
            // 
            this.fdFromTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.fdFromTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fdFromTxt.Enabled = false;
            this.fdFromTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdFromTxt.Location = new System.Drawing.Point(17, 326);
            this.fdFromTxt.Name = "fdFromTxt";
            this.fdFromTxt.ReadOnly = true;
            this.fdFromTxt.Size = new System.Drawing.Size(246, 44);
            this.fdFromTxt.TabIndex = 23;
            this.fdFromTxt.Text = "Cairo (Egypt)";
            // 
            // fdArrTimeTxt
            // 
            this.fdArrTimeTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.fdArrTimeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fdArrTimeTxt.Enabled = false;
            this.fdArrTimeTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdArrTimeTxt.Location = new System.Drawing.Point(378, 238);
            this.fdArrTimeTxt.Name = "fdArrTimeTxt";
            this.fdArrTimeTxt.ReadOnly = true;
            this.fdArrTimeTxt.Size = new System.Drawing.Size(246, 44);
            this.fdArrTimeTxt.TabIndex = 22;
            this.fdArrTimeTxt.Text = "11:00 AM";
            // 
            // fdDepTimeTxt
            // 
            this.fdDepTimeTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.fdDepTimeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fdDepTimeTxt.Enabled = false;
            this.fdDepTimeTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdDepTimeTxt.Location = new System.Drawing.Point(17, 238);
            this.fdDepTimeTxt.Name = "fdDepTimeTxt";
            this.fdDepTimeTxt.ReadOnly = true;
            this.fdDepTimeTxt.Size = new System.Drawing.Size(246, 44);
            this.fdDepTimeTxt.TabIndex = 19;
            this.fdDepTimeTxt.Text = "8:00 AM";
            // 
            // fdFlightNumTxt
            // 
            this.fdFlightNumTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.fdFlightNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fdFlightNumTxt.Enabled = false;
            this.fdFlightNumTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdFlightNumTxt.Location = new System.Drawing.Point(17, 163);
            this.fdFlightNumTxt.Name = "fdFlightNumTxt";
            this.fdFlightNumTxt.ReadOnly = true;
            this.fdFlightNumTxt.Size = new System.Drawing.Size(246, 44);
            this.fdFlightNumTxt.TabIndex = 14;
            this.fdFlightNumTxt.Text = "123";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(7, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(481, 100);
            this.label19.TabIndex = 5;
            this.label19.Text = "Flight Details";
            // 
            // bookingDetailsTab
            // 
            this.bookingDetailsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.bookingDetailsTab.Controls.Add(this.bdFlightStatusTxt);
            this.bookingDetailsTab.Controls.Add(label35);
            this.bookingDetailsTab.Controls.Add(this.flowLayoutPanel1);
            this.bookingDetailsTab.Controls.Add(this.bdTotalPriceTxt);
            this.bookingDetailsTab.Controls.Add(label51);
            this.bookingDetailsTab.Controls.Add(this.bdSeatNumberTxt);
            this.bookingDetailsTab.Controls.Add(label20);
            this.bookingDetailsTab.Controls.Add(label50);
            this.bookingDetailsTab.Controls.Add(this.bdTicketClassTxt);
            this.bookingDetailsTab.Controls.Add(this.bdIDTxt);
            this.bookingDetailsTab.Controls.Add(label38);
            this.bookingDetailsTab.Controls.Add(this.bdArrTxt);
            this.bookingDetailsTab.Controls.Add(label29);
            this.bookingDetailsTab.Controls.Add(label30);
            this.bookingDetailsTab.Controls.Add(this.bdDepTxt);
            this.bookingDetailsTab.Controls.Add(this.bdToTxt);
            this.bookingDetailsTab.Controls.Add(label31);
            this.bookingDetailsTab.Controls.Add(label32);
            this.bookingDetailsTab.Controls.Add(this.bdFromTxt);
            this.bookingDetailsTab.Controls.Add(this.bdArrTimeTxt);
            this.bookingDetailsTab.Controls.Add(label33);
            this.bookingDetailsTab.Controls.Add(label34);
            this.bookingDetailsTab.Controls.Add(this.bdDepTimeTxt);
            this.bookingDetailsTab.Controls.Add(label36);
            this.bookingDetailsTab.Controls.Add(this.bdFlightNumTxt);
            this.bookingDetailsTab.Controls.Add(label37);
            this.bookingDetailsTab.Location = new System.Drawing.Point(31, 4);
            this.bookingDetailsTab.Name = "bookingDetailsTab";
            this.bookingDetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.bookingDetailsTab.Size = new System.Drawing.Size(749, 720);
            this.bookingDetailsTab.TabIndex = 5;
            this.bookingDetailsTab.Text = "Booking Details";
            // 
            // bdSeatNumberTxt
            // 
            this.bdSeatNumberTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdSeatNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdSeatNumberTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdSeatNumberTxt.Location = new System.Drawing.Point(393, 461);
            this.bdSeatNumberTxt.Name = "bdSeatNumberTxt";
            this.bdSeatNumberTxt.ReadOnly = true;
            this.bdSeatNumberTxt.Size = new System.Drawing.Size(246, 44);
            this.bdSeatNumberTxt.TabIndex = 57;
            this.bdSeatNumberTxt.Text = "Bahrain International Airport";
            // 
            // bdTicketClassTxt
            // 
            this.bdTicketClassTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdTicketClassTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdTicketClassTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdTicketClassTxt.Location = new System.Drawing.Point(32, 467);
            this.bdTicketClassTxt.Name = "bdTicketClassTxt";
            this.bdTicketClassTxt.ReadOnly = true;
            this.bdTicketClassTxt.Size = new System.Drawing.Size(246, 44);
            this.bdTicketClassTxt.TabIndex = 54;
            this.bdTicketClassTxt.Text = "Cairo International Airport";
            // 
            // bdIDTxt
            // 
            this.bdIDTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdIDTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdIDTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdIDTxt.Location = new System.Drawing.Point(139, 106);
            this.bdIDTxt.Name = "bdIDTxt";
            this.bdIDTxt.ReadOnly = true;
            this.bdIDTxt.Size = new System.Drawing.Size(246, 44);
            this.bdIDTxt.TabIndex = 53;
            this.bdIDTxt.Text = "123";
            // 
            // bdBackBtn
            // 
            this.bdBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bdBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bdBackBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bdBackBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdBackBtn.ForeColor = System.Drawing.Color.White;
            this.bdBackBtn.Location = new System.Drawing.Point(205, 3);
            this.bdBackBtn.Name = "bdBackBtn";
            this.bdBackBtn.Size = new System.Drawing.Size(194, 48);
            this.bdBackBtn.TabIndex = 51;
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
            this.bdCancelBtn.Location = new System.Drawing.Point(3, 3);
            this.bdCancelBtn.Name = "bdCancelBtn";
            this.bdCancelBtn.Size = new System.Drawing.Size(196, 48);
            this.bdCancelBtn.TabIndex = 50;
            this.bdCancelBtn.Text = "Cancel the booking";
            this.bdCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bdCancelBtn.UseVisualStyleBackColor = false;
            this.bdCancelBtn.Click += new System.EventHandler(this.bdCancelBtn_Click);
            // 
            // bdArrTxt
            // 
            this.bdArrTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdArrTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdArrTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdArrTxt.Location = new System.Drawing.Point(393, 380);
            this.bdArrTxt.Name = "bdArrTxt";
            this.bdArrTxt.ReadOnly = true;
            this.bdArrTxt.Size = new System.Drawing.Size(246, 44);
            this.bdArrTxt.TabIndex = 49;
            this.bdArrTxt.Text = "Bahrain International Airport";
            // 
            // bdDepTxt
            // 
            this.bdDepTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdDepTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdDepTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdDepTxt.Location = new System.Drawing.Point(32, 380);
            this.bdDepTxt.Name = "bdDepTxt";
            this.bdDepTxt.ReadOnly = true;
            this.bdDepTxt.Size = new System.Drawing.Size(246, 44);
            this.bdDepTxt.TabIndex = 46;
            this.bdDepTxt.Text = "Cairo International Airport";
            // 
            // bdToTxt
            // 
            this.bdToTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdToTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdToTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdToTxt.Location = new System.Drawing.Point(393, 300);
            this.bdToTxt.Name = "bdToTxt";
            this.bdToTxt.ReadOnly = true;
            this.bdToTxt.Size = new System.Drawing.Size(246, 44);
            this.bdToTxt.TabIndex = 45;
            this.bdToTxt.Text = "Muharraq (Bahrain)";
            // 
            // bdFromTxt
            // 
            this.bdFromTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdFromTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdFromTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdFromTxt.Location = new System.Drawing.Point(32, 300);
            this.bdFromTxt.Name = "bdFromTxt";
            this.bdFromTxt.ReadOnly = true;
            this.bdFromTxt.Size = new System.Drawing.Size(246, 44);
            this.bdFromTxt.TabIndex = 42;
            this.bdFromTxt.Text = "Cairo (Egypt)";
            // 
            // bdArrTimeTxt
            // 
            this.bdArrTimeTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdArrTimeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdArrTimeTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdArrTimeTxt.Location = new System.Drawing.Point(393, 212);
            this.bdArrTimeTxt.Name = "bdArrTimeTxt";
            this.bdArrTimeTxt.ReadOnly = true;
            this.bdArrTimeTxt.Size = new System.Drawing.Size(246, 44);
            this.bdArrTimeTxt.TabIndex = 41;
            this.bdArrTimeTxt.Text = "11:00 AM";
            // 
            // bdDepTimeTxt
            // 
            this.bdDepTimeTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdDepTimeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdDepTimeTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdDepTimeTxt.Location = new System.Drawing.Point(32, 212);
            this.bdDepTimeTxt.Name = "bdDepTimeTxt";
            this.bdDepTimeTxt.ReadOnly = true;
            this.bdDepTimeTxt.Size = new System.Drawing.Size(246, 44);
            this.bdDepTimeTxt.TabIndex = 38;
            this.bdDepTimeTxt.Text = "8:00 AM";
            // 
            // bdFlightNumTxt
            // 
            this.bdFlightNumTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdFlightNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdFlightNumTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdFlightNumTxt.Location = new System.Drawing.Point(533, 106);
            this.bdFlightNumTxt.Name = "bdFlightNumTxt";
            this.bdFlightNumTxt.ReadOnly = true;
            this.bdFlightNumTxt.Size = new System.Drawing.Size(246, 44);
            this.bdFlightNumTxt.TabIndex = 34;
            this.bdFlightNumTxt.Text = "123";
            // 
            // payment
            // 
            this.payment.BackColor = System.Drawing.Color.Gainsboro;
            this.payment.Controls.Add(this.ppTicketClassDrop);
            this.payment.Controls.Add(this.paymentErrorLbl);
            this.payment.Controls.Add(this.ppTotaLbl);
            this.payment.Controls.Add(label49);
            this.payment.Controls.Add(label48);
            this.payment.Controls.Add(this.ppDatePick);
            this.payment.Controls.Add(this.ppCancelBtn);
            this.payment.Controls.Add(this.ppPayBtn);
            this.payment.Controls.Add(label46);
            this.payment.Controls.Add(this.ppCvvTxt);
            this.payment.Controls.Add(label47);
            this.payment.Controls.Add(this.ppNameCardTxt);
            this.payment.Controls.Add(label45);
            this.payment.Controls.Add(label44);
            this.payment.Controls.Add(this.ppCardNumTxt);
            this.payment.Controls.Add(this.pictureBox3);
            this.payment.Controls.Add(this.pictureBox2);
            this.payment.Controls.Add(this.pictureBox1);
            this.payment.Controls.Add(this.ppAeRadio);
            this.payment.Controls.Add(this.ppVisaRadio);
            this.payment.Controls.Add(this.ppCcRadio);
            this.payment.Controls.Add(label43);
            this.payment.Controls.Add(label42);
            this.payment.Controls.Add(this.ppPasportNumTxt);
            this.payment.Controls.Add(label41);
            this.payment.Controls.Add(label39);
            this.payment.Controls.Add(this.ppFlightNumTxt);
            this.payment.Controls.Add(label40);
            this.payment.Location = new System.Drawing.Point(31, 4);
            this.payment.Name = "payment";
            this.payment.Padding = new System.Windows.Forms.Padding(3);
            this.payment.Size = new System.Drawing.Size(749, 720);
            this.payment.TabIndex = 6;
            this.payment.Text = "Payment";
            // 
            // ppTicketClassDrop
            // 
            this.ppTicketClassDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.ppTicketClassDrop.FormattingEnabled = true;
            this.ppTicketClassDrop.Location = new System.Drawing.Point(24, 236);
            this.ppTicketClassDrop.Name = "ppTicketClassDrop";
            this.ppTicketClassDrop.Size = new System.Drawing.Size(246, 52);
            this.ppTicketClassDrop.TabIndex = 83;
            this.ppTicketClassDrop.SelectedIndexChanged += new System.EventHandler(this.ppTicketClassDrop_SelectedIndexChanged);
            // 
            // paymentErrorLbl
            // 
            this.paymentErrorLbl.AutoSize = true;
            this.paymentErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.paymentErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.paymentErrorLbl.Location = new System.Drawing.Point(346, 662);
            this.paymentErrorLbl.Name = "paymentErrorLbl";
            this.paymentErrorLbl.Size = new System.Drawing.Size(274, 44);
            this.paymentErrorLbl.TabIndex = 82;
            this.paymentErrorLbl.Text = "Error: Please fix..";
            this.paymentErrorLbl.Visible = false;
            // 
            // ppTotaLbl
            // 
            this.ppTotaLbl.AutoSize = true;
            this.ppTotaLbl.BackColor = System.Drawing.Color.Transparent;
            this.ppTotaLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppTotaLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ppTotaLbl.Location = new System.Drawing.Point(142, 594);
            this.ppTotaLbl.Name = "ppTotaLbl";
            this.ppTotaLbl.Size = new System.Drawing.Size(87, 51);
            this.ppTotaLbl.TabIndex = 81;
            this.ppTotaLbl.Text = "1500";
            this.ppTotaLbl.UseCompatibleTextRendering = true;
            // 
            // ppDatePick
            // 
            this.ppDatePick.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.ppDatePick.Location = new System.Drawing.Point(351, 448);
            this.ppDatePick.Name = "ppDatePick";
            this.ppDatePick.Size = new System.Drawing.Size(246, 51);
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
            this.ppCvvTxt.Location = new System.Drawing.Point(351, 532);
            this.ppCvvTxt.Name = "ppCvvTxt";
            this.ppCvvTxt.Size = new System.Drawing.Size(246, 51);
            this.ppCvvTxt.TabIndex = 74;
            // 
            // ppNameCardTxt
            // 
            this.ppNameCardTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ppNameCardTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppNameCardTxt.Location = new System.Drawing.Point(24, 532);
            this.ppNameCardTxt.Name = "ppNameCardTxt";
            this.ppNameCardTxt.Size = new System.Drawing.Size(246, 51);
            this.ppNameCardTxt.TabIndex = 72;
            // 
            // ppCardNumTxt
            // 
            this.ppCardNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ppCardNumTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppCardNumTxt.Location = new System.Drawing.Point(24, 447);
            this.ppCardNumTxt.Name = "ppCardNumTxt";
            this.ppCardNumTxt.Size = new System.Drawing.Size(246, 51);
            this.ppCardNumTxt.TabIndex = 68;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HappyJourneyAirline.Properties.Resources.AmericanExpress;
            this.pictureBox3.Location = new System.Drawing.Point(276, 319);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 67;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HappyJourneyAirline.Properties.Resources.Visa;
            this.pictureBox2.Location = new System.Drawing.Point(157, 319);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HappyJourneyAirline.Properties.Resources.CreditCard;
            this.pictureBox1.Location = new System.Drawing.Point(44, 319);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // ppAeRadio
            // 
            this.ppAeRadio.AutoSize = true;
            this.ppAeRadio.Location = new System.Drawing.Point(256, 345);
            this.ppAeRadio.Name = "ppAeRadio";
            this.ppAeRadio.Size = new System.Drawing.Size(21, 20);
            this.ppAeRadio.TabIndex = 64;
            this.ppAeRadio.TabStop = true;
            this.ppAeRadio.UseVisualStyleBackColor = true;
            // 
            // ppVisaRadio
            // 
            this.ppVisaRadio.AutoSize = true;
            this.ppVisaRadio.Location = new System.Drawing.Point(137, 345);
            this.ppVisaRadio.Name = "ppVisaRadio";
            this.ppVisaRadio.Size = new System.Drawing.Size(21, 20);
            this.ppVisaRadio.TabIndex = 63;
            this.ppVisaRadio.TabStop = true;
            this.ppVisaRadio.UseVisualStyleBackColor = true;
            // 
            // ppCcRadio
            // 
            this.ppCcRadio.AutoSize = true;
            this.ppCcRadio.Location = new System.Drawing.Point(24, 345);
            this.ppCcRadio.Name = "ppCcRadio";
            this.ppCcRadio.Size = new System.Drawing.Size(21, 20);
            this.ppCcRadio.TabIndex = 62;
            this.ppCcRadio.TabStop = true;
            this.ppCcRadio.UseVisualStyleBackColor = true;
            // 
            // ppPasportNumTxt
            // 
            this.ppPasportNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ppPasportNumTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppPasportNumTxt.Location = new System.Drawing.Point(351, 235);
            this.ppPasportNumTxt.Name = "ppPasportNumTxt";
            this.ppPasportNumTxt.Size = new System.Drawing.Size(246, 51);
            this.ppPasportNumTxt.TabIndex = 59;
            // 
            // ppFlightNumTxt
            // 
            this.ppFlightNumTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.ppFlightNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ppFlightNumTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppFlightNumTxt.Location = new System.Drawing.Point(24, 152);
            this.ppFlightNumTxt.Name = "ppFlightNumTxt";
            this.ppFlightNumTxt.ReadOnly = true;
            this.ppFlightNumTxt.Size = new System.Drawing.Size(246, 44);
            this.ppFlightNumTxt.TabIndex = 55;
            this.ppFlightNumTxt.Text = "123";
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
            this.panel1.TabIndex = 8;
            // 
            // notificationTab
            // 
            this.notificationTab.Image = global::HappyJourneyAirline.Properties.Resources.Notification;
            this.notificationTab.Location = new System.Drawing.Point(30, 396);
            this.notificationTab.Name = "notificationTab";
            this.notificationTab.Size = new System.Drawing.Size(106, 89);
            this.notificationTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.notificationTab.TabIndex = 9;
            this.notificationTab.TabStop = false;
            this.notificationTab.Click += new System.EventHandler(this.notificationTab_Click);
            // 
            // logOutIcon
            // 
            this.logOutIcon.Image = global::HappyJourneyAirline.Properties.Resources.log_out;
            this.logOutIcon.Location = new System.Drawing.Point(33, 637);
            this.logOutIcon.Name = "logOutIcon";
            this.logOutIcon.Size = new System.Drawing.Size(100, 50);
            this.logOutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logOutIcon.TabIndex = 7;
            this.logOutIcon.TabStop = false;
            this.logOutIcon.Click += new System.EventHandler(this.logOutIcon_Click);
            // 
            // settingTab
            // 
            this.settingTab.Image = global::HappyJourneyAirline.Properties.Resources.Settings_Icon;
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
            this.flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights;
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
            this.bookingTab.Image = global::HappyJourneyAirline.Properties.Resources.Bookings;
            this.bookingTab.Location = new System.Drawing.Point(31, 276);
            this.bookingTab.Name = "bookingTab";
            this.bookingTab.Size = new System.Drawing.Size(104, 80);
            this.bookingTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookingTab.TabIndex = 5;
            this.bookingTab.TabStop = false;
            this.bookingTab.Click += new System.EventHandler(this.bookingTab_Click);
            // 
            // View
            // 
            this.View.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.View.HeaderText = "View";
            this.View.MinimumWidth = 8;
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Width = 104;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 76;
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
            // bdTotalPriceTxt
            // 
            this.bdTotalPriceTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdTotalPriceTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdTotalPriceTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdTotalPriceTxt.Location = new System.Drawing.Point(393, 540);
            this.bdTotalPriceTxt.Name = "bdTotalPriceTxt";
            this.bdTotalPriceTxt.ReadOnly = true;
            this.bdTotalPriceTxt.Size = new System.Drawing.Size(246, 44);
            this.bdTotalPriceTxt.TabIndex = 59;
            this.bdTotalPriceTxt.Text = "Bahrain International Airport";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.BackColor = System.Drawing.Color.Transparent;
            label51.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label51.Location = new System.Drawing.Point(393, 514);
            label51.Name = "label51";
            label51.Size = new System.Drawing.Size(184, 51);
            label51.TabIndex = 58;
            label51.Text = "Total Price:";
            label51.UseCompatibleTextRendering = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bdCancelBtn);
            this.flowLayoutPanel1.Controls.Add(this.bdBackBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 645);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(488, 58);
            this.flowLayoutPanel1.TabIndex = 60;
            // 
            // bdFlightStatusTxt
            // 
            this.bdFlightStatusTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdFlightStatusTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdFlightStatusTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdFlightStatusTxt.Location = new System.Drawing.Point(32, 547);
            this.bdFlightStatusTxt.Name = "bdFlightStatusTxt";
            this.bdFlightStatusTxt.ReadOnly = true;
            this.bdFlightStatusTxt.Size = new System.Drawing.Size(246, 44);
            this.bdFlightStatusTxt.TabIndex = 62;
            this.bdFlightStatusTxt.Text = "Bahrain International Airport";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.BackColor = System.Drawing.Color.Transparent;
            label35.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label35.Location = new System.Drawing.Point(32, 521);
            label35.Name = "label35";
            label35.Size = new System.Drawing.Size(211, 51);
            label35.TabIndex = 61;
            label35.Text = "Flight Status:";
            label35.UseCompatibleTextRendering = true;
            // 
            // TravellerTabs
            // 
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.panel1);
            this.Name = "TravellerTabs";
            this.Size = new System.Drawing.Size(921, 728);
            this.travellerFlightsTab.ResumeLayout(false);
            this.travellerFlightsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridflightsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            this.tabController.ResumeLayout(false);
            this.travellerBookingsTab.ResumeLayout(false);
            this.travellerBookingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTable)).EndInit();
            this.travellerSettingsTab.ResumeLayout(false);
            this.travellerSettingsTab.PerformLayout();
            this.travellerNotificationTab.ResumeLayout(false);
            this.travellerNotificationTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotification)).EndInit();
            this.flightDetails.ResumeLayout(false);
            this.flightDetails.PerformLayout();
            this.bookingDetailsTab.ResumeLayout(false);
            this.bookingDetailsTab.PerformLayout();
            this.payment.ResumeLayout(false);
            this.payment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notificationTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTab)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #region Sidebar Navigation

        /// <summary>
        /// This method will be trigger in case of clickig on the flight icon (flight tab) in the traveller side.
        /// Als, it will chnage the scrren to the flight section 
        /// </summary>
        /// <param name="sender"> the sender object (flight icon)</param>
        /// <param name="e">evnt object (click)</param>
        private void flightsTab_Click(object sender, EventArgs e)
        {
            //chnage the tab to the flight tab
            tabController.SelectTab(0);
            defultIcons();
            //change the icon image to look like it is selected 
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights_Active;


            //call the flightDataLoad method to load the current flights into the gridview 
            flightDataLoad();

            try
            {
                //clear both comboBox that shows the available airports names 
                depDrop.Items.Clear();
                arrivalDrop.Items.Clear();


                List<Airport> airportList = new List<Airport>();
                
                //get all the airpots records from the database and save itinto list variable 
                airportList = Airport.GetAllAirports();

                // check if the list not empty, meaning if there is airports records in the database 
                if (airportList == null || airportList.Count == 0)
                {
                    Console.WriteLine("No airports found.");
                    return;
                }
                else
                {
                    //set both comboboxes with the airports names 
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

        /// <summary>
        /// This method will trigger in case of clicking on the booking tab leading to show the booking tab page
        /// </summary>
        /// <param name="sender"> the button </param>
        /// <param name="e"> Clicking action </param>
        private void bookingTab_Click(object sender, EventArgs e)
        {
            //chnage to th booking tab 
            tabController.SelectTab(1);
            defultIcons();
            bookingTab.Image = global::HappyJourneyAirline.Properties.Resources.Bookings_Active;

            //load the booking data from the database and place them into the gridview using the loadBookingTable method
            loadBookingTable();

        }


        /// <summary>
        /// This method will trigger in case of clicking on the setting tab leading to show the setting tab page
        /// </summary>
        /// <param name="sender"> the button </param>
        /// <param name="e"> Clicking action </param>
        private void settingTab_Click(object sender, EventArgs e)
        {
            //chnage to the setting tab 
            tabController.SelectTab(2);
            defultIcons();
            settingTab.Image = global::HappyJourneyAirline.Properties.Resources.Settings_Active;

            //get the loged in user and save it in a variable called currentUser.
            //GetUserById is static method in User model, GetCurrentUserId is method in the AuthService that return the current loged in user 
            User currentUser = User.GetUserById(AuthService.GetCurrentUserId());

            //set the text field in the ui with current user information 
            setUsernameTxt.Text = currentUser.Username;
            setFirstNameTxt.Text = currentUser.FirstName;
            setEmailTxt.Text = currentUser.Email;
            setPasswordTxt.Text = currentUser.Password;
            setLastNameTxt.Text = currentUser.LastName;
            setPhoneTxt.Text = currentUser.PhoneNumber;

        }


        /// <summary>
        /// This method will trigger in case of notification on the setting tab leading to show the notification tab page
        /// </summary>
        /// <param name="sender"> the button </param>
        /// <param name="e"> Clicking action </param>
        private void notificationTab_Click(object sender, EventArgs e)
        {

            //chnage the to the notification page 
            tabController.SelectTab(3);
            defultIcons();
            notificationTab.Image = global::HappyJourneyAirline.Properties.Resources.Notification_Active;

            //get all the notification that is related to the current loged in user and save the result into a list 
            List<Notification> list = Notification.GetNotificationsByUserId(AuthService.GetCurrentUserId());

            //set the dat list in the gridview 
            dataGridViewNotification.DataSource = list;


            // Disable automatic column generation
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

        /// <summary>
        /// this method was used by all the tabs clicking actions methods that is provided for the traveller.
        /// This method will reset the other tabs by seting the tab image to the defualt image 
        /// </summary>
        private void defultIcons() { 
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights;
            bookingTab.Image = global::HappyJourneyAirline.Properties.Resources.Bookings;
            settingTab.Image = global::HappyJourneyAirline.Properties.Resources.Settings_Icon;
            notificationTab.Image = global::HappyJourneyAirline.Properties.Resources.Notification;
        }

        #endregion Sidebar Navigation

        #region Flights Tab
        

        /// <summary>
        /// This method will be trigger in case of clicking on the blue button (search button) leading to show a diffrent result depanding on 
        /// the user specifications 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                    Console.WriteLine(cmd.CommandText);
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
                catch (Exception error)
                {
                    Console.WriteLine(error);
                }
            }
        }

        /// <summary>
        /// This method will load all the flight records from the database.
        /// This methhod used to refresh the flights records in the gridview 
        /// </summary>
        private void flightDataLoad()
        {

            try
            {

                //having two lists have the smae information which t is the all airports records 
                List<Airport> airportList = new List<Airport>();

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

                    //make the first choise in the list All 
                    airportList.Insert(0, allOption);
                    airportList2.Insert(0, allOption);

                    //set the list to the coboBox 
                    depDrop.DataSource = null;
                    depDrop.DataSource = airportList;
                    depDrop.DisplayMember = "Name";

                    arrivalDrop.DataSource = null;
                    arrivalDrop.DataSource = airportList2;
                    arrivalDrop.DisplayMember = "Name";
                }



                //create sql connection
                SqlConnection conn = new SqlConnection(Database.connectionString);
                SqlCommand cmd = conn.CreateCommand();
                
                //a query to retravel all Scheduled and Delayed the flights from the database 
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

                //create adapter to connect the command result with datatable 
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

                


                //set the data in the gridview 
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
        /// <summary>
        /// This method will be trigger in case of clicking on the cancel button.
        /// It will load all the flights and show them for the user, at the same time will remove any filtring on the flighhts 
        /// </summary>
        /// <param name="sender"> cancel button</param>
        /// <param name="e"> Clicking Action </param>
        private void cancelIcon_Click(object sender, EventArgs e)
        {
            //reset the filtring and fileds 
            dateCheck.CheckState = CheckState.Unchecked;
            timeCheck.CheckState = CheckState.Unchecked;
            arrivalDrop.SelectedIndex = 0;
            depDrop.SelectedIndex = 0;

            depDrop.SelectedIndex = 0;
            arrivalDrop.SelectedIndex = 0;

            //load the flights data 
            flightDataLoad();
            return;
        }



        /// <summary>
        /// This method handles the action when button2 is clicked.
        /// It retrieves the selected notification from the DataGridView and displays its details in a message box.
        /// </summary>
        /// <param name="sender">The button2 control</param>
        /// <param name="e">The click event associated with button2</param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the selected notification
                var selectedObject = dataGridViewNotification.SelectedCells[0].OwningRow.DataBoundItem as Notification;

                if (selectedObject != null)
                {
                    // Show the notification details in a message box
                    MessageBox.Show(selectedObject.Description, selectedObject.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch { }
        }

        /// <summary>
        /// This method handles the action when button1 is clicked.
        /// It retrieves the selected flight from the grid, updates the UI, and switches to the booking tab.
        /// </summary>
        /// <param name="sender">The button1 control</param>
        /// <param name="e">The click event associated with button1</param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected flight ID from the DataGridView
            int selectedId = Convert.ToInt32(gridflightsData.SelectedCells[0].OwningRow.Cells[0].Value);
            tabController.SelectTab(1);
            defultIcons();
            bookingTab.Image = global::HappyJourneyAirline.Properties.Resources.Bookings_Active;

            // Retrieve the selected flight details and update the label
            selectedFlight = Flight.GetFlightById(selectedId);
        }

        private void travellerFlightsTab_Paint(object sender, PaintEventArgs e)
        {
            //load the flights reords 
            flightDataLoad();
        }

        private void gridflightsData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //foreach (DataGridViewRow row in (sender as DataGridView).Rows)
            //{
            //    row.Cells[0].Value = "View";
            //}
        }

        private void gridflightsData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                previosTab = 0;
                selectedFlight = Flight.GetFlightById((int)(gridflightsData.Rows[e.RowIndex].Cells[1].Value));
                sutupFlightDetails();
                tabController.SelectTab(4);
            }
        }


        /// <summary>
        /// This method is triggered when the "dateCheck" checkbox's state changes.
        /// It enables or disables the "date" control based on whether the checkbox is checked.
        /// </summary>
        /// <param name="sender">The dateCheck checkbox control</param>
        /// <param name="e">The event triggered when the checkbox's state changes</param>
        private void dateCheck_CheckedChanged(object sender, EventArgs e)
        {
            // Enable or disable the date control based on the checkbox's state
            if (dateCheck.Checked)
            {
                date.Enabled = true;
            }
            else
            {
                date.Enabled = false;
            }
        }

        /// <summary>
        /// This method is triggered when the "timeCheck" checkbox's state changes.
        /// It enables or disables the "time" control and updates its text when enabled.
        /// </summary>
        /// <param name="sender">The timeCheck checkbox control</param>
        /// <param name="e">The event triggered when the checkbox's state changes</param>
        private void timeCheck_CheckedChanged(object sender, EventArgs e)
        {
            //time.Enabled = timeCheck.Checked;
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

        #endregion Flights Tab

        #region Flight Details Tab

        /// <summary>
        /// This method sets up the flight details in the user interface based on the selected flight.
        /// It retrieves and displays information about the flight number, departure/arrival airports,
        /// departure/arrival cities, countries, and timestamps.
        /// </summary>
        private void sutupFlightDetails()
        {
            // Display the selected flight's ID in the flight number text box
            fdFlightNumTxt.Text = $"{selectedFlight.Id}";

            // Retrieve departure and destination airport details
            Airport depAirport = Airport.GetAirportById(selectedFlight.SourceAirportID);
            Airport destAirport = Airport.GetAirportById(selectedFlight.DestinationAirportID);

            // Retrieve departure and destination city details
            City depCity = City.GetCityById(depAirport.CityId);
            City destCity = City.GetCityById(destAirport.CityId);

            // Retrieve departure and destination country details
            Country depCountry = Country.GetCountryById(depCity.CountryId);
            Country destCountry = Country.GetCountryById(destCity.CountryId);

            // Set the text fields for departure and arrival airports
            fdArrTxt.Text = destAirport.Name;
            fdDepTxt.Text = depAirport.Name;

            // Set the text fields for departure and destination locations (City and Country)
            fdFromTxt.Text = $"{depCity.Name} ({depCountry.Name})";
            fdToTxt.Text = $"{destCity.Name} ({destCountry.Name})";

            // Set the text fields for departure and arrival times
            fdArrTimeTxt.Text = $"{selectedFlight.ArrivalTimestamp}";
            fdDepTimeTxt.Text = $"{selectedFlight.DepartureTimestamp}";


        }


        /// <summary>
        /// This method is triggered when the cancel button is clicked in the flight details view.
        /// It resets the selected flight and navigates back to the main tab.
        /// </summary>
        /// <param name="sender">The cancel button control</param>
        /// <param name="e">The click event associated with the cancel button</param>
        private void fdCancelBtn_Click(object sender, EventArgs e)
        {
            // Reset the selected flight
            selectedFlight = null;

            // Navigate back to the main tab
            tabController.SelectTab(0);
        }


        /// <summary>
        /// This method is triggered when the book button is clicked in the flight details view.
        /// It initializes the booking form with the selected flight details and switches to the payment tab.
        /// </summary>
        /// <param name="sender">The book button control</param>
        /// <param name="e">The click event associated with the book button</param>
        private void fdBookBtn_Click(object sender, EventArgs e)
        {
            // Populate the booking form with the selected flight's details
            ppFlightNumTxt.Text = $"{selectedFlight.Id}";
            ppTotaLbl.Text = $"{selectedFlight.BasePrice}";

            // Clear the payment input fields
            ppPasportNumTxt.Text = "";
            ppCardNumTxt.Text = "";
            ppNameCardTxt.Text = "";
            ppCvvTxt.Text = "";

            // Hide any payment error messages
            paymentErrorLbl.Visible = false;

            try
            {
                // Clear and populate the ticket class dropdown
                ppTicketClassDrop.Items.Clear();
                List<TicketClass> ticketClassList = TicketClass.GetAllTicketClasses();

                if (ticketClassList == null || ticketClassList.Count == 0)
                {
                    Console.WriteLine("No Classes found.");
                    return;
                }
                else
                {
                    ppTicketClassDrop.DataSource = ticketClassList;
                    ppTicketClassDrop.DisplayMember = "Name";
                }
            }
            catch
            {
                // Handle exceptions silently (consider logging the exception for debugging)
            }

            // Navigate to the payment tab
            tabController.SelectTab(6);
        }

        #endregion Flight Details Tab

        #region Booking Screen


        /// <summary>
        /// Loads the user's booking data into the booking table.
        /// It retrieves tickets associated with the currently logged-in user,
        /// and for each ticket, retrieves flight details and populates the table rows.
        /// </summary>
        private void loadBookingTable() {
            // Clear existing rows in the booking table
            bookingTable.Rows.Clear();

            // Retrieve the tickets for the current user
            List<Ticket> tickets = Ticket.GetTicketsByUserId((int)AuthService.GetCurrentUserId());

            foreach (Ticket ticket in tickets)
            {
                // Retrieve flight and airport details for the ticket
                Flight flight = Flight.GetFlightById(ticket.FlightID);
                Airport source = Airport.GetAirportById(flight.SourceAirportID);
                Airport destination = Airport.GetAirportById(flight.DestinationAirportID);

                // Add a row to the booking table with ticket and flight details
                bookingTable.Rows.Add("View",  ticket.Id, source.Name, destination.Name, flight.DepartureTimestamp);
            }
        }


        /// <summary>
        /// Handles the event when a cell is clicked in the booking table.
        /// If the clicked cell is a button, it retrieves the ticket and flight details
        /// for the selected row, displays the information in the flight details section, 
        /// and navigates to the flight details tab.
        /// </summary>
        /// <param name="sender">The booking table control</param>
        /// <param name="e">The cell click event associated with the booking table</param>
        private void bookingTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        #endregion Booking Screen

        #region Booking Details

        /// <summary>
        /// Handles the event when the Back button in the Booking Details tab is clicked.
        /// Navigates back to the Booking List tab and reloads the booking table data.
        /// </summary>
        /// <param name="sender">The Back button control</param>
        /// <param name="e">The event data associated with the button click</param>
        private void bdBackBtn_Click(object sender, EventArgs e)
        {
            tabController.SelectTab(1);
            loadBookingTable();
        }


        /// <summary>
        /// Handles the event when the Cancel button in the Booking Details tab is clicked.
        /// Validates the input, confirms the action with the user, and deletes the ticket if confirmed.
        /// </summary>
        /// <param name="sender">The Cancel button control</param>
        /// <param name="e">The event data associated with the button click</param>
        private void bdCancelBtn_Click(object sender, EventArgs e)
        {
            // Validate input and parse Ticket ID
            if (!int.TryParse(bdIDTxt.Text, out int ticketId) || ticketId <= 0)
            {
                MessageBox.Show("Please enter a valid Ticket ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm deletion with the user
            var confirmResult = MessageBox.Show(
                $"Are you sure you want to delete Ticket ID {ticketId}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Attempt to delete the ticket
                    bool isDeleted = Ticket.DeleteTicket(ticketId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Ticket deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadBookingTable();
                        tabController.SelectTab(1);
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

        #region Settings Tab

        /// <summary>
        /// Handles the event triggered by clicking the Cancel button in the Settings tab.
        /// Navigates back to the main Flights tab, resets the tab controller, and populates the user's information in the settings fields.
        /// </summary>
        /// <param name="sender">The Cancel button control</param>
        /// <param name="e">The event data associated with the button click</param>
        private void setCancelBtn_Click(object sender, EventArgs e)
        {
            //get the curren user 
            User currentUser = User.GetUserById(AuthService.GetCurrentUserId());

            //set the text fields with current user information 
            setUsernameTxt.Text = currentUser.Username;
            setFirstNameTxt.Text = currentUser.FirstName;
            setEmailTxt.Text = currentUser.Email;
            setPasswordTxt.Text = currentUser.Password;
            setLastNameTxt.Text = currentUser.LastName;
            setPhoneTxt.Text = currentUser.PhoneNumber;
        }



        /// <summary>
        /// Handles the Save Changes button click event in the Settings tab.
        /// Validates user input for required fields and updates the user's information in the database.
        /// Displays appropriate error or success messages based on the result of the operation.
        /// </summary>
        /// <param name="sender">The Save Changes button control</param>
        /// <param name="e">The event data associated with the button click</param>
        private void setSaveChanesBtn_Click(object sender, EventArgs e)
        {
            // Retrieve the current user from the database using their ID
            User currentUser = User.GetUserById(AuthService.GetCurrentUserId());

            // Initialize a list to collect names of fields that are empty
            List<string> list = new List<string>();
            bool valid = true;

            // Validate each field and add the field name to the list if empty
            if (string.IsNullOrEmpty(setUsernameTxt.Text))
            {
                list.Add("Username");
                valid = false;
            }

            if (string.IsNullOrEmpty(setFirstNameTxt.Text))
            {
                list.Add("First Name");
                valid = false;
            }

            if (string.IsNullOrEmpty(setLastNameTxt.Text))
            {
                list.Add("Last Name");
                valid = false;
            }

            if (string.IsNullOrEmpty(setPasswordTxt.Text))
            {
                list.Add("Password");
                valid = false;
            }

            if (string.IsNullOrEmpty(setEmailTxt.Text))
            {
                list.Add("Email");
                valid = false;
            }

            if (string.IsNullOrEmpty(setPhoneTxt.Text))
            {
                list.Add("Phone Number");
                valid = false;
            }

            // If validation fails, show an error message
            if (!valid)
            {
                // Create an error message from the list of empty fields
                string message = list[0];
                for (int i = 1; i < list.Count; i++)
                {
                    message += ", " + list[i];
                }

                // Display the error message in a label and a message box
                setErrorLbl.Visible = true;
                setErrorLbl.Text = "Error: Please fill the following fields: " + message;

                MessageBox.Show("Error", "All fields are required", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


                // Update the user's information with the new values from the input fields
                currentUser.PhoneNumber = setPhoneTxt.Text;
                currentUser.Username = setUsernameTxt.Text;
                currentUser.Email = setEmailTxt.Text;
                currentUser.Password = setPasswordTxt.Text;
                currentUser.FirstName = setFirstNameTxt.Text;
                currentUser.LastName = setLastNameTxt.Text;

                // Save the updated user information to the database
                User.UpdateUser(currentUser);

                // Show a success message
                MessageBox.Show("User Info Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// Handles the Delete User button click event in the Settings tab.
        /// Prompts the user for confirmation and deletes the current user's account if confirmed.
        /// Displays appropriate success or error messages based on the operation result.
        /// </summary>
        /// <param name="sender">The Delete button control</param>
        /// <param name="e">The event data associated with the button click</param>
        private void setDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the current user's ID and retrieve their information
                long id = AuthService.GetCurrentUserId();
                User currentUser = User.GetUserById(id);

                // Display a confirmation dialog to the user
                DialogResult result = MessageBox.Show(
                    "Warning! Are you sure you want to delete this user? This action cannot be undone.",
                    "Delete Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Attempt to delete the user
                    if (User.DeleteUser(currentUser.Id))
                    {
                        // Success: Notify the user and return to the home tab
                        MessageBox.Show("User has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AuthService.LogoutCurrentUser();
                        appTabs.SelectTab(0);
                    }
                    else
                    {
                        // Failure: Display an error message
                        MessageBox.Show("An error occurred while deleting the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Operation canceled by the user
                    MessageBox.Show("Delete operation canceled.", "Cancellation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception er)
            {
                // Log any unexpected exceptions
                Console.WriteLine(er.ToString());
            }
        }

        #endregion Settings Tab


        /// <summary>
        /// Handles the Pay button click event in the Payment tab.
        /// Validates user inputs, processes the payment, generates a ticket, and assigns a random seat.
        /// Displays success or error messages based on the result of the operation.
        /// </summary>
        /// <param name="sender">The Pay button control</param>
        /// <param name="e">The event data associated with the button click</param>
        private void ppPayBtn_Click(object sender, EventArgs e)
        {
            paymentErrorLbl.Visible = false;
            // Validate input
            if (ppPasportNumTxt.Text == "" || ppCardNumTxt.Text == "" || ppNameCardTxt.Text == "" || ppCvvTxt.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please select a Payment Method.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                paymentErrorLbl.Visible = true;
                paymentErrorLbl.Text = "Please select a Payment Method.";
                return;
            }

            // Generate a random seat assignment
            string assignedSeat = GenerateRandomSeat();

            // Create a new Payment object
            Payment payment = new Payment
            {
                Id = 11, // Assuming this is the next available ID
                Amount = Convert.ToDecimal(ppTotaLbl.Text),
                Date = DateTime.Now,
                PaymentStatusID = 1, // Paid
                PaymentMethodID = paymentMethod
            };

            try
            {
                // Create a new Ticket object
                Ticket ticket = new Ticket
                {
                    FlightID = selectedFlight.Id,
                    UserID = AuthService.GetCurrentUserId(),
                    Seat = assignedSeat,
                    TicketClassID = ppTicketClassDrop.SelectedIndex + 1,
                    TicketStatusID = 1, // Confirmed
                    PaymentID = Payment.AddPayment(payment), // Add payment and get its ID
                    AgencyID = User.GetUserById(AuthService.GetCurrentUserId()).AgencyID
                };

                // Insert the ticket into the database
                Ticket.AddTicket(ticket);
            }
            catch
            {
                // Handle ticket creation errors
                paymentErrorLbl.Visible = true;
                MessageBox.Show("Error while creating the ticket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                paymentErrorLbl.Text = "Error while creating the ticket";
                return;
            }

            // Display success message to the user
            MessageBox.Show($"Ticket purchased successfully. Your seat: {assignedSeat}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Return to the booking tab
            defultIcons();
            bookingTab.Image = global::HappyJourneyAirline.Properties.Resources.Bookings_Active;
            loadBookingTable();
            tabController.SelectTab(1);
        }


        /// <summary>
        /// Generates a random seat assignment consisting of a row number and a column letter.
        /// Row numbers range from 1 to 30, and column letters range from A to F.
        /// </summary>
        /// <returns>A string representing the randomly generated seat (e.g., "12B").</returns>
        private string GenerateRandomSeat()
        {
            Random random = new Random();
            int row = random.Next(1, 31); // Random row number (1-30)
            char column = (char)random.Next('A', 'F' + 1); // Random column letter (A-F)
            return $"{row}{column}";
        }

        /// <summary>
        /// Handles the Cancel button click event in the Payment tab.
        /// Navigates the user back to the main Flights tab without saving any changes.
        /// </summary>
        /// <param name="sender">The Cancel button control</param>
        /// <param name="e">The event data associated with the button click</param>
        private void ppCancelBtn_Click(object sender, EventArgs e)
        {
            tabController.SelectTab(0); // return to the flight tab 
        }


        /// <summary>
        /// Handles the Ticket Class dropdown selection change event.
        /// Updates the total price label to reflect the selected ticket class's additional price.
        /// </summary>
        /// <param name="sender">The Ticket Class dropdown control</param>
        /// <param name="e">The event data associated with the selection change</param>
        private void ppTicketClassDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Retrieve the selected ticket class and update the total price label
            ppTotaLbl.Text = $"{selectedFlight.BasePrice+TicketClass.GetTicketClassById(ppTicketClassDrop.SelectedIndex+1).ExtraPrice}";
        }

        private void logOutIcon_Click(object sender, EventArgs e)
        {
            AuthService.LogoutCurrentUser();
            appTabs.SelectTab(0);
        }

        private void bookingTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                    // Retrieve the ticket ID from the selected row
                    int Ticketid = Convert.ToInt32(bookingTable.Rows[e.RowIndex].Cells[1].Value);

                    // Retrieve ticket and flight details
                    Ticket ticket = Ticket.GetTicketById(Ticketid);
                    Flight flight = Flight.GetFlightById(ticket.FlightID);

                    // Extract departure and arrival timestamps
                    string dep = flight.DepartureTimestamp.ToString();
                    string arr = flight.ArrivalTimestamp.ToString();

                    // Retrieve source and destination airport details
                    Airport source = Airport.GetAirportById(flight.SourceAirportID);
                    Airport destination = Airport.GetAirportById(flight.DestinationAirportID);

                    // Retrieve source and destination city and country details
                    City sourceCity = City.GetCityById(source.CityId);
                    City destinationCity = City.GetCityById(destination.CityId);
                    Country sourceCountry = Country.GetCountryById(sourceCity.CountryId);
                    Country destinationCountry = Country.GetCountryById(destinationCity.CountryId);

                    // Populate the flight details UI with the retrieved data
                    bdIDTxt.Text = ticket.Id.ToString();
                    bdFlightNumTxt.Text = ticket.FlightID.ToString();
                    bdDepTimeTxt.Text = dep;
                    bdArrTimeTxt.Text = arr;
                    bdFromTxt.Text = sourceCity.Name.ToString() + " (" + sourceCountry.Name.ToString() + ")";
                    bdToTxt.Text = destinationCity.Name.ToString() + " (" + destinationCountry.Name.ToString() + ")";
                    bdDepTxt.Text = source.Name.ToString();
                    bdArrTxt.Text = destination.Name.ToString();
                bdTicketClassTxt.Text = TicketClass.GetTicketClassById(ticket.TicketClassID).Name;
                bdSeatNumberTxt.Text = ticket.Seat;
                bdTotalPriceTxt.Text = $"{Payment.GetPaymentById(ticket.PaymentID).Amount:C}";
                bdFlightStatusTxt.Text = FlightStatus.GetFlightStatusById((int)flight.FlightStatusID).Name;
                if (bdFlightStatusTxt.Text != "Scheduled" && bdFlightStatusTxt.Text != "Delayed") {
                    bdCancelBtn.Visible = false;
                } else
                {
                    bdCancelBtn.Visible = true;

                }

                tabController.SelectTab(5);
                }

            
        }
    }

}
