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
    }
}
