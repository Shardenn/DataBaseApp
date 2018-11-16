namespace PenaltyManager
{
    partial class ViolationTypeUpdate
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
            this.textBox_violationType = new System.Windows.Forms.TextBox();
            this.textBox_fine = new System.Windows.Forms.TextBox();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.comboBox_violationTypes = new System.Windows.Forms.ComboBox();
            this.roadPenaltiesDataSet = new PenaltyManager.RoadPenaltiesDataSet();
            this.violationTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add violation type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "To remove a violation type, leave \"Fine\" empty.\r\n";
            // 
            // textBox_violationType
            // 
            this.textBox_violationType.Location = new System.Drawing.Point(112, 9);
            this.textBox_violationType.Name = "textBox_violationType";
            this.textBox_violationType.Size = new System.Drawing.Size(100, 20);
            this.textBox_violationType.TabIndex = 3;
            // 
            // textBox_fine
            // 
            this.textBox_fine.Location = new System.Drawing.Point(112, 91);
            this.textBox_fine.Name = "textBox_fine";
            this.textBox_fine.Size = new System.Drawing.Size(100, 20);
            this.textBox_fine.TabIndex = 4;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(267, 35);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(86, 23);
            this.button_remove.TabIndex = 5;
            this.button_remove.Text = "Remove/Edit";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(267, 7);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(86, 23);
            this.button_update.TabIndex = 6;
            this.button_update.Text = "Add";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // comboBox_violationTypes
            // 
            this.comboBox_violationTypes.DisplayMember = "Type";
            this.comboBox_violationTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_violationTypes.FormattingEnabled = true;
            this.comboBox_violationTypes.Location = new System.Drawing.Point(112, 35);
            this.comboBox_violationTypes.Name = "comboBox_violationTypes";
            this.comboBox_violationTypes.Size = new System.Drawing.Size(100, 21);
            this.comboBox_violationTypes.TabIndex = 7;
            this.comboBox_violationTypes.ValueMember = "Type";
            this.comboBox_violationTypes.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox_violationTypes_DrawItem);
            this.comboBox_violationTypes.SelectedIndexChanged += new System.EventHandler(this.comboBox_violationTypes_SelectedIndexChanged);
            // 
            // roadPenaltiesDataSet
            // 
            this.roadPenaltiesDataSet.DataSetName = "RoadPenaltiesDataSet";
            this.roadPenaltiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // violationTypeBindingSource
            // 
            this.violationTypeBindingSource.DataMember = "ViolationType";
            this.violationTypeBindingSource.DataSource = this.roadPenaltiesDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Edit/remove";
            // 
            // ViolationTypeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 130);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_violationTypes);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.textBox_fine);
            this.Controls.Add(this.textBox_violationType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViolationTypeUpdate";
            this.Text = "ViolationTypeUpdate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViolationTypeUpdate_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_violationType;
        private System.Windows.Forms.TextBox textBox_fine;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.ComboBox comboBox_violationTypes;
        private System.Windows.Forms.BindingSource violationTypeBindingSource;
        private RoadPenaltiesDataSet roadPenaltiesDataSet;
        private System.Windows.Forms.Label label4;
    }
}