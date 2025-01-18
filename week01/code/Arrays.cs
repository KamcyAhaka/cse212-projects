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

        // Step 2: Initialize an array to store the multiples
        double[] multiples = new double[length];

        // Step 3: Loop through and generate the multiples
        for (int i = 0; i < length; i++)
        {
            // Calculate the multiple by multiplying the starting number with the current index + 1
            multiples[i] = number * (i + 1);
        }

        // Step 4: Return the array containing the multiples
        return multiples; // replace this return statement with your own
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

        int count = data.Count;
        amount = amount % count; // Ensure we don't rotate more than the size of the list

        // Step 3: Split the list into two parts: the last 'amount' elements and the first 'count - amount' elements
        List<int> part1 = data.GetRange(count - amount, amount); // Last 'amount' elements
        List<int> part2 = data.GetRange(0, count - amount); // First 'count - amount' elements

        // Step 4: Clear the original list and add the two parts in the new order
        data.Clear(); // Clear the original list
        data.AddRange(part1); // Add the last 'amount' elements
        data.AddRange(part2); // Add the first 'count - amount' elements
    }
}
