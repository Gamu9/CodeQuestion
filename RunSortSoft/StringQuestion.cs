using CodeQuestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunSortSoft
{
    public class StringQuestion
    {

        public static void RunStringQuestion(string[] stringArray)
        {
            var sortStringQuestion = new SortStrings();
            var result = sortStringQuestion.Sort(stringArray);
            Console.WriteLine("Question Result");
            foreach (var sortTime in sortStringQuestion.sortTimes)
            {
                Console.WriteLine("Sort Type : " + sortTime.Key + ", Time : " + sortTime.Value.TotalMilliseconds + "ms");
            }
            Console.Write("Result : ");
            foreach (string val in result)
            {
                Console.Write(val.ToString() + ",");
            }
            Console.WriteLine();
        }
    }
}
