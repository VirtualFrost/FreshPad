using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;


namespace FreshPad
{
    public partial class FreshPad : Form
    {
        OpenFileDialog openDialog = new OpenFileDialog();   //Open Dialog
        SaveFileDialog saveDialog = new SaveFileDialog();   //Save Dialog
        public void setEditorFontSize(float size)
        {
            freshpadBox.Font = new Font(freshpadBox.Font.Name, size);
        }
        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            freshpadPrefForm fpPref = new freshpadPrefForm(this); // pass this to constructor
            fpPref.Show();
        }
        public FreshPad()
        {

            InitializeComponent();
            freshpadBox.SelectionFont = new Font("Times New Roman", 12, FontStyle.Regular);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void fIleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FreshPad_Load(object sender, EventArgs e)
        {

        }
        private void newTSM_Click(object sender, EventArgs e)
        {
            //Do Stuff
        }
        private void openTSM_Click(object sender, EventArgs e)
        {
            openDialog.Filter = "Text File(.txt)|*.txt";        //Filters which files to see
            openDialog.Title = "FreshPad - Open";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //freshpadBox.LoadFile(path);
            }
        }

        private void saveTSM_Click(object sender, EventArgs e)
        {
            saveDialog.Filter = "Text File(.txt)|*.txt";        //Filters which files to see
            saveDialog.Title = "FreshPad - Save";
            /*if (!File.Exists(path))                             //Check to see if file&path exists
            {
                saveDialog.ShowDialog();
            }*/
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            freshpadFind fpFind = new freshpadFind(this); // pass this to constructor
            fpFind.Show();
        }
    }
}