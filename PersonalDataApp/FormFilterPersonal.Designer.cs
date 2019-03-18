namespace PersonalDataApp
{
    partial class FormFilterPersonal
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxKeel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numVA = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTase = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSugu = new System.Windows.Forms.ComboBox();
            this.numVK = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVK)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(149, 172);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(63, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAddEdit
            // 
            this.buttonAddEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddEdit.Location = new System.Drawing.Point(218, 172);
            this.buttonAddEdit.Name = "buttonAddEdit";
            this.buttonAddEdit.Size = new System.Drawing.Size(67, 23);
            this.buttonAddEdit.TabIndex = 9;
            this.buttonAddEdit.Text = "Filter";
            this.buttonAddEdit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numVK);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxSugu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numVA);
            this.groupBox1.Controls.Add(this.comboBoxKeel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxTase);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 158);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // comboBoxKeel
            // 
            this.comboBoxKeel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKeel.FormattingEnabled = true;
            this.comboBoxKeel.Location = new System.Drawing.Point(83, 16);
            this.comboBoxKeel.Name = "comboBoxKeel";
            this.comboBoxKeel.Size = new System.Drawing.Size(181, 21);
            this.comboBoxKeel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vanus alates:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tase:";
            // 
            // numVA
            // 
            this.numVA.Location = new System.Drawing.Point(83, 73);
            this.numVA.Name = "numVA";
            this.numVA.Size = new System.Drawing.Size(112, 20);
            this.numVA.TabIndex = 5;
            // 
            // comboBoxTase
            // 
            this.comboBoxTase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTase.FormattingEnabled = true;
            this.comboBoxTase.Location = new System.Drawing.Point(83, 46);
            this.comboBoxTase.Name = "comboBoxTase";
            this.comboBoxTase.Size = new System.Drawing.Size(181, 21);
            this.comboBoxTase.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keel:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vanus kuni:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sugu:";
            // 
            // comboBoxSugu
            // 
            this.comboBoxSugu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSugu.FormattingEnabled = true;
            this.comboBoxSugu.Location = new System.Drawing.Point(83, 127);
            this.comboBoxSugu.Name = "comboBoxSugu";
            this.comboBoxSugu.Size = new System.Drawing.Size(181, 21);
            this.comboBoxSugu.TabIndex = 11;
            // 
            // numVK
            // 
            this.numVK.Location = new System.Drawing.Point(83, 100);
            this.numVK.Name = "numVK";
            this.numVK.Size = new System.Drawing.Size(112, 20);
            this.numVK.TabIndex = 13;
            this.numVK.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // FormFilterPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 205);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddEdit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFilterPersonal";
            this.Text = "Procedure personal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numVK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSugu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numVA;
        private System.Windows.Forms.ComboBox comboBoxKeel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTase;
        private System.Windows.Forms.Label label2;
    }
}