using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrandAssignment_3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int indexNo;

        public int IndexNo
        {
            get
            {
                return indexNo;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool i = int.TryParse(textBox1.Text, out indexNo);
            if (!i)
            {
                MessageBox.Show("please enter a valid value");
            }
            else
            {
                textBox1.Clear();
                this.Close();
            }
        }
    }
}
