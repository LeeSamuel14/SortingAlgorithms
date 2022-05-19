namespace SortingAlgorithms;
public class QuickSort
{
    private static int partition(int[] array, int subArrayIndexStart, int subArrayIndexEnd)
    {
        int smallerGroupTrackingIndex = subArrayIndexStart - 1;
        int pivot = array[subArrayIndexEnd];
        var temp = 0;


        //loop over array and ensure smaller elements are on the left side of array, according to the pivot
        for (int i = subArrayIndexStart; i < subArrayIndexEnd; i++) 
        {
            if (array[i] <= pivot)
            {
                smallerGroupTrackingIndex++;

                temp = array[smallerGroupTrackingIndex];
                array[smallerGroupTrackingIndex] = array[i];
                array[i] = temp;
            }

        }

        //ensure pivot sits in the correct spot. 
        //smaller elements to the left of the pivot
        //greater elements the the right of the pivot
        temp = array[smallerGroupTrackingIndex + 1];
        array[smallerGroupTrackingIndex + 1] = array[subArrayIndexEnd];
        array[subArrayIndexEnd] = temp;

        return smallerGroupTrackingIndex + 1;
    }

    public static int[] Sort(int[] array, int subArrayIndexStart, int subArrayIndexEnd)
    {
        if (array.Length == 1)
            return array;

        if(subArrayIndexStart < subArrayIndexEnd)
        {
            var indexOfPivot = partition(array, subArrayIndexStart, subArrayIndexEnd);

            //sort left side of array
            Sort(array, subArrayIndexStart, indexOfPivot - 1);

            //sort right side of array
            Sort(array, indexOfPivot + 1, subArrayIndexEnd);
        }

        return array;

    }
}

/*
 My strategy for Quick sort
 - Divide and Conquer
 - Pivot to divide smaller items on the left, bigger items on the right
 - Recursive function. Base case.
 - tracking index 

partition()
{
    init trackIndex of smaller group x
    set pivot x

    forloop over array
    check if item in array is smaller than the pivot
        if is smaller
            increment trackIndex
            swap values

    makes sure that pivot is in the correct position
    return tracking index
}

sort
{
    if len of array ==1 
        return array

    if subarrayindexStart < subarrayIndexEnd ***
        this if statement is important because this is when the left side is already sorted
        get partition p
        sort left side of array with p
        sort right side of array p
}
 
 */
