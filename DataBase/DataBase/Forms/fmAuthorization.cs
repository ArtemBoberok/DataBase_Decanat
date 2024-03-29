using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataBase.Forms
{
    public partial class fmAuthorization : Form
    {
        public fmAuthorization()
        {
            InitializeComponent();
        }

        public string fioUser;
        public string statusUser;

        private void textBoxLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPas_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string logUser = textBoxLog.Text;
            string passUser = textBoxPas.Text;
            SqlConnection conn = new SqlConnection(Connection.con);
            try
            {
                conn.Open();
                string query = $"SELECT [Id_user],[login],[password],[status],[fio] FROM [dbo].[dbo.User] WHERE [login] = '{logUser}' AND [password] = '{passUser}'";

                SqlCommand cmd = new SqlCommand(query,conn);

                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows == false)
                {
                    MessageBox.Show("Такого аккаунта нет!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (reader.Read())
                    {
                        fioUser = reader[4].ToString();
                        statusUser = reader[3].ToString();
                        MessageBox.Show("Вы успешно вошли, как " + statusUser, "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                reader.Close();
                conn.Close();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}
