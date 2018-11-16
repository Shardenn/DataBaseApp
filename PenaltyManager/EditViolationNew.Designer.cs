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
            this.comboBox_driverID = new System.Windows.Forms.ComboBox();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roadPenaltiesDataSet = new PenaltyManager.RoadPenaltiesDataSet();
            this.comboBox_carID = new System.Windows.Forms.ComboBox();
            this.automobileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_violationType = new System.Windows.Forms.ComboBox();
            this.comboBox_violationID = new System.Windows.Forms.ComboBox();
            this.violationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_driverName = new System.Windows.Forms.Label();
            this.label_driverLicense = new System.Windows.Forms.Label();
            this.label_carManufacturer = new System.Windows.Forms.Label();
            this.label_carModel = new System.Windows.Forms.Label();
            this.label_carNumber = new System.Windows.Forms.Label();
            this.driverTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.DriverTableAdapter();
            this.automobileTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.AutomobileTableAdapter();
            this.violationTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.violationTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.ViolationTableAdapter();
            this.button_editViolation = new System.Windows.Forms.Button();
            this.label_fine = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_driverID
            // 
            this.comboBox_driverID.DataSource = this.driverBindingSource;
            this.comboBox_driverID.DisplayMember = "id";
            this.comboBox_driverID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_driverID.FormattingEnabled = true;
            this.comboBox_driverID.Location = new System.Drawing.Point(110, 6);
            this.comboBox_driverID.Name = "comboBox_driverID";
            this.comboBox_driverID.Size = new System.Drawing.Size(121, 21);
            this.comboBox_driverID.TabIndex = 0;
            this.comboBox_driverID.ValueMember = "id";
            this.comboBox_driverID.SelectedIndexChanged += new System.EventHandler(this.comboBox_driverID_SelectedIndexChanged);
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
            // comboBox_carID
            // 
            this.comboBox_carID.DataSource = this.automobileBindingSource;
            this.comboBox_carID.DisplayMember = "id";
            this.comboBox_carID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_carID.FormattingEnabled = true;
            this.comboBox_carID.Location = new System.Drawing.Point(110, 43);
            this.comboBox_carID.Name = "comboBox_carID";
            this.comboBox_carID.Size = new System.Drawing.Size(121, 21);
            this.comboBox_carID.TabIndex = 1;
            this.comboBox_carID.ValueMember = "id";
            this.comboBox_carID.SelectedIndexChanged += new System.EventHandler(this.comboBox_carID_SelectedIndexChanged);
            // 
            // automobileBindingSource
            // 
            this.automobileBindingSource.DataMember = "Automobile";
            this.automobileBindingSource.DataSource = this.roadPenaltiesDataSet;
            // 
            // comboBox_violationType
            // 
            this.comboBox_violationType.DisplayMember = "Type";
            this.comboBox_violationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_violationType.FormattingEnabled = true;
            this.comboBox_violationType.Location = new System.Drawing.Point(110, 81);
            this.comboBox_violationType.Name = "comboBox_violationType";
            this.comboBox_violationType.Size = new System.Drawing.Size(121, 21);
            this.comboBox_violationType.TabIndex = 2;
            this.comboBox_violationType.ValueMember = "Type";
            this.comboBox_violationType.SelectedIndexChanged += new System.EventHandler(this.comboBox_violationType_SelectedIndexChanged);
            // 
            // comboBox_violationID
            // 
            this.comboBox_violationID.DataSource = this.violationBindingSource;
            this.comboBox_violationID.DisplayMember = "id";
            this.comboBox_violationID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_violationID.FormattingEnabled = true;
            this.comboBox_violationID.Location = new System.Drawing.Point(110, 126);
            this.comboBox_violationID.Name = "comboBox_violationID";
            this.comboBox_violationID.Size = new System.Drawing.Size(121, 21);
            this.comboBox_violationID.TabIndex = 3;
            this.comboBox_violationID.ValueMember = "id";
            // 
            // violationBindingSource
            // 
            this.violationBindingSource.DataMember = "Violation";
            this.violationBindingSource.DataSource = this.roadPenaltiesDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Driver ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Car ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Violation type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Violation ID";
            // 
            // label_driverName
            // 
            this.label_driverName.AutoSize = true;
            this.label_driverName.Location = new System.Drawing.Point(237, 9);
            this.label_driverName.Name = "label_driverName";
            this.label_driverName.Size = new System.Drawing.Size(35, 13);
            this.label_driverName.TabIndex = 8;
            this.label_driverName.Text = "label5";
            // 
            // label_driverLicense
            // 
            this.label_driverLicense.AutoSize = true;
            this.label_driverLicense.Location = new System.Drawing.Point(298, 9);
            this.label_driverLicense.Name = "label_driverLicense";
            this.label_driverLicense.Size = new System.Drawing.Size(35, 13);
            this.label_driverLicense.TabIndex = 9;
            this.label_driverLicense.Text = "label6";
            // 
            // label_carManufacturer
            // 
            this.label_carManufacturer.AutoSize = true;
            this.label_carManufacturer.Location = new System.Drawing.Point(237, 46);
            this.label_carManufacturer.Name = "label_carManufacturer";
            this.label_carManufacturer.Size = new System.Drawing.Size(35, 13);
            this.label_carManufacturer.TabIndex = 10;
            this.label_carManufacturer.Text = "label5";
            // 
            // label_carModel
            // 
            this.label_carModel.AutoSize = true;
            this.label_carModel.Location = new System.Drawing.Point(298, 46);
            this.label_carModel.Name = "label_carModel";
            this.label_carModel.Size = new System.Drawing.Size(35, 13);
            this.label_carModel.TabIndex = 11;
            this.label_carModel.Text = "label5";
            // 
            // label_carNumber
            // 
            this.label_carNumber.AutoSize = true;
            this.label_carNumber.Location = new System.Drawing.Point(348, 46);
            this.label_carNumber.Name = "label_carNumber";
            this.label_carNumber.Size = new System.Drawing.Size(35, 13);
            this.label_carNumber.TabIndex = 12;
            this.label_carNumber.Text = "label5";
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
            // button_editViolation
            // 
            this.button_editViolation.Location = new System.Drawing.Point(240, 124);
            this.button_editViolation.Name = "button_editViolation";
            this.button_editViolation.Size = new System.Drawing.Size(96, 23);
            this.button_editViolation.TabIndex = 13;
            this.button_editViolation.Text = "Edit violation";
            this.button_editViolation.UseVisualStyleBackColor = true;
            this.button_editViolation.Click += new System.EventHandler(this.button_editViolation_Click);
            // 
            // label_fine
            // 
            this.label_fine.AutoSize = true;
            this.label_fine.Location = new System.Drawing.Point(237, 84);
            this.label_fine.Name = "label_fine";
            this.label_fine.Size = new System.Drawing.Size(35, 13);
            this.label_fine.TabIndex = 14;
            this.label_fine.Text = "label5";
            // 
            // EditViolationNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 163);
            this.Controls.Add(this.label_fine);
            this.Controls.Add(this.button_editViolation);
            this.Controls.Add(this.label_carNumber);
            this.Controls.Add(this.label_carModel);
            this.Controls.Add(this.label_carManufacturer);
            this.Controls.Add(this.label_driverLicense);
            this.Controls.Add(this.label_driverName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_violationID);
            this.Controls.Add(this.comboBox_violationType);
            this.Controls.Add(this.comboBox_carID);
            this.Controls.Add(this.comboBox_driverID);
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

        private System.Windows.Forms.ComboBox comboBox_driverID;
        private System.Windows.Forms.ComboBox comboBox_carID;
        private System.Windows.Forms.ComboBox comboBox_violationType;
        private System.Windows.Forms.ComboBox comboBox_violationID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_driverName;
        private System.Windows.Forms.Label label_driverLicense;
        private System.Windows.Forms.Label label_carManufacturer;
        private System.Windows.Forms.Label label_carModel;
        private System.Windows.Forms.Label label_carNumber;
        private RoadPenaltiesDataSet roadPenaltiesDataSet;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private RoadPenaltiesDataSetTableAdapters.DriverTableAdapter driverTableAdapter;
        private System.Windows.Forms.BindingSource automobileBindingSource;
        private RoadPenaltiesDataSetTableAdapters.AutomobileTableAdapter automobileTableAdapter;
        private System.Windows.Forms.BindingSource violationTypeBindingSource;
        private System.Windows.Forms.BindingSource violationBindingSource;
        private RoadPenaltiesDataSetTableAdapters.ViolationTableAdapter violationTableAdapter;
        private System.Windows.Forms.Button button_editViolation;
        private System.Windows.Forms.Label label_fine;
    }
}