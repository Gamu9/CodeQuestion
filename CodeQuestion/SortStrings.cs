using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuestion
{
    public class SortStrings 
    {
        public Dictionary<string, TimeSpan> sortTimes;
        public List<Task> sortTasks { get; private set; }
        public string[] Sort(string[] unsortedInput)
        {
            sortTimes = new Dictionary<string, TimeSpan>();
            sortTasks = new List<Task>();
            string[] sortedOutput = new string[0];

            sortTasks.Add(Task.Run(() =>
            {
                var bubbleSort = new BubbleSort();
                sortedOutput = bubbleSort.SortStrings(unsortedInput);
                sortTimes.Add("BubbleSort", bubbleSort.sortTime);
            }));
            sortTasks.Add(Task.Run(() =>
            {
                var selectionSort = new SelectionSort();
                sortedOutput = selectionSort.SortStrings(unsortedInput);
                sortTimes.Add("SelectionSort", selectionSort.sortTime);
            }));

            Task.WaitAll(sortTasks.ToArray());
            return sortedOutput;
        }
    }
}
