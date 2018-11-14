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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grid_car_manufacturers = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roadPenaltiesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roadPenaltiesDataSet = new PenaltyManager.RoadPenaltiesDataSet();
            this.grid_car_colors = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grid_violation_types = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violationTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_add_color = new System.Windows.Forms.Button();
            this.button_remove_color = new System.Windows.Forms.Button();
            this.button_edit_color = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_add_manufacturer = new System.Windows.Forms.Button();
            this.button_remove_manufacturer = new System.Windows.Forms.Button();
            this.button_edit_manufacturer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_add_violation = new System.Windows.Forms.Button();
            this.button_remove_violation = new System.Windows.Forms.Button();
            this.button_edit_violation = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_car_manufacturers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_car_colors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_violation_types)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationTypeBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(876, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.tabControl1.Size = new System.Drawing.Size(876, 475);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(868, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(868, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.grid_car_manufacturers);
            this.tabPage3.Controls.Add(this.grid_car_colors);
            this.tabPage3.Controls.Add(this.grid_violation_types);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(868, 449);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Utilities";
            // 
            // grid_car_manufacturers
            // 
            this.grid_car_manufacturers.AllowUserToAddRows = false;
            this.grid_car_manufacturers.AllowUserToDeleteRows = false;
            this.grid_car_manufacturers.AutoGenerateColumns = false;
            this.grid_car_manufacturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_car_manufacturers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.manufacturerDataGridViewTextBoxColumn});
            this.grid_car_manufacturers.DataSource = this.manufacturersBindingSource1;
            this.grid_car_manufacturers.Location = new System.Drawing.Point(544, 44);
            this.grid_car_manufacturers.Name = "grid_car_manufacturers";
            this.grid_car_manufacturers.Size = new System.Drawing.Size(240, 150);
            this.grid_car_manufacturers.TabIndex = 16;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
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
            // grid_car_colors
            // 
            this.grid_car_colors.AllowUserToAddRows = false;
            this.grid_car_colors.AllowUserToDeleteRows = false;
            this.grid_car_colors.AutoGenerateColumns = false;
            this.grid_car_colors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_car_colors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn});
            this.grid_car_colors.DataSource = this.colorsBindingSource1;
            this.grid_car_colors.Location = new System.Drawing.Point(280, 44);
            this.grid_car_colors.Name = "grid_car_colors";
            this.grid_car_colors.ReadOnly = true;
            this.grid_car_colors.Size = new System.Drawing.Size(240, 150);
            this.grid_car_colors.TabIndex = 15;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorsBindingSource1
            // 
            this.colorsBindingSource1.DataMember = "Colors";
            this.colorsBindingSource1.DataSource = this.roadPenaltiesDataSetBindingSource;
            // 
            // grid_violation_types
            // 
            this.grid_violation_types.AllowUserToAddRows = false;
            this.grid_violation_types.AllowUserToDeleteRows = false;
            this.grid_violation_types.AutoGenerateColumns = false;
            this.grid_violation_types.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_violation_types.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.fineDataGridViewTextBoxColumn});
            this.grid_violation_types.DataSource = this.violationTypeBindingSource;
            this.grid_violation_types.Location = new System.Drawing.Point(9, 44);
            this.grid_violation_types.Name = "grid_violation_types";
            this.grid_violation_types.ReadOnly = true;
            this.grid_violation_types.Size = new System.Drawing.Size(240, 150);
            this.grid_violation_types.TabIndex = 14;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fineDataGridViewTextBoxColumn
            // 
            this.fineDataGridViewTextBoxColumn.DataPropertyName = "Fine";
            this.fineDataGridViewTextBoxColumn.HeaderText = "Fine";
            this.fineDataGridViewTextBoxColumn.Name = "fineDataGridViewTextBoxColumn";
            this.fineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // violationTypeBindingSource
            // 
            this.violationTypeBindingSource.DataMember = "ViolationType";
            this.violationTypeBindingSource.DataSource = this.roadPenaltiesDataSetBindingSource;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.button_add_color);
            this.panel3.Controls.Add(this.button_remove_color);
            this.panel3.Controls.Add(this.button_edit_color);
            this.panel3.Location = new System.Drawing.Point(316, 280);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 88);
            this.panel3.TabIndex = 13;
            // 
            // button_add_color
            // 
            this.button_add_color.Location = new System.Drawing.Point(34, 3);
            this.button_add_color.Name = "button_add_color";
            this.button_add_color.Size = new System.Drawing.Size(116, 23);
            this.button_add_color.TabIndex = 7;
            this.button_add_color.Text = "Add";
            this.button_add_color.UseVisualStyleBackColor = true;
            this.button_add_color.Click += new System.EventHandler(this.button_add_color_Click);
            // 
            // button_remove_color
            // 
            this.button_remove_color.Location = new System.Drawing.Point(34, 61);
            this.button_remove_color.Name = "button_remove_color";
            this.button_remove_color.Size = new System.Drawing.Size(116, 23);
            this.button_remove_color.TabIndex = 9;
            this.button_remove_color.Text = "Remove";
            this.button_remove_color.UseVisualStyleBackColor = true;
            // 
            // button_edit_color
            // 
            this.button_edit_color.Location = new System.Drawing.Point(34, 32);
            this.button_edit_color.Name = "button_edit_color";
            this.button_edit_color.Size = new System.Drawing.Size(116, 23);
            this.button_edit_color.TabIndex = 8;
            this.button_edit_color.Text = "Edit";
            this.button_edit_color.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.button_add_manufacturer);
            this.panel2.Controls.Add(this.button_remove_manufacturer);
            this.panel2.Controls.Add(this.button_edit_manufacturer);
            this.panel2.Location = new System.Drawing.Point(580, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 88);
            this.panel2.TabIndex = 12;
            // 
            // button_add_manufacturer
            // 
            this.button_add_manufacturer.Location = new System.Drawing.Point(34, 3);
            this.button_add_manufacturer.Name = "button_add_manufacturer";
            this.button_add_manufacturer.Size = new System.Drawing.Size(116, 23);
            this.button_add_manufacturer.TabIndex = 7;
            this.button_add_manufacturer.Text = "Add";
            this.button_add_manufacturer.UseVisualStyleBackColor = true;
            this.button_add_manufacturer.Click += new System.EventHandler(this.button_add_manufacturer_Click);
            // 
            // button_remove_manufacturer
            // 
            this.button_remove_manufacturer.Location = new System.Drawing.Point(34, 61);
            this.button_remove_manufacturer.Name = "button_remove_manufacturer";
            this.button_remove_manufacturer.Size = new System.Drawing.Size(116, 23);
            this.button_remove_manufacturer.TabIndex = 9;
            this.button_remove_manufacturer.Text = "Remove";
            this.button_remove_manufacturer.UseVisualStyleBackColor = true;
            // 
            // button_edit_manufacturer
            // 
            this.button_edit_manufacturer.Location = new System.Drawing.Point(34, 32);
            this.button_edit_manufacturer.Name = "button_edit_manufacturer";
            this.button_edit_manufacturer.Size = new System.Drawing.Size(116, 23);
            this.button_edit_manufacturer.TabIndex = 8;
            this.button_edit_manufacturer.Text = "Edit";
            this.button_edit_manufacturer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(416, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.button_add_violation);
            this.panel1.Controls.Add(this.button_remove_violation);
            this.panel1.Controls.Add(this.button_edit_violation);
            this.panel1.Location = new System.Drawing.Point(44, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 88);
            this.panel1.TabIndex = 10;
            // 
            // button_add_violation
            // 
            this.button_add_violation.Location = new System.Drawing.Point(34, 3);
            this.button_add_violation.Name = "button_add_violation";
            this.button_add_violation.Size = new System.Drawing.Size(116, 23);
            this.button_add_violation.TabIndex = 7;
            this.button_add_violation.Text = "Add";
            this.button_add_violation.UseVisualStyleBackColor = true;
            this.button_add_violation.Click += new System.EventHandler(this.button_add_violation_Click);
            // 
            // button_remove_violation
            // 
            this.button_remove_violation.Location = new System.Drawing.Point(34, 61);
            this.button_remove_violation.Name = "button_remove_violation";
            this.button_remove_violation.Size = new System.Drawing.Size(116, 23);
            this.button_remove_violation.TabIndex = 9;
            this.button_remove_violation.Text = "Remove";
            this.button_remove_violation.UseVisualStyleBackColor = true;
            this.button_remove_violation.Click += new System.EventHandler(this.button_remove_violation_Click);
            // 
            // button_edit_violation
            // 
            this.button_edit_violation.Location = new System.Drawing.Point(34, 32);
            this.button_edit_violation.Name = "button_edit_violation";
            this.button_edit_violation.Size = new System.Drawing.Size(116, 23);
            this.button_edit_violation.TabIndex = 8;
            this.button_edit_violation.Text = "Edit";
            this.button_edit_violation.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(280, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(240, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Car colors";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(544, 17);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Car manufacturers";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Violation types";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.voilationTypeBindingSource1.DataMember = "VoilationType";
            this.voilationTypeBindingSource1.DataSource = this.roadPenaltiesDataSetBindingSource;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 499);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "PenaltyManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_car_manufacturers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_car_colors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_violation_types)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationTypeBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voilationTypeBindingSource)).EndInit();
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
        private System.Windows.Forms.Button button_remove_color;
        private System.Windows.Forms.Button button_edit_color;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_add_manufacturer;
        private System.Windows.Forms.Button button_remove_manufacturer;
        private System.Windows.Forms.Button button_edit_manufacturer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_add_violation;
        private System.Windows.Forms.Button button_remove_violation;
        private System.Windows.Forms.Button button_edit_violation;
        private System.Windows.Forms.BindingSource voilationTypeBindingSource1;
        private System.Windows.Forms.DataGridView grid_car_manufacturers;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource manufacturersBindingSource1;
        private System.Windows.Forms.DataGridView grid_car_colors;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource colorsBindingSource1;
        private System.Windows.Forms.DataGridView grid_violation_types;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fineDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource violationTypeBindingSource;
    }
}

