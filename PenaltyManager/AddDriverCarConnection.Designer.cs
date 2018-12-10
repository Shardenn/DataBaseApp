namespace PenaltyManager
{
    partial class AddDriverCarConnection
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
            this.button_addConntection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label_findCarOrDriver = new System.Windows.Forms.Label();
            this.textBox_carNumber = new System.Windows.Forms.TextBox();
            this.gridView_cars = new System.Windows.Forms.DataGridView();
            this.label_textBoxInfo = new System.Windows.Forms.Label();
            this.button_searchCars = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_driverName = new System.Windows.Forms.TextBox();
            this.gridView_drivers = new System.Windows.Forms.DataGridView();
            this.button_searchDrivers = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_drivers)).BeginInit();
            this.SuspendLayout();
            // 
            // button_addConntection
            // 
            this.button_addConntection.Location = new System.Drawing.Point(387, 250);
            this.button_addConntection.Name = "button_addConntection";
            this.button_addConntection.Size = new System.Drawing.Size(95, 23);
            this.button_addConntection.TabIndex = 0;
            this.button_addConntection.Text = "Add connection";
            this.button_addConntection.UseVisualStyleBackColor = true;
            this.button_addConntection.Click += new System.EventHandler(this.button_addConntection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add a new connection for a car and a driver";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label_findCarOrDriver
            // 
            this.label_findCarOrDriver.AutoSize = true;
            this.label_findCarOrDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_findCarOrDriver.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_findCarOrDriver.Location = new System.Drawing.Point(12, 41);
            this.label_findCarOrDriver.Name = "label_findCarOrDriver";
            this.label_findCarOrDriver.Size = new System.Drawing.Size(71, 17);
            this.label_findCarOrDriver.TabIndex = 5;
            this.label_findCarOrDriver.Text = "Find a car";
            // 
            // textBox_carNumber
            // 
            this.textBox_carNumber.Location = new System.Drawing.Point(338, 40);
            this.textBox_carNumber.Name = "textBox_carNumber";
            this.textBox_carNumber.Size = new System.Drawing.Size(100, 20);
            this.textBox_carNumber.TabIndex = 6;
            // 
            // gridView_cars
            // 
            this.gridView_cars.AllowUserToAddRows = false;
            this.gridView_cars.AllowUserToDeleteRows = false;
            this.gridView_cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_cars.Location = new System.Drawing.Point(12, 95);
            this.gridView_cars.Name = "gridView_cars";
            this.gridView_cars.ReadOnly = true;
            this.gridView_cars.RowHeadersVisible = false;
            this.gridView_cars.Size = new System.Drawing.Size(423, 132);
            this.gridView_cars.TabIndex = 7;
            // 
            // label_textBoxInfo
            // 
            this.label_textBoxInfo.AutoSize = true;
            this.label_textBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_textBoxInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_textBoxInfo.Location = new System.Drawing.Point(233, 41);
            this.label_textBoxInfo.Name = "label_textBoxInfo";
            this.label_textBoxInfo.Size = new System.Drawing.Size(82, 17);
            this.label_textBoxInfo.TabIndex = 8;
            this.label_textBoxInfo.Text = "Car number";
            // 
            // button_searchCars
            // 
            this.button_searchCars.Location = new System.Drawing.Point(338, 66);
            this.button_searchCars.Name = "button_searchCars";
            this.button_searchCars.Size = new System.Drawing.Size(100, 23);
            this.button_searchCars.TabIndex = 9;
            this.button_searchCars.Text = "Search cars";
            this.button_searchCars.UseVisualStyleBackColor = true;
            this.button_searchCars.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(444, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Find a driver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(676, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Driver name";
            // 
            // textBox_driverName
            // 
            this.textBox_driverName.Location = new System.Drawing.Point(767, 40);
            this.textBox_driverName.Name = "textBox_driverName";
            this.textBox_driverName.Size = new System.Drawing.Size(100, 20);
            this.textBox_driverName.TabIndex = 12;
            // 
            // gridView_drivers
            // 
            this.gridView_drivers.AllowUserToAddRows = false;
            this.gridView_drivers.AllowUserToDeleteRows = false;
            this.gridView_drivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_drivers.Location = new System.Drawing.Point(444, 95);
            this.gridView_drivers.Name = "gridView_drivers";
            this.gridView_drivers.ReadOnly = true;
            this.gridView_drivers.RowHeadersVisible = false;
            this.gridView_drivers.Size = new System.Drawing.Size(423, 132);
            this.gridView_drivers.TabIndex = 13;
            // 
            // button_searchDrivers
            // 
            this.button_searchDrivers.Location = new System.Drawing.Point(767, 66);
            this.button_searchDrivers.Name = "button_searchDrivers";
            this.button_searchDrivers.Size = new System.Drawing.Size(100, 23);
            this.button_searchDrivers.TabIndex = 14;
            this.button_searchDrivers.Text = "Search drivers";
            this.button_searchDrivers.UseVisualStyleBackColor = true;
            this.button_searchDrivers.Click += new System.EventHandler(this.button_searchDrivers_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(194, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(482, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Select a car and a driver from the tables above and press \"add connection\"";
            // 
            // AddDriverCarConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(879, 280);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_searchDrivers);
            this.Controls.Add(this.gridView_drivers);
            this.Controls.Add(this.textBox_driverName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_searchCars);
            this.Controls.Add(this.label_textBoxInfo);
            this.Controls.Add(this.gridView_cars);
            this.Controls.Add(this.textBox_carNumber);
            this.Controls.Add(this.label_findCarOrDriver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_addConntection);
            this.Name = "AddDriverCarConnection";
            this.Text = "AddDriverCarConnection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddDriverCarConnection_FormClosed);
            this.Load += new System.EventHandler(this.AddDriverCarConnection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_drivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_addConntection;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label_findCarOrDriver;
        private System.Windows.Forms.TextBox textBox_carNumber;
        private System.Windows.Forms.DataGridView gridView_cars;
        private System.Windows.Forms.Label label_textBoxInfo;
        private System.Windows.Forms.Button button_searchCars;
        private System.Windows.Forms.TextBox textBox_driverName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridView_drivers;
        private System.Windows.Forms.Button button_searchDrivers;
        private System.Windows.Forms.Label label4;
    }
}