using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputNumber_ValueChanged(object sender, EventArgs e)
        {
            var number = double.Parse(this.inputNumber.Text);
            var euro = number / 1.94;
            this.result.Text = euro.ToString();
        }
    }
}
