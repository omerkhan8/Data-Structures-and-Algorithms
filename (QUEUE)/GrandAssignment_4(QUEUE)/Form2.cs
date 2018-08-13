using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrandAssignment_4_QUEUE_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int[] arr;
        int index = 9;
        int rarePtr;

        private void Form2_Load(object sender, EventArgs e)
        {
            CreateQueue();
            arr = new int[10];
            FPtr.Text = "0";
            RPtr.Text = "null";
            FPtr.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            RPtr.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
        }

        public void CreateQueue()
        {
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Label lbl = new Label();
                    lbl.Font = new Font("Arial", 9, FontStyle.Bold);
                    lbl.Name = "lbl" + j;
                    //  lbl.Text = (j + 1).ToString();
                    lbl.Size = new Size(40, 80);
                    lbl.Location = new Point(j * 40, i * 40);
                    lbl.BorderStyle = BorderStyle.FixedSingle;
                    panel1.Controls.Add(lbl);


                }
            }
        }

        public void PrintQueue()
        {
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Label lbl = panel1.Controls.Find("lbl" + j, true).FirstOrDefault() as Label;
                    lbl.Text = arr[j].ToString();

                }
            }
        }

        public bool ArrayFull(int[] num)
        {
            if ((num[num.Length - 1] > 0 || num[num.Length - 1] < 0) && (num[0] > 0 || num[0] < 0) && (num[num.Length - 2] > 0 || num[num.Length - 2] < 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ArrayEmpty(int[] num)
        {
            int count = 0;
            for (int i = 0; i != num.Length; i++)
            {
                if (num[i] == 0)
                {
                    count++;
                }
            }
            if (count == num.Length)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public int[] shiftRight(int[] num)
        {
            int count = 0;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] > 0 || num[i] < 0)
                {
                    count = i;
                    break;
                }
            }

            for (int i = count; i >= 0; i--)
            {
                num[count + 1] = num[count];

                count--;
            }

            return num;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool full = ArrayFull(arr);
            if (full)
            {
                MessageBox.Show("Queue Full!");
            }
            else
            {
                bool r = int.TryParse(textBox1.Text, out arr[index]);
                if (!r)
                {
                    MessageBox.Show("Invalid value entered!");
                }
                else
                {
                    FPtr.Text = "1";
                    rarePtr = 10 - index;
                    RPtr.Text = rarePtr.ToString();
                    index--;
                    PrintQueue();
                    textBox1.Clear();
                    textBox1.Focus();

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool empty = ArrayEmpty(arr);
            if (empty)
            {
                MessageBox.Show("Cannot Serve anything from an empty Queue!");
            }
            else
            {
                arr[9] = 0;
                arr = shiftRight(arr);
                arr[0] = 0;
                rarePtr--;
                RPtr.Text = rarePtr.ToString();
                index++;
                PrintQueue();
                if (RPtr.Text == "0")
                {
                    FPtr.Text = "0";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool empty = ArrayEmpty(arr);
            if (empty)
            {
                MessageBox.Show("Cannot Leave anything from an empty Queue!");
            }
            else
            {
                arr[index+1] = 0;
                rarePtr--;
                RPtr.Text = rarePtr.ToString();
                index++;
                PrintQueue();
                if (RPtr.Text == "0")
                {
                    FPtr.Text = "0";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (RPtr.Text == "10")
            {
                MessageBox.Show("Queue is Full");
            }
            else
            {
                MessageBox.Show("Queue is not Full");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (FPtr.Text == "0")
            {
                MessageBox.Show("Queue is Empty");
            }
            else
            {
                MessageBox.Show("Queue is not Empty");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently Queue has " + RPtr.Text + " values");
        }


    }
}
