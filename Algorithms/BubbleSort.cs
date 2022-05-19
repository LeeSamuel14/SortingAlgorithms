namespace SortingAlgorithms.Algorithms;
public class BubbleSort
{
    public static int[] Sort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if(array[j] > array[j+1])
                {
                    var temp = array[j+1];
                     array[j+1] = array[j];
                    array[j] = temp;
                }
            }
        }

        return array;
    }
}

/*
Strategy for bubble sort

It uses two for loops because it needs to look at every number in the array and compare it to every other number

second for loop stops at array.Length - i -1.

loop i from 0 to array.length
    loop j from 0 to arrLen - i - 1
    if(value is greater)
      swap values

*/
