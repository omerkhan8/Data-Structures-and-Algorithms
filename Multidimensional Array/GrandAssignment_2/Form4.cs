using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrandAssignment_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int val1;
        int val2;

        public int Val1
        {
            get
            {
                return val1;
            }
        }

        public int Val2
        {
            get
            {
                return val2;
            }
        }

        public string Lable1
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

        public string Lable2
        {
            get
            {
                return label2.Text;
            }
            set
            {
                label2.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            val1 = 0;
            val2 = 0;

            bool v1 = int.TryParse(textBox1.Text, out val1);
            bool v2 = int.TryParse(textBox2.Text, out val2);
            if (!v1 || !v2)
            {
                MessageBox.Show("Invalid value entered");
            }
            textBox1.Clear();
            textBox2.Clear();
            this.Close();

        }
    }
}
