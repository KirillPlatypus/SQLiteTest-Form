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
        internal long id { get; set; }
        internal string name { get; set; }
        internal string app { get; set; }
        internal long date { get; set; }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            rows2.Text = $"{name}";

        }
    }
}
