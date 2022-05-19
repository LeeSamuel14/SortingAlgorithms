namespace SortingAlgorithms.Algorithms;
public class SelectionSort
{
    public static int[] Sort(int[] array)
    {
        var minimumIndexPostion = 0;
        for (int i = 0; i < array.Length; i++)
        {
            minimumIndexPostion = i;

            for (int j = i + 1 ; j < array.Length; j++)
            {
                if(array[j] < array[minimumIndexPostion])
                {
                    minimumIndexPostion = j;
                }
            }

            var temp = array[i];
            array[i] = array[minimumIndexPostion];
            array[minimumIndexPostion] = temp;
        }

        return array;
    }
}

/*
 Selection Sort startegy

KEEPS TRACK OF MINIMUM INDEX POSITION

Selection sort sort lowest from the front.
It keep track of the postion of the lowest index. If a value is lower than the lowest it swaps that value.

It uses two for loops because it needs to look at every number in the array and compare it to every other number

loop i
set minIndex
    loop j
        if(number is less than minimum)
            set new minimum
    swap value i with new lowest minIndex
 
 */