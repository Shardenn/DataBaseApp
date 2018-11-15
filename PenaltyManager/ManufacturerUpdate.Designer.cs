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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_editRemove = new System.Windows.Forms.Button();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "To add a new manufacturer, leave ID empty. \r\nTo remove a manufacturer, leave new " +
    "name empty";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(33, 12);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 12;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_editRemove
            // 
            this.button_editRemove.Location = new System.Drawing.Point(33, 38);
            this.button_editRemove.Name = "button_editRemove";
            this.button_editRemove.Size = new System.Drawing.Size(83, 23);
            this.button_editRemove.TabIndex = 10;
            this.button_editRemove.Text = "Edit/Remove";
            this.button_editRemove.UseVisualStyleBackColor = true;
            this.button_editRemove.Click += new System.EventHandler(this.button_editRemove_Click);
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(235, 12);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(100, 20);
            this.textBox_input.TabIndex = 9;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "New manufacturer\r\nname";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(235, 38);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 7;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // ManufacturerUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 117);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_editRemove);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_add);
            this.Name = "ManufacturerUpdate";
            this.Text = "ManufacturerUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_editRemove;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add;
    }
}