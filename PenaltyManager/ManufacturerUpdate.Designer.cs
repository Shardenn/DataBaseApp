namespace PenaltyManager
{
    partial class ManufacturerUpdate
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
            this.textBox_oldName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.textBox_newName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_oldName
            // 
            this.textBox_oldName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox_oldName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_oldName.Location = new System.Drawing.Point(132, 12);
            this.textBox_oldName.Name = "textBox_oldName";
            this.textBox_oldName.Size = new System.Drawing.Size(100, 20);
            this.textBox_oldName.TabIndex = 12;
            this.textBox_oldName.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Old manufacturer name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(310, 12);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(100, 20);
            this.textBox_input.TabIndex = 9;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "New manufacturer\r\nname";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(142, 64);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 7;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_newName
            // 
            this.textBox_newName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox_newName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_newName.Location = new System.Drawing.Point(132, 38);
            this.textBox_newName.Name = "textBox_newName";
            this.textBox_newName.Size = new System.Drawing.Size(100, 20);
            this.textBox_newName.TabIndex = 13;
            // 
            // ManufacturerUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 102);
            this.Controls.Add(this.textBox_newName);
            this.Controls.Add(this.textBox_oldName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_update);
            this.Name = "ManufacturerUpdate";
            this.Text = "Manufacturer update";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManufacturerUpdate_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_oldName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBox_newName;
    }
}