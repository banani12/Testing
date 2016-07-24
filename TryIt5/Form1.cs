using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryIt5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contentsTextBox.BackColor = Color.Pink;

        }

        private void lightGreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contentsTextBox.BackColor = Color.LightGreen;
        }

        private void lightBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contentsTextBox.BackColor = Color.LightBlue;
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contentsTextBox.Font = smallToolStripMenuItem.Font;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contentsTextBox.Font = normalToolStripMenuItem.Font;
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contentsTextBox.Font = largeToolStripMenuItem.Font;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redToolStripMenuItem.Checked = true;
            contentsTextBox.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = true;
            contentsTextBox.ForeColor = Color.Green;
            contentsTextBox.BackColor = Color.Cyan;
            
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = true;
            greenToolStripMenuItem.Checked = false;
            contentsTextBox.ForeColor = Color.Blue;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
