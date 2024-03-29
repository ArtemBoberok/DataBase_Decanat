
namespace DataBase.Forms
{
    partial class fmStudent
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
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label place_birthdayLabel;
            System.Windows.Forms.Label id_groupLabel1;
            System.Windows.Forms.Label maleLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmStudent));
            this.decanatDataSet = new DataBase.DecanatDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new DataBase.DecanatDataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new DataBase.DecanatDataSetTableAdapters.TableAdapterManager();
            this.studentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.studentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.place_birthdayTextBox = new System.Windows.Forms.TextBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupTableAdapter = new DataBase.DecanatDataSetTableAdapters.GroupTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maleComboBox = new System.Windows.Forms.ComboBox();
            fIOLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            place_birthdayLabel = new System.Windows.Forms.Label();
            id_groupLabel1 = new System.Windows.Forms.Label();
            maleLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.decanatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).BeginInit();
            this.studentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fIOLabel.Location = new System.Drawing.Point(77, 82);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(67, 20);
            fIOLabel.TabIndex = 3;
            fIOLabel.Text = "Ф.И.О. :";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            birthdayLabel.Location = new System.Drawing.Point(12, 150);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(132, 20);
            birthdayLabel.TabIndex = 7;
            birthdayLabel.Text = "День рождения:";
            // 
            // place_birthdayLabel
            // 
            place_birthdayLabel.AutoSize = true;
            place_birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            place_birthdayLabel.Location = new System.Drawing.Point(3, 180);
            place_birthdayLabel.Name = "place_birthdayLabel";
            place_birthdayLabel.Size = new System.Drawing.Size(141, 20);
            place_birthdayLabel.TabIndex = 9;
            place_birthdayLabel.Text = "Место рождения:";
            // 
            // id_groupLabel1
            // 
            id_groupLabel1.AutoSize = true;
            id_groupLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_groupLabel1.Location = new System.Drawing.Point(79, 48);
            id_groupLabel1.Name = "id_groupLabel1";
            id_groupLabel1.Size = new System.Drawing.Size(65, 20);
            id_groupLabel1.TabIndex = 11;
            id_groupLabel1.Text = "Группа:";
            // 
            // maleLabel1
            // 
            maleLabel1.AutoSize = true;
            maleLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            maleLabel1.Location = new System.Drawing.Point(97, 114);
            maleLabel1.Name = "maleLabel1";
            maleLabel1.Size = new System.Drawing.Size(44, 20);
            maleLabel1.TabIndex = 12;
            maleLabel1.Text = "Пол:";
            // 
            // decanatDataSet
            // 
            this.decanatDataSet.DataSetName = "DecanatDataSet";
            this.decanatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.decanatDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BallTableAdapter = null;
            this.tableAdapterManager.GroupTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.SubjectTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataBase.DecanatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentBindingNavigator
            // 
            this.studentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentBindingNavigator.BindingSource = this.studentBindingSource;
            this.studentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studentBindingNavigatorSaveItem});
            this.studentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentBindingNavigator.Name = "studentBindingNavigator";
            this.studentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentBindingNavigator.Size = new System.Drawing.Size(684, 25);
            this.studentBindingNavigator.TabIndex = 0;
            this.studentBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // studentBindingNavigatorSaveItem
            // 
            this.studentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentBindingNavigatorSaveItem.Image")));
            this.studentBindingNavigatorSaveItem.Name = "studentBindingNavigatorSaveItem";
            this.studentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.studentBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentBindingNavigatorSaveItem_Click_1);
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FIO", true));
            this.fIOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fIOTextBox.Location = new System.Drawing.Point(150, 79);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(211, 26);
            this.fIOTextBox.TabIndex = 4;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentBindingSource, "Birthday", true));
            this.birthdayDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(150, 145);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(211, 26);
            this.birthdayDateTimePicker.TabIndex = 8;
            // 
            // place_birthdayTextBox
            // 
            this.place_birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Place_birthday", true));
            this.place_birthdayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.place_birthdayTextBox.Location = new System.Drawing.Point(150, 177);
            this.place_birthdayTextBox.Name = "place_birthdayTextBox";
            this.place_birthdayTextBox.Size = new System.Drawing.Size(211, 26);
            this.place_birthdayTextBox.TabIndex = 10;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.decanatDataSet;
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "id_group", true));
            this.comboBox1.DataSource = this.groupBindingSource;
            this.comboBox1.DisplayMember = "Name_group";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 28);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "Id_group";
            // 
            // maleComboBox
            // 
            this.maleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "male", true));
            this.maleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maleComboBox.FormattingEnabled = true;
            this.maleComboBox.Items.AddRange(new object[] {
            "m",
            "w"});
            this.maleComboBox.Location = new System.Drawing.Point(150, 111);
            this.maleComboBox.Name = "maleComboBox";
            this.maleComboBox.Size = new System.Drawing.Size(211, 28);
            this.maleComboBox.TabIndex = 13;
            // 
            // fmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(maleLabel1);
            this.Controls.Add(this.maleComboBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(id_groupLabel1);
            this.Controls.Add(place_birthdayLabel);
            this.Controls.Add(this.place_birthdayTextBox);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(fIOLabel);
            this.Controls.Add(this.fIOTextBox);
            this.Controls.Add(this.studentBindingNavigator);
            this.Name = "fmStudent";
            this.Text = "Студенты";
            this.Load += new System.EventHandler(this.fmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.decanatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).EndInit();
            this.studentBindingNavigator.ResumeLayout(false);
            this.studentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DecanatDataSet decanatDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DecanatDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private DecanatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox place_birthdayTextBox;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private DecanatDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox maleComboBox;
    }
}