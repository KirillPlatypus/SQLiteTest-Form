using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLiteTest_Form
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        public string massege { get; set; }


        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = $"{massege}";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
