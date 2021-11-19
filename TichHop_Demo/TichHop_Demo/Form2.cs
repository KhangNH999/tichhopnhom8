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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string[] row1 = new string[] {"1", "Trần Nguyễn Dân", "VietNam", "Sales Department", "Staff", "12/11/2021", "1 year"};
            dataGridView1.Rows.Add(row1);

            string[] row2 = new string[] { "1", "Trần Nguyễn Dân", "VietNam", "Sales Department", "Staff", "3"};
            string[] row3 = new string[] { "2", "Phạm Phú Minh Nhật", "VietNam", "Sales Department", "Staff", "1" };
            dataGridView2.Rows.Add(row2);
            dataGridView2.Rows.Add(row3);

            string[] row4 = new string[] { "1", "Trần Nguyễn Dân", "VietNam", "Sales Department", "Staff", "Not buy medical insurance", "His salary add 300$ on November" };
            string[] row5 = new string[] { "2", "Phạm Phú Minh Nhật", "VietNam", "Sales Department", "Staff", "'Advance payment in three months'.Company delt is 1600$.", "He won't be paid on December, January, February" };
            string[] row6 = new string[] { "3", "Phan Trung Hiếu", "VietNam", "Sales Department", "Staff", "'Buy shares of company'. He bought 300 shares.", "Add the profits of the company's shares each month(if any)" };
            dataGridView3.Rows.Add(row4);
            dataGridView3.Rows.Add(row5);
            dataGridView3.Rows.Add(row6);

            string[] row7 = new string[] { "1", "Trần Nguyễn Dân", "VietNam", "Sales Department", "Staff", "20/10/2000" };
            string[] row8 = new string[] { "2", "Phạm Phú Minh Nhật", "VietNam", "Sales Department", "Staff", "6/8/2000" };
            string[] row9 = new string[] { "3", "Phan Trung Hiếu", "VietNam", "Sales Department", "Staff", "2/10/2000" };
            string[] row10 = new string[] { "4", "Nguyễn Hồ Hải", "VietNam", "Sales Department", "Staff", "7/8/2000" };
            string[] row11 = new string[] { "5", "Triệu Quang Khải", "VietNam", "Sales Department", "Staff", "11/10/2000" };
            string[] row12 = new string[] { "6", "Trương Công Nhật", "VietNam", "Sales Department", "Staff", "9/8/2000" };
            dataGridView4.Rows.Add(row7);
            dataGridView4.Rows.Add(row8);
            dataGridView4.Rows.Add(row9);
            dataGridView4.Rows.Add(row10);
            dataGridView4.Rows.Add(row11);
            dataGridView4.Rows.Add(row12);

            comboBox9.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox10.SelectedIndex = 0;
            comboBox12.SelectedIndex = 0;
            comboBox11.SelectedIndex = 0;
        }
    }
}
