using System;
using System.Diagnostics; // Library to calculate execution time

class Algorithm1
{
    // The main recursive function to find the length of LCS
    // This function explores all possible subsequences to find the longest one.
    static int GetLCSLengthNaive(string s1, string s2, int m, int n)
    {
        // Base Case: If either string is empty (length is 0), the LCS length is 0.
        if (m == 0 || n == 0)
            return 0;

        // If the last characters of both strings match:
        // We include this character in the LCS count (add 1) 
        // and recursively check the remaining parts of the strings.
        if (s1[m - 1] == s2[n - 1])
            return 1 + GetLCSLengthNaive(s1, s2, m - 1, n - 1);

        // If the characters do not match, we have two options:
        // 1. Exclude the last character of the first string (s1) and recurse.
        // 2. Exclude the last character of the second string (s2) and recurse.
        // We take the maximum result of these two branches.
        else
            return Math.Max(GetLCSLengthNaive(s1, s2, m, n - 1),
                            GetLCSLengthNaive(s1, s2, m - 1, n));
    }

    static void Main()
    {
        // Example Input
        // Note: Keep inputs short for this algorithm because O(2^n) is very slow.
        string text1 = "AGGTAB";
        string text2 = "GXTXAYB";

        Console.WriteLine("--- Algorithm 1: Naive Recursive Approach ---");
        
        // Start the stopwatch to measure execution time
        Stopwatch sw = new Stopwatch();
        sw.Start();

        // Call the recursive function
        int result = GetLCSLengthNaive(text1, text2, text1.Length, text2.Length);

        // Stop the stopwatch
        sw.Stop();

        // Output the results
        Console.WriteLine($"LCS Length: {result}");
        Console.WriteLine($"Time Taken: {sw.Elapsed.TotalMilliseconds} ms");
    }
}
