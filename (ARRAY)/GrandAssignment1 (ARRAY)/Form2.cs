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
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();

        }

        Form3 ThirdForm = new Form3();
        Form4 FourthForm = new Form4();

        int[] arr1;
        int[] arr2;
        int[] arr3;
        int index1 = 0;
        int index2 = 0;
        int returnValue1;
        int returnValue2;


        // button taking index for 1st array
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int arrIndex;
            bool arrIndexx = int.TryParse(textBox1.Text, out arrIndex);
            returnValue1 = ArrayValue(arrIndex);
            if (returnValue1 > 0 && returnValue1 <= 100)
            {
                arr1 = new int[returnValue1];

                for (int i = 0; i != arr1.Length; i++)
                {
                    listBox1.Items.Add(arr1[i]);
                }
                listBox1.Items.Add("-----------xxx--------------------");
            }

            index1 = 0;
        }

        // Method for taking the index value from user
        public int ArrayValue(int arrValue)
        {

            if (arrValue > 100)
            {

                MessageBox.Show("Limit exceeded, you're not allowed to choose an index greater than 100", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (arrValue < 0)
            {
                MessageBox.Show("Cannot Give the Index value negative", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (arrValue == 0)
            {
                MessageBox.Show("Index value must be Greater than 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return arrValue;
        }

        // button takin index for 2st array
        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int arrIndex;
            bool arrIndexx = int.TryParse(textBox2.Text, out arrIndex);
            returnValue2 = ArrayValue(arrIndex);
            if (returnValue2 > 0 && returnValue2 <= 100)
            {
                arr2 = new int[returnValue2];

                for (int i = 0; i != arr2.Length; i++)
                {
                    listBox2.Items.Add(arr2[i]);
                }
                listBox2.Items.Add("-----------xxx--------------------");
            }

            index2 = 0;

        }

        // inserting values in 1st array
        private void arrValues1_Click(object sender, EventArgs e)
        {
            if (index1 < returnValue1)
            {
                bool arr_1 = int.TryParse(firstArray.Text, out arr1[index1]);
                if (!arr_1)
                {
                    MessageBox.Show("Please enter a valid Number");
                }
                else
                {
                    index1++;

                    listBox1.Items.Clear();
                    firstArray.Clear();
                    for (int i = 0; i != arr1.Length; i++)
                    {
                        listBox1.Items.Add(arr1[i]);
                    }
                    listBox1.Items.Add("-----------xxx--------------------");
                    firstArray.Focus();
                }
            }

            else
            {
                MessageBox.Show("Array Full");
                firstArray.Clear();
            }
        }
        // inserting values in 2st array
        private void arrValues2_Click(object sender, EventArgs e)
        {
            if (index2 < returnValue2)
            {
                bool arr_2 = int.TryParse(SecondArray.Text, out arr2[index2]);
                if (!arr_2)
                {
                    MessageBox.Show("Please enter a valid Number");
                }
                else
                {
                    index2++;

                    listBox2.Items.Clear();
                    SecondArray.Clear();
                    for (int i = 0; i != arr2.Length; i++)
                    {
                        listBox2.Items.Add(arr2[i]);
                    }
                    listBox2.Items.Add("-----------xxx--------------------");
                    SecondArray.Focus();
                }
            }

            else
            {
                MessageBox.Show("Array Full");
                SecondArray.Clear();
            }



        }

        // displaying functions in listbox 
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex == 0)
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Array Empty");
                listBox4.Items.Add("Array Full");
                listBox4.Items.Add("Array Current Size");
                listBox4.Items.Add("Array Sorted");
            }

            else if (listBox3.SelectedIndex == 1)
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Insert at specific location");
                listBox4.Items.Add("Insert at the end of Array");

            }
            else if (listBox3.SelectedIndex == 2)
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Delete from specific location");
                listBox4.Items.Add("Remove all elements");

            }

            else if (listBox3.SelectedIndex == 3)
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Linear Search");
                listBox4.Items.Add("Binary Search ");

            }

            else if (listBox3.SelectedIndex == 4)
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Merge Sort");

            }

            else if (listBox3.SelectedIndex == 5)
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Bubble Sort");
                listBox4.Items.Add("Insertion Sort");

            }

        }

        // button for executing functions.
        private void button3_Click(object sender, EventArgs e)
        {

            Array1 Array_1 = new Array1();
            Insert Insert_1 = new Insert();
            Delete Delete_1 = new Delete();
            Search Search_1 = new Search();
            SlowSort SlowSort_1 = new SlowSort();




            if (listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 0)
            {
                if (returnValue1 == 0)
                {
                    MessageBox.Show("Please create an Array first");
                }
                else
                {
                    bool value;
                    value = Array_1.ArrayEmpty(arr1);
                    if (!value)
                    {
                        MessageBox.Show("Array is not Empty");
                    }
                    else
                    {
                        MessageBox.Show("Array is Empty");
                    }
                }
            }

            else if (listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 1)
            {
                if (returnValue1 == 0)
                {
                    MessageBox.Show("Please create an Array first");
                }
                else
                {
                    bool value1;
                    value1 = Array_1.ArrayFull(arr1);
                    if (value1)
                    {
                        MessageBox.Show("Array is Full");
                    }
                    else
                    {
                        MessageBox.Show("Array is Not Full");
                    }
                }
            }

            else if (listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 2)
            {
                if (returnValue1 == 0)
                {
                    MessageBox.Show("Please create an Array first");
                }
                else
                {
                    int value2 = Array_1.ArrayCurrent(arr1);

                    MessageBox.Show("Currently Array has " + value2.ToString() + " values in it");
                }
            }

            else if (listBox3.SelectedIndex == 0 && listBox4.SelectedIndex == 3)
            {
                if (returnValue1 == 0)
                {
                    MessageBox.Show("Please create an Array first");
                }
                else
                {
                    int value3 = Array_1.ArraySorted(arr1);
                    if (value3 == 0)
                    {
                        MessageBox.Show("Array is not sorted");
                    }
                    else if (value3 == 1)
                    {
                        MessageBox.Show("Array is sorted in Ascending order");
                    }
                    else if (value3 == 2)
                    {
                        MessageBox.Show("Array is Sorted in Descending order");
                    }

                }
            }

            else if (listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 0)
            {
                if (returnValue1 == 0)
                {
                    MessageBox.Show("Please create an Array first");
                }
                else
                {

                    ThirdForm.ShowDialog();
                    int insertValue = ThirdForm.InsertIndex;
                    int insertLoc = ThirdForm.LocationIndex;
                    bool value4 = Array_1.ArrayFull(arr1);

                    if (value4 || arr1[returnValue1 - 1] > 0)
                    {
                        MessageBox.Show("To insert at a specific location, Your last index shoud be empty");
                    }
                    else
                    {
                        if (insertLoc == 0 || insertLoc > returnValue1)
                        {
                            MessageBox.Show("Invalid value Entered");
                        }

                        else
                        {

                            arr1 = Insert_1.shiftRight(arr1, insertLoc);
                            arr1[insertLoc - 1] = insertValue;
                            listBox1.Items.Clear();
                            for (int i = 0; i != arr1.Length; i++)
                            {
                                listBox1.Items.Add(arr1[i]);
                            }
                            listBox1.Items.Add("-----------xxx--------------------");
                            ThirdForm.InsertIndex = 0;
                            ThirdForm.LocationIndex = 0;
                        }
                    }
                }

            }

            else if (listBox3.SelectedIndex == 1 && listBox4.SelectedIndex == 1)
            {
                if (returnValue1 == 0)
                {
                    MessageBox.Show("Please create an Array first");
                }

                else
                {
                    bool value1 = Array_1.ArrayFull(arr1);
                    if (value1)
                    {
                        MessageBox.Show("Sorry array is full, you cannot insert any further value");
                    }
                    else
                    {

                        FourthForm.ShowDialog();
                        int value7 = FourthForm.ValueLast;

                        arr1[returnValue1 - 1] = value7;

                        listBox1.Items.Clear();
                        for (int i = 0; i != arr1.Length; i++)
                        {
                            listBox1.Items.Add(arr1[i]);
                        }
                        listBox1.Items.Add("-----------xxx--------------------");



                    }
                }

            }

            else if (listBox3.SelectedIndex == 2 && listBox4.SelectedIndex == 0)
            {
                if (returnValue1 == 0)
                {
                    MessageBox.Show("Please create an Array first");
                }

                else
                {
                    bool v = Array_1.ArrayEmpty(arr1);
                    if (v)
                    {
                        MessageBox.Show("cannot delete anything from an empty array");
                    }

                    else
                    {
                        Form4 FourthForm_1 = new Form4();

                        FourthForm_1.Label1 = "Select Index";
                        FourthForm_1.ShowDialog();
                        int value8 = FourthForm_1.ValueLast;


                        if (value8 == 0 || value8 > returnValue1 || value8 < 0)
                        {
                            MessageBox.Show("invalud value entered");
                        }

                        else
                        {

                            arr1 = Delete_1.shiftLeft(arr1, value8);

                            listBox1.Items.Clear();
                            for (int i = 0; i != arr1.Length; i++)
                            {
                                listBox1.Items.Add(arr1[i]);
                            }
                            listBox1.Items.Add("-----------xxx--------------------");
                        }
                    }
                }

            }

            else if (listBox3.SelectedIndex == 2 && listBox4.SelectedIndex == 1)
            {
                if (returnValue1 == 0)
                {
                    MessageBox.Show("Please create an Array first");
                }
                else
                {
                    arr1 = Delete_1.emptyArray(arr1);

                    listBox1.Items.Clear();
                    for (int i = 0; i != arr1.Length; i++)
                    {
                        listBox1.Items.Add(arr1[i]);
                    }
                    listBox1.Items.Add("-----------xxx--------------------");
                }
            }

            else if (listBox3.SelectedIndex == 3 && listBox4.SelectedIndex == 0)
            {
                if (returnValue1 == 0)
                {
                    MessageBox.Show("Please create an Array first");

                }

                else
                {
                    bool a = Array_1.ArrayEmpty(arr1);
                    if (a)
                    {
                        MessageBox.Show("Cannot search in an empty array");
                    }

                    else
                    {
                        Form4 FourthForm_2 = new Form4();
                        FourthForm_2.Label1 = "Insert the value ";
                        FourthForm_2.ShowDialog();
                        int value9 = FourthForm_2.ValueLast;
                        int num = Search_1.LinearSearch(arr1, value9);

                        if (num == -1)
                        {
                            MessageBox.Show(value9.ToString() + " is not present in current array");
                        }
                        else
                        {
                            num += 1;
                            MessageBox.Show(value9.ToString() + " is found at location " + num.ToString());
                        }
                    }

                }

            }

            else if (listBox3.SelectedIndex == 3 && listBox4.SelectedIndex == 1)
            {
                if (returnValue1 == 0)
                {
                    MessageBox.Show("Please create an Array first");

                }

                else
                {
                    bool a = Array_1.ArrayEmpty(arr1);
                    if (a)
                    {
                        MessageBox.Show("Cannot search in an empty array");
                    }

                    else
                    {
                        int value10 = Array_1.ArraySorted(arr1);

                        if (value10 == 0 || value10 == 2)
                        {
                            MessageBox.Show("Sorry! Your array must be sorted in ascending order for binary search");
                        }

                        else if (value10 == 1)
                        {
                            Form4 FourthForm_3 = new Form4();
                            FourthForm_3.Label1 = "Insert the value ";
                            FourthForm_3.ShowDialog();
                            int val = FourthForm_3.ValueLast;
                            int number = Search_1.BinarySearch(arr1, val);
                            if (number == -1)
                            {
                                MessageBox.Show(val.ToString() + " is not present in current array");
                            }
                            else
                            {
                                number += 1;
                                MessageBox.Show(val.ToString() + " is found at location " + number.ToString());
                            }
                        }

                    }

                }

            }


            else if (listBox3.SelectedIndex == 4 && listBox4.SelectedIndex == 0)
            {
                if (returnValue1 == 0)
                {
                    MessageBox.Show("Please create an Array first");
                }
                else
                {
                    int numb = Array_1.ArraySorted(arr1);

                    if (numb == 1)
                    {
                        MessageBox.Show("Array is already sorted");
                    }

                    else
                    {

                        MergeSort MergeSort_1 = new MergeSort();
                        MergeSort_1.SortMerge(arr1, 0, returnValue1 - 1);

                        listBox1.Items.Clear();
                        for (int i = 0; i != arr1.Length; i++)
                        {
                            listBox1.Items.Add(arr1[i]);
                        }
                        listBox1.Items.Add("-----------xxx--------------------");
                    }
                }


            }

            else if (listBox3.SelectedIndex == 5 && listBox4.SelectedIndex == 0)
            {
                if (returnValue1 == 0)
                {
                    MessageBox.Show("Please create an Array first");
                }
                else
                {
                    int numb = Array_1.ArraySorted(arr1);

                    if (numb == 1)
                    {
                        MessageBox.Show("Array is already sorted");
                    }
                    else
                    {
                        SlowSort_1.BubbleSort(arr1);
                        listBox1.Items.Clear();
                        for (int i = 0; i != arr1.Length; i++)
                        {
                            listBox1.Items.Add(arr1[i]);
                        }
                        listBox1.Items.Add("-----------xxx--------------------");
                    }
                }
            }

            else if (listBox3.SelectedIndex == 5 && listBox4.SelectedIndex == 1)
            {
                if (returnValue1 == 0)
                {
                    MessageBox.Show("Please create an Array first");
                }
                else
                {
                    int numb = Array_1.ArraySorted(arr1);

                    if (numb == 1)
                    {
                        MessageBox.Show("Array is already sorted");
                    }

                    else
                    {
                        SlowSort SlowSort_2 = new SlowSort();
                        SlowSort_2.BubbleSort(arr1);
                        listBox1.Items.Clear();
                        for (int i = 0; i != arr1.Length; i++)
                        {
                            listBox1.Items.Add(arr1[i]);
                        }
                        listBox1.Items.Add("-----------xxx--------------------");

                    }
                }


            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (returnValue2 == 0)
            {
                MessageBox.Show("Please create an Array first");
            }

            else
            {
                Array1 empty = new Array1();
                bool a = empty.ArrayEmpty(arr2);
                if (a)
                {
                    MessageBox.Show("Array is Empty");

                }
                else
                {
                    Array.Sort(arr2);
                    Array.Reverse(arr2);
                    listBox2.Items.Clear();
                    for (int i = 0; i != arr2.Length; i++)
                    {
                        listBox2.Items.Add(arr2[i]);
                    }
                    listBox2.Items.Add("-----------xxx--------------------");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (returnValue1 == 0 || returnValue2 == 0)
            {
                MessageBox.Show("Please create both Array first");
            }
            else
            {
                Array1 sorted = new Array1();
                Merge Merge_1 = new Merge();
                int val1 = sorted.ArraySorted(arr1);
                int val2 = sorted.ArraySorted(arr2);
                int sum = returnValue1 + returnValue2;
                if (val1 == 1 && val2 == 2)
                {
                    arr3 = new int[sum];
                    arr3 = Merge_1.MergeIn(arr1, arr2, arr3);


                    listBox5.Items.Clear();

                    for (int i = 0; i != arr3.Length; i++)
                    {
                        listBox5.Items.Add(arr3[i]);
                    }
                    listBox5.Items.Add("-----------xxx--------------------");

                }
                else
                {
                    MessageBox.Show("To Merge Array 1 must be in ascending order and Array 2 must be in descending");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {


                for (int i = 0; i != arr3.Length; i++)
                {
                    arr3[i] = 0;
                }

                listBox5.Items.Clear();

                for (int i = 0; i != arr3.Length; i++)
                {
                    listBox5.Items.Add(arr3[i]);
                }
                listBox5.Items.Add("-----------xxx--------------------");

            }
            catch 
            {
                MessageBox.Show("Error");
            }
            finally
            { }
        }
    }
}
