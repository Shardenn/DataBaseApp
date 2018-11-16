namespace PenaltyManager
{
    partial class ModelsUpdate
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.comboBox_manufacturers = new System.Windows.Forms.ComboBox();
            this.roadPenaltiesDataSet = new PenaltyManager.RoadPenaltiesDataSet();
            this.manufacturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturersTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.ManufacturersTableAdapter();
            this.textBox_modelName = new System.Windows.Forms.TextBox();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_addEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manufacturer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "To add a model leavle the \"ID\" field empty";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(99, 10);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 5;
            // 
            // comboBox_manufacturers
            // 
            this.comboBox_manufacturers.DataSource = this.manufacturersBindingSource;
            this.comboBox_manufacturers.DisplayMember = "Manufacturer";
            this.comboBox_manufacturers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_manufacturers.FormattingEnabled = true;
            this.comboBox_manufacturers.Location = new System.Drawing.Point(99, 46);
            this.comboBox_manufacturers.Name = "comboBox_manufacturers";
            this.comboBox_manufacturers.Size = new System.Drawing.Size(100, 21);
            this.comboBox_manufacturers.TabIndex = 6;
            this.comboBox_manufacturers.ValueMember = "id";
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
            // manufacturersTableAdapter
            // 
            this.manufacturersTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_modelName
            // 
            this.textBox_modelName.Location = new System.Drawing.Point(301, 10);
            this.textBox_modelName.Name = "textBox_modelName";
            this.textBox_modelName.Size = new System.Drawing.Size(100, 20);
            this.textBox_modelName.TabIndex = 7;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(233, 44);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 8;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_addEdit
            // 
            this.button_addEdit.Location = new System.Drawing.Point(326, 44);
            this.button_addEdit.Name = "button_addEdit";
            this.button_addEdit.Size = new System.Drawing.Size(75, 23);
            this.button_addEdit.TabIndex = 9;
            this.button_addEdit.Text = "Add/Edit";
            this.button_addEdit.UseVisualStyleBackColor = true;
            this.button_addEdit.Click += new System.EventHandler(this.button_addEdit_Click);
            // 
            // ModelsUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 113);
            this.Controls.Add(this.button_addEdit);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.textBox_modelName);
            this.Controls.Add(this.comboBox_manufacturers);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModelsUpdate";
            this.Text = "ModelsUpdate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModelsUpdate_FormClosed);
            this.Load += new System.EventHandler(this.ModelsUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.ComboBox comboBox_manufacturers;
        private RoadPenaltiesDataSet roadPenaltiesDataSet;
        private System.Windows.Forms.BindingSource manufacturersBindingSource;
        private RoadPenaltiesDataSetTableAdapters.ManufacturersTableAdapter manufacturersTableAdapter;
        private System.Windows.Forms.TextBox textBox_modelName;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_addEdit;
    }
}