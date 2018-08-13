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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int[] arr1;
        int[] arr2;
        int[] arr3;
        int[] arr4 = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 0 };
        int arrIndex;
        int nullIndex;
        int del;
        int last;

        private void Form2_Load(object sender, EventArgs e)
        {
            arr1 = new int[10];
            arr2 = new int[10];
            arr3 = new int[10];

            CreateArray(panel1);
            CreateArray(panel2);
            CreateArray(panel3);
            CreateArray(panel4);
            PrintArray(panel4, arr4);
            LLptr.Text = "null";
            LLRptr.Text = "null";
            LLAvb.Text = 1.ToString();
        }

        public void CreateArray(Panel a)
        {
            for (int i = 0; i < 10; i++)
            {
                Label lbl = new Label();
                lbl.Font = new Font("Arial", 9, FontStyle.Bold);
                lbl.Name = "lbl" + i;
                //lbl.Text = (i + 1).ToString();
                lbl.Size = new Size(40, 40);
                lbl.Location = new Point(i * 40);
                lbl.BorderStyle = BorderStyle.FixedSingle;
                a.Controls.Add(lbl);
            }
        }

        public void PrintArray(Panel a, int[] num)
        {
            for (int i = 0; i < 10; i++)
            {
                Label lbl = a.Controls.Find("lbl" + i, true).FirstOrDefault() as Label;
                lbl.Text = num[i].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert();
            textBox1.Clear();
            textBox1.Focus();


        }

        public void insert()
        {
            if (LLAvb.Text == "null")
            {
                MessageBox.Show("Cannot insert because Linked List is Full");
            }
            else
            {
                int index = int.Parse(LLAvb.Text) - 1;
                arrIndex = index;


                bool r = int.TryParse(textBox1.Text, out arr1[index]);
                if (!r)
                {
                    MessageBox.Show("Please enter a valid value");
                }
                else
                {


                    if (LLptr.Text == "null")
                    {
                        LLptr.Text = LLAvb.Text;
                        LLRptr.Text = LLAvb.Text;
                        LLAvb.Text = arr4[index].ToString();
                        if (nullIndex == 9)
                        {
                            arr4[arr4.Length - 1] = 0;
                        }
                        if (nullIndex > 0 && arr4[arr4.Length - 1] != 0)
                        {
                            arr4[index - 1] = 0;
                            arr2[index] = 0;
                            last = index;
                            // arr3[(int.Parse(LLptr.Text) - 1)] = 0;
                        }
                    }


                    else if (index == 0)
                    {
                        arr2[index] = 0;
                        last = index;
                        arr3[(int.Parse(LLptr.Text) - 1)] = 0;
                        arr2[arr2.Length - 1] = index + 1;
                        arr3[index] = arr3.Length;
                        arr4[arr4.Length - 1] = 0;
                        nullIndex = lastNull(arr2);
                        LLRptr.Text = (last+1).ToString();
                        LLAvb.Text = arr4[index].ToString();
                    }
                    else
                    {
                        arr2[index] = 0;
                        last = index;
                        arr3[(int.Parse(LLptr.Text) - 1)] = 0;
                        arr2[index - 1] = index + 1;
                        arr3[index] = index;
                        arr4[index - 1] = 0;
                        nullIndex = lastNull(arr2);
                        LLRptr.Text = (last+1).ToString();
                        LLAvb.Text = arr4[index].ToString();
                    }

                    // arr2[(int.Parse(LLRptr.Text)-1)] = 0;

                    PrintArray(panel1, arr1);
                    PrintArray(panel2, arr2);
                    PrintArray(panel3, arr3);
                    PrintArray(panel4, arr4);

                    if (LLAvb.Text == "0")
                    {
                        LLAvb.Text = "null";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //   Form3 ThirdForm = new Form3();
            //   ThirdForm.ShowDialog();
            //   int del = ThirdForm.IndexNo;

            bool a = firstArr(arr1);
            if (a)
            {
                MessageBox.Show("cannot delect from Empty list");
            }
            else
            {
                try
                {

                    del = int.Parse(LLptr.Text);
                }
                catch
                {
                    MessageBox.Show("error");
                }

                if (del <= 0 || del > 10 || LLRptr.Text == "null")
                {
                    MessageBox.Show("Invalid index entered");
                }
                else
                {

                    if (del == int.Parse(LLptr.Text))
                    {
                        if (del == 1)
                        {
                            del -= 1;
                            LLptr.Text = arr2[del].ToString();
                            //  LLAvb.Text = (del + 1).ToString();
                            arr3[del + 1] = arr3[del];
                            arr4[arr4.Length - 1] = del + 1;
                            LLAvb.Text = arr4[last].ToString();
                        }

                        else if (del == 10)
                        {
                            del -= 1;
                            if (LLptr.Text == LLRptr.Text)
                            {
                                LLptr.Text = "null";
                                LLRptr.Text = "null";

                            }

                            arr3[0] = arr3[del];
                            arr4[del - 1] = del + 1;
                            LLAvb.Text = arr4[last].ToString();
                        }

                        else
                        {
                            del -= 1;
                            LLptr.Text = arr2[del].ToString();
                            arr3[del + 1] = arr3[del];
                            arr4[del - 1] = del + 1;
                            LLAvb.Text = arr4[last].ToString();

                        }

                        PrintArray(panel1, arr1);
                        PrintArray(panel2, arr2);
                        PrintArray(panel3, arr3);
                        PrintArray(panel4, arr4);

                        if (LLptr.Text == "0")
                        {
                            LLptr.Text = "null";
                            LLRptr.Text = "null";
                        }

                    }


                }
            }
        }



        public int lastNull(int[] num)
        {
            int count = 0;
            for (int i = 0; i != num.Length; i++)
            {
                if (num[i] == 0)
                {
                    count = i;
                    break;
                }
            }
            return count;
        }

        public bool firstArr(int[] num)
        {
            int temp = 0;

            for (int i = 0; i != num.Length; i++)
            {
                if (num[i] == 0)
                {
                    temp++;
                }
            }
            if (temp == num.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}

