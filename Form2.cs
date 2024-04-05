using System.Data;
using System.Data.SqlClient;

//Modified: Bantu-Bethu Beya
//Time: 21:19
//Date: 05/04/2024
//Version 1 building from scratch


namespace Expense_Tracker_SideProject_BantuBeya
{
    public partial class Form2 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mr Bantu-Bethu Beya\Documents\expense.mdf"";Integrated Security=True;Connect Timeout=30");
        public Form2()
        {
            InitializeComponent();
        }//
        //

        //Check if it is connected to db
        public bool checkConnection()
        {
            return (connect.State == ConnectionState.Closed ? true : false);
        }//End of checkconnection
        //
        //
        private void btnSignup_Click_1(object sender, EventArgs e)
        {
            if (txtRegUsername.Text == "" || txtRegisterPassword.Text == "" || txtRegisterConfirmPass.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        // CHECK IF USERNAME ALREADY EXISTS IN BD
                        string selectUsername = "SELECT * FROM users WHERE username = @usern";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@usern", txtRegUsername.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count != 0)
                            {
                                //Capitalize first letter
                                string tempUsern = txtRegUsername.Text.Substring(0,1).ToUpper() + txtRegUsername.Text.Substring(1);
                                MessageBox.Show(tempUsern + " exists already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (txtRegisterPassword.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid password, atleast 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (txtRegisterPassword.Text != txtRegisterConfirmPass.Text) 
                            {
                                MessageBox.Show("The passwords do not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, password, date_create) VALUES(@usern, @pass, @date)";


                                //******* I made a mistake at first by typing SqlConnection instead of SqlCommand be mindful *******
                                using (SqlCommand insertUser = new SqlCommand(insertData, connect))
                                {
                                    insertUser.Parameters.AddWithValue("@usern", txtRegUsername.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@pass", txtRegisterPassword.Text.Trim());

                                    DateTime today = DateTime.Today; //The current day's date
                                    insertUser.Parameters.AddWithValue("@date", today);

                                    insertUser.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully1", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //
                                    //

                                    //After registering, open Login form
                                    Form loginForm = new Form1();
                                    loginForm.Show();

                                   

                                    //Hiding the Registration Form
                                    this.Hide();

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }//End of signup btn


        //Show password button for Sign up page
        private void loginShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtRegisterPassword.PasswordChar = registerShowPass.Checked ? '\0' : '*';
            txtRegisterConfirmPass.PasswordChar = registerShowPass.Checked ? '\0' : '*';
        }//End of Show password
        //
        //

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //
        //Switch from Sign Up page top Login
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }//End of Close button
         //
         //Sigup btn

        //

    }
}
