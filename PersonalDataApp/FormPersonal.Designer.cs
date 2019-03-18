namespace PersonalDataApp
{
    partial class FormPersonal
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
            this.textPerekonnanimi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numPalk = new System.Windows.Forms.NumericUpDown();
            this.dateSunnipaev = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSugu = new System.Windows.Forms.ComboBox();
            this.textEesnimi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddEdit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPalk)).BeginInit();
            this.SuspendLayout();
            // 
            // textPerekonnanimi
            // 
            this.textPerekonnanimi.Location = new System.Drawing.Point(137, 19);
            this.textPerekonnanimi.Name = "textPerekonnanimi";
            this.textPerekonnanimi.Size = new System.Drawing.Size(181, 20);
            this.textPerekonnanimi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add/Edit to Personal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numPalk);
            this.groupBox1.Controls.Add(this.dateSunnipaev);
            this.groupBox1.Controls.Add(this.comboBoxSugu);
            this.groupBox1.Controls.Add(this.textEesnimi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textPerekonnanimi);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 159);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Palk:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sünnipäev:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sugu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Eesnimi:";
            // 
            // numPalk
            // 
            this.numPalk.DecimalPlaces = 2;
            this.numPalk.Location = new System.Drawing.Point(137, 128);
            this.numPalk.Name = "numPalk";
            this.numPalk.Size = new System.Drawing.Size(181, 20);
            this.numPalk.TabIndex = 5;
            // 
            // dateSunnipaev
            // 
            this.dateSunnipaev.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSunnipaev.Location = new System.Drawing.Point(137, 101);
            this.dateSunnipaev.Name = "dateSunnipaev";
            this.dateSunnipaev.Size = new System.Drawing.Size(181, 20);
            this.dateSunnipaev.TabIndex = 4;
            // 
            // comboBoxSugu
            // 
            this.comboBoxSugu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSugu.FormattingEnabled = true;
            this.comboBoxSugu.Location = new System.Drawing.Point(137, 73);
            this.comboBoxSugu.Name = "comboBoxSugu";
            this.comboBoxSugu.Size = new System.Drawing.Size(181, 21);
            this.comboBoxSugu.TabIndex = 3;
            // 
            // textEesnimi
            // 
            this.textEesnimi.Location = new System.Drawing.Point(137, 46);
            this.textEesnimi.Name = "textEesnimi";
            this.textEesnimi.Size = new System.Drawing.Size(181, 20);
            this.textEesnimi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Perekonnanimi:";
            // 
            // buttonAddEdit
            // 
            this.buttonAddEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddEdit.Location = new System.Drawing.Point(269, 206);
            this.buttonAddEdit.Name = "buttonAddEdit";
            this.buttonAddEdit.Size = new System.Drawing.Size(67, 23);
            this.buttonAddEdit.TabIndex = 3;
            this.buttonAddEdit.Text = "Add/Save";
            this.buttonAddEdit.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(200, 206);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(63, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(12, 9);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(25, 20);
            this.textId.TabIndex = 5;
            this.textId.Visible = false;
            // 
            // FormPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 241);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPersonal";
            this.Text = "FormPersonal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPalk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPerekonnanimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPalk;
        private System.Windows.Forms.DateTimePicker dateSunnipaev;
        private System.Windows.Forms.ComboBox comboBoxSugu;
        private System.Windows.Forms.TextBox textEesnimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddEdit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textId;
    }
}