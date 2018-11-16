namespace PenaltyManager
{
    partial class CarUpdate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_insValue = new System.Windows.Forms.TextBox();
            this.comboBox_assignedIns = new System.Windows.Forms.ComboBox();
            this.insuranceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roadPenaltiesDataSet = new PenaltyManager.RoadPenaltiesDataSet();
            this.manufacturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_color = new System.Windows.Forms.ComboBox();
            this.colorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_remove = new System.Windows.Forms.Button();
            this.button_addEdit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_carNumber = new System.Windows.Forms.TextBox();
            this.manufacturersTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.ManufacturersTableAdapter();
            this.colorsTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.ColorsTableAdapter();
            this.insuranceTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.InsuranceTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_model = new System.Windows.Forms.ComboBox();
            this.modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelsTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.ModelsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insurance value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Assigned insurance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "To add a new car leave the \"ID\" field empty";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(36, 6);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(35, 20);
            this.textBox_id.TabIndex = 6;
            // 
            // textBox_insValue
            // 
            this.textBox_insValue.Location = new System.Drawing.Point(162, 6);
            this.textBox_insValue.Name = "textBox_insValue";
            this.textBox_insValue.Size = new System.Drawing.Size(104, 20);
            this.textBox_insValue.TabIndex = 7;
            // 
            // comboBox_assignedIns
            // 
            this.comboBox_assignedIns.DataSource = this.insuranceBindingSource;
            this.comboBox_assignedIns.DisplayMember = "id";
            this.comboBox_assignedIns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_assignedIns.FormattingEnabled = true;
            this.comboBox_assignedIns.Location = new System.Drawing.Point(162, 62);
            this.comboBox_assignedIns.Name = "comboBox_assignedIns";
            this.comboBox_assignedIns.Size = new System.Drawing.Size(104, 21);
            this.comboBox_assignedIns.TabIndex = 8;
            this.comboBox_assignedIns.ValueMember = "id";
            // 
            // insuranceBindingSource
            // 
            this.insuranceBindingSource.DataMember = "Insurance";
            this.insuranceBindingSource.DataSource = this.roadPenaltiesDataSet;
            // 
            // roadPenaltiesDataSet
            // 
            this.roadPenaltiesDataSet.DataSetName = "RoadPenaltiesDataSet";
            this.roadPenaltiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manufacturersBindingSource
            // 
            this.manufacturersBindingSource.DataMember = "Manufacturers";
            this.manufacturersBindingSource.DataSource = this.roadPenaltiesDataSet;
            // 
            // comboBox_color
            // 
            this.comboBox_color.DataSource = this.colorsBindingSource;
            this.comboBox_color.DisplayMember = "Color";
            this.comboBox_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_color.FormattingEnabled = true;
            this.comboBox_color.Location = new System.Drawing.Point(343, 6);
            this.comboBox_color.Name = "comboBox_color";
            this.comboBox_color.Size = new System.Drawing.Size(116, 21);
            this.comboBox_color.TabIndex = 10;
            this.comboBox_color.ValueMember = "id";
            // 
            // colorsBindingSource
            // 
            this.colorsBindingSource.DataMember = "Colors";
            this.colorsBindingSource.DataSource = this.roadPenaltiesDataSet;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(304, 65);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 11;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_addEdit
            // 
            this.button_addEdit.Location = new System.Drawing.Point(384, 65);
            this.button_addEdit.Name = "button_addEdit";
            this.button_addEdit.Size = new System.Drawing.Size(75, 23);
            this.button_addEdit.TabIndex = 12;
            this.button_addEdit.Text = "Add/Edit";
            this.button_addEdit.UseVisualStyleBackColor = true;
            this.button_addEdit.Click += new System.EventHandler(this.button_addEdit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Car number";
            // 
            // textBox_carNumber
            // 
            this.textBox_carNumber.Location = new System.Drawing.Point(162, 34);
            this.textBox_carNumber.Name = "textBox_carNumber";
            this.textBox_carNumber.Size = new System.Drawing.Size(104, 20);
            this.textBox_carNumber.TabIndex = 14;
            // 
            // manufacturersTableAdapter
            // 
            this.manufacturersTableAdapter.ClearBeforeFill = true;
            // 
            // colorsTableAdapter
            // 
            this.colorsTableAdapter.ClearBeforeFill = true;
            // 
            // insuranceTableAdapter
            // 
            this.insuranceTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Model";
            // 
            // comboBox_model
            // 
            this.comboBox_model.DataSource = this.modelsBindingSource;
            this.comboBox_model.DisplayMember = "Model";
            this.comboBox_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_model.FormattingEnabled = true;
            this.comboBox_model.Location = new System.Drawing.Point(343, 34);
            this.comboBox_model.Name = "comboBox_model";
            this.comboBox_model.Size = new System.Drawing.Size(116, 21);
            this.comboBox_model.TabIndex = 16;
            this.comboBox_model.ValueMember = "id";
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
            // CarUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 118);
            this.Controls.Add(this.comboBox_model);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_carNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_addEdit);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.comboBox_color);
            this.Controls.Add(this.comboBox_assignedIns);
            this.Controls.Add(this.textBox_insValue);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CarUpdate";
            this.Text = "CarUpdate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CarUpdate_FormClosed);
            this.Load += new System.EventHandler(this.CarUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insuranceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_insValue;
        private System.Windows.Forms.ComboBox comboBox_assignedIns;
        private System.Windows.Forms.ComboBox comboBox_color;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_addEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_carNumber;
        private RoadPenaltiesDataSet roadPenaltiesDataSet;
        private System.Windows.Forms.BindingSource manufacturersBindingSource;
        private RoadPenaltiesDataSetTableAdapters.ManufacturersTableAdapter manufacturersTableAdapter;
        private System.Windows.Forms.BindingSource colorsBindingSource;
        private RoadPenaltiesDataSetTableAdapters.ColorsTableAdapter colorsTableAdapter;
        private System.Windows.Forms.BindingSource insuranceBindingSource;
        private RoadPenaltiesDataSetTableAdapters.InsuranceTableAdapter insuranceTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_model;
        private System.Windows.Forms.BindingSource modelsBindingSource;
        private RoadPenaltiesDataSetTableAdapters.ModelsTableAdapter modelsTableAdapter;
    }
}