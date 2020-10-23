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

        List<PeopleToday> select = Command.Read<PeopleToday>.AnotherReadDB(Program.today);
        
        public Form1()
        {
            InitializeComponent();
            Program.Id = select.Count;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            select = Command.Read<PeopleToday>.AnotherReadDB(Program.today);

            for (int i = 0; i < select.Count; i++)
            {
                textBox2.Text += 
                $" {select[i].id} " +
                $" {select[i].name} " +
                $" {select[i].app} " +
                $" {select[i].date} " +
                $" {select[i].coordinate} " +
                $" {select[i].place} " +
                $" {Environment.NewLine}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.today.id = ++Program.Id;

            Command.Change<string>.Insert(Program.column, Program.today);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Program.today.id != 0 ) 
            {
                Command.Change<string>.Update(long.Parse(id.Text), Program.today, Program.column);

                textBox2.Text += $"Row was updeted on id {long.Parse(id.Text)}  {Environment.NewLine}";

            }

            else { textBox2.Text += $"There print 'id' for update row {Environment.NewLine}"; }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (Program.today.id != 0 )
            {
                Command.Change<string>.Delete(long.Parse(id.Text));

                textBox2.Text += $"Row was deleted on id {long.Parse(id.Text)}  {Environment.NewLine}";

            }

            else { textBox2.Text += $"There print 'id' for delete row {Environment.NewLine}"; }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }



        private void column1_TextChanged(object sender, EventArgs e)
        {
            //Program.column = column1.Text;

        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Program.today.id = long.Parse(id.Text);
            }
            catch (FormatException)
            {
                Program.today.id = 0;
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            Program.today.name = name.Text;

        }

        private void app_TextChanged(object sender, EventArgs e)
        {
            Program.today.app = app.Text;
        }

        private void date_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Program.today.date = long.Parse(date.Text);
            }
            catch (FormatException)
            {
                Program.today.date = 0;
            }
        }

        private void coordinate_TextChanged(object sender, EventArgs e)
        {
            Program.today.coordinate = coordinate.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Place_TextChanged(object sender, EventArgs e)
        {
            Program.today.place = Place.Text;
        }
    }
}
