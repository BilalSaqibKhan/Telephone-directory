using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;
using System.Net.Mail;
using System.Net.Mime;

//By Bilal saqib khan

namespace SplashScreen
{
    public partial class frmLogin : Form
    { 
        public frmLogin()
        {
            InitializeComponent();
            this.ActiveControl = txtUserName_login;
    }
    
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string code;
        //Random code generator STARTS
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        //Random code generator ENDS
        private void timer1_Tick(object sender, EventArgs e)
        {
            code = null;
            lblMessage_VerifyNewAccount.Text = null;
            lblErrorMessage_VerifyNewAccount.Text = "Verification code expired, click on resend code";
            lblVerify.Text = null;
        }

        

// Email Verification
        private void btnResendCode_Click(object sender, EventArgs e)
        {
            try
            {
                timer1_Tick(sender, e);
                code=RandomString(5);
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 20000;
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("#Gmail Address Here", "#Password Here");
                MailMessage msg = new MailMessage();
                msg.To.Add(txtEmail_signup.Text);
                msg.From = new MailAddress("#Gmail Address Here");
                msg.Subject = "User account authentication Datalink-x enterprise telephone directory system";
                msg.Body = "Software verification code: " + Environment.NewLine + code;
                client.Send(msg);

                lblErrorMessage_VerifyNewAccount.Text = null;
                lblMessage_VerifyNewAccount.Text = "Verification code has been sent to your e-mail address";
                con.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                lblMessage_signup.Text = null;
                lblErrorMessage_signup.Text = "Connection error";
                con.Close();
            }
            lblVerify.Text = "Open and check your e-mail again";
            lblErrorMessage_VerifyNewAccount.Text = null;
            lblMessage_VerifyNewAccount.Text = "Verification code has been sent to your e-mail address";
        }

        //Mouse click event coding STARTS
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
            lblHeading.Text = "Sign up";
            btnBack.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
            lblHeading.Text = "Login";
            btnBack.Visible = false;
        }

        private void lblForget_Click(object sender, EventArgs e)
        {
            btnSendCode.Visible = true;
            lblVerification.Visible = true;
            txtForget.Visible = true;
            btnVerify.Visible = true;
        }
        //Mouse click event coding ENDS

        //********************Database programming*********************
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=FUTURE-ENVISION\SQLEXPRESS;Initial Catalog=db_datalinkx;Integrated Security=True";
            con.Open();

            if (txtUserName_signup.Text == "" || txtPassword_signup.Text == "" || txtRetypePassword_signup.Text == "" || txtEmail_signup.Text == "")
            {
                lblMessage_signup.Text = null;
                lblErrorMessage_signup.Text = "All fields are required";
                con.Close();
            }
            else
            {
                if (txtPassword_signup.Text == txtRetypePassword_signup.Text)
                {
                    SqlCommand c = new SqlCommand("Select [Email] from [tbl_login] where [Email] = '" + txtEmail_signup.Text + "'", con);
                    c.Connection = con;
                    SqlDataReader dr;
                    dr = c.ExecuteReader();
                    if (dr.HasRows)
                    {
                        lblMessage_signup.Text = null;
                        lblErrorMessage_signup.Text = "This Email is already registered";
                        dr.Close();
                        con.Close();
                    }
                    else
                    {
                        tabControl.SelectedIndex = 2;
                        lblHeading.Text = "Verify";

                        timer1_Tick(sender, e);
                        code = RandomString(5);

                        try
                        {
                                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                                client.EnableSsl = true;
                                client.Timeout = 20000;
                                client.EnableSsl = true;
                                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                                client.UseDefaultCredentials = false;
                                client.Credentials = new System.Net.NetworkCredential("bilalsaqib.khan@gmail.com", "lotrbfme2");
                                MailMessage msg = new MailMessage();
                                msg.To.Add(txtEmail_signup.Text);
                                msg.From = new MailAddress("bilalsaqib.khan@gmail.com");
                                msg.Subject = "User account authentication Datalink-x enterprise telephone directory system";
                                msg.Body = "Software verification code: "+Environment.NewLine+ code;
                                client.Send(msg);

                                lblErrorMessage_VerifyNewAccount.Text = null;
                                lblMessage_VerifyNewAccount.Text = "Verification code has been sent to your e-mail address";
                                con.Close();
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show(ex.ToString());
                            lblMessage_signup.Text = null;
                            lblErrorMessage_signup.Text = "Connection error";
                            con.Close();

                            tabControl.SelectedIndex = 1;
                            lblHeading.Text = "Signup";

                        }
                    }
                }
                else
                {
                    lblMessage_signup.Text = null;
                    lblErrorMessage_signup.Text = "Password didn't matched please check the password";
                    con.Close();
                }
            }
        }

        private void btnVerify_verifyNewAccount_Click(object sender, EventArgs e)
        {
            if (txtVerifyNewAccount_verifyNewAccount.Text == code)
            {
                con.ConnectionString = @"Data Source=FUTURE-ENVISION\SQLEXPRESS;Initial Catalog=db_datalinkx;Integrated Security=True";
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into [tbl_login] values ('" + txtUserName_signup.Text + "', '" + txtPassword_signup.Text + "', '" + txtEmail_signup.Text + "')", con);
                cmd.ExecuteNonQuery();
                lblErrorMessage_login.Text = null;

                tabControl.SelectedIndex = 0;
                lblHeading.Text = "Login";

                lblErrorMessage_login.Text = null;
                lblMessage_login.Text = "Congratulations! account successfully created";
                con.Close();

                txtUserName_signup.Text = null;
                txtPassword_signup.Text = null;
                txtRetypePassword_signup.Text = null;
                txtEmail_signup.Text = null;
            }
            else
            {
                lblMessage_VerifyNewAccount.Text = null;
                lblErrorMessage_VerifyNewAccount.Text = "Invalid code";
                con.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName_login.Text == "" || txtPassword_login.Text == "")
            {
                lblMessage_login.Text = null;
                lblErrorMessage_login.Text = "All fields are required";
            }
            else
            {
                con.ConnectionString = @"Data Source=FUTURE-ENVISION\SQLEXPRESS;Initial Catalog=db_datalinkx;Integrated Security=True";
                con.Open();
                SqlCommand cmd = new SqlCommand("Select [UserName], [Password] from [tbl_login] where [UserName] = '" + txtUserName_login.Text + "' AND [Password] = '"+ txtPassword_login.Text +"'", con);
                cmd.Connection = con;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    con.Close();
                    frmSplash obj = new frmSplash(txtUserName_login.Text, txtPassword_login.Text);
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    lblMessage_login.Text = null;
                    lblErrorMessage_login.Text = "Incorrect Username or password";
                    con.Close();
                }
            }
        }
        //*******************Database programming ENDS***********************

        //Mouse hover event coding STARTS
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Black;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Teal;
            btnLogin.ForeColor = Color.Black;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Black;
            btnLogin.ForeColor = Color.White;
        }

        private void btnSignup_MouseEnter(object sender, EventArgs e)
        {
            btnSignup.BackColor = Color.Teal;
            btnSignup.ForeColor = Color.Black;
        }

        private void btnSignup_MouseLeave(object sender, EventArgs e)
        {
            btnSignup.BackColor = Color.Black;
            btnSignup.ForeColor = Color.White;
        }

        private void btnCreateAccount_MouseEnter(object sender, EventArgs e)
        {
            btnCreateAccount.BackColor = Color.Teal;
            btnCreateAccount.ForeColor = Color.Black;
        }

        private void btnCreateAccount_MouseLeave(object sender, EventArgs e)
        {
            btnCreateAccount.BackColor = Color.Black;
            btnCreateAccount.ForeColor = Color.White;
        }

        private void btnVerify_MouseEnter(object sender, EventArgs e)
        {
            btnVerify.BackColor = Color.Teal;
            btnVerify.ForeColor = Color.Black;
        }

        private void btnVerify_MouseLeave(object sender, EventArgs e)
        {
            btnVerify.BackColor = Color.Black;
            btnVerify.ForeColor = Color.White;
        }

        //Mouse hover event coding ENDS

        //Keyboard enter key coding STARTS
        private void txtUserName_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword_login.Focus();
            }
        }

        private void txtPassword_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
        //Keyboard enter key coding ENDS

        
    }
}
