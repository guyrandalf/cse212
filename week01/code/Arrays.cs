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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        
        // Step 1: Understanding the input and output.
        // Input: 'number' (double), 'length' (int > 0).
        // Output: An array of doubles containing 'length' multiples of 'number'.
        
        // Step 2: Prepare an array to hold the multiples.
        // Array to store the result.
        double[] multiples = new double[length];

        // Step 4: Populating the array with multiples of the number.
        // We calculate multiples by multiplying 'number' with each index (1-based).
        for (int i = 0; i < length; i++)
        {
            // The (i + 1)-th multiple of `number`.
            multiples[i] = number * (i + 1);
        }

        // Step 5: Return the array of multiples.
        return multiples;
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        
        // Step 1: Understand the input and output.
        // Input: 'data' (List<int>) to be rotated, 'amount' (int) specifies the positions to rotate.
        // Output: The function modifies the original 'data' list to be rotated to the right by 'amount'.

        // Step 2: Identify where to split the list.
        // The last 'amount' elements need to move to the front. Calculate the starting index of the rotation.
        int splitIndex = data.Count - amount;

        // Step 3: Use slicing to divide the list into two parts.
        // Part 1: The last 'amount' elements (slice starting at splitIndex).
        List<int> lastPart = data.GetRange(splitIndex, amount);
        
        // Part 2: The remaining elements before the split (slice from index 0 to splitIndex).
        List<int> firstPart = data.GetRange(0, splitIndex);

        // Step 4: Clear the original list and rebuild it in the rotated order.
        data.Clear(); // Remove all elements from the original list.
        data.AddRange(lastPart); // Add the rotated last part to the front.
        data.AddRange(firstPart); // Append the remaining elements to the end.
    }
}
