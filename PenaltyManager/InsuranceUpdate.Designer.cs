namespace PenaltyManager
{
    partial class InsuranceUpdate
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_isValid = new System.Windows.Forms.CheckBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_remove = new System.Windows.Forms.Button();
            this.checkBox_leaveDate = new System.Windows.Forms.CheckBox();
            this.button_addEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(93, 51);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Is valid?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time and date";
            // 
            // checkBox_isValid
            // 
            this.checkBox_isValid.AutoSize = true;
            this.checkBox_isValid.Location = new System.Drawing.Point(93, 111);
            this.checkBox_isValid.Name = "checkBox_isValid";
            this.checkBox_isValid.Size = new System.Drawing.Size(49, 17);
            this.checkBox_isValid.TabIndex = 6;
            this.checkBox_isValid.Text = "Valid";
            this.checkBox_isValid.UseVisualStyleBackColor = true;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(93, 14);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 7;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(218, 12);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 8;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // checkBox_leaveDate
            // 
            this.checkBox_leaveDate.AutoSize = true;
            this.checkBox_leaveDate.Enabled = false;
            this.checkBox_leaveDate.Location = new System.Drawing.Point(93, 77);
            this.checkBox_leaveDate.Name = "checkBox_leaveDate";
            this.checkBox_leaveDate.Size = new System.Drawing.Size(92, 17);
            this.checkBox_leaveDate.TabIndex = 9;
            this.checkBox_leaveDate.Text = "Leave current";
            this.checkBox_leaveDate.UseVisualStyleBackColor = true;
            this.checkBox_leaveDate.CheckedChanged += new System.EventHandler(this.checkBox_leaveDate_CheckedChanged);
            // 
            // button_addEdit
            // 
            this.button_addEdit.Location = new System.Drawing.Point(218, 107);
            this.button_addEdit.Name = "button_addEdit";
            this.button_addEdit.Size = new System.Drawing.Size(75, 23);
            this.button_addEdit.TabIndex = 10;
            this.button_addEdit.Text = "Add/Edit";
            this.button_addEdit.UseVisualStyleBackColor = true;
            this.button_addEdit.Click += new System.EventHandler(this.button_addEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "To add an insurance leave \"ID\" field empty";
            // 
            // InsuranceUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 176);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_addEdit);
            this.Controls.Add(this.checkBox_leaveDate);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.checkBox_isValid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "InsuranceUpdate";
            this.Text = "InsuranceUpdate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InsuranceUpdate_FormClosed);
            this.Load += new System.EventHandler(this.InsuranceUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_isValid;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.CheckBox checkBox_leaveDate;
        private System.Windows.Forms.Button button_addEdit;
        private System.Windows.Forms.Label label4;
    }
}