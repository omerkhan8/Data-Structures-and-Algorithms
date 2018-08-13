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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int val;

        public int Val
        {
            get
            {
                return val;
            }

            set
            {
                val = value;
            }
         
        }

        public string Lable
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
            val = 0;
            bool v = int.TryParse(textBox1.Text, out val);
            if (!v)
            {
                MessageBox.Show("Invalud Value Entered");
            }

            textBox1.Clear();
            this.Close();
            
        }
    }
}
