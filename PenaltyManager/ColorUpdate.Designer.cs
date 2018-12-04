namespace PenaltyManager
{
    partial class ColorUpdate
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_oldName = new System.Windows.Forms.TextBox();
            this.textBox_newName = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old color name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New color name";
            // 
            // textBox_oldName
            // 
            this.textBox_oldName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox_oldName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_oldName.Location = new System.Drawing.Point(106, 10);
            this.textBox_oldName.Name = "textBox_oldName";
            this.textBox_oldName.Size = new System.Drawing.Size(100, 20);
            this.textBox_oldName.TabIndex = 2;
            // 
            // textBox_newName
            // 
            this.textBox_newName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox_newName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_newName.Location = new System.Drawing.Point(106, 42);
            this.textBox_newName.Name = "textBox_newName";
            this.textBox_newName.Size = new System.Drawing.Size(100, 20);
            this.textBox_newName.TabIndex = 3;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(121, 69);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 4;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // ColorUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 104);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox_newName);
            this.Controls.Add(this.textBox_oldName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ColorUpdate";
            this.Text = "ColorUpdate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ColorUpdate_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_oldName;
        private System.Windows.Forms.TextBox textBox_newName;
        private System.Windows.Forms.Button button_update;
    }
}