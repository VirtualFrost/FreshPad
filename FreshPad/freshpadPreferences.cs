using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshPad
{
    public partial class freshpadPrefForm : Form
    {
        FreshPad freshpadForm;
        int fsize;
        string ffamily;
        bool fstyle;
        public freshpadPrefForm(FreshPad fpForm)
        {
            InitializeComponent();
            freshpadForm = fpForm;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fsize = Convert.ToByte(fontSizeBox.Text);
            freshpadForm.freshpadBox.Font = new Font("Times New Roman", fsize, FontStyle.Regular);
        }

        private void fontBoldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(freshpadForm.freshpadBox.Font.Style == FontStyle.Bold)
            {
                freshpadForm.freshpadBox.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            } else {
                freshpadForm.freshpadBox.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            }
            
        }

        private void fontItalicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (freshpadForm.freshpadBox.Font.Style == FontStyle.Italic)
            {
                freshpadForm.freshpadBox.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            }
            else
            {
                freshpadForm.freshpadBox.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            }
        }
    }
}