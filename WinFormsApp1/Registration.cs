using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Numerics;
using System.Collections.Generic;
using System.IO;
using static System.Net.WebRequestMethods;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Registration : Form
    {
        SqlConnection sqlConnection;
        public Registration()
        {
            InitializeComponent();
        }

        private async void buttonReg_Click(object sender, EventArgs e)
        {
            labelErLogin.Visible = false;
            labelErNickName.Visible = false;
            labelErNothing.Visible= false;
            labelRightReg.Visible = false;
            buttonProd.Visible = false;
            buttonReg.Visible = true;

            if (!string.IsNullOrEmpty(NickNameBox.Text) && !string.IsNullOrWhiteSpace(NickNameBox.Text)
                && !string.IsNullOrEmpty(LoginBox.Text) && !string.IsNullOrWhiteSpace(LoginBox.Text)
                && !string.IsNullOrEmpty(PasswordBox.Text) && !string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                bool flagNickName = true;
                bool flagLogin = true;

                //-----------------CHECK----------------------//
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("SELECT * FROM [Users]", sqlConnection);
                try
                {
                    sqlReader = await command.ExecuteReaderAsync();
                    while (await sqlReader.ReadAsync())
                    {
                        if (Convert.ToString(sqlReader["UserName"])==NickNameBox.Text) 
                        {
                            labelErNickName.Visible = true;
                            flagNickName = false;
                        }
                        if (Convert.ToString(sqlReader["Login"])==LoginBox.Text)
                        {
                            labelErLogin.Visible = true;
                            flagLogin = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (sqlReader != null)
                    {
                        sqlReader.Close();
                    }
                }
                //-----INSERT--------------//
                if (flagNickName && flagLogin) 
                {
                    SqlCommand commandTwo = new SqlCommand("INSERT INTO [Users] (Login, Password, UserName)VALUES(@Login, @Password, @UserName)", sqlConnection);
                    commandTwo.Parameters.AddWithValue("Login", LoginBox.Text);
                    commandTwo.Parameters.AddWithValue("Password", PasswordBox.Text);
                    commandTwo.Parameters.AddWithValue("UserName", NickNameBox.Text);
                    await commandTwo.ExecuteNonQueryAsync();

                    labelRightReg.Visible = true;
                    buttonProd.Visible = true;
                    buttonReg.Visible = false;

                }
                else
                {
                    LoginBox.Clear();
                    PasswordBox.Clear();
                    NickNameBox.Clear();
                }

            }
            else
            {
                labelErNothing.Visible = true;
            }
        }

        private async void Registration_Load(object sender, EventArgs e)
        {
            string StringUser = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\WinFormsApp1\WinFormsApp1\Users.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(StringUser);
            await sqlConnection.OpenAsync();
        }

        private void buttonProd_Click(object sender, EventArgs e)
        {
            LogInSystem prod = new LogInSystem();
            prod.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            LogInSystem back = new LogInSystem();
            back.Show();
            this.Hide();
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            PasswordBox.UseSystemPasswordChar = !checkBoxPassword.Checked;
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
            Application.Exit();
        }

        private void NickNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch < 'A' || ch > 'z') && !Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void LoginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch < 'A' || ch > 'z') && !Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void PasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch < 'A' || ch > 'z') && !Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
