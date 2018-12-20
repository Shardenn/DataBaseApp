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
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roadPenaltiesDataSet = new PenaltyManager.RoadPenaltiesDataSet();
            this.comboBox_carID = new System.Windows.Forms.ComboBox();
            this.automobileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_violationType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_fine = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.driverTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.DriverTableAdapter();
            this.automobileTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.AutomobileTableAdapter();
            this.violationTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_license = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_driverID
            // 
            this.comboBox_driverID.DisplayMember = "id";
            this.comboBox_driverID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_driverID.FormattingEnabled = true;
            this.comboBox_driverID.Location = new System.Drawing.Point(104, 11);
            this.comboBox_driverID.Name = "comboBox_driverID";
            this.comboBox_driverID.Size = new System.Drawing.Size(183, 21);
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
            this.comboBox_carID.DisplayMember = "id";
            this.comboBox_carID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_carID.FormattingEnabled = true;
            this.comboBox_carID.Location = new System.Drawing.Point(104, 81);
            this.comboBox_carID.Name = "comboBox_carID";
            this.comboBox_carID.Size = new System.Drawing.Size(183, 21);
            this.comboBox_carID.TabIndex = 1;
            this.comboBox_carID.ValueMember = "id";
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
            this.comboBox_violationType.Location = new System.Drawing.Point(104, 45);
            this.comboBox_violationType.Name = "comboBox_violationType";
            this.comboBox_violationType.Size = new System.Drawing.Size(183, 21);
            this.comboBox_violationType.TabIndex = 2;
            this.comboBox_violationType.ValueMember = "Type";
            this.comboBox_violationType.SelectedIndexChanged += new System.EventHandler(this.comboBox_violationType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Driver";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Car";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Violation type";
            // 
            // label_fine
            // 
            this.label_fine.AutoSize = true;
            this.label_fine.Location = new System.Drawing.Point(297, 48);
            this.label_fine.Name = "label_fine";
            this.label_fine.Size = new System.Drawing.Size(35, 13);
            this.label_fine.TabIndex = 11;
            this.label_fine.Text = "label4";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(347, 79);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(121, 23);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "Add violation";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
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
            // comboBox_license
            // 
            this.comboBox_license.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_license.FormattingEnabled = true;
            this.comboBox_license.Location = new System.Drawing.Point(347, 11);
            this.comboBox_license.Name = "comboBox_license";
            this.comboBox_license.Size = new System.Drawing.Size(121, 21);
            this.comboBox_license.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "License";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // AddViolation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 142);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_license);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_fine);
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
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).EndInit();
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
        private System.Windows.Forms.Label label_fine;
        private System.Windows.Forms.Button button_add;
        private RoadPenaltiesDataSet roadPenaltiesDataSet;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private RoadPenaltiesDataSetTableAdapters.DriverTableAdapter driverTableAdapter;
        private System.Windows.Forms.BindingSource automobileBindingSource;
        private RoadPenaltiesDataSetTableAdapters.AutomobileTableAdapter automobileTableAdapter;
        private System.Windows.Forms.BindingSource violationTypeBindingSource;
        private System.Windows.Forms.ComboBox comboBox_license;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}