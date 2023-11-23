class Program
{
    static void Main()
    {
        int M = 1, N = 15;
        Console.WriteLine($"M = {M}; N = {N} -> {GetSum(M, N)}");

        M = 4; N = 8;
        Console.WriteLine($"M = {M}; N = {N} -> {GetSum(M, N)}");
    }

    static int GetSum(int m, int n)
    {
        if (m > n)
            return 0;
        else
            return m + GetSum(m + 1, n);
    }
}