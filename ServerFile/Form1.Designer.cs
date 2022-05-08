namespace ServerFile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.PathFileTxt = new System.Windows.Forms.TextBox();
            this.InfoTxt = new System.Windows.Forms.RichTextBox();
            this.SendBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name";
            // 
            // PathFileTxt
            // 
            this.PathFileTxt.Location = new System.Drawing.Point(176, 50);
            this.PathFileTxt.Name = "PathFileTxt";
            this.PathFileTxt.Size = new System.Drawing.Size(601, 27);
            this.PathFileTxt.TabIndex = 1;
            // 
            // InfoTxt
            // 
            this.InfoTxt.Location = new System.Drawing.Point(176, 114);
            this.InfoTxt.Name = "InfoTxt";
            this.InfoTxt.ReadOnly = true;
            this.InfoTxt.Size = new System.Drawing.Size(601, 314);
            this.InfoTxt.TabIndex = 2;
            this.InfoTxt.Text = "";
            // 
            // SendBTN
            // 
            this.SendBTN.Location = new System.Drawing.Point(442, 464);
            this.SendBTN.Name = "SendBTN";
            this.SendBTN.Size = new System.Drawing.Size(94, 29);
            this.SendBTN.TabIndex = 3;
            this.SendBTN.Text = "Send";
            this.SendBTN.UseVisualStyleBackColor = true;
            this.SendBTN.Click += new System.EventHandler(this.SendBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 521);
            this.Controls.Add(this.SendBTN);
            this.Controls.Add(this.InfoTxt);
            this.Controls.Add(this.PathFileTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox PathFileTxt;
        private RichTextBox InfoTxt;
        private Button SendBTN;
    }
}