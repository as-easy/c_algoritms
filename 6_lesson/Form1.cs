using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_lesson
{
    /// <summary>
    /// Автор: Варанкин Владимир
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = " ";
            }

            HashFunction hash = new HashFunction();
            textBox2.Text = hash.HashMetod(textBox1.Text).ToString();
        }
    }
}
