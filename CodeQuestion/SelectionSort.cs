
/*
* This document is intented for the use of Microgaming only. It contains information that is priviledged and that is the intellectual property of Microgaming. 
* You may neither copy nor use it, nor disclose it to anyone else.
* If you have received this document in error, please notify us immediately. ©Microgaming All Rights Reserved
*/

using System;
using System.Diagnostics;

namespace CodeQuestion
{
    public class SelectionSort
    {
        public  TimeSpan sortTime;
        public int[] SortInts(int[] data)
        {
            var timer = new StopWatch().GetStopwatch();

            int n = data.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (data[j] < data[min_idx])
                    {
                        min_idx = j;
                    }
                }

                int temp = data[min_idx];
                data[min_idx] = data[i];
                data[i] = temp;
            }

            sortTime = new StopWatch().StopTimer(timer);
            return data;
        }

        public string[] SortStrings(string[] data)
        {
            var timer = new StopWatch().GetStopwatch();

            int n = data.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (data[j].CompareTo(data[min_idx]) < 0)
                    {
                        min_idx = j;
                    }
                }

                string temp = data[min_idx];
                data[min_idx] = data[i];
                data[i] = temp;
            }

            sortTime = new StopWatch().StopTimer(timer);
            return data;
        }


    }
}

