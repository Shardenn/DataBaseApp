namespace PenaltyManager
{
    partial class ModelsAddition
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
            this.comboBox_manufacturers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_modelName = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_manufacturers
            // 
            this.comboBox_manufacturers.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.comboBox_manufacturers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox_manufacturers.FormattingEnabled = true;
            this.comboBox_manufacturers.Location = new System.Drawing.Point(109, 6);
            this.comboBox_manufacturers.Name = "comboBox_manufacturers";
            this.comboBox_manufacturers.Size = new System.Drawing.Size(121, 21);
            this.comboBox_manufacturers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manufacturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model name";
            // 
            // textBox_modelName
            // 
            this.textBox_modelName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox_modelName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_modelName.Location = new System.Drawing.Point(109, 35);
            this.textBox_modelName.Name = "textBox_modelName";
            this.textBox_modelName.Size = new System.Drawing.Size(121, 20);
            this.textBox_modelName.TabIndex = 3;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(109, 61);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(121, 23);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // ModelsAddition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 96);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_modelName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_manufacturers);
            this.Name = "ModelsAddition";
            this.Text = "ModelsAddition";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModelsAddition_FormClosed);
            this.Load += new System.EventHandler(this.ModelsAddition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_manufacturers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_modelName;
        private System.Windows.Forms.Button button_add;
    }
}