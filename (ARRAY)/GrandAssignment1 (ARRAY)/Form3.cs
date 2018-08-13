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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int locationIndex;
        int insertIndex;

        public int LocationIndex
        {
            get
            {
                return locationIndex;
            }
            set
            {
                locationIndex = value;
            }
        }

        public int InsertIndex
        {
            get
            {
                return insertIndex;
            }
            set
            {
                insertIndex = value;
            }
        }

       
      
        private void button1_Click(object sender, EventArgs e)
        {
            insertIndex = 0;
            locationIndex = 0;

            bool li = int.TryParse(textBox1.Text, out locationIndex);
            if (!li || locationIndex < 0 || locationIndex > 100)
            {
                MessageBox.Show("please enter a valid value");
            }

            bool ii = int.TryParse(textBox2.Text, out insertIndex);
            if (!li)
            {
                MessageBox.Show("please enter a valid value");
            }
            textBox1.Clear();
            textBox2.Clear();
            this.Close();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("please Enter a value");
                textBox1.Focus();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("please Enter a value");
                textBox2.Focus();
            }
        }

        
    }
}
