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
        int Id;
        string value;
        List<PeopleToday> select = Command.Read<PeopleToday>.AnotherReadDB(today);

        public Form1()
        {
            InitializeComponent();
            Id = select.Count;
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

            today.id = ++Id;
            value += $"{today.id}, ";
            Command.Change<string>.Insert(column, value);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
       

        private void column1_TextChanged(object sender, EventArgs e)
        {
            column = column1.Text;
        }
        

        private void name_TextChanged(object sender, EventArgs e)
        {
            today.name = name.Text;
            value += $"{today.name}, "; 

        }

        private void app_TextChanged(object sender, EventArgs e)
        {
            today.app = app.Text;
            value += $"{today.app}, ";
        }

        private void date_TextChanged(object sender, EventArgs e)
        {
            today.date = long.Parse(date.Text);
            value += $"{today.date}, ";

        }

        private void coordinate_TextChanged(object sender, EventArgs e)
        {
            today.coordinate = coordinate.Text;
            value += $"{today.coordinate} ";

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
