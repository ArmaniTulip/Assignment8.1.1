
namespace Quicksort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = { 8,2,4,7,1,3,9,6,5  };//array of intergers


            //call quicksort with argument that includes the array, with the beginning and end 
            quicksort(array, 0, array.Length - 1);


            //print array
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }


        }
        //recursive quicksort function
        //takes the array, start index and end index as parameters
        private static void quicksort(int[] array, int start, int end)
        {
            if (end <= start) return; //base case if the array has no elements it is already sorted
            
            int pivot = partition(array, start, end); //partition the array and get the pivot index

            quicksort(array, start, pivot - 1); //recursive application to left side

            quicksort(array, pivot + 1, end);//recursive application to right side
        }




        // Partition function to rearrange the elements in the array
        // Takes the array, start index, and end index as parameters
        // Returns the index of the pivot element after partitioning
        private static int partition(int[] array, int start, int end)
        {
            
            int pivot = array[end];// Choose the last element as the pivot

            int i = start - 1; // Initialize the index for the smaller element

            for (int j = start; j <= end - 1;j++) // Loop through the array from start to end-1
            {
                if (array[j] < pivot)// If the current element is less than the pivot
                {
                    i++;//swap current element of the array with the element at the smaller index


                    // Swap the current element with the element at the smaller index
                    int temp1 = array[i];
                    array[i] = array[j];
                    array[j] = temp1;
                }
            }
            // Place the pivot element in the correct position
            // Swap the pivot element with the element at the index i+1
            i++;
            int temp2 = array[i];
            array[i] = array[end];
            array[end] = temp2;


            // Return the index of the pivot element
            return i;
        }
       
        
    }
}
