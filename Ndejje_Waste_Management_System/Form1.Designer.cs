namespace Ndejje_Waste_Management_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controls used in the form
        private System.Windows.Forms.DataGridView dgvResidents;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabResident;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.Label lblResName;
        private System.Windows.Forms.Label lblResPhone;
        private System.Windows.Forms.Label lblResZone;
        private System.Windows.Forms.TextBox txtResName;
        private System.Windows.Forms.TextBox txtResPhone;
        private System.Windows.Forms.ComboBox cmbResZone;
        private System.Windows.Forms.Button btnSaveResident;
        private System.Windows.Forms.ComboBox cmbSchedZone;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtCollector;
        private System.Windows.Forms.Button btnCreateSchedule;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblTotalResidentsTitle;
        private System.Windows.Forms.Label lblTotalResidentsValue;
        private System.Windows.Forms.Label lblTotalCollectorsTitle;
        private System.Windows.Forms.Label lblTotalCollectorsValue;
        private System.Windows.Forms.Label lblUpcomingSchedulesTitle;
        private System.Windows.Forms.Label lblUpcomingSchedulesValue;
        private System.Windows.Forms.Label lblTotalCollectionsTitle;
        private System.Windows.Forms.Label lblTotalCollectionsValue;
        private System.Windows.Forms.Label lblRecentCollectionsTitle;
        private System.Windows.Forms.DataGridView dgvRecentCollections;
        private System.Windows.Forms.Label lblSystemInfo;
        private System.Windows.Forms.Label lblResWelcome;
        private System.Windows.Forms.Label lblResNextScheduleEnglish;
        private System.Windows.Forms.Label lblResNextScheduleLuganda;
        private System.Windows.Forms.Label lblThankYouEnglish;
        private System.Windows.Forms.Label lblThankYouLuganda;
        private System.Windows.Forms.Panel pnlRegisterArea;
        private System.Windows.Forms.Panel pnlLoginArea;
        private System.Windows.Forms.Button btnLoginNow;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.DataGridView dgvSignIns;
        private System.Windows.Forms.ComboBox cmbAdminZone;
        private System.Windows.Forms.Button btnViewAssigned;
        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Label lblLoginUser2;
        private System.Windows.Forms.Label lblLoginPass2;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnTabLogin;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblAccountPassword;
        private System.Windows.Forms.TextBox txtAccountPassword;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cmbLanguage;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvResidents = new System.Windows.Forms.DataGridView();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.pnlRegisterArea = new System.Windows.Forms.Panel();
            this.btnLoginNow = new System.Windows.Forms.Button();
            this.lblResName = new System.Windows.Forms.Label();
            this.txtResName = new System.Windows.Forms.TextBox();
            this.lblResPhone = new System.Windows.Forms.Label();
            this.txtResPhone = new System.Windows.Forms.TextBox();
            this.lblResZone = new System.Windows.Forms.Label();
            this.cmbResZone = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblAccountPassword = new System.Windows.Forms.Label();
            this.txtAccountPassword = new System.Windows.Forms.TextBox();
            this.btnSaveResident = new System.Windows.Forms.Button();
            this.btnTabLogin = new System.Windows.Forms.Button();
            this.cmbSchedZone = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtCollector = new System.Windows.Forms.TextBox();
            this.btnCreateSchedule = new System.Windows.Forms.Button();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.pnlLoginArea = new System.Windows.Forms.Panel();
            this.lblLoginUser2 = new System.Windows.Forms.Label();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.lblLoginPass2 = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tabResident = new System.Windows.Forms.TabPage();
            this.lblResWelcome = new System.Windows.Forms.Label();
            this.lblResNextScheduleEnglish = new System.Windows.Forms.Label();
            this.lblResNextScheduleLuganda = new System.Windows.Forms.Label();
            this.lblThankYouEnglish = new System.Windows.Forms.Label();
            this.lblThankYouLuganda = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.lblTotalResidentsTitle = new System.Windows.Forms.Label();
            this.lblTotalResidentsValue = new System.Windows.Forms.Label();
            this.lblTotalCollectorsTitle = new System.Windows.Forms.Label();
            this.lblTotalCollectorsValue = new System.Windows.Forms.Label();
            this.lblUpcomingSchedulesTitle = new System.Windows.Forms.Label();
            this.lblUpcomingSchedulesValue = new System.Windows.Forms.Label();
            this.lblTotalCollectionsTitle = new System.Windows.Forms.Label();
            this.lblTotalCollectionsValue = new System.Windows.Forms.Label();
            this.lblRecentCollectionsTitle = new System.Windows.Forms.Label();
            this.dgvRecentCollections = new System.Windows.Forms.DataGridView();
            this.lblSystemInfo = new System.Windows.Forms.Label();
            this.dgvSignIns = new System.Windows.Forms.DataGridView();
            this.cmbAdminZone = new System.Windows.Forms.ComboBox();
            this.btnViewAssigned = new System.Windows.Forms.Button();
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResidents)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.pnlRegisterArea.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.pnlLoginArea.SuspendLayout();
            this.tabResident.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentCollections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSignIns)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResidents
            // 
            this.dgvResidents.ColumnHeadersHeight = 34;
            this.dgvResidents.Location = new System.Drawing.Point(12, 12);
            this.dgvResidents.Name = "dgvResidents";
            this.dgvResidents.RowHeadersWidth = 62;
            this.dgvResidents.Size = new System.Drawing.Size(450, 200);
            this.dgvResidents.TabIndex = 0;
            this.dgvResidents.Visible = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(480, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 26);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(480, 38);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 26);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(480, 64);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(200, 23);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            this.lblStatus.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRegister);
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabResident);
            this.tabControl1.Controls.Add(this.tabDashboard);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 450);
            this.tabControl1.TabIndex = 4;
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.pnlRegisterArea);
            this.tabRegister.Controls.Add(this.btnTabLogin);
            this.tabRegister.Controls.Add(this.cmbSchedZone);
            this.tabRegister.Controls.Add(this.dtpDate);
            this.tabRegister.Controls.Add(this.txtCollector);
            this.tabRegister.Controls.Add(this.btnCreateSchedule);
            this.tabRegister.Location = new System.Drawing.Point(4, 29);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(692, 417);
            this.tabRegister.TabIndex = 0;
            this.tabRegister.Text = "Register";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // pnlRegisterArea
            // 
            this.pnlRegisterArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRegisterArea.Controls.Add(this.btnLoginNow);
            this.pnlRegisterArea.Controls.Add(this.lblResName);
            this.pnlRegisterArea.Controls.Add(this.txtResName);
            this.pnlRegisterArea.Controls.Add(this.lblResPhone);
            this.pnlRegisterArea.Controls.Add(this.txtResPhone);
            this.pnlRegisterArea.Controls.Add(this.lblResZone);
            this.pnlRegisterArea.Controls.Add(this.cmbResZone);
            this.pnlRegisterArea.Controls.Add(this.lblLanguage);
            this.pnlRegisterArea.Controls.Add(this.cmbLanguage);
            this.pnlRegisterArea.Controls.Add(this.lblRole);
            this.pnlRegisterArea.Controls.Add(this.cmbRole);
            this.pnlRegisterArea.Controls.Add(this.lblAccountPassword);
            this.pnlRegisterArea.Controls.Add(this.txtAccountPassword);
            this.pnlRegisterArea.Controls.Add(this.btnSaveResident);
            this.pnlRegisterArea.Location = new System.Drawing.Point(10, 10);
            this.pnlRegisterArea.Name = "pnlRegisterArea";
            this.pnlRegisterArea.Size = new System.Drawing.Size(330, 220);
            this.pnlRegisterArea.TabIndex = 0;
            // 
            // btnLoginNow
            // 
            this.btnLoginNow.Location = new System.Drawing.Point(206, 187);
            this.btnLoginNow.Name = "btnLoginNow";
            this.btnLoginNow.Size = new System.Drawing.Size(120, 28);
            this.btnLoginNow.TabIndex = 28;
            this.btnLoginNow.Text = "Go to Login";
            this.btnLoginNow.UseVisualStyleBackColor = true;
            this.btnLoginNow.Click += new System.EventHandler(this.btnLoginNow_Click);
            // 
            // lblResName
            // 
            this.lblResName.AutoSize = true;
            this.lblResName.Location = new System.Drawing.Point(10, 10);
            this.lblResName.Name = "lblResName";
            this.lblResName.Size = new System.Drawing.Size(55, 20);
            this.lblResName.TabIndex = 8;
            this.lblResName.Text = "Name:";
            // 
            // txtResName
            // 
            this.txtResName.Location = new System.Drawing.Point(120, 8);
            this.txtResName.Name = "txtResName";
            this.txtResName.Size = new System.Drawing.Size(200, 26);
            this.txtResName.TabIndex = 0;
            // 
            // lblResPhone
            // 
            this.lblResPhone.AutoSize = true;
            this.lblResPhone.Location = new System.Drawing.Point(10, 40);
            this.lblResPhone.Name = "lblResPhone";
            this.lblResPhone.Size = new System.Drawing.Size(59, 20);
            this.lblResPhone.TabIndex = 9;
            this.lblResPhone.Text = "Phone:";
            // 
            // txtResPhone
            // 
            this.txtResPhone.Location = new System.Drawing.Point(120, 36);
            this.txtResPhone.Name = "txtResPhone";
            this.txtResPhone.Size = new System.Drawing.Size(200, 26);
            this.txtResPhone.TabIndex = 1;
            // 
            // lblResZone
            // 
            this.lblResZone.AutoSize = true;
            this.lblResZone.Location = new System.Drawing.Point(10, 70);
            this.lblResZone.Name = "lblResZone";
            this.lblResZone.Size = new System.Drawing.Size(50, 20);
            this.lblResZone.TabIndex = 10;
            this.lblResZone.Text = "Zone:";
            // 
            // cmbResZone
            // 
            this.cmbResZone.Location = new System.Drawing.Point(120, 66);
            this.cmbResZone.Name = "cmbResZone";
            this.cmbResZone.Size = new System.Drawing.Size(200, 28);
            this.cmbResZone.TabIndex = 2;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(10, 100);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(85, 20);
            this.lblLanguage.TabIndex = 26;
            this.lblLanguage.Text = "Language:";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.Location = new System.Drawing.Point(120, 96);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(200, 28);
            this.cmbLanguage.TabIndex = 25;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(10, 130);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(46, 20);
            this.lblRole.TabIndex = 21;
            this.lblRole.Text = "Role:";
            // 
            // cmbRole
            // 
            this.cmbRole.Location = new System.Drawing.Point(120, 126);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(200, 28);
            this.cmbRole.TabIndex = 22;
            // 
            // lblAccountPassword
            // 
            this.lblAccountPassword.AutoSize = true;
            this.lblAccountPassword.Location = new System.Drawing.Point(10, 160);
            this.lblAccountPassword.Name = "lblAccountPassword";
            this.lblAccountPassword.Size = new System.Drawing.Size(82, 20);
            this.lblAccountPassword.TabIndex = 23;
            this.lblAccountPassword.Text = "Password:";
            // 
            // txtAccountPassword
            // 
            this.txtAccountPassword.Location = new System.Drawing.Point(120, 156);
            this.txtAccountPassword.Name = "txtAccountPassword";
            this.txtAccountPassword.PasswordChar = '*';
            this.txtAccountPassword.Size = new System.Drawing.Size(200, 26);
            this.txtAccountPassword.TabIndex = 24;
            // 
            // btnSaveResident
            // 
            this.btnSaveResident.Location = new System.Drawing.Point(80, 188);
            this.btnSaveResident.Name = "btnSaveResident";
            this.btnSaveResident.Size = new System.Drawing.Size(120, 28);
            this.btnSaveResident.TabIndex = 3;
            this.btnSaveResident.Text = "Register";
            this.btnSaveResident.UseVisualStyleBackColor = true;
            this.btnSaveResident.Click += new System.EventHandler(this.btnSaveResident_Click);
            // 
            // btnTabLogin
            // 
            this.btnTabLogin.Location = new System.Drawing.Point(10, 248);
            this.btnTabLogin.Name = "btnTabLogin";
            this.btnTabLogin.Size = new System.Drawing.Size(180, 36);
            this.btnTabLogin.TabIndex = 27;
            this.btnTabLogin.Text = "Already registered? Login";
            this.btnTabLogin.UseVisualStyleBackColor = true;
            this.btnTabLogin.Click += new System.EventHandler(this.btnTabLogin_Click);
            // 
            // cmbSchedZone
            // 
            this.cmbSchedZone.Location = new System.Drawing.Point(360, 6);
            this.cmbSchedZone.Name = "cmbSchedZone";
            this.cmbSchedZone.Size = new System.Drawing.Size(200, 28);
            this.cmbSchedZone.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(360, 46);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 26);
            this.dtpDate.TabIndex = 5;
            // 
            // txtCollector
            // 
            this.txtCollector.Location = new System.Drawing.Point(360, 90);
            this.txtCollector.Name = "txtCollector";
            this.txtCollector.Size = new System.Drawing.Size(200, 26);
            this.txtCollector.TabIndex = 6;
            // 
            // btnCreateSchedule
            // 
            this.btnCreateSchedule.Location = new System.Drawing.Point(360, 133);
            this.btnCreateSchedule.Name = "btnCreateSchedule";
            this.btnCreateSchedule.Size = new System.Drawing.Size(191, 32);
            this.btnCreateSchedule.TabIndex = 7;
            this.btnCreateSchedule.Text = "Create Schedule";
            this.btnCreateSchedule.UseVisualStyleBackColor = true;
            this.btnCreateSchedule.Click += new System.EventHandler(this.btnCreateSchedule_Click);
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.pnlLoginArea);
            this.tabLogin.Location = new System.Drawing.Point(4, 29);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(660, 347);
            this.tabLogin.TabIndex = 2;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // pnlLoginArea
            // 
            this.pnlLoginArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLoginArea.Controls.Add(this.lblLoginUser2);
            this.pnlLoginArea.Controls.Add(this.txtLoginUsername);
            this.pnlLoginArea.Controls.Add(this.lblLoginPass2);
            this.pnlLoginArea.Controls.Add(this.txtLoginPassword);
            this.pnlLoginArea.Location = new System.Drawing.Point(180, 20);
            this.pnlLoginArea.Name = "pnlLoginArea";
            this.pnlLoginArea.Size = new System.Drawing.Size(320, 130);
            this.pnlLoginArea.TabIndex = 0;
            // 
            // lblLoginUser2
            // 
            this.lblLoginUser2.AutoSize = true;
            this.lblLoginUser2.Location = new System.Drawing.Point(10, 10);
            this.lblLoginUser2.Name = "lblLoginUser2";
            this.lblLoginUser2.Size = new System.Drawing.Size(87, 20);
            this.lblLoginUser2.TabIndex = 0;
            this.lblLoginUser2.Text = "Username:";
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Location = new System.Drawing.Point(100, 6);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(200, 26);
            this.txtLoginUsername.TabIndex = 1;
            // 
            // lblLoginPass2
            // 
            this.lblLoginPass2.AutoSize = true;
            this.lblLoginPass2.Location = new System.Drawing.Point(10, 46);
            this.lblLoginPass2.Name = "lblLoginPass2";
            this.lblLoginPass2.Size = new System.Drawing.Size(82, 20);
            this.lblLoginPass2.TabIndex = 2;
            this.lblLoginPass2.Text = "Password:";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(100, 42);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(200, 26);
            this.txtLoginPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(480, 90);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Visible = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tabResident
            // 
            this.tabResident.Controls.Add(this.lblResWelcome);
            this.tabResident.Controls.Add(this.lblResNextScheduleEnglish);
            this.tabResident.Controls.Add(this.lblResNextScheduleLuganda);
            this.tabResident.Controls.Add(this.lblThankYouEnglish);
            this.tabResident.Controls.Add(this.lblThankYouLuganda);
            this.tabResident.Controls.Add(this.btnSignIn);
            this.tabResident.Location = new System.Drawing.Point(4, 29);
            this.tabResident.Name = "tabResident";
            this.tabResident.Padding = new System.Windows.Forms.Padding(3);
            this.tabResident.Size = new System.Drawing.Size(660, 347);
            this.tabResident.TabIndex = 3;
            this.tabResident.Text = "Resident";
            this.tabResident.UseVisualStyleBackColor = true;
            // 
            // lblResWelcome
            // 
            this.lblResWelcome.AutoSize = true;
            this.lblResWelcome.Location = new System.Drawing.Point(10, 10);
            this.lblResWelcome.Name = "lblResWelcome";
            this.lblResWelcome.Size = new System.Drawing.Size(133, 20);
            this.lblResWelcome.TabIndex = 0;
            this.lblResWelcome.Text = "Welcome, [Name]";
            // 
            // lblResNextScheduleEnglish
            // 
            this.lblResNextScheduleEnglish.AutoSize = true;
            this.lblResNextScheduleEnglish.Location = new System.Drawing.Point(10, 40);
            this.lblResNextScheduleEnglish.Name = "lblResNextScheduleEnglish";
            this.lblResNextScheduleEnglish.Size = new System.Drawing.Size(248, 20);
            this.lblResNextScheduleEnglish.TabIndex = 1;
            this.lblResNextScheduleEnglish.Text = "Next collection: [English message]";
            // 
            // lblResNextScheduleLuganda
            // 
            this.lblResNextScheduleLuganda.AutoSize = true;
            this.lblResNextScheduleLuganda.Location = new System.Drawing.Point(10, 64);
            this.lblResNextScheduleLuganda.Name = "lblResNextScheduleLuganda";
            this.lblResNextScheduleLuganda.Size = new System.Drawing.Size(259, 20);
            this.lblResNextScheduleLuganda.TabIndex = 2;
            this.lblResNextScheduleLuganda.Text = "Next collection: [Luganda message]";
            // 
            // lblThankYouEnglish
            // 
            this.lblThankYouEnglish.AutoSize = true;
            this.lblThankYouEnglish.Location = new System.Drawing.Point(10, 100);
            this.lblThankYouEnglish.Name = "lblThankYouEnglish";
            this.lblThankYouEnglish.Size = new System.Drawing.Size(310, 20);
            this.lblThankYouEnglish.TabIndex = 3;
            this.lblThankYouEnglish.Text = "Thank you for being collaborative. (English)";
            // 
            // lblThankYouLuganda
            // 
            this.lblThankYouLuganda.AutoSize = true;
            this.lblThankYouLuganda.Location = new System.Drawing.Point(10, 124);
            this.lblThankYouLuganda.Name = "lblThankYouLuganda";
            this.lblThankYouLuganda.Size = new System.Drawing.Size(321, 20);
            this.lblThankYouLuganda.TabIndex = 4;
            this.lblThankYouLuganda.Text = "webale kukolagana naffe";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(10, 150);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(120, 28);
            this.btnSignIn.TabIndex = 40;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.lblTotalResidentsTitle);
            this.tabDashboard.Controls.Add(this.lblTotalResidentsValue);
            this.tabDashboard.Controls.Add(this.lblTotalCollectorsTitle);
            this.tabDashboard.Controls.Add(this.lblTotalCollectorsValue);
            this.tabDashboard.Controls.Add(this.lblUpcomingSchedulesTitle);
            this.tabDashboard.Controls.Add(this.lblUpcomingSchedulesValue);
            this.tabDashboard.Controls.Add(this.lblTotalCollectionsTitle);
            this.tabDashboard.Controls.Add(this.lblTotalCollectionsValue);
            this.tabDashboard.Controls.Add(this.lblRecentCollectionsTitle);
            this.tabDashboard.Controls.Add(this.dgvRecentCollections);
            this.tabDashboard.Controls.Add(this.lblSystemInfo);
            this.tabDashboard.Controls.Add(this.dgvSignIns);
            this.tabDashboard.Controls.Add(this.cmbAdminZone);
            this.tabDashboard.Controls.Add(this.btnViewAssigned);
            this.tabDashboard.Location = new System.Drawing.Point(4, 29);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(660, 347);
            this.tabDashboard.TabIndex = 1;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // lblTotalResidentsTitle
            // 
            this.lblTotalResidentsTitle.AutoSize = true;
            this.lblTotalResidentsTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTotalResidentsTitle.Name = "lblTotalResidentsTitle";
            this.lblTotalResidentsTitle.Size = new System.Drawing.Size(124, 20);
            this.lblTotalResidentsTitle.TabIndex = 10;
            this.lblTotalResidentsTitle.Text = "Total Residents:";
            // 
            // lblTotalResidentsValue
            // 
            this.lblTotalResidentsValue.AutoSize = true;
            this.lblTotalResidentsValue.Location = new System.Drawing.Point(140, 10);
            this.lblTotalResidentsValue.Name = "lblTotalResidentsValue";
            this.lblTotalResidentsValue.Size = new System.Drawing.Size(18, 20);
            this.lblTotalResidentsValue.TabIndex = 11;
            this.lblTotalResidentsValue.Text = "0";
            // 
            // lblTotalCollectorsTitle
            // 
            this.lblTotalCollectorsTitle.AutoSize = true;
            this.lblTotalCollectorsTitle.Location = new System.Drawing.Point(10, 40);
            this.lblTotalCollectorsTitle.Name = "lblTotalCollectorsTitle";
            this.lblTotalCollectorsTitle.Size = new System.Drawing.Size(122, 20);
            this.lblTotalCollectorsTitle.TabIndex = 12;
            this.lblTotalCollectorsTitle.Text = "Total Collectors:";
            // 
            // lblTotalCollectorsValue
            // 
            this.lblTotalCollectorsValue.AutoSize = true;
            this.lblTotalCollectorsValue.Location = new System.Drawing.Point(140, 40);
            this.lblTotalCollectorsValue.Name = "lblTotalCollectorsValue";
            this.lblTotalCollectorsValue.Size = new System.Drawing.Size(18, 20);
            this.lblTotalCollectorsValue.TabIndex = 13;
            this.lblTotalCollectorsValue.Text = "0";
            // 
            // lblUpcomingSchedulesTitle
            // 
            this.lblUpcomingSchedulesTitle.AutoSize = true;
            this.lblUpcomingSchedulesTitle.Location = new System.Drawing.Point(10, 70);
            this.lblUpcomingSchedulesTitle.Name = "lblUpcomingSchedulesTitle";
            this.lblUpcomingSchedulesTitle.Size = new System.Drawing.Size(164, 20);
            this.lblUpcomingSchedulesTitle.TabIndex = 14;
            this.lblUpcomingSchedulesTitle.Text = "Upcoming Schedules:";
            // 
            // lblUpcomingSchedulesValue
            // 
            this.lblUpcomingSchedulesValue.AutoSize = true;
            this.lblUpcomingSchedulesValue.Location = new System.Drawing.Point(140, 70);
            this.lblUpcomingSchedulesValue.Name = "lblUpcomingSchedulesValue";
            this.lblUpcomingSchedulesValue.Size = new System.Drawing.Size(18, 20);
            this.lblUpcomingSchedulesValue.TabIndex = 15;
            this.lblUpcomingSchedulesValue.Text = "0";
            // 
            // lblTotalCollectionsTitle
            // 
            this.lblTotalCollectionsTitle.AutoSize = true;
            this.lblTotalCollectionsTitle.Location = new System.Drawing.Point(10, 100);
            this.lblTotalCollectionsTitle.Name = "lblTotalCollectionsTitle";
            this.lblTotalCollectionsTitle.Size = new System.Drawing.Size(129, 20);
            this.lblTotalCollectionsTitle.TabIndex = 16;
            this.lblTotalCollectionsTitle.Text = "Total Collections:";
            // 
            // lblTotalCollectionsValue
            // 
            this.lblTotalCollectionsValue.AutoSize = true;
            this.lblTotalCollectionsValue.Location = new System.Drawing.Point(140, 100);
            this.lblTotalCollectionsValue.Name = "lblTotalCollectionsValue";
            this.lblTotalCollectionsValue.Size = new System.Drawing.Size(18, 20);
            this.lblTotalCollectionsValue.TabIndex = 17;
            this.lblTotalCollectionsValue.Text = "0";
            // 
            // lblRecentCollectionsTitle
            // 
            this.lblRecentCollectionsTitle.AutoSize = true;
            this.lblRecentCollectionsTitle.Location = new System.Drawing.Point(320, 10);
            this.lblRecentCollectionsTitle.Name = "lblRecentCollectionsTitle";
            this.lblRecentCollectionsTitle.Size = new System.Drawing.Size(146, 20);
            this.lblRecentCollectionsTitle.TabIndex = 18;
            this.lblRecentCollectionsTitle.Text = "Recent Collections:";
            // 
            // dgvRecentCollections
            // 
            this.dgvRecentCollections.ColumnHeadersHeight = 34;
            this.dgvRecentCollections.Location = new System.Drawing.Point(320, 30);
            this.dgvRecentCollections.Name = "dgvRecentCollections";
            this.dgvRecentCollections.RowHeadersWidth = 62;
            this.dgvRecentCollections.Size = new System.Drawing.Size(320, 180);
            this.dgvRecentCollections.TabIndex = 19;
            // 
            // lblSystemInfo
            // 
            this.lblSystemInfo.AutoSize = true;
            this.lblSystemInfo.Location = new System.Drawing.Point(6, 100);
            this.lblSystemInfo.Name = "lblSystemInfo";
            this.lblSystemInfo.Size = new System.Drawing.Size(98, 20);
            this.lblSystemInfo.TabIndex = 20;
            this.lblSystemInfo.Text = "System Info:";
            // 
            // dgvSignIns
            // 
            this.dgvSignIns.ColumnHeadersHeight = 34;
            this.dgvSignIns.Location = new System.Drawing.Point(320, 220);
            this.dgvSignIns.Name = "dgvSignIns";
            this.dgvSignIns.RowHeadersWidth = 62;
            this.dgvSignIns.Size = new System.Drawing.Size(320, 120);
            this.dgvSignIns.TabIndex = 41;
            // 
            // cmbAdminZone
            // 
            this.cmbAdminZone.Location = new System.Drawing.Point(10, 220);
            this.cmbAdminZone.Name = "cmbAdminZone";
            this.cmbAdminZone.Size = new System.Drawing.Size(200, 28);
            this.cmbAdminZone.TabIndex = 42;
            // 
            // btnViewAssigned
            // 
            this.btnViewAssigned.Location = new System.Drawing.Point(220, 218);
            this.btnViewAssigned.Name = "btnViewAssigned";
            this.btnViewAssigned.Size = new System.Drawing.Size(80, 24);
            this.btnViewAssigned.TabIndex = 43;
            this.btnViewAssigned.Text = "View";
            this.btnViewAssigned.UseVisualStyleBackColor = true;
            this.btnViewAssigned.Click += new System.EventHandler(this.btnViewAssigned_Click);
            // 
            // lblLoginUsername
            // 
            this.lblLoginUsername.AutoSize = true;
            this.lblLoginUsername.Location = new System.Drawing.Point(420, 15);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(87, 20);
            this.lblLoginUsername.TabIndex = 2;
            this.lblLoginUsername.Text = "Username:";
            this.lblLoginUsername.Visible = false;
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Location = new System.Drawing.Point(420, 41);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(82, 20);
            this.lblLoginPassword.TabIndex = 3;
            this.lblLoginPassword.Text = "Password:";
            this.lblLoginPassword.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblLoginUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.dgvResidents);
            this.Name = "Form1";
            this.Text = "Ndejje Waste Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResidents)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            this.pnlRegisterArea.ResumeLayout(false);
            this.pnlRegisterArea.PerformLayout();
            this.tabLogin.ResumeLayout(false);
            this.pnlLoginArea.ResumeLayout(false);
            this.pnlLoginArea.PerformLayout();
            this.tabResident.ResumeLayout(false);
            this.tabResident.PerformLayout();
            this.tabDashboard.ResumeLayout(false);
            this.tabDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentCollections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSignIns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

