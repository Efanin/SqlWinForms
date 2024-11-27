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
        string detail;
        Form1 form1;
        public FormNewDetail(string detail, Form1 form1)
        {
            InitializeComponent();
            this.detail = detail;
            this.form1 = form1;
        }

        private void FormNewDetail_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = int.Parse(textBox1.Text);
            form1.addNewDetail(detail, price);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
