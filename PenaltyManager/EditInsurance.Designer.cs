namespace PenaltyManager
{
    partial class EditInsurance
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
            this.button_dateNow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.checkBox_isValid = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox_numbers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_dateNow
            // 
            this.button_dateNow.Location = new System.Drawing.Point(94, 64);
            this.button_dateNow.Name = "button_dateNow";
            this.button_dateNow.Size = new System.Drawing.Size(75, 24);
            this.button_dateNow.TabIndex = 31;
            this.button_dateNow.Text = "Now";
            this.button_dateNow.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Number";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(219, 90);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 28;
            this.button_add.Text = "Edit";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // checkBox_isValid
            // 
            this.checkBox_isValid.AutoSize = true;
            this.checkBox_isValid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_isValid.Location = new System.Drawing.Point(94, 94);
            this.checkBox_isValid.Name = "checkBox_isValid";
            this.checkBox_isValid.Size = new System.Drawing.Size(49, 17);
            this.checkBox_isValid.TabIndex = 27;
            this.checkBox_isValid.Text = "Valid";
            this.checkBox_isValid.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Time and date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Is valid?";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(94, 38);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 24;
            // 
            // comboBox_numbers
            // 
            this.comboBox_numbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_numbers.Location = new System.Drawing.Point(94, 12);
            this.comboBox_numbers.Name = "comboBox_numbers";
            this.comboBox_numbers.Size = new System.Drawing.Size(121, 21);
            this.comboBox_numbers.TabIndex = 32;
            // 
            // EditInsurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(312, 124);
            this.Controls.Add(this.comboBox_numbers);
            this.Controls.Add(this.button_dateNow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.checkBox_isValid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "EditInsurance";
            this.Text = "EditInsurance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditInsurance_FormClosed);
            this.Load += new System.EventHandler(this.EditInsurance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_dateNow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.CheckBox checkBox_isValid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBox_numbers;
    }
}