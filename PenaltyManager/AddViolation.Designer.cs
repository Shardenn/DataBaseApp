namespace PenaltyManager
{
    partial class AddViolation
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
            this.comboBox_carID = new System.Windows.Forms.ComboBox();
            this.comboBox_violationType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_driverName = new System.Windows.Forms.Label();
            this.label_driverLicense = new System.Windows.Forms.Label();
            this.label_carManufacturer = new System.Windows.Forms.Label();
            this.label_carModel = new System.Windows.Forms.Label();
            this.label_carNumber = new System.Windows.Forms.Label();
            this.label_fine = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.roadPenaltiesDataSet = new PenaltyManager.RoadPenaltiesDataSet();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.DriverTableAdapter();
            this.automobileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobileTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.AutomobileTableAdapter();
            this.violationTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_driverID
            // 
            this.comboBox_driverID.DataSource = this.driverBindingSource;
            this.comboBox_driverID.DisplayMember = "id";
            this.comboBox_driverID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_driverID.FormattingEnabled = true;
            this.comboBox_driverID.Location = new System.Drawing.Point(104, 11);
            this.comboBox_driverID.Name = "comboBox_driverID";
            this.comboBox_driverID.Size = new System.Drawing.Size(121, 21);
            this.comboBox_driverID.TabIndex = 0;
            this.comboBox_driverID.ValueMember = "id";
            this.comboBox_driverID.SelectedIndexChanged += new System.EventHandler(this.comboBox_driverID_SelectedIndexChanged);
            // 
            // comboBox_carID
            // 
            this.comboBox_carID.DataSource = this.automobileBindingSource;
            this.comboBox_carID.DisplayMember = "id";
            this.comboBox_carID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_carID.FormattingEnabled = true;
            this.comboBox_carID.Location = new System.Drawing.Point(104, 48);
            this.comboBox_carID.Name = "comboBox_carID";
            this.comboBox_carID.Size = new System.Drawing.Size(121, 21);
            this.comboBox_carID.TabIndex = 1;
            this.comboBox_carID.ValueMember = "id";
            this.comboBox_carID.SelectedIndexChanged += new System.EventHandler(this.comboBox_carID_SelectedIndexChanged);
            // 
            // comboBox_violationType
            // 
            this.comboBox_violationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_violationType.FormattingEnabled = true;
            this.comboBox_violationType.Location = new System.Drawing.Point(104, 85);
            this.comboBox_violationType.Name = "comboBox_violationType";
            this.comboBox_violationType.Size = new System.Drawing.Size(121, 21);
            this.comboBox_violationType.TabIndex = 2;
            this.comboBox_violationType.ValueMember = "Type";
            this.comboBox_violationType.SelectedIndexChanged += new System.EventHandler(this.comboBox_violationType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Driver ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Car ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Violation type";
            // 
            // label_driverName
            // 
            this.label_driverName.AutoSize = true;
            this.label_driverName.Location = new System.Drawing.Point(263, 14);
            this.label_driverName.Name = "label_driverName";
            this.label_driverName.Size = new System.Drawing.Size(35, 13);
            this.label_driverName.TabIndex = 6;
            this.label_driverName.Text = "label4";
            // 
            // label_driverLicense
            // 
            this.label_driverLicense.AutoSize = true;
            this.label_driverLicense.Location = new System.Drawing.Point(331, 14);
            this.label_driverLicense.Name = "label_driverLicense";
            this.label_driverLicense.Size = new System.Drawing.Size(35, 13);
            this.label_driverLicense.TabIndex = 7;
            this.label_driverLicense.Text = "label5";
            // 
            // label_carManufacturer
            // 
            this.label_carManufacturer.AutoSize = true;
            this.label_carManufacturer.Location = new System.Drawing.Point(263, 56);
            this.label_carManufacturer.Name = "label_carManufacturer";
            this.label_carManufacturer.Size = new System.Drawing.Size(35, 13);
            this.label_carManufacturer.TabIndex = 8;
            this.label_carManufacturer.Text = "label4";
            // 
            // label_carModel
            // 
            this.label_carModel.AutoSize = true;
            this.label_carModel.Location = new System.Drawing.Point(331, 56);
            this.label_carModel.Name = "label_carModel";
            this.label_carModel.Size = new System.Drawing.Size(35, 13);
            this.label_carModel.TabIndex = 9;
            this.label_carModel.Text = "label5";
            // 
            // label_carNumber
            // 
            this.label_carNumber.AutoSize = true;
            this.label_carNumber.Location = new System.Drawing.Point(396, 56);
            this.label_carNumber.Name = "label_carNumber";
            this.label_carNumber.Size = new System.Drawing.Size(35, 13);
            this.label_carNumber.TabIndex = 10;
            this.label_carNumber.Text = "label6";
            // 
            // label_fine
            // 
            this.label_fine.AutoSize = true;
            this.label_fine.Location = new System.Drawing.Point(263, 88);
            this.label_fine.Name = "label_fine";
            this.label_fine.Size = new System.Drawing.Size(35, 13);
            this.label_fine.TabIndex = 11;
            this.label_fine.Text = "label4";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(127, 134);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(98, 23);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "Add violation";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // roadPenaltiesDataSet
            // 
            this.roadPenaltiesDataSet.DataSetName = "RoadPenaltiesDataSet";
            this.roadPenaltiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "Driver";
            this.driverBindingSource.DataSource = this.roadPenaltiesDataSet;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // automobileBindingSource
            // 
            this.automobileBindingSource.DataMember = "Automobile";
            this.automobileBindingSource.DataSource = this.roadPenaltiesDataSet;
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
            // AddViolation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 174);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_fine);
            this.Controls.Add(this.label_carNumber);
            this.Controls.Add(this.label_carModel);
            this.Controls.Add(this.label_carManufacturer);
            this.Controls.Add(this.label_driverLicense);
            this.Controls.Add(this.label_driverName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_violationType);
            this.Controls.Add(this.comboBox_carID);
            this.Controls.Add(this.comboBox_driverID);
            this.Name = "AddViolation";
            this.Text = "AddViolation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddViolation_FormClosed);
            this.Load += new System.EventHandler(this.AddViolation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_driverID;
        private System.Windows.Forms.ComboBox comboBox_carID;
        private System.Windows.Forms.ComboBox comboBox_violationType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_driverName;
        private System.Windows.Forms.Label label_driverLicense;
        private System.Windows.Forms.Label label_carManufacturer;
        private System.Windows.Forms.Label label_carModel;
        private System.Windows.Forms.Label label_carNumber;
        private System.Windows.Forms.Label label_fine;
        private System.Windows.Forms.Button button_add;
        private RoadPenaltiesDataSet roadPenaltiesDataSet;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private RoadPenaltiesDataSetTableAdapters.DriverTableAdapter driverTableAdapter;
        private System.Windows.Forms.BindingSource automobileBindingSource;
        private RoadPenaltiesDataSetTableAdapters.AutomobileTableAdapter automobileTableAdapter;
        private System.Windows.Forms.BindingSource violationTypeBindingSource;
    }
}