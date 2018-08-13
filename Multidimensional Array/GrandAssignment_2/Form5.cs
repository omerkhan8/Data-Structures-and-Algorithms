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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        int value1;
        int value2;
        int value3;

        public int Value1
        {
            get
            {
                return value1;
            }
        }

        public int Value2
        {
            get
            {
                return value2;
            }
        }

        public int Value3
        {
            get
            {
                return value3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value1 = 0;
            value2 = 0;
            value3 = 0;

            bool v1 = int.TryParse(textBox1.Text, out value1);
            bool v2 = int.TryParse(textBox2.Text, out value2);
            bool v3 = int.TryParse(textBox3.Text, out value3);

            if (!v1 || !v2 || !v3)
            {
                MessageBox.Show("Invalid value entered!");
            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            this.Close();
            
        }
    }
}
