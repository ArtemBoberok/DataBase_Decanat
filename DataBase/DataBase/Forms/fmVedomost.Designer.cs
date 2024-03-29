
namespace DataBase.Forms
{
    partial class fmVedomost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxVed = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.listBoxSor = new System.Windows.Forms.ListBox();
            this.buttonSor = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).BeginInit();
            this.groupBoxVed.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridStudent
            // 
            this.dataGridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridStudent.Location = new System.Drawing.Point(12, 12);
            this.dataGridStudent.Name = "dataGridStudent";
            this.dataGridStudent.Size = new System.Drawing.Size(543, 269);
            this.dataGridStudent.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ФИО";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Группа";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Предмет";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Оценка";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Вид контроля";
            this.Column5.Name = "Column5";
            // 
            // groupBoxVed
            // 
            this.groupBoxVed.Controls.Add(this.buttonAdd);
            this.groupBoxVed.Controls.Add(this.buttonExcel);
            this.groupBoxVed.Controls.Add(this.listBoxSor);
            this.groupBoxVed.Controls.Add(this.buttonSor);
            this.groupBoxVed.Controls.Add(this.radioButton2);
            this.groupBoxVed.Controls.Add(this.radioButton1);
            this.groupBoxVed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxVed.Location = new System.Drawing.Point(572, 12);
            this.groupBoxVed.Name = "groupBoxVed";
            this.groupBoxVed.Size = new System.Drawing.Size(200, 280);
            this.groupBoxVed.TabIndex = 1;
            this.groupBoxVed.TabStop = false;
            this.groupBoxVed.Text = "Сортировка";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(16, 242);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(166, 27);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавление записи";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(16, 209);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(166, 27);
            this.buttonExcel.TabIndex = 5;
            this.buttonExcel.Text = "Экспорт в Excel";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click_1);
            // 
            // listBoxSor
            // 
            this.listBoxSor.FormattingEnabled = true;
            this.listBoxSor.ItemHeight = 16;
            this.listBoxSor.Items.AddRange(new object[] {
            "ФИО",
            "Группа",
            "Предмет",
            "Оценка",
            "Вид контроля"});
            this.listBoxSor.Location = new System.Drawing.Point(16, 22);
            this.listBoxSor.Name = "listBoxSor";
            this.listBoxSor.Size = new System.Drawing.Size(166, 100);
            this.listBoxSor.TabIndex = 4;
            // 
            // buttonSor
            // 
            this.buttonSor.Location = new System.Drawing.Point(16, 176);
            this.buttonSor.Name = "buttonSor";
            this.buttonSor.Size = new System.Drawing.Size(166, 27);
            this.buttonSor.TabIndex = 3;
            this.buttonSor.Text = "Сортировать";
            this.buttonSor.UseVisualStyleBackColor = true;
            this.buttonSor.Click += new System.EventHandler(this.buttonSor_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 152);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(114, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "По убыванию";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 128);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(134, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "По возрастанию";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // fmVedomost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 304);
            this.Controls.Add(this.groupBoxVed);
            this.Controls.Add(this.dataGridStudent);
            this.Name = "fmVedomost";
            this.Text = "Ведомость";
            this.Activated += new System.EventHandler(this.fmVedomost_Activated);
            this.Load += new System.EventHandler(this.fmVedomost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).EndInit();
            this.groupBoxVed.ResumeLayout(false);
            this.groupBoxVed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBoxVed;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button buttonSor;
        private System.Windows.Forms.ListBox listBoxSor;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Button buttonAdd;
    }
}