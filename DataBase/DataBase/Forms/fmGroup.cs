using System;
using System.Windows.Forms;

namespace DataBase.Forms
{
    public partial class fmGroup : Form
    {
        Form1 owner = null;
        public fmGroup(Form1 owner)
        {
            InitializeComponent();
            this.owner = owner;
        }

        private void groupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.groupBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.decanatDataSet);
        }

        private void fmGroup_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "decanatDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.decanatDataSet.Group);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.owner.X();
        }
    }
}
