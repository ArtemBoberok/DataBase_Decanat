using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace DataBase.Forms
{
    public partial class fmVedomost : Form
    {
        public fmVedomost()
        {
            InitializeComponent();
        }

        void Base()
        {
            SqlConnection conn = new SqlConnection(Connection.con);
            try
            {
                conn.Open();
                string query = "SELECT [dbo].[Student].[FIO], [dbo].[Group].[Name_group]," +
                "[dbo].[Subject].[Name_subject], [dbo].[Ball].[ball], [dbo].[Ball].[vid_control]" +
                "FROM [dbo].[Student], [dbo].[Group], [dbo].[Subject], [dbo].[Ball]" +
                "WHERE ([dbo].[Student].[id_group] = [dbo].[Group].[Id_group]) AND" +
                "([dbo].[Ball].[id_student] = [dbo].[Student].[id_student]) AND" +
                "([dbo].[Ball].[id_subject] = [dbo].[Subject].[Id_subject])";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    MessageBox.Show("Данные не найдены!");
                }
                else
                {
                    while (reader.Read())
                    {
                        dataGridStudent.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                    }
                }
                reader.Close();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void fmVedomost_Load(object sender, EventArgs e)
        {
            Base();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            buttonSor.Enabled = true;
        }

        private DataGridViewColumn Col;
        private void buttonSor_Click(object sender, EventArgs e)
        {
            Col = new DataGridViewColumn();
            switch (listBoxSor.SelectedIndex)
            {
                case 0: Col = Column1; break;
                case 1: Col = Column2; break;
                case 2: Col = Column3; break;
                case 3: Col = Column4; break;
                case 4: Col = Column5; break;
            }
            if (radioButton1.Checked)
                dataGridStudent.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else
                dataGridStudent.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
        }

        private void buttonExcel_Click_1(object sender, EventArgs e)
        {
            var application = new Excel.Application();
            application.SheetsInNewWorkbook = 1;
            Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);

            Excel.Worksheet worksheet = application.Worksheets.Item[1];
            worksheet.Name = "Сводная ведомость";
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < dataGridStudent.Columns.Count; j++)
                worksheet.Cells[1, i+1] = dataGridStudent.Columns[j].HeaderCell.Value;
            }

            for (int i = 2; i < dataGridStudent.Rows.Count + 2; i++)
            {
                for (int j = 0; j < dataGridStudent.Columns.Count; j++)
                {
                    worksheet.Cells[i, j + 1] = dataGridStudent[j, i - 2].Value;
                }
            }
            application.Visible = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            fmAddBall AddBall = new fmAddBall();
            AddBall.Show();
        }

        private void fmVedomost_Activated(object sender, EventArgs e)
        {
            dataGridStudent.Rows.Clear();
            
            Base();
        }
    }
}
