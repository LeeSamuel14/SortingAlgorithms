namespace SortingAlgorithms.Algorithms;

public class BucketSort
{
    public static int[] Sort(int[] array)
    {
        int maxElement = array.Max();
        int arrayLength = array.Length;
        int indexDeterminer = maxElement / arrayLength;
        List<List<int>> buckets = new List<List<int>>();  
        
        for (int i = 0; i < arrayLength; i++)
        {
            buckets.Add(new List<int>());
        }

        List<int> result = new List<int>();
        int index;

        for(int i = 0; i < arrayLength; i++)
        {
            index = array[i] / indexDeterminer;
            if( index != arrayLength)
            {
                buckets[index].Add(array[i]);
            }
            else
            {
                buckets[arrayLength - 1].Add(array[i]);
            }
        }

        for(int i = 0; i < arrayLength; i++)
        {
           buckets[i].Sort();
        }

        for(int i = 0; i < arrayLength; i++)
        {
            for (int j = 0; j < buckets[i].Count; j++)
            {
                result.Add(buckets[i][j]);
            }
        }

        return result.ToArray();

    }
}