using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrandAssignment1__ARRAY_
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int valueLast;

        public int ValueLast
        {
            get
            {
                return valueLast;
            }

            set
            {
                valueLast = value;
            }
        }

        public string Label1
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valueLast = 0;
            bool vl = int.TryParse(textBox1.Text, out valueLast);
            if (!vl)
            {
                MessageBox.Show("Please enter a value");
            }
            textBox1.Clear();
            this.Close();
        }
    }
}
