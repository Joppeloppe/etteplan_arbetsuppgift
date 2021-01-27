
namespace etteplan_arbetsuppgift_winforms
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
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.RichTextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(13, 13);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "Browse file";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(12, 85);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(420, 126);
            this.textBoxLog.TabIndex = 1;
            this.textBoxLog.Text = "";
            // 
            // buttonResult
            // 
            this.buttonResult.Enabled = false;
            this.buttonResult.Location = new System.Drawing.Point(357, 217);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(75, 23);
            this.buttonResult.TabIndex = 2;
            this.buttonResult.Text = "Show result";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(94, 17);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(339, 20);
            this.textBoxFileName.TabIndex = 3;
            this.textBoxFileName.TextChanged += new System.EventHandler(this.textBoxFileName_TextChanged);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(342, 56);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 261);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonBrowse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.RichTextBox textBoxLog;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonGenerate;
    }
}

