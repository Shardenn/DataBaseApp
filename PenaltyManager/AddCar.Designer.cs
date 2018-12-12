namespace PenaltyManager
{
    partial class AddCar
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
            this.comboBox_model = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_carNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_color = new System.Windows.Forms.ComboBox();
            this.textBox_insValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_assignedIns = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.roadPenaltiesDataSet = new PenaltyManager.RoadPenaltiesDataSet();
            this.insuranceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insuranceTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.InsuranceTableAdapter();
            this.colorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorsTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.ColorsTableAdapter();
            this.modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelsTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.ModelsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_owner = new System.Windows.Forms.ComboBox();
            this.comboBox_license = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_model
            // 
            this.comboBox_model.DisplayMember = "id";
            this.comboBox_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_model.FormattingEnabled = true;
            this.comboBox_model.Location = new System.Drawing.Point(275, 34);
            this.comboBox_model.Name = "comboBox_model";
            this.comboBox_model.Size = new System.Drawing.Size(116, 21);
            this.comboBox_model.TabIndex = 24;
            this.comboBox_model.ValueMember = "id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(233, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Model";
            // 
            // textBox_carNumber
            // 
            this.textBox_carNumber.Location = new System.Drawing.Point(112, 34);
            this.textBox_carNumber.Name = "textBox_carNumber";
            this.textBox_carNumber.Size = new System.Drawing.Size(104, 20);
            this.textBox_carNumber.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(45, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Car number";
            // 
            // comboBox_color
            // 
            this.comboBox_color.DisplayMember = "id";
            this.comboBox_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_color.FormattingEnabled = true;
            this.comboBox_color.Location = new System.Drawing.Point(275, 6);
            this.comboBox_color.Name = "comboBox_color";
            this.comboBox_color.Size = new System.Drawing.Size(116, 21);
            this.comboBox_color.TabIndex = 20;
            this.comboBox_color.ValueMember = "id";
            // 
            // textBox_insValue
            // 
            this.textBox_insValue.Location = new System.Drawing.Point(112, 6);
            this.textBox_insValue.Name = "textBox_insValue";
            this.textBox_insValue.Size = new System.Drawing.Size(104, 20);
            this.textBox_insValue.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(238, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(27, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Insurance value";
            // 
            // comboBox_assignedIns
            // 
            this.comboBox_assignedIns.DisplayMember = "id";
            this.comboBox_assignedIns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_assignedIns.FormattingEnabled = true;
            this.comboBox_assignedIns.Location = new System.Drawing.Point(112, 90);
            this.comboBox_assignedIns.Name = "comboBox_assignedIns";
            this.comboBox_assignedIns.Size = new System.Drawing.Size(104, 21);
            this.comboBox_assignedIns.TabIndex = 26;
            this.comboBox_assignedIns.ValueMember = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(7, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Assigned insurance";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(275, 88);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(116, 23);
            this.button_add.TabIndex = 27;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // roadPenaltiesDataSet
            // 
            this.roadPenaltiesDataSet.DataSetName = "RoadPenaltiesDataSet";
            this.roadPenaltiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insuranceBindingSource
            // 
            this.insuranceBindingSource.DataMember = "Insurance";
            this.insuranceBindingSource.DataSource = this.roadPenaltiesDataSet;
            // 
            // insuranceTableAdapter
            // 
            this.insuranceTableAdapter.ClearBeforeFill = true;
            // 
            // colorsBindingSource
            // 
            this.colorsBindingSource.DataMember = "Colors";
            this.colorsBindingSource.DataSource = this.roadPenaltiesDataSet;
            // 
            // colorsTableAdapter
            // 
            this.colorsTableAdapter.ClearBeforeFill = true;
            // 
            // modelsBindingSource
            // 
            this.modelsBindingSource.DataMember = "Models";
            this.modelsBindingSource.DataSource = this.roadPenaltiesDataSet;
            // 
            // modelsTableAdapter
            // 
            this.modelsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(68, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Owner";
            // 
            // comboBox_owner
            // 
            this.comboBox_owner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_owner.FormattingEnabled = true;
            this.comboBox_owner.Location = new System.Drawing.Point(112, 60);
            this.comboBox_owner.Name = "comboBox_owner";
            this.comboBox_owner.Size = new System.Drawing.Size(104, 21);
            this.comboBox_owner.TabIndex = 29;
            this.comboBox_owner.SelectedValueChanged += new System.EventHandler(this.comboBox_owner_SelectedValueChanged);
            // 
            // comboBox_license
            // 
            this.comboBox_license.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_license.FormattingEnabled = true;
            this.comboBox_license.Location = new System.Drawing.Point(275, 60);
            this.comboBox_license.Name = "comboBox_license";
            this.comboBox_license.Size = new System.Drawing.Size(116, 21);
            this.comboBox_license.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(225, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "License";
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(404, 120);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_license);
            this.Controls.Add(this.comboBox_owner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.comboBox_assignedIns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_model);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_carNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_color);
            this.Controls.Add(this.textBox_insValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "AddCar";
            this.Text = "AddCar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCar_FormClosed);
            this.Load += new System.EventHandler(this.AddCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_model;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_carNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_color;
        private System.Windows.Forms.TextBox textBox_insValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_assignedIns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_add;
        private RoadPenaltiesDataSet roadPenaltiesDataSet;
        private System.Windows.Forms.BindingSource insuranceBindingSource;
        private RoadPenaltiesDataSetTableAdapters.InsuranceTableAdapter insuranceTableAdapter;
        private System.Windows.Forms.BindingSource colorsBindingSource;
        private RoadPenaltiesDataSetTableAdapters.ColorsTableAdapter colorsTableAdapter;
        private System.Windows.Forms.BindingSource modelsBindingSource;
        private RoadPenaltiesDataSetTableAdapters.ModelsTableAdapter modelsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_owner;
        private System.Windows.Forms.ComboBox comboBox_license;
        private System.Windows.Forms.Label label4;
    }
}