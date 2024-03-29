
namespace DataBase.Forms
{
    partial class fmPredmet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPredmet));
            this.decanatDataSet = new DataBase.DecanatDataSet();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectTableAdapter = new DataBase.DecanatDataSetTableAdapters.SubjectTableAdapter();
            this.tableAdapterManager = new DataBase.DecanatDataSetTableAdapters.TableAdapterManager();
            this.subjectBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.subjectBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.subjectDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTerm = new System.Windows.Forms.Label();
            this.comboBoxTerm = new System.Windows.Forms.ComboBox();
            this.buttonFil = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.decanatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingNavigator)).BeginInit();
            this.subjectBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BallTableAdapter = null;
            this.tableAdapterManager.GroupTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.SubjectTableAdapter = this.subjectTableAdapter;
            this.tableAdapterManager.UpdateOrder = DataBase.DecanatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // subjectBindingNavigator
            // 
            this.subjectBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.subjectBindingNavigator.BindingSource = this.subjectBindingSource;
            this.subjectBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.subjectBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.subjectBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.subjectBindingNavigatorSaveItem});
            this.subjectBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.subjectBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.subjectBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.subjectBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.subjectBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.subjectBindingNavigator.Name = "subjectBindingNavigator";
            this.subjectBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.subjectBindingNavigator.Size = new System.Drawing.Size(684, 25);
            this.subjectBindingNavigator.TabIndex = 0;
            this.subjectBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // subjectBindingNavigatorSaveItem
            // 
            this.subjectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.subjectBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("subjectBindingNavigatorSaveItem.Image")));
            this.subjectBindingNavigatorSaveItem.Name = "subjectBindingNavigatorSaveItem";
            this.subjectBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.subjectBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.subjectBindingNavigatorSaveItem.Click += new System.EventHandler(this.subjectBindingNavigatorSaveItem_Click);
            // 
            // subjectDataGridView
            // 
            this.subjectDataGridView.AutoGenerateColumns = false;
            this.subjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.subjectDataGridView.DataSource = this.subjectBindingSource;
            this.subjectDataGridView.Location = new System.Drawing.Point(12, 42);
            this.subjectDataGridView.Name = "subjectDataGridView";
            this.subjectDataGridView.Size = new System.Drawing.Size(372, 194);
            this.subjectDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_subject";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_subject";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name_subject";
            this.dataGridViewTextBoxColumn2.HeaderText = "Предмет";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "semestr";
            this.dataGridViewTextBoxColumn3.HeaderText = "Семестр";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Count_Hour";
            this.dataGridViewTextBoxColumn4.HeaderText = "Часы";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // labelTerm
            // 
            this.labelTerm.AutoSize = true;
            this.labelTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTerm.Location = new System.Drawing.Point(14, 246);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(79, 20);
            this.labelTerm.TabIndex = 2;
            this.labelTerm.Text = "Семестр:";
            // 
            // comboBoxTerm
            // 
            this.comboBoxTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTerm.FormattingEnabled = true;
            this.comboBoxTerm.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxTerm.Location = new System.Drawing.Point(99, 243);
            this.comboBoxTerm.Name = "comboBoxTerm";
            this.comboBoxTerm.Size = new System.Drawing.Size(59, 28);
            this.comboBoxTerm.TabIndex = 3;
            // 
            // buttonFil
            // 
            this.buttonFil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFil.Location = new System.Drawing.Point(164, 242);
            this.buttonFil.Name = "buttonFil";
            this.buttonFil.Size = new System.Drawing.Size(124, 29);
            this.buttonFil.TabIndex = 4;
            this.buttonFil.Text = "Фильтровать";
            this.buttonFil.UseVisualStyleBackColor = true;
            this.buttonFil.Click += new System.EventHandler(this.buttonFil_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowAll.Location = new System.Drawing.Point(294, 242);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(90, 29);
            this.buttonShowAll.TabIndex = 5;
            this.buttonShowAll.Text = "Показать все";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // fmPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonFil);
            this.Controls.Add(this.comboBoxTerm);
            this.Controls.Add(this.labelTerm);
            this.Controls.Add(this.subjectDataGridView);
            this.Controls.Add(this.subjectBindingNavigator);
            this.Name = "fmPredmet";
            this.Text = "Дисциплины";
            this.Load += new System.EventHandler(this.fmPredmet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.decanatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingNavigator)).EndInit();
            this.subjectBindingNavigator.ResumeLayout(false);
            this.subjectBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DecanatDataSet decanatDataSet;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private DecanatDataSetTableAdapters.SubjectTableAdapter subjectTableAdapter;
        private DecanatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator subjectBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton subjectBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView subjectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label labelTerm;
        private System.Windows.Forms.ComboBox comboBoxTerm;
        private System.Windows.Forms.Button buttonFil;
        private System.Windows.Forms.Button buttonShowAll;
    }
}