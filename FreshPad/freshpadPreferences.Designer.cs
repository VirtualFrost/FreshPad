namespace FreshPad
{
    partial class freshpadPrefForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(freshpadPrefForm));
            this.fontPanel = new System.Windows.Forms.GroupBox();
            this.fontItalicCheckBox = new System.Windows.Forms.CheckBox();
            this.fontBoldCheckBox = new System.Windows.Forms.CheckBox();
            this.fontTypeBox = new System.Windows.Forms.ComboBox();
            this.prefFontTypeLbl = new System.Windows.Forms.Label();
            this.prefFontSizeLbl = new System.Windows.Forms.Label();
            this.fontSizeBox = new System.Windows.Forms.ComboBox();
            this.fontPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontPanel
            // 
            this.fontPanel.Controls.Add(this.fontItalicCheckBox);
            this.fontPanel.Controls.Add(this.fontBoldCheckBox);
            this.fontPanel.Controls.Add(this.fontTypeBox);
            this.fontPanel.Controls.Add(this.prefFontTypeLbl);
            this.fontPanel.Controls.Add(this.prefFontSizeLbl);
            this.fontPanel.Controls.Add(this.fontSizeBox);
            this.fontPanel.Location = new System.Drawing.Point(12, 12);
            this.fontPanel.Name = "fontPanel";
            this.fontPanel.Size = new System.Drawing.Size(182, 137);
            this.fontPanel.TabIndex = 0;
            this.fontPanel.TabStop = false;
            this.fontPanel.Text = "Font";
            // 
            // fontItalicCheckBox
            // 
            this.fontItalicCheckBox.AutoSize = true;
            this.fontItalicCheckBox.Location = new System.Drawing.Point(56, 100);
            this.fontItalicCheckBox.Name = "fontItalicCheckBox";
            this.fontItalicCheckBox.Size = new System.Drawing.Size(53, 17);
            this.fontItalicCheckBox.TabIndex = 5;
            this.fontItalicCheckBox.Text = "Italics";
            this.fontItalicCheckBox.UseVisualStyleBackColor = true;
            this.fontItalicCheckBox.CheckedChanged += new System.EventHandler(this.fontItalicCheckBox_CheckedChanged);
            // 
            // fontBoldCheckBox
            // 
            this.fontBoldCheckBox.AutoSize = true;
            this.fontBoldCheckBox.Location = new System.Drawing.Point(56, 77);
            this.fontBoldCheckBox.Name = "fontBoldCheckBox";
            this.fontBoldCheckBox.Size = new System.Drawing.Size(47, 17);
            this.fontBoldCheckBox.TabIndex = 4;
            this.fontBoldCheckBox.Text = "Bold";
            this.fontBoldCheckBox.UseVisualStyleBackColor = true;
            this.fontBoldCheckBox.CheckedChanged += new System.EventHandler(this.fontBoldCheckBox_CheckedChanged);
            // 
            // fontTypeBox
            // 
            this.fontTypeBox.FormattingEnabled = true;
            this.fontTypeBox.Location = new System.Drawing.Point(56, 50);
            this.fontTypeBox.Name = "fontTypeBox";
            this.fontTypeBox.Size = new System.Drawing.Size(120, 21);
            this.fontTypeBox.TabIndex = 3;
            // 
            // prefFontTypeLbl
            // 
            this.prefFontTypeLbl.AutoSize = true;
            this.prefFontTypeLbl.Location = new System.Drawing.Point(11, 53);
            this.prefFontTypeLbl.Name = "prefFontTypeLbl";
            this.prefFontTypeLbl.Size = new System.Drawing.Size(34, 13);
            this.prefFontTypeLbl.TabIndex = 2;
            this.prefFontTypeLbl.Text = "Type:";
            // 
            // prefFontSizeLbl
            // 
            this.prefFontSizeLbl.AutoSize = true;
            this.prefFontSizeLbl.Location = new System.Drawing.Point(15, 22);
            this.prefFontSizeLbl.Name = "prefFontSizeLbl";
            this.prefFontSizeLbl.Size = new System.Drawing.Size(30, 13);
            this.prefFontSizeLbl.TabIndex = 1;
            this.prefFontSizeLbl.Text = "Size:";
            // 
            // fontSizeBox
            // 
            this.fontSizeBox.FormattingEnabled = true;
            this.fontSizeBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.fontSizeBox.Location = new System.Drawing.Point(56, 19);
            this.fontSizeBox.Name = "fontSizeBox";
            this.fontSizeBox.Size = new System.Drawing.Size(120, 21);
            this.fontSizeBox.TabIndex = 0;
            this.fontSizeBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // freshpadPrefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 278);
            this.Controls.Add(this.fontPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "freshpadPrefForm";
            this.Text = "FreshPad - Preferences";
            this.fontPanel.ResumeLayout(false);
            this.fontPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FreshPad _fpForm;
        private System.Windows.Forms.GroupBox fontPanel;
        private System.Windows.Forms.Label prefFontSizeLbl;
        private System.Windows.Forms.ComboBox fontSizeBox;
        private System.Windows.Forms.CheckBox fontItalicCheckBox;
        private System.Windows.Forms.CheckBox fontBoldCheckBox;
        private System.Windows.Forms.ComboBox fontTypeBox;
        private System.Windows.Forms.Label prefFontTypeLbl;
    }
}