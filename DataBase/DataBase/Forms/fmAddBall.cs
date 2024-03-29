using System;
using System.Data;
using System.Windows.Forms;

namespace DataBase.Forms
{
    public partial class fmAddBall : Form
    {
        public fmAddBall()
        {
            InitializeComponent();
        }

        private void fmAddBall_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "decanatDataSet.Ball". При необходимости она может быть перемещена или удалена.
            this.ballTableAdapter.Fill(this.decanatDataSet.Ball);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "decanatDataSet.Subject". При необходимости она может быть перемещена или удалена.
            this.subjectTableAdapter.Fill(this.decanatDataSet.Subject);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "decanatDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.decanatDataSet.Student);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DataRow nRow = decanatDataSet.Ball.NewRow();
            nRow[1] = comboBoxSubject.SelectedValue.ToString();
            nRow[2] = comboBoxStudent.SelectedValue.ToString();
            nRow[3] = numericUpDownBall.Text;
            nRow[4] = comboBoxVid.Text;
            this.decanatDataSet.Ball.Rows.Add(nRow);
            tableAdapterManager1.UpdateAll(this.decanatDataSet);
            decanatDataSet.Ball.AcceptChanges();
            MessageBox.Show("Данные успешно сохранены!");
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxVid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
