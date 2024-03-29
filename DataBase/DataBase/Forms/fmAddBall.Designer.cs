
namespace DataBase.Forms
{
    partial class fmAddBall
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.ballBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.decanatDataSet = new DataBase.DecanatDataSet();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxVid = new System.Windows.Forms.ComboBox();
            this.numericUpDownBall = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.studentTableAdapter = new DataBase.DecanatDataSetTableAdapters.StudentTableAdapter();
            this.subjectTableAdapter = new DataBase.DecanatDataSetTableAdapters.SubjectTableAdapter();
            this.ballTableAdapter = new DataBase.DecanatDataSetTableAdapters.BallTableAdapter();
            this.subjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new DataBase.DecanatDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.ballBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decanatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дисциплина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(54, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Студент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(63, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Оценка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вид контроля";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ballBindingSource, "id_subject", true));
            this.comboBoxSubject.DataSource = this.subjectBindingSource;
            this.comboBoxSubject.DisplayMember = "Name_subject";
            this.comboBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(135, 15);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(167, 28);
            this.comboBoxSubject.TabIndex = 4;
            this.comboBoxSubject.ValueMember = "Id_subject";
            // 
            // ballBindingSource
            // 
            this.ballBindingSource.DataMember = "Ball";
            this.ballBindingSource.DataSource = this.decanatDataSet;
            // 
            // decanatDataSet
            // 
            this.decanatDataSet.DataSetName = "DecanatDataSet";
            this.decanatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject";
            this.subjectBindingSource.DataSource = this.decanatDataSet;
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ballBindingSource, "id_student", true));
            this.comboBoxStudent.DataSource = this.studentBindingSource;
            this.comboBoxStudent.DisplayMember = "FIO";
            this.comboBoxStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(135, 58);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(167, 28);
            this.comboBoxStudent.TabIndex = 5;
            this.comboBoxStudent.ValueMember = "Id_student";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.decanatDataSet;
            // 
            // comboBoxVid
            // 
            this.comboBoxVid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ballBindingSource, "Id_ball", true));
            this.comboBoxVid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxVid.FormattingEnabled = true;
            this.comboBoxVid.Items.AddRange(new object[] {
            "Control",
            "indep"});
            this.comboBoxVid.Location = new System.Drawing.Point(135, 145);
            this.comboBoxVid.Name = "comboBoxVid";
            this.comboBoxVid.Size = new System.Drawing.Size(167, 28);
            this.comboBoxVid.TabIndex = 6;
            this.comboBoxVid.SelectedIndexChanged += new System.EventHandler(this.comboBoxVid_SelectedIndexChanged);
            // 
            // numericUpDownBall
            // 
            this.numericUpDownBall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownBall.Location = new System.Drawing.Point(135, 101);
            this.numericUpDownBall.Name = "numericUpDownBall";
            this.numericUpDownBall.Size = new System.Drawing.Size(166, 26);
            this.numericUpDownBall.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(30, 188);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(103, 32);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnd.Location = new System.Drawing.Point(164, 188);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(108, 32);
            this.buttonEnd.TabIndex = 9;
            this.buttonEnd.Text = "Закрыть";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // ballTableAdapter
            // 
            this.ballTableAdapter.ClearBeforeFill = true;
            // 
            // subjectBindingSource1
            // 
            this.subjectBindingSource1.DataMember = "Subject";
            this.subjectBindingSource1.DataSource = this.decanatDataSet;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BallTableAdapter = this.ballTableAdapter;
            this.tableAdapterManager1.GroupTableAdapter = null;
            this.tableAdapterManager1.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager1.SubjectTableAdapter = this.subjectTableAdapter;
            this.tableAdapterManager1.UpdateOrder = DataBase.DecanatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fmAddBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownBall);
            this.Controls.Add(this.comboBoxVid);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmAddBall";
            this.Text = "Добавление оценки";
            this.Load += new System.EventHandler(this.fmAddBall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ballBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decanatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.ComboBox comboBoxVid;
        private System.Windows.Forms.NumericUpDown numericUpDownBall;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonEnd;
        private DecanatDataSet decanatDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DecanatDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private DecanatDataSetTableAdapters.SubjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.BindingSource ballBindingSource;
        private DecanatDataSetTableAdapters.BallTableAdapter ballTableAdapter;
        private System.Windows.Forms.BindingSource subjectBindingSource1;
        private DecanatDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}