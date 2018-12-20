namespace PenaltyManager
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button_removeViolation = new System.Windows.Forms.Button();
            this.button_editViolation = new System.Windows.Forms.Button();
            this.button_addViolation = new System.Windows.Forms.Button();
            this.grid_violations = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_manageInsurances = new System.Windows.Forms.Button();
            this.button_editDriverCarConnection = new System.Windows.Forms.Button();
            this.button_editRemoveFoundEntity = new System.Windows.Forms.Button();
            this.button_addDriverCarConnection = new System.Windows.Forms.Button();
            this.button_addCar = new System.Windows.Forms.Button();
            this.button_addDriver = new System.Windows.Forms.Button();
            this.label_resultDriverName_CarNumber = new System.Windows.Forms.LinkLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView_searchResults = new System.Windows.Forms.DataGridView();
            this.label_driverOrCar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_carNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_driverSurname = new System.Windows.Forms.TextBox();
            this.textBox_driverName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button_manufacturerRemove = new System.Windows.Forms.Button();
            this.button_manufacturerAdd = new System.Windows.Forms.Button();
            this.button_manufacturereUpdate = new System.Windows.Forms.Button();
            this.grid_models = new System.Windows.Forms.DataGridView();
            this.grid_car_manufacturers = new System.Windows.Forms.DataGridView();
            this.grid_car_colors = new System.Windows.Forms.DataGridView();
            this.grid_violation_types = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_removeColor = new System.Windows.Forms.Button();
            this.button_addColor = new System.Windows.Forms.Button();
            this.button_updateColor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_modelsRemoval = new System.Windows.Forms.Button();
            this.button_modelAddition = new System.Windows.Forms.Button();
            this.button_updateModels = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_removeViolationType = new System.Windows.Forms.Button();
            this.button_addViolationType = new System.Windows.Forms.Button();
            this.button_add_violation = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.manufacturersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roadPenaltiesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roadPenaltiesDataSet = new PenaltyManager.RoadPenaltiesDataSet();
            this.violationTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.colorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voilationTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.voilationTypeTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.VoilationTypeTableAdapter();
            this.colorsTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.ColorsTableAdapter();
            this.manufacturersTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.ManufacturersTableAdapter();
            this.voilationTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.label_userName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_violations)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_searchResults)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_models)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_car_manufacturers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_car_colors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_violation_types)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voilationTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voilationTypeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 433);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.grid_violations);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(804, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Violations information";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGray;
            this.panel7.Controls.Add(this.button_removeViolation);
            this.panel7.Controls.Add(this.button_editViolation);
            this.panel7.Controls.Add(this.button_addViolation);
            this.panel7.Location = new System.Drawing.Point(3, 360);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(795, 44);
            this.panel7.TabIndex = 1;
            // 
            // button_removeViolation
            // 
            this.button_removeViolation.Location = new System.Drawing.Point(540, 3);
            this.button_removeViolation.Name = "button_removeViolation";
            this.button_removeViolation.Size = new System.Drawing.Size(174, 36);
            this.button_removeViolation.TabIndex = 2;
            this.button_removeViolation.Text = "Remove violation";
            this.button_removeViolation.UseVisualStyleBackColor = true;
            this.button_removeViolation.Click += new System.EventHandler(this.button_removeViolation_Click);
            // 
            // button_editViolation
            // 
            this.button_editViolation.Location = new System.Drawing.Point(290, 3);
            this.button_editViolation.Name = "button_editViolation";
            this.button_editViolation.Size = new System.Drawing.Size(223, 36);
            this.button_editViolation.TabIndex = 1;
            this.button_editViolation.Text = "Edit violation";
            this.button_editViolation.UseVisualStyleBackColor = true;
            this.button_editViolation.Click += new System.EventHandler(this.button_editViolation_Click);
            // 
            // button_addViolation
            // 
            this.button_addViolation.Location = new System.Drawing.Point(97, 3);
            this.button_addViolation.Name = "button_addViolation";
            this.button_addViolation.Size = new System.Drawing.Size(164, 36);
            this.button_addViolation.TabIndex = 0;
            this.button_addViolation.Text = "Add violation";
            this.button_addViolation.UseVisualStyleBackColor = true;
            this.button_addViolation.Click += new System.EventHandler(this.button_addViolation_Click);
            // 
            // grid_violations
            // 
            this.grid_violations.AllowUserToAddRows = false;
            this.grid_violations.AllowUserToDeleteRows = false;
            this.grid_violations.AllowUserToOrderColumns = true;
            this.grid_violations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_violations.Location = new System.Drawing.Point(3, 3);
            this.grid_violations.Name = "grid_violations";
            this.grid_violations.RowHeadersVisible = false;
            this.grid_violations.Size = new System.Drawing.Size(798, 354);
            this.grid_violations.TabIndex = 0;
            this.grid_violations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_violations_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.button_manageInsurances);
            this.tabPage2.Controls.Add(this.button_editDriverCarConnection);
            this.tabPage2.Controls.Add(this.button_editRemoveFoundEntity);
            this.tabPage2.Controls.Add(this.button_addDriverCarConnection);
            this.tabPage2.Controls.Add(this.button_addCar);
            this.tabPage2.Controls.Add(this.button_addDriver);
            this.tabPage2.Controls.Add(this.label_resultDriverName_CarNumber);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.dataGridView_searchResults);
            this.tabPage2.Controls.Add(this.label_driverOrCar);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox_carNumber);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBox_driverSurname);
            this.tabPage2.Controls.Add(this.textBox_driverName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(804, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cars and drivers management";
            // 
            // button_manageInsurances
            // 
            this.button_manageInsurances.Location = new System.Drawing.Point(13, 260);
            this.button_manageInsurances.Name = "button_manageInsurances";
            this.button_manageInsurances.Size = new System.Drawing.Size(195, 23);
            this.button_manageInsurances.TabIndex = 33;
            this.button_manageInsurances.Text = "Manage insurances";
            this.button_manageInsurances.UseVisualStyleBackColor = true;
            this.button_manageInsurances.Click += new System.EventHandler(this.button_manageInsurances_Click);
            // 
            // button_editDriverCarConnection
            // 
            this.button_editDriverCarConnection.Location = new System.Drawing.Point(108, 347);
            this.button_editDriverCarConnection.Name = "button_editDriverCarConnection";
            this.button_editDriverCarConnection.Size = new System.Drawing.Size(100, 52);
            this.button_editDriverCarConnection.TabIndex = 32;
            this.button_editDriverCarConnection.Text = "Remove selected driver-car connection";
            this.button_editDriverCarConnection.UseVisualStyleBackColor = true;
            this.button_editDriverCarConnection.Click += new System.EventHandler(this.button_editDriverCarConnection_Click);
            // 
            // button_editRemoveFoundEntity
            // 
            this.button_editRemoveFoundEntity.Location = new System.Drawing.Point(13, 347);
            this.button_editRemoveFoundEntity.Name = "button_editRemoveFoundEntity";
            this.button_editRemoveFoundEntity.Size = new System.Drawing.Size(89, 52);
            this.button_editRemoveFoundEntity.TabIndex = 31;
            this.button_editRemoveFoundEntity.Text = "Edit/remove found entity";
            this.button_editRemoveFoundEntity.UseVisualStyleBackColor = true;
            // 
            // button_addDriverCarConnection
            // 
            this.button_addDriverCarConnection.Location = new System.Drawing.Point(108, 289);
            this.button_addDriverCarConnection.Name = "button_addDriverCarConnection";
            this.button_addDriverCarConnection.Size = new System.Drawing.Size(100, 52);
            this.button_addDriverCarConnection.TabIndex = 30;
            this.button_addDriverCarConnection.Text = "Create new driver-car connection";
            this.button_addDriverCarConnection.UseVisualStyleBackColor = true;
            this.button_addDriverCarConnection.Click += new System.EventHandler(this.button_addDriverCarConnection_Click);
            // 
            // button_addCar
            // 
            this.button_addCar.Location = new System.Drawing.Point(12, 318);
            this.button_addCar.Name = "button_addCar";
            this.button_addCar.Size = new System.Drawing.Size(90, 23);
            this.button_addCar.TabIndex = 29;
            this.button_addCar.Text = "Add a car";
            this.button_addCar.UseVisualStyleBackColor = true;
            this.button_addCar.Click += new System.EventHandler(this.button_addCar_Click);
            // 
            // button_addDriver
            // 
            this.button_addDriver.Location = new System.Drawing.Point(12, 289);
            this.button_addDriver.Name = "button_addDriver";
            this.button_addDriver.Size = new System.Drawing.Size(90, 23);
            this.button_addDriver.TabIndex = 28;
            this.button_addDriver.Text = "Add a driver";
            this.button_addDriver.UseVisualStyleBackColor = true;
            this.button_addDriver.Click += new System.EventHandler(this.button_addDriver_Click);
            // 
            // label_resultDriverName_CarNumber
            // 
            this.label_resultDriverName_CarNumber.AutoSize = true;
            this.label_resultDriverName_CarNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_resultDriverName_CarNumber.Location = new System.Drawing.Point(9, 201);
            this.label_resultDriverName_CarNumber.Name = "label_resultDriverName_CarNumber";
            this.label_resultDriverName_CarNumber.Size = new System.Drawing.Size(80, 20);
            this.label_resultDriverName_CarNumber.TabIndex = 27;
            this.label_resultDriverName_CarNumber.TabStop = true;
            this.label_resultDriverName_CarNumber.Text = "linkLabel1";
            this.label_resultDriverName_CarNumber.Visible = false;
            this.label_resultDriverName_CarNumber.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_resultDriverName_CarNumber_LinkClicked);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(419, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 26;
            this.textBox2.Text = "Search results";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView_searchResults
            // 
            this.dataGridView_searchResults.AllowUserToAddRows = false;
            this.dataGridView_searchResults.AllowUserToDeleteRows = false;
            this.dataGridView_searchResults.AllowUserToOrderColumns = true;
            this.dataGridView_searchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_searchResults.Location = new System.Drawing.Point(214, 30);
            this.dataGridView_searchResults.Name = "dataGridView_searchResults";
            this.dataGridView_searchResults.RowHeadersVisible = false;
            this.dataGridView_searchResults.Size = new System.Drawing.Size(582, 371);
            this.dataGridView_searchResults.TabIndex = 25;
            // 
            // label_driverOrCar
            // 
            this.label_driverOrCar.AutoSize = true;
            this.label_driverOrCar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_driverOrCar.Location = new System.Drawing.Point(135, 172);
            this.label_driverOrCar.Name = "label_driverOrCar";
            this.label_driverOrCar.Size = new System.Drawing.Size(86, 13);
            this.label_driverOrCar.TabIndex = 22;
            this.label_driverOrCar.Text = "DRIVERORCAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(9, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Showing search results for";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(105, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "OR:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_carNumber
            // 
            this.textBox_carNumber.Location = new System.Drawing.Point(108, 103);
            this.textBox_carNumber.Name = "textBox_carNumber";
            this.textBox_carNumber.Size = new System.Drawing.Size(100, 20);
            this.textBox_carNumber.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(9, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Car number";
            // 
            // textBox_driverSurname
            // 
            this.textBox_driverSurname.Location = new System.Drawing.Point(108, 56);
            this.textBox_driverSurname.Name = "textBox_driverSurname";
            this.textBox_driverSurname.Size = new System.Drawing.Size(100, 20);
            this.textBox_driverSurname.TabIndex = 16;
            // 
            // textBox_driverName
            // 
            this.textBox_driverName.Location = new System.Drawing.Point(108, 30);
            this.textBox_driverName.Name = "textBox_driverName";
            this.textBox_driverName.Size = new System.Drawing.Size(100, 20);
            this.textBox_driverName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Driver surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Driver name";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(8, 6);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(200, 20);
            this.textBox8.TabIndex = 12;
            this.textBox8.Text = "Search for drivers or cars";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.panel8);
            this.tabPage3.Controls.Add(this.grid_models);
            this.tabPage3.Controls.Add(this.grid_car_manufacturers);
            this.tabPage3.Controls.Add(this.grid_car_colors);
            this.tabPage3.Controls.Add(this.grid_violation_types);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(804, 407);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Utilities";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(568, 18);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(228, 20);
            this.textBox7.TabIndex = 18;
            this.textBox7.Text = "Car models";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkGray;
            this.panel8.Controls.Add(this.button_manufacturerRemove);
            this.panel8.Controls.Add(this.button_manufacturerAdd);
            this.panel8.Controls.Add(this.button_manufacturereUpdate);
            this.panel8.Location = new System.Drawing.Point(389, 345);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(173, 50);
            this.panel8.TabIndex = 13;
            // 
            // button_manufacturerRemove
            // 
            this.button_manufacturerRemove.Location = new System.Drawing.Point(114, 13);
            this.button_manufacturerRemove.Name = "button_manufacturerRemove";
            this.button_manufacturerRemove.Size = new System.Drawing.Size(56, 23);
            this.button_manufacturerRemove.TabIndex = 9;
            this.button_manufacturerRemove.Text = "Remove";
            this.button_manufacturerRemove.UseVisualStyleBackColor = true;
            this.button_manufacturerRemove.Click += new System.EventHandler(this.button_manufacturerRemove_Click);
            // 
            // button_manufacturerAdd
            // 
            this.button_manufacturerAdd.Location = new System.Drawing.Point(3, 13);
            this.button_manufacturerAdd.Name = "button_manufacturerAdd";
            this.button_manufacturerAdd.Size = new System.Drawing.Size(48, 23);
            this.button_manufacturerAdd.TabIndex = 8;
            this.button_manufacturerAdd.Text = "Add";
            this.button_manufacturerAdd.UseVisualStyleBackColor = true;
            this.button_manufacturerAdd.Click += new System.EventHandler(this.button_manufacturerAdd_Click);
            // 
            // button_manufacturereUpdate
            // 
            this.button_manufacturereUpdate.Location = new System.Drawing.Point(57, 13);
            this.button_manufacturereUpdate.Name = "button_manufacturereUpdate";
            this.button_manufacturereUpdate.Size = new System.Drawing.Size(52, 23);
            this.button_manufacturereUpdate.TabIndex = 7;
            this.button_manufacturereUpdate.Text = "Update manufacturers";
            this.button_manufacturereUpdate.UseVisualStyleBackColor = true;
            this.button_manufacturereUpdate.Click += new System.EventHandler(this.button_manufacturereUpdate_Click);
            // 
            // grid_models
            // 
            this.grid_models.AllowUserToAddRows = false;
            this.grid_models.AllowUserToDeleteRows = false;
            this.grid_models.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_models.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_models.Location = new System.Drawing.Point(568, 44);
            this.grid_models.Name = "grid_models";
            this.grid_models.ReadOnly = true;
            this.grid_models.RowHeadersVisible = false;
            this.grid_models.Size = new System.Drawing.Size(228, 295);
            this.grid_models.TabIndex = 17;
            // 
            // grid_car_manufacturers
            // 
            this.grid_car_manufacturers.AllowUserToAddRows = false;
            this.grid_car_manufacturers.AllowUserToDeleteRows = false;
            this.grid_car_manufacturers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_car_manufacturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_car_manufacturers.Location = new System.Drawing.Point(389, 44);
            this.grid_car_manufacturers.Name = "grid_car_manufacturers";
            this.grid_car_manufacturers.ReadOnly = true;
            this.grid_car_manufacturers.RowHeadersVisible = false;
            this.grid_car_manufacturers.Size = new System.Drawing.Size(173, 295);
            this.grid_car_manufacturers.TabIndex = 16;
            // 
            // grid_car_colors
            // 
            this.grid_car_colors.AllowUserToAddRows = false;
            this.grid_car_colors.AllowUserToDeleteRows = false;
            this.grid_car_colors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_car_colors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_car_colors.Location = new System.Drawing.Point(207, 44);
            this.grid_car_colors.Name = "grid_car_colors";
            this.grid_car_colors.ReadOnly = true;
            this.grid_car_colors.RowHeadersVisible = false;
            this.grid_car_colors.Size = new System.Drawing.Size(176, 295);
            this.grid_car_colors.TabIndex = 15;
            this.grid_car_colors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_car_colors_CellContentClick);
            // 
            // grid_violation_types
            // 
            this.grid_violation_types.AllowUserToAddRows = false;
            this.grid_violation_types.AllowUserToDeleteRows = false;
            this.grid_violation_types.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_violation_types.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.grid_violation_types.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_violation_types.Location = new System.Drawing.Point(9, 44);
            this.grid_violation_types.Name = "grid_violation_types";
            this.grid_violation_types.ReadOnly = true;
            this.grid_violation_types.RowHeadersVisible = false;
            this.grid_violation_types.Size = new System.Drawing.Size(192, 295);
            this.grid_violation_types.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.button_removeColor);
            this.panel3.Controls.Add(this.button_addColor);
            this.panel3.Controls.Add(this.button_updateColor);
            this.panel3.Location = new System.Drawing.Point(207, 345);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 50);
            this.panel3.TabIndex = 13;
            // 
            // button_removeColor
            // 
            this.button_removeColor.Location = new System.Drawing.Point(116, 13);
            this.button_removeColor.Name = "button_removeColor";
            this.button_removeColor.Size = new System.Drawing.Size(57, 23);
            this.button_removeColor.TabIndex = 9;
            this.button_removeColor.Text = "Remove";
            this.button_removeColor.UseVisualStyleBackColor = true;
            this.button_removeColor.Click += new System.EventHandler(this.button_removeColor_Click);
            // 
            // button_addColor
            // 
            this.button_addColor.Location = new System.Drawing.Point(4, 13);
            this.button_addColor.Name = "button_addColor";
            this.button_addColor.Size = new System.Drawing.Size(44, 23);
            this.button_addColor.TabIndex = 8;
            this.button_addColor.Text = "Add";
            this.button_addColor.UseVisualStyleBackColor = true;
            this.button_addColor.Click += new System.EventHandler(this.button_addColor_Click);
            // 
            // button_updateColor
            // 
            this.button_updateColor.Location = new System.Drawing.Point(54, 13);
            this.button_updateColor.Name = "button_updateColor";
            this.button_updateColor.Size = new System.Drawing.Size(55, 23);
            this.button_updateColor.TabIndex = 7;
            this.button_updateColor.Text = "Update table";
            this.button_updateColor.UseVisualStyleBackColor = true;
            this.button_updateColor.Click += new System.EventHandler(this.button_updateColor_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.button_modelsRemoval);
            this.panel2.Controls.Add(this.button_modelAddition);
            this.panel2.Controls.Add(this.button_updateModels);
            this.panel2.Location = new System.Drawing.Point(568, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 50);
            this.panel2.TabIndex = 12;
            // 
            // button_modelsRemoval
            // 
            this.button_modelsRemoval.Location = new System.Drawing.Point(150, 13);
            this.button_modelsRemoval.Name = "button_modelsRemoval";
            this.button_modelsRemoval.Size = new System.Drawing.Size(73, 23);
            this.button_modelsRemoval.TabIndex = 10;
            this.button_modelsRemoval.Text = "Remove";
            this.button_modelsRemoval.UseVisualStyleBackColor = true;
            this.button_modelsRemoval.Click += new System.EventHandler(this.button_modelsRemoval_Click);
            // 
            // button_modelAddition
            // 
            this.button_modelAddition.Location = new System.Drawing.Point(4, 13);
            this.button_modelAddition.Name = "button_modelAddition";
            this.button_modelAddition.Size = new System.Drawing.Size(64, 23);
            this.button_modelAddition.TabIndex = 9;
            this.button_modelAddition.Text = "Add";
            this.button_modelAddition.UseVisualStyleBackColor = true;
            this.button_modelAddition.Click += new System.EventHandler(this.button_modelAddition_Click);
            // 
            // button_updateModels
            // 
            this.button_updateModels.Location = new System.Drawing.Point(74, 13);
            this.button_updateModels.Name = "button_updateModels";
            this.button_updateModels.Size = new System.Drawing.Size(70, 23);
            this.button_updateModels.TabIndex = 8;
            this.button_updateModels.Text = "Update";
            this.button_updateModels.UseVisualStyleBackColor = true;
            this.button_updateModels.Click += new System.EventHandler(this.button_updateModels_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.button_removeViolationType);
            this.panel1.Controls.Add(this.button_addViolationType);
            this.panel1.Controls.Add(this.button_add_violation);
            this.panel1.Location = new System.Drawing.Point(9, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 50);
            this.panel1.TabIndex = 10;
            // 
            // button_removeViolationType
            // 
            this.button_removeViolationType.Location = new System.Drawing.Point(132, 13);
            this.button_removeViolationType.Name = "button_removeViolationType";
            this.button_removeViolationType.Size = new System.Drawing.Size(57, 23);
            this.button_removeViolationType.TabIndex = 9;
            this.button_removeViolationType.Text = "Remove";
            this.button_removeViolationType.UseVisualStyleBackColor = true;
            this.button_removeViolationType.Click += new System.EventHandler(this.button_removeViolationType_Click);
            // 
            // button_addViolationType
            // 
            this.button_addViolationType.Location = new System.Drawing.Point(4, 13);
            this.button_addViolationType.Name = "button_addViolationType";
            this.button_addViolationType.Size = new System.Drawing.Size(47, 23);
            this.button_addViolationType.TabIndex = 8;
            this.button_addViolationType.Text = "Add";
            this.button_addViolationType.UseVisualStyleBackColor = true;
            this.button_addViolationType.Click += new System.EventHandler(this.button_addViolationType_Click);
            // 
            // button_add_violation
            // 
            this.button_add_violation.Location = new System.Drawing.Point(57, 13);
            this.button_add_violation.Name = "button_add_violation";
            this.button_add_violation.Size = new System.Drawing.Size(70, 23);
            this.button_add_violation.TabIndex = 7;
            this.button_add_violation.Text = "Update fine";
            this.button_add_violation.UseVisualStyleBackColor = true;
            this.button_add_violation.Click += new System.EventHandler(this.button_add_violation_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(207, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(176, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Car colors";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(389, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Car manufacturers";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Violation types";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // manufacturersBindingSource1
            // 
            this.manufacturersBindingSource1.DataMember = "Manufacturers";
            this.manufacturersBindingSource1.DataSource = this.roadPenaltiesDataSetBindingSource;
            // 
            // roadPenaltiesDataSetBindingSource
            // 
            this.roadPenaltiesDataSetBindingSource.DataSource = this.roadPenaltiesDataSet;
            this.roadPenaltiesDataSetBindingSource.Position = 0;
            // 
            // roadPenaltiesDataSet
            // 
            this.roadPenaltiesDataSet.DataSetName = "RoadPenaltiesDataSet";
            this.roadPenaltiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // violationTypeBindingSource
            // 
            this.violationTypeBindingSource.DataMember = "ViolationType";
            this.violationTypeBindingSource.DataSource = this.roadPenaltiesDataSetBindingSource;
            // 
            // colorsBindingSource2
            // 
            this.colorsBindingSource2.DataMember = "Colors";
            this.colorsBindingSource2.DataSource = this.roadPenaltiesDataSetBindingSource;
            // 
            // colorsBindingSource1
            // 
            this.colorsBindingSource1.DataMember = "Colors";
            this.colorsBindingSource1.DataSource = this.roadPenaltiesDataSetBindingSource;
            // 
            // manufacturersBindingSource
            // 
            this.manufacturersBindingSource.DataMember = "Manufacturers";
            this.manufacturersBindingSource.DataSource = this.roadPenaltiesDataSetBindingSource;
            // 
            // colorsBindingSource
            // 
            this.colorsBindingSource.DataMember = "Colors";
            this.colorsBindingSource.DataSource = this.roadPenaltiesDataSetBindingSource;
            // 
            // voilationTypeBindingSource
            // 
            this.voilationTypeBindingSource.DataMember = "ViolationType";
            this.voilationTypeBindingSource.DataSource = this.roadPenaltiesDataSetBindingSource;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // voilationTypeTableAdapter
            // 
            this.voilationTypeTableAdapter.ClearBeforeFill = true;
            // 
            // colorsTableAdapter
            // 
            this.colorsTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturersTableAdapter
            // 
            this.manufacturersTableAdapter.ClearBeforeFill = true;
            // 
            // voilationTypeBindingSource1
            // 
            this.voilationTypeBindingSource1.DataSource = this.roadPenaltiesDataSetBindingSource;
            this.voilationTypeBindingSource1.Position = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(544, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "You logged in as";
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_userName.Location = new System.Drawing.Point(664, 4);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(46, 17);
            this.label_userName.TabIndex = 3;
            this.label_userName.Text = "label7";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 457);
            this.Controls.Add(this.label_userName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "PenaltyManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_violations)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_searchResults)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_models)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_car_manufacturers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_car_colors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_violation_types)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voilationTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voilationTypeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource roadPenaltiesDataSetBindingSource;
        private RoadPenaltiesDataSet roadPenaltiesDataSet;
        private System.Windows.Forms.BindingSource voilationTypeBindingSource;
        private RoadPenaltiesDataSetTableAdapters.VoilationTypeTableAdapter voilationTypeTableAdapter;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource colorsBindingSource;
        private RoadPenaltiesDataSetTableAdapters.ColorsTableAdapter colorsTableAdapter;
        private System.Windows.Forms.BindingSource manufacturersBindingSource;
        private RoadPenaltiesDataSetTableAdapters.ManufacturersTableAdapter manufacturersTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_updateColor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_add_violation;
        private System.Windows.Forms.BindingSource voilationTypeBindingSource1;
        private System.Windows.Forms.DataGridView grid_car_manufacturers;
        private System.Windows.Forms.BindingSource manufacturersBindingSource1;
        private System.Windows.Forms.DataGridView grid_car_colors;
        private System.Windows.Forms.BindingSource colorsBindingSource1;
        private System.Windows.Forms.DataGridView grid_violation_types;
        private System.Windows.Forms.BindingSource violationTypeBindingSource;
        private System.Windows.Forms.BindingSource colorsBindingSource2;
        private System.Windows.Forms.DataGridView grid_violations;
        private System.Windows.Forms.DataGridView grid_models;
        private System.Windows.Forms.Button button_updateModels;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button_removeViolation;
        private System.Windows.Forms.Button button_editViolation;
        private System.Windows.Forms.Button button_addViolation;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button_manufacturereUpdate;
        private System.Windows.Forms.Button button_addColor;
        private System.Windows.Forms.Button button_removeColor;
        private System.Windows.Forms.Button button_manufacturerRemove;
        private System.Windows.Forms.Button button_manufacturerAdd;
        private System.Windows.Forms.Button button_addViolationType;
        private System.Windows.Forms.Button button_removeViolationType;
        private System.Windows.Forms.Button button_modelAddition;
        private System.Windows.Forms.Button button_modelsRemoval;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView_searchResults;
        private System.Windows.Forms.Label label_driverOrCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_carNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_driverSurname;
        private System.Windows.Forms.TextBox textBox_driverName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.LinkLabel label_resultDriverName_CarNumber;
        private System.Windows.Forms.Button button_editRemoveFoundEntity;
        private System.Windows.Forms.Button button_addDriverCarConnection;
        private System.Windows.Forms.Button button_addCar;
        private System.Windows.Forms.Button button_addDriver;
        private System.Windows.Forms.Button button_editDriverCarConnection;
        private System.Windows.Forms.Button button_manageInsurances;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_userName;
    }
}

