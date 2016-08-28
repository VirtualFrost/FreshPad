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
    public partial class freshpadFind : Form
    {
        FreshPad freshpadForm;
        public freshpadFind(FreshPad fpForm)
        {
            InitializeComponent();
            freshpadForm = fpForm;
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            /*for(int i = 0; i < freshpadForm.freshpadBox.Text.Length; i++)
            {
                if (freshpadFindTxt.Text == freshpadForm.freshpadBox.Text)
                {
                    freshpadForm.freshpadBox.SelectionStart = 0;
                    freshpadForm.freshpadBox.SelectionLength = freshpadFindTxt.Text.Length;
                }
            }*/
        }
    }
}
