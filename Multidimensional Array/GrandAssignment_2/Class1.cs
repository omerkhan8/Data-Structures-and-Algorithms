using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrandAssignment_2
{
    class Class1
    {
        public int ArrayEmpty(int[,] num)
        {

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    if (num[i, j] > 0 || num[i, j] < 0)
                    {

                        return 0;
                    }

                }
            }
            return 1;
        }

        public bool ArraySquare(int[,] num)
        {
            if (num.GetLength(0) == num.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }


    class Retrieve
    {

        public int[,] SpecRow(int[,] num, int val)
        {
            int[,] num1 = new int[1, num.GetLength(1)];

            for (int j = 0; j < num.GetLength(1); j++)
            {
                num1[0, j] = num[val, j];
            }
            return num1;
        }


        public int[,] SpecCol(int[,] num, int val)
        {
            int[,] num1 = new int[num.GetLength(0), 1];

            for (int i = 0; i < num.GetLength(0); i++)
            {
                num1[i, 0] = num[i, val];
            }
            return num1;
        }


        public int[,] RowWise(int[,] num, int[,] num1)
        {
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    num1[i, j] = num[i, j];
                }
            }
            return num1;
        }


        public int[,] ColWise(int[,] num)
        {
            int[,] num1 = new int[num.GetLength(1), num.GetLength(0)];
            int count = 0;
            int j = 0;
            int max = num.GetLength(0) * num.GetLength(1);

            for (int i = 0; count < max; i++)
            {
                num1[j, i] = num[i, j];
                count++;
                if (i == (num.GetLength(0) - 1))
                {
                    j++;
                    i = -1;
                }
            }
            return num1;
        }


        public int[,] DynamicTraversal(int[,] num)
        {
            int[,] num1 = new int[num.GetLength(0), num.GetLength(1)];
            int temp = num.GetLength(1) - 1;
            int count = 0;
            int max = num.GetLength(0) * num.GetLength(1);
            int i = 0;
            int j = 0;
            // int a = 0;
            // int b = 0;

            while (count < max)
            {

                num1[i, j] = num[i, j];
                //  b++;
                i++;
                j++;
                count++;

                //if (b == num1.GetLength(1))
                //{
                //    b = 0;
                //    a++;
                //    if (a == num1.GetLength(0))
                //    {
                //        break;
                //    }

                // }

                if (j == num.GetLength(1))
                {
                    i = 0;
                    j -= temp;
                    temp--;
                }

                if (i == 0 && j == num.GetLength(1))
                {
                    break;
                }

            }
            return num1;


        }

    }

    class Insert
    {
        public int[,] InsertRow(int[,] num)
        {
            int[,] NewArray = new int[(num.GetLength(0) + 1), num.GetLength(1)];
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    NewArray[i, j] = num[i, j];
                }
            }
            return NewArray;
        }

        public int[,] InsertCol(int[,] num)
        {
            int[,] NewArray = new int[num.GetLength(0), (num.GetLength(1) + 1)];

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    NewArray[i, j] = num[i, j];
                }
            }
            return NewArray;
        }
    }

    class Swap
    {
        public int[,] SwapRow(int[,] num, int val1, int val2)
        {
            int[,] num1 = new int[num.GetLength(0), num.GetLength(1)];

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    num1[i, j] = num[i, j];
                }
            }


            for (int j = 0; j < num.GetLength(1); j++)
            {
                num1[val1, j] = num[val2, j];
                num1[val2, j] = num[val1, j];
            }
            return num1;
        }


        public int[,] SwapCol(int[,] num, int val1, int val2)
        {
            int[,] num1 = new int[num.GetLength(0), num.GetLength(1)];

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    num1[i, j] = num[i, j];
                }
            }


            for (int i = 0; i < num.GetLength(0); i++)
            {
                num1[i, val1] = num[i, val2];
                num1[i, val2] = num[i, val1];
            }
            return num1;
        }
    }


    class RotateRow
    {
        public int[,] RotateRight(int[,] num, int val)
        {
            int[,] num1 = new int[num.GetLength(0), num.GetLength(1)];

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    num1[i, j] = num[i, j];
                }
            }

            for (int j = num.GetLength(1) - 2; j >= 0; j--)
            {
                num1[val, j + 1] = num[val, j];
                if (j == 0)
                {
                    break;
                }
            }
            num1[val, 0] = num[val, num.GetLength(1) - 1];

            return num1;
        }

        public int[,] RotateLeft(int[,] num, int val)
        {
            int[,] num1 = new int[num.GetLength(0), num.GetLength(1)];

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    num1[i, j] = num[i, j];
                }
            }


            for (int j = 0; j < num.GetLength(1); j++)
            {
                num1[val, j] = num[val, j + 1];
                if (j == num.GetLength(1) - 2)
                {
                    break;
                }
            }

            num1[val, num1.GetLength(1) - 1] = num[val, 0];

            return num1;
        }

        public int[,] RotateRightAll(int[,] num)
        {
            int[,] num1 = new int[num.GetLength(0), num.GetLength(1)];

            for (int x = 0; x < num.GetLength(0); x++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    num1[x, j] = num[x, j];
                }
            }
            int i = 0;

            for (int j = num.GetLength(1) - 2; j >= 0; j--)
            {
                num1[i, j + 1] = num[i, j];
                if (j == 0)
                {
                    i++;
                    j = num.GetLength(1) - 1;
                }

                if (i == num.GetLength(0))
                {
                    break;
                }
            }

            for (i = 0; i < num.GetLength(0); i++)
            {
                num1[i, 0] = num[i, num.GetLength(1) - 1];
            }

            return num1;

        }


        public int[,] RotateLeftAll(int[,] num)
        {
            int[,] num1 = new int[num.GetLength(0), num.GetLength(1)];

            for (int x = 0; x < num.GetLength(0); x++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    num1[x, j] = num[x, j];
                }
            }

            int i = 0;
            for (int j = 0; j < num.GetLength(1); j++)
            {
                num1[i, j] = num[i, j + 1];
                if (j == num.GetLength(1) - 2)
                {
                    i++;
                    j = -1;
                }

                if (i == num.GetLength(0))
                {
                    break;
                }
            }

            for (int b = 0; b < num1.GetLength(0); b++)
            {
                num1[b, num1.GetLength(1) - 1] = num[b, 0];
            }
            return num1;
        }
    }


    class RotateCol
    {

        public int[,] RotateUp(int[,] num, int val)
        {
            int[,] num1 = new int[num.GetLength(0), num.GetLength(1)];

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    num1[i, j] = num[i, j];
                }
            }

            for (int i = 0; i < num.GetLength(0); i++)
            {
                num1[i, val] = num[i+1, val];
                if (i == num.GetLength(0) - 2)
                {
                    break;
                }
            }
            num1[num1.GetLength(0)-1, val] = num[0, val];

            return num1;
        }


        public int[,] RotateDown(int[,] num, int val)
        {
            int[,] num1 = new int[num.GetLength(0), num.GetLength(1)];

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    num1[i, j] = num[i, j];
                }
            }

            for (int i = num.GetLength(0) - 2; i >= 0; i--)
            {
                num1[i + 1, val] = num[i, val];

                if (i == 0)
                {
                    break;
                }
            }
            num1[0, val] = num[num.GetLength(0) - 1, val];

            return num1;
        }

        public int[,] RotateUpAll(int[,] num)
        {
            int[,] num1 = new int[num.GetLength(0), num.GetLength(1)];

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int k = 0; k < num.GetLength(1); k++)
                {
                    num1[i, k] = num[i, k];
                }
            }

            int j = 0;


            for (int i = 0; i < num.GetLength(0); i++)
            {
                num1[i, j] = num[i + 1, j];

                if (i == num.GetLength(0) - 2)
                {
                    j++;
                    i = -1;
                }

                if (j == num.GetLength(1))
                {
                    break;
                }
            }

            for (int a = 0; a < num.GetLength(1); a++)
            {
                num1[num1.GetLength(0) - 1, a] = num[0, a];
            }

            return num1;

        }


        public int[,] RotateDownAll(int[,] num)
        {
            int[,] num1 = new int[num.GetLength(0), num.GetLength(1)];

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int k = 0; k < num.GetLength(1); k++)
                {
                    num1[i, k] = num[i, k];
                }
            }

            int j = 0;

            for (int i = num.GetLength(0)-2; i >= 0; i--)
            {
                num1[i + 1, j] = num[i, j];
                if (i == 0)
                {
                    j++;
                    i = num.GetLength(0) - 1;
                }
                if (j == num.GetLength(1))
                {
                    break;
                }
            }

            for (int a = 0; a < num.GetLength(1); a++)
            {
                num1[0, a] = num[num.GetLength(0) - 1, a];
            }

            return num1;
        }
    }


    class FaceRotate
    {
        public int[,] FaceRight(int[,] num)
        {
            int[,] num1 = new int[num.GetLength(0), num.GetLength(1)];

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    num1[i, j] = num[i, j];
                }
            }

            int a = num.GetLength(0) - 1;
            int b = 0;

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    num1[i, j] = num[a, b];
                    a--;
                    if (a == -1)
                    {
                        b++;
                        a = num.GetLength(0) - 1;
                    }
                    if (b == num.GetLength(1))
                    {
                        break;
                    }
                }
            }

            return num1;
           
        }

        public int[,] FaceLeft(int[,] num)
        {
            int[,] num1 = new int[num.GetLength(0), num.GetLength(1)];

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    num1[i, j] = num[i, j];
                }
            }

            int a = 0;
            int b = num.GetLength(1) - 1;

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    num1[i, j] = num[a, b];
                    a++;

                    if (a == num.GetLength(0))
                    {
                        a = 0;
                        b -= 1;
                    }

                    if (b == -1)
                    {
                        break;
                    }
                  
                }
            }

            return num1;
        }
    }
}
