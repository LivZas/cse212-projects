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

    
        // Step 1: We need to create an array with length
        double[] result = new double[length];

        // Step 2: We need to create a loop with for to calculate each multiple of number
        for (int i = 0; i < length; i++) {
            // We need to populate the array with multiples
            result[i] = number * (i + 1);
        }

        // Step 3: We need to return the array with the numbers calculated

        return result; // replace this return statement with your own
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
            // Step 1: Verify that the list isn't empty and the amount is valid
    if (data.Count == 0 || amount <= 0 || amount > data.Count)
    {
        return;
    }

    // Step 2: If the amount is larger than the size of the list, reduce it
    amount = amount % data.Count;

    // Step 3: Split the list into two parts
    var part1 = data.GetRange(data.Count - amount, amount);
    var part2 = data.GetRange(0, data.Count - amount);

    // Step 4: Combine the parts in the correct order
    data.Clear();
    data.AddRange(part1);
    data.AddRange(part2);
}

        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }


// W01 Code: Dynamic Arrays 

public static class ArraysAssignment
{
    /// <summary>
    /// Generates an array containing a sequence of multiples of a given number.
    /// The sequence starts with the given number and continues for the specified count.
    /// For example, MultiplesOf(3, 5) returns {3, 6, 9, 12, 15}.
    /// </summary>

    // TODO Problem 1 Start
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: We need to create an array with the size length
        double[] result = new double[length];

        // Step 2: We create a loop to calculate and keep the multiples
        for (int i = 0; i < length; i++)  
        {
            result[i] = number * (i + 1);
        }

        // Step 3: Return the array
        return result;
    }
}

public static class ListProblem
{
    /// <summary>
    /// Rotate the 'data' to the right by the specified 'amount'. For example, if the data is
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and the amount is 5, the list after the function runs should be
    /// List<int>{5, 6, 7, 8, 9, 1, 2, 3, 4}. If the data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and the amount is 3, 
    /// the list after the function runs should be List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}. The value of 'amount' will be
    /// in the range of 1 to data.Count, inclusive.
    ///
    /// This function modifies the existing 'data' list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Verify that the list isn't empty and the amount is valid
        if (data.Count == 0 || amount <= 0)
        {
            return;
        }

        // Step 2: Reduce the amount if it's larger than the list size
        amount %= data.Count;
        if (amount == 0) return;

        // Step 3: Split the list into two parts
        List<int> part1 = data.GetRange(data.Count - amount, amount);
        List<int> part2 = data.GetRange(0, data.Count - amount);

        // Step 4: Clear the list and combine the parts in the correct order
        data.Clear();
        data.AddRange(part1);
        data.AddRange(part2);
    }
}
