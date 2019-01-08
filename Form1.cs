using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   mainText.Text = "";
            mainText.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                mainText.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
  
            }
            this.Text = op.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                mainText.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = sv.FileName;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eliot's notepad based off youtube videos","help",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void exitButt_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.Copy();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.Cut();

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.Paste();

        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.SelectionFont = new Font(mainText.Font, FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.SelectionFont = new Font(mainText.Font, FontStyle.Italic);

        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.SelectionFont = new Font(mainText.Font, FontStyle.Underline);

        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.SelectionFont = new Font(mainText.Font, FontStyle.Regular);

        }
    }
}
