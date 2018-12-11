namespace PenaltyManager
{
    partial class ViolationTypeAddition
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_newName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_fine = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New type name";
            // 
            // textBox_newName
            // 
            this.textBox_newName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox_newName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_newName.Location = new System.Drawing.Point(108, 6);
            this.textBox_newName.Name = "textBox_newName";
            this.textBox_newName.Size = new System.Drawing.Size(100, 20);
            this.textBox_newName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fine";
            // 
            // textBox_fine
            // 
            this.textBox_fine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox_fine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_fine.Location = new System.Drawing.Point(108, 28);
            this.textBox_fine.Name = "textBox_fine";
            this.textBox_fine.Size = new System.Drawing.Size(100, 20);
            this.textBox_fine.TabIndex = 3;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(108, 54);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 23);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // ViolationTypeAddition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 85);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_fine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_newName);
            this.Controls.Add(this.label1);
            this.Name = "ViolationTypeAddition";
            this.Text = "ViolationTypeAddition";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViolationTypeAddition_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_newName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_fine;
        private System.Windows.Forms.Button button_add;
    }
}