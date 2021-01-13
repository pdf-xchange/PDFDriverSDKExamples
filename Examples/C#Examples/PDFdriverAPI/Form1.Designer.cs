namespace PDFdriverAPI
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
            this.tbEventsLog = new System.Windows.Forms.TextBox();
            this.bPrint = new System.Windows.Forms.Button();
            this.bFilePrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEventsLog
            // 
            this.tbEventsLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEventsLog.Location = new System.Drawing.Point(18, 63);
            this.tbEventsLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEventsLog.Multiline = true;
            this.tbEventsLog.Name = "tbEventsLog";
            this.tbEventsLog.Size = new System.Drawing.Size(823, 446);
            this.tbEventsLog.TabIndex = 0;
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(18, 18);
            this.bPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(112, 35);
            this.bPrint.TabIndex = 1;
            this.bPrint.Text = "Simple Print";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // bFilePrint
            // 
            this.bFilePrint.Location = new System.Drawing.Point(140, 18);
            this.bFilePrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bFilePrint.Name = "bFilePrint";
            this.bFilePrint.Size = new System.Drawing.Size(112, 35);
            this.bFilePrint.TabIndex = 2;
            this.bFilePrint.Text = "File Print";
            this.bFilePrint.UseVisualStyleBackColor = true;
            this.bFilePrint.Click += new System.EventHandler(this.bFilePrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 529);
            this.Controls.Add(this.bFilePrint);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.tbEventsLog);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "PDF-Xchange V9.0 DotNet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEventsLog;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.Button bFilePrint;
    }
}

