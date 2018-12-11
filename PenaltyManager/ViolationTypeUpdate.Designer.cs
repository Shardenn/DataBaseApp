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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_fine = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.comboBox_violationTypes = new System.Windows.Forms.ComboBox();
            this.roadPenaltiesDataSet = new PenaltyManager.RoadPenaltiesDataSet();
            this.violationTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New fine";
            // 
            // textBox_fine
            // 
            this.textBox_fine.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_fine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_fine.Location = new System.Drawing.Point(97, 38);
            this.textBox_fine.Name = "textBox_fine";
            this.textBox_fine.Size = new System.Drawing.Size(100, 20);
            this.textBox_fine.TabIndex = 4;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(97, 75);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(100, 23);
            this.button_update.TabIndex = 6;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // comboBox_violationTypes
            // 
            this.comboBox_violationTypes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox_violationTypes.DisplayMember = "Type";
            this.comboBox_violationTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_violationTypes.FormattingEnabled = true;
            this.comboBox_violationTypes.Location = new System.Drawing.Point(97, 6);
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
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type to update";
            // 
            // ViolationTypeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(211, 112);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_violationTypes);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox_fine);
            this.Controls.Add(this.label2);
            this.Name = "ViolationTypeUpdate";
            this.Text = "ViolationTypeUpdate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViolationTypeUpdate_FormClosed);
            this.Load += new System.EventHandler(this.ViolationTypeUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_fine;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.ComboBox comboBox_violationTypes;
        private System.Windows.Forms.BindingSource violationTypeBindingSource;
        private RoadPenaltiesDataSet roadPenaltiesDataSet;
        private System.Windows.Forms.Label label4;
    }
}