using System.Security.Principal;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Create a array variable to storage the result that it will be return
        double[] result = new double[length];
        // Start a loop the increment the index while the multiple was adding
        for (int i = 0; i < length; i++)
        {
            // Add multiple according to the numeric sequence 
            result[i] = number * (i + 1);
        }

        // return the final result of the multiples function 
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // If the amount if bigger than the size of the list, we adjust it.
        amount = amount % data.Count;

        // We divide teh list in two parts
        List<int> lastPart = data.GetRange(data.Count - amount, amount);
        List<int> firstPart = data.GetRange(0, data.Count - amount);
        
        // We clean the list and then add the two part in rotated order
        data.Clear();
        data.AddRange(lastPart);
        data.AddRange(firstPart);
    }
}
