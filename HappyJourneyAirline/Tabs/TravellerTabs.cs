using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using HappyJourneyAirline.Models;
namespace HappyJourneyAirline.Tabs
{
    public partial class TravellerTabs : UserControl
    {
        private TabPage travellerFlightsTab;
        private Label label22;
        private Label label11;
        private TabControl tabController;
        private TabPage travellerBookingsTab;
        private Label label1;
        private Label label13;
        private TabPage travellerSettingsTab;
        private Label label14;
        private Panel panel1;
        private PictureBox logOutIcon;
        private PictureBox settingTab;
        private PictureBox flightsTab;
        private PictureBox logoIcon;
        private DateTimePicker date;
        private PictureBox cancelIcon;
        private Label label3;
        private Label label4;
        private PictureBox searchIcon;
        private Label label2;
        private ComboBox arrivalDrop;
        private Label label5;
        private ComboBox depDrop;
        private DateTimePicker time;
        private System.ComponentModel.IContainer components;
        private PictureBox notificationTab;
        private TabPage travellerNotificationTab;
        private Label label6;
        private Label label7;
        private CheckBox dateCheck;
        private CheckBox timeCheck;
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
        private Button setSaveChanesBtn;
        private Button setCancelBtn;
        private Button setDeleteBtn;
        private Label label18;
        private TabPage flightDetails;
        private TextBox fdArrTxt;
        private Label label27;
        private Label label28;
        private TextBox fdDepTxt;
        private TextBox fdToTxt;
        private Label label25;
        private Label label26;
        private TextBox fdFromTxt;
        private TextBox fdArrTimeTxt;
        private Label label23;
        private Label label24;
        private TextBox fdDepTimeTxt;
        private TextBox fdDateTxt;
        private Label label20;
        private Label label21;
        private TextBox fdFlightNumTxt;
        private Label label19;
        private Button fdCancelBtn;
        private Button fdBookBtn;
        private TabPage bookingDetailsTab;
        private TextBox bdIDTxt;
        private Label label38;
        private Button bdBackBtn;
        private Button bdCancelBtn;
        private TextBox bdArrTxt;
        private Label label29;
        private Label label30;
        private TextBox bdDepTxt;
        private TextBox bdToTxt;
        private Label label31;
        private Label label32;
        private TextBox bdFromTxt;
        private TextBox bdArrTimeTxt;
        private Label label33;
        private Label label34;
        private TextBox bdDepTimeTxt;
        private TextBox bdDateTxt;
        private Label label35;
        private Label label36;
        private TextBox bdFlightNumTxt;
        private Label label37;
        private TabPage payment;
        private Label label40;
        private Label label42;
        private TextBox ppPasportNumTxt;
        private Label label41;
        private TextBox ppNumofTicketsTxt;
        private Label label39;
        private TextBox ppFlightNumTxt;
        private RadioButton ppAeRadio;
        private RadioButton ppVisaRadio;
        private RadioButton ppCcRadio;
        private Label label43;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button ppCancelBtn;
        private Button ppPayBtn;
        private Label label46;
        private TextBox ppCvvTxt;
        private Label label47;
        private TextBox ppNameCardTxt;
        private Label label45;
        private Label label44;
        private TextBox ppCardNumTxt;
        private DateTimePicker ppDatePick;
        private Label label48;
        private Label ppTotaLbl;
        private Label label49;
        private Label setErrorLbl;
        private Label paymentErrorLbl;
        private DataGridView bookingTable;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn from;
        private DataGridViewTextBoxColumn to;
        private DataGridViewTextBoxColumn dateTime;
        private DataGridViewButtonColumn bookDetails;
        private PictureBox bookingTab;

        public TravellerTabs()
        {
            InitializeComponent();
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights_Active;
            time.Format = DateTimePickerFormat.Custom;
            time.CustomFormat = "HH:mm";
            time.ShowUpDown = true;

            // when time change console log the time


        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravellerTabs));
            this.travellerFlightsTab = new System.Windows.Forms.TabPage();
            this.dateCheck = new System.Windows.Forms.CheckBox();
            this.timeCheck = new System.Windows.Forms.CheckBox();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cancelIcon = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.arrivalDrop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.depDrop = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabController = new System.Windows.Forms.TabControl();
            this.travellerBookingsTab = new System.Windows.Forms.TabPage();
            this.bookingTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            this.travellerNotificationTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flightDetails = new System.Windows.Forms.TabPage();
            this.fdCancelBtn = new System.Windows.Forms.Button();
            this.fdBookBtn = new System.Windows.Forms.Button();
            this.fdArrTxt = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.fdDepTxt = new System.Windows.Forms.TextBox();
            this.fdToTxt = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.fdFromTxt = new System.Windows.Forms.TextBox();
            this.fdArrTimeTxt = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.fdDepTimeTxt = new System.Windows.Forms.TextBox();
            this.fdDateTxt = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.fdFlightNumTxt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.bookingDetailsTab = new System.Windows.Forms.TabPage();
            this.bdIDTxt = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.bdBackBtn = new System.Windows.Forms.Button();
            this.bdCancelBtn = new System.Windows.Forms.Button();
            this.bdArrTxt = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.bdDepTxt = new System.Windows.Forms.TextBox();
            this.bdToTxt = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.bdFromTxt = new System.Windows.Forms.TextBox();
            this.bdArrTimeTxt = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.bdDepTimeTxt = new System.Windows.Forms.TextBox();
            this.bdDateTxt = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.bdFlightNumTxt = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.TabPage();
            this.paymentErrorLbl = new System.Windows.Forms.Label();
            this.ppTotaLbl = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.ppDatePick = new System.Windows.Forms.DateTimePicker();
            this.ppCancelBtn = new System.Windows.Forms.Button();
            this.ppPayBtn = new System.Windows.Forms.Button();
            this.label46 = new System.Windows.Forms.Label();
            this.ppCvvTxt = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.ppNameCardTxt = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.ppCardNumTxt = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ppAeRadio = new System.Windows.Forms.RadioButton();
            this.ppVisaRadio = new System.Windows.Forms.RadioButton();
            this.ppCcRadio = new System.Windows.Forms.RadioButton();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.ppPasportNumTxt = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.ppNumofTicketsTxt = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.ppFlightNumTxt = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notificationTab = new System.Windows.Forms.PictureBox();
            this.logOutIcon = new System.Windows.Forms.PictureBox();
            this.settingTab = new System.Windows.Forms.PictureBox();
            this.flightsTab = new System.Windows.Forms.PictureBox();
            this.logoIcon = new System.Windows.Forms.PictureBox();
            this.bookingTab = new System.Windows.Forms.PictureBox();
            this.travellerFlightsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cancelIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            this.tabController.SuspendLayout();
            this.travellerBookingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTable)).BeginInit();
            this.travellerSettingsTab.SuspendLayout();
            this.travellerNotificationTab.SuspendLayout();
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
            this.SuspendLayout();
            // 
            // travellerFlightsTab
            // 
            this.travellerFlightsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerFlightsTab.Controls.Add(this.dateCheck);
            this.travellerFlightsTab.Controls.Add(this.timeCheck);
            this.travellerFlightsTab.Controls.Add(this.time);
            this.travellerFlightsTab.Controls.Add(this.date);
            this.travellerFlightsTab.Controls.Add(this.cancelIcon);
            this.travellerFlightsTab.Controls.Add(this.label3);
            this.travellerFlightsTab.Controls.Add(this.label4);
            this.travellerFlightsTab.Controls.Add(this.searchIcon);
            this.travellerFlightsTab.Controls.Add(this.label2);
            this.travellerFlightsTab.Controls.Add(this.arrivalDrop);
            this.travellerFlightsTab.Controls.Add(this.label5);
            this.travellerFlightsTab.Controls.Add(this.depDrop);
            this.travellerFlightsTab.Controls.Add(this.label22);
            this.travellerFlightsTab.Controls.Add(this.label11);
            this.travellerFlightsTab.Location = new System.Drawing.Point(23, 4);
            this.travellerFlightsTab.Name = "travellerFlightsTab";
            this.travellerFlightsTab.Padding = new System.Windows.Forms.Padding(3);
            this.travellerFlightsTab.Size = new System.Drawing.Size(757, 720);
            this.travellerFlightsTab.TabIndex = 0;
            this.travellerFlightsTab.Text = "Flights";
            // 
            // dateCheck
            // 
            this.dateCheck.AutoSize = true;
            this.dateCheck.Location = new System.Drawing.Point(123, 267);
            this.dateCheck.Name = "dateCheck";
            this.dateCheck.Size = new System.Drawing.Size(15, 14);
            this.dateCheck.TabIndex = 46;
            this.dateCheck.UseVisualStyleBackColor = true;
            this.dateCheck.CheckedChanged += new System.EventHandler(this.dateCheck_CheckedChanged);
            // 
            // timeCheck
            // 
            this.timeCheck.AutoSize = true;
            this.timeCheck.Location = new System.Drawing.Point(337, 267);
            this.timeCheck.Name = "timeCheck";
            this.timeCheck.Size = new System.Drawing.Size(15, 14);
            this.timeCheck.TabIndex = 45;
            this.timeCheck.UseVisualStyleBackColor = true;
            this.timeCheck.CheckedChanged += new System.EventHandler(this.timeCheck_CheckedChanged);
            // 
            // time
            // 
            this.time.Enabled = false;
            this.time.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.time.Location = new System.Drawing.Point(360, 258);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(150, 33);
            this.time.TabIndex = 44;
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.date.Location = new System.Drawing.Point(144, 258);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(152, 33);
            this.date.TabIndex = 42;
            // 
            // cancelIcon
            // 
            this.cancelIcon.Image = ((System.Drawing.Image)(resources.GetObject("cancelIcon.Image")));
            this.cancelIcon.Location = new System.Drawing.Point(537, 223);
            this.cancelIcon.Name = "cancelIcon";
            this.cancelIcon.Size = new System.Drawing.Size(72, 52);
            this.cancelIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cancelIcon.TabIndex = 41;
            this.cancelIcon.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Date";
            // 
            // searchIcon
            // 
            this.searchIcon.Image = ((System.Drawing.Image)(resources.GetObject("searchIcon.Image")));
            this.searchIcon.Location = new System.Drawing.Point(537, 149);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(72, 52);
            this.searchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchIcon.TabIndex = 38;
            this.searchIcon.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Arrival Airport";
            // 
            // arrivalDrop
            // 
            this.arrivalDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.arrivalDrop.FormattingEnabled = true;
            this.arrivalDrop.Location = new System.Drawing.Point(337, 180);
            this.arrivalDrop.Name = "arrivalDrop";
            this.arrivalDrop.Size = new System.Drawing.Size(173, 34);
            this.arrivalDrop.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Departure Airport";
            // 
            // depDrop
            // 
            this.depDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.depDrop.FormattingEnabled = true;
            this.depDrop.Location = new System.Drawing.Point(123, 180);
            this.depDrop.Name = "depDrop";
            this.depDrop.Size = new System.Drawing.Size(173, 34);
            this.depDrop.TabIndex = 34;
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
            this.travellerBookingsTab.Controls.Add(this.label1);
            this.travellerBookingsTab.Controls.Add(this.label13);
            this.travellerBookingsTab.Location = new System.Drawing.Point(23, 4);
            this.travellerBookingsTab.Name = "travellerBookingsTab";
            this.travellerBookingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.travellerBookingsTab.Size = new System.Drawing.Size(757, 720);
            this.travellerBookingsTab.TabIndex = 1;
            this.travellerBookingsTab.Text = "Bookings";
            // 
            // bookingTable
            // 
            this.bookingTable.AllowUserToAddRows = false;
            this.bookingTable.AllowUserToDeleteRows = false;
            this.bookingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.from,
            this.to,
            this.dateTime,
            this.bookDetails});
            this.bookingTable.Location = new System.Drawing.Point(52, 166);
            this.bookingTable.Name = "bookingTable";
            this.bookingTable.ReadOnly = true;
            this.bookingTable.Size = new System.Drawing.Size(650, 441);
            this.bookingTable.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // from
            // 
            this.from.HeaderText = "From";
            this.from.Name = "from";
            this.from.ReadOnly = true;
            // 
            // to
            // 
            this.to.HeaderText = "To";
            this.to.Name = "to";
            this.to.ReadOnly = true;
            // 
            // dateTime
            // 
            this.dateTime.HeaderText = "Date and Time";
            this.dateTime.Name = "dateTime";
            this.dateTime.ReadOnly = true;
            // 
            // bookDetails
            // 
            this.bookDetails.HeaderText = "Booking Details";
            this.bookDetails.Name = "bookDetails";
            this.bookDetails.ReadOnly = true;
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
            this.travellerSettingsTab.Location = new System.Drawing.Point(23, 4);
            this.travellerSettingsTab.Name = "travellerSettingsTab";
            this.travellerSettingsTab.Size = new System.Drawing.Size(757, 720);
            this.travellerSettingsTab.TabIndex = 2;
            this.travellerSettingsTab.Text = "Settings";
            // 
            // setErrorLbl
            // 
            this.setErrorLbl.AutoSize = true;
            this.setErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.setErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.setErrorLbl.Location = new System.Drawing.Point(17, 436);
            this.setErrorLbl.Name = "setErrorLbl";
            this.setErrorLbl.Size = new System.Drawing.Size(160, 26);
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
            this.setDeleteBtn.Size = new System.Drawing.Size(139, 43);
            this.setDeleteBtn.TabIndex = 21;
            this.setDeleteBtn.Text = "Delete Account";
            this.setDeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.setDeleteBtn.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(18, 574);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(652, 19);
            this.label18.TabIndex = 20;
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
            this.setCancelBtn.Location = new System.Drawing.Point(167, 378);
            this.setCancelBtn.Name = "setCancelBtn";
            this.setCancelBtn.Size = new System.Drawing.Size(139, 43);
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
            this.setSaveChanesBtn.Location = new System.Drawing.Point(22, 378);
            this.setSaveChanesBtn.Name = "setSaveChanesBtn";
            this.setSaveChanesBtn.Size = new System.Drawing.Size(139, 43);
            this.setSaveChanesBtn.TabIndex = 18;
            this.setSaveChanesBtn.Text = "Save Changes";
            this.setSaveChanesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.setSaveChanesBtn.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(325, 272);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(149, 32);
            this.label17.TabIndex = 17;
            this.label17.Text = "Phone Number:";
            this.label17.UseCompatibleTextRendering = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(22, 272);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 32);
            this.label16.TabIndex = 16;
            this.label16.Text = "Email:";
            this.label16.UseCompatibleTextRendering = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(325, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 32);
            this.label15.TabIndex = 15;
            this.label15.Text = "Last Name:";
            this.label15.UseCompatibleTextRendering = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 32);
            this.label12.TabIndex = 14;
            this.label12.Text = "First Name:";
            this.label12.UseCompatibleTextRendering = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(325, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 32);
            this.label10.TabIndex = 13;
            this.label10.Text = "Password:";
            this.label10.UseCompatibleTextRendering = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 32);
            this.label9.TabIndex = 12;
            this.label9.Text = "Username:";
            this.label9.UseCompatibleTextRendering = true;
            // 
            // setPhoneTxt
            // 
            this.setPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setPhoneTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPhoneTxt.Location = new System.Drawing.Point(325, 305);
            this.setPhoneTxt.Name = "setPhoneTxt";
            this.setPhoneTxt.Size = new System.Drawing.Size(246, 33);
            this.setPhoneTxt.TabIndex = 11;
            // 
            // setEmailTxt
            // 
            this.setEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setEmailTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setEmailTxt.Location = new System.Drawing.Point(22, 305);
            this.setEmailTxt.Name = "setEmailTxt";
            this.setEmailTxt.Size = new System.Drawing.Size(246, 33);
            this.setEmailTxt.TabIndex = 10;
            // 
            // setLastNameTxt
            // 
            this.setLastNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setLastNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setLastNameTxt.Location = new System.Drawing.Point(325, 236);
            this.setLastNameTxt.Name = "setLastNameTxt";
            this.setLastNameTxt.Size = new System.Drawing.Size(246, 33);
            this.setLastNameTxt.TabIndex = 9;
            // 
            // setFirstNameTxt
            // 
            this.setFirstNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setFirstNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setFirstNameTxt.Location = new System.Drawing.Point(22, 236);
            this.setFirstNameTxt.Name = "setFirstNameTxt";
            this.setFirstNameTxt.Size = new System.Drawing.Size(246, 33);
            this.setFirstNameTxt.TabIndex = 8;
            // 
            // setPasswordTxt
            // 
            this.setPasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setPasswordTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPasswordTxt.Location = new System.Drawing.Point(325, 167);
            this.setPasswordTxt.Name = "setPasswordTxt";
            this.setPasswordTxt.Size = new System.Drawing.Size(246, 33);
            this.setPasswordTxt.TabIndex = 7;
            // 
            // setUsernameTxt
            // 
            this.setUsernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setUsernameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setUsernameTxt.Location = new System.Drawing.Point(22, 167);
            this.setUsernameTxt.Name = "setUsernameTxt";
            this.setUsernameTxt.Size = new System.Drawing.Size(246, 33);
            this.setUsernameTxt.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(18, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Here you can customize your account";
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
            // travellerNotificationTab
            // 
            this.travellerNotificationTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerNotificationTab.Controls.Add(this.label6);
            this.travellerNotificationTab.Controls.Add(this.label7);
            this.travellerNotificationTab.Location = new System.Drawing.Point(23, 4);
            this.travellerNotificationTab.Name = "travellerNotificationTab";
            this.travellerNotificationTab.Size = new System.Drawing.Size(757, 720);
            this.travellerNotificationTab.TabIndex = 3;
            this.travellerNotificationTab.Text = "Notification";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(14, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Here you will find all your notifications";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 59);
            this.label7.TabIndex = 4;
            this.label7.Text = "Notification";
            // 
            // flightDetails
            // 
            this.flightDetails.BackColor = System.Drawing.Color.Gainsboro;
            this.flightDetails.Controls.Add(this.fdCancelBtn);
            this.flightDetails.Controls.Add(this.fdBookBtn);
            this.flightDetails.Controls.Add(this.fdArrTxt);
            this.flightDetails.Controls.Add(this.label27);
            this.flightDetails.Controls.Add(this.label28);
            this.flightDetails.Controls.Add(this.fdDepTxt);
            this.flightDetails.Controls.Add(this.fdToTxt);
            this.flightDetails.Controls.Add(this.label25);
            this.flightDetails.Controls.Add(this.label26);
            this.flightDetails.Controls.Add(this.fdFromTxt);
            this.flightDetails.Controls.Add(this.fdArrTimeTxt);
            this.flightDetails.Controls.Add(this.label23);
            this.flightDetails.Controls.Add(this.label24);
            this.flightDetails.Controls.Add(this.fdDepTimeTxt);
            this.flightDetails.Controls.Add(this.fdDateTxt);
            this.flightDetails.Controls.Add(this.label20);
            this.flightDetails.Controls.Add(this.label21);
            this.flightDetails.Controls.Add(this.fdFlightNumTxt);
            this.flightDetails.Controls.Add(this.label19);
            this.flightDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flightDetails.Location = new System.Drawing.Point(23, 4);
            this.flightDetails.Name = "flightDetails";
            this.flightDetails.Padding = new System.Windows.Forms.Padding(3);
            this.flightDetails.Size = new System.Drawing.Size(757, 720);
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
            this.fdCancelBtn.Text = "Cancel";
            this.fdCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.fdCancelBtn.UseVisualStyleBackColor = false;
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
            this.fdArrTxt.Size = new System.Drawing.Size(246, 26);
            this.fdArrTxt.TabIndex = 30;
            this.fdArrTxt.Text = "Bahrain International Airport";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(378, 369);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(192, 32);
            this.label27.TabIndex = 29;
            this.label27.Text = "Arrival Airport Time:";
            this.label27.UseCompatibleTextRendering = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(17, 369);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(233, 32);
            this.label28.TabIndex = 28;
            this.label28.Text = "Departure Airport Name:";
            this.label28.UseCompatibleTextRendering = true;
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
            this.fdDepTxt.Size = new System.Drawing.Size(246, 26);
            this.fdDepTxt.TabIndex = 27;
            this.fdDepTxt.Text = "Cairo International Airport";
            this.fdDepTxt.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
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
            this.fdToTxt.Size = new System.Drawing.Size(246, 26);
            this.fdToTxt.TabIndex = 26;
            this.fdToTxt.Text = "Muharraq (Bahrain)";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(378, 291);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(36, 32);
            this.label25.TabIndex = 25;
            this.label25.Text = "To:";
            this.label25.UseCompatibleTextRendering = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(17, 289);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(60, 32);
            this.label26.TabIndex = 24;
            this.label26.Text = "From:";
            this.label26.UseCompatibleTextRendering = true;
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
            this.fdFromTxt.Size = new System.Drawing.Size(246, 26);
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
            this.fdArrTimeTxt.Size = new System.Drawing.Size(246, 26);
            this.fdArrTimeTxt.TabIndex = 22;
            this.fdArrTimeTxt.Text = "11:00 AM";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(378, 203);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(123, 32);
            this.label23.TabIndex = 21;
            this.label23.Text = "Arrival Time:";
            this.label23.UseCompatibleTextRendering = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(17, 203);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(155, 32);
            this.label24.TabIndex = 20;
            this.label24.Text = "Departure Time:";
            this.label24.UseCompatibleTextRendering = true;
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
            this.fdDepTimeTxt.Size = new System.Drawing.Size(246, 26);
            this.fdDepTimeTxt.TabIndex = 19;
            this.fdDepTimeTxt.Text = "8:00 AM";
            // 
            // fdDateTxt
            // 
            this.fdDateTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.fdDateTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fdDateTxt.Enabled = false;
            this.fdDateTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdDateTxt.Location = new System.Drawing.Point(378, 163);
            this.fdDateTxt.Name = "fdDateTxt";
            this.fdDateTxt.ReadOnly = true;
            this.fdDateTxt.Size = new System.Drawing.Size(246, 26);
            this.fdDateTxt.TabIndex = 18;
            this.fdDateTxt.Text = "2024/12/30";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(378, 128);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 32);
            this.label20.TabIndex = 17;
            this.label20.Text = "Date:";
            this.label20.UseCompatibleTextRendering = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(17, 126);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(142, 32);
            this.label21.TabIndex = 16;
            this.label21.Text = "Flight Number:";
            this.label21.UseCompatibleTextRendering = true;
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
            this.fdFlightNumTxt.Size = new System.Drawing.Size(246, 26);
            this.fdFlightNumTxt.TabIndex = 14;
            this.fdFlightNumTxt.Text = "123";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(7, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(286, 59);
            this.label19.TabIndex = 5;
            this.label19.Text = "Flight Details";
            // 
            // bookingDetailsTab
            // 
            this.bookingDetailsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.bookingDetailsTab.Controls.Add(this.bdIDTxt);
            this.bookingDetailsTab.Controls.Add(this.label38);
            this.bookingDetailsTab.Controls.Add(this.bdBackBtn);
            this.bookingDetailsTab.Controls.Add(this.bdCancelBtn);
            this.bookingDetailsTab.Controls.Add(this.bdArrTxt);
            this.bookingDetailsTab.Controls.Add(this.label29);
            this.bookingDetailsTab.Controls.Add(this.label30);
            this.bookingDetailsTab.Controls.Add(this.bdDepTxt);
            this.bookingDetailsTab.Controls.Add(this.bdToTxt);
            this.bookingDetailsTab.Controls.Add(this.label31);
            this.bookingDetailsTab.Controls.Add(this.label32);
            this.bookingDetailsTab.Controls.Add(this.bdFromTxt);
            this.bookingDetailsTab.Controls.Add(this.bdArrTimeTxt);
            this.bookingDetailsTab.Controls.Add(this.label33);
            this.bookingDetailsTab.Controls.Add(this.label34);
            this.bookingDetailsTab.Controls.Add(this.bdDepTimeTxt);
            this.bookingDetailsTab.Controls.Add(this.bdDateTxt);
            this.bookingDetailsTab.Controls.Add(this.label35);
            this.bookingDetailsTab.Controls.Add(this.label36);
            this.bookingDetailsTab.Controls.Add(this.bdFlightNumTxt);
            this.bookingDetailsTab.Controls.Add(this.label37);
            this.bookingDetailsTab.Location = new System.Drawing.Point(23, 4);
            this.bookingDetailsTab.Name = "bookingDetailsTab";
            this.bookingDetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.bookingDetailsTab.Size = new System.Drawing.Size(757, 720);
            this.bookingDetailsTab.TabIndex = 5;
            this.bookingDetailsTab.Text = "Booking Details";
            // 
            // bdIDTxt
            // 
            this.bdIDTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdIDTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdIDTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdIDTxt.Location = new System.Drawing.Point(139, 106);
            this.bdIDTxt.Name = "bdIDTxt";
            this.bdIDTxt.ReadOnly = true;
            this.bdIDTxt.Size = new System.Drawing.Size(246, 26);
            this.bdIDTxt.TabIndex = 53;
            this.bdIDTxt.Text = "123";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(32, 106);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(108, 32);
            this.label38.TabIndex = 52;
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
            this.bdBackBtn.Location = new System.Drawing.Point(212, 529);
            this.bdBackBtn.Name = "bdBackBtn";
            this.bdBackBtn.Size = new System.Drawing.Size(173, 43);
            this.bdBackBtn.TabIndex = 51;
            this.bdBackBtn.Text = "Back to bookings";
            this.bdBackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bdBackBtn.UseVisualStyleBackColor = false;
            // 
            // bdCancelBtn
            // 
            this.bdCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.bdCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bdCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bdCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdCancelBtn.ForeColor = System.Drawing.Color.White;
            this.bdCancelBtn.Location = new System.Drawing.Point(32, 529);
            this.bdCancelBtn.Name = "bdCancelBtn";
            this.bdCancelBtn.Size = new System.Drawing.Size(175, 43);
            this.bdCancelBtn.TabIndex = 50;
            this.bdCancelBtn.Text = "Cancel the booking";
            this.bdCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bdCancelBtn.UseVisualStyleBackColor = false;
            // 
            // bdArrTxt
            // 
            this.bdArrTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdArrTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdArrTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdArrTxt.Location = new System.Drawing.Point(393, 440);
            this.bdArrTxt.Name = "bdArrTxt";
            this.bdArrTxt.ReadOnly = true;
            this.bdArrTxt.Size = new System.Drawing.Size(246, 26);
            this.bdArrTxt.TabIndex = 49;
            this.bdArrTxt.Text = "Bahrain International Airport";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(393, 403);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(192, 32);
            this.label29.TabIndex = 48;
            this.label29.Text = "Arrival Airport Time:";
            this.label29.UseCompatibleTextRendering = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(32, 403);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(233, 32);
            this.label30.TabIndex = 47;
            this.label30.Text = "Departure Airport Name:";
            this.label30.UseCompatibleTextRendering = true;
            // 
            // bdDepTxt
            // 
            this.bdDepTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdDepTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdDepTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdDepTxt.Location = new System.Drawing.Point(32, 440);
            this.bdDepTxt.Name = "bdDepTxt";
            this.bdDepTxt.ReadOnly = true;
            this.bdDepTxt.Size = new System.Drawing.Size(246, 26);
            this.bdDepTxt.TabIndex = 46;
            this.bdDepTxt.Text = "Cairo International Airport";
            // 
            // bdToTxt
            // 
            this.bdToTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdToTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdToTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdToTxt.Location = new System.Drawing.Point(393, 360);
            this.bdToTxt.Name = "bdToTxt";
            this.bdToTxt.ReadOnly = true;
            this.bdToTxt.Size = new System.Drawing.Size(246, 26);
            this.bdToTxt.TabIndex = 45;
            this.bdToTxt.Text = "Muharraq (Bahrain)";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(393, 325);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(36, 32);
            this.label31.TabIndex = 44;
            this.label31.Text = "To:";
            this.label31.UseCompatibleTextRendering = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(32, 323);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(60, 32);
            this.label32.TabIndex = 43;
            this.label32.Text = "From:";
            this.label32.UseCompatibleTextRendering = true;
            // 
            // bdFromTxt
            // 
            this.bdFromTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdFromTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdFromTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdFromTxt.Location = new System.Drawing.Point(32, 360);
            this.bdFromTxt.Name = "bdFromTxt";
            this.bdFromTxt.ReadOnly = true;
            this.bdFromTxt.Size = new System.Drawing.Size(246, 26);
            this.bdFromTxt.TabIndex = 42;
            this.bdFromTxt.Text = "Cairo (Egypt)";
            // 
            // bdArrTimeTxt
            // 
            this.bdArrTimeTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdArrTimeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdArrTimeTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdArrTimeTxt.Location = new System.Drawing.Point(393, 272);
            this.bdArrTimeTxt.Name = "bdArrTimeTxt";
            this.bdArrTimeTxt.ReadOnly = true;
            this.bdArrTimeTxt.Size = new System.Drawing.Size(246, 26);
            this.bdArrTimeTxt.TabIndex = 41;
            this.bdArrTimeTxt.Text = "11:00 AM";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(393, 237);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(123, 32);
            this.label33.TabIndex = 40;
            this.label33.Text = "Arrival Time:";
            this.label33.UseCompatibleTextRendering = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(32, 237);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(155, 32);
            this.label34.TabIndex = 39;
            this.label34.Text = "Departure Time:";
            this.label34.UseCompatibleTextRendering = true;
            // 
            // bdDepTimeTxt
            // 
            this.bdDepTimeTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdDepTimeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdDepTimeTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdDepTimeTxt.Location = new System.Drawing.Point(32, 272);
            this.bdDepTimeTxt.Name = "bdDepTimeTxt";
            this.bdDepTimeTxt.ReadOnly = true;
            this.bdDepTimeTxt.Size = new System.Drawing.Size(246, 26);
            this.bdDepTimeTxt.TabIndex = 38;
            this.bdDepTimeTxt.Text = "8:00 AM";
            // 
            // bdDateTxt
            // 
            this.bdDateTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdDateTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdDateTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdDateTxt.Location = new System.Drawing.Point(393, 197);
            this.bdDateTxt.Name = "bdDateTxt";
            this.bdDateTxt.ReadOnly = true;
            this.bdDateTxt.Size = new System.Drawing.Size(246, 26);
            this.bdDateTxt.TabIndex = 37;
            this.bdDateTxt.Text = "2024/12/30";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(393, 162);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(56, 32);
            this.label35.TabIndex = 36;
            this.label35.Text = "Date:";
            this.label35.UseCompatibleTextRendering = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(32, 160);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(142, 32);
            this.label36.TabIndex = 35;
            this.label36.Text = "Flight Number:";
            this.label36.UseCompatibleTextRendering = true;
            // 
            // bdFlightNumTxt
            // 
            this.bdFlightNumTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdFlightNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdFlightNumTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdFlightNumTxt.Location = new System.Drawing.Point(32, 197);
            this.bdFlightNumTxt.Name = "bdFlightNumTxt";
            this.bdFlightNumTxt.ReadOnly = true;
            this.bdFlightNumTxt.Size = new System.Drawing.Size(246, 26);
            this.bdFlightNumTxt.TabIndex = 34;
            this.bdFlightNumTxt.Text = "123";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(16, 19);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(337, 59);
            this.label37.TabIndex = 33;
            this.label37.Text = "Booking Details";
            // 
            // payment
            // 
            this.payment.BackColor = System.Drawing.Color.Gainsboro;
            this.payment.Controls.Add(this.paymentErrorLbl);
            this.payment.Controls.Add(this.ppTotaLbl);
            this.payment.Controls.Add(this.label49);
            this.payment.Controls.Add(this.label48);
            this.payment.Controls.Add(this.ppDatePick);
            this.payment.Controls.Add(this.ppCancelBtn);
            this.payment.Controls.Add(this.ppPayBtn);
            this.payment.Controls.Add(this.label46);
            this.payment.Controls.Add(this.ppCvvTxt);
            this.payment.Controls.Add(this.label47);
            this.payment.Controls.Add(this.ppNameCardTxt);
            this.payment.Controls.Add(this.label45);
            this.payment.Controls.Add(this.label44);
            this.payment.Controls.Add(this.ppCardNumTxt);
            this.payment.Controls.Add(this.pictureBox3);
            this.payment.Controls.Add(this.pictureBox2);
            this.payment.Controls.Add(this.pictureBox1);
            this.payment.Controls.Add(this.ppAeRadio);
            this.payment.Controls.Add(this.ppVisaRadio);
            this.payment.Controls.Add(this.ppCcRadio);
            this.payment.Controls.Add(this.label43);
            this.payment.Controls.Add(this.label42);
            this.payment.Controls.Add(this.ppPasportNumTxt);
            this.payment.Controls.Add(this.label41);
            this.payment.Controls.Add(this.ppNumofTicketsTxt);
            this.payment.Controls.Add(this.label39);
            this.payment.Controls.Add(this.ppFlightNumTxt);
            this.payment.Controls.Add(this.label40);
            this.payment.Location = new System.Drawing.Point(23, 4);
            this.payment.Name = "payment";
            this.payment.Padding = new System.Windows.Forms.Padding(3);
            this.payment.Size = new System.Drawing.Size(757, 720);
            this.payment.TabIndex = 6;
            this.payment.Text = "Payment";
            // 
            // paymentErrorLbl
            // 
            this.paymentErrorLbl.AutoSize = true;
            this.paymentErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.paymentErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.paymentErrorLbl.Location = new System.Drawing.Point(346, 662);
            this.paymentErrorLbl.Name = "paymentErrorLbl";
            this.paymentErrorLbl.Size = new System.Drawing.Size(160, 26);
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
            this.ppTotaLbl.Size = new System.Drawing.Size(51, 32);
            this.ppTotaLbl.TabIndex = 81;
            this.ppTotaLbl.Text = "1500";
            this.ppTotaLbl.UseCompatibleTextRendering = true;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(192, 594);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(130, 32);
            this.label49.TabIndex = 80;
            this.label49.Text = "BD (VAT inc.) ";
            this.label49.UseCompatibleTextRendering = true;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.Transparent;
            this.label48.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(24, 594);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(124, 32);
            this.label48.TabIndex = 79;
            this.label48.Text = "Total will be:";
            this.label48.UseCompatibleTextRendering = true;
            this.label48.Click += new System.EventHandler(this.label48_Click);
            // 
            // ppDatePick
            // 
            this.ppDatePick.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.ppDatePick.Location = new System.Drawing.Point(351, 448);
            this.ppDatePick.Name = "ppDatePick";
            this.ppDatePick.Size = new System.Drawing.Size(246, 33);
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
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(351, 497);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(45, 32);
            this.label46.TabIndex = 75;
            this.label46.Text = "CVV";
            this.label46.UseCompatibleTextRendering = true;
            // 
            // ppCvvTxt
            // 
            this.ppCvvTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ppCvvTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppCvvTxt.Location = new System.Drawing.Point(351, 532);
            this.ppCvvTxt.Name = "ppCvvTxt";
            this.ppCvvTxt.Size = new System.Drawing.Size(246, 33);
            this.ppCvvTxt.TabIndex = 74;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(24, 497);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(135, 32);
            this.label47.TabIndex = 73;
            this.label47.Text = "Name on Card";
            this.label47.UseCompatibleTextRendering = true;
            // 
            // ppNameCardTxt
            // 
            this.ppNameCardTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ppNameCardTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppNameCardTxt.Location = new System.Drawing.Point(24, 532);
            this.ppNameCardTxt.Name = "ppNameCardTxt";
            this.ppNameCardTxt.Size = new System.Drawing.Size(246, 33);
            this.ppNameCardTxt.TabIndex = 72;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(351, 412);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(119, 32);
            this.label45.TabIndex = 71;
            this.label45.Text = "Expiary date";
            this.label45.UseCompatibleTextRendering = true;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(24, 412);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(127, 32);
            this.label44.TabIndex = 69;
            this.label44.Text = "Card Number";
            this.label44.UseCompatibleTextRendering = true;
            // 
            // ppCardNumTxt
            // 
            this.ppCardNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ppCardNumTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppCardNumTxt.Location = new System.Drawing.Point(24, 447);
            this.ppCardNumTxt.Name = "ppCardNumTxt";
            this.ppCardNumTxt.Size = new System.Drawing.Size(246, 33);
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
            this.ppAeRadio.Size = new System.Drawing.Size(14, 13);
            this.ppAeRadio.TabIndex = 64;
            this.ppAeRadio.TabStop = true;
            this.ppAeRadio.UseVisualStyleBackColor = true;
            // 
            // ppVisaRadio
            // 
            this.ppVisaRadio.AutoSize = true;
            this.ppVisaRadio.Location = new System.Drawing.Point(137, 345);
            this.ppVisaRadio.Name = "ppVisaRadio";
            this.ppVisaRadio.Size = new System.Drawing.Size(14, 13);
            this.ppVisaRadio.TabIndex = 63;
            this.ppVisaRadio.TabStop = true;
            this.ppVisaRadio.UseVisualStyleBackColor = true;
            // 
            // ppCcRadio
            // 
            this.ppCcRadio.AutoSize = true;
            this.ppCcRadio.Location = new System.Drawing.Point(24, 345);
            this.ppCcRadio.Name = "ppCcRadio";
            this.ppCcRadio.Size = new System.Drawing.Size(14, 13);
            this.ppCcRadio.TabIndex = 62;
            this.ppCcRadio.TabStop = true;
            this.ppCcRadio.UseVisualStyleBackColor = true;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(24, 294);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(171, 32);
            this.label43.TabIndex = 61;
            this.label43.Text = "Credit card details";
            this.label43.UseCompatibleTextRendering = true;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(351, 200);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(167, 32);
            this.label42.TabIndex = 60;
            this.label42.Text = "Passport number:";
            this.label42.UseCompatibleTextRendering = true;
            this.label42.Click += new System.EventHandler(this.label42_Click);
            // 
            // ppPasportNumTxt
            // 
            this.ppPasportNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ppPasportNumTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppPasportNumTxt.Location = new System.Drawing.Point(351, 235);
            this.ppPasportNumTxt.Name = "ppPasportNumTxt";
            this.ppPasportNumTxt.Size = new System.Drawing.Size(246, 33);
            this.ppPasportNumTxt.TabIndex = 59;
            this.ppPasportNumTxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(24, 200);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(175, 32);
            this.label41.TabIndex = 58;
            this.label41.Text = "Number of tickets:";
            this.label41.UseCompatibleTextRendering = true;
            // 
            // ppNumofTicketsTxt
            // 
            this.ppNumofTicketsTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ppNumofTicketsTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppNumofTicketsTxt.Location = new System.Drawing.Point(24, 235);
            this.ppNumofTicketsTxt.Name = "ppNumofTicketsTxt";
            this.ppNumofTicketsTxt.Size = new System.Drawing.Size(246, 33);
            this.ppNumofTicketsTxt.TabIndex = 57;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(24, 115);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(142, 32);
            this.label39.TabIndex = 56;
            this.label39.Text = "Flight Number:";
            this.label39.UseCompatibleTextRendering = true;
            // 
            // ppFlightNumTxt
            // 
            this.ppFlightNumTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.ppFlightNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ppFlightNumTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppFlightNumTxt.Location = new System.Drawing.Point(24, 152);
            this.ppFlightNumTxt.Name = "ppFlightNumTxt";
            this.ppFlightNumTxt.ReadOnly = true;
            this.ppFlightNumTxt.Size = new System.Drawing.Size(246, 26);
            this.ppFlightNumTxt.TabIndex = 55;
            this.ppFlightNumTxt.Text = "123";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(14, 23);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(308, 59);
            this.label40.TabIndex = 54;
            this.label40.Text = "Payment Page";
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
            // TravellerTabs
            // 
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.panel1);
            this.Name = "TravellerTabs";
            this.Size = new System.Drawing.Size(921, 728);
            this.travellerFlightsTab.ResumeLayout(false);
            this.travellerFlightsTab.PerformLayout();
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
            this.ResumeLayout(false);

        }

        private void flightsTab_Click(object sender, EventArgs e)
        {
            tabController.SelectTab(0);
            defultIcons();
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights_Active;
        }

        private void bookingTab_Click(object sender, EventArgs e)
        {
            tabController.SelectTab(1);
            defultIcons();
            bookingTab.Image = global::HappyJourneyAirline.Properties.Resources.Bookings_Active;

            // display Booking list
            Ticket handler = new Ticket();
            //List<Ticket> tickets = new List<Ticket>();
            Ticket ticket = handler.GetTicketById(2);

            Flight flightHandler = new Flight();
            Flight flight = flightHandler.GetFlightById(ticket.FlightID);

            bookingTable.Rows.Add(ticket.Id, flight.SourceAirportID, flight.DestinationAirportID, flight.DepartureTimestamp, "View Details");

            //bookingTable.Rows.Add("ticket.Id", "Bahrain", "ticket.To", "ticket.Date", "View Details");  

        }

        private void settingTab_Click(object sender, EventArgs e)
        {
            tabController.SelectTab(2);
            defultIcons();
            settingTab.Image = global::HappyJourneyAirline.Properties.Resources.Settings_Active;
        }

        private void notificationTab_Click(object sender, EventArgs e)
        {
            tabController.SelectTab(3);
            defultIcons();
            notificationTab.Image = global::HappyJourneyAirline.Properties.Resources.Notification_Active;
        }

        private void defultIcons() { 
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights;
            bookingTab.Image = global::HappyJourneyAirline.Properties.Resources.Bookings;
            settingTab.Image = global::HappyJourneyAirline.Properties.Resources.Settings_Icon;
            notificationTab.Image = global::HappyJourneyAirline.Properties.Resources.Notification;
        }

        private void dateCheck_CheckedChanged(object sender, EventArgs e)
        {
            date.Enabled = dateCheck.Checked;
        }

        private void timeCheck_CheckedChanged(object sender, EventArgs e)
        {
            time.Enabled = timeCheck.Checked;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void setCancelBtn_Click(object sender, EventArgs e)
        {
            tabController.SelectTab(0);
            defultIcons();
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights_Active;
        }
    }

}
