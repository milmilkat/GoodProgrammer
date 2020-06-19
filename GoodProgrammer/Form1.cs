using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodProgrammer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //nothing
            textBox2.Text = (Convert.ToInt32(textBox1.Text) % 2 == 0) ? "Even" : "Odd";
            //nothing again
        }
    }
}
