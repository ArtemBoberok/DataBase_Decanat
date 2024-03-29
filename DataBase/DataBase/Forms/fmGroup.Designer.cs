
namespace DataBase.Forms
{
    partial class fmGroup
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
            System.Windows.Forms.Label name_groupLabel;
            System.Windows.Forms.Label kursLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmGroup));
            this.decanatDataSet = new DataBase.DecanatDataSet();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupTableAdapter = new DataBase.DecanatDataSetTableAdapters.GroupTableAdapter();
            this.tableAdapterManager = new DataBase.DecanatDataSetTableAdapters.TableAdapterManager();
            this.groupBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.groupBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.name_groupTextBox = new System.Windows.Forms.TextBox();
            this.kursTextBox = new System.Windows.Forms.TextBox();
            name_groupLabel = new System.Windows.Forms.Label();
            kursLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.decanatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingNavigator)).BeginInit();
            this.groupBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_groupLabel
            // 
            name_groupLabel.AutoSize = true;
            name_groupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_groupLabel.Location = new System.Drawing.Point(19, 48);
            name_groupLabel.Name = "name_groupLabel";
            name_groupLabel.Size = new System.Drawing.Size(143, 20);
            name_groupLabel.TabIndex = 1;
            name_groupLabel.Text = "Название группы:";
            // 
            // kursLabel
            // 
            kursLabel.AutoSize = true;
            kursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kursLabel.Location = new System.Drawing.Point(117, 90);
            kursLabel.Name = "kursLabel";
            kursLabel.Size = new System.Drawing.Size(47, 20);
            kursLabel.TabIndex = 3;
            kursLabel.Text = "Курс:";
            // 
            // decanatDataSet
            // 
            this.decanatDataSet.DataSetName = "DecanatDataSet";
            this.decanatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BallTableAdapter = null;
            this.tableAdapterManager.GroupTableAdapter = this.groupTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.SubjectTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataBase.DecanatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBindingNavigator
            // 
            this.groupBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.groupBindingNavigator.BindingSource = this.groupBindingSource;
            this.groupBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.groupBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.groupBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.groupBindingNavigatorSaveItem});
            this.groupBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.groupBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.groupBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.groupBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.groupBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.groupBindingNavigator.Name = "groupBindingNavigator";
            this.groupBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.groupBindingNavigator.Size = new System.Drawing.Size(302, 25);
            this.groupBindingNavigator.TabIndex = 0;
            this.groupBindingNavigator.Text = "bindingNavigator1";
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
            // groupBindingNavigatorSaveItem
            // 
            this.groupBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.groupBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("groupBindingNavigatorSaveItem.Image")));
            this.groupBindingNavigatorSaveItem.Name = "groupBindingNavigatorSaveItem";
            this.groupBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.groupBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.groupBindingNavigatorSaveItem.Click += new System.EventHandler(this.groupBindingNavigatorSaveItem_Click);
            // 
            // name_groupTextBox
            // 
            this.name_groupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Name_group", true));
            this.name_groupTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_groupTextBox.Location = new System.Drawing.Point(168, 45);
            this.name_groupTextBox.Name = "name_groupTextBox";
            this.name_groupTextBox.Size = new System.Drawing.Size(114, 26);
            this.name_groupTextBox.TabIndex = 2;
            // 
            // kursTextBox
            // 
            this.kursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Kurs", true));
            this.kursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kursTextBox.Location = new System.Drawing.Point(168, 87);
            this.kursTextBox.Name = "kursTextBox";
            this.kursTextBox.Size = new System.Drawing.Size(114, 26);
            this.kursTextBox.TabIndex = 4;
            // 
            // fmGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(302, 130);
            this.Controls.Add(kursLabel);
            this.Controls.Add(this.kursTextBox);
            this.Controls.Add(name_groupLabel);
            this.Controls.Add(this.name_groupTextBox);
            this.Controls.Add(this.groupBindingNavigator);
            this.Name = "fmGroup";
            this.Text = "Справочник групп";
            this.Load += new System.EventHandler(this.fmGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.decanatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingNavigator)).EndInit();
            this.groupBindingNavigator.ResumeLayout(false);
            this.groupBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DecanatDataSet decanatDataSet;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private DecanatDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
        private DecanatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator groupBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton groupBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox name_groupTextBox;
        private System.Windows.Forms.TextBox kursTextBox;
    }
}