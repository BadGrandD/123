
namespace Practice
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelFio = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.txtFio = new System.Windows.Forms.TextBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelTheme = new System.Windows.Forms.Label();
            this.txtTheme1 = new System.Windows.Forms.TextBox();
            this.btnSaveIntoBase = new System.Windows.Forms.Button();
            this.btnSaveIntoWord = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(352, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 0;
            // 
            // labelFio
            // 
            this.labelFio.AutoSize = true;
            this.labelFio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFio.Location = new System.Drawing.Point(81, 9);
            this.labelFio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFio.Name = "labelFio";
            this.labelFio.Size = new System.Drawing.Size(46, 21);
            this.labelFio.TabIndex = 6;
            this.labelFio.Text = "ФИО";
            this.labelFio.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGroup.Location = new System.Drawing.Point(65, 42);
            this.labelGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(62, 21);
            this.labelGroup.TabIndex = 7;
            this.labelGroup.Text = "Группа";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(81, 75);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(45, 21);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Дата";
            // 
            // txtFio
            // 
            this.txtFio.Enabled = false;
            this.txtFio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFio.Location = new System.Drawing.Point(131, 6);
            this.txtFio.Margin = new System.Windows.Forms.Padding(2);
            this.txtFio.Name = "txtFio";
            this.txtFio.Size = new System.Drawing.Size(391, 29);
            this.txtFio.TabIndex = 9;
            // 
            // txtGroup
            // 
            this.txtGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGroup.Location = new System.Drawing.Point(131, 39);
            this.txtGroup.Margin = new System.Windows.Forms.Padding(2);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(149, 29);
            this.txtGroup.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 23);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTheme.Location = new System.Drawing.Point(45, 101);
            this.labelTheme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(81, 21);
            this.labelTheme.TabIndex = 12;
            this.labelTheme.Text = "Тема ВКР";
            // 
            // txtTheme1
            // 
            this.txtTheme1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTheme1.Location = new System.Drawing.Point(131, 101);
            this.txtTheme1.Margin = new System.Windows.Forms.Padding(2);
            this.txtTheme1.Multiline = true;
            this.txtTheme1.Name = "txtTheme1";
            this.txtTheme1.Size = new System.Drawing.Size(391, 79);
            this.txtTheme1.TabIndex = 13;
            // 
            // btnSaveIntoBase
            // 
            this.btnSaveIntoBase.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSaveIntoBase.Location = new System.Drawing.Point(131, 184);
            this.btnSaveIntoBase.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveIntoBase.Name = "btnSaveIntoBase";
            this.btnSaveIntoBase.Size = new System.Drawing.Size(124, 68);
            this.btnSaveIntoBase.TabIndex = 14;
            this.btnSaveIntoBase.Text = "ЗАПИСАТЬ в БД";
            this.btnSaveIntoBase.UseVisualStyleBackColor = true;
            this.btnSaveIntoBase.Click += new System.EventHandler(this.btnSaveIntoBase_Click);
            // 
            // btnSaveIntoWord
            // 
            this.btnSaveIntoWord.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSaveIntoWord.Location = new System.Drawing.Point(259, 184);
            this.btnSaveIntoWord.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveIntoWord.Name = "btnSaveIntoWord";
            this.btnSaveIntoWord.Size = new System.Drawing.Size(138, 68);
            this.btnSaveIntoWord.TabIndex = 15;
            this.btnSaveIntoWord.Text = "СОХРАНИТЬ в WORD";
            this.btnSaveIntoWord.UseVisualStyleBackColor = true;
            this.btnSaveIntoWord.Click += new System.EventHandler(this.btnSaveIntoWord_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Location = new System.Drawing.Point(401, 184);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 68);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "ЗАКРЫТЬ ФОРМУ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormFill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 308);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveIntoWord);
            this.Controls.Add(this.btnSaveIntoBase);
            this.Controls.Add(this.txtTheme1);
            this.Controls.Add(this.labelTheme);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.txtFio);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelFio);
            this.Controls.Add(this.label1);
            this.Name = "FormFill";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFio;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox txtFio;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.TextBox txtTheme1;
        private System.Windows.Forms.Button btnSaveIntoBase;
        private System.Windows.Forms.Button btnSaveIntoWord;
        private System.Windows.Forms.Button btnCancel;
    }
}