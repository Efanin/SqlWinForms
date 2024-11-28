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
    public partial class FormNewNameFio : Form
    {
        private string nameFio;
        private Form1 form1;
        public FormNewNameFio(string nameFio,Form1 form1)
        {
            InitializeComponent();
            this.nameFio = nameFio;
            this.form1 = form1;
            label1.Text = nameFio;
        }

        private void FormNewNameFio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.addNewNameFio(nameFio);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
