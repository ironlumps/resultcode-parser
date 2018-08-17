namespace ResultCodeDescriptions
{
    partial class Form1
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
            this.btnRun = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkShort = new System.Windows.Forms.CheckBox();
            this.checkLong = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(29, 159);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(120, 44);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(215, 159);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(120, 44);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Result Code";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 3;
            // 
            // checkShort
            // 
            this.checkShort.AutoSize = true;
            this.checkShort.Checked = true;
            this.checkShort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkShort.Location = new System.Drawing.Point(29, 85);
            this.checkShort.Name = "checkShort";
            this.checkShort.Size = new System.Drawing.Size(107, 17);
            this.checkShort.TabIndex = 4;
            this.checkShort.Text = "Short Description";
            this.checkShort.UseVisualStyleBackColor = true;
            // 
            // checkLong
            // 
            this.checkLong.AutoSize = true;
            this.checkLong.Checked = true;
            this.checkLong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkLong.Location = new System.Drawing.Point(29, 118);
            this.checkLong.Name = "checkLong";
            this.checkLong.Size = new System.Drawing.Size(106, 17);
            this.checkLong.TabIndex = 5;
            this.checkLong.Text = "Long Description";
            this.checkLong.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(393, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(270, 96);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 257);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkLong);
            this.Controls.Add(this.checkShort);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "Result Code Parse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkShort;
        private System.Windows.Forms.CheckBox checkLong;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

