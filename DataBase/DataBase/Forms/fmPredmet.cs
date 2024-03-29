using System;
using System.Windows.Forms;

namespace DataBase.Forms
{
    public partial class fmPredmet : Form
    {
        Form1 owner = null;
        public fmPredmet(Form1 owner)
        {
            InitializeComponent();
            this.owner = owner;
        }

        private void subjectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.decanatDataSet);

        }

        private void fmPredmet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "decanatDataSet.Subject". При необходимости она может быть перемещена или удалена.
            this.subjectTableAdapter.Fill(this.decanatDataSet.Subject);

        }

        private void buttonFil_Click(object sender, EventArgs e)
        {
            subjectBindingSource.Filter = "semestr = '" + comboBoxTerm.Text + "'";
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            subjectBindingSource.Filter = "";
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.owner.X();
        }
    }
}
