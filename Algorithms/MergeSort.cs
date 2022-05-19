namespace SortingAlgorithms.Algorithms;

public class MergeSort
{
    public static int[] Sort(int[] mainArray)
    {
        if (mainArray.Length > 1) //we need this value because this is our base case for recusrsion. That's why when explaining we use boxes above 1 because at length 1 nothing happens
        {
            int middleIndex = mainArray.Length / 2;
            var leftArray = new List<int>(mainArray).GetRange(0, middleIndex).ToArray();
            var rightArray = new List<int>(mainArray).GetRange(middleIndex, mainArray.Length - middleIndex).ToArray();

            Sort(leftArray);
            Sort(rightArray);

            //Initialise tracker variables to ensure array indexing stays within bounds
            int mainArrayIndexTracker = 0;
            int leftArrayIndexTracker = 0;
            int rightArrayIndexTracker = 0;

            //does comparision of elements and checks our index is within bounds
            while (leftArrayIndexTracker < leftArray.Length && rightArrayIndexTracker < rightArray.Length)
            {
                if (leftArray[leftArrayIndexTracker] < rightArray[rightArrayIndexTracker])
                {
                    mainArray[mainArrayIndexTracker] = leftArray[leftArrayIndexTracker];
                    leftArrayIndexTracker++;
                }
                else
                {
                    mainArray[mainArrayIndexTracker] = rightArray[rightArrayIndexTracker];
                    rightArrayIndexTracker++;
                }
                mainArrayIndexTracker++;
            }

            //consumes left overs in left sub array
            while (leftArrayIndexTracker < leftArray.Length)
            {
                mainArray[mainArrayIndexTracker] = leftArray[leftArrayIndexTracker];
                leftArrayIndexTracker++;
                mainArrayIndexTracker++;
            }

            //consumes left overs for right sub array
            while (rightArrayIndexTracker < rightArray.Length)
            {
                mainArray[mainArrayIndexTracker] = rightArray[rightArrayIndexTracker];
                rightArrayIndexTracker++;
                mainArrayIndexTracker++;
            }
        }
        return mainArray;
    }
}

/*
 strategy for merge sort

//if len(array) > 1
    then
    divide array into sub arrays
    a left array
    a right array
    
    call the sort function recursively for LEFT
    call the sort function recursively for RIGHT

    init our tracker variables
    
    have three while loops
    1. while loop will do the actual comparison to see in in order
    2. second while loop will be there for left overs of the LEFT array
    3. third while loop will be for left overs of RIGHT array
 */