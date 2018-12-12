namespace PenaltyManager
{
    partial class FoundDriverInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_driverName = new System.Windows.Forms.TextBox();
            this.textBox_licenseNumber = new System.Windows.Forms.TextBox();
            this.gridView_carsAssigned = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button_saveChanges = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_removeDriver = new System.Windows.Forms.Button();
            this.button_addInsurance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_carsAssigned)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "License number";
            // 
            // textBox_driverName
            // 
            this.textBox_driverName.Location = new System.Drawing.Point(217, 8);
            this.textBox_driverName.Name = "textBox_driverName";
            this.textBox_driverName.Size = new System.Drawing.Size(100, 20);
            this.textBox_driverName.TabIndex = 2;
            // 
            // textBox_licenseNumber
            // 
            this.textBox_licenseNumber.Location = new System.Drawing.Point(217, 35);
            this.textBox_licenseNumber.Name = "textBox_licenseNumber";
            this.textBox_licenseNumber.Size = new System.Drawing.Size(100, 20);
            this.textBox_licenseNumber.TabIndex = 3;
            // 
            // gridView_carsAssigned
            // 
            this.gridView_carsAssigned.AllowUserToAddRows = false;
            this.gridView_carsAssigned.AllowUserToDeleteRows = false;
            this.gridView_carsAssigned.AllowUserToOrderColumns = true;
            this.gridView_carsAssigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_carsAssigned.ColumnHeadersVisible = false;
            this.gridView_carsAssigned.Location = new System.Drawing.Point(12, 157);
            this.gridView_carsAssigned.Name = "gridView_carsAssigned";
            this.gridView_carsAssigned.ReadOnly = true;
            this.gridView_carsAssigned.RowHeadersVisible = false;
            this.gridView_carsAssigned.Size = new System.Drawing.Size(305, 150);
            this.gridView_carsAssigned.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(61, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Driver\'s insurances and their cars";
            // 
            // button_saveChanges
            // 
            this.button_saveChanges.Location = new System.Drawing.Point(12, 313);
            this.button_saveChanges.Name = "button_saveChanges";
            this.button_saveChanges.Size = new System.Drawing.Size(100, 23);
            this.button_saveChanges.TabIndex = 6;
            this.button_saveChanges.Text = "Save changes";
            this.button_saveChanges.UseVisualStyleBackColor = true;
            this.button_saveChanges.Click += new System.EventHandler(this.button_saveChanges_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Double click an insurance to update\r\nRight click to delete\r\n";
            // 
            // button_removeDriver
            // 
            this.button_removeDriver.Location = new System.Drawing.Point(217, 313);
            this.button_removeDriver.Name = "button_removeDriver";
            this.button_removeDriver.Size = new System.Drawing.Size(100, 23);
            this.button_removeDriver.TabIndex = 8;
            this.button_removeDriver.Text = "Remove driver";
            this.button_removeDriver.UseVisualStyleBackColor = true;
            // 
            // button_addInsurance
            // 
            this.button_addInsurance.Location = new System.Drawing.Point(118, 313);
            this.button_addInsurance.Name = "button_addInsurance";
            this.button_addInsurance.Size = new System.Drawing.Size(93, 23);
            this.button_addInsurance.TabIndex = 9;
            this.button_addInsurance.Text = "Add insurance";
            this.button_addInsurance.UseVisualStyleBackColor = true;
            // 
            // FoundDriverInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(328, 346);
            this.Controls.Add(this.button_addInsurance);
            this.Controls.Add(this.button_removeDriver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_saveChanges);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridView_carsAssigned);
            this.Controls.Add(this.textBox_licenseNumber);
            this.Controls.Add(this.textBox_driverName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FoundDriverInfo";
            this.Text = "FoundDriverInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FoundDriverInfo_FormClosed);
            this.Load += new System.EventHandler(this.FoundDriverInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_carsAssigned)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_driverName;
        private System.Windows.Forms.TextBox textBox_licenseNumber;
        private System.Windows.Forms.DataGridView gridView_carsAssigned;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_saveChanges;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_removeDriver;
        private System.Windows.Forms.Button button_addInsurance;
    }
}