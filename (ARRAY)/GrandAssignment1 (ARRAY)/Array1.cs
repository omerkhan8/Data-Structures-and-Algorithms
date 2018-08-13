using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrandAssignment1__ARRAY_
{
    class Array1
    {
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

        public int ArrayCurrent(int[] num)
        {
            int count = 0;
            for (int i = 0; i != num.Length; i++)
            {
                if (num[i] > 0 || num[i] < 0)
                {
                    count++;


                }

            }

            return count;

        }

        public int ArraySorted(int[] num)
        {

            int count = 0;
            int i = 0;
            int count1 = 0;
            int j = 0;

            foreach (int val in num)
            {
                if (i == num.Length - 1)
                {
                    break;
                }

                else if (val <= num[i + 1])
                {
                    count++;

                }
                i++;
            }

            foreach (int val1 in num)
            {
                if (j == num.Length - 1)
                {
                    break;
                }
                else if (val1 >= num[j + 1])
                {
                    count1++;

                }
                j++;
            }
            if (count == num.Length - 1)
            {
                return 1;

            }

            else if (count1 == num.Length - 1)
            {
                return 2;
            }

            else
            {
                return 0;
            }



        }

    }

    class Insert
    {
        public int[] shiftRight(int[] num, int val)
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

            for (int i = count; i >= val - 1; i--)
            {
                num[count + 1] = num[count];

                count--;
            }

            return num;
            
        }

    }


    class Delete
    {
        public int[] shiftLeft(int[] num, int val1)
        {
            int number = val1 - 1;
            for (int i = val1 - 1; i != num.Length - 1; i++)
            {
                num[number] = num[number + 1];

                number++;

            }
            num[num.Length - 1] = 0;
            return num;
        }


        public int[] emptyArray(int[] num1)
        {
            for (int i = 0; i != num1.Length; i++)
            {
                num1[i] = 0;
            }

            return num1;


        }





    }


    class Search
    {

        public int LinearSearch(int[] num, int val)
        {

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == val)
                {
                    return i;
                }
            }


            return -1;

        }


        public int BinarySearch(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }

}
