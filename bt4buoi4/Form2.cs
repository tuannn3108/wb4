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
    public partial class Form2 : Form
    {
        // Khai báo một delegate
        public delegate void DataSentEventHandler(string data1, string data2, string data3);
        // Khai báo một sự kiện dựa trên delegate đó
        public event DataSentEventHandler DataSent;
        public Form2()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string MSNV = this.textBox1.Text.Trim();
            string TenNV = this.textBox2.Text.Trim();
            string Luongcb = this.textBox3.Text.Trim(); // Lưu ý: Chuyển sang kiểu string cho nhất quán

            // Gửi dữ liệu thông qua sự kiện trước khi đóng form
            DataSent?.Invoke(MSNV, TenNV, Luongcb);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

}