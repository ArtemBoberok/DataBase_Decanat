using System;
using System.Windows.Forms;
using DataBase.Forms;

namespace DataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmGroup Group = new fmGroup(this);
            Group.Show();
        }

        private void дисциплиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmPredmet Predmet = new fmPredmet(this);
            Predmet.Show();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmStudent Student = new fmStudent(this);
            Student.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void ведомостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmVedomost Vedomost = new fmVedomost();
            Vedomost.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmAbout About = new fmAbout();
            About.Show();
        }

        bool cancel;
        public void X ()
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                cancel = true;
            }
        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmAuthorization Authorization = new fmAuthorization();
            Authorization.Show();
        }
    }
}
