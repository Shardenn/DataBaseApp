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
            this.dataGridView_violations = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_updateInsurances = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_updateCars = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_updateDrivers = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.grid_insurances = new System.Windows.Forms.DataGridView();
            this.grid_cars = new System.Windows.Forms.DataGridView();
            this.grid_drivers = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grid_car_manufacturers = new System.Windows.Forms.DataGridView();
            this.grid_car_colors = new System.Windows.Forms.DataGridView();
            this.grid_violation_types = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_add_color = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_add_manufacturer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_violations)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_insurances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_drivers)).BeginInit();
            this.tabPage3.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
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
            this.tabControl1.Size = new System.Drawing.Size(829, 382);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.dataGridView_violations);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(821, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Violations information";
            // 
            // dataGridView_violations
            // 
            this.dataGridView_violations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_violations.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_violations.Name = "dataGridView_violations";
            this.dataGridView_violations.Size = new System.Drawing.Size(821, 356);
            this.dataGridView_violations.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.grid_insurances);
            this.tabPage2.Controls.Add(this.grid_cars);
            this.tabPage2.Controls.Add(this.grid_drivers);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(821, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cars and drivers management";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Controls.Add(this.button_updateInsurances);
            this.panel6.Location = new System.Drawing.Point(592, 300);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(180, 50);
            this.panel6.TabIndex = 11;
            // 
            // button_updateInsurances
            // 
            this.button_updateInsurances.Location = new System.Drawing.Point(34, 15);
            this.button_updateInsurances.Name = "button_updateInsurances";
            this.button_updateInsurances.Size = new System.Drawing.Size(116, 23);
            this.button_updateInsurances.TabIndex = 6;
            this.button_updateInsurances.Text = "Update insurances";
            this.button_updateInsurances.UseVisualStyleBackColor = true;
            this.button_updateInsurances.Click += new System.EventHandler(this.button_updateInsurances_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Controls.Add(this.button_updateCars);
            this.panel5.Location = new System.Drawing.Point(321, 300);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 50);
            this.panel5.TabIndex = 10;
            // 
            // button_updateCars
            // 
            this.button_updateCars.Location = new System.Drawing.Point(34, 15);
            this.button_updateCars.Name = "button_updateCars";
            this.button_updateCars.Size = new System.Drawing.Size(116, 23);
            this.button_updateCars.TabIndex = 6;
            this.button_updateCars.Text = "Update automobiles";
            this.button_updateCars.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.button_updateDrivers);
            this.panel4.Location = new System.Drawing.Point(47, 300);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 50);
            this.panel4.TabIndex = 9;
            // 
            // button_updateDrivers
            // 
            this.button_updateDrivers.Location = new System.Drawing.Point(34, 15);
            this.button_updateDrivers.Name = "button_updateDrivers";
            this.button_updateDrivers.Size = new System.Drawing.Size(116, 23);
            this.button_updateDrivers.TabIndex = 6;
            this.button_updateDrivers.Text = "Update drivers";
            this.button_updateDrivers.UseVisualStyleBackColor = true;
            this.button_updateDrivers.Click += new System.EventHandler(this.button_updateDrivers_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(551, 18);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(262, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Insurances";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(280, 18);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(265, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Automobiles";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grid_insurances
            // 
            this.grid_insurances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_insurances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_insurances.Location = new System.Drawing.Point(551, 44);
            this.grid_insurances.Name = "grid_insurances";
            this.grid_insurances.Size = new System.Drawing.Size(262, 250);
            this.grid_insurances.TabIndex = 3;
            // 
            // grid_cars
            // 
            this.grid_cars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cars.Location = new System.Drawing.Point(280, 44);
            this.grid_cars.Name = "grid_cars";
            this.grid_cars.Size = new System.Drawing.Size(265, 250);
            this.grid_cars.TabIndex = 2;
            // 
            // grid_drivers
            // 
            this.grid_drivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_drivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_drivers.Location = new System.Drawing.Point(8, 44);
            this.grid_drivers.Name = "grid_drivers";
            this.grid_drivers.Size = new System.Drawing.Size(266, 250);
            this.grid_drivers.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(266, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Drivers";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
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
            this.tabPage3.Size = new System.Drawing.Size(821, 356);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Utilities";
            // 
            // grid_car_manufacturers
            // 
            this.grid_car_manufacturers.AllowUserToAddRows = false;
            this.grid_car_manufacturers.AllowUserToDeleteRows = false;
            this.grid_car_manufacturers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_car_manufacturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_car_manufacturers.Location = new System.Drawing.Point(551, 43);
            this.grid_car_manufacturers.Name = "grid_car_manufacturers";
            this.grid_car_manufacturers.Size = new System.Drawing.Size(265, 251);
            this.grid_car_manufacturers.TabIndex = 16;
            // 
            // grid_car_colors
            // 
            this.grid_car_colors.AllowUserToAddRows = false;
            this.grid_car_colors.AllowUserToDeleteRows = false;
            this.grid_car_colors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_car_colors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_car_colors.Location = new System.Drawing.Point(280, 44);
            this.grid_car_colors.Name = "grid_car_colors";
            this.grid_car_colors.ReadOnly = true;
            this.grid_car_colors.Size = new System.Drawing.Size(265, 250);
            this.grid_car_colors.TabIndex = 15;
            this.grid_car_colors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_car_colors_CellContentClick);
            // 
            // grid_violation_types
            // 
            this.grid_violation_types.AllowUserToAddRows = false;
            this.grid_violation_types.AllowUserToDeleteRows = false;
            this.grid_violation_types.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_violation_types.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_violation_types.Location = new System.Drawing.Point(9, 44);
            this.grid_violation_types.Name = "grid_violation_types";
            this.grid_violation_types.ReadOnly = true;
            this.grid_violation_types.Size = new System.Drawing.Size(265, 250);
            this.grid_violation_types.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.button_add_color);
            this.panel3.Location = new System.Drawing.Point(318, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 48);
            this.panel3.TabIndex = 13;
            // 
            // button_add_color
            // 
            this.button_add_color.Location = new System.Drawing.Point(31, 13);
            this.button_add_color.Name = "button_add_color";
            this.button_add_color.Size = new System.Drawing.Size(116, 23);
            this.button_add_color.TabIndex = 7;
            this.button_add_color.Text = "Update table";
            this.button_add_color.UseVisualStyleBackColor = true;
            this.button_add_color.Click += new System.EventHandler(this.button_add_color_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.button_add_manufacturer);
            this.panel2.Location = new System.Drawing.Point(590, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 48);
            this.panel2.TabIndex = 12;
            // 
            // button_add_manufacturer
            // 
            this.button_add_manufacturer.Location = new System.Drawing.Point(33, 13);
            this.button_add_manufacturer.Name = "button_add_manufacturer";
            this.button_add_manufacturer.Size = new System.Drawing.Size(116, 23);
            this.button_add_manufacturer.TabIndex = 7;
            this.button_add_manufacturer.Text = "Update table";
            this.button_add_manufacturer.UseVisualStyleBackColor = true;
            this.button_add_manufacturer.Click += new System.EventHandler(this.button_add_manufacturer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.button_add_violation);
            this.panel1.Location = new System.Drawing.Point(40, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 50);
            this.panel1.TabIndex = 10;
            // 
            // button_add_violation
            // 
            this.button_add_violation.Location = new System.Drawing.Point(34, 13);
            this.button_add_violation.Name = "button_add_violation";
            this.button_add_violation.Size = new System.Drawing.Size(116, 23);
            this.button_add_violation.TabIndex = 7;
            this.button_add_violation.Text = "Update table";
            this.button_add_violation.UseVisualStyleBackColor = true;
            this.button_add_violation.Click += new System.EventHandler(this.button_add_violation_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(280, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(265, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Car colors";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(551, 17);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(265, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Car manufacturers";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 20);
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 406);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_violations)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_insurances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_drivers)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.Button button_add_color;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_add_manufacturer;
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
        private System.Windows.Forms.DataGridView dataGridView_violations;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView grid_insurances;
        private System.Windows.Forms.DataGridView grid_cars;
        private System.Windows.Forms.DataGridView grid_drivers;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button_updateInsurances;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button_updateCars;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_updateDrivers;
    }
}

