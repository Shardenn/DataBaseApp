namespace PenaltyManager
{
    partial class AddDriver
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
            this.textBox_license = new System.Windows.Forms.TextBox();
            this.textBox_fullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_license
            // 
            this.textBox_license.Location = new System.Drawing.Point(102, 43);
            this.textBox_license.Name = "textBox_license";
            this.textBox_license.Size = new System.Drawing.Size(100, 20);
            this.textBox_license.TabIndex = 12;
            // 
            // textBox_fullName
            // 
            this.textBox_fullName.Location = new System.Drawing.Point(102, 12);
            this.textBox_fullName.Name = "textBox_fullName";
            this.textBox_fullName.Size = new System.Drawing.Size(100, 20);
            this.textBox_fullName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Licence number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Full name";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(102, 69);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 23);
            this.button_add.TabIndex = 13;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // AddDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(215, 103);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_license);
            this.Controls.Add(this.textBox_fullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddDriver";
            this.Text = "AddDriver";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddDriver_FormClosed);
            this.Load += new System.EventHandler(this.AddDriver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_license;
        private System.Windows.Forms.TextBox textBox_fullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_add;
    }
}