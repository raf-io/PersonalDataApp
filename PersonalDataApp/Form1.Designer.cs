namespace PersonalDataApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPersonalData = new System.Windows.Forms.TabControl();
            this.tabPersonal = new System.Windows.Forms.TabPage();
            this.tabKeeled = new System.Windows.Forms.TabPage();
            this.tabPersonalKeeled = new System.Windows.Forms.TabPage();
            this.tabKeeleTasud = new System.Windows.Forms.TabPage();
            this.tabTooaeg = new System.Windows.Forms.TabPage();
            this.tabPalgad = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEditKeeled = new System.Windows.Forms.Button();
            this.buttonAddKeeled = new System.Windows.Forms.Button();
            this.buttonRemoveKeeled = new System.Windows.Forms.Button();
            this.buttonRefreshKeeled = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEditPersonal = new System.Windows.Forms.Button();
            this.buttonAddPersonal = new System.Windows.Forms.Button();
            this.buttonRemovePersonal = new System.Windows.Forms.Button();
            this.buttonRefreshPersonal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEditPK = new System.Windows.Forms.Button();
            this.buttonAddPK = new System.Windows.Forms.Button();
            this.buttonRemovePK = new System.Windows.Forms.Button();
            this.buttonRefreshPK = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEditKT = new System.Windows.Forms.Button();
            this.buttonAddKT = new System.Windows.Forms.Button();
            this.buttonRemoveKT = new System.Windows.Forms.Button();
            this.buttonRefreshKT = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonEditTooaeg = new System.Windows.Forms.Button();
            this.buttonAddTooaeg = new System.Windows.Forms.Button();
            this.buttonRemoveTooaeg = new System.Windows.Forms.Button();
            this.buttonRefreshTooaeg = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRefreshPalgad = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.buttonFilterPK = new System.Windows.Forms.Button();
            this.buttonFilterPalgad = new System.Windows.Forms.Button();
            this.tabPersonalData.SuspendLayout();
            this.tabPersonal.SuspendLayout();
            this.tabKeeled.SuspendLayout();
            this.tabPersonalKeeled.SuspendLayout();
            this.tabKeeleTasud.SuspendLayout();
            this.tabTooaeg.SuspendLayout();
            this.tabPalgad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPersonalData
            // 
            this.tabPersonalData.Controls.Add(this.tabPersonal);
            this.tabPersonalData.Controls.Add(this.tabKeeled);
            this.tabPersonalData.Controls.Add(this.tabPersonalKeeled);
            this.tabPersonalData.Controls.Add(this.tabKeeleTasud);
            this.tabPersonalData.Controls.Add(this.tabTooaeg);
            this.tabPersonalData.Controls.Add(this.tabPalgad);
            this.tabPersonalData.Location = new System.Drawing.Point(12, 12);
            this.tabPersonalData.Name = "tabPersonalData";
            this.tabPersonalData.SelectedIndex = 0;
            this.tabPersonalData.Size = new System.Drawing.Size(595, 405);
            this.tabPersonalData.TabIndex = 0;
            // 
            // tabPersonal
            // 
            this.tabPersonal.Controls.Add(this.label2);
            this.tabPersonal.Controls.Add(this.buttonEditPersonal);
            this.tabPersonal.Controls.Add(this.buttonAddPersonal);
            this.tabPersonal.Controls.Add(this.buttonRemovePersonal);
            this.tabPersonal.Controls.Add(this.buttonRefreshPersonal);
            this.tabPersonal.Controls.Add(this.dataGridView1);
            this.tabPersonal.Location = new System.Drawing.Point(4, 22);
            this.tabPersonal.Name = "tabPersonal";
            this.tabPersonal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonal.Size = new System.Drawing.Size(587, 379);
            this.tabPersonal.TabIndex = 0;
            this.tabPersonal.Text = "Personal";
            this.tabPersonal.UseVisualStyleBackColor = true;
            // 
            // tabKeeled
            // 
            this.tabKeeled.Controls.Add(this.label1);
            this.tabKeeled.Controls.Add(this.buttonEditKeeled);
            this.tabKeeled.Controls.Add(this.buttonAddKeeled);
            this.tabKeeled.Controls.Add(this.buttonRemoveKeeled);
            this.tabKeeled.Controls.Add(this.buttonRefreshKeeled);
            this.tabKeeled.Controls.Add(this.dataGridView2);
            this.tabKeeled.Location = new System.Drawing.Point(4, 22);
            this.tabKeeled.Name = "tabKeeled";
            this.tabKeeled.Padding = new System.Windows.Forms.Padding(3);
            this.tabKeeled.Size = new System.Drawing.Size(587, 379);
            this.tabKeeled.TabIndex = 1;
            this.tabKeeled.Text = "Keeled";
            this.tabKeeled.UseVisualStyleBackColor = true;
            // 
            // tabPersonalKeeled
            // 
            this.tabPersonalKeeled.Controls.Add(this.buttonFilterPK);
            this.tabPersonalKeeled.Controls.Add(this.label3);
            this.tabPersonalKeeled.Controls.Add(this.buttonEditPK);
            this.tabPersonalKeeled.Controls.Add(this.buttonAddPK);
            this.tabPersonalKeeled.Controls.Add(this.buttonRemovePK);
            this.tabPersonalKeeled.Controls.Add(this.buttonRefreshPK);
            this.tabPersonalKeeled.Controls.Add(this.dataGridView3);
            this.tabPersonalKeeled.Location = new System.Drawing.Point(4, 22);
            this.tabPersonalKeeled.Name = "tabPersonalKeeled";
            this.tabPersonalKeeled.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonalKeeled.Size = new System.Drawing.Size(587, 379);
            this.tabPersonalKeeled.TabIndex = 2;
            this.tabPersonalKeeled.Text = "Personal keeled";
            this.tabPersonalKeeled.UseVisualStyleBackColor = true;
            // 
            // tabKeeleTasud
            // 
            this.tabKeeleTasud.Controls.Add(this.label4);
            this.tabKeeleTasud.Controls.Add(this.buttonEditKT);
            this.tabKeeleTasud.Controls.Add(this.buttonAddKT);
            this.tabKeeleTasud.Controls.Add(this.buttonRemoveKT);
            this.tabKeeleTasud.Controls.Add(this.buttonRefreshKT);
            this.tabKeeleTasud.Controls.Add(this.dataGridView4);
            this.tabKeeleTasud.Location = new System.Drawing.Point(4, 22);
            this.tabKeeleTasud.Name = "tabKeeleTasud";
            this.tabKeeleTasud.Padding = new System.Windows.Forms.Padding(3);
            this.tabKeeleTasud.Size = new System.Drawing.Size(587, 379);
            this.tabKeeleTasud.TabIndex = 3;
            this.tabKeeleTasud.Text = "Keele tasud";
            this.tabKeeleTasud.UseVisualStyleBackColor = true;
            // 
            // tabTooaeg
            // 
            this.tabTooaeg.Controls.Add(this.label5);
            this.tabTooaeg.Controls.Add(this.buttonEditTooaeg);
            this.tabTooaeg.Controls.Add(this.buttonAddTooaeg);
            this.tabTooaeg.Controls.Add(this.buttonRemoveTooaeg);
            this.tabTooaeg.Controls.Add(this.buttonRefreshTooaeg);
            this.tabTooaeg.Controls.Add(this.dataGridView5);
            this.tabTooaeg.Location = new System.Drawing.Point(4, 22);
            this.tabTooaeg.Name = "tabTooaeg";
            this.tabTooaeg.Padding = new System.Windows.Forms.Padding(3);
            this.tabTooaeg.Size = new System.Drawing.Size(587, 379);
            this.tabTooaeg.TabIndex = 4;
            this.tabTooaeg.Text = "Tööaeg";
            this.tabTooaeg.UseVisualStyleBackColor = true;
            // 
            // tabPalgad
            // 
            this.tabPalgad.Controls.Add(this.buttonFilterPalgad);
            this.tabPalgad.Controls.Add(this.label6);
            this.tabPalgad.Controls.Add(this.buttonRefreshPalgad);
            this.tabPalgad.Controls.Add(this.dataGridView6);
            this.tabPalgad.Location = new System.Drawing.Point(4, 22);
            this.tabPalgad.Name = "tabPalgad";
            this.tabPalgad.Padding = new System.Windows.Forms.Padding(3);
            this.tabPalgad.Size = new System.Drawing.Size(587, 379);
            this.tabPalgad.TabIndex = 5;
            this.tabPalgad.Text = "Palgad";
            this.tabPalgad.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(143, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data From \'Keeled\' table";
            // 
            // buttonEditKeeled
            // 
            this.buttonEditKeeled.Location = new System.Drawing.Point(478, 350);
            this.buttonEditKeeled.Name = "buttonEditKeeled";
            this.buttonEditKeeled.Size = new System.Drawing.Size(48, 23);
            this.buttonEditKeeled.TabIndex = 10;
            this.buttonEditKeeled.Text = "Edit";
            this.buttonEditKeeled.UseVisualStyleBackColor = true;
            // 
            // buttonAddKeeled
            // 
            this.buttonAddKeeled.Location = new System.Drawing.Point(532, 350);
            this.buttonAddKeeled.Name = "buttonAddKeeled";
            this.buttonAddKeeled.Size = new System.Drawing.Size(49, 23);
            this.buttonAddKeeled.TabIndex = 9;
            this.buttonAddKeeled.Text = "Add";
            this.buttonAddKeeled.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveKeeled
            // 
            this.buttonRemoveKeeled.Location = new System.Drawing.Point(411, 350);
            this.buttonRemoveKeeled.Name = "buttonRemoveKeeled";
            this.buttonRemoveKeeled.Size = new System.Drawing.Size(61, 23);
            this.buttonRemoveKeeled.TabIndex = 8;
            this.buttonRemoveKeeled.Text = "Remove";
            this.buttonRemoveKeeled.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshKeeled
            // 
            this.buttonRefreshKeeled.Location = new System.Drawing.Point(6, 350);
            this.buttonRefreshKeeled.Name = "buttonRefreshKeeled";
            this.buttonRefreshKeeled.Size = new System.Drawing.Size(57, 23);
            this.buttonRefreshKeeled.TabIndex = 7;
            this.buttonRefreshKeeled.Text = "Refresh";
            this.buttonRefreshKeeled.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(575, 312);
            this.dataGridView2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(143, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data From \'Personal\' table";
            // 
            // buttonEditPersonal
            // 
            this.buttonEditPersonal.Location = new System.Drawing.Point(478, 350);
            this.buttonEditPersonal.Name = "buttonEditPersonal";
            this.buttonEditPersonal.Size = new System.Drawing.Size(48, 23);
            this.buttonEditPersonal.TabIndex = 10;
            this.buttonEditPersonal.Text = "Edit";
            this.buttonEditPersonal.UseVisualStyleBackColor = true;
            // 
            // buttonAddPersonal
            // 
            this.buttonAddPersonal.Location = new System.Drawing.Point(532, 350);
            this.buttonAddPersonal.Name = "buttonAddPersonal";
            this.buttonAddPersonal.Size = new System.Drawing.Size(49, 23);
            this.buttonAddPersonal.TabIndex = 9;
            this.buttonAddPersonal.Text = "Add";
            this.buttonAddPersonal.UseVisualStyleBackColor = true;
            // 
            // buttonRemovePersonal
            // 
            this.buttonRemovePersonal.Location = new System.Drawing.Point(411, 350);
            this.buttonRemovePersonal.Name = "buttonRemovePersonal";
            this.buttonRemovePersonal.Size = new System.Drawing.Size(61, 23);
            this.buttonRemovePersonal.TabIndex = 8;
            this.buttonRemovePersonal.Text = "Remove";
            this.buttonRemovePersonal.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshPersonal
            // 
            this.buttonRefreshPersonal.Location = new System.Drawing.Point(6, 350);
            this.buttonRefreshPersonal.Name = "buttonRefreshPersonal";
            this.buttonRefreshPersonal.Size = new System.Drawing.Size(57, 23);
            this.buttonRefreshPersonal.TabIndex = 7;
            this.buttonRefreshPersonal.Text = "Refresh";
            this.buttonRefreshPersonal.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(575, 312);
            this.dataGridView1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(492, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data From \'PersonalKeeled\' table / Procedure";
            // 
            // buttonEditPK
            // 
            this.buttonEditPK.Location = new System.Drawing.Point(478, 350);
            this.buttonEditPK.Name = "buttonEditPK";
            this.buttonEditPK.Size = new System.Drawing.Size(48, 23);
            this.buttonEditPK.TabIndex = 10;
            this.buttonEditPK.Text = "Edit";
            this.buttonEditPK.UseVisualStyleBackColor = true;
            // 
            // buttonAddPK
            // 
            this.buttonAddPK.Location = new System.Drawing.Point(532, 350);
            this.buttonAddPK.Name = "buttonAddPK";
            this.buttonAddPK.Size = new System.Drawing.Size(49, 23);
            this.buttonAddPK.TabIndex = 9;
            this.buttonAddPK.Text = "Add";
            this.buttonAddPK.UseVisualStyleBackColor = true;
            // 
            // buttonRemovePK
            // 
            this.buttonRemovePK.Location = new System.Drawing.Point(411, 350);
            this.buttonRemovePK.Name = "buttonRemovePK";
            this.buttonRemovePK.Size = new System.Drawing.Size(61, 23);
            this.buttonRemovePK.TabIndex = 8;
            this.buttonRemovePK.Text = "Remove";
            this.buttonRemovePK.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshPK
            // 
            this.buttonRefreshPK.Location = new System.Drawing.Point(6, 350);
            this.buttonRefreshPK.Name = "buttonRefreshPK";
            this.buttonRefreshPK.Size = new System.Drawing.Size(57, 23);
            this.buttonRefreshPK.TabIndex = 7;
            this.buttonRefreshPK.Text = "Refresh";
            this.buttonRefreshPK.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 32);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(575, 312);
            this.dataGridView3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(135, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data From \'KeeleTasud\' table";
            // 
            // buttonEditKT
            // 
            this.buttonEditKT.Location = new System.Drawing.Point(478, 350);
            this.buttonEditKT.Name = "buttonEditKT";
            this.buttonEditKT.Size = new System.Drawing.Size(48, 23);
            this.buttonEditKT.TabIndex = 10;
            this.buttonEditKT.Text = "Edit";
            this.buttonEditKT.UseVisualStyleBackColor = true;
            // 
            // buttonAddKT
            // 
            this.buttonAddKT.Location = new System.Drawing.Point(532, 350);
            this.buttonAddKT.Name = "buttonAddKT";
            this.buttonAddKT.Size = new System.Drawing.Size(49, 23);
            this.buttonAddKT.TabIndex = 9;
            this.buttonAddKT.Text = "Add";
            this.buttonAddKT.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveKT
            // 
            this.buttonRemoveKT.Location = new System.Drawing.Point(411, 350);
            this.buttonRemoveKT.Name = "buttonRemoveKT";
            this.buttonRemoveKT.Size = new System.Drawing.Size(61, 23);
            this.buttonRemoveKT.TabIndex = 8;
            this.buttonRemoveKT.Text = "Remove";
            this.buttonRemoveKT.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshKT
            // 
            this.buttonRefreshKT.Location = new System.Drawing.Point(6, 350);
            this.buttonRefreshKT.Name = "buttonRefreshKT";
            this.buttonRefreshKT.Size = new System.Drawing.Size(57, 23);
            this.buttonRefreshKT.TabIndex = 7;
            this.buttonRefreshKT.Text = "Refresh";
            this.buttonRefreshKT.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 32);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(575, 312);
            this.dataGridView4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(143, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data From \'Tooaeg\' table";
            // 
            // buttonEditTooaeg
            // 
            this.buttonEditTooaeg.Location = new System.Drawing.Point(478, 350);
            this.buttonEditTooaeg.Name = "buttonEditTooaeg";
            this.buttonEditTooaeg.Size = new System.Drawing.Size(48, 23);
            this.buttonEditTooaeg.TabIndex = 10;
            this.buttonEditTooaeg.Text = "Edit";
            this.buttonEditTooaeg.UseVisualStyleBackColor = true;
            // 
            // buttonAddTooaeg
            // 
            this.buttonAddTooaeg.Location = new System.Drawing.Point(532, 350);
            this.buttonAddTooaeg.Name = "buttonAddTooaeg";
            this.buttonAddTooaeg.Size = new System.Drawing.Size(49, 23);
            this.buttonAddTooaeg.TabIndex = 9;
            this.buttonAddTooaeg.Text = "Add";
            this.buttonAddTooaeg.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveTooaeg
            // 
            this.buttonRemoveTooaeg.Location = new System.Drawing.Point(411, 350);
            this.buttonRemoveTooaeg.Name = "buttonRemoveTooaeg";
            this.buttonRemoveTooaeg.Size = new System.Drawing.Size(61, 23);
            this.buttonRemoveTooaeg.TabIndex = 8;
            this.buttonRemoveTooaeg.Text = "Remove";
            this.buttonRemoveTooaeg.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshTooaeg
            // 
            this.buttonRefreshTooaeg.Location = new System.Drawing.Point(6, 350);
            this.buttonRefreshTooaeg.Name = "buttonRefreshTooaeg";
            this.buttonRefreshTooaeg.Size = new System.Drawing.Size(57, 23);
            this.buttonRefreshTooaeg.TabIndex = 7;
            this.buttonRefreshTooaeg.Text = "Refresh";
            this.buttonRefreshTooaeg.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(6, 32);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(575, 312);
            this.dataGridView5.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(182, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Procedure \'Palgad\'";
            // 
            // buttonRefreshPalgad
            // 
            this.buttonRefreshPalgad.Location = new System.Drawing.Point(6, 350);
            this.buttonRefreshPalgad.Name = "buttonRefreshPalgad";
            this.buttonRefreshPalgad.Size = new System.Drawing.Size(57, 23);
            this.buttonRefreshPalgad.TabIndex = 7;
            this.buttonRefreshPalgad.Text = "Refresh";
            this.buttonRefreshPalgad.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(6, 32);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.Size = new System.Drawing.Size(575, 312);
            this.dataGridView6.TabIndex = 6;
            // 
            // buttonFilterPK
            // 
            this.buttonFilterPK.Location = new System.Drawing.Point(69, 350);
            this.buttonFilterPK.Name = "buttonFilterPK";
            this.buttonFilterPK.Size = new System.Drawing.Size(75, 23);
            this.buttonFilterPK.TabIndex = 12;
            this.buttonFilterPK.Text = "Filter output";
            this.buttonFilterPK.UseVisualStyleBackColor = true;
            // 
            // buttonFilterPalgad
            // 
            this.buttonFilterPalgad.Location = new System.Drawing.Point(69, 350);
            this.buttonFilterPalgad.Name = "buttonFilterPalgad";
            this.buttonFilterPalgad.Size = new System.Drawing.Size(75, 23);
            this.buttonFilterPalgad.TabIndex = 13;
            this.buttonFilterPalgad.Text = "Filter output";
            this.buttonFilterPalgad.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 429);
            this.Controls.Add(this.tabPersonalData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPersonalData.ResumeLayout(false);
            this.tabPersonal.ResumeLayout(false);
            this.tabPersonal.PerformLayout();
            this.tabKeeled.ResumeLayout(false);
            this.tabKeeled.PerformLayout();
            this.tabPersonalKeeled.ResumeLayout(false);
            this.tabPersonalKeeled.PerformLayout();
            this.tabKeeleTasud.ResumeLayout(false);
            this.tabKeeleTasud.PerformLayout();
            this.tabTooaeg.ResumeLayout(false);
            this.tabTooaeg.PerformLayout();
            this.tabPalgad.ResumeLayout(false);
            this.tabPalgad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPersonalData;
        private System.Windows.Forms.TabPage tabPersonal;
        private System.Windows.Forms.TabPage tabKeeled;
        private System.Windows.Forms.TabPage tabPersonalKeeled;
        private System.Windows.Forms.TabPage tabKeeleTasud;
        private System.Windows.Forms.TabPage tabTooaeg;
        private System.Windows.Forms.TabPage tabPalgad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEditPersonal;
        private System.Windows.Forms.Button buttonAddPersonal;
        private System.Windows.Forms.Button buttonRemovePersonal;
        private System.Windows.Forms.Button buttonRefreshPersonal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEditKeeled;
        private System.Windows.Forms.Button buttonAddKeeled;
        private System.Windows.Forms.Button buttonRemoveKeeled;
        private System.Windows.Forms.Button buttonRefreshKeeled;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonFilterPK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEditPK;
        private System.Windows.Forms.Button buttonAddPK;
        private System.Windows.Forms.Button buttonRemovePK;
        private System.Windows.Forms.Button buttonRefreshPK;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEditKT;
        private System.Windows.Forms.Button buttonAddKT;
        private System.Windows.Forms.Button buttonRemoveKT;
        private System.Windows.Forms.Button buttonRefreshKT;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonEditTooaeg;
        private System.Windows.Forms.Button buttonAddTooaeg;
        private System.Windows.Forms.Button buttonRemoveTooaeg;
        private System.Windows.Forms.Button buttonRefreshTooaeg;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button buttonFilterPalgad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonRefreshPalgad;
        private System.Windows.Forms.DataGridView dataGridView6;
    }
}

