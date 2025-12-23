static int GetLCSBottomUp(string s1, string s2)
{
    int m = s1.Length;
    int n = s2.Length;
    int[,] dp = new int[m + 1, n + 1];

    // nested loops
    for (int i = 1; i <= m; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            //  (Match)
            if (s1[i - 1] == s2[j - 1])
            {
            	dp[i, j] = 1 + dp[i - 1, j - 1];
            }
            //  (Mismatch)
            else
            {
                dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }
        }
    }
    return dp[m, n];
}
using System.Diagnostics;

static void Main(string[] args)
{
    Console.WriteLine("--- LCS Bottom-Up with Empirical Analysis ---");
    Console.Write("Enter first string: ");
    string s1 = Console.ReadLine();
    Console.Write("Enter second string: ");
    string s2 = Console.ReadLine();
    Stopwatch sw = new Stopwatch();
    sw.Start();
    int result = GetLCSBottomUp(s1, s2);
 sw.Stop();
    Console.WriteLine("\n========================================");
    Console.WriteLine($"Result: Length of LCS is {result}");
    Console.WriteLine($"Time Elapsed (Empirical): {sw.Elapsed.TotalMilliseconds} ms");
    Console.WriteLine($"Ticks: {sw.ElapsedTicks}");
    Console.WriteLine("========================================");
}






