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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int[,] arr;
        int[,] arr1;
        int row;
        int col;
        int indexRow;
        int indexCol;
        int indexRow1;
        int indexCol1;


        private void button1_Click(object sender, EventArgs e)
        {
            indexCol = 0;
            indexRow = 0;
            indexCol1 = 0;
            indexRow1 = 0;
            int returnValue;
            bool r = int.TryParse(textBox1.Text, out row);
            bool c = int.TryParse(textBox2.Text, out col);
            if (!r || !c)
            {
                MessageBox.Show("Invalud value entered");
            }
            else
            {
                returnValue = ValueCheck(row, col);
                if (returnValue == 1)
                {


                    arr = new int[row, col];

                    CreateMatrix(row, col);

                    // PrintMatrix(row, col);

                }
            }

        }

        private int ValueCheck(int num1, int num2)
        {
            if (num1 > 10 || num2 > 10)
            {
                MessageBox.Show("Limit exceed your rows and col must be less than 11");
                return 0;
            }

            else if (num1 <= 0 || num2 <= 0)
            {
                MessageBox.Show("Your index shoud be greater than 0");
                return 0;
            }
            else
            {
                return 1;

            }
        }

        public void CreateMatrix(int num1, int num2)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            label6.Visible = false;

            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < num2; j++)
                {
                    Label lbl = new Label();
                    lbl.Font = new Font("Arial", 9, FontStyle.Bold);
                    lbl.Name = "lbl" + i + "" + j;
                    lbl.Text = ((i + 1) + "" + (j + 1));
                    lbl.Size = new Size(40, 40);
                    lbl.Location = new Point(j * 40, i * 40);
                    lbl.BorderStyle = BorderStyle.FixedSingle;
                    panel1.Controls.Add(lbl);


                }
            }
        }

        public void CreateMatrix1(int num1, int num2)
        {
            panel2.Controls.Clear();
            label6.Visible = true;
            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < num2; j++)
                {

                    Label lbl1 = new Label();
                    lbl1.Font = new Font("Arial", 9, FontStyle.Bold);
                    lbl1.Name = "lbl" + i + "" + j;
                    lbl1.Text = ((i + 1) + "" + (j + 1));
                    lbl1.Size = new Size(40, 40);
                    lbl1.Location = new Point(j * 40, i * 40);
                    lbl1.BorderStyle = BorderStyle.FixedSingle;
                    panel2.Controls.Add(lbl1);


                }
            }
        }
        public void PrintMatrix(int num1, int num2)
        {
            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < num2; j++)
                {
                    Label lbl = panel1.Controls.Find("lbl" + i + "" + j, true).FirstOrDefault() as Label;
                    lbl.Text = arr[i, j].ToString();

                }
            }
        }


        public void PrintMatrix1(int num1, int num2)
        {
            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < num2; j++)
                {
                    Label lbl1 = panel2.Controls.Find("lbl" + i + "" + j, true).FirstOrDefault() as Label;
                    lbl1.Text = arr1[i, j].ToString();

                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (row == 0 || col == 0)
            {
                MessageBox.Show("Please create a matrix first");
            }
            else
            {
                if (indexRow == row || indexCol == col)
                {
                    MessageBox.Show("Matrix Full");
                }
                else
                {
                    bool val = int.TryParse(textBox3.Text, out arr[indexRow, indexCol]);
                    if (!val)
                    {
                        MessageBox.Show("Please Enter a valid value");
                    }
                    else
                    {
                        indexCol++;
                        if (indexCol == col)
                        {
                            indexCol = 0;
                            indexRow++;
                        }
                        PrintMatrix(row, col);
                        textBox3.Clear();
                        textBox3.Focus();
                    }
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (row == 0 || col == 0)
            {
                MessageBox.Show("Please create a matrix first");
            }
            else
            {
                if (indexRow1 == row || indexCol1 == col)
                {
                    MessageBox.Show("Matrix Full");
                }
                else
                {
                    bool val1 = int.TryParse(textBox4.Text, out arr[indexRow1, indexCol1]);
                    if (!val1)
                    {
                        MessageBox.Show("Please Enter a valid value");
                    }
                    else
                    {
                        indexRow1++;
                        if (indexRow1 == row)
                        {
                            indexRow1 = 0;
                            indexCol1++;
                        }
                        PrintMatrix(row, col);
                        textBox4.Clear();
                        textBox4.Focus();
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Row #");
                listBox2.Items.Add("Col #");
            }

            else if (listBox1.SelectedIndex == 1)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Row wise");
                listBox2.Items.Add("Column wise");
                listBox2.Items.Add("Dynamic traversal");
            }

            else if (listBox1.SelectedIndex == 2)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Row @ the end");
                listBox2.Items.Add("Column @ the end ");
            }

            else if (listBox1.SelectedIndex == 3)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Row ");
                listBox2.Items.Add("Column ");
            }

            else if (listBox1.SelectedIndex == 4)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Rotate Right Rk");
                listBox2.Items.Add("Rotate Left Rk ");
                listBox2.Items.Add("Rotate Right All ");
                listBox2.Items.Add("Rotate Left All ");
            }

            else if (listBox1.SelectedIndex == 5)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Rotate Up Ck");
                listBox2.Items.Add("Rotate Down Ck ");
                listBox2.Items.Add("Rotate Up All ");
                listBox2.Items.Add("Rotate Down All ");
            }

            else if (listBox1.SelectedIndex == 6)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Face Right");
                listBox2.Items.Add("Face Left");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1 Array1 = new Class1();
            Retrieve Retrieve_1 = new Retrieve();
            Insert Insert1 = new Insert();
            Swap Swap1 = new Swap();
            RotateRow RotateRow1 = new RotateRow();
            RotateCol RotateCol1 = new RotateCol();
            FaceRotate FaceRotate1 = new FaceRotate();

            if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0)
            {
                if (row == 0 || col == 0)
                {
                    MessageBox.Show("Please create a matrix first");
                }
                else
                {
                    int empty = Array1.ArrayEmpty(arr);
                    if (empty == 1)
                    {
                        MessageBox.Show("Can not retrieve anything from an empty array");
                    }
                    else
                    {
                        Form3 ThirdForm_0 = new Form3();
                        ThirdForm_0.Lable = "Enter Row:";
                        ThirdForm_0.ShowDialog();
                        int value = ThirdForm_0.Val;
                        if (value > 0 && value <= row)
                        {
                            value -= 1;
                            arr1 = new int[row, col];
                            arr1 = Retrieve_1.SpecRow(arr, value);
                            CreateMatrix1(arr1.GetLength(0), arr1.GetLength(1));
                            PrintMatrix1(arr1.GetLength(0), arr1.GetLength(1));


                        }
                        else
                        {
                            MessageBox.Show("Invalid Row entered");
                        }
                    }
                }
            }

            else if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1)
            {
                if (row == 0 || col == 0)
                {
                    MessageBox.Show("Please create a matrix first");
                }
                else
                {
                    int empty = Array1.ArrayEmpty(arr);
                    if (empty == 1)
                    {
                        MessageBox.Show("Can not retrieve anything from an empty array");
                    }
                    else
                    {
                        Form3 ThirdForm_1 = new Form3();
                        ThirdForm_1.Lable = "Enter Col:";
                        ThirdForm_1.ShowDialog();
                        int value = ThirdForm_1.Val;
                        if (value > 0 && value <= col)
                        {
                            value -= 1;
                            arr1 = new int[row, col];
                            arr1 = Retrieve_1.SpecCol(arr, value);
                            CreateMatrix1(arr1.GetLength(0), arr1.GetLength(1));
                            PrintMatrix1(arr1.GetLength(0), arr1.GetLength(1));

                        }
                        else
                        {
                            MessageBox.Show("Invalid Col entered");
                        }
                    }
                }
            }

            else if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0)
            {
                if (row == 0 || col == 0)
                {
                    MessageBox.Show("Please create a matrix first");
                }
                else
                {
                    int empty = Array1.ArrayEmpty(arr);
                    if (empty == 1)
                    {
                        MessageBox.Show("Can not retrieve anything from an empty array");
                    }
                    else
                    {
                        arr1 = new int[row, col];
                        arr1 = Retrieve_1.RowWise(arr, arr1);
                        CreateMatrix1(row, col);
                        PrintMatrix1(row, col);
                    }

                }
            }

            else if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1)
            {
                if (row == 0 || col == 0)
                {
                    MessageBox.Show("Please create a matrix first");
                }
                else
                {
                    int empty = Array1.ArrayEmpty(arr);
                    if (empty == 1)
                    {
                        MessageBox.Show("Can not retrieve anything from an empty array");
                    }
                    else
                    {
                        arr1 = new int[row, col];
                        arr1 = Retrieve_1.ColWise(arr);
                        CreateMatrix1(arr1.GetLength(0), arr1.GetLength(1));
                        PrintMatrix1(arr1.GetLength(0), arr1.GetLength(1));
                    }
                }
            }

            else if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 2)
            {
                if (row == 0 || col == 0)
                {
                    MessageBox.Show("Please create a matrix first");
                }
                else
                {
                    int empty = Array1.ArrayEmpty(arr);
                    if (empty == 1)
                    {
                        MessageBox.Show("Can not retrieve anything from an empty array");
                    }

                    else
                    {
                        bool check = Array1.ArraySquare(arr);
                        if (!check)
                        {
                            MessageBox.Show("For Dynamic Traversal Matrix shoud be a Square matrix. ie: rows=cols");
                        }

                        else
                        {
                            arr1 = new int[row, col];
                            arr1 = Retrieve_1.DynamicTraversal(arr);
                            CreateMatrix1(arr1.GetLength(0), arr1.GetLength(1));
                            PrintMatrix1(arr1.GetLength(0), arr1.GetLength(1));
                        }
                    }
                }
            }

            else if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0)
            {
                if (row == 0 || col == 0)
                {
                    MessageBox.Show("Please create a matrix first");
                }
                else
                {
                    row++;
                    if (row <= 10)
                    {
                        textBox1.Text = row.ToString();
                        arr = Insert1.InsertRow(arr);
                        CreateMatrix(row, col);
                        PrintMatrix(row, col);
                        MessageBox.Show("Row has been added, now please insert values in it");
                    }
                    else
                    {
                        MessageBox.Show("Max Limit reached");
                    }
                }
            }


            else if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1)
            {
                if (row == 0 || col == 0)
                {
                    MessageBox.Show("Please create a matrix first");
                }
                else
                {
                    col++;
                    if (col <= 10)
                    {
                        textBox2.Text = col.ToString();
                        arr = Insert1.InsertCol(arr);
                        CreateMatrix(row, col);
                        PrintMatrix(row, col);
                        MessageBox.Show("Col has been added, now please insert values in it");
                    }
                    else
                    {
                        MessageBox.Show("Max Limit reached");
                    }
                }
            }

            else if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0)
            {
                if (row == 0 || col == 0)
                {
                    MessageBox.Show("Please create a matrix first");
                }
                else
                {
                    int empty = Array1.ArrayEmpty(arr);

                    if (empty == 1)
                    {
                        MessageBox.Show("Can not Swap anything from an empty array");
                    }

                    else
                    {
                        Form4 FourthForm = new Form4();
                        FourthForm.Lable1 = "Enter Row 1:";
                        FourthForm.Lable2 = "Enter Row 2:";
                        FourthForm.ShowDialog();
                        int firstRow = FourthForm.Val1;
                        int secondRow = FourthForm.Val2;

                        if ((firstRow > 0 && firstRow <= row) && (secondRow > 0 && secondRow <= row))
                        {
                            firstRow -= 1;
                            secondRow -= 1;
                            //   arr1 = new int[row, col];
                            arr = Swap1.SwapRow(arr, firstRow, secondRow);
                            CreateMatrix(row, col);
                            PrintMatrix(row, col);
                        }
                        else
                        {
                            MessageBox.Show("Invalid Row Or Col entered");
                        }
                    }
                }
            }

            else if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1)
            {
                if (row == 0 || col == 0)
                {
                    MessageBox.Show("Please create a matrix first");
                }
                else
                {
                    int empty = Array1.ArrayEmpty(arr);

                    if (empty == 1)
                    {
                        MessageBox.Show("Can not Swap anything from an empty array");
                    }
                    else
                    {
                        Form4 FourthForm1 = new Form4();
                        FourthForm1.Lable1 = "Enter Col 1:";
                        FourthForm1.Lable2 = "Enter Col 2:";
                        FourthForm1.ShowDialog();
                        int firstCol = FourthForm1.Val1;
                        int secondCol = FourthForm1.Val2;

                        if ((firstCol > 0 && firstCol <= col) && (secondCol > 0 && secondCol <= col))
                        {
                            firstCol -= 1;
                            secondCol -= 1;
                            //  arr1 = new int[row, col];
                            arr = Swap1.SwapCol(arr, firstCol, secondCol);
                            CreateMatrix(row, col);
                            PrintMatrix(row, col);
                        }
                        else
                        {
                            MessageBox.Show("Invalid Row Or Col entered");
                        }
                    }
                }
            }

            else if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 0)
            {
                if (row == 0 || col == 0)
                {
                    MessageBox.Show("Please create a matrix first");
                }
                else
                {
                    int empty = Array1.ArrayEmpty(arr);

                    if (empty == 1)
                    {
                        MessageBox.Show("Can not Rotate anything from an empty array");
                    }
                    else
                    {
                        Form3 ThirdForm_2 = new Form3();
                        ThirdForm_2.Lable = "Enter Row:";
                        ThirdForm_2.ShowDialog();
                        int rowNum = ThirdForm_2.Val;
                        if (rowNum > 0 && rowNum <= row)
                        {
                            rowNum -= 1;
                            arr = RotateRow1.RotateRight(arr, rowNum);
                            CreateMatrix(row, col);
                            PrintMatrix(row, col);
                        }

                        else
                        {
                            MessageBox.Show("Invalid Row entered");
                        }
                    }
                }
            }

            else if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 1)
            {
                if (row == 0 || col == 0)
                {
                    MessageBox.Show("Please create a matrix first");
                }
                else
                {
                    int empty = Array1.ArrayEmpty(arr);

                    if (empty == 1)
                    {
                        MessageBox.Show("Can not Rotate anything from an empty array");
                    }
                    else
                    {
                        Form3 ThirdForm_2 = new Form3();
                        ThirdForm_2.Lable = "Enter Row:";
                        ThirdForm_2.ShowDialog();
                        int rowNum = ThirdForm_2.Val;
                        if (rowNum > 0 && rowNum <= row)
                        {
                            rowNum -= 1;
                            arr = RotateRow1.RotateLeft(arr, rowNum);
                            CreateMatrix(row, col);
                            PrintMatrix(row, col);
                        }

                        else
                        {
                            MessageBox.Show("Invalid Row entered");
                        }
                    }
                }
            }

            else if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 2)
            {
                if (row == 0 || col == 0)
                {
                    MessageBox.Show("Please create a matrix first");
                }
                else
                {
                    int empty = Array1.ArrayEmpty(arr);

                    if (empty == 1)
                    {
                        MessageBox.Show("Can not Rotate anything from an empty array");
                    }
                    else
                    {
                        arr = RotateRow1.RotateRightAll(arr);
                        CreateMatrix(row, col);
                        PrintMatrix(row, col);
                    }
                }
            }

            else if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 3)
            {
                if (row == 0 || col == 0)
                {
                    MessageBox.Show("Please create a matrix first");
                }
                else
                {
                    int empty = Array1.ArrayEmpty(arr);

                    if (empty == 1)
                    {
                        MessageBox.Show("Can not Rotate anything from an empty array");
                    }

                    else
                    {
                        arr = RotateRow1.RotateLeftAll(arr);
                        CreateMatrix(row, col);
                        PrintMatrix(row, col);

                    }

                }
            }



            else if (listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 0)
            {
                if (row == 0 || col == 0)
                {
                    MessageBox.Show("Please create a matrix first");
                }
                else
                {
                    int empty = Array1.ArrayEmpty(arr);

                    if (empty == 1)
                    {
                        MessageBox.Show("Can not Rotate anything from an empty array");
                    }
                    else
                    {
                        Form3 ThirdForm_3 = new Form3();
                        ThirdForm_3.Lable = "Enter Col:";
                        ThirdForm_3.ShowDialog();
                        int ColNum = ThirdForm_3.Val;
                        if (ColNum > 0 && ColNum <= col)
                        {
                            ColNum -= 1;
                            arr = RotateCol1.RotateUp(arr, ColNum);
                            CreateMatrix(row, col);
                            PrintMatrix(row, col);

                        }

                        else
                        {
                            MessageBox.Show("Invalid Column entered");
                        }
                    }
                }

            }


            else if (listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 1)
            {
                if (row == 0 || col == 0)
                {
                    MessageBox.Show("Please create a matrix first");
                }
                else
                {
                    int empty = Array1.ArrayEmpty(arr);

                    if (empty == 1)
                    {
                        MessageBox.Show("Can not Rotate anything from an empty array");
                    }
                    else
                    {
                        Form3 ThirdForm_3 = new Form3();
                        ThirdForm_3.Lable = "Enter Col:";
                        ThirdForm_3.ShowDialog();
                        int ColNum = ThirdForm_3.Val;
                        if (ColNum > 0 && ColNum <= col)
                        {
                            ColNum -= 1;
                            arr = RotateCol1.RotateDown(arr, ColNum);
                            CreateMatrix(row, col);
                            PrintMatrix(row, col);

                        }

                        else
                        {
                            MessageBox.Show("Invalid Column entered");
                        }
                    }
                }
            }

            else if (listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 2)
            {
                if (row == 0 || col == 0)
                {
                    MessageBox.Show("Please create a matrix first");
                }
                else
                {
                    int empty = Array1.ArrayEmpty(arr);

                    if (empty == 1)
                    {
                        MessageBox.Show("Can not Rotate anything from an empty array");
                    }

                    else
                    {
                        arr = RotateCol1.RotateUpAll(arr);
                        CreateMatrix(row, col);
                        PrintMatrix(row, col);

                    }
                }
            }

            else if (listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 3)
            {
                if (row == 0 || col == 0)
                {
                    MessageBox.Show("Please create a matrix first");
                }
                else
                {
                    int empty = Array1.ArrayEmpty(arr);

                    if (empty == 1)
                    {
                        MessageBox.Show("Can not Rotate anything from an empty array");
                    }

                    else
                    {

                        arr = RotateCol1.RotateDownAll(arr);
                        CreateMatrix(row, col);
                        PrintMatrix(row, col);
                    }
                }
            }

            else if (listBox1.SelectedIndex == 6 && listBox2.SelectedIndex == 0)
            {
                if (row == 0 || col == 0)
                {
                    MessageBox.Show("Please create a matrix first");
                }
                else
                {
                    int empty = Array1.ArrayEmpty(arr);

                    if (empty == 1)
                    {
                        MessageBox.Show("Can not Rotate anything from an empty array");
                    }
                    else
                    {
                        bool check = Array1.ArraySquare(arr);
                        if (!check)
                        {
                            MessageBox.Show("For Face Rotation Matrix shoud be a Square matrix. ie: rows=cols");
                        }

                        else
                        {

                            arr = FaceRotate1.FaceRight(arr);
                            CreateMatrix(row, col);
                            PrintMatrix(row, col);
                        }
                    }
                }
            }

            else if (listBox1.SelectedIndex == 6 && listBox2.SelectedIndex == 1)
            {
                if (row == 0 || col == 0)
                {
                    MessageBox.Show("Please create a matrix first");
                }
                else
                {
                    int empty = Array1.ArrayEmpty(arr);

                    if (empty == 1)
                    {
                        MessageBox.Show("Can not Rotate anything from an empty array");
                    }
                    else
                    {
                        bool check = Array1.ArraySquare(arr);
                        if (!check)
                        {
                            MessageBox.Show("For Face Rotation Matrix shoud be a Square matrix. ie: rows=cols");
                        }

                        else
                        {
                            arr = FaceRotate1.FaceLeft(arr);
                            CreateMatrix(row, col);
                            PrintMatrix(row, col);

                        }
                    }
                }
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {

            if (row == 0 || col == 0)
            {
                MessageBox.Show("Please create a matrix first");
            }
            else
            {

                Form5 FormFive = new Form5();
                FormFive.ShowDialog();
                int rowNum = FormFive.Value1;
                int colNum = FormFive.Value2;
                int value = FormFive.Value3;

                if ((rowNum > 0 && rowNum <= row) && (colNum > 0 && colNum <= col))
                {
                    rowNum -= 1;
                    colNum -= 1;

                    arr[rowNum, colNum] = value;
                    PrintMatrix(row, col);
                }
                else
                {
                    MessageBox.Show("Invalid row or column selected");
                }

            }
        }
    }
}
