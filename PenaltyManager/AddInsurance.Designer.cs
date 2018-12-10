namespace PenaltyManager
{
    partial class AddInsurance
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
            this.button_add = new System.Windows.Forms.Button();
            this.checkBox_leaveDate = new System.Windows.Forms.CheckBox();
            this.checkBox_isValid = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(218, 59);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 20;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // checkBox_leaveDate
            // 
            this.checkBox_leaveDate.AutoSize = true;
            this.checkBox_leaveDate.Enabled = false;
            this.checkBox_leaveDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_leaveDate.Location = new System.Drawing.Point(93, 29);
            this.checkBox_leaveDate.Name = "checkBox_leaveDate";
            this.checkBox_leaveDate.Size = new System.Drawing.Size(92, 17);
            this.checkBox_leaveDate.TabIndex = 19;
            this.checkBox_leaveDate.Text = "Leave current";
            this.checkBox_leaveDate.UseVisualStyleBackColor = true;
            // 
            // checkBox_isValid
            // 
            this.checkBox_isValid.AutoSize = true;
            this.checkBox_isValid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_isValid.Location = new System.Drawing.Point(93, 63);
            this.checkBox_isValid.Name = "checkBox_isValid";
            this.checkBox_isValid.Size = new System.Drawing.Size(49, 17);
            this.checkBox_isValid.TabIndex = 16;
            this.checkBox_isValid.Text = "Valid";
            this.checkBox_isValid.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Time and date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Is valid?";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(93, 3);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 12;
            // 
            // AddInsurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(335, 136);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.checkBox_leaveDate);
            this.Controls.Add(this.checkBox_isValid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "AddInsurance";
            this.Text = "AddInsurance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.CheckBox checkBox_leaveDate;
        private System.Windows.Forms.CheckBox checkBox_isValid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}