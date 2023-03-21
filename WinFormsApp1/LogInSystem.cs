using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LogInSystem : Form
    {
        SqlConnection sqlConnection;
        
        public LogInSystem()
        {
            InitializeComponent();
        }

        private async void buttonLog_Click(object sender, EventArgs e)
        {
            if (labelErrorLog.Visible)
            {
                labelErrorLog.Visible = false;
            }

            bool UserFlag = false;
            if (!string.IsNullOrEmpty(LoginBox.Text) && !string.IsNullOrWhiteSpace(LoginBox.Text)
                && !string.IsNullOrEmpty(PasswordBox.Text) && !string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("SELECT * FROM [Users]", sqlConnection);
                try
                {
                    sqlReader = await command.ExecuteReaderAsync();
                    while (await sqlReader.ReadAsync())
                    {
                        if (LoginBox.Text == Convert.ToString(sqlReader["Login"]) &&
                            PasswordBox.Text == Convert.ToString(sqlReader["Password"]))
                        {
                            UserFlag = true;
                            break;
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

                if (UserFlag)
                {
                    Form3 frm3 = new Form3();
                    frm3.Show();
                    this.Hide();
                }
                else
                {
                    LoginBox.Clear();
                    PasswordBox.Clear();
                    labelErrorLog.Visible = true;
                    labelErrorLog.Text = "Данные введены неверно!";
                }
            }
            else
            {
                LoginBox.Clear();
                PasswordBox.Clear();
                labelErrorLog.Visible = true;
                labelErrorLog.Text = "Заполните поля выше!";
            }
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Registration regfrm = new Registration();
            regfrm.Show();
            this.Hide();
        }

        private async void LogInSystem_Load(object sender, EventArgs e)
        {
            string UserConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\WinFormsApp1\WinFormsApp1\Users.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(UserConnection);
            await sqlConnection.OpenAsync();
            
        }

        private void checkPasswordBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordBox.UseSystemPasswordChar = !checkPasswordBox.Checked;
        }

        private void LogInSystem_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
            Application.Exit();
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