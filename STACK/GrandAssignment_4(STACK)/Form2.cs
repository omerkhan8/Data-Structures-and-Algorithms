using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrandAssignment_4_STACK_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int[] arr;
        int index = 9;
        int stackPointer;

        private void Form2_Load(object sender, EventArgs e)
        {
            CreateStack();
            arr = new int[10];
            StackPtr.Font = new Font("Arial", 9, FontStyle.Bold);
            StackPtr.Text = "Null";

        }

        public void CreateStack()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Label lbl = new Label();
                    lbl.Font = new Font("Arial", 9, FontStyle.Bold);
                    lbl.Name = "lbl" + i;
                    //lbl.Text = ((i + 1).ToString());
                    lbl.Size = new Size(100, 40);
                    lbl.Location = new Point(j * 40, i * 40);
                    lbl.BorderStyle = BorderStyle.FixedSingle;
                    panel1.Controls.Add(lbl);
                }
            }
        }

        public void PrintStack()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Label lbl = panel1.Controls.Find("lbl" + i, true).FirstOrDefault() as Label;
                    lbl.Text = arr[i].ToString();

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

        private void button1_Click(object sender, EventArgs e)
        {
            bool full = ArrayFull(arr);
            if (full || index == -1)
            {
                MessageBox.Show("Cannot push, Stack full!");
            }
            else
            {
                bool v = int.TryParse(textBox1.Text, out arr[index]);
                if (!v)
                {
                    MessageBox.Show("Invalid value entered!");
                }
                else
                {
                    stackPointer = 10 - index;
                    StackPtr.Text = stackPointer.ToString();
                    index--;
                    textBox1.Clear();
                    textBox1.Focus();
                    PrintStack();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool empty = ArrayEmpty(arr);
            if (empty)
            {
                MessageBox.Show("Cannot Pop from an empty stack!");
            }
            else
            {
                stackPointer--;
                StackPtr.Text = stackPointer.ToString();
                arr[index + 1] = 0;
                index++;
                PrintStack();

                if (stackPointer == 0)
                {
                    StackPtr.Text = "Null";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool empty = ArrayEmpty(arr);
            if (empty)
            {
                MessageBox.Show("Cannot Top from an empty stack!");
            }
            else
            {
                MessageBox.Show("Top value of stack is = " + arr[index + 1]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int current = stackPointer;
            MessageBox.Show("Currently Stack has " + current + " values in it!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool empty = ArrayEmpty(arr);
            if (empty)
            {
                MessageBox.Show("Stack is Empty");
            }
            else
            {
                MessageBox.Show("Stack is not Empty");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool full = ArrayFull(arr);
            if (full)
            {
                MessageBox.Show("Stack FULL!");
            }
            else
            {
                MessageBox.Show("Stack is not FULL!");
            }
        }

    }
}

