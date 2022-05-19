// See https://aka.ms/new-console-template for more information
using SortingAlgorithms;

QuickSortCallingFunction();

static void MergeSortCallingFunction()
{
    Console.WriteLine("Hello, World!");

    int[] array = new int[100];
    int index = 0;
    for (int i = 100; i > 0; i--)
    {
        array[index] = i;
        index++;
    }

    var done = "done";

    var result = MergeSort.Sort(array);

    Console.WriteLine(result);
}

static void QuickSortCallingFunction()
{
    var array = new int[] { 1, 9, 8, 7, 6, 4, 3, 2, 5 };
    var array2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

    var result = QuickSort.Sort(array, 0, array.Length - 1);

    foreach (var item in result)
    {
        Console.WriteLine(item);
    }
}
