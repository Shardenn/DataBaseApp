namespace PenaltyManager
{
    partial class EditViolationNew
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
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roadPenaltiesDataSet = new PenaltyManager.RoadPenaltiesDataSet();
            this.automobileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.violationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.DriverTableAdapter();
            this.automobileTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.AutomobileTableAdapter();
            this.violationTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.violationTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.ViolationTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_licenses = new System.Windows.Forms.ComboBox();
            this.button_update = new System.Windows.Forms.Button();
            this.label_fine = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_violationTypes = new System.Windows.Forms.ComboBox();
            this.comboBox_cars = new System.Windows.Forms.ComboBox();
            this.comboBox_drivers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "Driver";
            this.driverBindingSource.DataSource = this.roadPenaltiesDataSet;
            // 
            // roadPenaltiesDataSet
            // 
            this.roadPenaltiesDataSet.DataSetName = "RoadPenaltiesDataSet";
            this.roadPenaltiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // automobileBindingSource
            // 
            this.automobileBindingSource.DataMember = "Automobile";
            this.automobileBindingSource.DataSource = this.roadPenaltiesDataSet;
            // 
            // violationBindingSource
            // 
            this.violationBindingSource.DataMember = "Violation";
            this.violationBindingSource.DataSource = this.roadPenaltiesDataSet;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // automobileTableAdapter
            // 
            this.automobileTableAdapter.ClearBeforeFill = true;
            // 
            // violationTypeBindingSource
            // 
            this.violationTypeBindingSource.DataMember = "ViolationType";
            this.violationTypeBindingSource.DataSource = this.roadPenaltiesDataSet;
            // 
            // violationTableAdapter
            // 
            this.violationTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "License";
            // 
            // comboBox_licenses
            // 
            this.comboBox_licenses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_licenses.FormattingEnabled = true;
            this.comboBox_licenses.Location = new System.Drawing.Point(286, 12);
            this.comboBox_licenses.Name = "comboBox_licenses";
            this.comboBox_licenses.Size = new System.Drawing.Size(121, 21);
            this.comboBox_licenses.TabIndex = 23;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(286, 80);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(121, 23);
            this.button_update.TabIndex = 22;
            this.button_update.Text = "Update violation";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label_fine
            // 
            this.label_fine.AutoSize = true;
            this.label_fine.Location = new System.Drawing.Point(236, 49);
            this.label_fine.Name = "label_fine";
            this.label_fine.Size = new System.Drawing.Size(35, 13);
            this.label_fine.TabIndex = 21;
            this.label_fine.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Violation type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Car";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Driver";
            // 
            // comboBox_violationTypes
            // 
            this.comboBox_violationTypes.DisplayMember = "Type";
            this.comboBox_violationTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_violationTypes.FormattingEnabled = true;
            this.comboBox_violationTypes.Location = new System.Drawing.Point(97, 46);
            this.comboBox_violationTypes.Name = "comboBox_violationTypes";
            this.comboBox_violationTypes.Size = new System.Drawing.Size(121, 21);
            this.comboBox_violationTypes.TabIndex = 17;
            this.comboBox_violationTypes.ValueMember = "Type";
            // 
            // comboBox_cars
            // 
            this.comboBox_cars.DisplayMember = "id";
            this.comboBox_cars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cars.FormattingEnabled = true;
            this.comboBox_cars.Location = new System.Drawing.Point(97, 82);
            this.comboBox_cars.Name = "comboBox_cars";
            this.comboBox_cars.Size = new System.Drawing.Size(121, 21);
            this.comboBox_cars.TabIndex = 16;
            this.comboBox_cars.ValueMember = "id";
            // 
            // comboBox_drivers
            // 
            this.comboBox_drivers.DisplayMember = "id";
            this.comboBox_drivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_drivers.FormattingEnabled = true;
            this.comboBox_drivers.Location = new System.Drawing.Point(97, 12);
            this.comboBox_drivers.Name = "comboBox_drivers";
            this.comboBox_drivers.Size = new System.Drawing.Size(121, 21);
            this.comboBox_drivers.TabIndex = 15;
            this.comboBox_drivers.ValueMember = "id";
            // 
            // EditViolationNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 114);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_licenses);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label_fine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_violationTypes);
            this.Controls.Add(this.comboBox_cars);
            this.Controls.Add(this.comboBox_drivers);
            this.Name = "EditViolationNew";
            this.Text = "EditViolationNew";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditViolationNew_FormClosed);
            this.Load += new System.EventHandler(this.EditViolationNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoadPenaltiesDataSet roadPenaltiesDataSet;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private RoadPenaltiesDataSetTableAdapters.DriverTableAdapter driverTableAdapter;
        private System.Windows.Forms.BindingSource automobileBindingSource;
        private RoadPenaltiesDataSetTableAdapters.AutomobileTableAdapter automobileTableAdapter;
        private System.Windows.Forms.BindingSource violationTypeBindingSource;
        private System.Windows.Forms.BindingSource violationBindingSource;
        private RoadPenaltiesDataSetTableAdapters.ViolationTableAdapter violationTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_licenses;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label_fine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_violationTypes;
        private System.Windows.Forms.ComboBox comboBox_cars;
        private System.Windows.Forms.ComboBox comboBox_drivers;
    }
}