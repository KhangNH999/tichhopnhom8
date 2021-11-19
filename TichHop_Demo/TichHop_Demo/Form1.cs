using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TichHop_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] row1 = new string[] { "001", "Phan Trung", "Hieu", "Male", "Vietnam", null, "A", "B", "C"   };
            string[] row2 = new string[] { "002", "Nguyen Ho", "Hai", "Male", "Vietnam", null, "A", "B", "C" };
            string[] row3 = new string[] { "003", "Tran Nguyen", "Dan", "Female", "Vietnam", null, "A", "B", "C" };

            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
            dataGridView1.Rows.Add(row3);

            string[] row4 = new string[] { "Basic pay", "15000","15000"};
            string[] row5 = new string[] { "Overtime", "[value]*[Basic pay]/100", "1200" };
            string[] row6 = new string[] { "Overtime or Holliday", "[value]*[Basic pay]/100", "700" };
            string[] row7 = new string[] { "Bonus", "[value]*[Basic pay]/100", "4800" };

            dataGridView2.Rows.Add(row4);
            dataGridView2.Rows.Add(row5);
            dataGridView2.Rows.Add(row6);
            dataGridView2.Rows.Add(row7);

            string[] row8 = new string[] { "Insurance", "300", "300" };
            string[] row9 = new string[] { "Profesional Tax", "[value]*[Basic pay]/100", "500" };
            string[] row10 = new string[] { "Provide Fund", "[value]*[Basic pay]/100", "900" };

            dataGridView3.Rows.Add(row8);
            dataGridView3.Rows.Add(row9);
            dataGridView3.Rows.Add(row10);

            string[] row11 = new string[] { "Advance payment and loan company", "0" };
            string[] row12 = new string[] { "Borrow the car company", "200" };
            string[] row13 = new string[] { "Conveyance Allowance", "500" };
            string[] row14 = new string[] { "House Rent Allowance", "150" };
            string[] row15 = new string[] { "Health insurance", "300" };
            string[] row16 = new string[] { "Shares of the company", "300" };
            dataGridView4.Rows.Add(row11);
            dataGridView4.Rows.Add(row12);
            dataGridView4.Rows.Add(row13);
            dataGridView4.Rows.Add(row14);
            dataGridView4.Rows.Add(row15);
            dataGridView4.Rows.Add(row16);

            string[] row17 = new string[] { "A level", "2020" };
            string[] row18 = new string[] { "College Degree", "2021" };
            dataGridView5.Rows.Add(row17);
            dataGridView5.Rows.Add(row18);

            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox9.SelectedIndex = 0;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
