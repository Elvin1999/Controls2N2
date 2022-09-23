using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("myfile.txt", richTextBox1.Text);
        }
        public bool isAutoSave { get; set; } = false;
        private void avtoSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isAutoSave = true;
        }

        private void turnOffAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isAutoSave = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (isAutoSave)
            {
                File.WriteAllText("myfile.txt", richTextBox1.Text);
            }
        }
    }
}
