using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Process.Start("notepad.exe");
                    break;
                case 1:
                    Process.Start("mspaint.exe");
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox2.Visible = true;
            }
            else
            {
                groupBox2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBx1.Clear();
            txtBx2.Clear();
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odaberite neko dugme.","Obavještenje", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text text = new Text();
            text.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var messageBox= MessageBox.Show("Da li ste sigurni da želite zatvoriti aplikaciju ", "Potvrda",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
           if(messageBox==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
