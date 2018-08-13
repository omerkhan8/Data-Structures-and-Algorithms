using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrandAssignment1__ARRAY_
{
    class Sorting
    {
    }

    class MergeSort
    {

         public void MainMerge(int[] numbers, int left, int mid, int right)
        {

            int[] temp = new int[100];

            int i, eol, num, pos;



            eol = (mid - 1);

            pos = left;

            num = (right - left + 1);



            while ((left <= eol) && (mid <= right))
            {

                if (numbers[left] <= numbers[mid])

                    temp[pos++] = numbers[left++];

                else

                    temp[pos++] = numbers[mid++];

            }



            while (left <= eol)

                temp[pos++] = numbers[left++];



            while (mid <= right)

                temp[pos++] = numbers[mid++];



            for (i = 0; i < num; i++)
            {

                numbers[right] = temp[right];

                right--;

            }

        }



        public void SortMerge(int[] numbers, int left, int right)
        {

            int mid;



            if (right > left)
            {

                mid = (right + left) / 2;

                SortMerge(numbers, left, mid);

                SortMerge(numbers, (mid + 1), right);



                MainMerge(numbers, left, (mid + 1), right);

            }

        }
    }

    class SlowSort
    {
        public void BubbleSort(int[] num)
        {
            int temp = 0;

            for (int write = 0; write < num.Length; write++)
            {
                for (int sort = 0; sort < num.Length - 1; sort++)
                {
                    if (num[sort] > num[sort + 1])
                    {
                        temp = num[sort + 1];
                        num[sort + 1] = num[sort];
                        num[sort] = temp;
                    }
                }
            }
        }
    }

    class Merge
    {
        public int[] MergeIn(int[] num1, int[] num2, int[] num3)
        {
            int temp = 0;
            int i = 0;
            int j = num2.Length-1;
            int count = 0;
            while (temp < num3.Length)
            {
                if (num1[i] > num2[j])
                {
                    num3[count] = num2[j];
                    j--;
                    count++;

                    if (j < 0)
                    {
                        for (int k = i; k < num1.Length; k++)
                        {
                            num3[count] = num1[k];

                            count++;
                        }
                        break;
                    }

                }
                else
                {
                    num3[count] = num1[i];
                    i++;
                    count++;
                    if (i == num1.Length)
                    {
                        for (int k = j; k >= 0; k--)
                        {
                            num3[count] = num2[k];

                            count++;
                        }
                        break;
                    }
                }
                temp++;
            }

            return num3;
        }
    
    }
}
