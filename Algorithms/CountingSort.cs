namespace SortingAlgorithms.Algorithms;
public class CountingSort
{
    public static int[] Sort(int[] array)
    {
        int maxNumber = array.Max();
        int[] counts = new int[maxNumber + 1];
        int[] result = new int[array.Length];

        for (int i = 0; i < counts.Length; i++)
        {
            counts[i] = 0;
        }


        for (int i = 0; i < array.Length; i++)
        {
            counts[ array[i] ] += 1;
        }

        for (int i = 1; i < counts.Length; i++)
        {
            counts[i] = counts[i - 1] + counts[i];
        }


        for (int i = array.Length -1; i >=0 ; i--)
        {
            var originalValue = array[i];
            var index = counts[originalValue] - 1;
            result[index] = originalValue;
            counts[originalValue] -= 1;
        }

        return result;
    }
}
/*
 Strategy for counting sort

find max number
init new counts array with length of maximum number + 1
init that array to all zeros
init output array

loop
    count occurance of each number and store them in counts
loop
    modify count to store the occurance of the values

loop
    place values in correct position
    org value get value of array
    use org value  as index in count array to get value then decrement it by 1 call this index
    use index value as index of where to place original value
    esnure to decrement value in count // this is so when there are duplicates it won't place it in the same position


 
 */