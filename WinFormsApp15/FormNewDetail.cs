using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp15
{
    public partial class FormNewDetail : Form
    {
        string namefio;
        string detail;
        string count;
        string date;
        Form1 form1;
        public FormNewDetail(string namefio,string detail,string count,string date, Form1 form1)
        {
            InitializeComponent();
            this.detail = detail;
            this.form1 = form1;
            this.namefio = namefio;
            this.date = date;
            this.count = count;
            label1.Text = detail;
        }

        private void FormNewDetail_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = int.Parse(textBox1.Text);
            form1.Sales(namefio, detail, price, count, date);
            form1.addNewDetail(detail, price);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int price = int.Parse(textBox1.Text);
            form1.Sales(namefio, detail, price, count, date);
            this.Close();
        }
    }
}
