
/*
* This document is intented for the use of Microgaming only. It contains information that is priviledged and that is the intellectual property of Microgaming. 
* You may neither copy nor use it, nor disclose it to anyone else.
* If you have received this document in error, please notify us immediately. ©Microgaming All Rights Reserved
*/

using System;
using System.Diagnostics;

namespace CodeQuestion
{
  public class BubbleSort  
  {

    public TimeSpan sortTime;
    public int[] SortInts(int[] data) 
    {
      var timer = new StopWatch().GetStopwatch();

      int n = data.Length; 
      for (int i = 0; i < n - 1; i++)
      {
        for (int j = 0; j < n - i - 1; j++)
        {
          if (data[j] > data[j + 1])
          {
            // swap temp and arr[i] 
            int temp = data[j];
            data[j] = data[j + 1];
            data[j + 1] = temp;
          }
        }
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
        for (int j = 0; j < n - i - 1; j++)
        {
          if (data[j].CompareTo(data[j + 1]) > 1)
          {
            // swap temp and arr[i] 
            string temp = data[j];
            data[j] = data[j + 1];
            data[j + 1] = temp;
          }
        }
      }

      sortTime = new StopWatch().StopTimer(timer);
      return data;
    }   

  }
}
