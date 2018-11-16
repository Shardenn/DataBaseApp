namespace PenaltyManager
{
    partial class DriversUpdate
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_fullName = new System.Windows.Forms.TextBox();
            this.textBox_license = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_addEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Licence number";
            // 
            // textBox_fullName
            // 
            this.textBox_fullName.Location = new System.Drawing.Point(102, 39);
            this.textBox_fullName.Name = "textBox_fullName";
            this.textBox_fullName.Size = new System.Drawing.Size(100, 20);
            this.textBox_fullName.TabIndex = 6;
            // 
            // textBox_license
            // 
            this.textBox_license.Location = new System.Drawing.Point(102, 70);
            this.textBox_license.Name = "textBox_license";
            this.textBox_license.Size = new System.Drawing.Size(100, 20);
            this.textBox_license.TabIndex = 8;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(102, 10);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 10;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(225, 8);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 11;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_addEdit
            // 
            this.button_addEdit.Location = new System.Drawing.Point(225, 68);
            this.button_addEdit.Name = "button_addEdit";
            this.button_addEdit.Size = new System.Drawing.Size(75, 23);
            this.button_addEdit.TabIndex = 12;
            this.button_addEdit.Text = "Add/Edit";
            this.button_addEdit.UseVisualStyleBackColor = true;
            this.button_addEdit.Click += new System.EventHandler(this.button_addEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "To add a driver leave ID filed empty.\r\n";
            // 
            // DriversUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 133);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_addEdit);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.textBox_license);
            this.Controls.Add(this.textBox_fullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DriversUpdate";
            this.Text = "DriversUpdate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DriversUpdate_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_fullName;
        private System.Windows.Forms.TextBox textBox_license;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_addEdit;
        private System.Windows.Forms.Label label4;
    }
}