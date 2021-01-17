namespace SplashScreen
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.lblVerification = new System.Windows.Forms.Label();
            this.txtForget = new System.Windows.Forms.TextBox();
            this.lblForget = new System.Windows.Forms.Label();
            this.lblMessage_login = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblErrorMessage_login = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName_login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabSignup = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail_signup = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRetypePassword_signup = new System.Windows.Forms.TextBox();
            this.lblMessage_signup = new System.Windows.Forms.Label();
            this.lblErrorMessage_signup = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword_signup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserName_signup = new System.Windows.Forms.TextBox();
            this.tabVerifyNewAccount = new System.Windows.Forms.TabPage();
            this.lblMessage_VerifyNewAccount = new System.Windows.Forms.Label();
            this.lblErrorMessage_VerifyNewAccount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblVerify = new System.Windows.Forms.Label();
            this.btnResendCode = new System.Windows.Forms.Button();
            this.btnVerify_verifyNewAccount = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVerifyNewAccount_verifyNewAccount = new System.Windows.Forms.TextBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabSignup.SuspendLayout();
            this.tabVerifyNewAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabLogin);
            this.tabControl.Controls.Add(this.tabSignup);
            this.tabControl.Controls.Add(this.tabVerifyNewAccount);
            this.tabControl.Location = new System.Drawing.Point(-8, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(558, 543);
            this.tabControl.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tabLogin.Controls.Add(this.btnSendCode);
            this.tabLogin.Controls.Add(this.btnVerify);
            this.tabLogin.Controls.Add(this.lblVerification);
            this.tabLogin.Controls.Add(this.txtForget);
            this.tabLogin.Controls.Add(this.lblForget);
            this.tabLogin.Controls.Add(this.lblMessage_login);
            this.tabLogin.Controls.Add(this.btnSignup);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.lblErrorMessage_login);
            this.tabLogin.Controls.Add(this.label3);
            this.tabLogin.Controls.Add(this.txtPassword_login);
            this.tabLogin.Controls.Add(this.label2);
            this.tabLogin.Controls.Add(this.txtUserName_login);
            this.tabLogin.Controls.Add(this.label4);
            this.tabLogin.Location = new System.Drawing.Point(4, 25);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(550, 514);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            // 
            // btnSendCode
            // 
            this.btnSendCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.btnSendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.Location = new System.Drawing.Point(34, 317);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(127, 24);
            this.btnSendCode.TabIndex = 51;
            this.btnSendCode.Text = "Send code";
            this.btnSendCode.UseVisualStyleBackColor = false;
            this.btnSendCode.Visible = false;
            
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.Black;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Location = new System.Drawing.Point(418, 346);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(100, 27);
            this.btnVerify.TabIndex = 50;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Visible = false;
            this.btnVerify.MouseEnter += new System.EventHandler(this.btnVerify_MouseEnter);
            this.btnVerify.MouseLeave += new System.EventHandler(this.btnVerify_MouseLeave);
            // 
            // lblVerification
            // 
            this.lblVerification.AutoSize = true;
            this.lblVerification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerification.Location = new System.Drawing.Point(30, 350);
            this.lblVerification.Name = "lblVerification";
            this.lblVerification.Size = new System.Drawing.Size(131, 20);
            this.lblVerification.TabIndex = 49;
            this.lblVerification.Text = "Verification code:";
            this.lblVerification.Visible = false;
            // 
            // txtForget
            // 
            this.txtForget.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtForget.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForget.Location = new System.Drawing.Point(162, 351);
            this.txtForget.Name = "txtForget";
            this.txtForget.Size = new System.Drawing.Size(248, 17);
            this.txtForget.TabIndex = 48;
            this.txtForget.Visible = false;
            // 
            // lblForget
            // 
            this.lblForget.AutoSize = true;
            this.lblForget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForget.ForeColor = System.Drawing.Color.Gray;
            this.lblForget.Location = new System.Drawing.Point(201, 292);
            this.lblForget.Name = "lblForget";
            this.lblForget.Size = new System.Drawing.Size(144, 15);
            this.lblForget.TabIndex = 47;
            this.lblForget.Text = "Forgottten your password";
            this.lblForget.Click += new System.EventHandler(this.lblForget_Click);
            // 
            // lblMessage_login
            // 
            this.lblMessage_login.AutoSize = true;
            this.lblMessage_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage_login.ForeColor = System.Drawing.Color.Lime;
            this.lblMessage_login.Location = new System.Drawing.Point(34, 399);
            this.lblMessage_login.Name = "lblMessage_login";
            this.lblMessage_login.Size = new System.Drawing.Size(22, 13);
            this.lblMessage_login.TabIndex = 42;
            this.lblMessage_login.Text = "     ";
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.Black;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.Location = new System.Drawing.Point(94, 239);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(344, 29);
            this.btnSignup.TabIndex = 41;
            this.btnSignup.Text = "Sign up";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            this.btnSignup.MouseEnter += new System.EventHandler(this.btnSignup_MouseEnter);
            this.btnSignup.MouseLeave += new System.EventHandler(this.btnSignup_MouseLeave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(94, 204);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(344, 29);
            this.btnLogin.TabIndex = 40;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // lblErrorMessage_login
            // 
            this.lblErrorMessage_login.AutoSize = true;
            this.lblErrorMessage_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage_login.ForeColor = System.Drawing.Color.Gold;
            this.lblErrorMessage_login.Location = new System.Drawing.Point(14, 399);
            this.lblErrorMessage_login.Name = "lblErrorMessage_login";
            this.lblErrorMessage_login.Size = new System.Drawing.Size(13, 13);
            this.lblErrorMessage_login.TabIndex = 39;
            this.lblErrorMessage_login.Text = "  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Password:";
            // 
            // txtPassword_login
            // 
            this.txtPassword_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword_login.Location = new System.Drawing.Point(189, 158);
            this.txtPassword_login.Name = "txtPassword_login";
            this.txtPassword_login.PasswordChar = '#';
            this.txtPassword_login.Size = new System.Drawing.Size(248, 17);
            this.txtPassword_login.TabIndex = 37;
            this.txtPassword_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_login_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "User name:";
            // 
            // txtUserName_login
            // 
            this.txtUserName_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName_login.Location = new System.Drawing.Point(189, 116);
            this.txtUserName_login.Name = "txtUserName_login";
            this.txtUserName_login.Size = new System.Drawing.Size(248, 17);
            this.txtUserName_login.TabIndex = 35;
            this.txtUserName_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_login_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(406, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "DataLink-X Enterprise v1.2";
            // 
            // tabSignup
            // 
            this.tabSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tabSignup.Controls.Add(this.label7);
            this.tabSignup.Controls.Add(this.txtEmail_signup);
            this.tabSignup.Controls.Add(this.label6);
            this.tabSignup.Controls.Add(this.label9);
            this.tabSignup.Controls.Add(this.txtRetypePassword_signup);
            this.tabSignup.Controls.Add(this.lblMessage_signup);
            this.tabSignup.Controls.Add(this.lblErrorMessage_signup);
            this.tabSignup.Controls.Add(this.label8);
            this.tabSignup.Controls.Add(this.btnCreateAccount);
            this.tabSignup.Controls.Add(this.label1);
            this.tabSignup.Controls.Add(this.txtPassword_signup);
            this.tabSignup.Controls.Add(this.label5);
            this.tabSignup.Controls.Add(this.txtUserName_signup);
            this.tabSignup.Location = new System.Drawing.Point(4, 25);
            this.tabSignup.Name = "tabSignup";
            this.tabSignup.Padding = new System.Windows.Forms.Padding(3);
            this.tabSignup.Size = new System.Drawing.Size(550, 514);
            this.tabSignup.TabIndex = 1;
            this.tabSignup.Text = "Signup";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "E-mail address:";
            // 
            // txtEmail_signup
            // 
            this.txtEmail_signup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail_signup.Location = new System.Drawing.Point(205, 182);
            this.txtEmail_signup.Name = "txtEmail_signup";
            this.txtEmail_signup.Size = new System.Drawing.Size(248, 17);
            this.txtEmail_signup.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(151, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Don\'t have any account yet? Create one it\'s easy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Retype password:";
            // 
            // txtRetypePassword_signup
            // 
            this.txtRetypePassword_signup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRetypePassword_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetypePassword_signup.Location = new System.Drawing.Point(205, 268);
            this.txtRetypePassword_signup.Name = "txtRetypePassword_signup";
            this.txtRetypePassword_signup.PasswordChar = '#';
            this.txtRetypePassword_signup.Size = new System.Drawing.Size(248, 17);
            this.txtRetypePassword_signup.TabIndex = 50;
            // 
            // lblMessage_signup
            // 
            this.lblMessage_signup.AutoSize = true;
            this.lblMessage_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage_signup.ForeColor = System.Drawing.Color.Lime;
            this.lblMessage_signup.Location = new System.Drawing.Point(34, 399);
            this.lblMessage_signup.Name = "lblMessage_signup";
            this.lblMessage_signup.Size = new System.Drawing.Size(31, 13);
            this.lblMessage_signup.TabIndex = 49;
            this.lblMessage_signup.Text = "        ";
            // 
            // lblErrorMessage_signup
            // 
            this.lblErrorMessage_signup.AutoSize = true;
            this.lblErrorMessage_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage_signup.ForeColor = System.Drawing.Color.Gold;
            this.lblErrorMessage_signup.Location = new System.Drawing.Point(14, 399);
            this.lblErrorMessage_signup.Name = "lblErrorMessage_signup";
            this.lblErrorMessage_signup.Size = new System.Drawing.Size(13, 13);
            this.lblErrorMessage_signup.TabIndex = 48;
            this.lblErrorMessage_signup.Text = "  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(406, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "DataLink-X Enterprise v1.2";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.Black;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.Location = new System.Drawing.Point(94, 323);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(344, 29);
            this.btnCreateAccount.TabIndex = 46;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            this.btnCreateAccount.MouseEnter += new System.EventHandler(this.btnCreateAccount_MouseEnter);
            this.btnCreateAccount.MouseLeave += new System.EventHandler(this.btnCreateAccount_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Password:";
            // 
            // txtPassword_signup
            // 
            this.txtPassword_signup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword_signup.Location = new System.Drawing.Point(205, 232);
            this.txtPassword_signup.Name = "txtPassword_signup";
            this.txtPassword_signup.PasswordChar = '#';
            this.txtPassword_signup.Size = new System.Drawing.Size(248, 17);
            this.txtPassword_signup.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "User name:";
            // 
            // txtUserName_signup
            // 
            this.txtUserName_signup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName_signup.Location = new System.Drawing.Point(205, 146);
            this.txtUserName_signup.Name = "txtUserName_signup";
            this.txtUserName_signup.Size = new System.Drawing.Size(248, 17);
            this.txtUserName_signup.TabIndex = 42;
            // 
            // tabVerifyNewAccount
            // 
            this.tabVerifyNewAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tabVerifyNewAccount.Controls.Add(this.lblMessage_VerifyNewAccount);
            this.tabVerifyNewAccount.Controls.Add(this.lblErrorMessage_VerifyNewAccount);
            this.tabVerifyNewAccount.Controls.Add(this.label13);
            this.tabVerifyNewAccount.Controls.Add(this.lblVerify);
            this.tabVerifyNewAccount.Controls.Add(this.btnResendCode);
            this.tabVerifyNewAccount.Controls.Add(this.btnVerify_verifyNewAccount);
            this.tabVerifyNewAccount.Controls.Add(this.label10);
            this.tabVerifyNewAccount.Controls.Add(this.txtVerifyNewAccount_verifyNewAccount);
            this.tabVerifyNewAccount.Location = new System.Drawing.Point(4, 25);
            this.tabVerifyNewAccount.Name = "tabVerifyNewAccount";
            this.tabVerifyNewAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabVerifyNewAccount.Size = new System.Drawing.Size(550, 514);
            this.tabVerifyNewAccount.TabIndex = 2;
            this.tabVerifyNewAccount.Text = "Verify Singup";
            // 
            // lblMessage_VerifyNewAccount
            // 
            this.lblMessage_VerifyNewAccount.AutoSize = true;
            this.lblMessage_VerifyNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage_VerifyNewAccount.ForeColor = System.Drawing.Color.Lime;
            this.lblMessage_VerifyNewAccount.Location = new System.Drawing.Point(37, 399);
            this.lblMessage_VerifyNewAccount.Name = "lblMessage_VerifyNewAccount";
            this.lblMessage_VerifyNewAccount.Size = new System.Drawing.Size(13, 13);
            this.lblMessage_VerifyNewAccount.TabIndex = 59;
            this.lblMessage_VerifyNewAccount.Text = "  ";
            // 
            // lblErrorMessage_VerifyNewAccount
            // 
            this.lblErrorMessage_VerifyNewAccount.AutoSize = true;
            this.lblErrorMessage_VerifyNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage_VerifyNewAccount.ForeColor = System.Drawing.Color.Gold;
            this.lblErrorMessage_VerifyNewAccount.Location = new System.Drawing.Point(14, 399);
            this.lblErrorMessage_VerifyNewAccount.Name = "lblErrorMessage_VerifyNewAccount";
            this.lblErrorMessage_VerifyNewAccount.Size = new System.Drawing.Size(13, 13);
            this.lblErrorMessage_VerifyNewAccount.TabIndex = 58;
            this.lblErrorMessage_VerifyNewAccount.Text = "  ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(406, 399);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 13);
            this.label13.TabIndex = 57;
            this.label13.Text = "DataLink-X Enterprise v1.2";
            // 
            // lblVerify
            // 
            this.lblVerify.AutoSize = true;
            this.lblVerify.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerify.ForeColor = System.Drawing.Color.Gray;
            this.lblVerify.Location = new System.Drawing.Point(151, 132);
            this.lblVerify.Name = "lblVerify";
            this.lblVerify.Size = new System.Drawing.Size(231, 15);
            this.lblVerify.TabIndex = 56;
            this.lblVerify.Text = "Login to your account for verification code";
            // 
            // btnResendCode
            // 
            this.btnResendCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(26)))));
            this.btnResendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResendCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResendCode.Location = new System.Drawing.Point(35, 188);
            this.btnResendCode.Name = "btnResendCode";
            this.btnResendCode.Size = new System.Drawing.Size(127, 24);
            this.btnResendCode.TabIndex = 55;
            this.btnResendCode.Text = "Resend code";
            this.btnResendCode.UseVisualStyleBackColor = false;
            this.btnResendCode.Click += new System.EventHandler(this.btnResendCode_Click);
            // 
            // btnVerify_verifyNewAccount
            // 
            this.btnVerify_verifyNewAccount.BackColor = System.Drawing.Color.Black;
            this.btnVerify_verifyNewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerify_verifyNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify_verifyNewAccount.Location = new System.Drawing.Point(419, 219);
            this.btnVerify_verifyNewAccount.Name = "btnVerify_verifyNewAccount";
            this.btnVerify_verifyNewAccount.Size = new System.Drawing.Size(100, 27);
            this.btnVerify_verifyNewAccount.TabIndex = 54;
            this.btnVerify_verifyNewAccount.Text = "Verify";
            this.btnVerify_verifyNewAccount.UseVisualStyleBackColor = false;
            this.btnVerify_verifyNewAccount.Click += new System.EventHandler(this.btnVerify_verifyNewAccount_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 20);
            this.label10.TabIndex = 53;
            this.label10.Text = "Verification code:";
            // 
            // txtVerifyNewAccount_verifyNewAccount
            // 
            this.txtVerifyNewAccount_verifyNewAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVerifyNewAccount_verifyNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerifyNewAccount_verifyNewAccount.Location = new System.Drawing.Point(163, 224);
            this.txtVerifyNewAccount_verifyNewAccount.Name = "txtVerifyNewAccount_verifyNewAccount";
            this.txtVerifyNewAccount_verifyNewAccount.Size = new System.Drawing.Size(248, 17);
            this.txtVerifyNewAccount_verifyNewAccount.TabIndex = 52;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Black;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblHeading.Location = new System.Drawing.Point(211, 24);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(96, 37);
            this.lblHeading.TabIndex = 54;
            this.lblHeading.Text = "Login";
            // 
            // btnMinimize
            // 
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(484, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 31);
            this.btnMinimize.TabIndex = 53;
            this.btnMinimize.Text = "_";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(513, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 31);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "x";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Black;
            this.header.Location = new System.Drawing.Point(-1, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(543, 83);
            this.header.TabIndex = 51;
            this.header.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(39, 34);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 43;
            this.btnBack.TabStop = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.header);
            this.Controls.Add(this.tabControl);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form0";
            this.tabControl.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabSignup.ResumeLayout(false);
            this.tabSignup.PerformLayout();
            this.tabVerifyNewAccount.ResumeLayout(false);
            this.tabVerifyNewAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabSignup;
        private System.Windows.Forms.Label lblMessage_login;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblErrorMessage_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label btnMinimize;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword_signup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserName_signup;
        private System.Windows.Forms.Label lblMessage_signup;
        private System.Windows.Forms.Label lblErrorMessage_signup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRetypePassword_signup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail_signup;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label lblVerification;
        private System.Windows.Forms.TextBox txtForget;
        private System.Windows.Forms.Label lblForget;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.TabPage tabVerifyNewAccount;
        private System.Windows.Forms.Label lblErrorMessage_VerifyNewAccount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnResendCode;
        private System.Windows.Forms.Button btnVerify_verifyNewAccount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVerifyNewAccount_verifyNewAccount;
        private System.Windows.Forms.Label lblMessage_VerifyNewAccount;
        private System.Windows.Forms.Label lblVerify;
        private System.Windows.Forms.Timer timer1;
    }
}