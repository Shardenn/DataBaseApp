﻿namespace PenaltyManager
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
            this.checkBox_isValid = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.button_dateNow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(218, 84);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 20;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // checkBox_isValid
            // 
            this.checkBox_isValid.AutoSize = true;
            this.checkBox_isValid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_isValid.Location = new System.Drawing.Point(93, 88);
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
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Time and date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Is valid?";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(93, 32);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Number";
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(93, 6);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(100, 20);
            this.textBox_number.TabIndex = 22;
            // 
            // button_dateNow
            // 
            this.button_dateNow.Location = new System.Drawing.Point(93, 58);
            this.button_dateNow.Name = "button_dateNow";
            this.button_dateNow.Size = new System.Drawing.Size(75, 24);
            this.button_dateNow.TabIndex = 23;
            this.button_dateNow.Text = "Now";
            this.button_dateNow.UseVisualStyleBackColor = true;
            this.button_dateNow.Click += new System.EventHandler(this.button_dateNow_Click);
            // 
            // AddInsurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(303, 117);
            this.Controls.Add(this.button_dateNow);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.checkBox_isValid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "AddInsurance";
            this.Text = "AddInsurance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddInsurance_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.CheckBox checkBox_isValid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Button button_dateNow;
    }
}