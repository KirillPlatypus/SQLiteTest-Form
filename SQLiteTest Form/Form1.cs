using SQLite3Test;
using SQLiteTest_Form.DB;
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
        static PeopleToday today = new PeopleToday();

        string column;
        List<PeopleToday> select = Command.Read<PeopleToday>.AnotherReadDB(today);

        public Form1()
        {
            InitializeComponent();

        }

        internal List<PeopleToday> messege { get; set; }


        private void button1_Click_1(object sender, EventArgs e)
        {
             select = Command.Read<PeopleToday>.AnotherReadDB(today);

            for (int i = 0; i < select.Count; i++)
            {
                textBox2.Text += $"{select[i].id} " +
                $" {select[i].name} " +
                $" {select[i].app} " +
                $" {select[i].date} " +
                $" {select[i].coordinate} {Environment.NewLine}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Id = select.Count;
            Command.Change<string>.Insert(Id++, name.Text, column);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
       

        private void column1_TextChanged(object sender, EventArgs e)
        {
            column = column1.Text;
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            //today.id = id.Text;
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            today.name = name.Text;

        }

        private void app_TextChanged(object sender, EventArgs e)
        {
            today.app = app.Text;
        }

        private void date_TextChanged(object sender, EventArgs e)
        {
            //today.date = coordinate.Text;
        }

        private void coordinate_TextChanged(object sender, EventArgs e)
        {
            today.coordinate = coordinate.Text;
        }
    }
}
