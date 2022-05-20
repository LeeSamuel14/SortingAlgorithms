// See https://aka.ms/new-console-template for more information
using SortingAlgorithms.Algorithms;

StartSorting();

void StartSorting()
{
    //MergeSortCallingFunction();
    //QuickSortCallingFunction();
    //BubbleSortCallingFunction();
    //SelectionSortCallingFunction();
    //InsertionSortCallingFunction();
    CountingSortCallingFunction();
}



static void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.WriteLine(item);
    }
}

static void MergeSortCallingFunction()
{
    int[] array = new int[1000000];
    int index = 0;
    for (int i = 1000000; i > 0; i--)
    {
        array[index] = i;
        index++;
    }
    var result = MergeSort.Sort(array);
    //PrintArray(result);
}

static void QuickSortCallingFunction()
{
    var array = new int[] { 1, 9, 8, 7, 6, 4, 3, 2, 5 };
    var result = QuickSort.Sort(array, 0, array.Length - 1);
    PrintArray(result);
}

static void BubbleSortCallingFunction()
{
    int[] array = new int[1000000];
    int index = 0;
    for (int i = 1000000; i > 0; i--)
    {
        array[index] = i;
        index++;
    }
    var result = BubbleSort.Sort(array);
    //PrintArray(result);
}

static void SelectionSortCallingFunction()
{
    var array = new int[] { 110, 7, 55555, 8, 45950, };
    var result = SelectionSort.Sort(array);
    PrintArray(result);
}

static void InsertionSortCallingFunction()
{
    var array = new int[] { 110, 7, 55555, 8, 45950, 10, 9, 8, 7, 6, 5 };
    var result = InsertionSort.Sort(array);
    PrintArray(result);
}

void CountingSortCallingFunction()
{
    var array = new int[] { 10, 9, 3, 2, 1, 0 };
    var result = CountingSort.Sort(array);
    PrintArray(result);
}



