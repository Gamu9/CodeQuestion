using CodeQuestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunSortSoft
{
    public class IntegerQuestion
    {
        public static void RunIntegerQuestion(int[] integerArray)
        {
            var sortIntegerQuestion = new SortIntegers();
            var result = sortIntegerQuestion.Sort(integerArray);
            Console.WriteLine("Question Result");
            foreach (var sortTime in sortIntegerQuestion.sortTimes)
            {
                Console.WriteLine("Sort Type : " + sortTime.Key + ", Time : " + sortTime.Value.TotalMilliseconds + "ms");
            }
            Console.Write("Result : ");
            foreach (int val in result)
            {
                Console.Write(val.ToString() + ",");
            }
            Console.WriteLine();
        }
    }
}
