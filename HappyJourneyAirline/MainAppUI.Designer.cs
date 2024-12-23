using System.Windows.Forms;

namespace ProjectSample
{
    partial class MainAppUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            Application.Exit();

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.PictureBox pictureBox1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label label19;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.PictureBox pictureBox2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label21;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.PictureBox pictureBox3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAppUI));
            this.registerTab = new System.Windows.Forms.TabPage();
            this.registerValidationMessage = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.phoneNumberRegisterInput = new System.Windows.Forms.TextBox();
            this.emailRegisterInput = new System.Windows.Forms.TextBox();
            this.lastNameRegisterInput = new System.Windows.Forms.TextBox();
            this.firstNameRegisterInput = new System.Windows.Forms.TextBox();
            this.passwordRegisterInput = new System.Windows.Forms.TextBox();
            this.registerUsernameInput = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.loginValidationMessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mainMenuTab = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.appTabs = new System.Windows.Forms.TabControl();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).BeginInit();
            this.registerTab.SuspendLayout();
            this.loginTab.SuspendLayout();
            this.mainMenuTab.SuspendLayout();
            this.appTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(330, 386);
            label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(53, 13);
            label7.TabIndex = 8;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(330, 317);
            label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(55, 13);
            label6.TabIndex = 7;
            label6.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = global::HappyJourneyAirline.Properties.Resources.logo;
            pictureBox1.Location = new System.Drawing.Point(367, 61);
            pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(150, 157);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            label2.Location = new System.Drawing.Point(348, 287);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(195, 13);
            label2.TabIndex = 4;
            label2.Text = "Please login to contiue using the system";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(307, 240);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(276, 24);
            label1.TabIndex = 3;
            label1.Text = "Welcome To Happy Journey";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(452, 392);
            label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(78, 13);
            label20.TabIndex = 23;
            label20.Text = "Phone Number";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(188, 392);
            label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(32, 13);
            label19.TabIndex = 22;
            label19.Text = "Email";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(452, 329);
            label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(58, 13);
            label18.TabIndex = 21;
            label18.Text = "Last Name";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(188, 329);
            label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(57, 13);
            label17.TabIndex = 20;
            label17.Text = "First Name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(452, 267);
            label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(53, 13);
            label16.TabIndex = 19;
            label16.Text = "Password";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(188, 265);
            label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(55, 13);
            label15.TabIndex = 18;
            label15.Text = "Username";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            label8.Location = new System.Drawing.Point(324, 535);
            label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(261, 13);
            label8.TabIndex = 16;
            label8.Text = "By using our system you accept the Terms & Conditions";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = global::HappyJourneyAirline.Properties.Resources.logo;
            pictureBox2.Location = new System.Drawing.Point(369, 22);
            pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(150, 157);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            label3.Location = new System.Drawing.Point(350, 241);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(205, 13);
            label3.TabIndex = 10;
            label3.Text = "Please Fill details below to create account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(309, 201);
            label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(276, 24);
            label4.TabIndex = 9;
            label4.Text = "Welcome To Happy Journey";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = System.Drawing.Color.Gray;
            label21.Location = new System.Drawing.Point(373, 502);
            label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(138, 13);
            label21.TabIndex = 6;
            label21.Text = "All Rights Reserved @2024";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(367, 340);
            label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(151, 24);
            label10.TabIndex = 5;
            label10.Text = "Happy Journey";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = global::HappyJourneyAirline.Properties.Resources.logo;
            pictureBox3.Location = new System.Drawing.Point(367, 180);
            pictureBox3.Margin = new System.Windows.Forms.Padding(5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(150, 157);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // registerTab
            // 
            this.registerTab.BackColor = System.Drawing.Color.White;
            this.registerTab.Controls.Add(this.registerValidationMessage);
            this.registerTab.Controls.Add(label20);
            this.registerTab.Controls.Add(label19);
            this.registerTab.Controls.Add(label18);
            this.registerTab.Controls.Add(label17);
            this.registerTab.Controls.Add(label16);
            this.registerTab.Controls.Add(label15);
            this.registerTab.Controls.Add(this.label9);
            this.registerTab.Controls.Add(label8);
            this.registerTab.Controls.Add(this.phoneNumberRegisterInput);
            this.registerTab.Controls.Add(this.emailRegisterInput);
            this.registerTab.Controls.Add(this.lastNameRegisterInput);
            this.registerTab.Controls.Add(this.firstNameRegisterInput);
            this.registerTab.Controls.Add(this.passwordRegisterInput);
            this.registerTab.Controls.Add(this.registerUsernameInput);
            this.registerTab.Controls.Add(pictureBox2);
            this.registerTab.Controls.Add(label3);
            this.registerTab.Controls.Add(this.button2);
            this.registerTab.Controls.Add(label4);
            this.registerTab.Location = new System.Drawing.Point(4, 22);
            this.registerTab.Margin = new System.Windows.Forms.Padding(5);
            this.registerTab.Name = "registerTab";
            this.registerTab.Padding = new System.Windows.Forms.Padding(3);
            this.registerTab.Size = new System.Drawing.Size(918, 716);
            this.registerTab.TabIndex = 1;
            this.registerTab.Text = "Register";
            this.registerTab.Click += new System.EventHandler(this.registerTab_Click);
            // 
            // registerValidationMessage
            // 
            this.registerValidationMessage.AutoSize = true;
            this.registerValidationMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerValidationMessage.ForeColor = System.Drawing.Color.Red;
            this.registerValidationMessage.Location = new System.Drawing.Point(271, 459);
            this.registerValidationMessage.Name = "registerValidationMessage";
            this.registerValidationMessage.Size = new System.Drawing.Size(0, 15);
            this.registerValidationMessage.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(386, 559);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Already Have Account ?";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // phoneNumberRegisterInput
            // 
            this.phoneNumberRegisterInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.phoneNumberRegisterInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumberRegisterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberRegisterInput.Location = new System.Drawing.Point(455, 409);
            this.phoneNumberRegisterInput.Margin = new System.Windows.Forms.Padding(5);
            this.phoneNumberRegisterInput.Name = "phoneNumberRegisterInput";
            this.phoneNumberRegisterInput.Size = new System.Drawing.Size(226, 40);
            this.phoneNumberRegisterInput.TabIndex = 15;
            // 
            // emailRegisterInput
            // 
            this.emailRegisterInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.emailRegisterInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailRegisterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailRegisterInput.Location = new System.Drawing.Point(199, 409);
            this.emailRegisterInput.Margin = new System.Windows.Forms.Padding(0);
            this.emailRegisterInput.Name = "emailRegisterInput";
            this.emailRegisterInput.Size = new System.Drawing.Size(226, 40);
            this.emailRegisterInput.TabIndex = 14;
            // 
            // lastNameRegisterInput
            // 
            this.lastNameRegisterInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lastNameRegisterInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameRegisterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameRegisterInput.Location = new System.Drawing.Point(455, 346);
            this.lastNameRegisterInput.Margin = new System.Windows.Forms.Padding(5);
            this.lastNameRegisterInput.Name = "lastNameRegisterInput";
            this.lastNameRegisterInput.Size = new System.Drawing.Size(226, 40);
            this.lastNameRegisterInput.TabIndex = 13;
            // 
            // firstNameRegisterInput
            // 
            this.firstNameRegisterInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.firstNameRegisterInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameRegisterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameRegisterInput.Location = new System.Drawing.Point(199, 346);
            this.firstNameRegisterInput.Margin = new System.Windows.Forms.Padding(0);
            this.firstNameRegisterInput.Name = "firstNameRegisterInput";
            this.firstNameRegisterInput.Size = new System.Drawing.Size(226, 40);
            this.firstNameRegisterInput.TabIndex = 12;
            // 
            // passwordRegisterInput
            // 
            this.passwordRegisterInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.passwordRegisterInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordRegisterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordRegisterInput.Location = new System.Drawing.Point(455, 284);
            this.passwordRegisterInput.Margin = new System.Windows.Forms.Padding(5);
            this.passwordRegisterInput.Name = "passwordRegisterInput";
            this.passwordRegisterInput.Size = new System.Drawing.Size(226, 40);
            this.passwordRegisterInput.TabIndex = 11;
            // 
            // registerUsernameInput
            // 
            this.registerUsernameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.registerUsernameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerUsernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUsernameInput.Location = new System.Drawing.Point(199, 284);
            this.registerUsernameInput.Margin = new System.Windows.Forms.Padding(0);
            this.registerUsernameInput.Name = "registerUsernameInput";
            this.registerUsernameInput.Size = new System.Drawing.Size(226, 40);
            this.registerUsernameInput.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(274, 483);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(344, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Register Traveller";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // loginTab
            // 
            this.loginTab.BackColor = System.Drawing.Color.White;
            this.loginTab.Controls.Add(this.loginValidationMessage);
            this.loginTab.Controls.Add(label7);
            this.loginTab.Controls.Add(label6);
            this.loginTab.Controls.Add(this.label5);
            this.loginTab.Controls.Add(pictureBox1);
            this.loginTab.Controls.Add(this.textBox2);
            this.loginTab.Controls.Add(this.textBox1);
            this.loginTab.Controls.Add(label2);
            this.loginTab.Controls.Add(this.button1);
            this.loginTab.Controls.Add(label1);
            this.loginTab.Location = new System.Drawing.Point(4, 22);
            this.loginTab.Margin = new System.Windows.Forms.Padding(5);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginTab.Size = new System.Drawing.Size(918, 716);
            this.loginTab.TabIndex = 0;
            this.loginTab.Text = "Login";
            // 
            // loginValidationMessage
            // 
            this.loginValidationMessage.AutoSize = true;
            this.loginValidationMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginValidationMessage.ForeColor = System.Drawing.Color.Red;
            this.loginValidationMessage.Location = new System.Drawing.Point(330, 444);
            this.loginValidationMessage.Name = "loginValidationMessage";
            this.loginValidationMessage.Size = new System.Drawing.Size(0, 15);
            this.loginValidationMessage.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(392, 524);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Register as Traveller";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8773F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(332, 406);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 30);
            this.textBox2.TabIndex = 5;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8773F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(332, 337);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(333, 464);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainMenuTab
            // 
            this.mainMenuTab.BackColor = System.Drawing.Color.White;
            this.mainMenuTab.Controls.Add(label21);
            this.mainMenuTab.Controls.Add(label10);
            this.mainMenuTab.Controls.Add(this.button4);
            this.mainMenuTab.Controls.Add(this.button3);
            this.mainMenuTab.Controls.Add(pictureBox3);
            this.mainMenuTab.Location = new System.Drawing.Point(4, 22);
            this.mainMenuTab.Margin = new System.Windows.Forms.Padding(5);
            this.mainMenuTab.Name = "mainMenuTab";
            this.mainMenuTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainMenuTab.Size = new System.Drawing.Size(918, 739);
            this.mainMenuTab.TabIndex = 5;
            this.mainMenuTab.Text = "MainMenuPage";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(296, 449);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(292, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Register a traveller";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(198)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(296, 390);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(292, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // appTabs
            // 
            this.appTabs.Controls.Add(this.mainMenuTab);
            this.appTabs.Controls.Add(this.loginTab);
            this.appTabs.Controls.Add(this.registerTab);
            this.appTabs.Location = new System.Drawing.Point(-6, -22);
            this.appTabs.Margin = new System.Windows.Forms.Padding(5);
            this.appTabs.Name = "appTabs";
            this.appTabs.SelectedIndex = 0;
            this.appTabs.Size = new System.Drawing.Size(926, 765);
            this.appTabs.TabIndex = 7;
            this.appTabs.TabStop = false;
            // 
            // MainAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 740);
            this.Controls.Add(this.appTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainAppUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Happy Journey Airline";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).EndInit();
            this.registerTab.ResumeLayout(false);
            this.registerTab.PerformLayout();
            this.loginTab.ResumeLayout(false);
            this.loginTab.PerformLayout();
            this.mainMenuTab.ResumeLayout(false);
            this.mainMenuTab.PerformLayout();
            this.appTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage registerTab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox phoneNumberRegisterInput;
        private System.Windows.Forms.TextBox emailRegisterInput;
        private System.Windows.Forms.TextBox lastNameRegisterInput;
        private System.Windows.Forms.TextBox firstNameRegisterInput;
        private System.Windows.Forms.TextBox passwordRegisterInput;
        private System.Windows.Forms.TextBox registerUsernameInput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage loginTab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage mainMenuTab;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl appTabs;
        private System.Windows.Forms.Label loginValidationMessage;
        private System.Windows.Forms.Label registerValidationMessage;
    }
}