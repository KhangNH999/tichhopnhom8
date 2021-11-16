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
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
