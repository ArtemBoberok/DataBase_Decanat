using System;
using System.Windows.Forms;

namespace DataBase.Forms
{
    public partial class fmStudent : Form
    {
        Form1 owner = null;
        public fmStudent(Form1 owner)
        {
            InitializeComponent();
            this.owner = owner;
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.decanatDataSet);

        }

        private void studentBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.decanatDataSet);

        }

        private void fmStudent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "decanatDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.decanatDataSet.Group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "decanatDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.decanatDataSet.Student);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.owner.X();
        }
    }
}
