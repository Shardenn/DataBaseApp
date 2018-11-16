namespace PenaltyManager
{
    partial class RemoveViolation
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
            this.comboBox_violationsID = new System.Windows.Forms.ComboBox();
            this.violationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roadPenaltiesDataSet = new PenaltyManager.RoadPenaltiesDataSet();
            this.button_remove = new System.Windows.Forms.Button();
            this.violationTableAdapter = new PenaltyManager.RoadPenaltiesDataSetTableAdapters.ViolationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.violationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).BeginInit();
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
            // comboBox_violationsID
            // 
            this.comboBox_violationsID.DataSource = this.violationBindingSource;
            this.comboBox_violationsID.DisplayMember = "id";
            this.comboBox_violationsID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_violationsID.FormattingEnabled = true;
            this.comboBox_violationsID.Location = new System.Drawing.Point(36, 6);
            this.comboBox_violationsID.Name = "comboBox_violationsID";
            this.comboBox_violationsID.Size = new System.Drawing.Size(121, 21);
            this.comboBox_violationsID.TabIndex = 1;
            this.comboBox_violationsID.ValueMember = "id";
            // 
            // violationBindingSource
            // 
            this.violationBindingSource.DataMember = "Violation";
            this.violationBindingSource.DataSource = this.roadPenaltiesDataSet;
            // 
            // roadPenaltiesDataSet
            // 
            this.roadPenaltiesDataSet.DataSetName = "RoadPenaltiesDataSet";
            this.roadPenaltiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(36, 33);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(121, 23);
            this.button_remove.TabIndex = 2;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button1_Click);
            // 
            // violationTableAdapter
            // 
            this.violationTableAdapter.ClearBeforeFill = true;
            // 
            // RemoveViolation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 67);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.comboBox_violationsID);
            this.Controls.Add(this.label1);
            this.Name = "RemoveViolation";
            this.Text = "RemoveViolation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RemoveViolation_FormClosed);
            this.Load += new System.EventHandler(this.RemoveViolation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.violationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPenaltiesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_violationsID;
        private System.Windows.Forms.Button button_remove;
        private RoadPenaltiesDataSet roadPenaltiesDataSet;
        private System.Windows.Forms.BindingSource violationBindingSource;
        private RoadPenaltiesDataSetTableAdapters.ViolationTableAdapter violationTableAdapter;
    }
}