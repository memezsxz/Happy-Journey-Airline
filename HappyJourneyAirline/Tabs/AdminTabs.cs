using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HappyJourneyAirline.Models;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using HappyJourneyAirline.Lib;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.IO;


//public enum FlightStatus
//{
//    Scheduled = 1,
//    Boarding = 2,
//    InAir = 3,
//    Landed = 4,
//    Cancelled = 5
//}


namespace HappyJourneyAirline.Tabs
{
    public partial class AdminTabs : UserControl
    {

        enum Tabs
        {
            Flights,
            Bookings,
            Settings,
            Users,
            BookingDetails,
            CreateFlight,
            EditFligh,
            CreateUser,
            AddCountryCiyAirport,
            ManageUser,
            ViewCountriesCitiesAirports,
            ViewLocation,
            CreateNotification,
            ViewPlanes
        }



        TabControl appTabs;
        #region attrebutes
        private Panel panel1;
        private PictureBox bookingTab;
        private PictureBox logoIcon;
        private PictureBox flightsTab;
        private PictureBox settingTab;
        private PictureBox logOutIcon;
        private PictureBox usersIcon;
        #endregion attrebutes

        #region AddedAtributes
        private BindingList<Plane> planes = new BindingList<Plane>();
        private BindingList<Airport> airports = new BindingList<Airport>();
        private BindingList<City> cities = new BindingList<City>();
        private BindingList<FlightStatus> flightsStatuses = new BindingList<FlightStatus>();
        private BindingList<Country> countries = new BindingList<Country>();
        private BindingList<User> users = new BindingList<User>();
        private BindingList<Flight> flights = new BindingList<Flight>();
        private User selectedUser = null;
        private Flight selectedFlight = null;
        private City selectedCity = null;
        private Country selectedCountry = null;
        private Airport selectedAirport = null;
        private Plane selectedPlane = null;
        private TabPage btntabCreatenotifications;
        private ComboBox comboBoxType;
        private Label lblErrorType;
        private Label label88;
        private Label label86;
        private Label lblErrorFlight;
        private ComboBox comboBoxFlights;
        private Button button1;
        private Label lblErrorDescription;
        private Label lblErrorTitle;
        private Label label84;
        private TextBox txtDescription;
        private TextBox txtTitle;
        private Label label76;
        private Label label74;
        private TabPage viewLocation;
        private FlowLayoutPanel flowLayoutPanel5;
        private GroupBox countryGroupBox;
        private Label label73;
        private Label editContErrorLbl;
        private TextBox editContNameTxt;
        private GroupBox AirportGroupBox;
        private Label label78;
        private ComboBox editAirportConDrop;
        private TextBox editAirportNameTxt;
        private Label label80;
        private TextBox editAirportLongitudeTxt;
        private Label label81;
        private Label label82;
        private ComboBox editAirportCityDrop;
        private TextBox editAirportLatitudeTxt;
        private Label editAirportErrorLbl;
        private Label label85;
        private GroupBox cityGroupBox;
        private Label label75;
        private TextBox editCitytNameTxt;
        private Label editCityErrorLbl;
        private Label label77;
        private ComboBox editConDrop;
        private FlowLayoutPanel flowLayoutPanel6;
        private Button editLocationDelete;
        private Button editLocationSave;
        private Button editLocationBack;
        private Label label79;
        private Label label83;
        private TabPage veAirCouCity;
        private Button button2;
        private GroupBox groupBox4;
        private DataGridView countriesDataGridView;
        private GroupBox groupBox5;
        private DataGridView citiesDataGridView;
        private GroupBox groupBox6;
        private DataGridView airportsDataGridView;
        private Button addAirCityCouBtn;
        private Label label72;
        private Label Locations;
        private TabPage tabPage1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel mtFirstNamePanel;
        private Label label62;
        private TextBox mtFnameTxt;
        private Panel mtLastNamePanel;
        private Label label61;
        private TextBox mtLnameTxt;
        private Panel mtCompanyNamePanel;
        private Label mtCompanyNamelLbl;
        private TextBox mtCompanyNamelTxt;
        private Panel mtAgencyPanel;
        private TextBox mtAgencyIdTxt;
        private Label mtAgencyIdLbl;
        private TextBox mtUsernameTxt;
        private TextBox mtPhoneTxt;
        private TextBox mtEmailTxt;
        private TextBox mtUserIDTxt;
        private TextBox mtUserTypeTxt;
        private Label label69;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button mtDeleteBtn;
        private Button mtCancelBtn;
        private Label label65;
        private Label label64;
        private Label label59;
        private Label label60;
        private Label label63;
        private Label label18;
        private TabPage AddAirCityConTab;
        private GroupBox groupBox3;
        private Label label54;
        private Button addAddCountryBtn;
        private Label addContErrorLbl;
        private TextBox addContNameTxt;
        private GroupBox groupBox2;
        private Label label56;
        private Button addAddCityBtn;
        private TextBox addCitytNameTxt;
        private Label addCityErrorLbl;
        private Label label55;
        private ComboBox addConDrop;
        private GroupBox groupBox1;
        private Label label58;
        private ComboBox addAirportConDrop;
        private TextBox addAirportNameTxt;
        private Label label68;
        private Button addAddAirportBtn;
        private TextBox addAirportLongitudeTxt;
        private Label label57;
        private Label label67;
        private ComboBox addAirportCityDrop;
        private TextBox addAirportLatitudeTxt;
        private Label addAirportErrorLbl;
        private Label label53;
        private Button addBackBtn;
        private Label label52;
        private TabPage createUserTab;
        private Label cuPhoneNumberErrorLbl;
        private Label cuEmailErrorLbl;
        private Label cuFCoumpanyNameErrorLbl;
        private Label cuPasswordErrorLbl;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel cuFNamePanel;
        private Label label47;
        private TextBox cuFnameTxt;
        private Panel cuLNamePanel;
        private Label label46;
        private TextBox cuLnameTxt;
        private Label cuLNameErrorLbl;
        private Panel cuCompanyNamePanel;
        private TextBox cuCoumpanyNameTxt;
        private Label label70;
        private Label cuUserNameErrorLbl;
        private ComboBox cuUserTypeDrop;
        private Label label51;
        private Label label50;
        private Button cuCancelBtn;
        private Button cuCreateUserBtn;
        private Label label44;
        private Label label45;
        private Label label48;
        private Label label49;
        private TextBox cuPhoneTxt;
        private TextBox cuEmailTxt;
        private TextBox cuPasswordTxt;
        private TextBox cuUsernameTxt;
        private TabPage editFlightTab;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button efDeleteBtn;
        private Button efEditBtn;
        private Button efCancelBtn;
        private Label efPriceErrorLbl;
        private ComboBox efStatusDrop;
        private Label label71;
        private DateTimePicker efArrTimePick;
        private DateTimePicker efDepTimePick;
        private TextBox efArrTxt;
        private TextBox efDepTxt;
        private TextBox efPriceTxt;
        private TextBox efFlightNumTxt;
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
        private ComboBox cfStatusDrop;
        private Label label66;
        private Label cfTimeErrorLbl;
        private Label cfAirportsErrorLbl;
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
        private TextBox bdUsrIDLbl;
        private TextBox bdIDTxt;
        private TextBox bdArrTxt;
        private TextBox bdDepTxt;
        private TextBox bdToTxt;
        private TextBox bdFromTxt;
        private TextBox bdArrTimeTxt;
        private TextBox bdDepTimeTxt;
        private TextBox bdDateTxt;
        private TextBox bdFlightNumTxt;
        private Label bdUsrTypeLbl;
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
        private Button btnReportUsers;
        private PictureBox addNotifications;
        private DataGridView usersDataGridView;
        private Button userCreateUserBtn;
        private Label label2;
        private Label label3;
        private TabPage travellerSettingsTab;
        private Button btnBackup;
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
        private DataGridView bookingTable;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn from;
        private DataGridViewTextBoxColumn to;
        private DataGridViewTextBoxColumn dateTime;
        private DataGridViewButtonColumn bookDetails;
        private Label label1;
        private Label label13;
        private TabPage travellerFlightsTab;
        private Button viewPlanesBtn;
        private DataGridView flightsDataGridView;
        private Button viewAirCityCouBtn;
        private Button creatFlightBtn;
        private Label label22;
        private Label label11;
        private TabControl tabControler;
        private Label cpCapacityErrorLbl;
        private Label cpModelErrorLbl;
        private TextBox cpCapacityTxt;
        private TextBox cpModelTxt;
        private DataGridView planesDataGridView;
        private Button createPlaneBtn;
        private static readonly double rand = new Random().NextDouble();
        #endregion
        public AdminTabs(TabControl appTabs)
        {
            InitializeComponent();
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights_Active;
            usersDataGridView.DataSource = users;
            loadFlights();
            usersDataGridView.Columns.Insert(0, AddEditColumn());
            countriesDataGridView.Columns.Insert(0, AddEditColumn());
            citiesDataGridView.Columns.Insert(0, AddEditColumn());
            airportsDataGridView.Columns.Insert(0, AddEditColumn());
            planesDataGridView.Columns.Insert(0, AddDeleteColumn());
            this.appTabs = appTabs;
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabPage viewPlanes;
            System.Windows.Forms.Label label92;
            System.Windows.Forms.Label label93;
            System.Windows.Forms.Label label87;
            System.Windows.Forms.Label label89;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTabs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cpCapacityErrorLbl = new System.Windows.Forms.Label();
            this.cpModelErrorLbl = new System.Windows.Forms.Label();
            this.cpCapacityTxt = new System.Windows.Forms.TextBox();
            this.cpModelTxt = new System.Windows.Forms.TextBox();
            this.planesDataGridView = new System.Windows.Forms.DataGridView();
            this.createPlaneBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usersIcon = new System.Windows.Forms.PictureBox();
            this.logOutIcon = new System.Windows.Forms.PictureBox();
            this.settingTab = new System.Windows.Forms.PictureBox();
            this.flightsTab = new System.Windows.Forms.PictureBox();
            this.logoIcon = new System.Windows.Forms.PictureBox();
            this.bookingTab = new System.Windows.Forms.PictureBox();
            this.btntabCreatenotifications = new System.Windows.Forms.TabPage();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.lblErrorType = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.lblErrorFlight = new System.Windows.Forms.Label();
            this.comboBoxFlights = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblErrorDescription = new System.Windows.Forms.Label();
            this.lblErrorTitle = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.viewLocation = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.countryGroupBox = new System.Windows.Forms.GroupBox();
            this.label73 = new System.Windows.Forms.Label();
            this.editContErrorLbl = new System.Windows.Forms.Label();
            this.editContNameTxt = new System.Windows.Forms.TextBox();
            this.AirportGroupBox = new System.Windows.Forms.GroupBox();
            this.label78 = new System.Windows.Forms.Label();
            this.editAirportConDrop = new System.Windows.Forms.ComboBox();
            this.editAirportNameTxt = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.editAirportLongitudeTxt = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.editAirportCityDrop = new System.Windows.Forms.ComboBox();
            this.editAirportLatitudeTxt = new System.Windows.Forms.TextBox();
            this.editAirportErrorLbl = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.cityGroupBox = new System.Windows.Forms.GroupBox();
            this.label75 = new System.Windows.Forms.Label();
            this.editCitytNameTxt = new System.Windows.Forms.TextBox();
            this.editCityErrorLbl = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.editConDrop = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.editLocationDelete = new System.Windows.Forms.Button();
            this.editLocationSave = new System.Windows.Forms.Button();
            this.editLocationBack = new System.Windows.Forms.Button();
            this.label79 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.veAirCouCity = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.countriesDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.citiesDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.airportsDataGridView = new System.Windows.Forms.DataGridView();
            this.addAirCityCouBtn = new System.Windows.Forms.Button();
            this.label72 = new System.Windows.Forms.Label();
            this.Locations = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.mtFirstNamePanel = new System.Windows.Forms.Panel();
            this.label62 = new System.Windows.Forms.Label();
            this.mtFnameTxt = new System.Windows.Forms.TextBox();
            this.mtLastNamePanel = new System.Windows.Forms.Panel();
            this.label61 = new System.Windows.Forms.Label();
            this.mtLnameTxt = new System.Windows.Forms.TextBox();
            this.mtCompanyNamePanel = new System.Windows.Forms.Panel();
            this.mtCompanyNamelLbl = new System.Windows.Forms.Label();
            this.mtCompanyNamelTxt = new System.Windows.Forms.TextBox();
            this.mtAgencyPanel = new System.Windows.Forms.Panel();
            this.mtAgencyIdTxt = new System.Windows.Forms.TextBox();
            this.mtAgencyIdLbl = new System.Windows.Forms.Label();
            this.mtUsernameTxt = new System.Windows.Forms.TextBox();
            this.mtPhoneTxt = new System.Windows.Forms.TextBox();
            this.mtEmailTxt = new System.Windows.Forms.TextBox();
            this.mtUserIDTxt = new System.Windows.Forms.TextBox();
            this.mtUserTypeTxt = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mtDeleteBtn = new System.Windows.Forms.Button();
            this.mtCancelBtn = new System.Windows.Forms.Button();
            this.label65 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.AddAirCityConTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label54 = new System.Windows.Forms.Label();
            this.addAddCountryBtn = new System.Windows.Forms.Button();
            this.addContErrorLbl = new System.Windows.Forms.Label();
            this.addContNameTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label56 = new System.Windows.Forms.Label();
            this.addAddCityBtn = new System.Windows.Forms.Button();
            this.addCitytNameTxt = new System.Windows.Forms.TextBox();
            this.addCityErrorLbl = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.addConDrop = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label58 = new System.Windows.Forms.Label();
            this.addAirportConDrop = new System.Windows.Forms.ComboBox();
            this.addAirportNameTxt = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.addAddAirportBtn = new System.Windows.Forms.Button();
            this.addAirportLongitudeTxt = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.addAirportCityDrop = new System.Windows.Forms.ComboBox();
            this.addAirportLatitudeTxt = new System.Windows.Forms.TextBox();
            this.addAirportErrorLbl = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.addBackBtn = new System.Windows.Forms.Button();
            this.label52 = new System.Windows.Forms.Label();
            this.createUserTab = new System.Windows.Forms.TabPage();
            this.cuPhoneNumberErrorLbl = new System.Windows.Forms.Label();
            this.cuEmailErrorLbl = new System.Windows.Forms.Label();
            this.cuFCoumpanyNameErrorLbl = new System.Windows.Forms.Label();
            this.cuPasswordErrorLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cuFNamePanel = new System.Windows.Forms.Panel();
            this.label47 = new System.Windows.Forms.Label();
            this.cuFnameTxt = new System.Windows.Forms.TextBox();
            this.cuLNamePanel = new System.Windows.Forms.Panel();
            this.label46 = new System.Windows.Forms.Label();
            this.cuLnameTxt = new System.Windows.Forms.TextBox();
            this.cuLNameErrorLbl = new System.Windows.Forms.Label();
            this.cuCompanyNamePanel = new System.Windows.Forms.Panel();
            this.cuCoumpanyNameTxt = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.cuUserNameErrorLbl = new System.Windows.Forms.Label();
            this.cuUserTypeDrop = new System.Windows.Forms.ComboBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.cuCancelBtn = new System.Windows.Forms.Button();
            this.cuCreateUserBtn = new System.Windows.Forms.Button();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.cuPhoneTxt = new System.Windows.Forms.TextBox();
            this.cuEmailTxt = new System.Windows.Forms.TextBox();
            this.cuPasswordTxt = new System.Windows.Forms.TextBox();
            this.cuUsernameTxt = new System.Windows.Forms.TextBox();
            this.editFlightTab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.efDeleteBtn = new System.Windows.Forms.Button();
            this.efEditBtn = new System.Windows.Forms.Button();
            this.efCancelBtn = new System.Windows.Forms.Button();
            this.efPriceErrorLbl = new System.Windows.Forms.Label();
            this.efStatusDrop = new System.Windows.Forms.ComboBox();
            this.label71 = new System.Windows.Forms.Label();
            this.efArrTimePick = new System.Windows.Forms.DateTimePicker();
            this.efDepTimePick = new System.Windows.Forms.DateTimePicker();
            this.efArrTxt = new System.Windows.Forms.TextBox();
            this.efDepTxt = new System.Windows.Forms.TextBox();
            this.efPriceTxt = new System.Windows.Forms.TextBox();
            this.efFlightNumTxt = new System.Windows.Forms.TextBox();
            this.efDatePick = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.efPlaneIdDrop = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.createFlightTab = new System.Windows.Forms.TabPage();
            this.cfStatusDrop = new System.Windows.Forms.ComboBox();
            this.label66 = new System.Windows.Forms.Label();
            this.cfTimeErrorLbl = new System.Windows.Forms.Label();
            this.cfAirportsErrorLbl = new System.Windows.Forms.Label();
            this.cfPriceErrorLbl = new System.Windows.Forms.Label();
            this.cfArrTimePick = new System.Windows.Forms.DateTimePicker();
            this.cfDepTimePick = new System.Windows.Forms.DateTimePicker();
            this.cfCancelBtn = new System.Windows.Forms.Button();
            this.cfCreateBtn = new System.Windows.Forms.Button();
            this.cfDatePick = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.cfPriceTxt = new System.Windows.Forms.TextBox();
            this.cfFlightNumTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cfArrDrop = new System.Windows.Forms.ComboBox();
            this.cfDepDrop = new System.Windows.Forms.ComboBox();
            this.cfPlaneIdDrop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.bookingDetailsTab = new System.Windows.Forms.TabPage();
            this.bdUsrIDLbl = new System.Windows.Forms.TextBox();
            this.bdIDTxt = new System.Windows.Forms.TextBox();
            this.bdArrTxt = new System.Windows.Forms.TextBox();
            this.bdDepTxt = new System.Windows.Forms.TextBox();
            this.bdToTxt = new System.Windows.Forms.TextBox();
            this.bdFromTxt = new System.Windows.Forms.TextBox();
            this.bdArrTimeTxt = new System.Windows.Forms.TextBox();
            this.bdDepTimeTxt = new System.Windows.Forms.TextBox();
            this.bdDateTxt = new System.Windows.Forms.TextBox();
            this.bdFlightNumTxt = new System.Windows.Forms.TextBox();
            this.bdUsrTypeLbl = new System.Windows.Forms.Label();
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
            this.travellerUsersTab = new System.Windows.Forms.TabPage();
            this.btnReportUsers = new System.Windows.Forms.Button();
            this.addNotifications = new System.Windows.Forms.PictureBox();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.userCreateUserBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.travellerSettingsTab = new System.Windows.Forms.TabPage();
            this.btnBackup = new System.Windows.Forms.Button();
            this.setErrorLbl = new System.Windows.Forms.Label();
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
            this.bookingTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.travellerFlightsTab = new System.Windows.Forms.TabPage();
            this.viewPlanesBtn = new System.Windows.Forms.Button();
            this.flightsDataGridView = new System.Windows.Forms.DataGridView();
            this.viewAirCityCouBtn = new System.Windows.Forms.Button();
            this.creatFlightBtn = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControler = new System.Windows.Forms.TabControl();
            viewPlanes = new System.Windows.Forms.TabPage();
            label92 = new System.Windows.Forms.Label();
            label93 = new System.Windows.Forms.Label();
            label87 = new System.Windows.Forms.Label();
            label89 = new System.Windows.Forms.Label();
            viewPlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planesDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTab)).BeginInit();
            this.btntabCreatenotifications.SuspendLayout();
            this.viewLocation.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.countryGroupBox.SuspendLayout();
            this.AirportGroupBox.SuspendLayout();
            this.cityGroupBox.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.veAirCouCity.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countriesDataGridView)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airportsDataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.mtFirstNamePanel.SuspendLayout();
            this.mtLastNamePanel.SuspendLayout();
            this.mtCompanyNamePanel.SuspendLayout();
            this.mtAgencyPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.AddAirCityConTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.createUserTab.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.cuFNamePanel.SuspendLayout();
            this.cuLNamePanel.SuspendLayout();
            this.cuCompanyNamePanel.SuspendLayout();
            this.editFlightTab.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.createFlightTab.SuspendLayout();
            this.bookingDetailsTab.SuspendLayout();
            this.travellerUsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addNotifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.travellerSettingsTab.SuspendLayout();
            this.travellerBookingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTable)).BeginInit();
            this.travellerFlightsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).BeginInit();
            this.tabControler.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewPlanes
            // 
            viewPlanes.BackColor = System.Drawing.Color.Gainsboro;
            viewPlanes.Controls.Add(this.cpCapacityErrorLbl);
            viewPlanes.Controls.Add(this.cpModelErrorLbl);
            viewPlanes.Controls.Add(label92);
            viewPlanes.Controls.Add(label93);
            viewPlanes.Controls.Add(this.cpCapacityTxt);
            viewPlanes.Controls.Add(this.cpModelTxt);
            viewPlanes.Controls.Add(this.planesDataGridView);
            viewPlanes.Controls.Add(this.createPlaneBtn);
            viewPlanes.Controls.Add(label87);
            viewPlanes.Controls.Add(label89);
            viewPlanes.Location = new System.Drawing.Point(85, 4);
            viewPlanes.Name = "viewPlanes";
            viewPlanes.Padding = new System.Windows.Forms.Padding(3);
            viewPlanes.Size = new System.Drawing.Size(693, 720);
            viewPlanes.TabIndex = 14;
            viewPlanes.Text = "View Planes";
            // 
            // cpCapacityErrorLbl
            // 
            this.cpCapacityErrorLbl.AutoSize = true;
            this.cpCapacityErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.cpCapacityErrorLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpCapacityErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.cpCapacityErrorLbl.Location = new System.Drawing.Point(462, 344);
            this.cpCapacityErrorLbl.Name = "cpCapacityErrorLbl";
            this.cpCapacityErrorLbl.Size = new System.Drawing.Size(173, 28);
            this.cpCapacityErrorLbl.TabIndex = 119;
            this.cpCapacityErrorLbl.Text = "Error: Please fix..";
            this.cpCapacityErrorLbl.Visible = false;
            // 
            // cpModelErrorLbl
            // 
            this.cpModelErrorLbl.AutoSize = true;
            this.cpModelErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.cpModelErrorLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpModelErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.cpModelErrorLbl.Location = new System.Drawing.Point(458, 233);
            this.cpModelErrorLbl.Name = "cpModelErrorLbl";
            this.cpModelErrorLbl.Size = new System.Drawing.Size(173, 28);
            this.cpModelErrorLbl.TabIndex = 118;
            this.cpModelErrorLbl.Text = "Error: Please fix..";
            this.cpModelErrorLbl.Visible = false;
            // 
            // label92
            // 
            label92.AutoSize = true;
            label92.BackColor = System.Drawing.Color.Transparent;
            label92.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label92.Location = new System.Drawing.Point(463, 273);
            label92.Name = "label92";
            label92.Size = new System.Drawing.Size(152, 51);
            label92.TabIndex = 117;
            label92.Text = "Capacity:";
            label92.UseCompatibleTextRendering = true;
            // 
            // label93
            // 
            label93.AutoSize = true;
            label93.BackColor = System.Drawing.Color.Transparent;
            label93.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label93.Location = new System.Drawing.Point(461, 162);
            label93.Name = "label93";
            label93.Size = new System.Drawing.Size(215, 51);
            label93.TabIndex = 116;
            label93.Text = "Plane Model:";
            label93.UseCompatibleTextRendering = true;
            // 
            // cpCapacityTxt
            // 
            this.cpCapacityTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpCapacityTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpCapacityTxt.Location = new System.Drawing.Point(463, 308);
            this.cpCapacityTxt.Name = "cpCapacityTxt";
            this.cpCapacityTxt.Size = new System.Drawing.Size(275, 51);
            this.cpCapacityTxt.TabIndex = 115;
            this.cpCapacityTxt.Text = "0";
            this.cpCapacityTxt.TextChanged += new System.EventHandler(this.cpCapacityTxt_TextChanged);
            this.cpCapacityTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyIntgers_KeyPress);
            // 
            // cpModelTxt
            // 
            this.cpModelTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpModelTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpModelTxt.Location = new System.Drawing.Point(461, 197);
            this.cpModelTxt.Name = "cpModelTxt";
            this.cpModelTxt.Size = new System.Drawing.Size(275, 51);
            this.cpModelTxt.TabIndex = 114;
            this.cpModelTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyDotUnderscore_KeyPress);
            // 
            // planesDataGridView
            // 
            this.planesDataGridView.AllowUserToAddRows = false;
            this.planesDataGridView.AllowUserToDeleteRows = false;
            this.planesDataGridView.AllowUserToOrderColumns = true;
            this.planesDataGridView.AllowUserToResizeRows = false;
            this.planesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planesDataGridView.Location = new System.Drawing.Point(13, 152);
            this.planesDataGridView.MultiSelect = false;
            this.planesDataGridView.Name = "planesDataGridView";
            this.planesDataGridView.ReadOnly = true;
            this.planesDataGridView.RowHeadersWidth = 70;
            this.planesDataGridView.RowTemplate.Height = 30;
            this.planesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.planesDataGridView.Size = new System.Drawing.Size(430, 547);
            this.planesDataGridView.TabIndex = 43;
            this.planesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.planesDataGridView_CellClick);
            this.planesDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.planesDataGridView_DataBindingComplete);
            // 
            // createPlaneBtn
            // 
            this.createPlaneBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.createPlaneBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createPlaneBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.createPlaneBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPlaneBtn.ForeColor = System.Drawing.Color.White;
            this.createPlaneBtn.Location = new System.Drawing.Point(490, 404);
            this.createPlaneBtn.Name = "createPlaneBtn";
            this.createPlaneBtn.Size = new System.Drawing.Size(223, 55);
            this.createPlaneBtn.TabIndex = 42;
            this.createPlaneBtn.Text = "Create Plane";
            this.createPlaneBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.createPlaneBtn.UseVisualStyleBackColor = false;
            this.createPlaneBtn.Click += new System.EventHandler(this.createPlaneBtn_Click);
            // 
            // label87
            // 
            label87.AutoSize = true;
            label87.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label87.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label87.Location = new System.Drawing.Point(17, 81);
            label87.Name = "label87";
            label87.Size = new System.Drawing.Size(320, 35);
            label87.TabIndex = 41;
            label87.Text = "Manage planes in this Page";
            // 
            // label89
            // 
            label89.AutoSize = true;
            label89.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label89.Location = new System.Drawing.Point(10, 22);
            label89.Name = "label89";
            label89.Size = new System.Drawing.Size(264, 100);
            label89.TabIndex = 40;
            label89.Text = "Planes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.usersIcon);
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
            // usersIcon
            // 
            this.usersIcon.Image = ((System.Drawing.Image)(resources.GetObject("usersIcon.Image")));
            this.usersIcon.Location = new System.Drawing.Point(32, 392);
            this.usersIcon.Name = "usersIcon";
            this.usersIcon.Size = new System.Drawing.Size(104, 80);
            this.usersIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usersIcon.TabIndex = 8;
            this.usersIcon.TabStop = false;
            this.usersIcon.Click += new System.EventHandler(this.users_Click);
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
            this.logOutIcon.Click += new System.EventHandler(this.logOutIcon_Click);
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
            this.logoIcon.Image = ((System.Drawing.Image)(resources.GetObject("logoIcon.Image")));
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
            // btntabCreatenotifications
            // 
            this.btntabCreatenotifications.BackColor = System.Drawing.Color.Gainsboro;
            this.btntabCreatenotifications.Controls.Add(this.comboBoxType);
            this.btntabCreatenotifications.Controls.Add(this.lblErrorType);
            this.btntabCreatenotifications.Controls.Add(this.label88);
            this.btntabCreatenotifications.Controls.Add(this.label86);
            this.btntabCreatenotifications.Controls.Add(this.lblErrorFlight);
            this.btntabCreatenotifications.Controls.Add(this.comboBoxFlights);
            this.btntabCreatenotifications.Controls.Add(this.button1);
            this.btntabCreatenotifications.Controls.Add(this.lblErrorDescription);
            this.btntabCreatenotifications.Controls.Add(this.lblErrorTitle);
            this.btntabCreatenotifications.Controls.Add(this.label84);
            this.btntabCreatenotifications.Controls.Add(this.txtDescription);
            this.btntabCreatenotifications.Controls.Add(this.txtTitle);
            this.btntabCreatenotifications.Controls.Add(this.label76);
            this.btntabCreatenotifications.Controls.Add(this.label74);
            this.btntabCreatenotifications.Location = new System.Drawing.Point(85, 4);
            this.btntabCreatenotifications.Name = "btntabCreatenotifications";
            this.btntabCreatenotifications.Padding = new System.Windows.Forms.Padding(3);
            this.btntabCreatenotifications.Size = new System.Drawing.Size(693, 720);
            this.btntabCreatenotifications.TabIndex = 12;
            this.btntabCreatenotifications.Text = "Create Notifications";
            this.btntabCreatenotifications.Paint += new System.Windows.Forms.PaintEventHandler(this.btntabCreatenotifications_Paint);
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "",
            "Policy",
            "Security",
            "Alert",
            "Refund",
            "Cancellation",
            "Discount",
            "Delay",
            "Registration",
            "Reminder",
            "Offer",
            "Updat",
            "Feedback",
            "Payment",
            "Booking"});
            this.comboBoxType.Location = new System.Drawing.Point(31, 395);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(642, 39);
            this.comboBoxType.TabIndex = 170;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblErrorType
            // 
            this.lblErrorType.AutoSize = true;
            this.lblErrorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorType.ForeColor = System.Drawing.Color.Red;
            this.lblErrorType.Location = new System.Drawing.Point(39, 430);
            this.lblErrorType.Name = "lblErrorType";
            this.lblErrorType.Size = new System.Drawing.Size(0, 29);
            this.lblErrorType.TabIndex = 169;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.BackColor = System.Drawing.Color.Transparent;
            this.label88.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.Location = new System.Drawing.Point(30, 363);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(275, 51);
            this.label88.TabIndex = 168;
            this.label88.Text = "Notification Type";
            this.label88.UseCompatibleTextRendering = true;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.BackColor = System.Drawing.Color.Transparent;
            this.label86.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.Location = new System.Drawing.Point(31, 472);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(112, 51);
            this.label86.TabIndex = 166;
            this.label86.Text = "Flights";
            this.label86.UseCompatibleTextRendering = true;
            // 
            // lblErrorFlight
            // 
            this.lblErrorFlight.AutoSize = true;
            this.lblErrorFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFlight.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFlight.Location = new System.Drawing.Point(39, 543);
            this.lblErrorFlight.Name = "lblErrorFlight";
            this.lblErrorFlight.Size = new System.Drawing.Size(0, 29);
            this.lblErrorFlight.TabIndex = 165;
            // 
            // comboBoxFlights
            // 
            this.comboBoxFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFlights.FormattingEnabled = true;
            this.comboBoxFlights.Location = new System.Drawing.Point(31, 509);
            this.comboBoxFlights.Name = "comboBoxFlights";
            this.comboBoxFlights.Size = new System.Drawing.Size(642, 39);
            this.comboBoxFlights.TabIndex = 164;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(243, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 55);
            this.button1.TabIndex = 162;
            this.button1.Text = "Create Notification";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblErrorDescription
            // 
            this.lblErrorDescription.AutoSize = true;
            this.lblErrorDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDescription.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDescription.Location = new System.Drawing.Point(38, 319);
            this.lblErrorDescription.Name = "lblErrorDescription";
            this.lblErrorDescription.Size = new System.Drawing.Size(0, 29);
            this.lblErrorDescription.TabIndex = 161;
            // 
            // lblErrorTitle
            // 
            this.lblErrorTitle.AutoSize = true;
            this.lblErrorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTitle.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTitle.Location = new System.Drawing.Point(39, 163);
            this.lblErrorTitle.Name = "lblErrorTitle";
            this.lblErrorTitle.Size = new System.Drawing.Size(0, 29);
            this.lblErrorTitle.TabIndex = 160;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.BackColor = System.Drawing.Color.Transparent;
            this.label84.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.Location = new System.Drawing.Point(32, 204);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(187, 51);
            this.label84.TabIndex = 158;
            this.label84.Text = "Description";
            this.label84.UseCompatibleTextRendering = true;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(31, 240);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(642, 79);
            this.txtDescription.TabIndex = 157;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(31, 123);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(642, 51);
            this.txtTitle.TabIndex = 155;
            this.txtTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.BackColor = System.Drawing.Color.Transparent;
            this.label76.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.Location = new System.Drawing.Point(31, 91);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(80, 51);
            this.label76.TabIndex = 156;
            this.label76.Text = "Title";
            this.label76.UseCompatibleTextRendering = true;
            // 
            // label74
            // 
            this.label74.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.Location = new System.Drawing.Point(18, 12);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(622, 73);
            this.label74.TabIndex = 154;
            this.label74.Text = "Create Notifications";
            // 
            // viewLocation
            // 
            this.viewLocation.BackColor = System.Drawing.Color.Gainsboro;
            this.viewLocation.Controls.Add(this.flowLayoutPanel5);
            this.viewLocation.Controls.Add(this.flowLayoutPanel6);
            this.viewLocation.Controls.Add(this.label79);
            this.viewLocation.Controls.Add(this.label83);
            this.viewLocation.Location = new System.Drawing.Point(85, 4);
            this.viewLocation.Name = "viewLocation";
            this.viewLocation.Padding = new System.Windows.Forms.Padding(3);
            this.viewLocation.Size = new System.Drawing.Size(693, 720);
            this.viewLocation.TabIndex = 11;
            this.viewLocation.Text = "veLocation";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.countryGroupBox);
            this.flowLayoutPanel5.Controls.Add(this.AirportGroupBox);
            this.flowLayoutPanel5.Controls.Add(this.cityGroupBox);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(13, 123);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(724, 458);
            this.flowLayoutPanel5.TabIndex = 161;
            // 
            // countryGroupBox
            // 
            this.countryGroupBox.Controls.Add(this.label73);
            this.countryGroupBox.Controls.Add(this.editContErrorLbl);
            this.countryGroupBox.Controls.Add(this.editContNameTxt);
            this.countryGroupBox.Location = new System.Drawing.Point(3, 3);
            this.countryGroupBox.Name = "countryGroupBox";
            this.countryGroupBox.Size = new System.Drawing.Size(707, 150);
            this.countryGroupBox.TabIndex = 147;
            this.countryGroupBox.TabStop = false;
            this.countryGroupBox.Text = "Country";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.BackColor = System.Drawing.Color.Transparent;
            this.label73.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.Location = new System.Drawing.Point(20, 24);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(243, 51);
            this.label73.TabIndex = 111;
            this.label73.Text = "Country Name:";
            this.label73.UseCompatibleTextRendering = true;
            // 
            // editContErrorLbl
            // 
            this.editContErrorLbl.AutoSize = true;
            this.editContErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.editContErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editContErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.editContErrorLbl.Location = new System.Drawing.Point(278, 64);
            this.editContErrorLbl.Name = "editContErrorLbl";
            this.editContErrorLbl.Size = new System.Drawing.Size(429, 44);
            this.editContErrorLbl.TabIndex = 132;
            this.editContErrorLbl.Text = "Error: Country already Exist";
            this.editContErrorLbl.Visible = false;
            // 
            // editContNameTxt
            // 
            this.editContNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editContNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editContNameTxt.Location = new System.Drawing.Point(20, 57);
            this.editContNameTxt.Name = "editContNameTxt";
            this.editContNameTxt.Size = new System.Drawing.Size(246, 51);
            this.editContNameTxt.TabIndex = 109;
            this.editContNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyLetters_KeyPress);
            // 
            // AirportGroupBox
            // 
            this.AirportGroupBox.Controls.Add(this.label78);
            this.AirportGroupBox.Controls.Add(this.editAirportConDrop);
            this.AirportGroupBox.Controls.Add(this.editAirportNameTxt);
            this.AirportGroupBox.Controls.Add(this.label80);
            this.AirportGroupBox.Controls.Add(this.editAirportLongitudeTxt);
            this.AirportGroupBox.Controls.Add(this.label81);
            this.AirportGroupBox.Controls.Add(this.label82);
            this.AirportGroupBox.Controls.Add(this.editAirportCityDrop);
            this.AirportGroupBox.Controls.Add(this.editAirportLatitudeTxt);
            this.AirportGroupBox.Controls.Add(this.editAirportErrorLbl);
            this.AirportGroupBox.Controls.Add(this.label85);
            this.AirportGroupBox.Location = new System.Drawing.Point(3, 159);
            this.AirportGroupBox.Name = "AirportGroupBox";
            this.AirportGroupBox.Size = new System.Drawing.Size(707, 237);
            this.AirportGroupBox.TabIndex = 145;
            this.AirportGroupBox.TabStop = false;
            this.AirportGroupBox.Text = "Airport";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.BackColor = System.Drawing.Color.Transparent;
            this.label78.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.Location = new System.Drawing.Point(20, 24);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(231, 51);
            this.label78.TabIndex = 123;
            this.label78.Text = "Airport Name:";
            this.label78.UseCompatibleTextRendering = true;
            // 
            // editAirportConDrop
            // 
            this.editAirportConDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editAirportConDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.editAirportConDrop.FormattingEnabled = true;
            this.editAirportConDrop.Location = new System.Drawing.Point(360, 57);
            this.editAirportConDrop.Name = "editAirportConDrop";
            this.editAirportConDrop.Size = new System.Drawing.Size(309, 52);
            this.editAirportConDrop.TabIndex = 141;
            this.editAirportConDrop.SelectedIndexChanged += new System.EventHandler(this.editAirportConDrop_SelectedIndexChanged);
            // 
            // editAirportNameTxt
            // 
            this.editAirportNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editAirportNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAirportNameTxt.Location = new System.Drawing.Point(20, 57);
            this.editAirportNameTxt.Name = "editAirportNameTxt";
            this.editAirportNameTxt.Size = new System.Drawing.Size(320, 51);
            this.editAirportNameTxt.TabIndex = 121;
            this.editAirportNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyDotUnderscore_KeyPress);
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.BackColor = System.Drawing.Color.Transparent;
            this.label80.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.Location = new System.Drawing.Point(360, 25);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(243, 51);
            this.label80.TabIndex = 140;
            this.label80.Text = "Country Name:";
            this.label80.UseCompatibleTextRendering = true;
            // 
            // editAirportLongitudeTxt
            // 
            this.editAirportLongitudeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editAirportLongitudeTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAirportLongitudeTxt.Location = new System.Drawing.Point(494, 146);
            this.editAirportLongitudeTxt.Name = "editAirportLongitudeTxt";
            this.editAirportLongitudeTxt.Size = new System.Drawing.Size(175, 51);
            this.editAirportLongitudeTxt.TabIndex = 138;
            this.editAirportLongitudeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLatitudeLongitude_KeyPress);
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.BackColor = System.Drawing.Color.Transparent;
            this.label81.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.Location = new System.Drawing.Point(20, 113);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(180, 51);
            this.label81.TabIndex = 129;
            this.label81.Text = "City Name:";
            this.label81.UseCompatibleTextRendering = true;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.BackColor = System.Drawing.Color.Transparent;
            this.label82.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.Location = new System.Drawing.Point(494, 113);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(175, 51);
            this.label82.TabIndex = 139;
            this.label82.Text = "Longitude:";
            this.label82.UseCompatibleTextRendering = true;
            // 
            // editAirportCityDrop
            // 
            this.editAirportCityDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editAirportCityDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.editAirportCityDrop.FormattingEnabled = true;
            this.editAirportCityDrop.Location = new System.Drawing.Point(20, 145);
            this.editAirportCityDrop.Name = "editAirportCityDrop";
            this.editAirportCityDrop.Size = new System.Drawing.Size(246, 52);
            this.editAirportCityDrop.TabIndex = 131;
            // 
            // editAirportLatitudeTxt
            // 
            this.editAirportLatitudeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editAirportLatitudeTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAirportLatitudeTxt.Location = new System.Drawing.Point(293, 146);
            this.editAirportLatitudeTxt.Name = "editAirportLatitudeTxt";
            this.editAirportLatitudeTxt.Size = new System.Drawing.Size(175, 51);
            this.editAirportLatitudeTxt.TabIndex = 136;
            this.editAirportLatitudeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLatitudeLongitude_KeyPress);
            // 
            // editAirportErrorLbl
            // 
            this.editAirportErrorLbl.AutoSize = true;
            this.editAirportErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.editAirportErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAirportErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.editAirportErrorLbl.Location = new System.Drawing.Point(178, 196);
            this.editAirportErrorLbl.Name = "editAirportErrorLbl";
            this.editAirportErrorLbl.Size = new System.Drawing.Size(418, 44);
            this.editAirportErrorLbl.TabIndex = 134;
            this.editAirportErrorLbl.Text = "Error: Airport already Exist";
            this.editAirportErrorLbl.Visible = false;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.BackColor = System.Drawing.Color.Transparent;
            this.label85.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label85.Location = new System.Drawing.Point(293, 113);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(149, 51);
            this.label85.TabIndex = 137;
            this.label85.Text = "Latitude:";
            this.label85.UseCompatibleTextRendering = true;
            // 
            // cityGroupBox
            // 
            this.cityGroupBox.Controls.Add(this.label75);
            this.cityGroupBox.Controls.Add(this.editCitytNameTxt);
            this.cityGroupBox.Controls.Add(this.editCityErrorLbl);
            this.cityGroupBox.Controls.Add(this.label77);
            this.cityGroupBox.Controls.Add(this.editConDrop);
            this.cityGroupBox.Location = new System.Drawing.Point(3, 402);
            this.cityGroupBox.Name = "cityGroupBox";
            this.cityGroupBox.Size = new System.Drawing.Size(707, 155);
            this.cityGroupBox.TabIndex = 146;
            this.cityGroupBox.TabStop = false;
            this.cityGroupBox.Text = "City";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.BackColor = System.Drawing.Color.Transparent;
            this.label75.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(20, 29);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(180, 51);
            this.label75.TabIndex = 117;
            this.label75.Text = "City Name:";
            this.label75.UseCompatibleTextRendering = true;
            // 
            // editCitytNameTxt
            // 
            this.editCitytNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editCitytNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCitytNameTxt.Location = new System.Drawing.Point(20, 62);
            this.editCitytNameTxt.Name = "editCitytNameTxt";
            this.editCitytNameTxt.Size = new System.Drawing.Size(246, 51);
            this.editCitytNameTxt.TabIndex = 115;
            this.editCitytNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyLetters_KeyPress);
            // 
            // editCityErrorLbl
            // 
            this.editCityErrorLbl.AutoSize = true;
            this.editCityErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.editCityErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCityErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.editCityErrorLbl.Location = new System.Drawing.Point(302, 114);
            this.editCityErrorLbl.Name = "editCityErrorLbl";
            this.editCityErrorLbl.Size = new System.Drawing.Size(368, 44);
            this.editCityErrorLbl.TabIndex = 133;
            this.editCityErrorLbl.Text = "Error: City already Exist";
            this.editCityErrorLbl.Visible = false;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.BackColor = System.Drawing.Color.Transparent;
            this.label77.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.Location = new System.Drawing.Point(293, 29);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(243, 51);
            this.label77.TabIndex = 127;
            this.label77.Text = "Country Name:";
            this.label77.UseCompatibleTextRendering = true;
            // 
            // editConDrop
            // 
            this.editConDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editConDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.editConDrop.FormattingEnabled = true;
            this.editConDrop.Location = new System.Drawing.Point(293, 61);
            this.editConDrop.Name = "editConDrop";
            this.editConDrop.Size = new System.Drawing.Size(246, 52);
            this.editConDrop.TabIndex = 130;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.editLocationDelete);
            this.flowLayoutPanel6.Controls.Add(this.editLocationSave);
            this.flowLayoutPanel6.Controls.Add(this.editLocationBack);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(23, 611);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(537, 57);
            this.flowLayoutPanel6.TabIndex = 160;
            // 
            // editLocationDelete
            // 
            this.editLocationDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.editLocationDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editLocationDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.editLocationDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLocationDelete.ForeColor = System.Drawing.Color.White;
            this.editLocationDelete.Location = new System.Drawing.Point(3, 3);
            this.editLocationDelete.Name = "editLocationDelete";
            this.editLocationDelete.Size = new System.Drawing.Size(139, 43);
            this.editLocationDelete.TabIndex = 128;
            this.editLocationDelete.Text = "Delete Location";
            this.editLocationDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.editLocationDelete.UseVisualStyleBackColor = false;
            this.editLocationDelete.Click += new System.EventHandler(this.editLocationDelete_Click);
            // 
            // editLocationSave
            // 
            this.editLocationSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.editLocationSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editLocationSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.editLocationSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLocationSave.ForeColor = System.Drawing.Color.White;
            this.editLocationSave.Location = new System.Drawing.Point(148, 3);
            this.editLocationSave.Name = "editLocationSave";
            this.editLocationSave.Size = new System.Drawing.Size(139, 43);
            this.editLocationSave.TabIndex = 119;
            this.editLocationSave.Text = "Save Edits";
            this.editLocationSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.editLocationSave.UseVisualStyleBackColor = false;
            this.editLocationSave.Click += new System.EventHandler(this.editLocationSave_Click);
            // 
            // editLocationBack
            // 
            this.editLocationBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.editLocationBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editLocationBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.editLocationBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLocationBack.ForeColor = System.Drawing.Color.White;
            this.editLocationBack.Location = new System.Drawing.Point(293, 3);
            this.editLocationBack.Name = "editLocationBack";
            this.editLocationBack.Size = new System.Drawing.Size(139, 43);
            this.editLocationBack.TabIndex = 129;
            this.editLocationBack.Text = "Back";
            this.editLocationBack.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.editLocationBack.UseVisualStyleBackColor = false;
            this.editLocationBack.Click += new System.EventHandler(this.editLocationBack_Click);
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label79.Location = new System.Drawing.Point(17, 584);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(1444, 35);
            this.label79.TabIndex = 157;
            this.label79.Text = "Attention if you delete this location all its information and other locations rel" +
    "ated to it will be deleted and can\'t be restored";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.Location = new System.Drawing.Point(9, 30);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(624, 100);
            this.label83.TabIndex = 153;
            this.label83.Text = "Manage Location";
            // 
            // veAirCouCity
            // 
            this.veAirCouCity.BackColor = System.Drawing.Color.Gainsboro;
            this.veAirCouCity.Controls.Add(this.button2);
            this.veAirCouCity.Controls.Add(this.groupBox4);
            this.veAirCouCity.Controls.Add(this.groupBox5);
            this.veAirCouCity.Controls.Add(this.groupBox6);
            this.veAirCouCity.Controls.Add(this.addAirCityCouBtn);
            this.veAirCouCity.Controls.Add(this.label72);
            this.veAirCouCity.Controls.Add(this.Locations);
            this.veAirCouCity.Location = new System.Drawing.Point(85, 4);
            this.veAirCouCity.Name = "veAirCouCity";
            this.veAirCouCity.Padding = new System.Windows.Forms.Padding(3);
            this.veAirCouCity.Size = new System.Drawing.Size(693, 720);
            this.veAirCouCity.TabIndex = 10;
            this.veAirCouCity.Text = "veAirCouCity";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(480, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 55);
            this.button2.TabIndex = 148;
            this.button2.Text = "Generate Locations Report";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.countriesDataGridView);
            this.groupBox4.Location = new System.Drawing.Point(7, 153);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(707, 150);
            this.groupBox4.TabIndex = 147;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Country";
            // 
            // countriesDataGridView
            // 
            this.countriesDataGridView.AllowUserToAddRows = false;
            this.countriesDataGridView.AllowUserToDeleteRows = false;
            this.countriesDataGridView.AllowUserToOrderColumns = true;
            this.countriesDataGridView.AllowUserToResizeRows = false;
            this.countriesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.countriesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.countriesDataGridView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle38.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.countriesDataGridView.DefaultCellStyle = dataGridViewCellStyle38;
            this.countriesDataGridView.Location = new System.Drawing.Point(7, 23);
            this.countriesDataGridView.Name = "countriesDataGridView";
            this.countriesDataGridView.RowHeadersVisible = false;
            this.countriesDataGridView.RowHeadersWidth = 70;
            this.countriesDataGridView.RowTemplate.Height = 50;
            this.countriesDataGridView.Size = new System.Drawing.Size(694, 121);
            this.countriesDataGridView.TabIndex = 0;
            this.countriesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.countriesDataGridView_CellClick);
            this.countriesDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.usersDataGridView_DataBindingComplete);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.citiesDataGridView);
            this.groupBox5.Location = new System.Drawing.Point(7, 304);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(707, 155);
            this.groupBox5.TabIndex = 146;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "City";
            // 
            // citiesDataGridView
            // 
            this.citiesDataGridView.AllowUserToAddRows = false;
            this.citiesDataGridView.AllowUserToDeleteRows = false;
            this.citiesDataGridView.AllowUserToOrderColumns = true;
            this.citiesDataGridView.AllowUserToResizeRows = false;
            this.citiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.citiesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.citiesDataGridView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle40.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.citiesDataGridView.DefaultCellStyle = dataGridViewCellStyle40;
            this.citiesDataGridView.Location = new System.Drawing.Point(6, 23);
            this.citiesDataGridView.Name = "citiesDataGridView";
            this.citiesDataGridView.RowHeadersVisible = false;
            this.citiesDataGridView.RowHeadersWidth = 70;
            this.citiesDataGridView.RowTemplate.Height = 50;
            this.citiesDataGridView.Size = new System.Drawing.Size(694, 126);
            this.citiesDataGridView.TabIndex = 1;
            this.citiesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.citiesDataGridView_CellClick);
            this.citiesDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.usersDataGridView_DataBindingComplete);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.airportsDataGridView);
            this.groupBox6.Location = new System.Drawing.Point(7, 462);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(707, 237);
            this.groupBox6.TabIndex = 145;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Airport";
            // 
            // airportsDataGridView
            // 
            this.airportsDataGridView.AllowUserToAddRows = false;
            this.airportsDataGridView.AllowUserToDeleteRows = false;
            this.airportsDataGridView.AllowUserToOrderColumns = true;
            this.airportsDataGridView.AllowUserToResizeRows = false;
            this.airportsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle41.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.airportsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.airportsDataGridView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle42.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.airportsDataGridView.DefaultCellStyle = dataGridViewCellStyle42;
            this.airportsDataGridView.Location = new System.Drawing.Point(7, 23);
            this.airportsDataGridView.Name = "airportsDataGridView";
            this.airportsDataGridView.RowHeadersVisible = false;
            this.airportsDataGridView.RowHeadersWidth = 70;
            this.airportsDataGridView.RowTemplate.Height = 50;
            this.airportsDataGridView.Size = new System.Drawing.Size(694, 208);
            this.airportsDataGridView.TabIndex = 2;
            this.airportsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.airportsDataGridView_CellClick);
            this.airportsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.usersDataGridView_DataBindingComplete);
            // 
            // addAirCityCouBtn
            // 
            this.addAirCityCouBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.addAirCityCouBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addAirCityCouBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addAirCityCouBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAirCityCouBtn.ForeColor = System.Drawing.Color.White;
            this.addAirCityCouBtn.Location = new System.Drawing.Point(480, 97);
            this.addAirCityCouBtn.Name = "addAirCityCouBtn";
            this.addAirCityCouBtn.Size = new System.Drawing.Size(223, 55);
            this.addAirCityCouBtn.TabIndex = 39;
            this.addAirCityCouBtn.Text = "Add Location";
            this.addAirCityCouBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addAirCityCouBtn.UseVisualStyleBackColor = false;
            this.addAirCityCouBtn.Click += new System.EventHandler(this.addAirCityCouBtn_Click_1);
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label72.Location = new System.Drawing.Point(31, 84);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(369, 35);
            this.label72.TabIndex = 38;
            this.label72.Text = "View and edit all locations here";
            // 
            // Locations
            // 
            this.Locations.AutoSize = true;
            this.Locations.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Locations.Location = new System.Drawing.Point(24, 25);
            this.Locations.Name = "Locations";
            this.Locations.Size = new System.Drawing.Size(363, 100);
            this.Locations.TabIndex = 37;
            this.Locations.Text = "Locations";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.flowLayoutPanel3);
            this.tabPage1.Controls.Add(this.mtAgencyPanel);
            this.tabPage1.Controls.Add(this.mtUsernameTxt);
            this.tabPage1.Controls.Add(this.mtPhoneTxt);
            this.tabPage1.Controls.Add(this.mtEmailTxt);
            this.tabPage1.Controls.Add(this.mtUserIDTxt);
            this.tabPage1.Controls.Add(this.mtUserTypeTxt);
            this.tabPage1.Controls.Add(this.label69);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.label65);
            this.tabPage1.Controls.Add(this.label64);
            this.tabPage1.Controls.Add(this.label59);
            this.tabPage1.Controls.Add(this.label60);
            this.tabPage1.Controls.Add(this.label63);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Location = new System.Drawing.Point(85, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(693, 720);
            this.tabPage1.TabIndex = 9;
            this.tabPage1.Text = "Manage User";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.mtFirstNamePanel);
            this.flowLayoutPanel3.Controls.Add(this.mtLastNamePanel);
            this.flowLayoutPanel3.Controls.Add(this.mtCompanyNamePanel);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(17, 170);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(710, 92);
            this.flowLayoutPanel3.TabIndex = 152;
            // 
            // mtFirstNamePanel
            // 
            this.mtFirstNamePanel.Controls.Add(this.label62);
            this.mtFirstNamePanel.Controls.Add(this.mtFnameTxt);
            this.mtFirstNamePanel.Location = new System.Drawing.Point(3, 3);
            this.mtFirstNamePanel.Name = "mtFirstNamePanel";
            this.mtFirstNamePanel.Size = new System.Drawing.Size(358, 82);
            this.mtFirstNamePanel.TabIndex = 150;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.BackColor = System.Drawing.Color.Transparent;
            this.label62.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(3, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(188, 51);
            this.label62.TabIndex = 120;
            this.label62.Text = "First Name:";
            this.label62.UseCompatibleTextRendering = true;
            // 
            // mtFnameTxt
            // 
            this.mtFnameTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.mtFnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtFnameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtFnameTxt.Location = new System.Drawing.Point(8, 38);
            this.mtFnameTxt.Name = "mtFnameTxt";
            this.mtFnameTxt.ReadOnly = true;
            this.mtFnameTxt.Size = new System.Drawing.Size(246, 44);
            this.mtFnameTxt.TabIndex = 139;
            this.mtFnameTxt.Text = "Employer/Traveler";
            // 
            // mtLastNamePanel
            // 
            this.mtLastNamePanel.Controls.Add(this.label61);
            this.mtLastNamePanel.Controls.Add(this.mtLnameTxt);
            this.mtLastNamePanel.Location = new System.Drawing.Point(367, 3);
            this.mtLastNamePanel.Name = "mtLastNamePanel";
            this.mtLastNamePanel.Size = new System.Drawing.Size(301, 82);
            this.mtLastNamePanel.TabIndex = 151;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.Color.Transparent;
            this.label61.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(0, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(183, 51);
            this.label61.TabIndex = 121;
            this.label61.Text = "Last Name:";
            this.label61.UseCompatibleTextRendering = true;
            // 
            // mtLnameTxt
            // 
            this.mtLnameTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.mtLnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtLnameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtLnameTxt.Location = new System.Drawing.Point(7, 35);
            this.mtLnameTxt.Name = "mtLnameTxt";
            this.mtLnameTxt.ReadOnly = true;
            this.mtLnameTxt.Size = new System.Drawing.Size(246, 44);
            this.mtLnameTxt.TabIndex = 141;
            this.mtLnameTxt.Text = "Employer/Traveler";
            // 
            // mtCompanyNamePanel
            // 
            this.mtCompanyNamePanel.Controls.Add(this.mtCompanyNamelLbl);
            this.mtCompanyNamePanel.Controls.Add(this.mtCompanyNamelTxt);
            this.mtCompanyNamePanel.Location = new System.Drawing.Point(3, 91);
            this.mtCompanyNamePanel.Name = "mtCompanyNamePanel";
            this.mtCompanyNamePanel.Size = new System.Drawing.Size(336, 77);
            this.mtCompanyNamePanel.TabIndex = 151;
            // 
            // mtCompanyNamelLbl
            // 
            this.mtCompanyNamelLbl.AutoSize = true;
            this.mtCompanyNamelLbl.BackColor = System.Drawing.Color.Transparent;
            this.mtCompanyNamelLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtCompanyNamelLbl.Location = new System.Drawing.Point(3, 0);
            this.mtCompanyNamelLbl.Name = "mtCompanyNamelLbl";
            this.mtCompanyNamelLbl.Size = new System.Drawing.Size(265, 51);
            this.mtCompanyNamelLbl.TabIndex = 146;
            this.mtCompanyNamelLbl.Text = "Company Name:";
            this.mtCompanyNamelLbl.UseCompatibleTextRendering = true;
            // 
            // mtCompanyNamelTxt
            // 
            this.mtCompanyNamelTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.mtCompanyNamelTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtCompanyNamelTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtCompanyNamelTxt.Location = new System.Drawing.Point(10, 35);
            this.mtCompanyNamelTxt.Name = "mtCompanyNamelTxt";
            this.mtCompanyNamelTxt.ReadOnly = true;
            this.mtCompanyNamelTxt.Size = new System.Drawing.Size(246, 44);
            this.mtCompanyNamelTxt.TabIndex = 148;
            this.mtCompanyNamelTxt.Text = "Employer/Traveler";
            // 
            // mtAgencyPanel
            // 
            this.mtAgencyPanel.Controls.Add(this.mtAgencyIdTxt);
            this.mtAgencyPanel.Controls.Add(this.mtAgencyIdLbl);
            this.mtAgencyPanel.Location = new System.Drawing.Point(24, 426);
            this.mtAgencyPanel.Name = "mtAgencyPanel";
            this.mtAgencyPanel.Size = new System.Drawing.Size(301, 83);
            this.mtAgencyPanel.TabIndex = 150;
            // 
            // mtAgencyIdTxt
            // 
            this.mtAgencyIdTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.mtAgencyIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtAgencyIdTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtAgencyIdTxt.Location = new System.Drawing.Point(11, 38);
            this.mtAgencyIdTxt.Name = "mtAgencyIdTxt";
            this.mtAgencyIdTxt.ReadOnly = true;
            this.mtAgencyIdTxt.Size = new System.Drawing.Size(246, 44);
            this.mtAgencyIdTxt.TabIndex = 147;
            this.mtAgencyIdTxt.Text = "Employer/Traveler";
            // 
            // mtAgencyIdLbl
            // 
            this.mtAgencyIdLbl.AutoSize = true;
            this.mtAgencyIdLbl.BackColor = System.Drawing.Color.Transparent;
            this.mtAgencyIdLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtAgencyIdLbl.Location = new System.Drawing.Point(4, 3);
            this.mtAgencyIdLbl.Name = "mtAgencyIdLbl";
            this.mtAgencyIdLbl.Size = new System.Drawing.Size(174, 51);
            this.mtAgencyIdLbl.TabIndex = 145;
            this.mtAgencyIdLbl.Text = "Agency ID:";
            this.mtAgencyIdLbl.UseCompatibleTextRendering = true;
            // 
            // mtUsernameTxt
            // 
            this.mtUsernameTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.mtUsernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtUsernameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtUsernameTxt.Location = new System.Drawing.Point(30, 291);
            this.mtUsernameTxt.Name = "mtUsernameTxt";
            this.mtUsernameTxt.ReadOnly = true;
            this.mtUsernameTxt.Size = new System.Drawing.Size(246, 44);
            this.mtUsernameTxt.TabIndex = 144;
            this.mtUsernameTxt.Text = "Employer/Traveler";
            // 
            // mtPhoneTxt
            // 
            this.mtPhoneTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.mtPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtPhoneTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtPhoneTxt.Location = new System.Drawing.Point(391, 378);
            this.mtPhoneTxt.Name = "mtPhoneTxt";
            this.mtPhoneTxt.ReadOnly = true;
            this.mtPhoneTxt.Size = new System.Drawing.Size(246, 44);
            this.mtPhoneTxt.TabIndex = 142;
            this.mtPhoneTxt.Text = "Employer/Traveler";
            // 
            // mtEmailTxt
            // 
            this.mtEmailTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.mtEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtEmailTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtEmailTxt.Location = new System.Drawing.Point(30, 378);
            this.mtEmailTxt.Name = "mtEmailTxt";
            this.mtEmailTxt.ReadOnly = true;
            this.mtEmailTxt.Size = new System.Drawing.Size(246, 44);
            this.mtEmailTxt.TabIndex = 140;
            this.mtEmailTxt.Text = "Employer/Traveler";
            // 
            // mtUserIDTxt
            // 
            this.mtUserIDTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.mtUserIDTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtUserIDTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtUserIDTxt.Location = new System.Drawing.Point(132, 124);
            this.mtUserIDTxt.Name = "mtUserIDTxt";
            this.mtUserIDTxt.ReadOnly = true;
            this.mtUserIDTxt.Size = new System.Drawing.Size(246, 44);
            this.mtUserIDTxt.TabIndex = 138;
            this.mtUserIDTxt.Text = "Employer/Traveler";
            // 
            // mtUserTypeTxt
            // 
            this.mtUserTypeTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.mtUserTypeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtUserTypeTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtUserTypeTxt.Location = new System.Drawing.Point(391, 291);
            this.mtUserTypeTxt.Name = "mtUserTypeTxt";
            this.mtUserTypeTxt.ReadOnly = true;
            this.mtUserTypeTxt.Size = new System.Drawing.Size(246, 44);
            this.mtUserTypeTxt.TabIndex = 131;
            this.mtUserTypeTxt.Text = "Employer/Traveler";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.BackColor = System.Drawing.Color.Transparent;
            this.label69.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(23, 256);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(179, 51);
            this.label69.TabIndex = 143;
            this.label69.Text = "Username:";
            this.label69.UseCompatibleTextRendering = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.mtDeleteBtn);
            this.flowLayoutPanel1.Controls.Add(this.mtCancelBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 611);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(537, 57);
            this.flowLayoutPanel1.TabIndex = 137;
            // 
            // mtDeleteBtn
            // 
            this.mtDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.mtDeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mtDeleteBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.mtDeleteBtn.Location = new System.Drawing.Point(3, 3);
            this.mtDeleteBtn.Name = "mtDeleteBtn";
            this.mtDeleteBtn.Size = new System.Drawing.Size(139, 43);
            this.mtDeleteBtn.TabIndex = 128;
            this.mtDeleteBtn.Text = "Delete Account";
            this.mtDeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mtDeleteBtn.UseVisualStyleBackColor = false;
            this.mtDeleteBtn.Click += new System.EventHandler(this.mtDeleteBtn_Click);
            // 
            // mtCancelBtn
            // 
            this.mtCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.mtCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mtCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtCancelBtn.ForeColor = System.Drawing.Color.White;
            this.mtCancelBtn.Location = new System.Drawing.Point(148, 3);
            this.mtCancelBtn.Name = "mtCancelBtn";
            this.mtCancelBtn.Size = new System.Drawing.Size(139, 43);
            this.mtCancelBtn.TabIndex = 129;
            this.mtCancelBtn.Text = "Cancel";
            this.mtCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mtCancelBtn.UseVisualStyleBackColor = false;
            this.mtCancelBtn.Click += new System.EventHandler(this.mtCancelBtn_Click);
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BackColor = System.Drawing.Color.Transparent;
            this.label65.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(384, 256);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(175, 51);
            this.label65.TabIndex = 130;
            this.label65.Text = "User Type:";
            this.label65.UseCompatibleTextRendering = true;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label64.Location = new System.Drawing.Point(17, 584);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(1096, 35);
            this.label64.TabIndex = 127;
            this.label64.Text = "Attention if you delete your account all your information will be deleted and can" +
    "t be restored";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.Color.Transparent;
            this.label59.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(384, 343);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(253, 51);
            this.label59.TabIndex = 125;
            this.label59.Text = "Phone Number:";
            this.label59.UseCompatibleTextRendering = true;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.BackColor = System.Drawing.Color.Transparent;
            this.label60.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(23, 343);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(106, 51);
            this.label60.TabIndex = 124;
            this.label60.Text = "Email:";
            this.label60.UseCompatibleTextRendering = true;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.BackColor = System.Drawing.Color.Transparent;
            this.label63.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(23, 124);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(134, 51);
            this.label63.TabIndex = 117;
            this.label63.Text = "User ID:";
            this.label63.UseCompatibleTextRendering = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(9, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(493, 100);
            this.label18.TabIndex = 115;
            this.label18.Text = "Manage User";
            // 
            // AddAirCityConTab
            // 
            this.AddAirCityConTab.BackColor = System.Drawing.Color.Gainsboro;
            this.AddAirCityConTab.Controls.Add(this.groupBox3);
            this.AddAirCityConTab.Controls.Add(this.groupBox2);
            this.AddAirCityConTab.Controls.Add(this.groupBox1);
            this.AddAirCityConTab.Controls.Add(this.addBackBtn);
            this.AddAirCityConTab.Controls.Add(this.label52);
            this.AddAirCityConTab.Location = new System.Drawing.Point(85, 4);
            this.AddAirCityConTab.Name = "AddAirCityConTab";
            this.AddAirCityConTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddAirCityConTab.Size = new System.Drawing.Size(693, 720);
            this.AddAirCityConTab.TabIndex = 8;
            this.AddAirCityConTab.Text = "Add ar/city/cont";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label54);
            this.groupBox3.Controls.Add(this.addAddCountryBtn);
            this.groupBox3.Controls.Add(this.addContErrorLbl);
            this.groupBox3.Controls.Add(this.addContNameTxt);
            this.groupBox3.Location = new System.Drawing.Point(20, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(707, 150);
            this.groupBox3.TabIndex = 144;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Country";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.Transparent;
            this.label54.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(20, 24);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(243, 51);
            this.label54.TabIndex = 111;
            this.label54.Text = "Country Name:";
            this.label54.UseCompatibleTextRendering = true;
            // 
            // addAddCountryBtn
            // 
            this.addAddCountryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.addAddCountryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addAddCountryBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addAddCountryBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAddCountryBtn.ForeColor = System.Drawing.Color.White;
            this.addAddCountryBtn.Location = new System.Drawing.Point(20, 96);
            this.addAddCountryBtn.Name = "addAddCountryBtn";
            this.addAddCountryBtn.Size = new System.Drawing.Size(139, 43);
            this.addAddCountryBtn.TabIndex = 113;
            this.addAddCountryBtn.Text = "Add Country";
            this.addAddCountryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addAddCountryBtn.UseVisualStyleBackColor = false;
            this.addAddCountryBtn.Click += new System.EventHandler(this.addAddCountryBtn_Click);
            // 
            // addContErrorLbl
            // 
            this.addContErrorLbl.AutoSize = true;
            this.addContErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.addContErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addContErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.addContErrorLbl.Location = new System.Drawing.Point(278, 64);
            this.addContErrorLbl.Name = "addContErrorLbl";
            this.addContErrorLbl.Size = new System.Drawing.Size(429, 44);
            this.addContErrorLbl.TabIndex = 132;
            this.addContErrorLbl.Text = "Error: Country already Exist";
            this.addContErrorLbl.Visible = false;
            // 
            // addContNameTxt
            // 
            this.addContNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addContNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addContNameTxt.Location = new System.Drawing.Point(20, 57);
            this.addContNameTxt.Name = "addContNameTxt";
            this.addContNameTxt.Size = new System.Drawing.Size(246, 51);
            this.addContNameTxt.TabIndex = 109;
            this.addContNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyLetters_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label56);
            this.groupBox2.Controls.Add(this.addAddCityBtn);
            this.groupBox2.Controls.Add(this.addCitytNameTxt);
            this.groupBox2.Controls.Add(this.addCityErrorLbl);
            this.groupBox2.Controls.Add(this.label55);
            this.groupBox2.Controls.Add(this.addConDrop);
            this.groupBox2.Location = new System.Drawing.Point(20, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 155);
            this.groupBox2.TabIndex = 143;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add City";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.BackColor = System.Drawing.Color.Transparent;
            this.label56.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(20, 29);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(180, 51);
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
            this.addAddCityBtn.Location = new System.Drawing.Point(20, 101);
            this.addAddCityBtn.Name = "addAddCityBtn";
            this.addAddCityBtn.Size = new System.Drawing.Size(139, 43);
            this.addAddCityBtn.TabIndex = 119;
            this.addAddCityBtn.Text = "Add City";
            this.addAddCityBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addAddCityBtn.UseVisualStyleBackColor = false;
            this.addAddCityBtn.Click += new System.EventHandler(this.addAddCityBtn_Click);
            // 
            // addCitytNameTxt
            // 
            this.addCitytNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addCitytNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCitytNameTxt.Location = new System.Drawing.Point(20, 62);
            this.addCitytNameTxt.Name = "addCitytNameTxt";
            this.addCitytNameTxt.Size = new System.Drawing.Size(246, 51);
            this.addCitytNameTxt.TabIndex = 115;
            this.addCitytNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyLetters_KeyPress);
            // 
            // addCityErrorLbl
            // 
            this.addCityErrorLbl.AutoSize = true;
            this.addCityErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.addCityErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCityErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.addCityErrorLbl.Location = new System.Drawing.Point(302, 114);
            this.addCityErrorLbl.Name = "addCityErrorLbl";
            this.addCityErrorLbl.Size = new System.Drawing.Size(368, 44);
            this.addCityErrorLbl.TabIndex = 133;
            this.addCityErrorLbl.Text = "Error: City already Exist";
            this.addCityErrorLbl.Visible = false;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.BackColor = System.Drawing.Color.Transparent;
            this.label55.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(293, 29);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(243, 51);
            this.label55.TabIndex = 127;
            this.label55.Text = "Country Name:";
            this.label55.UseCompatibleTextRendering = true;
            // 
            // addConDrop
            // 
            this.addConDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addConDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.addConDrop.FormattingEnabled = true;
            this.addConDrop.Location = new System.Drawing.Point(293, 61);
            this.addConDrop.Name = "addConDrop";
            this.addConDrop.Size = new System.Drawing.Size(246, 52);
            this.addConDrop.TabIndex = 130;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label58);
            this.groupBox1.Controls.Add(this.addAirportConDrop);
            this.groupBox1.Controls.Add(this.addAirportNameTxt);
            this.groupBox1.Controls.Add(this.label68);
            this.groupBox1.Controls.Add(this.addAddAirportBtn);
            this.groupBox1.Controls.Add(this.addAirportLongitudeTxt);
            this.groupBox1.Controls.Add(this.label57);
            this.groupBox1.Controls.Add(this.label67);
            this.groupBox1.Controls.Add(this.addAirportCityDrop);
            this.groupBox1.Controls.Add(this.addAirportLatitudeTxt);
            this.groupBox1.Controls.Add(this.addAirportErrorLbl);
            this.groupBox1.Controls.Add(this.label53);
            this.groupBox1.Location = new System.Drawing.Point(20, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 237);
            this.groupBox1.TabIndex = 142;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Airport";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.BackColor = System.Drawing.Color.Transparent;
            this.label58.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(20, 24);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(231, 51);
            this.label58.TabIndex = 123;
            this.label58.Text = "Airport Name:";
            this.label58.UseCompatibleTextRendering = true;
            // 
            // addAirportConDrop
            // 
            this.addAirportConDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addAirportConDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.addAirportConDrop.FormattingEnabled = true;
            this.addAirportConDrop.Location = new System.Drawing.Point(293, 57);
            this.addAirportConDrop.Name = "addAirportConDrop";
            this.addAirportConDrop.Size = new System.Drawing.Size(246, 52);
            this.addAirportConDrop.TabIndex = 141;
            this.addAirportConDrop.SelectedIndexChanged += new System.EventHandler(this.addAirportConDrop_SelectedIndexChanged);
            // 
            // addAirportNameTxt
            // 
            this.addAirportNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addAirportNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAirportNameTxt.Location = new System.Drawing.Point(20, 57);
            this.addAirportNameTxt.Name = "addAirportNameTxt";
            this.addAirportNameTxt.Size = new System.Drawing.Size(246, 51);
            this.addAirportNameTxt.TabIndex = 121;
            this.addAirportNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyDotUnderscore_KeyPress);
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.BackColor = System.Drawing.Color.Transparent;
            this.label68.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(293, 25);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(243, 51);
            this.label68.TabIndex = 140;
            this.label68.Text = "Country Name:";
            this.label68.UseCompatibleTextRendering = true;
            // 
            // addAddAirportBtn
            // 
            this.addAddAirportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.addAddAirportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addAddAirportBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addAddAirportBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAddAirportBtn.ForeColor = System.Drawing.Color.White;
            this.addAddAirportBtn.Location = new System.Drawing.Point(20, 187);
            this.addAddAirportBtn.Name = "addAddAirportBtn";
            this.addAddAirportBtn.Size = new System.Drawing.Size(139, 43);
            this.addAddAirportBtn.TabIndex = 125;
            this.addAddAirportBtn.Text = "Add Airport";
            this.addAddAirportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addAddAirportBtn.UseVisualStyleBackColor = false;
            this.addAddAirportBtn.Click += new System.EventHandler(this.addAddAirportBtn_Click);
            // 
            // addAirportLongitudeTxt
            // 
            this.addAirportLongitudeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addAirportLongitudeTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAirportLongitudeTxt.Location = new System.Drawing.Point(494, 146);
            this.addAirportLongitudeTxt.Name = "addAirportLongitudeTxt";
            this.addAirportLongitudeTxt.Size = new System.Drawing.Size(175, 51);
            this.addAirportLongitudeTxt.TabIndex = 138;
            this.addAirportLongitudeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLatitudeLongitude_KeyPress);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.BackColor = System.Drawing.Color.Transparent;
            this.label57.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(20, 113);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(180, 51);
            this.label57.TabIndex = 129;
            this.label57.Text = "City Name:";
            this.label57.UseCompatibleTextRendering = true;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.BackColor = System.Drawing.Color.Transparent;
            this.label67.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(494, 113);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(175, 51);
            this.label67.TabIndex = 139;
            this.label67.Text = "Longitude:";
            this.label67.UseCompatibleTextRendering = true;
            // 
            // addAirportCityDrop
            // 
            this.addAirportCityDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addAirportCityDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.addAirportCityDrop.FormattingEnabled = true;
            this.addAirportCityDrop.Location = new System.Drawing.Point(20, 145);
            this.addAirportCityDrop.Name = "addAirportCityDrop";
            this.addAirportCityDrop.Size = new System.Drawing.Size(246, 52);
            this.addAirportCityDrop.TabIndex = 131;
            // 
            // addAirportLatitudeTxt
            // 
            this.addAirportLatitudeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addAirportLatitudeTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAirportLatitudeTxt.Location = new System.Drawing.Point(293, 146);
            this.addAirportLatitudeTxt.Name = "addAirportLatitudeTxt";
            this.addAirportLatitudeTxt.Size = new System.Drawing.Size(175, 51);
            this.addAirportLatitudeTxt.TabIndex = 136;
            this.addAirportLatitudeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLatitudeLongitude_KeyPress);
            // 
            // addAirportErrorLbl
            // 
            this.addAirportErrorLbl.AutoSize = true;
            this.addAirportErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.addAirportErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAirportErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.addAirportErrorLbl.Location = new System.Drawing.Point(178, 196);
            this.addAirportErrorLbl.Name = "addAirportErrorLbl";
            this.addAirportErrorLbl.Size = new System.Drawing.Size(418, 44);
            this.addAirportErrorLbl.TabIndex = 134;
            this.addAirportErrorLbl.Text = "Error: Airport already Exist";
            this.addAirportErrorLbl.Visible = false;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(293, 113);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(149, 51);
            this.label53.TabIndex = 137;
            this.label53.Text = "Latitude:";
            this.label53.UseCompatibleTextRendering = true;
            // 
            // addBackBtn
            // 
            this.addBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.addBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addBackBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addBackBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBackBtn.ForeColor = System.Drawing.Color.White;
            this.addBackBtn.Location = new System.Drawing.Point(29, 665);
            this.addBackBtn.Name = "addBackBtn";
            this.addBackBtn.Size = new System.Drawing.Size(139, 43);
            this.addBackBtn.TabIndex = 135;
            this.addBackBtn.Text = "Back To Locations";
            this.addBackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addBackBtn.UseVisualStyleBackColor = false;
            this.addBackBtn.Click += new System.EventHandler(this.addBackBtn_Click);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(19, 25);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(946, 100);
            this.label52.TabIndex = 108;
            this.label52.Text = "Add(Airport/City/Country)";
            // 
            // createUserTab
            // 
            this.createUserTab.BackColor = System.Drawing.Color.Gainsboro;
            this.createUserTab.Controls.Add(this.cuPhoneNumberErrorLbl);
            this.createUserTab.Controls.Add(this.cuEmailErrorLbl);
            this.createUserTab.Controls.Add(this.cuFCoumpanyNameErrorLbl);
            this.createUserTab.Controls.Add(this.cuPasswordErrorLbl);
            this.createUserTab.Controls.Add(this.flowLayoutPanel2);
            this.createUserTab.Controls.Add(this.cuUserNameErrorLbl);
            this.createUserTab.Controls.Add(this.cuUserTypeDrop);
            this.createUserTab.Controls.Add(this.label51);
            this.createUserTab.Controls.Add(this.label50);
            this.createUserTab.Controls.Add(this.cuCancelBtn);
            this.createUserTab.Controls.Add(this.cuCreateUserBtn);
            this.createUserTab.Controls.Add(this.label44);
            this.createUserTab.Controls.Add(this.label45);
            this.createUserTab.Controls.Add(this.label48);
            this.createUserTab.Controls.Add(this.label49);
            this.createUserTab.Controls.Add(this.cuPhoneTxt);
            this.createUserTab.Controls.Add(this.cuEmailTxt);
            this.createUserTab.Controls.Add(this.cuPasswordTxt);
            this.createUserTab.Controls.Add(this.cuUsernameTxt);
            this.createUserTab.Location = new System.Drawing.Point(85, 4);
            this.createUserTab.Name = "createUserTab";
            this.createUserTab.Padding = new System.Windows.Forms.Padding(3);
            this.createUserTab.Size = new System.Drawing.Size(693, 720);
            this.createUserTab.TabIndex = 7;
            this.createUserTab.Text = "Create User";
            // 
            // cuPhoneNumberErrorLbl
            // 
            this.cuPhoneNumberErrorLbl.AutoSize = true;
            this.cuPhoneNumberErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.cuPhoneNumberErrorLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuPhoneNumberErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.cuPhoneNumberErrorLbl.Location = new System.Drawing.Point(327, 519);
            this.cuPhoneNumberErrorLbl.Name = "cuPhoneNumberErrorLbl";
            this.cuPhoneNumberErrorLbl.Size = new System.Drawing.Size(173, 28);
            this.cuPhoneNumberErrorLbl.TabIndex = 117;
            this.cuPhoneNumberErrorLbl.Text = "Error: Please fix..";
            this.cuPhoneNumberErrorLbl.Visible = false;
            // 
            // cuEmailErrorLbl
            // 
            this.cuEmailErrorLbl.AutoSize = true;
            this.cuEmailErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.cuEmailErrorLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuEmailErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.cuEmailErrorLbl.Location = new System.Drawing.Point(24, 517);
            this.cuEmailErrorLbl.Name = "cuEmailErrorLbl";
            this.cuEmailErrorLbl.Size = new System.Drawing.Size(173, 28);
            this.cuEmailErrorLbl.TabIndex = 116;
            this.cuEmailErrorLbl.Text = "Error: Please fix..";
            this.cuEmailErrorLbl.Visible = false;
            // 
            // cuFCoumpanyNameErrorLbl
            // 
            this.cuFCoumpanyNameErrorLbl.AutoSize = true;
            this.cuFCoumpanyNameErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.cuFCoumpanyNameErrorLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuFCoumpanyNameErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.cuFCoumpanyNameErrorLbl.Location = new System.Drawing.Point(25, 409);
            this.cuFCoumpanyNameErrorLbl.Name = "cuFCoumpanyNameErrorLbl";
            this.cuFCoumpanyNameErrorLbl.Size = new System.Drawing.Size(173, 28);
            this.cuFCoumpanyNameErrorLbl.TabIndex = 114;
            this.cuFCoumpanyNameErrorLbl.Text = "Error: Please fix..";
            this.cuFCoumpanyNameErrorLbl.Visible = false;
            // 
            // cuPasswordErrorLbl
            // 
            this.cuPasswordErrorLbl.AutoSize = true;
            this.cuPasswordErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.cuPasswordErrorLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuPasswordErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.cuPasswordErrorLbl.Location = new System.Drawing.Point(327, 299);
            this.cuPasswordErrorLbl.Name = "cuPasswordErrorLbl";
            this.cuPasswordErrorLbl.Size = new System.Drawing.Size(173, 28);
            this.cuPasswordErrorLbl.TabIndex = 113;
            this.cuPasswordErrorLbl.Text = "Error: Please fix..";
            this.cuPasswordErrorLbl.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.cuFNamePanel);
            this.flowLayoutPanel2.Controls.Add(this.cuLNamePanel);
            this.flowLayoutPanel2.Controls.Add(this.cuCompanyNamePanel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(22, 337);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(701, 110);
            this.flowLayoutPanel2.TabIndex = 112;
            // 
            // cuFNamePanel
            // 
            this.cuFNamePanel.Controls.Add(this.label47);
            this.cuFNamePanel.Controls.Add(this.cuFnameTxt);
            this.cuFNamePanel.Location = new System.Drawing.Point(3, 3);
            this.cuFNamePanel.Name = "cuFNamePanel";
            this.cuFNamePanel.Size = new System.Drawing.Size(290, 100);
            this.cuFNamePanel.TabIndex = 113;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(0, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(188, 51);
            this.label47.TabIndex = 45;
            this.label47.Text = "First Name:";
            this.label47.UseCompatibleTextRendering = true;
            // 
            // cuFnameTxt
            // 
            this.cuFnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuFnameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuFnameTxt.Location = new System.Drawing.Point(0, 35);
            this.cuFnameTxt.Name = "cuFnameTxt";
            this.cuFnameTxt.Size = new System.Drawing.Size(281, 51);
            this.cuFnameTxt.TabIndex = 39;
            this.cuFnameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyLetters_KeyPress);
            // 
            // cuLNamePanel
            // 
            this.cuLNamePanel.Controls.Add(this.label46);
            this.cuLNamePanel.Controls.Add(this.cuLnameTxt);
            this.cuLNamePanel.Controls.Add(this.cuLNameErrorLbl);
            this.cuLNamePanel.Location = new System.Drawing.Point(299, 3);
            this.cuLNamePanel.Name = "cuLNamePanel";
            this.cuLNamePanel.Size = new System.Drawing.Size(297, 96);
            this.cuLNamePanel.TabIndex = 114;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(3, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(183, 51);
            this.label46.TabIndex = 46;
            this.label46.Text = "Last Name:";
            this.label46.UseCompatibleTextRendering = true;
            // 
            // cuLnameTxt
            // 
            this.cuLnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuLnameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuLnameTxt.Location = new System.Drawing.Point(7, 35);
            this.cuLnameTxt.Name = "cuLnameTxt";
            this.cuLnameTxt.Size = new System.Drawing.Size(271, 51);
            this.cuLnameTxt.TabIndex = 40;
            this.cuLnameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyLetters_KeyPress);
            // 
            // cuLNameErrorLbl
            // 
            this.cuLNameErrorLbl.AutoSize = true;
            this.cuLNameErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.cuLNameErrorLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuLNameErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.cuLNameErrorLbl.Location = new System.Drawing.Point(9, 68);
            this.cuLNameErrorLbl.Name = "cuLNameErrorLbl";
            this.cuLNameErrorLbl.Size = new System.Drawing.Size(173, 28);
            this.cuLNameErrorLbl.TabIndex = 115;
            this.cuLNameErrorLbl.Text = "Error: Please fix..";
            this.cuLNameErrorLbl.Visible = false;
            // 
            // cuCompanyNamePanel
            // 
            this.cuCompanyNamePanel.Controls.Add(this.cuCoumpanyNameTxt);
            this.cuCompanyNamePanel.Controls.Add(this.label70);
            this.cuCompanyNamePanel.Location = new System.Drawing.Point(3, 109);
            this.cuCompanyNamePanel.Name = "cuCompanyNamePanel";
            this.cuCompanyNamePanel.Size = new System.Drawing.Size(336, 100);
            this.cuCompanyNamePanel.TabIndex = 152;
            // 
            // cuCoumpanyNameTxt
            // 
            this.cuCoumpanyNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuCoumpanyNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuCoumpanyNameTxt.Location = new System.Drawing.Point(3, 36);
            this.cuCoumpanyNameTxt.Name = "cuCoumpanyNameTxt";
            this.cuCoumpanyNameTxt.Size = new System.Drawing.Size(246, 51);
            this.cuCoumpanyNameTxt.TabIndex = 153;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.BackColor = System.Drawing.Color.Transparent;
            this.label70.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(3, -1);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(265, 51);
            this.label70.TabIndex = 146;
            this.label70.Text = "Company Name:";
            this.label70.UseCompatibleTextRendering = true;
            // 
            // cuUserNameErrorLbl
            // 
            this.cuUserNameErrorLbl.AutoSize = true;
            this.cuUserNameErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.cuUserNameErrorLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuUserNameErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.cuUserNameErrorLbl.Location = new System.Drawing.Point(24, 299);
            this.cuUserNameErrorLbl.Name = "cuUserNameErrorLbl";
            this.cuUserNameErrorLbl.Size = new System.Drawing.Size(173, 28);
            this.cuUserNameErrorLbl.TabIndex = 111;
            this.cuUserNameErrorLbl.Text = "Error: Please fix..";
            this.cuUserNameErrorLbl.Visible = false;
            // 
            // cuUserTypeDrop
            // 
            this.cuUserTypeDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cuUserTypeDrop.FormattingEnabled = true;
            this.cuUserTypeDrop.Location = new System.Drawing.Point(26, 166);
            this.cuUserTypeDrop.Name = "cuUserTypeDrop";
            this.cuUserTypeDrop.Size = new System.Drawing.Size(246, 52);
            this.cuUserTypeDrop.TabIndex = 110;
            this.cuUserTypeDrop.SelectedIndexChanged += new System.EventHandler(this.cuUserTypeDrop_SelectedIndexChanged);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label51.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(26, 130);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(175, 51);
            this.label51.TabIndex = 109;
            this.label51.Text = "User Type:";
            this.label51.UseCompatibleTextRendering = true;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(12, 25);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(437, 100);
            this.label50.TabIndex = 107;
            this.label50.Text = "Create User";
            // 
            // cuCancelBtn
            // 
            this.cuCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.cuCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cuCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cuCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuCancelBtn.ForeColor = System.Drawing.Color.White;
            this.cuCancelBtn.Location = new System.Drawing.Point(171, 574);
            this.cuCancelBtn.Name = "cuCancelBtn";
            this.cuCancelBtn.Size = new System.Drawing.Size(139, 43);
            this.cuCancelBtn.TabIndex = 50;
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
            this.cuCreateUserBtn.Location = new System.Drawing.Point(26, 574);
            this.cuCreateUserBtn.Name = "cuCreateUserBtn";
            this.cuCreateUserBtn.Size = new System.Drawing.Size(139, 43);
            this.cuCreateUserBtn.TabIndex = 49;
            this.cuCreateUserBtn.Text = "Create User";
            this.cuCreateUserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cuCreateUserBtn.UseVisualStyleBackColor = false;
            this.cuCreateUserBtn.Click += new System.EventHandler(this.cuCreateUserBtn_Click);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(332, 450);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(253, 51);
            this.label44.TabIndex = 48;
            this.label44.Text = "Phone Number:";
            this.label44.UseCompatibleTextRendering = true;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(27, 450);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(106, 51);
            this.label45.TabIndex = 47;
            this.label45.Text = "Email:";
            this.label45.UseCompatibleTextRendering = true;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.Transparent;
            this.label48.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(328, 228);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(169, 51);
            this.label48.TabIndex = 44;
            this.label48.Text = "Password:";
            this.label48.UseCompatibleTextRendering = true;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(27, 228);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(179, 51);
            this.label49.TabIndex = 43;
            this.label49.Text = "Username:";
            this.label49.UseCompatibleTextRendering = true;
            // 
            // cuPhoneTxt
            // 
            this.cuPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuPhoneTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuPhoneTxt.Location = new System.Drawing.Point(332, 482);
            this.cuPhoneTxt.Name = "cuPhoneTxt";
            this.cuPhoneTxt.Size = new System.Drawing.Size(300, 51);
            this.cuPhoneTxt.TabIndex = 42;
            this.cuPhoneTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTextBox_KeyPress);
            // 
            // cuEmailTxt
            // 
            this.cuEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuEmailTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuEmailTxt.Location = new System.Drawing.Point(27, 483);
            this.cuEmailTxt.Name = "cuEmailTxt";
            this.cuEmailTxt.Size = new System.Drawing.Size(283, 51);
            this.cuEmailTxt.TabIndex = 41;
            this.cuEmailTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBox_KeyPress);
            // 
            // cuPasswordTxt
            // 
            this.cuPasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuPasswordTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuPasswordTxt.Location = new System.Drawing.Point(328, 263);
            this.cuPasswordTxt.Name = "cuPasswordTxt";
            this.cuPasswordTxt.PasswordChar = '*';
            this.cuPasswordTxt.Size = new System.Drawing.Size(275, 51);
            this.cuPasswordTxt.TabIndex = 38;
            // 
            // cuUsernameTxt
            // 
            this.cuUsernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuUsernameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuUsernameTxt.Location = new System.Drawing.Point(27, 263);
            this.cuUsernameTxt.Name = "cuUsernameTxt";
            this.cuUsernameTxt.Size = new System.Drawing.Size(283, 51);
            this.cuUsernameTxt.TabIndex = 37;
            // 
            // editFlightTab
            // 
            this.editFlightTab.BackColor = System.Drawing.Color.Gainsboro;
            this.editFlightTab.Controls.Add(this.flowLayoutPanel4);
            this.editFlightTab.Controls.Add(this.efPriceErrorLbl);
            this.editFlightTab.Controls.Add(this.efStatusDrop);
            this.editFlightTab.Controls.Add(this.label71);
            this.editFlightTab.Controls.Add(this.efArrTimePick);
            this.editFlightTab.Controls.Add(this.efDepTimePick);
            this.editFlightTab.Controls.Add(this.efArrTxt);
            this.editFlightTab.Controls.Add(this.efDepTxt);
            this.editFlightTab.Controls.Add(this.efPriceTxt);
            this.editFlightTab.Controls.Add(this.efFlightNumTxt);
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
            this.editFlightTab.Location = new System.Drawing.Point(85, 4);
            this.editFlightTab.Name = "editFlightTab";
            this.editFlightTab.Padding = new System.Windows.Forms.Padding(3);
            this.editFlightTab.Size = new System.Drawing.Size(693, 720);
            this.editFlightTab.TabIndex = 6;
            this.editFlightTab.Text = "Edit Flight";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.efDeleteBtn);
            this.flowLayoutPanel4.Controls.Add(this.efEditBtn);
            this.flowLayoutPanel4.Controls.Add(this.efCancelBtn);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(23, 636);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(494, 56);
            this.flowLayoutPanel4.TabIndex = 134;
            // 
            // efDeleteBtn
            // 
            this.efDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.efDeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.efDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.efDeleteBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.efDeleteBtn.Location = new System.Drawing.Point(3, 3);
            this.efDeleteBtn.Name = "efDeleteBtn";
            this.efDeleteBtn.Size = new System.Drawing.Size(139, 43);
            this.efDeleteBtn.TabIndex = 129;
            this.efDeleteBtn.Text = "Delete Flight";
            this.efDeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.efDeleteBtn.UseVisualStyleBackColor = false;
            this.efDeleteBtn.Click += new System.EventHandler(this.efDeleteBtn_Click);
            // 
            // efEditBtn
            // 
            this.efEditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.efEditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.efEditBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.efEditBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efEditBtn.ForeColor = System.Drawing.Color.White;
            this.efEditBtn.Location = new System.Drawing.Point(148, 3);
            this.efEditBtn.Name = "efEditBtn";
            this.efEditBtn.Size = new System.Drawing.Size(139, 43);
            this.efEditBtn.TabIndex = 123;
            this.efEditBtn.Text = "Save Edits";
            this.efEditBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.efEditBtn.UseVisualStyleBackColor = false;
            this.efEditBtn.Click += new System.EventHandler(this.efEditBtn_Click);
            // 
            // efCancelBtn
            // 
            this.efCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.efCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.efCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.efCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efCancelBtn.ForeColor = System.Drawing.Color.White;
            this.efCancelBtn.Location = new System.Drawing.Point(293, 3);
            this.efCancelBtn.Name = "efCancelBtn";
            this.efCancelBtn.Size = new System.Drawing.Size(139, 43);
            this.efCancelBtn.TabIndex = 124;
            this.efCancelBtn.Text = "Cancel";
            this.efCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.efCancelBtn.UseVisualStyleBackColor = false;
            this.efCancelBtn.Click += new System.EventHandler(this.efCancelBtn_Click);
            // 
            // efPriceErrorLbl
            // 
            this.efPriceErrorLbl.AutoSize = true;
            this.efPriceErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.efPriceErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efPriceErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.efPriceErrorLbl.Location = new System.Drawing.Point(379, 505);
            this.efPriceErrorLbl.Name = "efPriceErrorLbl";
            this.efPriceErrorLbl.Size = new System.Drawing.Size(446, 44);
            this.efPriceErrorLbl.TabIndex = 133;
            this.efPriceErrorLbl.Text = "Error: Input Must be number";
            this.efPriceErrorLbl.Visible = false;
            // 
            // efStatusDrop
            // 
            this.efStatusDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.efStatusDrop.FormattingEnabled = true;
            this.efStatusDrop.Location = new System.Drawing.Point(387, 572);
            this.efStatusDrop.Name = "efStatusDrop";
            this.efStatusDrop.Size = new System.Drawing.Size(338, 52);
            this.efStatusDrop.TabIndex = 132;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.BackColor = System.Drawing.Color.Transparent;
            this.label71.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(384, 537);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(118, 51);
            this.label71.TabIndex = 131;
            this.label71.Text = "Status:";
            this.label71.UseCompatibleTextRendering = true;
            // 
            // efArrTimePick
            // 
            this.efArrTimePick.Enabled = false;
            this.efArrTimePick.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.efArrTimePick.Location = new System.Drawing.Point(384, 261);
            this.efArrTimePick.Name = "efArrTimePick";
            this.efArrTimePick.Size = new System.Drawing.Size(338, 51);
            this.efArrTimePick.TabIndex = 128;
            // 
            // efDepTimePick
            // 
            this.efDepTimePick.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.efDepTimePick.Location = new System.Drawing.Point(23, 261);
            this.efDepTimePick.Name = "efDepTimePick";
            this.efDepTimePick.Size = new System.Drawing.Size(338, 51);
            this.efDepTimePick.TabIndex = 127;
            this.efDepTimePick.ValueChanged += new System.EventHandler(this.efDepTimePick_ValueChanged);
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
            this.efArrTxt.Size = new System.Drawing.Size(246, 44);
            this.efArrTxt.TabIndex = 126;
            this.efArrTxt.Text = "Bahrain International Airport";
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
            this.efDepTxt.Size = new System.Drawing.Size(246, 44);
            this.efDepTxt.TabIndex = 125;
            this.efDepTxt.Text = "Cairo International Airport";
            // 
            // efPriceTxt
            // 
            this.efPriceTxt.BackColor = System.Drawing.Color.White;
            this.efPriceTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.efPriceTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efPriceTxt.Location = new System.Drawing.Point(384, 466);
            this.efPriceTxt.Name = "efPriceTxt";
            this.efPriceTxt.Size = new System.Drawing.Size(338, 51);
            this.efPriceTxt.TabIndex = 120;
            this.efPriceTxt.Text = "300";
            this.efPriceTxt.TextChanged += new System.EventHandler(this.efPriceTxt_TextChanged);
            this.efPriceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumbers_KeyPress);
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
            this.efFlightNumTxt.Size = new System.Drawing.Size(246, 44);
            this.efFlightNumTxt.TabIndex = 107;
            this.efFlightNumTxt.Text = "123";
            // 
            // efDatePick
            // 
            this.efDatePick.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.efDatePick.Location = new System.Drawing.Point(23, 466);
            this.efDatePick.MinDate = new System.DateTime(2024, 12, 16, 0, 0, 0, 0);
            this.efDatePick.Name = "efDatePick";
            this.efDatePick.Size = new System.Drawing.Size(338, 51);
            this.efDatePick.TabIndex = 122;
            this.efDatePick.Value = new System.DateTime(2024, 12, 16, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 51);
            this.label4.TabIndex = 121;
            this.label4.Text = "Price in BD";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(23, 431);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(95, 51);
            this.label26.TabIndex = 119;
            this.label26.Text = "Date:";
            this.label26.UseCompatibleTextRendering = true;
            // 
            // efPlaneIdDrop
            // 
            this.efPlaneIdDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.efPlaneIdDrop.FormattingEnabled = true;
            this.efPlaneIdDrop.Location = new System.Drawing.Point(384, 164);
            this.efPlaneIdDrop.Name = "efPlaneIdDrop";
            this.efPlaneIdDrop.Size = new System.Drawing.Size(246, 52);
            this.efPlaneIdDrop.TabIndex = 116;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(384, 338);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(326, 51);
            this.label27.TabIndex = 115;
            this.label27.Text = "Arrival Airport Time:";
            this.label27.UseCompatibleTextRendering = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(23, 338);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(396, 51);
            this.label28.TabIndex = 114;
            this.label28.Text = "Departure Airport Name:";
            this.label28.UseCompatibleTextRendering = true;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(384, 226);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(208, 51);
            this.label39.TabIndex = 112;
            this.label39.Text = "Arrival Time:";
            this.label39.UseCompatibleTextRendering = true;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(23, 226);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(263, 51);
            this.label40.TabIndex = 111;
            this.label40.Text = "Departure Time:";
            this.label40.UseCompatibleTextRendering = true;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(384, 129);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(149, 51);
            this.label41.TabIndex = 109;
            this.label41.Text = "Plane ID:";
            this.label41.UseCompatibleTextRendering = true;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(23, 127);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(241, 51);
            this.label42.TabIndex = 108;
            this.label42.Text = "Flight Number:";
            this.label42.UseCompatibleTextRendering = true;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(9, 26);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(380, 100);
            this.label43.TabIndex = 106;
            this.label43.Text = "Edit Flight";
            // 
            // createFlightTab
            // 
            this.createFlightTab.BackColor = System.Drawing.Color.Gainsboro;
            this.createFlightTab.Controls.Add(this.cfStatusDrop);
            this.createFlightTab.Controls.Add(this.label66);
            this.createFlightTab.Controls.Add(this.cfTimeErrorLbl);
            this.createFlightTab.Controls.Add(this.cfAirportsErrorLbl);
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
            this.createFlightTab.Location = new System.Drawing.Point(85, 4);
            this.createFlightTab.Name = "createFlightTab";
            this.createFlightTab.Padding = new System.Windows.Forms.Padding(3);
            this.createFlightTab.Size = new System.Drawing.Size(693, 720);
            this.createFlightTab.TabIndex = 5;
            this.createFlightTab.Text = "Create Flight";
            // 
            // cfStatusDrop
            // 
            this.cfStatusDrop.Enabled = false;
            this.cfStatusDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cfStatusDrop.FormattingEnabled = true;
            this.cfStatusDrop.Location = new System.Drawing.Point(382, 574);
            this.cfStatusDrop.Name = "cfStatusDrop";
            this.cfStatusDrop.Size = new System.Drawing.Size(338, 52);
            this.cfStatusDrop.TabIndex = 112;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.BackColor = System.Drawing.Color.Transparent;
            this.label66.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(379, 539);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(118, 51);
            this.label66.TabIndex = 111;
            this.label66.Text = "Status:";
            this.label66.UseCompatibleTextRendering = true;
            // 
            // cfTimeErrorLbl
            // 
            this.cfTimeErrorLbl.AutoSize = true;
            this.cfTimeErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.cfTimeErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfTimeErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.cfTimeErrorLbl.Location = new System.Drawing.Point(22, 304);
            this.cfTimeErrorLbl.Name = "cfTimeErrorLbl";
            this.cfTimeErrorLbl.Size = new System.Drawing.Size(833, 44);
            this.cfTimeErrorLbl.TabIndex = 110;
            this.cfTimeErrorLbl.Text = "Error: Departure and Arrival Times cannot be the same";
            this.cfTimeErrorLbl.Visible = false;
            // 
            // cfAirportsErrorLbl
            // 
            this.cfAirportsErrorLbl.AutoSize = true;
            this.cfAirportsErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.cfAirportsErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfAirportsErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.cfAirportsErrorLbl.Location = new System.Drawing.Point(22, 418);
            this.cfAirportsErrorLbl.Name = "cfAirportsErrorLbl";
            this.cfAirportsErrorLbl.Size = new System.Drawing.Size(866, 44);
            this.cfAirportsErrorLbl.TabIndex = 109;
            this.cfAirportsErrorLbl.Text = "Error: Departure and Arrival Airports cannot be the same";
            this.cfAirportsErrorLbl.Visible = false;
            // 
            // cfPriceErrorLbl
            // 
            this.cfPriceErrorLbl.AutoSize = true;
            this.cfPriceErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.cfPriceErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfPriceErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.cfPriceErrorLbl.Location = new System.Drawing.Point(378, 504);
            this.cfPriceErrorLbl.Name = "cfPriceErrorLbl";
            this.cfPriceErrorLbl.Size = new System.Drawing.Size(446, 44);
            this.cfPriceErrorLbl.TabIndex = 108;
            this.cfPriceErrorLbl.Text = "Error: Input Must be number";
            this.cfPriceErrorLbl.Visible = false;
            // 
            // cfArrTimePick
            // 
            this.cfArrTimePick.Enabled = false;
            this.cfArrTimePick.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cfArrTimePick.Location = new System.Drawing.Point(379, 258);
            this.cfArrTimePick.Name = "cfArrTimePick";
            this.cfArrTimePick.Size = new System.Drawing.Size(337, 51);
            this.cfArrTimePick.TabIndex = 107;
            // 
            // cfDepTimePick
            // 
            this.cfDepTimePick.CustomFormat = "Time";
            this.cfDepTimePick.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cfDepTimePick.Location = new System.Drawing.Point(19, 258);
            this.cfDepTimePick.Name = "cfDepTimePick";
            this.cfDepTimePick.Size = new System.Drawing.Size(337, 51);
            this.cfDepTimePick.TabIndex = 106;
            this.cfDepTimePick.ValueChanged += new System.EventHandler(this.cfDepTimePick_ValueChanged);
            // 
            // cfCancelBtn
            // 
            this.cfCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.cfCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cfCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cfCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfCancelBtn.ForeColor = System.Drawing.Color.White;
            this.cfCancelBtn.Location = new System.Drawing.Point(163, 643);
            this.cfCancelBtn.Name = "cfCancelBtn";
            this.cfCancelBtn.Size = new System.Drawing.Size(139, 43);
            this.cfCancelBtn.TabIndex = 105;
            this.cfCancelBtn.Text = "Cancel";
            this.cfCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cfCancelBtn.UseVisualStyleBackColor = false;
            this.cfCancelBtn.Click += new System.EventHandler(this.cfCancelBtn_Click);
            // 
            // cfCreateBtn
            // 
            this.cfCreateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.cfCreateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cfCreateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cfCreateBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfCreateBtn.ForeColor = System.Drawing.Color.White;
            this.cfCreateBtn.Location = new System.Drawing.Point(22, 643);
            this.cfCreateBtn.Name = "cfCreateBtn";
            this.cfCreateBtn.Size = new System.Drawing.Size(139, 43);
            this.cfCreateBtn.TabIndex = 104;
            this.cfCreateBtn.Text = "Create Flight";
            this.cfCreateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cfCreateBtn.UseVisualStyleBackColor = false;
            this.cfCreateBtn.Click += new System.EventHandler(this.cfCreateBtn_Click);
            // 
            // cfDatePick
            // 
            this.cfDatePick.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cfDatePick.Location = new System.Drawing.Point(18, 465);
            this.cfDatePick.Name = "cfDatePick";
            this.cfDatePick.Size = new System.Drawing.Size(338, 51);
            this.cfDatePick.TabIndex = 103;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(379, 430);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(177, 51);
            this.label19.TabIndex = 102;
            this.label19.Text = "Price in BD";
            this.label19.UseCompatibleTextRendering = true;
            // 
            // cfPriceTxt
            // 
            this.cfPriceTxt.BackColor = System.Drawing.Color.White;
            this.cfPriceTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cfPriceTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfPriceTxt.Location = new System.Drawing.Point(379, 465);
            this.cfPriceTxt.Name = "cfPriceTxt";
            this.cfPriceTxt.Size = new System.Drawing.Size(337, 51);
            this.cfPriceTxt.TabIndex = 101;
            this.cfPriceTxt.Text = "300";
            this.cfPriceTxt.TextChanged += new System.EventHandler(this.cfPriceTxt_TextChanged);
            this.cfPriceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumbers_KeyPress);
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
            this.cfFlightNumTxt.Size = new System.Drawing.Size(246, 44);
            this.cfFlightNumTxt.TabIndex = 76;
            this.cfFlightNumTxt.Text = "123";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 51);
            this.label7.TabIndex = 99;
            this.label7.Text = "Date:";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // cfArrDrop
            // 
            this.cfArrDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cfArrDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cfArrDrop.FormattingEnabled = true;
            this.cfArrDrop.Location = new System.Drawing.Point(379, 364);
            this.cfArrDrop.Name = "cfArrDrop";
            this.cfArrDrop.Size = new System.Drawing.Size(337, 52);
            this.cfArrDrop.TabIndex = 98;
            this.cfArrDrop.SelectedIndexChanged += new System.EventHandler(this.cfArrDrop_SelectedIndexChanged);
            // 
            // cfDepDrop
            // 
            this.cfDepDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cfDepDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cfDepDrop.FormattingEnabled = true;
            this.cfDepDrop.Location = new System.Drawing.Point(18, 364);
            this.cfDepDrop.Name = "cfDepDrop";
            this.cfDepDrop.Size = new System.Drawing.Size(338, 52);
            this.cfDepDrop.TabIndex = 97;
            this.cfDepDrop.SelectedIndexChanged += new System.EventHandler(this.cfDepDrop_SelectedIndexChanged);
            // 
            // cfPlaneIdDrop
            // 
            this.cfPlaneIdDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cfPlaneIdDrop.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cfPlaneIdDrop.FormattingEnabled = true;
            this.cfPlaneIdDrop.Location = new System.Drawing.Point(383, 159);
            this.cfPlaneIdDrop.Name = "cfPlaneIdDrop";
            this.cfPlaneIdDrop.Size = new System.Drawing.Size(246, 52);
            this.cfPlaneIdDrop.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 51);
            this.label5.TabIndex = 90;
            this.label5.Text = "Arrival Airport Name:";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(396, 51);
            this.label6.TabIndex = 89;
            this.label6.Text = "Departure Airport Name:";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(379, 223);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(208, 51);
            this.label20.TabIndex = 82;
            this.label20.Text = "Arrival Time:";
            this.label20.UseCompatibleTextRendering = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(18, 223);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(263, 51);
            this.label21.TabIndex = 81;
            this.label21.Text = "Departure Time:";
            this.label21.UseCompatibleTextRendering = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(383, 124);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(149, 51);
            this.label23.TabIndex = 78;
            this.label23.Text = "Plane ID:";
            this.label23.UseCompatibleTextRendering = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(22, 122);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(241, 51);
            this.label24.TabIndex = 77;
            this.label24.Text = "Flight Number:";
            this.label24.UseCompatibleTextRendering = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(8, 21);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(468, 100);
            this.label25.TabIndex = 75;
            this.label25.Text = "Create Flight";
            // 
            // bookingDetailsTab
            // 
            this.bookingDetailsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.bookingDetailsTab.Controls.Add(this.bdUsrIDLbl);
            this.bookingDetailsTab.Controls.Add(this.bdIDTxt);
            this.bookingDetailsTab.Controls.Add(this.bdArrTxt);
            this.bookingDetailsTab.Controls.Add(this.bdDepTxt);
            this.bookingDetailsTab.Controls.Add(this.bdToTxt);
            this.bookingDetailsTab.Controls.Add(this.bdFromTxt);
            this.bookingDetailsTab.Controls.Add(this.bdArrTimeTxt);
            this.bookingDetailsTab.Controls.Add(this.bdDepTimeTxt);
            this.bookingDetailsTab.Controls.Add(this.bdDateTxt);
            this.bookingDetailsTab.Controls.Add(this.bdFlightNumTxt);
            this.bookingDetailsTab.Controls.Add(this.bdUsrTypeLbl);
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
            this.bookingDetailsTab.Location = new System.Drawing.Point(85, 4);
            this.bookingDetailsTab.Name = "bookingDetailsTab";
            this.bookingDetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.bookingDetailsTab.Size = new System.Drawing.Size(693, 720);
            this.bookingDetailsTab.TabIndex = 4;
            this.bookingDetailsTab.Text = "Booking Details";
            // 
            // bdUsrIDLbl
            // 
            this.bdUsrIDLbl.BackColor = System.Drawing.Color.Gainsboro;
            this.bdUsrIDLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdUsrIDLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdUsrIDLbl.Location = new System.Drawing.Point(496, 99);
            this.bdUsrIDLbl.Name = "bdUsrIDLbl";
            this.bdUsrIDLbl.ReadOnly = true;
            this.bdUsrIDLbl.Size = new System.Drawing.Size(122, 44);
            this.bdUsrIDLbl.TabIndex = 76;
            this.bdUsrIDLbl.Text = "123";
            // 
            // bdIDTxt
            // 
            this.bdIDTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bdIDTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdIDTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdIDTxt.Location = new System.Drawing.Point(137, 105);
            this.bdIDTxt.Name = "bdIDTxt";
            this.bdIDTxt.ReadOnly = true;
            this.bdIDTxt.Size = new System.Drawing.Size(246, 44);
            this.bdIDTxt.TabIndex = 74;
            this.bdIDTxt.Text = "123";
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
            this.bdArrTxt.Size = new System.Drawing.Size(246, 44);
            this.bdArrTxt.TabIndex = 70;
            this.bdArrTxt.Text = "Bahrain International Airport";
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
            this.bdDepTxt.Size = new System.Drawing.Size(246, 44);
            this.bdDepTxt.TabIndex = 67;
            this.bdDepTxt.Text = "Cairo International Airport";
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
            this.bdToTxt.Size = new System.Drawing.Size(246, 44);
            this.bdToTxt.TabIndex = 66;
            this.bdToTxt.Text = "Muharraq (Bahrain)";
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
            this.bdFromTxt.Size = new System.Drawing.Size(246, 44);
            this.bdFromTxt.TabIndex = 63;
            this.bdFromTxt.Text = "Cairo (Egypt)";
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
            this.bdArrTimeTxt.Size = new System.Drawing.Size(246, 44);
            this.bdArrTimeTxt.TabIndex = 62;
            this.bdArrTimeTxt.Text = "11:00 AM";
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
            this.bdDepTimeTxt.Size = new System.Drawing.Size(246, 44);
            this.bdDepTimeTxt.TabIndex = 59;
            this.bdDepTimeTxt.Text = "8:00 AM";
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
            this.bdDateTxt.Size = new System.Drawing.Size(246, 44);
            this.bdDateTxt.TabIndex = 58;
            this.bdDateTxt.Text = "2024/12/30";
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
            this.bdFlightNumTxt.Size = new System.Drawing.Size(246, 44);
            this.bdFlightNumTxt.TabIndex = 55;
            this.bdFlightNumTxt.Text = "123";
            // 
            // bdUsrTypeLbl
            // 
            this.bdUsrTypeLbl.AutoSize = true;
            this.bdUsrTypeLbl.BackColor = System.Drawing.Color.Transparent;
            this.bdUsrTypeLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdUsrTypeLbl.Location = new System.Drawing.Point(389, 99);
            this.bdUsrTypeLbl.Name = "bdUsrTypeLbl";
            this.bdUsrTypeLbl.Size = new System.Drawing.Size(183, 51);
            this.bdUsrTypeLbl.TabIndex = 75;
            this.bdUsrTypeLbl.Text = "Booking ID:";
            this.bdUsrTypeLbl.UseCompatibleTextRendering = true;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(30, 105);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(183, 51);
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
            this.bdBackBtn.Location = new System.Drawing.Point(210, 528);
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
            this.bdCancelBtn.Location = new System.Drawing.Point(30, 528);
            this.bdCancelBtn.Name = "bdCancelBtn";
            this.bdCancelBtn.Size = new System.Drawing.Size(175, 43);
            this.bdCancelBtn.TabIndex = 71;
            this.bdCancelBtn.Text = "Cancel the booking";
            this.bdCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bdCancelBtn.UseVisualStyleBackColor = false;
            this.bdCancelBtn.Click += new System.EventHandler(this.bdCancelBtn_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(391, 402);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(326, 51);
            this.label29.TabIndex = 69;
            this.label29.Text = "Arrival Airport Time:";
            this.label29.UseCompatibleTextRendering = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(30, 402);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(396, 51);
            this.label30.TabIndex = 68;
            this.label30.Text = "Departure Airport Name:";
            this.label30.UseCompatibleTextRendering = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(391, 324);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(60, 51);
            this.label31.TabIndex = 65;
            this.label31.Text = "To:";
            this.label31.UseCompatibleTextRendering = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(30, 322);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(102, 51);
            this.label32.TabIndex = 64;
            this.label32.Text = "From:";
            this.label32.UseCompatibleTextRendering = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(391, 236);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(208, 51);
            this.label33.TabIndex = 61;
            this.label33.Text = "Arrival Time:";
            this.label33.UseCompatibleTextRendering = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(30, 236);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(263, 51);
            this.label34.TabIndex = 60;
            this.label34.Text = "Departure Time:";
            this.label34.UseCompatibleTextRendering = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(391, 161);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(95, 51);
            this.label35.TabIndex = 57;
            this.label35.Text = "Date:";
            this.label35.UseCompatibleTextRendering = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(30, 159);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(241, 51);
            this.label36.TabIndex = 56;
            this.label36.Text = "Flight Number:";
            this.label36.UseCompatibleTextRendering = true;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(14, 18);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(569, 100);
            this.label37.TabIndex = 54;
            this.label37.Text = "Booking Details";
            // 
            // travellerUsersTab
            // 
            this.travellerUsersTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerUsersTab.Controls.Add(this.btnReportUsers);
            this.travellerUsersTab.Controls.Add(this.addNotifications);
            this.travellerUsersTab.Controls.Add(this.usersDataGridView);
            this.travellerUsersTab.Controls.Add(this.userCreateUserBtn);
            this.travellerUsersTab.Controls.Add(this.label2);
            this.travellerUsersTab.Controls.Add(this.label3);
            this.travellerUsersTab.Location = new System.Drawing.Point(85, 4);
            this.travellerUsersTab.Name = "travellerUsersTab";
            this.travellerUsersTab.Size = new System.Drawing.Size(693, 720);
            this.travellerUsersTab.TabIndex = 3;
            this.travellerUsersTab.Text = "Users";
            // 
            // btnReportUsers
            // 
            this.btnReportUsers.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnReportUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReportUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReportUsers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportUsers.ForeColor = System.Drawing.Color.White;
            this.btnReportUsers.Location = new System.Drawing.Point(494, 127);
            this.btnReportUsers.Name = "btnReportUsers";
            this.btnReportUsers.Size = new System.Drawing.Size(223, 55);
            this.btnReportUsers.TabIndex = 41;
            this.btnReportUsers.Text = "Generate Users Report";
            this.btnReportUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnReportUsers.UseVisualStyleBackColor = false;
            this.btnReportUsers.Click += new System.EventHandler(this.button2_Click);
            // 
            // addNotifications
            // 
            this.addNotifications.Image = global::HappyJourneyAirline.Properties.Resources.addNot;
            this.addNotifications.Location = new System.Drawing.Point(613, 26);
            this.addNotifications.Name = "addNotifications";
            this.addNotifications.Size = new System.Drawing.Size(104, 80);
            this.addNotifications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addNotifications.TabIndex = 40;
            this.addNotifications.TabStop = false;
            this.addNotifications.Click += new System.EventHandler(this.addNotifications_Click);
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToOrderColumns = true;
            this.usersDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle43.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle43;
            this.usersDataGridView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle44.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersDataGridView.DefaultCellStyle = dataGridViewCellStyle44;
            this.usersDataGridView.Location = new System.Drawing.Point(22, 249);
            this.usersDataGridView.MultiSelect = false;
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.RowHeadersVisible = false;
            this.usersDataGridView.RowHeadersWidth = 70;
            this.usersDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDataGridView.RowTemplate.Height = 50;
            this.usersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDataGridView.Size = new System.Drawing.Size(695, 451);
            this.usersDataGridView.TabIndex = 39;
            this.usersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDataGridView_CellClick);
            this.usersDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.usersDataGridView_DataBindingComplete);
            // 
            // userCreateUserBtn
            // 
            this.userCreateUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.userCreateUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userCreateUserBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.userCreateUserBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCreateUserBtn.ForeColor = System.Drawing.Color.White;
            this.userCreateUserBtn.Location = new System.Drawing.Point(494, 188);
            this.userCreateUserBtn.Name = "userCreateUserBtn";
            this.userCreateUserBtn.Size = new System.Drawing.Size(223, 55);
            this.userCreateUserBtn.TabIndex = 38;
            this.userCreateUserBtn.Text = "Create User";
            this.userCreateUserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.userCreateUserBtn.UseVisualStyleBackColor = false;
            this.userCreateUserBtn.Click += new System.EventHandler(this.userCreateUserBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Manage users in this Page";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 100);
            this.label3.TabIndex = 4;
            this.label3.Text = "Users";
            // 
            // travellerSettingsTab
            // 
            this.travellerSettingsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerSettingsTab.Controls.Add(this.btnBackup);
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
            this.travellerSettingsTab.Location = new System.Drawing.Point(85, 4);
            this.travellerSettingsTab.Name = "travellerSettingsTab";
            this.travellerSettingsTab.Size = new System.Drawing.Size(693, 720);
            this.travellerSettingsTab.TabIndex = 2;
            this.travellerSettingsTab.Text = "Settings";
            this.travellerSettingsTab.Paint += new System.Windows.Forms.PaintEventHandler(this.travellerSettingsTab_Paint);
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBackup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(22, 636);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(399, 57);
            this.btnBackup.TabIndex = 40;
            this.btnBackup.Text = "Database Backup";
            this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // setErrorLbl
            // 
            this.setErrorLbl.AutoSize = true;
            this.setErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.setErrorLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.setErrorLbl.Location = new System.Drawing.Point(34, 466);
            this.setErrorLbl.Name = "setErrorLbl";
            this.setErrorLbl.Size = new System.Drawing.Size(274, 44);
            this.setErrorLbl.TabIndex = 39;
            this.setErrorLbl.Text = "Error: Please fix..";
            this.setErrorLbl.Visible = false;
            // 
            // setCancelBtn
            // 
            this.setCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.setCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.setCancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.setCancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setCancelBtn.ForeColor = System.Drawing.Color.White;
            this.setCancelBtn.Location = new System.Drawing.Point(232, 374);
            this.setCancelBtn.Name = "setCancelBtn";
            this.setCancelBtn.Size = new System.Drawing.Size(192, 57);
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
            this.setSaveChanesBtn.Location = new System.Drawing.Point(25, 374);
            this.setSaveChanesBtn.Name = "setSaveChanesBtn";
            this.setSaveChanesBtn.Size = new System.Drawing.Size(187, 57);
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
            this.label17.Location = new System.Drawing.Point(380, 257);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(253, 51);
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
            this.label16.Size = new System.Drawing.Size(106, 51);
            this.label16.TabIndex = 33;
            this.label16.Text = "Email:";
            this.label16.UseCompatibleTextRendering = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(380, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(183, 51);
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
            this.label12.Size = new System.Drawing.Size(188, 51);
            this.label12.TabIndex = 31;
            this.label12.Text = "First Name:";
            this.label12.UseCompatibleTextRendering = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(380, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 51);
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
            this.label9.Size = new System.Drawing.Size(179, 51);
            this.label9.TabIndex = 29;
            this.label9.Text = "Username:";
            this.label9.UseCompatibleTextRendering = true;
            // 
            // setPhoneTxt
            // 
            this.setPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setPhoneTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPhoneTxt.Location = new System.Drawing.Point(380, 290);
            this.setPhoneTxt.Name = "setPhoneTxt";
            this.setPhoneTxt.Size = new System.Drawing.Size(333, 51);
            this.setPhoneTxt.TabIndex = 28;
            // 
            // setEmailTxt
            // 
            this.setEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setEmailTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setEmailTxt.Location = new System.Drawing.Point(23, 290);
            this.setEmailTxt.Name = "setEmailTxt";
            this.setEmailTxt.Size = new System.Drawing.Size(321, 51);
            this.setEmailTxt.TabIndex = 27;
            // 
            // setLastNameTxt
            // 
            this.setLastNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setLastNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setLastNameTxt.Location = new System.Drawing.Point(380, 221);
            this.setLastNameTxt.Name = "setLastNameTxt";
            this.setLastNameTxt.Size = new System.Drawing.Size(333, 51);
            this.setLastNameTxt.TabIndex = 26;
            // 
            // setFirstNameTxt
            // 
            this.setFirstNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setFirstNameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setFirstNameTxt.Location = new System.Drawing.Point(23, 221);
            this.setFirstNameTxt.Name = "setFirstNameTxt";
            this.setFirstNameTxt.Size = new System.Drawing.Size(321, 51);
            this.setFirstNameTxt.TabIndex = 25;
            // 
            // setPasswordTxt
            // 
            this.setPasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setPasswordTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPasswordTxt.Location = new System.Drawing.Point(380, 152);
            this.setPasswordTxt.Name = "setPasswordTxt";
            this.setPasswordTxt.Size = new System.Drawing.Size(333, 51);
            this.setPasswordTxt.TabIndex = 24;
            // 
            // setUsernameTxt
            // 
            this.setUsernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setUsernameTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setUsernameTxt.Location = new System.Drawing.Point(23, 152);
            this.setUsernameTxt.Name = "setUsernameTxt";
            this.setUsernameTxt.Size = new System.Drawing.Size(321, 51);
            this.setUsernameTxt.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(18, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(441, 35);
            this.label8.TabIndex = 22;
            this.label8.Text = "Here you can customize your account";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(310, 100);
            this.label14.TabIndex = 3;
            this.label14.Text = "Settings";
            // 
            // travellerBookingsTab
            // 
            this.travellerBookingsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerBookingsTab.Controls.Add(this.bookingTable);
            this.travellerBookingsTab.Controls.Add(this.label1);
            this.travellerBookingsTab.Controls.Add(this.label13);
            this.travellerBookingsTab.Location = new System.Drawing.Point(85, 4);
            this.travellerBookingsTab.Name = "travellerBookingsTab";
            this.travellerBookingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.travellerBookingsTab.Size = new System.Drawing.Size(693, 720);
            this.travellerBookingsTab.TabIndex = 1;
            this.travellerBookingsTab.Text = "Bookings";
            // 
            // bookingTable
            // 
            this.bookingTable.AllowUserToAddRows = false;
            this.bookingTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle45.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookingTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle45;
            this.bookingTable.ColumnHeadersHeight = 40;
            this.bookingTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.from,
            this.to,
            this.dateTime,
            this.bookDetails});
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle46.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookingTable.DefaultCellStyle = dataGridViewCellStyle46;
            this.bookingTable.Location = new System.Drawing.Point(28, 147);
            this.bookingTable.Name = "bookingTable";
            this.bookingTable.ReadOnly = true;
            this.bookingTable.RowHeadersVisible = false;
            this.bookingTable.RowHeadersWidth = 51;
            this.bookingTable.RowTemplate.Height = 50;
            this.bookingTable.Size = new System.Drawing.Size(686, 519);
            this.bookingTable.TabIndex = 6;
            this.bookingTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookingTable_CellContentClick);
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
            // bookDetails
            // 
            this.bookDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookDetails.HeaderText = "Booking Details";
            this.bookDetails.MinimumWidth = 6;
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
            this.label1.Size = new System.Drawing.Size(426, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "You can here modify bookings easily";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(351, 100);
            this.label13.TabIndex = 2;
            this.label13.Text = "Bookings";
            // 
            // travellerFlightsTab
            // 
            this.travellerFlightsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.travellerFlightsTab.Controls.Add(this.viewPlanesBtn);
            this.travellerFlightsTab.Controls.Add(this.flightsDataGridView);
            this.travellerFlightsTab.Controls.Add(this.viewAirCityCouBtn);
            this.travellerFlightsTab.Controls.Add(this.creatFlightBtn);
            this.travellerFlightsTab.Controls.Add(this.label22);
            this.travellerFlightsTab.Controls.Add(this.label11);
            this.travellerFlightsTab.Location = new System.Drawing.Point(85, 4);
            this.travellerFlightsTab.Name = "travellerFlightsTab";
            this.travellerFlightsTab.Padding = new System.Windows.Forms.Padding(3);
            this.travellerFlightsTab.Size = new System.Drawing.Size(693, 720);
            this.travellerFlightsTab.TabIndex = 0;
            this.travellerFlightsTab.Text = "Flights";
            // 
            // viewPlanesBtn
            // 
            this.viewPlanesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.viewPlanesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewPlanesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.viewPlanesBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPlanesBtn.ForeColor = System.Drawing.Color.White;
            this.viewPlanesBtn.Location = new System.Drawing.Point(497, 36);
            this.viewPlanesBtn.Name = "viewPlanesBtn";
            this.viewPlanesBtn.Size = new System.Drawing.Size(223, 55);
            this.viewPlanesBtn.TabIndex = 40;
            this.viewPlanesBtn.Text = "View Planes";
            this.viewPlanesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.viewPlanesBtn.UseVisualStyleBackColor = false;
            this.viewPlanesBtn.Click += new System.EventHandler(this.viewPlanesBtn_Click);
            // 
            // flightsDataGridView
            // 
            this.flightsDataGridView.AllowUserToAddRows = false;
            this.flightsDataGridView.AllowUserToDeleteRows = false;
            this.flightsDataGridView.AllowUserToOrderColumns = true;
            this.flightsDataGridView.AllowUserToResizeRows = false;
            this.flightsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle47.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.flightsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.flightsDataGridView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle48.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.flightsDataGridView.DefaultCellStyle = dataGridViewCellStyle48;
            this.flightsDataGridView.Location = new System.Drawing.Point(18, 231);
            this.flightsDataGridView.Name = "flightsDataGridView";
            this.flightsDataGridView.RowHeadersVisible = false;
            this.flightsDataGridView.RowHeadersWidth = 70;
            this.flightsDataGridView.RowTemplate.Height = 50;
            this.flightsDataGridView.Size = new System.Drawing.Size(702, 455);
            this.flightsDataGridView.TabIndex = 38;
            this.flightsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flightsDataGridView_CellClick);
            // 
            // viewAirCityCouBtn
            // 
            this.viewAirCityCouBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.viewAirCityCouBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewAirCityCouBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.viewAirCityCouBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAirCityCouBtn.ForeColor = System.Drawing.Color.White;
            this.viewAirCityCouBtn.Location = new System.Drawing.Point(497, 97);
            this.viewAirCityCouBtn.Name = "viewAirCityCouBtn";
            this.viewAirCityCouBtn.Size = new System.Drawing.Size(223, 55);
            this.viewAirCityCouBtn.TabIndex = 37;
            this.viewAirCityCouBtn.Text = "View Locations";
            this.viewAirCityCouBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.viewAirCityCouBtn.UseVisualStyleBackColor = false;
            this.viewAirCityCouBtn.Click += new System.EventHandler(this.addAirCityCouBtn_Click);
            // 
            // creatFlightBtn
            // 
            this.creatFlightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.creatFlightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.creatFlightBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.creatFlightBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatFlightBtn.ForeColor = System.Drawing.Color.White;
            this.creatFlightBtn.Location = new System.Drawing.Point(497, 158);
            this.creatFlightBtn.Name = "creatFlightBtn";
            this.creatFlightBtn.Size = new System.Drawing.Size(223, 55);
            this.creatFlightBtn.TabIndex = 36;
            this.creatFlightBtn.Text = "Create Flight";
            this.creatFlightBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.creatFlightBtn.UseVisualStyleBackColor = false;
            this.creatFlightBtn.Click += new System.EventHandler(this.creatFlightBtn_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Location = new System.Drawing.Point(33, 101);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(330, 35);
            this.label22.TabIndex = 3;
            this.label22.Text = "Add and modify flights here";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(263, 100);
            this.label11.TabIndex = 1;
            this.label11.Text = "Flights";
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
            this.tabControler.Controls.Add(this.veAirCouCity);
            this.tabControler.Controls.Add(this.viewLocation);
            this.tabControler.Controls.Add(this.btntabCreatenotifications);
            this.tabControler.Controls.Add(viewPlanes);
            this.tabControler.Location = new System.Drawing.Point(136, 0);
            this.tabControler.Multiline = true;
            this.tabControler.Name = "tabControler";
            this.tabControler.SelectedIndex = 0;
            this.tabControler.Size = new System.Drawing.Size(782, 728);
            this.tabControler.TabIndex = 1;
            // 
            // AdminTabs
            // 
            this.Controls.Add(this.tabControler);
            this.Controls.Add(this.panel1);
            this.Name = "AdminTabs";
            this.Size = new System.Drawing.Size(921, 728);
            viewPlanes.ResumeLayout(false);
            viewPlanes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planesDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTab)).EndInit();
            this.btntabCreatenotifications.ResumeLayout(false);
            this.btntabCreatenotifications.PerformLayout();
            this.viewLocation.ResumeLayout(false);
            this.viewLocation.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.countryGroupBox.ResumeLayout(false);
            this.countryGroupBox.PerformLayout();
            this.AirportGroupBox.ResumeLayout(false);
            this.AirportGroupBox.PerformLayout();
            this.cityGroupBox.ResumeLayout(false);
            this.cityGroupBox.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.veAirCouCity.ResumeLayout(false);
            this.veAirCouCity.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countriesDataGridView)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.airportsDataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.mtFirstNamePanel.ResumeLayout(false);
            this.mtFirstNamePanel.PerformLayout();
            this.mtLastNamePanel.ResumeLayout(false);
            this.mtLastNamePanel.PerformLayout();
            this.mtCompanyNamePanel.ResumeLayout(false);
            this.mtCompanyNamePanel.PerformLayout();
            this.mtAgencyPanel.ResumeLayout(false);
            this.mtAgencyPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.AddAirCityConTab.ResumeLayout(false);
            this.AddAirCityConTab.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.createUserTab.ResumeLayout(false);
            this.createUserTab.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.cuFNamePanel.ResumeLayout(false);
            this.cuFNamePanel.PerformLayout();
            this.cuLNamePanel.ResumeLayout(false);
            this.cuLNamePanel.PerformLayout();
            this.cuCompanyNamePanel.ResumeLayout(false);
            this.cuCompanyNamePanel.PerformLayout();
            this.editFlightTab.ResumeLayout(false);
            this.editFlightTab.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.createFlightTab.ResumeLayout(false);
            this.createFlightTab.PerformLayout();
            this.bookingDetailsTab.ResumeLayout(false);
            this.bookingDetailsTab.PerformLayout();
            this.travellerUsersTab.ResumeLayout(false);
            this.travellerUsersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.travellerSettingsTab.ResumeLayout(false);
            this.travellerSettingsTab.PerformLayout();
            this.travellerBookingsTab.ResumeLayout(false);
            this.travellerBookingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTable)).EndInit();
            this.travellerFlightsTab.ResumeLayout(false);
            this.travellerFlightsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).EndInit();
            this.tabControler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void flightsTab_Click(object sender, EventArgs e)
        {
            setupFlightTab();
            tabControler.SelectTab(0);
            defultIcons();
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights_Active;
        }

        private void bookingTab_Click(object sender, EventArgs e)
        {
            tabControler.SelectTab(1);
            defultIcons();
            bookingTab.Image = global::HappyJourneyAirline.Properties.Resources.Bookings_Active;

            loadBookingTable();
        }

        private void loadBookingTable()
        {
            bookingTable.Rows.Clear();
            // display Booking list
            List<Ticket> tickets = new List<Ticket>();

            tickets = Ticket.GetAllTickets();

            foreach (Ticket ticket in tickets)
            {
                //Console.WriteLine("-, "+ticket.Id);
                Flight flight = Flight.GetFlightById(ticket.FlightID);
                //Console.WriteLine("--, " + flight.SourceAirportID);
                Airport source = Airport.GetAirportById(flight.SourceAirportID);
                Airport destination = Airport.GetAirportById(flight.DestinationAirportID);
                bookingTable.Rows.Add(ticket.Id, source.Name, destination.Name, flight.DepartureTimestamp, "View Details");
            }
        }

        private void settingTab_Click(object sender, EventArgs e)
        {
            tabControler.SelectTab(2);
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

        private void users_Click(object sender, EventArgs e)
        {
            setupUsers();
            tabControler.SelectTab(3);
            defultIcons();
            usersIcon.Image = global::HappyJourneyAirline.Properties.Resources.Users_Active;
        }

        private void defultIcons()
        {
            flightsTab.Image = global::HappyJourneyAirline.Properties.Resources.Flights;
            bookingTab.Image = global::HappyJourneyAirline.Properties.Resources.Bookings;
            settingTab.Image = global::HappyJourneyAirline.Properties.Resources.Settings_Icon;
            usersIcon.Image = global::HappyJourneyAirline.Properties.Resources.Users;
        }

        private void creatFlightBtn_Click(object sender, EventArgs e)
        {
            planes = new BindingList<Plane>(Plane.GetAllPlanes());
            airports = new BindingList<Airport>(Airport.GetAllAirports());

            if (airports.Count < 2)
            {
                MessageBox.Show(
     "There are no airports registered in the system, please add some first then come back to add a flight",
     "Problem",
     MessageBoxButtons.OK,
     MessageBoxIcon.Error);
                return;
            }

            if (planes.Count == 0)
            {
                MessageBox.Show(
     "There are no plains registered in the system, please add some first then come back to add a flight",
     "Problem",
     MessageBoxButtons.OK,
     MessageBoxIcon.Error);
                return;
            }
            cfArrTimePick.Format = DateTimePickerFormat.Time;
            cfDatePick.Value = DateTime.Now.Date + TimeSpan.FromDays(7);

            cfArrTimePick.ShowUpDown = true;


            cfDepTimePick.Format = DateTimePickerFormat.Time;
            cfDepTimePick.ShowUpDown = true;
            cfDepTimePick.Value = cfDatePick.Value.Date;


            setupCreateFlightTab();

            cfDepDrop_SelectedIndexChanged(null, null);
            tabControler.SelectTab(5);

        }

        private void cuCancelBtn_Click(object sender, EventArgs e)
        {
            tabControler.SelectTab(3);
        }

        private void userCreateUserBtn_Click(object sender, EventArgs e)
        {
            sutupCreateUserScreen();
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

            long id = AuthService.GetCurrentUserId();
            User currentUser = User.GetUserById(id);

            setUsernameTxt.Text = currentUser.Username;
            setFirstNameTxt.Text = currentUser.FirstName;
            setLastNameTxt.Text = currentUser.LastName;
            setEmailTxt.Text = currentUser.Email;
            setPasswordTxt.Text = currentUser.Password;
            setPhoneTxt.Text = currentUser.PhoneNumber;

        }

        private void addAirCityCouBtn_Click(object sender, EventArgs e)
        {
            setupViewAirCityCou();
            tabControler.SelectTab(10);
        }
        private void addAirCityCouBtn_Click_1(object sender, EventArgs e)
        {
            setupAddAirCityCou();
            tabControler.SelectTab(8);
        }
        private void addBackBtn_Click(object sender, EventArgs e)
        {
            addAirCityCouBtn_Click(null, null);
        }
        private void viewPlanesBtn_Click(object sender, EventArgs e)
        {
            setupViewPlanes();
            tabControler.SelectTab((int)Tabs.ViewPlanes);
        }


        #region flights
        private void setupFlightTab()
        {
            loadFlights();

            for (int i = 0; i < flightsDataGridView.Columns.Count; i++)
            {
                flightsDataGridView.Columns[i].ReadOnly = true;
            }
            flightsDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;


            if (flightsDataGridView.Columns[3] != null)
            {
                flightsDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            if (flightsDataGridView.Columns[4] != null)
            {
                flightsDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            if (flightsDataGridView.Columns[5] != null)
            {
                flightsDataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            if (flightsDataGridView.Columns["ArrivalTimestamp"] != null)
            {
                flightsDataGridView.Columns["ArrivalTimestamp"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

        }

        // should be in db
        private void loadFlights()
        {
            flights = new BindingList<Flight>(Flight.GetAllFlights());

            SqlConnection sqlConnection = new SqlConnection(Database.connectionString);
            sqlConnection.Open();
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = $"SELECT " +
                $"'Edit' AS 'Edit', " +
                $"f.Id AS 'Flight ID', " +
                $"f_s.name AS 'Flight Status', " +
                $"s_a.name AS 'Source Airport Name', " +
                $"d_a.name AS 'Destination Airport Name', " +
                $"f.departureTimestamp AS 'Departure Timestamp', " +
                $"f.arrivalTimestamp  AS 'Arrival Timestamp' " +
                $"FROM flights f " +
                $"LEFT JOIN flight_statuses f_s ON f.flightStatusID = f_s.Id " +
                $"LEFT JOIN airports s_a ON f.sourceAirportID = s_a.Id " +
                $"LEFT JOIN airports d_a ON f.destinationAirportID = d_a.Id;";

            DataSet ds = new DataSet();
            DataAdapter da = new SqlDataAdapter(command); // Ensure DataAdapter is of type SqlDataAdapter
            da.Fill(ds); // Fill the DataSet with the data from the database
            flightsDataGridView.DataSource = ds.Tables[0]; // Set the DataSource to the first table in the DataSet

            DataGridViewColumn editColumn = flightsDataGridView.Columns[0];
            editColumn.DefaultCellStyle = flightsDataGridView.Columns[2].DefaultCellStyle.Clone();
            editColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            editColumn.DefaultCellStyle.ForeColor = Color.Blue;

            command.Dispose();
            sqlConnection.Close();
        }

        private void flightsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                selectedFlight = Flight.GetFlightById((int)(flightsDataGridView.Rows[e.RowIndex].Cells[1].Value));
                setupEditFlight();
                tabControler.SelectTab(6);
            }
        }

        #region edit flight 

        private void setupEditFlight()
        {
            efDepTimePick.Format = DateTimePickerFormat.Time;
            efDepTimePick.ShowUpDown = true;
            efDepTimePick.Value = selectedFlight.DepartureTimestamp;

            efArrTimePick.Format = DateTimePickerFormat.Time;
            efArrTimePick.ShowUpDown = true;
            efArrTimePick.Value = selectedFlight.ArrivalTimestamp;

            efDepTxt.Text = Airport.GetAirportById(selectedFlight.SourceAirportID).Name;
            efArrTxt.Text = Airport.GetAirportById(selectedFlight.DestinationAirportID).Name;

            efFlightNumTxt.Text = $"{selectedFlight.Id}";

            efDatePick.MinDate = selectedFlight.DepartureTimestamp;
            efDatePick.Value = selectedFlight.DepartureTimestamp;

            flightsStatuses = new BindingList<FlightStatus>(FlightStatus.GetAllFlightStatuses());
            efStatusDrop.DataSource = FlightStatus.GetAllFlightStatuses();
            efStatusDrop.DisplayMember = "Name";
            efStatusDrop.SelectedIndex = flightsStatuses.ToList().FindIndex(s => s.Id == selectedFlight.FlightStatusID);

            planes = new BindingList<Plane>(Plane.GetAllPlanes());
            efPlaneIdDrop.DataSource = planes;
            efPlaneIdDrop.DisplayMember = "Id";
            efPlaneIdDrop.SelectedIndex = planes.ToList().FindIndex(p => p.Id == selectedFlight.PlaneID);


            string flightStatus = FlightStatus.GetFlightStatusById((int)selectedFlight.FlightStatusID).Name.ToLower();

            if (flightStatus == "scheduled")
            {
                efDepTimePick.Enabled = true;
                efPlaneIdDrop.Enabled = true;
                efDatePick.Enabled = true;
                efPriceTxt.Enabled = true;
                efStatusDrop.Enabled = true;
                efEditBtn.Visible = true;
                efDeleteBtn.Visible = false;
            }
            else
            {
                efDepTimePick.Enabled = false;
                efPlaneIdDrop.Enabled = false;
                efDatePick.Enabled = false;
                efPriceTxt.Enabled = false;
                efEditBtn.Visible = false;
                efDeleteBtn.Visible = true;
                efStatusDrop.Enabled = true;
                if (flightStatus == "cancelled" || flightStatus == "landed")
                {
                    efDeleteBtn.Visible = true;
                    efStatusDrop.Enabled = false;
                }
            }
        }

        private void efPriceTxt_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(efPriceTxt.Text))
            {
                efPriceTxt.Text = "0";
                efPriceTxt.SelectionStart = efPriceTxt.Text.Length;
            }
            if (decimal.Parse(efPriceTxt.Text) <= 0)
            {
                ShowError(efPriceErrorLbl, "Error: Flight price cannot be 0$");
            }
            else
            {
                ShowError(efPriceErrorLbl, string.Empty);

            }
        }
        private void efDepTimePick_ValueChanged(object sender, EventArgs e)
        {
            efDepTimePick.Value = efDatePick.Value.Date.Add(efDepTimePick.Value.TimeOfDay);
            Airport dep = Airport.GetAirportById(selectedFlight.SourceAirportID);
            Airport arr = Airport.GetAirportById(selectedFlight.DestinationAirportID);

            double distance = CalculateDistance((double)dep.Latitude, (double)dep.Longitude, (double)arr.Latitude, (double)arr.Longitude);
            double speed = rand * (900 - 800) + 800; ; // Speed in km/h
            double time = distance / speed; // Time in hours
            TimeSpan travelTime = TimeSpan.FromHours(time);

            efArrTimePick.Value = efDepTimePick.Value + travelTime;

        }

        private void efDeleteBtn_Click(object sender, EventArgs e)
        {

            bool result = Flight.DeleteFlight(selectedFlight.Id);

            if (!result)
            {
                MessageBox.Show("Problem saving to database, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                selectedFlight = null;
                flightsTab_Click(null, null);
            }
        }

        private void efEditBtn_Click(object sender, EventArgs e)
        {
            if (efPriceErrorLbl.Visible) { return; }

            if (efPlaneIdDrop.Enabled)
            {
                selectedFlight.PlaneID = (efPlaneIdDrop.SelectedItem as Plane).Id;
                selectedFlight.DepartureTimestamp = efDatePick.Value.Date + efDepTimePick.Value.TimeOfDay;
                selectedFlight.ArrivalTimestamp = efArrTimePick.Value;
                selectedFlight.BasePrice = decimal.Parse(efPriceTxt.Text);
                selectedFlight.FlightStatusID = (efStatusDrop.SelectedItem as FlightStatus).Id;
            }
            else
            {
                selectedFlight.FlightStatusID = (efStatusDrop.SelectedItem as FlightStatus).Id;
            }

            bool result = Flight.UpdateFlight(selectedFlight);

            if (!result)
            {
                MessageBox.Show("Problem saving to database, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                flightsTab_Click(sender, e);
            }
        }

        #endregion edit flight

        #region View [Airport, Country, City]
        private void setupViewAirCityCou()
        {

            countries = new BindingList<Country>(Country.GetAllCountries());
            countriesDataGridView.DataSource = countries;

            cities = new BindingList<City>(City.GetAllCities());
            citiesDataGridView.DataSource = cities;

            airports = new BindingList<Airport>(Airport.GetAllAirports());
            airportsDataGridView.DataSource = airports;


            if (airportsDataGridView.Columns["Name"] != null) // Replace "Name" with the actual column name for the airport name
            {
                var nameColumn = airportsDataGridView.Columns["Name"];
                nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Automatically adjust size to fit content
            }
        }
        private void citiesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                selectedCity = citiesDataGridView.Rows[e.RowIndex].DataBoundItem as City;
                cityGroupBox.Visible = true;
                countryGroupBox.Visible = false;
                AirportGroupBox.Visible = false;

                editCitytNameTxt.Text = selectedCity.Name;
                countries = new BindingList<Country>(Country.GetAllCountries());
                editConDrop.DataSource = countries;
                editConDrop.DisplayMember = "Name";
                editConDrop.SelectedItem = countries.First(c => c.Id == selectedCity.CountryId);
                tabControler.SelectTab(11);
            }
        }
        private void airportsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                selectedAirport = airportsDataGridView.Rows[e.RowIndex].DataBoundItem as Airport;
                cityGroupBox.Visible = false;
                countryGroupBox.Visible = false;
                AirportGroupBox.Visible = true;

                editAirportNameTxt.Text = selectedAirport.Name;

                City city = City.GetCityById(selectedAirport.CityId);
                cities = new BindingList<City>(City.GetCitiesByCountryId(city.CountryId));
                editAirportCityDrop.DataSource = cities;
                editAirportCityDrop.DisplayMember = "Name";
                editAirportCityDrop.SelectedItem = cities.First(c => c.Id == selectedAirport.CityId);

                countries = new BindingList<Country>(Country.GetAllCountries());
                editAirportConDrop.DataSource = countries;
                editAirportConDrop.DisplayMember = "Name";
                editAirportConDrop.SelectedItem = countries.First(c => c.Id == city.CountryId);

                editAirportLatitudeTxt.Text = $"{selectedAirport.Latitude}";
                editAirportLongitudeTxt.Text = $"{selectedAirport.Longitude}";

                tabControler.SelectTab(11);
            }
        }
        private void countriesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                selectedCountry = countriesDataGridView.Rows[e.RowIndex].DataBoundItem as Country;
                cityGroupBox.Visible = false;
                countryGroupBox.Visible = true;
                AirportGroupBox.Visible = false;

                editContNameTxt.Text = selectedCountry.Name;
                tabControler.SelectTab(11);
            }
        }

        #endregion View [Airport, Country, City]

        #region Edit [Airport, Country, City]

        private void editLocationBack_Click(object sender, EventArgs e)
        {
            tabControler.SelectTab(10);
            selectedAirport = null;
            selectedCity = null;
            selectedCountry = null;
        }

        private void editLocationSave_Click(object sender, EventArgs e)
        {
            if (AirportGroupBox.Visible)
            {
                bool isValid = false;
                string airportName = string.Empty;
                long? airportCityId = 0;
                decimal? airportLatitude = 0;
                decimal? airportLongitude = 0;

                validateAirport(editAirportNameTxt, editAirportErrorLbl, editAirportConDrop, editAirportCityDrop, editAirportLatitudeTxt,
                    editAirportLongitudeTxt, out isValid, out airportName, out airportCityId, out airportLatitude, out airportLongitude);


                if (!isValid) { return; }

                ShowError(editAirportErrorLbl, string.Empty);

                selectedAirport.Name = airportName;
                selectedAirport.CityId = (long)airportCityId;
                selectedAirport.Latitude = (decimal)airportLatitude;
                selectedAirport.Longitude = (decimal)airportLongitude;

                bool result = Airport.UpdateAirport(selectedAirport);

                if (!result)
                {
                    MessageBox.Show("Problem saving to database, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tabControler.SelectTab(10);

                }
            }
            else if (cityGroupBox.Visible)
            {
                bool isValid = false;
                string cityName = string.Empty;
                long? countryId = null;

                validateCity(editCitytNameTxt, editCityErrorLbl, editConDrop, out isValid, out cityName, out countryId);

                if (!isValid) { return; }

                ShowError(editCityErrorLbl, string.Empty); // Hide error

                selectedCity.Name = cityName;
                selectedCity.CountryId = (long)countryId;

                bool result = City.UpdateCity(selectedCity);

                if (!result)
                {
                    MessageBox.Show("Problem saving to database, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tabControler.SelectTab(10);
                }
            }
            else
            {
                bool isValid = false;
                string countryName = null;

                validateCountry(editContNameTxt, editContErrorLbl, out isValid, out countryName);

                if (!isValid) { return; }

                ShowError(editContErrorLbl, string.Empty);

                selectedCountry.Name = countryName;

                bool result = Country.UpdateCountry(selectedCountry);

                if (!result)
                {
                    MessageBox.Show("Problem saving to database, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tabControler.SelectTab(10);
                }

            }
        }

        private void editAirportConDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country c = editAirportConDrop.SelectedItem as Country;
            if (c == null)
            {
                Console.WriteLine("No country selected.");
            }
            else
            {
                cities = new BindingList<City>(City.GetAllCities());
                editAirportCityDrop.DataSource = new BindingList<City>(City.GetCitiesByCountryId(c.Id));
                editAirportCityDrop.DisplayMember = "Name";
            }

        }

        private void editLocationDelete_Click(object sender, EventArgs e)
        {
            bool result = false;

            DialogResult r = MessageBox.Show("Attention if you delete this location all its information and other locations related to it will be deleted and can't be restored", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
            {

                if (AirportGroupBox.Visible)
                {
                    result = Airport.DeleteAirport(selectedAirport.Id);
                }
                else if (cityGroupBox.Visible)
                {
                    result = City.DeleteCity(selectedCity.Id);
                }
                else
                {
                    result = Country.DeleteCountry(selectedCountry.Id);
                }


                if (!result)
                {
                    MessageBox.Show("Problem saving to database, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tabControler.SelectTab(10);
                }
            }
        }

        #endregion Edit [Airport, Country, City]

        #region [Country, City, Airport] Validation
        private void validateCountry(TextBox nameTextBox, Label errorLabel, out bool isValid, out string countryName)
        {
            isValid = false;
            countryName = null;

            string name = nameTextBox.Text.Trim();

            if (name.Length == 0)
            {
                ShowError(errorLabel, "Error: Invalid country name");
                return;
            }

            if (nameTextBox == addCitytNameTxt)
            {
                if (countries.Any(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    ShowError(errorLabel, "Error: Country already Exist");
                    return;
                }
            }
            ShowError(errorLabel, string.Empty);

            isValid = true;
            countryName = name;
            return;
        }
        private void validateCity(TextBox nameTextBox, Label errorLabel, ComboBox countryComboBox, out bool isValid, out string cityName, out long? countryId)
        {
            isValid = false;
            cityName = null;
            countryId = null;

            string inCityName = nameTextBox.Text.Trim();
            Country country = countryComboBox.SelectedItem as Country;

            if (string.IsNullOrEmpty(inCityName))
            {
                ShowError(errorLabel, "Error: Invalid city name");
                return;
            }

            if (country == null)
            {
                ShowError(errorLabel, "Error: Invalid country name");
                return;
            }

            if (nameTextBox == addCitytNameTxt)
            {
                if (cities.Any(c => c.Name.Equals(inCityName, StringComparison.OrdinalIgnoreCase) && c.CountryId == country.Id))
                {
                    ShowError(addCityErrorLbl, "Error: City already exists");
                    return;
                }
            }
            isValid = true;
            cityName = inCityName;
            countryId = country.Id;
            return;
        }
        private void validateAirport(TextBox nameTextBox, Label errorLabel, ComboBox countryComboBox, ComboBox cityComboBox, TextBox latitudeTextBox, TextBox longitudeTextBox,
    out bool isValid, out string airportName, out long? airportCityId, out decimal? airportLatitude, out decimal? airportLongitude)
        {
            isValid = false;
            airportName = null;
            airportCityId = null;
            airportLatitude = null;
            airportLongitude = null;

            string name = nameTextBox.Text.Trim();
            if (name.Length == 0)
            {
                ShowError(errorLabel, "Error: Airport name cannot be empty");
                return;
            }

            if (!name.Any(c => char.IsLetter(c)))
            {
                ShowError(errorLabel, "Error: Airport name must contain at least one letter");
                return;
            }

            Country country = countryComboBox.SelectedItem as Country;
            City city = cityComboBox.SelectedItem as City;

            if (country == null)
            {
                ShowError(errorLabel, "Error: Invalid country name");
                return;
            }

            if (city == null)
            {
                ShowError(errorLabel, "Error: Invalid city name");
                return;
            }

            if (nameTextBox == addAirportNameTxt)
            {
                if (Airport.GetAirportsByCityId(city.Id).Any(a =>
        a.Name.Equals(name, StringComparison.OrdinalIgnoreCase)
        ))
                {
                    ShowError(errorLabel, "Error: Airport Already exists");
                    return;
                }
            }

            decimal la = 0;
            decimal lo = 0;

            string laText = latitudeTextBox.Text.Trim();
            string loText = longitudeTextBox.Text.Trim();

            if (laText.Length == 0 || loText.Length == 0)
            {
                ShowError(errorLabel, "Error: latitude and longitude coordinates are not provided");
                return;
            }

            try
            {
                la = decimal.Parse(laText);
                lo = decimal.Parse(loText);
            }
            catch
            {
                ShowError(errorLabel, "Error: numbers are too big");
                return;
            }

            if (la < -90 || la > 90)
            {
                ShowError(errorLabel, "Error: Latitude range should be between -90 and 90");
                return;
            }

            if (lo < -180 || lo > 180)
            {
                ShowError(errorLabel, "Error: Longitude range should be between -180 and 180");
                return;
            }

            isValid = true;
            airportName = nameTextBox.Text.Trim();
            airportCityId = city.Id;
            airportLatitude = la;
            airportLongitude = lo;
        }

        #endregion


        #region Add [Country, City, Airport]
        private void setupAddAirCityCou()
        {
            addLoadCountries();
            addAirportConDrop_SelectedIndexChanged(null, null);
            addLoadCities();

            addContNameTxt.Text = string.Empty;
            addCitytNameTxt.Text = string.Empty;
            addAirportNameTxt.Text = string.Empty;
            addAirportLatitudeTxt.Text = string.Empty;
            addAirportLongitudeTxt.Text = string.Empty;

            addContErrorLbl.Visible = false;
            addCityErrorLbl.Visible = false;
            addAirportErrorLbl.Visible = false;
        }
        private void addLoadCountries()
        {
            countries = new BindingList<Country>(Country.GetAllCountries());

            BindingSource source1 = new BindingSource();

            BindingSource source2 = new BindingSource();

            source2.DataSource = countries;
            source1.DataSource = countries;

            addConDrop.DataSource = source1;
            addConDrop.DisplayMember = "Name";

            addAirportConDrop.DataSource = source2;
            addAirportConDrop.DisplayMember = "Name";
        }
        private void addLoadCities()
        {
            cities = new BindingList<City>(City.GetAllCities());

            addAirportCityDrop.DataSource = cities;
            addAirportCityDrop.DisplayMember = "Name";
        }

        private void addAddCountryBtn_Click(object sender, EventArgs e)
        {
            bool isValid = false;
            string countryName = null;

            validateCountry(addContNameTxt, addContErrorLbl, out isValid, out countryName);

            if (!isValid) { return; }


            ShowError(addContErrorLbl, string.Empty);


            bool result = Country.AddCountry(new Country
            {
                Name = addContNameTxt.Text
            });

            if (!result)
            {
                MessageBox.Show("Problem saving to database, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addLoadCountries();
                addConDrop.SelectedIndex = addConDrop.Items.Count - 1;
                addAirportConDrop.SelectedIndex = addAirportConDrop.Items.Count - 1;
            }

        }

        private void addAddCityBtn_Click(object sender, EventArgs e)
        {

            bool isValid = false;
            string cityName = string.Empty;
            long? countryId = null;

            validateCity(addCitytNameTxt, addCityErrorLbl, addConDrop, out isValid, out cityName, out countryId);

            if (!isValid) { return; }

            ShowError(addCityErrorLbl, string.Empty); // Hide error

            bool result = City.AddCity(new City { Name = cityName, CountryId = (long)countryId });

            if (!result)
            {
                MessageBox.Show("Problem saving to database, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addAirportConDrop_SelectedIndexChanged(null, null);
                addAirportCityDrop.SelectedIndex = addAirportCityDrop.Items.Count - 1;
            }

        }
        private void addAirportConDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country c = addAirportConDrop.SelectedItem as Country;
            if (c == null)
            {
                Console.WriteLine("No country selected.");
            }
            else
            {
                cities = new BindingList<City>(City.GetAllCities());
                addAirportCityDrop.DataSource = new BindingList<City>(City.GetCitiesByCountryId(c.Id));
                addAirportCityDrop.DisplayMember = "Name";
            }
        }

        private void addAddAirportBtn_Click(object sender, EventArgs e)
        {
            bool isValid = false;
            string airportName = string.Empty;
            long? airportCityId = 0;
            decimal? airportLatitude = 0;
            decimal? airportLongitude = 0;

            validateAirport(addAirportNameTxt, addAirportErrorLbl, addAirportConDrop, addAirportCityDrop, addAirportLatitudeTxt,
                addAirportLongitudeTxt, out isValid, out airportName, out airportCityId, out airportLatitude, out airportLongitude);


            if (isValid)
            {
                ShowError(addAirportErrorLbl, string.Empty);

                int result = Airport.AddAirport(new Airport
                {
                    Name = airportName,
                    CityId = (long)airportCityId,
                    Latitude = (decimal)airportLatitude,
                    Longitude = (decimal)airportLongitude
                });

                if (result == -1)
                {
                    MessageBox.Show("Problem saving to database, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Create Flight Screen
        private void setupCreateFlightTab()
        {
            cfFlightNumTxt.Text = $"{Flight.GetAllFlights().Count + 1}";
            cfDatePick.MinDate = DateTime.Today;

            cfDatePick.Value = DateTime.Now + TimeSpan.FromDays(7);
            cfPriceTxt.Text = "300";
            cfStatusDrop.DataSource = FlightStatus.GetAllFlightStatuses();
            cfStatusDrop.DisplayMember = "Name";
            cfStatusDrop.SelectedIndex = 0;

            cfTimeErrorLbl.Visible = false;
            cfAirportsErrorLbl.Visible = false;
            cfPriceErrorLbl.Visible = false;

            cfLoadPlanes();
            cfLoadAirports();
        }
        private void cfLoadPlanes()
        {
            // TODO: need tp get only avaliable planes for the spicific time and date
            cfPlaneIdDrop.DataSource = planes;
            cfPlaneIdDrop.DisplayMember = "Id";
            if (planes.Count != 0)
            {
                cfPlaneIdDrop.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("There are no planes avaliable at the selected time",
                    "Problem",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void cfLoadAirports()
        {
            BindingSource depSource = new BindingSource
            {
                DataSource = airports
            };
            cfDepDrop.DataSource = depSource;
            cfDepDrop.DisplayMember = "Name";

            BindingSource arrSource = new BindingSource
            {
                DataSource = airports
            };
            cfArrDrop.DataSource = arrSource;
            cfArrDrop.DisplayMember = "Name";

            cfDepDrop.SelectedIndex = 0;

            cfArrDrop.SelectedIndex = 1;

        }
        private void cfDepDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cfDepDrop.SelectedItem == cfArrDrop.SelectedItem)
            {
                cfAirportsErrorLbl.Visible = true;
            }
            else
            {
                cfAirportsErrorLbl.Visible = false;
                cfDepTimePick_ValueChanged(null, null);
            }
        }
        private void cfArrDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cfDepDrop.SelectedItem == cfArrDrop.SelectedItem)
            {
                cfAirportsErrorLbl.Visible = true;
            }
            else
            {
                cfAirportsErrorLbl.Visible = false;
                cfDepTimePick_ValueChanged(null, null);
            }

        }
        private void cfDepTimePick_ValueChanged(object sender, EventArgs e)
        {
            if ((cfDepDrop.SelectedItem != null && cfArrDrop.SelectedItem != null)
                &&
                (cfDepDrop.SelectedItem != cfArrDrop.SelectedItem))
            {
                cfDepTimePick.Value = cfDatePick.Value.Date.Add(cfDepTimePick.Value.TimeOfDay);
                Airport dep = cfDepDrop.SelectedItem as Airport;
                Airport arr = cfArrDrop.SelectedItem as Airport;

                double distance = CalculateDistance((double)dep.Latitude, (double)dep.Longitude, (double)arr.Latitude, (double)arr.Longitude);
                double speed = rand * (900 - 800) + 800; ; // Speed in km/h
                double time = distance / speed; // Time in hours
                TimeSpan travelTime = TimeSpan.FromHours(time);

                cfArrTimePick.Value = cfDepTimePick.Value + travelTime;
            }
        }
        private double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            const double R = 6371.0; // Earth's radius in km
            double dLat = ToRadians(lat2 - lat1);
            double dLon = ToRadians(lon2 - lon1);

            lat1 = ToRadians(lat1);
            lat2 = ToRadians(lat2);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(lat1) * Math.Cos(lat2) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c;
        }
        private double ToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }
        private void cfCreateBtn_Click(object sender, EventArgs e)
        {

            if (cfAirportsErrorLbl.Visible || cfPriceErrorLbl.Visible) { return; }
            if (cfAirportsErrorLbl.Visible)
            {
                ShowError(cfAirportsErrorLbl, "Departure and Arrival Airports cannot be the same");
                return;
            }

            Flight flight = new Flight
            {
                PlaneID = (cfPlaneIdDrop.SelectedItem as Plane).Id,
                DepartureTimestamp = cfDatePick.Value.Date + cfDepTimePick.Value.TimeOfDay,
                ArrivalTimestamp = cfArrTimePick.Value,
                BasePrice = Convert.ToDecimal(cfPriceTxt.Text),
                DestinationAirportID = (cfArrDrop.SelectedItem as Airport).Id,
                SourceAirportID = (cfDepDrop.SelectedItem as Airport).Id,
                FlightStatusID = 1
            };

            Flight.AddFlight(flight);
            flightsTab_Click(sender, e);
        }
        private void cfPriceTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cfPriceTxt.Text))
            {
                cfPriceTxt.Text = "0";
                cfPriceTxt.SelectionStart = cfPriceTxt.Text.Length;
            }
            if (decimal.Parse(cfPriceTxt.Text) <= 0)
            {
                ShowError(cfPriceErrorLbl, "Error: Flight price cannot be 0$");
            }
            else
            {
                ShowError(cfPriceErrorLbl, string.Empty);

            }
        }
        #endregion Create Flight Screen

        #endregion flights



        #region for all
        private void ShowError(Label label, string message)
        {
            label.Text = message;
            label.Visible = !string.IsNullOrEmpty(message);
        }
        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!(e.KeyChar == '@' || e.KeyChar == '.' || e.KeyChar == '-' || e.KeyChar == '_' || char.IsLetterOrDigit(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }


            if (sender is TextBox textBox)
            {
                string txt = textBox.Text + e.KeyChar;

                if (txt.Count(c => c == '@') > 1)
                {
                    e.Handled = true;
                    return;
                }

                if (txt.Contains("@"))
                {
                    string[] parts = txt.Split('@');
                    if (parts.Length > 1 && !parts[1].Contains('.') && e.KeyChar == '.')
                    {
                        return;
                    }
                }

                if (txt.Contains("@") && txt.Split('@')[1].StartsWith(".") && e.KeyChar == '.')
                {
                    e.Handled = true;
                    return;
                }

                if (txt.Contains("-"))
                {
                    if (txt.StartsWith("-") || txt.EndsWith("-") || txt.Contains("-.") || txt.Contains(".-"))
                    {
                        e.Handled = true;
                        return;
                    }
                }
            }
        }
        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            string allowedPattern = "[+\\d\\s()-]";
            if (!Regex.IsMatch(e.KeyChar.ToString(), allowedPattern))
            {
                e.Handled = true;
                return;
            }
        }
        private void txtOnlyLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        // for airport name
        private void txtOnlyDotUnderscore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-' || e.KeyChar == ' ')
            {
                return;
            }

            e.Handled = true;
        }
        private void txtLatitudeLongitude_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return;
            }
            if ((e.KeyChar == '-' || e.KeyChar == '+') && textBox.Text.Length == 0)
            {
                return;
            }

            if (e.KeyChar == '.' && !textBox.Text.Contains("."))
            {
                return;
            }

            e.Handled = true;
        }
        private void txtOnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == '.' && !(sender as TextBox).Text.Contains("."))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        private void txtOnlyIntgers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private DataGridViewTextBoxColumn AddEditColumn()
        {
            DataGridViewTextBoxColumn editColumn = new DataGridViewTextBoxColumn
            {
                Name = "EditColumn",
                HeaderText = "Edit",
                ReadOnly = true,
                DefaultCellStyle = usersDataGridView.Columns[2].DefaultCellStyle.Clone()
            };
            editColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            editColumn.DefaultCellStyle.ForeColor = Color.Blue;
            return editColumn;
        }
        private DataGridViewTextBoxColumn AddDeleteColumn()
        {
            DataGridViewTextBoxColumn editColumn = new DataGridViewTextBoxColumn
            {
                Name = "DeleteColumn",
                HeaderText = "Delete",
                ReadOnly = true,
                DefaultCellStyle = usersDataGridView.Columns[2].DefaultCellStyle.Clone()
            };
            editColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            editColumn.DefaultCellStyle.ForeColor = Color.Red;
            return editColumn;
        }

        #endregion

        #region users screen
        private void setupUsers()
        {
            users = new BindingList<User>(User.GetAllUsers());

            usersDataGridView.DataSource = users;
            usersDataGridView.ClearSelection();

            usersDataGridView.Columns["Password"].Visible = false;
            usersDataGridView.Columns["Id"].ReadOnly = true;
            usersDataGridView.Columns["FirstName"].HeaderText = "First Name";
            usersDataGridView.Columns["LastName"].HeaderText = "Last Name";
            usersDataGridView.Columns["PhoneNumber"].HeaderText = "Phone Number";
            usersDataGridView.Columns["Type"].HeaderText = "User Type";
            usersDataGridView.Columns["AgencyID"].ReadOnly = true;

            for (int i = 1; i < usersDataGridView.Columns.Count; i++)
            {
                usersDataGridView.Columns[i].ReadOnly = true;
            }
            usersDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;


            // Adjust the AutoSizeMode for specific columns to display full content
            usersDataGridView.Columns["Username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            usersDataGridView.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            usersDataGridView.Columns["CompanyName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }
        private void usersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                selectedUser = usersDataGridView.Rows[e.RowIndex].DataBoundItem as User;
                setupViewUser();
                tabControler.SelectTab(9);
            }
        }

        #region view user screen 
        private void setupViewUser()
        {
            if (selectedUser.Type == "traveller" || selectedUser.Type == "admin")
            {
                mtCompanyNamePanel.Visible = false;
                mtLastNamePanel.Visible = true;
                mtFirstNamePanel.Visible = true;
            }
            else
            {
                mtCompanyNamePanel.Visible = true;
                mtLastNamePanel.Visible = false;
                mtFirstNamePanel.Visible = false;
            }

            if (selectedUser.AgencyID == null || selectedUser.Type == "agency")
            {
                mtAgencyPanel.Visible = false;
            }
            else
            {
                mtAgencyPanel.Visible = true;
            }

            mtUserIDTxt.Text = $"{selectedUser.Id:D}";
            mtFnameTxt.Text = selectedUser.FirstName;
            mtLnameTxt.Text = selectedUser.LastName;
            mtPhoneTxt.Text = selectedUser.PhoneNumber;
            mtUserTypeTxt.Text = selectedUser.Type;
            mtUsernameTxt.Text = selectedUser.Username;
            mtEmailTxt.Text = selectedUser.Email;
            mtCompanyNamelTxt.Text = $"{selectedUser.CompanyName}";
            mtAgencyIdTxt.Text = $"{selectedUser.AgencyID}";
        }
        private void mtDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Attention if you delete your account all your information will be deleted and cant be restored", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                bool val = User.DeleteUser(selectedUser.Id);
                if (val)
                {
                    users_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Problem applying changes to the database, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void mtCancelBtn_Click(object sender, EventArgs e)
        {
            users_Click(null, null);
        }

        #endregion view user screen

        private void usersDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in (sender as DataGridView).Rows)
            {
                row.Cells[0].Value = "Edit";
            }
        }

        #region create user screen
        private void sutupCreateUserScreen()
        {
            cuUserTypeDrop.Items.Clear();

            cuUserTypeDrop.Items.Add("Agency");
            cuUserTypeDrop.Items.Add("Admin");

            cuUserTypeDrop.SelectedIndex = 0;

            cuUsernameTxt.Text = string.Empty;
            cuPasswordTxt.Text = string.Empty;
            cuFnameTxt.Text = string.Empty;
            cuLnameTxt.Text = string.Empty;
            cuCoumpanyNameTxt.Text = string.Empty;
            cuEmailTxt.Text = string.Empty;
            cuPhoneTxt.Text = string.Empty;


            cuUserNameErrorLbl.Visible = false;
            cuPasswordErrorLbl.Visible = false;
            cuFCoumpanyNameErrorLbl.Visible = false;
            cuLNameErrorLbl.Visible = false;
            cuEmailErrorLbl.Visible = false;
            cuPhoneNumberErrorLbl.Visible = false;

            cuUserTypeDrop_SelectedIndexChanged(null, null);
        }
        private void cuUserTypeDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cuUserTypeDrop.SelectedIndex == 1)
            {
                cuCompanyNamePanel.Visible = false;
                cuCoumpanyNameTxt.Text = "";
                cuEmailTxt.Text = $"admin{User.GetAllUsers().Count() + 1}@happy.airlines.org";
                cuEmailTxt.ReadOnly = true;
                cuFNamePanel.Visible = true;
                cuLNamePanel.Visible = true;
            }
            else
            {
                cuCompanyNamePanel.Visible = true;
                cuFNamePanel.Visible = false;
                cuLNamePanel.Visible = false;
                cuFnameTxt.Text = "";
                cuLnameTxt.Text = "";
                cuEmailTxt.Text = string.Empty;
                cuEmailTxt.ReadOnly = false;

            }
        }
        private void cuCreateUserBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            bool isValidData = true;  // Start assuming the data is valid

            // Username validation
            if (cuUsernameTxt.Text.Trim().Length < 3)
            {
                ShowError(cuUserNameErrorLbl, "Error: Username must contain at least 3 characters");
                isValidData = false;  // Mark as invalid if this check fails
            }
            else
            {
                ShowError(cuUserNameErrorLbl, string.Empty);
                user.Username = cuUsernameTxt.Text.Trim();
            }

            // Password validation
            if (cuPasswordTxt.Text.Trim().Length < 6)
            {
                ShowError(cuPasswordErrorLbl, "Error: Password must contain at least 6 characters");
                isValidData = false;  // Mark as invalid if this check fails
            }
            else
            {
                ShowError(cuPasswordErrorLbl, string.Empty);
                user.Password = cuPasswordTxt.Text.Trim();
            }

            if (cuUserTypeDrop.SelectedIndex == 1) // creating admin
            {
                user.Type = "admin";
                // first Name validation
                if (string.IsNullOrEmpty(cuFnameTxt.Text.Trim()))
                {
                    ShowError(cuFCoumpanyNameErrorLbl, "Error: First name cannot be empty");
                    isValidData = false;
                }
                else
                {
                    ShowError(cuFCoumpanyNameErrorLbl, string.Empty);
                    user.FirstName = cuFnameTxt.Text.Trim();
                }

                // last Name validation
                if (string.IsNullOrEmpty(cuLnameTxt.Text.Trim()))
                {
                    ShowError(cuLNameErrorLbl, "Error: Last name cannot be empty");
                    isValidData = false;
                }
                else
                {
                    ShowError(cuLNameErrorLbl, string.Empty);
                    user.LastName = cuLnameTxt.Text.Trim();
                }

                user.Email = cuEmailTxt.Text.Trim();
            }
            else // creating agency
            {
                user.Type = "agency";
                string companyName = cuCoumpanyNameTxt.Text.Trim();
                if (companyName.Count() < 6)
                {
                    ShowError(cuFCoumpanyNameErrorLbl, "Error: Company name must contain at least 6 characters");
                    isValidData = false;
                }
                else if (users.Any(u => u.CompanyName != null && u.CompanyName.Equals(companyName, StringComparison.OrdinalIgnoreCase)))
                {
                    ShowError(cuFCoumpanyNameErrorLbl, "Error: Company name is already in use, please choose another one");
                    isValidData = false;
                }
                else
                {
                    ShowError(cuFCoumpanyNameErrorLbl, string.Empty);
                    user.CompanyName = cuCoumpanyNameTxt.Text.Trim();
                }

                // email validation
                string txt = cuEmailTxt.Text.Trim().ToLower();
                string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                if (!Regex.IsMatch(txt, emailPattern))
                {
                    ShowError(cuEmailErrorLbl, "Error: Invalid email.");
                    isValidData = false;
                }
                else if (users.Any(u => u.Email.Equals(txt, StringComparison.OrdinalIgnoreCase)))
                {
                    ShowError(cuEmailErrorLbl, "Error: Email entered is already in use.");
                    isValidData = false;
                }
                else
                {
                    ShowError(cuEmailErrorLbl, string.Empty);
                    user.Email = txt;
                }

            }

            // phone Number validation
            string pattern = @"^\+?(\d{1,4})?[\s.-]?\(?\d{1,4}\)?[\s.-]?\d{1,4}[\s.-]?\d{1,4}$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(cuPhoneTxt.Text.Trim()))
            {
                ShowError(cuPhoneNumberErrorLbl, "Error: Invalid phone number");
                isValidData = false;
            }
            else
            {
                ShowError(cuPhoneNumberErrorLbl, string.Empty);
                user.PhoneNumber = cuPhoneTxt.Text.Trim();
            }

            if (isValidData)
            {
                long result = User.AddUser(user);

                if (result == -1)
                {
                    MessageBox.Show("Error: Problem applying changes to the database, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    selectedUser = User.GetUserById(result);
                    setupViewUser();
                    tabControler.SelectTab(9);
                }
            }
        }


        #endregion create user screen

        #endregion users screen

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntabCreatenotifications_Paint(object sender, PaintEventArgs e)
        {

            SqlConnection con = new SqlConnection(Database.connectionString);
            con.Open();
            SqlCommand com = con.CreateCommand();
            com.CommandText = "select f.id , a.name , b.name from flights f , airports a , airports b where f.sourceAirportID = a.Id and f.destinationAirportID = b.Id and (f.flightStatusID = 1 or f.flightStatusID = 2);";

            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            comboBoxFlights.Items.Clear();
            comboBoxFlights.Items.Add(" ");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string id = dt.Rows[i]["id"].ToString();                // Flight ID
                string sourceAirport = dt.Rows[i]["name"].ToString();  // Source airport name
                string destinationAirport = dt.Rows[i]["name"].ToString(); // Destination airport name

                // Add a readable format to the comboBox
                comboBoxFlights.Items.Add($"ID: {id}   {sourceAirport} --> {destinationAirport}");
            }



            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = true;

            if (txtTitle.Text == "")
            {
                lblErrorTitle.Text = "Title is required";
                valid = false;
            }
            else
            {
                lblErrorTitle.Text = "";
            }

            if (txtDescription.Text == "")
            {
                lblErrorDescription.Text = "Description is required";
                valid = false;
            }
            else
            {
                lblErrorDescription.Text = "";
            }

            if (comboBoxFlights.SelectedItem == null)
            {
                lblErrorFlight.Text = "Flight is required";
                valid = false;
            }
            else
            {
                lblErrorFlight.Text = "";
            }

            if (comboBoxType.SelectedItem == null)
            {
                lblErrorType.Text = "Type is required";
                valid = false;
            }
            else
            {
                lblErrorType.Text = "";

            }

            if (valid)
            {

                List<string> userList = new List<string>();

                SqlConnection con = new SqlConnection(Database.connectionString);
                con.Open();
                SqlCommand com = con.CreateCommand();

                com.CommandText = "SELECT DISTINCT userID \r\nFROM tickets \r\nWHERE flightID = 5;";
                SqlDataReader reader = com.ExecuteReader();

                List<int> userIds = new List<int>();

                while (reader.Read())
                {

                    userIds.Add(Convert.ToInt32(reader.GetInt64(0)));

                }
                reader.Close();

                for (int i = 0; i < userIds.Count; i++)
                {

                    Notification n = new Notification();
                    n.Title = txtTitle.Text;
                    n.Description = txtDescription.Text;
                    n.Source = "Admin";
                    n.Type = comboBoxType.SelectedItem.ToString();
                    n.UserId = userIds[i];

                    SqlCommand insetCom = con.CreateCommand();

                    insetCom.CommandText = "insert into notifications(source,type,title,description,user_id) values (@source , @type, @title, @desc, @id);";
                    insetCom.Parameters.AddWithValue("@source", n.Source);
                    insetCom.Parameters.AddWithValue("@type", n.Type);
                    insetCom.Parameters.AddWithValue("@title", n.Title);
                    insetCom.Parameters.AddWithValue("@desc", n.Description);
                    insetCom.Parameters.AddWithValue("@id", n.UserId);

                    insetCom.ExecuteNonQuery();
                }

                con.Close();

                MessageBox.Show("All the notifications sends to the users sucssfuly", "Notification sends", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtTitle.Text = "";
                txtDescription.Text = "";
                comboBoxFlights.SelectedIndex = 0;
                comboBoxType.SelectedIndex = 0;

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tabControler.SelectTab(12);
            defultIcons();
        }

        private void addNotifications_Click(object sender, EventArgs e)
        {
            tabControler.SelectTab(12);
        }

        //load the user information on the textfileds in event of clicking the settings tab
        private void travellerSettingsTab_Paint(object sender, PaintEventArgs e)
        {
            long id = AuthService.GetCurrentUserId();
            User currentUser = User.GetUserById(id);

            setUsernameTxt.Text = currentUser.Username;
            setFirstNameTxt.Text = currentUser.FirstName;
            setLastNameTxt.Text = currentUser.LastName;
            setEmailTxt.Text = currentUser.Email;
            setPasswordTxt.Text = currentUser.Password;
            setPhoneTxt.Text = currentUser.PhoneNumber;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {

            string selectedPath = null;

            // Create an STA thread for the FolderBrowserDialog
            Thread staThread = new Thread(() =>
            {
                using (FolderBrowserDialog folderDlg = new FolderBrowserDialog())
                {
                    folderDlg.Description = "Select a folder to save your backup";
                    folderDlg.ShowNewFolderButton = true;
                    folderDlg.RootFolder = Environment.SpecialFolder.MyComputer;

                    if (folderDlg.ShowDialog() == DialogResult.OK)
                    {
                        selectedPath = folderDlg.SelectedPath;
                    }
                }
            });

            // Set the thread to STA and start it
            staThread.SetApartmentState(ApartmentState.STA);
            staThread.Start();
            staThread.Join(); // Wait for the thread to complete

            if (!string.IsNullOrEmpty(selectedPath))
            {
                // the file formate 
                string timestamp = DateTime.Now.ToString("ddMMyyyy_HHmmss");

                // Construct the filename with the formatted date and time
                string filename = $"HappyJourneyAirline_DB_Backup_{timestamp}.bak";


                // Call the backup method with the generated filename
                Database.BackupDatabase(filename, selectedPath);

                MessageBox.Show($"Selected folder for the backup file: {selectedPath}", "Folder Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Thread staThread = new Thread(() =>
            {
                using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
                {
                    saveFileDialog1.Filter = "Text File |*.txt";
                    saveFileDialog1.Title = "Save User Report";
                    saveFileDialog1.FileName = "UserReport.txt";

                    // Show the dialog and process the save if a file name is provided
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(saveFileDialog1.FileName))
                    {
                        try
                        {
                            // Step 1: Retrieve the list of users
                            List<User> userList = User.GetAllUsers();

                            // Step 2: Create the content for the file
                            StringBuilder userInfo = new StringBuilder();
                            userInfo.AppendLine("User Report");
                            userInfo.AppendLine("--------------------------");
                            bool adminHeaderAdded = false;
                            bool travellerHeaderAdded = false;
                            bool agencyHeaderAdded = false;

                            foreach (var user in userList)
                            {
                                if (user.Type == "admin" && !adminHeaderAdded)
                                {
                                    userInfo.AppendLine("");
                                    userInfo.AppendLine("--------- Admin Users ---------");
                                    adminHeaderAdded = true;
                                }
                                else if (user.Type == "agency" && !agencyHeaderAdded)
                                {
                                    userInfo.AppendLine("");
                                    userInfo.AppendLine("--------- Employeer Users ---------");
                                    agencyHeaderAdded = true;
                                }
                                else if (user.Type == "traveller" && !travellerHeaderAdded)
                                {
                                    userInfo.AppendLine("");
                                    userInfo.AppendLine("--------- Traveller Users ---------");
                                    travellerHeaderAdded = true;
                                }

                                userInfo.AppendLine($"ID: {user.Id}, Name: {user.Username}, Email: {user.Email}, Username: {user.Username}, Password: {user.Password}, CPR: {user.Cpr}");
                            }


                            userInfo.AppendLine("\n\nTotal Number of Users: " + userList.Count);
                            // Step 3: Write the content to the selected file
                            File.WriteAllText(saveFileDialog1.FileName, userInfo.ToString());

                            // Step 4: Notify the user of success
                            MessageBox.Show("Report saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            // Handle any errors during the save process
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            });

            staThread.SetApartmentState(ApartmentState.STA);
            staThread.Start();
            staThread.Join(); // Wait for the thread to complete

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Thread staThread = new Thread(() =>
            {
                using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
                {
                    saveFileDialog1.Filter = "Text File |*.txt";
                    saveFileDialog1.Title = "Save User Report";
                    saveFileDialog1.FileName = "LocationsReport.txt";

                    // Show the dialog and process the save if a file name is provided
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(saveFileDialog1.FileName))
                    {
                        try
                        {
                            // Step 1: Retrieve the list of users
                            List<City> cityList = City.GetAllCities();
                            List<Country> countriesList = Country.GetAllCountries();
                            List<Airport> airportList = Airport.GetAllAirports();

                            // Step 2: Create the content for the file
                            StringBuilder locationInfo = new StringBuilder();
                            locationInfo.AppendLine("Locations Report");
                            locationInfo.AppendLine("--------------------------------\n\n");



                            locationInfo.AppendLine("--------- Country ---------");
                            foreach (var country in countriesList)
                            {
                                locationInfo.AppendLine($"Country ID: {country.Id}, Country Name: {country.Name}");
                            }


                            locationInfo.AppendLine("--------- City ---------");
                            foreach (var city in cityList)
                            {
                                locationInfo.AppendLine($"City ID: {city.Id}, City Name: {city.Name}, Country ID: {city.CountryId}");
                            }

                            locationInfo.AppendLine("--------- Airport ---------");
                            foreach (var airport in airportList)
                            {
                                locationInfo.AppendLine($"Airport ID: {airport.Id}, Airport Name: {airport.Name}, City ID: {airport.CityId}");
                            }


                            locationInfo.AppendLine("\n\nTotal Number of Country: " + countriesList.Count);
                            locationInfo.AppendLine("\n\nTotal Number of City: " + cityList.Count);
                            locationInfo.AppendLine("\n\nTotal Number of Airport: " + airportList.Count);

                            // Step 3: Write the content to the selected file
                            File.WriteAllText(saveFileDialog1.FileName, locationInfo.ToString());

                            // Step 4: Notify the user of success
                            MessageBox.Show("Report saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            // Handle any errors during the save process
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            });

            staThread.SetApartmentState(ApartmentState.STA);
            staThread.Start();
            staThread.Join(); // Wait for the thread to complete

        }

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

                bdUsrTypeLbl.Text = $"{User.GetUserById(ticket.UserID).Type.ToString()} ID: ";
                bdUsrIDLbl.Text = ticket.UserID.ToString();

                bdIDTxt.Text = ticket.Id.ToString();
                bdFlightNumTxt.Text = ticket.FlightID.ToString();
                bdDateTxt.Text = dep.Split(' ')[0];
                bdDepTimeTxt.Text = dep;
                bdArrTimeTxt.Text = arr;
                bdFromTxt.Text = sourceCity.Name.ToString() + " (" + sourceCountry.Name.ToString() + ")";
                bdToTxt.Text = destinationCity.Name.ToString() + " (" + destinationCountry.Name.ToString() + ")";
                bdDepTxt.Text = source.Name.ToString();
                bdArrTxt.Text = destination.Name.ToString();
                tabControler.SelectTab(4);
            }
        }

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
                        tabControler.SelectTab(1);
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

        #region Planes
        private void setupViewPlanes()
        {
            planes = new BindingList<Plane>(Plane.GetAllPlanes());
            planesDataGridView.DataSource = planes;

            ShowError(cpModelErrorLbl, string.Empty);
            ShowError(cpCapacityErrorLbl, string.Empty);

            cpModelTxt.Text = "";
            cpCapacityTxt.Text = "";
        }
        private void planesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                selectedPlane = planesDataGridView.Rows[e.RowIndex].DataBoundItem as Plane;
                DialogResult result = MessageBox.Show($"Are you sure you want to delete plane {selectedPlane.Id}, deleting it will result in all related information being deleted too.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    if (Plane.DeletePlane(selectedPlane.Id))
                    {
                        planes = new BindingList<Plane>(Plane.GetAllPlanes());
                        planesDataGridView.DataSource = planes;
                    }
                    else
                    {
                        MessageBox.Show("Problem saving to database, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void planesDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in (sender as DataGridView).Rows)
            {
                row.Cells[0].Value = "Delete";
            }

        }

        private void createPlaneBtn_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string txt = cpModelTxt.Text.Trim();

            if (txt.Length != 5)
            {
                ShowError(cpModelErrorLbl, "Error: Plane model name can should contain 5 charecters");
                isValid = false;
            }
            else
            {
                ShowError(cpModelErrorLbl, string.Empty);
            }

            int cap = 0;
            bool val = int.TryParse(cpCapacityTxt.Text, out cap);
            if (!val)
            {
                ShowError(cpCapacityErrorLbl, "Error: Plane Capacity number is too big");
                isValid = false;
            }
            else if (cap == 0)
            {
                ShowError(cpCapacityErrorLbl, "Error: Plane capacity canot be 0");
                isValid = false;
            }
            else
            {
                ShowError(cpCapacityErrorLbl, string.Empty);

            }


            if (!isValid) { return; }
            if (Plane.AddPlane(new Plane { Capacity = cap, Model = txt }) != -1)
            {
                planes = new BindingList<Plane>(Plane.GetAllPlanes());
                planesDataGridView.DataSource = planes;
                cpModelTxt.Text = "";
                cpCapacityTxt.Text = "";
            }
            else
            {
                MessageBox.Show("Problem saving to database, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cpCapacityTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox).Text))
            {
                (sender as TextBox).Text = "0";
                (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
            }

        }
        #endregion Planes

        private void logOutIcon_Click(object sender, EventArgs e)
        {
            AuthService.LogoutCurrentUser();
            appTabs.SelectTab(0);
        }
    }
}