using HappyJourneyAirline.Lib;
using HappyJourneyAirline.Models;
using HappyJourneyAirline.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSample
{
    public partial class MainAppUI : Form
    {

        private enum APP_ROUTES : int
        {
            MAIN_MENU_ROUTE = 0,
            LOGIN_ROUTE = 1,
            REGISTER_ROUTE = 2,
            TRAVELLER_DASHBOARD_ROUTE = 3,
            EMPLOYER_DASHBOARD_ROUTE = 4,
            ADMIN_DASHBOARD_ROUTE = 5
        }

        private int getAppRoute(APP_ROUTES appRoute)
        {
            return (int) appRoute;
        }


        public MainAppUI()
        {
            InitializeComponent();

            TravellerTabs travelTab = new TravellerTabs();
            TabPage travelTabPage = new TabPage("Traveller Dashboard");
            travelTabPage.Controls.Add(travelTab);
            appTabs.TabPages.Add(travelTabPage);

            AdminTabs adminTab = new AdminTabs();
            TabPage adminTabPage = new TabPage("Admin Dashboard");
            adminTabPage.Controls.Add(adminTab);
            appTabs.TabPages.Add(adminTabPage);


            EmployerTabs employerTab = new EmployerTabs();
            TabPage employerTabPage = new TabPage("Employer Dashboad");
            employerTabPage.Controls.Add(employerTab);
            appTabs.TabPages.Add(employerTabPage);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (AuthService.IsUserLoggedIn())
            {
                User userHandler = new User();

                User currentLoggedInUser = userHandler.GetUserById(AuthService.GetCurrentUserId());

                try
                {
                    if (currentLoggedInUser?.Type == "traveller")
                    {
                        appTabs.SelectTab(3);
                    }
                    else if (currentLoggedInUser?.Type == "admin")
                    {
                        appTabs.SelectTab(4);
                    }
                    else if (currentLoggedInUser.Type == "agency")
                    {
                        appTabs.SelectTab(5);
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;
            User userHandler = new User();
            User loggedInUser = userHandler.Login(username, password);

            if (loggedInUser == null) {
                Console.WriteLine("Incorrect Credintials");
                return;
            }
            AuthService.StoreUserId(loggedInUser.Id);
            Console.WriteLine("Logged in user: " + loggedInUser.Email);

            if (loggedInUser.Type == "traveller")
            {
                appTabs.SelectTab(3);
            }
            else if (loggedInUser.Type == "admin")
            {
                appTabs.SelectTab(4);
            }
            else if (loggedInUser.Type == "agency")
            {
                appTabs.SelectTab(5);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            appTabs.SelectTab(getAppRoute(APP_ROUTES.REGISTER_ROUTE) );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            appTabs.SelectTab(getAppRoute(APP_ROUTES.REGISTER_ROUTE) );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            appTabs.SelectTab(getAppRoute(APP_ROUTES.LOGIN_ROUTE) );
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            appTabs.SelectTab(getAppRoute(APP_ROUTES.LOGIN_ROUTE) );
        }

        private void registerTab_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String username = registerUsernameInput.Text;
            String password = passwordRegisterInput.Text;
            String firstName = firstNameRegisterInput.Text;
            String lastName = lastNameRegisterInput.Text;
            String phoneNumber = phoneNumberRegisterInput.Text;
            String email = emailRegisterInput.Text;

            User userHandler = new User();

            User newUser = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password,
                Email = email,
                Type = "traveller",
                PhoneNumber = phoneNumber,
                CompanyName = null,
            };

            long newUserId = userHandler.AddUser(newUser);

            if (newUserId > 0)
            {
                Console.WriteLine($"User created successfully! User ID: {newUserId}");
                AuthService.StoreUserId(newUserId);

                appTabs.SelectTab(getAppRoute(APP_ROUTES.TRAVELLER_DASHBOARD_ROUTE));
            }
            else
            {
                Console.WriteLine("Failed to create user.");
            }

            
        }

        private void emailRegisterInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
