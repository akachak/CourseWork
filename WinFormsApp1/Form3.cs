using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        SqlConnection sqlConnection;
        public Form3()
        {
            InitializeComponent();
        }

        private async void Form3_Load(object sender, EventArgs e)
        {
            string StringAbonents = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\WinFormsApp1\WinFormsApp1\Users.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(StringAbonents);
            await sqlConnection.OpenAsync();

            SqlDataAdapter adapter= new SqlDataAdapter("SELECT * FROM [Abonents]", sqlConnection);
            DataTable abonentsTable= new DataTable();

            try
            {
                adapter.Fill(abonentsTable);

                dataGridView1.DataSource = abonentsTable;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInSystem exitLog = new LogInSystem();
            exitLog.Show();
            this.Hide();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(label6.Visible)
            {
                label6.Visible = false;
            }
            labelRightReg.Visible = false;

            if(!string.IsNullOrEmpty(textBoxAddSurn.Text)&&!string.IsNullOrWhiteSpace(textBoxAddSurn.Text)&&
                !string.IsNullOrEmpty(textBoxAddName.Text) && !string.IsNullOrWhiteSpace(textBoxAddName.Text) &&
                !string.IsNullOrEmpty(textBoxAddOtch.Text) && !string.IsNullOrWhiteSpace(textBoxAddOtch.Text) &&
                !string.IsNullOrEmpty(textBoxNumberDob.Text) && !string.IsNullOrWhiteSpace(textBoxNumberDob.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Abonents] (Фамилия, Имя, Отчество, Номер, Дата)VALUES(@Фамилия, @Имя, @Отчество, @Номер, @Дата)", sqlConnection);
                command.Parameters.AddWithValue("Фамилия", textBoxAddSurn.Text);
                command.Parameters.AddWithValue("Имя", textBoxAddName.Text);
                command.Parameters.AddWithValue("Отчество", textBoxAddOtch.Text);
                command.Parameters.AddWithValue("Номер", "+79"+textBoxNumberDob.Text);
                command.Parameters.AddWithValue("Дата", dateTimePicker.Text);

                await command.ExecuteNonQueryAsync();
                labelRightReg.Visible = true;
                textBoxAddSurn.Clear();
                textBoxAddName.Clear();
                textBoxAddOtch.Clear();
                textBoxNumberDob.Clear();
                

            }
            else
            {
                textBoxAddSurn.Clear();
                textBoxAddName.Clear();
                textBoxAddOtch.Clear();
                textBoxNumberDob.Clear();
                

                label6.Visible = true;
                label6.Text = "Поля должны быть заполнены!";
            }
            
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Abonents]", sqlConnection);
            DataTable abonentsTable = new DataTable();

            try
            {
                adapter.Fill(abonentsTable);

                dataGridView1.DataSource = abonentsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SqlDataAdapter adapterThree = new SqlDataAdapter("SELECT Фамилия, Имя, Отчество, Дата FROM [Abonents]", sqlConnection);
            DataTable abonentsTableThree = new DataTable();

            try
            {
                adapterThree.Fill(abonentsTableThree);
                dataGridView3.DataSource = abonentsTableThree;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }

            System.Windows.Forms.Application.Exit();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            labelErSearchNewNumber.Visible = false;
            labelNewNumberIzm.Visible=false;
            NewNumberBox.Visible = false;
            buttonNewNumberIzm.Visible = false;
            textBox10.Visible = false;
            buttonOtmena.Visible = false;
            

            if (!string.IsNullOrEmpty(textBoxSearchToIzmSurn.Text) && !string.IsNullOrWhiteSpace(textBoxSearchToIzmSurn.Text)
                && !string.IsNullOrEmpty(textBoxSearchToIzmName.Text) && !string.IsNullOrWhiteSpace(textBoxSearchToIzmName.Text)
                && !string.IsNullOrEmpty(textBoxSearchToIzmOtch.Text) && !string.IsNullOrWhiteSpace(textBoxSearchToIzmOtch.Text)) 
            {
                bool flagSurn = false;
                bool flagName = false;
                bool flagOtch = false;

                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("SELECT * FROM [Abonents]", sqlConnection);
                try
                {
                    sqlReader = await command.ExecuteReaderAsync();
                    while (await sqlReader.ReadAsync())
                    {
                        if (Convert.ToString(sqlReader["Фамилия"]) == textBoxSearchToIzmSurn.Text)
                        {
                            flagSurn = true;
                        }
                        if (Convert.ToString(sqlReader["Имя"]) == textBoxSearchToIzmName.Text)
                        {
                            flagName = true;
                        }
                        if (Convert.ToString(sqlReader["Отчество"]) == textBoxSearchToIzmOtch.Text)
                        {
                            flagOtch= true;
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

                if (flagSurn && flagName && flagOtch) 
                {
                    labelNewNumberIzm.Visible = true;
                    NewNumberBox.Visible = true;
                    buttonNewNumberIzm.Visible = true;
                    textBox10.Visible = true;
                    buttonOtmena.Visible = true;

                    textBoxSearchToIzmSurn.Enabled = false;
                    textBoxSearchToIzmName.Enabled = false;
                    textBoxSearchToIzmOtch.Enabled = false;
                }
                else
                {
                    textBoxSearchToIzmSurn.Clear();
                    textBoxSearchToIzmName.Clear();
                    textBoxSearchToIzmOtch.Clear();

                    labelErSearchNewNumber.Text = "Совпадений нет";
                    labelErSearchNewNumber.Visible = true;
                }
            }
            else
            {
                textBoxSearchToIzmSurn.Clear();
                textBoxSearchToIzmName.Clear();
                textBoxSearchToIzmOtch.Clear();

                labelErSearchNewNumber.Text = "Заполните поля";
                labelErSearchNewNumber.Visible = true;
            }
        }

        private async void buttonNewNumberIzm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NewNumberBox.Text) && !string.IsNullOrWhiteSpace(NewNumberBox.Text))
            {
                SqlCommand commandUpdate = new SqlCommand("UPDATE [Abonents] SET [Номер]=@Номер WHERE [Фамилия]=@Фамилия AND [Имя]=@Имя AND [Отчество]=@Отчество ", sqlConnection);

                commandUpdate.Parameters.AddWithValue("Номер", "+79" + NewNumberBox.Text);
                commandUpdate.Parameters.AddWithValue("Фамилия", textBoxSearchToIzmSurn.Text);
                commandUpdate.Parameters.AddWithValue("Имя", textBoxSearchToIzmName.Text);
                commandUpdate.Parameters.AddWithValue("Отчество", textBoxSearchToIzmOtch.Text);

                await commandUpdate.ExecuteNonQueryAsync();

                textBoxSearchToIzmSurn.Clear();
                textBoxSearchToIzmName.Clear();
                textBoxSearchToIzmOtch.Clear();
                textBoxSearchToIzmSurn.Enabled = true;
                textBoxSearchToIzmName.Enabled = true;
                textBoxSearchToIzmOtch.Enabled = true;

                NewNumberBox.Visible = false;
                buttonNewNumberIzm.Visible = false;
                labelNewNumberIzm.Visible = false;
                textBox10.Visible = false;
                buttonOtmena.Visible = false;
            }
           
            
        }

        private void NewNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }

            if (NewNumberBox.TextLength < 8 || number == 8) 
            {
                buttonNewNumberIzm.Enabled = false;
            }
            else
            {
                buttonNewNumberIzm.Enabled = true;
            }
        }

        private void TwoNumbersBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }

            if (TwoNumbersBox.TextLength < 1 || number==8)
            {
                buttonSearchTwoNum.Enabled = false;
            }
            else
            {
                buttonSearchTwoNum.Enabled = true;
            }
        }

        private void textBoxNumberDob_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }

        }

        private void buttonOtmena_Click(object sender, EventArgs e)
        {
            labelNewNumberIzm.Visible = false;
            NewNumberBox.Visible = false;
            buttonNewNumberIzm.Visible = false;
            textBox10.Visible = false;
            buttonOtmena.Visible = false;

            textBoxSearchToIzmSurn.Clear();
            textBoxSearchToIzmName.Clear();
            textBoxSearchToIzmOtch.Clear();

            textBoxSearchToIzmSurn.Enabled = true;
            textBoxSearchToIzmName.Enabled = true;
            textBoxSearchToIzmOtch.Enabled = true;
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            labelDelete.Visible = false;

            if (!string.IsNullOrEmpty(textBoxDeleteName.Text) && !string.IsNullOrWhiteSpace(textBoxDeleteName.Text)
                && !string.IsNullOrEmpty(textBoxDeleteOtch.Text) && !string.IsNullOrWhiteSpace(textBoxDeleteOtch.Text)
                && !string.IsNullOrEmpty(textBoxDeleteSurn.Text) && !string.IsNullOrWhiteSpace(textBoxDeleteSurn.Text)) 
            {
                bool flagSurnDel = false;
                bool flagNameDel = false;
                bool flagOtchDel = false;

                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("SELECT * FROM [Abonents]", sqlConnection);
                try
                {
                    sqlReader = await command.ExecuteReaderAsync();
                    while (await sqlReader.ReadAsync())
                    {
                        if (Convert.ToString(sqlReader["Фамилия"]) == textBoxDeleteSurn.Text)
                        {
                            flagSurnDel = true;
                        }
                        if (Convert.ToString(sqlReader["Имя"]) == textBoxDeleteName.Text)
                        {
                            flagNameDel = true;
                        }
                        if (Convert.ToString(sqlReader["Отчество"]) == textBoxDeleteOtch.Text)
                        {
                            flagOtchDel = true;
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

                if (flagSurnDel && flagNameDel && flagOtchDel)
                {
                    SqlCommand commandDel = new SqlCommand("DELETE FROM [Abonents] WHERE [Фамилия]=@Фамилия AND [Имя]=@Имя AND [Отчество]=@Отчество ", sqlConnection);

                    commandDel.Parameters.AddWithValue("Фамилия", textBoxDeleteSurn.Text);
                    commandDel.Parameters.AddWithValue("Имя", textBoxDeleteName.Text);
                    commandDel.Parameters.AddWithValue("Отчество", textBoxDeleteOtch.Text);

                    await commandDel.ExecuteNonQueryAsync();

                    textBoxDeleteSurn.Clear();
                    textBoxDeleteName.Clear();
                    textBoxDeleteOtch.Clear();

                    labelDelete.ForeColor = Color.Green; 
                    labelDelete.Location = new Point(389, 254);
                    labelDelete.Text = "Успешно";
                    labelDelete.Visible = true;
                    
                }
                else
                {
                    textBoxDeleteSurn.Clear();
                    textBoxDeleteName.Clear();
                    textBoxDeleteOtch.Clear();

                    labelDelete.ForeColor = Color.Red;
                    labelDelete.Location = new Point(337, 254);
                    labelDelete.Text = "Пользователь не был найден";
                    labelDelete.Visible = true;
                }
            }
            else
            {
                textBoxDeleteSurn.Clear();
                textBoxDeleteName.Clear();
                textBoxDeleteOtch.Clear();
                labelDelete.ForeColor = Color.Red;
                labelDelete.Location = new Point(337, 254);
                labelDelete.Text = "Поля должны быть заполнены";
                labelDelete.Visible = true;
            }
        }

        private void textBoxDeleteSurn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch < 'А' || ch > 'я') && ch != 8) 
            {
                e.Handled = true;
            }
        }

        private void textBoxDeleteName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch < 'А' || ch > 'я') && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxDeleteOtch_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch < 'А' || ch > 'я') && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonSearchTwoNum_Click(object sender, EventArgs e)
        {
            string searchStringSql = "SELECT Фамилия, Имя, Отчество, Номер FROM [Abonents] WHERE Номер LIKE '___" + TwoNumbersBox.Text + "%'";

            SqlDataAdapter adapterTwo = new SqlDataAdapter(searchStringSql, sqlConnection);
            DataTable abonentsTableTwo = new DataTable();

            try
            {
                adapterTwo.Fill(abonentsTableTwo);

                dataGridView2.DataSource = abonentsTableTwo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxSearchToIzmOtch_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch < 'А' || ch > 'я') && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxSearchToIzmName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch < 'А' || ch > 'я') && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxSearchToIzmSurn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch < 'А' || ch > 'я') && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxAddOtch_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch < 'А' || ch > 'я') && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxAddName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch < 'А' || ch > 'я') && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxAddSurn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch < 'А' || ch > 'я') && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            if (buttonFile.Text == "Показать")
            {
                Excel.Application exApp= new Excel.Application();
                exApp.Workbooks.Add();
                Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
                for (int i = 0; i < dataGridView3.RowCount-1; i++) 
                {
                    for (int j = 0; j < dataGridView3.ColumnCount; j++)
                    {
                        wsh.Cells[i + 1, j + 1] = dataGridView3[j, i].Value.ToString();
                    }
                }

                exApp.Visible = true;
            }
            else
            {
                SqlDataAdapter adapterThree = new SqlDataAdapter("SELECT Фамилия, Имя, Отчество, Дата FROM [Abonents]", sqlConnection);
                DataTable abonentsTableThree = new DataTable();

                try
                {
                    adapterThree.Fill(abonentsTableThree);
                    dataGridView3.DataSource = abonentsTableThree;
                    buttonFile.Text = "Показать";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

    }
}
