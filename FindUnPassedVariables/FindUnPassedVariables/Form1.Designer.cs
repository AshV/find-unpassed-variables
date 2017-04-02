namespace FindUnPassedVariables
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
            this.lnkUploadSchema = new System.Windows.Forms.LinkLabel();
            this.chkSchema = new System.Windows.Forms.CheckBox();
            this.grpTop = new System.Windows.Forms.GroupBox();
            this.lnkTCFile = new System.Windows.Forms.LinkLabel();
            this.grpBottom = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.grpTop.SuspendLayout();
            this.grpBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkUploadSchema
            // 
            this.lnkUploadSchema.AutoSize = true;
            this.lnkUploadSchema.Location = new System.Drawing.Point(283, 13);
            this.lnkUploadSchema.Name = "lnkUploadSchema";
            this.lnkUploadSchema.Size = new System.Drawing.Size(86, 13);
            this.lnkUploadSchema.TabIndex = 1;
            this.lnkUploadSchema.TabStop = true;
            this.lnkUploadSchema.Text = "Which Schema?";
            this.lnkUploadSchema.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUploadSchema_LinkClicked);
            // 
            // chkSchema
            // 
            this.chkSchema.AutoSize = true;
            this.chkSchema.Location = new System.Drawing.Point(53, 12);
            this.chkSchema.Name = "chkSchema";
            this.chkSchema.Size = new System.Drawing.Size(224, 17);
            this.chkSchema.TabIndex = 0;
            this.chkSchema.Text = "Check File Provided Against Schema Also";
            this.chkSchema.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkSchema.UseVisualStyleBackColor = true;
            // 
            // grpTop
            // 
            this.grpTop.Controls.Add(this.lnkTCFile);
            this.grpTop.Controls.Add(this.chkSchema);
            this.grpTop.Controls.Add(this.lnkUploadSchema);
            this.grpTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTop.Location = new System.Drawing.Point(0, 0);
            this.grpTop.Name = "grpTop";
            this.grpTop.Size = new System.Drawing.Size(614, 34);
            this.grpTop.TabIndex = 3;
            this.grpTop.TabStop = false;
            this.grpTop.Text = "[AshV]";
            // 
            // lnkTCFile
            // 
            this.lnkTCFile.AutoSize = true;
            this.lnkTCFile.Location = new System.Drawing.Point(375, 13);
            this.lnkTCFile.Name = "lnkTCFile";
            this.lnkTCFile.Size = new System.Drawing.Size(80, 13);
            this.lnkTCFile.TabIndex = 5;
            this.lnkTCFile.TabStop = true;
            this.lnkTCFile.Text = "Which TC File?";
            this.lnkTCFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTCFile_LinkClicked);
            // 
            // grpBottom
            // 
            this.grpBottom.Controls.Add(this.textBox1);
            this.grpBottom.Controls.Add(this.button1);
            this.grpBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpBottom.Location = new System.Drawing.Point(0, 274);
            this.grpBottom.Name = "grpBottom";
            this.grpBottom.Size = new System.Drawing.Size(614, 100);
            this.grpBottom.TabIndex = 5;
            this.grpBottom.TabStop = false;
            this.grpBottom.Text = "Copy n Paste File";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 78);
            this.button1.TabIndex = 1;
            this.button1.Text = "This\r\n <-TC\r\n File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult.Location = new System.Drawing.Point(0, 34);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(461, 75);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(614, 374);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.grpBottom);
            this.Controls.Add(this.grpTop);
            this.Name = "Form1";
            this.Text = "Find UnPassed Variable";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpTop.ResumeLayout(false);
            this.grpTop.PerformLayout();
            this.grpBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkUploadSchema;
        private System.Windows.Forms.CheckBox chkSchema;
        private System.Windows.Forms.GroupBox grpTop;
        private System.Windows.Forms.LinkLabel lnkTCFile;
        private System.Windows.Forms.GroupBox grpBottom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RichTextBox textBox1;
    }
}

