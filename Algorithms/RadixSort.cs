namespace SortingAlgorithms.Algorithms;
public class RadixSort
{
    public static int[] CountingSort(int[] array, int digitPosition)
    {
        var output = new int[array.Length];
        var count = new int[10] { 0, 0, 0, 0, 0, 0, 0 , 0, 0, 0};

        //get occurences for each number
        for (int i = 0; i < array.Length; i++)
        {
            int index = array[i] / digitPosition;
            count[index % 10] += 1;
        }

        for (int i = 1; i < 10; i++)
        {
            count[i] += count[i - 1];
        }

        int indexName = array.Length - 1;

        while(indexName >= 0)
        {
            int index = array[indexName] / digitPosition;
            //confusing line below, counting sort similar
            output[count[index % 10] - 1] = array[indexName];
            count[index % 10] -= 1;
            indexName -= 1;
        }

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = output[i];
        }

        return output;
    }

    public static int[] Sort(int[] array)
    {
        var maxElement = array.Max();
        int digitPosition = 1;
        var result = new int[array.Length];

        while (maxElement/digitPosition > 0)
        {
            result = CountingSort(array, digitPosition);
            digitPosition *= 10;
        }

        return result;

    }
}
