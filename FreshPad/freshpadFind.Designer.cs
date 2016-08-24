namespace FreshPad
{
    partial class freshpadFind
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
            this.findFindLbl = new System.Windows.Forms.Label();
            this.freshpadFindTxt = new System.Windows.Forms.TextBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findFindLbl
            // 
            this.findFindLbl.AutoSize = true;
            this.findFindLbl.Location = new System.Drawing.Point(12, 9);
            this.findFindLbl.Name = "findFindLbl";
            this.findFindLbl.Size = new System.Drawing.Size(30, 13);
            this.findFindLbl.TabIndex = 0;
            this.findFindLbl.Text = "Find:";
            // 
            // freshpadFindTxt
            // 
            this.freshpadFindTxt.Location = new System.Drawing.Point(48, 6);
            this.freshpadFindTxt.Name = "freshpadFindTxt";
            this.freshpadFindTxt.Size = new System.Drawing.Size(322, 20);
            this.freshpadFindTxt.TabIndex = 1;
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(146, 32);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(75, 23);
            this.findBtn.TabIndex = 2;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // freshpadFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 62);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.freshpadFindTxt);
            this.Controls.Add(this.findFindLbl);
            this.Name = "freshpadFind";
            this.Text = "freshpadFind";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label findFindLbl;
        public System.Windows.Forms.TextBox freshpadFindTxt;
        private System.Windows.Forms.Button findBtn;
    }
}