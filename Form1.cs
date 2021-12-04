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

namespace PasswordManager_2
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\toxa_\source\repos\PasswordManager_2\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                SqlCommand command = new SqlCommand("PassAdd", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", textName.Text.Trim());
                command.Parameters.AddWithValue("@Site", textSite.Text.Trim());
                command.Parameters.AddWithValue("@Login", textLogin.Text.Trim());
                command.Parameters.AddWithValue("@Pass", textPass.Text.Trim());
                command.ExecuteNonQuery();
                MessageBox.Show("Сохранение успешно выполнено");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Возникла ошибка");
            }
            finally
            {

            }
        }
    }
}
