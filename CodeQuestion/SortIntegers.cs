using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuestion
{
    public class SortIntegers 
    {
        public Dictionary<string, TimeSpan> sortTimes;
        public List<Task> sortTasks { get; private set; }
        public int[] Sort(int[] unsortedInput)
        {
            sortTimes = new Dictionary<string, TimeSpan>();
            sortTasks = new List<Task>();
            int[] sortedOutput = new int[0];

            sortTasks.Add(Task.Run(() =>
            {
                var bubbleSort = new BubbleSort();
                sortedOutput = bubbleSort.SortInts(unsortedInput);
                sortTimes.Add("BubbleSort", bubbleSort.sortTime);
            }));
            sortTasks.Add(Task.Run(() =>
            {
                var selectionSort = new SelectionSort();
                sortedOutput = selectionSort.SortInts(unsortedInput);
                sortTimes.Add("SelectionSort", selectionSort.sortTime);
            }));

            Task.WaitAll(sortTasks.ToArray());
            return sortedOutput;
        }
    }
}
