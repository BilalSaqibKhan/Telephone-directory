using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Web;
using System.Net.Mail;
using System.Net.Mime;
using System.Data.SqlClient;

//By Bilal saqib khan

namespace SplashScreen
{
    public partial class frmMain : Form
    {
        //variables
        int TogMove, MvalX, MvalY;
        bool theme = false; //Disables the theme sounds to play on software startup

        string UserName, Password;

        SqlConnection con = new SqlConnection();
        

        public frmMain(string username = "testing mode", string password = "testing mode")
        {
            InitializeComponent();

            UserName = username;
            Password = password;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            con.ConnectionString = @"Data Source=FUTURE-ENVISION\SQLEXPRESS;Initial Catalog=db_datalinkx;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("Select * from [tbl_contacts] where [PersonName] like '%" + txtSearch_search.Text + "%'", con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDisplay_search.DataSource = dt;

            if (!File.Exists(@"C:\file.csv"))
            {
                File.AppendAllText(@"C:\file.csv", "dark");
                rbDark_settings.Checked = true;
            }
            else
            {
                var reader = File.ReadAllLines(@"C:\file.csv");
                if (reader[0] == "dark")
                {
                    rbDark_settings.Checked = true;
                }
                else if (reader[0] == "light")
                {
                    rbLight_settings.Checked = true;
                    rbLight_settings_Click(sender, e);
                }
                else if (reader[0] == "epic")
                {
                    rbEpic_settings.Checked = true;
                    rbEpic_settings_Click(sender, e);
                }
                else
                {
                    rbFutureenvision_settings.Checked = true;
                    rbFutureenvision_settings_Click(sender, e);
                }
            }
            lblDate_search.Text = DateTime.Now.ToLongDateString();
            lblUsername_search.Text = "USER: " + UserName.ToUpper();
            lblUsername_add.Text = "USER: " + UserName.ToUpper();
            lblUsername_delete.Text = "USER: " + UserName.ToUpper();
            lblUsername_update.Text = "USER: " + UserName.ToUpper();
            lblUsername_settings.Text = "USER: " + UserName.ToUpper();
            lblUsername_help.Text = "USER: " + UserName.ToUpper();

            //Initializining dropdowns
            cboDepartment_add.Items.Add("Computer Science");
            cboDepartment_add.Items.Add("Computer Engineering");
            cboDepartment_add.Items.Add("Software Engineering");
            cboDepartment_add.Items.Add("Electronics");
            cboDepartment_add.Items.Add("Information Technology");
            cboDepartment_add.Items.Add("Telecom Engineering");
            cboDepartment_add.Items.Add("Mathematics");
            cboDepartment_add.Items.Add("Admin");

            cboDepartment_update.Items.Add("Computer Science");
            cboDepartment_update.Items.Add("Computer Engineering");
            cboDepartment_update.Items.Add("Software Engineering");
            cboDepartment_update.Items.Add("Electronics");
            cboDepartment_update.Items.Add("Information Technology");
            cboDepartment_update.Items.Add("Telecom Engineering");
            cboDepartment_update.Items.Add("Mathematics");
            cboDepartment_update.Items.Add("Admin");

            this.ActiveControl = txtSearch_search;

            //formating grid view colum widths
            dgvDisplay_search.Columns[0].Width = 50;
            dgvDisplay_search.Columns[1].Width = 220;
            dgvDisplay_search.Columns[2].Width = 130;
            dgvDisplay_search.Columns[3].Width = 90;
            dgvDisplay_search.Columns[4].Width = 200;
            dgvDisplay_search.Columns[5].Width = 220;
            dgvDisplay_search.Columns[6].Width = 70;
            dgvDisplay_search.Columns[7].Width = 155;
            dgvDisplay_search.RowHeadersWidth = 25;
        }

        //this code works to drag the form STARTS
        private void header1_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MvalX = e.X;
            MvalY = e.Y;
        }

        private void header1_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void header1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MvalX, MousePosition.Y - MvalY);
            }
        }
        //Drag form code ENDS

        //Checkboxes STARTS
        private void cboDepartment_add_TextChanged(object sender, EventArgs e)
        {
            if (cboDepartment_add.Text == "Admin")
            {
                cboDesignation_add.Text = null;
                cboDesignation_add.Items.Clear();

                cboDesignation_add.Items.Add("HR Manager");
                cboDesignation_add.Items.Add("Marketing Manager");
                cboDesignation_add.Items.Add("Finance Manager");
                cboDesignation_add.Items.Add("Transport Officer");
            }
            else
            {
                cboDesignation_add.Text = null;
                cboDesignation_add.Items.Clear();

                cboDesignation_add.Items.Add("Professor");
                cboDesignation_add.Items.Add("Assistant Professor");
                cboDesignation_add.Items.Add("Chairperson");
            }
        }

        private void cboDepartment_update_TextChanged(object sender, EventArgs e)
        {
            if (cboDepartment_update.Text == "Admin")
            {
                cboDesignation_update.Text = null;
                cboDesignation_update.Items.Clear();

                cboDesignation_update.Items.Add("HR Manager");
                cboDesignation_update.Items.Add("Marketing Manager");
                cboDesignation_update.Items.Add("Finance Manager");
                cboDesignation_update.Items.Add("Transport Officer");
            }
            else
            {
                cboDesignation_update.Text = null;
                cboDesignation_update.Items.Clear();

                cboDesignation_update.Items.Add("Professor");
                cboDesignation_update.Items.Add("Assistant Professor");
                cboDesignation_update.Items.Add("Chairperson");
            }
        }
        //Checkboxes ENDS

        //button click event coding STARTS
        private void btnSearch_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
            lblHeading.Text = "Search Records";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
            lblHeading.Text = "Add Records";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
            lblHeading.Text = "Delete Records";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
            lblHeading.Text = "Update Records";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
            lblHeading.Text = "Settings";
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 5;
            lblHeading.Text = "Help + Support";
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 6;
            lblHeading.Text = "About";
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void lblUrl_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://futureenvision.blogspot.com");
        }

        private void btnCheckUpdate_Click(object sender, EventArgs e)
        {
            lblUpdate.Text = "Software is uptodate";
            lblDateTime_help.Text = "Last checked: " + System.DateTime.Now.ToString();
            lblUpdate.Visible = true;
            lblDateTime_help.Visible = true;
        }
        //button click event coding ends

        //********************Database Programming ************************************
        private void txtSearch_search_TextChanged(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=FUTURE-ENVISION\SQLEXPRESS;Initial Catalog=db_datalinkx;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("Select * from [tbl_contacts] where [PersonName] like '%" + txtSearch_search.Text + "%'", con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDisplay_search.DataSource = dt;
        }

        private void txtDepartment_search_TextChanged(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=FUTURE-ENVISION\SQLEXPRESS;Initial Catalog=db_datalinkx;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("Select * from [tbl_contacts] where [Department] like '%" + txtDepartment_search.Text + "%'", con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDisplay_search.DataSource = dt;
        }

        private void btnAdd_add_Click(object sender, EventArgs e)
        {
            if (txtName_add.Text == "" || txtPhone_add.Text == "" || txtExtension_add.Text == "" || cboDepartment_add.Text == "" || cboDesignation_add.Text == "" || txtCNIC_add.Text == "" || rbMale_add.Checked == false && rbFemale_add.Checked == false)
            {
                lblMessage_add.Text = null;
                lblErrorMessage_add.Text = "Please fill all fields";
            }
            else
            {
                con.ConnectionString = @"Data Source=FUTURE-ENVISION\SQLEXPRESS;Initial Catalog=db_datalinkx;Integrated Security=True";
                con.Open();
                if(rbMale_add.Checked == true)
                {
                    SqlCommand cmd = new SqlCommand("Insert into [tbl_contacts] values ('" + txtName_add.Text + "', '" + txtPhone_add.Text + "', '" + txtExtension_add.Text + "', '" + cboDesignation_add.Text + "', '" + cboDepartment_add.Text + "', '" + rbMale_add.Text + "', '" + txtCNIC_add.Text + "')", con);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Insert into [tbl_contacts] values ('" + txtName_add.Text + "', '" + txtPhone_add.Text + "', '" + txtExtension_add.Text + "', '" + cboDesignation_add.Text + "', '" + cboDepartment_add.Text + "', '" + rbFemale_add.Text + "', '" + txtCNIC_add.Text + "')", con);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                lblErrorMessage_add.Text = null;
                txtName_add.Text = null;
                txtPhone_add.Text = null;
                txtExtension_add.Text = null;
                txtCNIC_add.Text = null;
                cboDepartment_add.Text = null;
                cboDesignation_add.Text = null;
                lblMessage_add.Text = "Information added successfully!";
            }
        }

        private void btnDelete_delete_Click(object sender, EventArgs e)
        {
            if (txtCNIC_delete.Text == "")
            {
                lblMessage_delete.Text = null;
                lblErrorMessage_delete.Text = "Please fill the CNIC field";
            }
            else
            {
                con.ConnectionString = @"Data Source=FUTURE-ENVISION\SQLEXPRESS;Initial Catalog=db_datalinkx;Integrated Security=True";
                con.Open();

                SqlCommand c = new SqlCommand("Select [CNIC] from [tbl_contacts] where [CNIC] = '"+ txtCNIC_delete.Text +"'", con);
                c.Connection = con;
                SqlDataReader dr;
                dr = c.ExecuteReader();
                if(dr.HasRows)
                {
                    dr.Close();
                    SqlCommand cmd = new SqlCommand("Delete from [tbl_contacts] where [CNIC] = '" + txtCNIC_delete.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    lblErrorMessage_delete.Text = null;
                    lblMessage_delete.Text = "Contact removed successfully";
                    txtCNIC_delete.Text = null;
                    lblinfo_delete.Text = null;
                }
                else
                {
                    lblMessage_delete.Text = null;
                    lblErrorMessage_delete.Text = "Given CNIC dosen't exists";
                    lblinfo_delete.Text = null;
                    con.Close();
                }
            }
        }

        private void txtCNIC_delete_TextChanged(object sender, EventArgs e)
        {
            if (txtCNIC_delete.Text.Count() == 15)
            {
                con.ConnectionString = @"Data Source=FUTURE-ENVISION\SQLEXPRESS;Initial Catalog=db_datalinkx;Integrated Security=True";
                con.Open();

                SqlCommand c = new SqlCommand("Select [PersonName] from [tbl_contacts] where [CNIC] = '" + txtCNIC_delete.Text + "'", con);
                c.Connection = con;

                try
                {
                    lblinfo_delete.Text = "Employee name: " + c.ExecuteScalar().ToString() + "";
                }
                catch(Exception ex)
                {
                    lblinfo_delete.Text = "Person not found!";
                }
                con.Close();
            }
            else
            {
                lblinfo_delete.Text = null;
            }
        }

        private void btnChangePassword_settings_Click(object sender, EventArgs e)
        {
            if(txtCurrentPassword_settings.Text == "" || txtNewPassword_settings.Text == "" || txtRetypePassword_settings.Text == "")
            {
                lblMessage_settings.Text = null;
                lblErrorMessage_settings.Text = "All fields are required";
            }
            else if(txtNewPassword_settings.Text != txtRetypePassword_settings.Text)
            {
                lblMessage_settings.Text = null;
                lblErrorMessage_settings.Text = "New password and retype password did'nt matched";
            }
            else
            {
                    con.ConnectionString = @"Data Source=FUTURE-ENVISION\SQLEXPRESS;Initial Catalog=db_datalinkx;Integrated Security=True";
                    con.Open();

                    SqlCommand cmd = new SqlCommand("Select [UserName], [Password] from [tbl_login] where [UserName] = '" + UserName + "' AND [Password] = '" + txtCurrentPassword_settings.Text + "'", con);
                    cmd.Connection = con;
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Close();
                        SqlCommand c = new SqlCommand("Update [tbl_login] SET [Password] = '"+ txtRetypePassword_settings.Text +"' where [UserName] = '" + UserName + "' AND [Password] = '" + txtCurrentPassword_settings.Text + "'", con);
                        c.Connection = con;
                        c.ExecuteNonQuery();
                        con.Close();

                        txtCurrentPassword_settings.Text = null;
                        txtNewPassword_settings.Text = null;
                        txtRetypePassword_settings.Text = null;

                        lblErrorMessage_settings.Text = null;
                        lblMessage_settings.Text = "User password has been successfully changed";
                    }
                else
                {
                    lblMessage_settings.Text = null;
                    lblErrorMessage_settings.Text = "Current password is incorrect";
                    con.Close();
                }
            }
        }

        private void btnDelete_search_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvDisplay_search.Rows)
            {
                if(row.Selected == true)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value);

                    con.ConnectionString = @"Data Source=FUTURE-ENVISION\SQLEXPRESS;Initial Catalog=db_datalinkx;Integrated Security=True";
                    con.Open();

                    DialogResult dr = MessageBox.Show("Are you sure you want to delete selected record?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                    SqlCommand cmd = new SqlCommand("Delete from [tbl_contacts] where id = '" + id + "'", con);
                    cmd.ExecuteNonQuery();

                    SqlDataAdapter da = new SqlDataAdapter("Select * from [tbl_contacts]", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDisplay_search.DataSource = dt;
                    con.Close();
                    }
                    else{ con.Close(); }

                    
                }
            }
        }

        private void btnUpdate_search_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDisplay_search.Rows)
            {
                if (row.Selected == true)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    string name = row.Cells[1].Value.ToString();
                    string phoneNo = row.Cells[2].Value.ToString();
                    string extNo = row.Cells[3].Value.ToString();
                    string designation = row.Cells[4].Value.ToString();
                    string department = row.Cells[5].Value.ToString();
                    string gender = row.Cells[6].Value.ToString();
                    string cnic = row.Cells[7].Value.ToString();
                   
                   

                    txtid_update.Text = id.ToString();
                    txtName_update.Text = name;
                    txtPhone_update.Text = phoneNo;
                    txtExtension_update.Text = extNo;
                    txtCNIC_update.Text = cnic;
                    
                    if (gender== "Male  ")
                    {
                        rbMale_update.Checked = true;
                        rbFemale_update.Checked = false;
                    }
                    else
                    {
                        rbFemale_update.Checked = true;
                        rbMale_update.Checked = false;
                    }
                    cboDesignation_update.Text = designation;
                    cboDepartment_update.Text = department;
                    btnUpdate_Click(sender, e);
                }
            }
        }

        private void btnUpdate_update_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtName_update.Text == "" || txtPhone_update.Text == "" || txtExtension_update.Text == "" || cboDepartment_update.Text == "" || cboDesignation_update.Text == "" || txtCNIC_update.Text == "" || rbMale_update.Checked == false && rbFemale_update.Checked == false)
                {
                    lblMessage_update.Text = null;
                    lblErrorMessage_update.Text = "Please fill all fields";
                }
                else
                {
                    con.ConnectionString = @"Data Source=FUTURE-ENVISION\SQLEXPRESS;Initial Catalog=db_datalinkx;Integrated Security=True";
                    con.Open();
                    if (rbMale_update.Checked == true)
                    {
                        SqlCommand cmd = new SqlCommand("Update [tbl_contacts] SET [PersonName] = '"+ txtName_update.Text +"', [PhoneNo] = '"+ txtPhone_update.Text +"', [ExtensionNo] = '"+ txtExtension_update.Text +"', [Designation] = '"+ cboDesignation_update.Text +"', [Department] = '"+ cboDepartment_update.Text +"', [Gender] = '"+ rbMale_update.Text +"', [CNIC] = '"+ txtCNIC_update.Text +"' where [id] = '" + Convert.ToInt32(txtid_update.Text) + "'", con);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("Update [tbl_contacts] SET [PersonName] = '" + txtName_update.Text + "', [PhoneNo] = '" + txtPhone_update.Text + "', [ExtensionNo] = '" + txtExtension_update.Text + "', [Designation] = '" + cboDesignation_update.Text + "', [Department] = '" + cboDepartment_update.Text + "', [Gender] = '" + rbFemale_update.Text + "', [CNIC] = '" + txtCNIC_update.Text + "' where [id] = '" + Convert.ToInt32(txtid_update.Text) + "'", con);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                    lblErrorMessage_update.Text = null;
                    txtName_update.Text = null;
                    txtPhone_update.Text = null;
                    txtExtension_update.Text = null;
                    txtCNIC_update.Text = null;
                    cboDepartment_update.Text = null;
                    cboDesignation_update.Text = null;
                    lblMessage_update.Text = "Information updated successfully!";
                }
            }
            catch(Exception ex)
            {
                lblMessage_update.Text = null;
                lblErrorMessage_update.Text = "Please update information through search panel";
                con.Close();
            }
        }
        //*********************Database Programming ENDS *********************

        //button hovering coding STARTS
        private void btnChangePassword_MouseEnter(object sender, EventArgs e)
        {
            btnChangePassword_settings.BackColor = Color.Teal;
            btnChangePassword_settings.ForeColor = Color.Black;
        }

        private void btnChangePassword_MouseLeave(object sender, EventArgs e)
        {
            btnChangePassword_settings.BackColor = Color.Black;
            btnChangePassword_settings.ForeColor = Color.White;
        }

        private void btnAdd_add_MouseEnter(object sender, EventArgs e)
        {
            btnAdd_add.BackColor = Color.Teal;
            btnAdd_add.ForeColor = Color.Black;
        }

        private void btnAdd_add_MouseLeave(object sender, EventArgs e)
        {
            btnAdd_add.BackColor = Color.Black;
            btnAdd_add.ForeColor = Color.White;
        }

        private void btnDelete_delete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete_delete.BackColor = Color.Teal;
            btnDelete_delete.ForeColor = Color.Black;
        }

        private void btnDelete_delete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete_delete.BackColor = Color.Black;
            btnDelete_delete.ForeColor = Color.White;
        }

        private void btnUpdate_update_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate_update.BackColor = Color.Teal;
            btnUpdate_update.ForeColor = Color.Black;
        }

        private void btnUpdate_update_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate_update.BackColor = Color.Black;
            btnUpdate_update.ForeColor = Color.White;
        }
        
        private void btnCheckUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnCheckUpdate.BackColor = Color.Teal;
            btnCheckUpdate.ForeColor = Color.Black;
        }

        private void btnCheckUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnCheckUpdate.BackColor = Color.Black;
            btnCheckUpdate.ForeColor = Color.White;
        }

        private void btnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnSubmit_help.BackColor = Color.Teal;
            btnSubmit_help.ForeColor = Color.Black;
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit_help.BackColor = Color.Black;
            btnSubmit_help.ForeColor = Color.White;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Black;
        }

        private void btnDelete_search_MouseEnter(object sender, EventArgs e)
        {
            btnDelete_search.BackColor = Color.Teal;
            btnDelete_search.ForeColor = Color.Black;
        }

        private void btnDelete_search_MouseLeave(object sender, EventArgs e)
        {
            btnDelete_search.BackColor = Color.Black;
            btnDelete_search.ForeColor = Color.White;
        }

        private void btnUpdate_search_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate_search.BackColor = Color.Teal;
            btnUpdate_search.ForeColor = Color.Black;
        }

        private void btnUpdate_search_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate_search.BackColor = Color.Black;
            btnUpdate_search.ForeColor = Color.White;
        }
        //button hovering coding ENDS

        //themes coding STARTS
        private void rbDark_settings_Click(object sender, EventArgs e)
        {
            theme = true;

            tabSearch.BackgroundImage = null;
            tabSearch.BackColor = Color.FromArgb(15, 15, 15);
            tabSearch.ForeColor = Color.White;

            tabAdd.BackgroundImage = null;
            tabAdd.BackColor = Color.FromArgb(15, 15, 15);
            tabAdd.ForeColor = Color.White;

            tabDelete.BackgroundImage = null;
            tabDelete.BackColor = Color.FromArgb(15, 15, 15);
            tabDelete.ForeColor = Color.White;

            tabUpdate.BackgroundImage = null;
            tabUpdate.BackColor = Color.FromArgb(15, 15, 15);
            tabUpdate.ForeColor = Color.White;

            tabSettings.BackgroundImage = null;
            tabSettings.BackColor = Color.FromArgb(15, 15, 15);
            tabSettings.ForeColor = Color.White;

            tabHelp.BackgroundImage = null;
            tabHelp.BackColor = Color.FromArgb(15, 15, 15);
            tabHelp.ForeColor = Color.White;

            tabAbout.BackgroundImage = null;
            tabAbout.BackColor = Color.FromArgb(15, 15, 15);
            tabAbout.ForeColor = Color.White;
            lblUrl.ForeColor = Color.White;

            File.WriteAllText(@"C:\file.csv", "dark");
        }

        private void rbLight_settings_Click(object sender, EventArgs e)
        {
            theme = true;

            tabSearch.BackgroundImage = null;
            tabSearch.BackColor = Color.LightGray;
            tabSearch.ForeColor = Color.Black;
            btnDelete_search.ForeColor = Color.White;
            btnUpdate_search.ForeColor = Color.White;
            dgvDisplay_search.ForeColor = Color.White;

            tabAdd.BackgroundImage = null;
            tabAdd.BackColor = Color.LightGray;
            tabAdd.ForeColor = Color.Black;
            btnAdd_add.ForeColor = Color.White;

            tabDelete.BackgroundImage = null;
            tabDelete.BackColor = Color.LightGray;
            tabDelete.ForeColor = Color.Black;
            btnDelete_delete.ForeColor = Color.White;

            tabUpdate.BackgroundImage = null;
            tabUpdate.BackColor = Color.LightGray;
            tabUpdate.ForeColor = Color.Black;
            btnUpdate_update.ForeColor = Color.White;

            tabSettings.BackgroundImage = null;
            tabSettings.BackColor = Color.LightGray;
            tabSettings.ForeColor = Color.Black;
            btnChangePassword_settings.ForeColor = Color.White;

            tabHelp.BackgroundImage = null;
            tabHelp.BackColor = Color.LightGray;
            tabHelp.ForeColor = Color.Black;
            btnCheckUpdate.ForeColor = Color.White;

            tabAbout.BackgroundImage = null;
            tabAbout.BackColor = Color.LightGray;
            tabAbout.ForeColor = Color.Black;
            btnSubmit_help.ForeColor = Color.White;
            lblUrl.ForeColor = Color.Black;

            File.WriteAllText(@"C:\file.csv", "light");
        }

        //feedback system STARTS
        private void btnSubmit_help_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtEmail_help.Text == "" || txtCompany_help.Text == "" || txtCountry_help.Text == "" || txtCity_help.Text == "" || txtFeedback_help.Text == "")
                {
                    lblMessage_help.Text = null;
                    lblErrorMessage_help.Text = "Please fill all fields";
                }
                else
                {
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.EnableSsl = true;
                    client.Timeout = 20000;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential("#Gmail Address", "#Password");
                    MailMessage msg = new MailMessage();
                    msg.To.Add("#Gmail address here");
                    msg.From = new MailAddress("#gmail Address here");
                    msg.Subject = "Feedback Datalink-x enterprise telephone directory system";
                    msg.Body = txtFeedback_help.Text + Environment.NewLine + "Country: " + txtCountry_help.Text + "    " + "City: " + txtCity_help.Text + "    " + "Company: " + txtCompany_help.Text + Environment.NewLine + "Sender E-mail: " + txtEmail_help.Text;
                    client.Send(msg);


                    MailMessage msgConfirmation = new MailMessage();
                    msgConfirmation.To.Add(txtEmail_help.Text);
                    msgConfirmation.From = new MailAddress("#Gmail Address Here");
                    msgConfirmation.Subject = "Feedback confirmation";
                    msgConfirmation.Body = "Hi, " + txtCompany_help.Text + Environment.NewLine + "We have received your feedback Thank you, keep in touch with us." + Environment.NewLine + Environment.NewLine +"Future envision customer help center";
                    client.Send(msgConfirmation);


                    lblErrorMessage_help.Text = null;
                    lblMessage_help.Text = "Feedback send to future envision customer help center Thank you!";

                    txtEmail_help.Text = null;
                    txtCompany_help.Text = null;
                    txtCountry_help.Text = null;
                    txtCity_help.Text = null;
                    txtFeedback_help.Text = null;
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                lblMessage_help.Text = null;
                lblErrorMessage_help.Text = "Feedback sending failed Connection error";
            }
        }
        //feedback system ENDS

        private void rbEpic_settings_Click(object sender, EventArgs e)
        {
            if(theme == true)
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Bilal Saqib Khan\source\repos\SplashScreen\quite-impressed.wav");
                splayer.Play();
            }
            theme = true; //Disables the theme sounds to play on software startup

            tabSearch.BackgroundImage = null;
            tabSearch.BackgroundImage = SplashScreen.Properties.Resources._5;
            tabSearch.ForeColor = Color.White;

            tabAdd.BackgroundImage = null;
            tabAdd.BackgroundImage = SplashScreen.Properties.Resources._5;
            tabAdd.ForeColor = Color.White;

            tabDelete.BackgroundImage = null;
            tabDelete.BackgroundImage = SplashScreen.Properties.Resources._5;
            tabDelete.ForeColor = Color.White;

            tabUpdate.BackgroundImage = null;
            tabUpdate.BackgroundImage = SplashScreen.Properties.Resources._5;
            tabUpdate.ForeColor = Color.White;

            tabSettings.BackgroundImage = null;
            tabSettings.BackgroundImage = SplashScreen.Properties.Resources._5;
            tabSettings.ForeColor = Color.White;

            tabHelp.BackgroundImage = null;
            tabHelp.BackgroundImage = SplashScreen.Properties.Resources._5;
            tabHelp.ForeColor = Color.White;

            tabAbout.BackgroundImage = null;
            tabAbout.BackgroundImage = SplashScreen.Properties.Resources._5;
            tabAbout.ForeColor = Color.White;
            lblUrl.ForeColor = Color.White;

            File.WriteAllText(@"C:\file.csv", "epic");
        }

        private void rbFutureenvision_settings_Click(object sender, EventArgs e)
        {
            if (theme == true)
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Bilal Saqib Khan\source\repos\SplashScreen\chin-up.wav");
                splayer.Play();
            }
            theme = true; //Disables the theme sounds to play on software startup

            tabSearch.BackgroundImage = null;
            tabSearch.BackgroundImage = SplashScreen.Properties.Resources.abstract_1366x768;
            tabSearch.ForeColor = Color.White;

            tabAdd.BackgroundImage = null;
            tabAdd.BackgroundImage = SplashScreen.Properties.Resources.abstract_1366x768;
            tabAdd.ForeColor = Color.White;

            tabDelete.BackgroundImage = null;
            tabDelete.BackgroundImage = SplashScreen.Properties.Resources.abstract_1366x768;
            tabDelete.ForeColor = Color.White;

            tabUpdate.BackgroundImage = null;
            tabUpdate.BackgroundImage = SplashScreen.Properties.Resources.abstract_1366x768;
            tabUpdate.ForeColor = Color.White;

            tabSettings.BackgroundImage = null;
            tabSettings.BackgroundImage = SplashScreen.Properties.Resources.abstract_1366x768;
            tabSettings.ForeColor = Color.White;

            tabHelp.BackgroundImage = null;
            tabHelp.BackgroundImage = SplashScreen.Properties.Resources.abstract_1366x768;
            tabHelp.ForeColor = Color.White;

            tabAbout.BackgroundImage = null;
            tabAbout.BackgroundImage = SplashScreen.Properties.Resources.abstract_1366x768;
            tabAbout.ForeColor = Color.White;
            //tabAbout.Font = Font.Bold;
            lblUrl.ForeColor = Color.White;

            File.WriteAllText(@"C:\file.csv", "futureEnvision");
        }
        //themes coding ENDS
    }
}
