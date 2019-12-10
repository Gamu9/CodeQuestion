
/*
* This document is intented for the use of Microgaming only. It contains information that is priviledged and that is the intellectual property of Microgaming. 
* You may neither copy nor use it, nor disclose it to anyone else.
* If you have received this document in error, please notify us immediately. ©Microgaming All Rights Reserved
*/

using CodeQuestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunSortSoft
{
  public class Program
  {
    static void Main(string[] args)
    {

      int[] integerArray = new int[] { 2, 98, 7, 9, 3, 5, 4, 1, 3, 1, 6, 0, 2, 3, 78, 34, 56, 234, 87, 12, 45 };
      string[] stringArray = new string[] { "abc", "aa", "bc", "cb", "cc", "ar", "ef", "fe", "ft", "abcde", "abb" };

      IntegerQuestion.RunIntegerQuestion(integerArray.ToArray());
      Console.WriteLine();
      StringQuestion.RunStringQuestion(stringArray.ToArray());
      Console.WriteLine();     

      Console.WriteLine("Hit a key to exit...");
      Console.ReadLine();
    }

    


  }
}
