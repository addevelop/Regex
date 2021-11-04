using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regexapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            RegularExp expresion;
            expresion = new RegularExp(textBox1.Text, textBox2.Text);

            if(expresion.Mregex() == true)
            {
                textBox3.Text += "\r\nMatch";
            }
            else
            {
                textBox3.Text += "\r\n/M";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
    }
}
