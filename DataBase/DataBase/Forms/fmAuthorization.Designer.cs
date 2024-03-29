
namespace DataBase.Forms
{
    partial class fmAuthorization
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
            this.panel = new System.Windows.Forms.Panel();
            this.labelAut = new System.Windows.Forms.Label();
            this.labelLog = new System.Windows.Forms.Label();
            this.labelPas = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxPas = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Aqua;
            this.panel.Controls.Add(this.labelAut);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(484, 50);
            this.panel.TabIndex = 0;
            // 
            // labelAut
            // 
            this.labelAut.AutoSize = true;
            this.labelAut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAut.Location = new System.Drawing.Point(174, 9);
            this.labelAut.Name = "labelAut";
            this.labelAut.Size = new System.Drawing.Size(109, 20);
            this.labelAut.TabIndex = 0;
            this.labelAut.Text = "Авторизация";
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLog.Location = new System.Drawing.Point(122, 99);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(55, 20);
            this.labelLog.TabIndex = 1;
            this.labelLog.Text = "Логин";
            // 
            // labelPas
            // 
            this.labelPas.AutoSize = true;
            this.labelPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPas.Location = new System.Drawing.Point(113, 145);
            this.labelPas.Name = "labelPas";
            this.labelPas.Size = new System.Drawing.Size(67, 20);
            this.labelPas.TabIndex = 2;
            this.labelPas.Text = "Пароль";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLog.Location = new System.Drawing.Point(183, 96);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(100, 26);
            this.textBoxLog.TabIndex = 3;
            this.textBoxLog.TextChanged += new System.EventHandler(this.textBoxLog_TextChanged);
            // 
            // textBoxPas
            // 
            this.textBoxPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPas.Location = new System.Drawing.Point(183, 145);
            this.textBoxPas.Name = "textBoxPas";
            this.textBoxPas.PasswordChar = '*';
            this.textBoxPas.Size = new System.Drawing.Size(100, 26);
            this.textBoxPas.TabIndex = 4;
            this.textBoxPas.TextChanged += new System.EventHandler(this.textBoxPas_TextChanged);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter.Location = new System.Drawing.Point(194, 206);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 32);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "войти";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // fmAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxPas);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.labelPas);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.panel);
            this.Name = "fmAuthorization";
            this.Text = "fmAuthorization";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelAut;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Label labelPas;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxPas;
        private System.Windows.Forms.Button buttonEnter;
    }
}