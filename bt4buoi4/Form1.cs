using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt4buoi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedIndices.Count > 0)
            {
                ListViewItem listViewItem = listView1.SelectedItems[0];
                string MSNV = listViewItem.SubItems[0].Text;
                string TenSP=
                listViewItem.SubItems[1].Text;
                string LuongCB =
               listViewItem.SubItems[2].Text;


            }


        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.DataSent += Form2_DataSent;
            form2.Show(); // Hoặc form2.ShowDialog() nếu bạn muốn Form2 là form modal
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.DataSent += Form2_DataSent;
            form2.Show(); // Hoặc form2.ShowDialog() nếu bạn muốn Form2 là form modal

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {

            this.Close();


        }
        private void Form2_DataSent(string data1, string data2, string data3)
        {
            // Thêm dữ liệu vào ListView
            ListViewItem item = new ListViewItem(data1);
            item.SubItems.Add(data2);
            item.SubItems.Add(data3);
            listView1.Items.Add(item);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
