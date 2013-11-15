using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContrastChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = panel1.BackColor.R;
            numericUpDown2.Value = panel1.BackColor.G;
            numericUpDown3.Value = panel1.BackColor.B;
            numericUpDown4.Value = panel2.BackColor.R;
            numericUpDown5.Value = panel2.BackColor.G;
            numericUpDown6.Value = panel2.BackColor.B;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(255, (int)numericUpDown4.Value, (int)numericUpDown5.Value, (int)numericUpDown6.Value);
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(255, (int)numericUpDown4.Value, (int)numericUpDown5.Value, (int)numericUpDown6.Value);
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(255, (int)numericUpDown4.Value, (int)numericUpDown5.Value, (int)numericUpDown6.Value);
        }
    }
}
