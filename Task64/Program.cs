class Program
{
    static void Main()
    {
        int low = 1, high = 5;
        Console.WriteLine($"low = {low}; high = {high} -> \"{GetEvenNumbers(low, high)}\"");
        
        low = 4; high = 8;
        Console.WriteLine($"low = {low}; high = {high} -> \"{GetEvenNumbers(low, high)}\"");
    }

    static string GetEvenNumbers(int low, int high)
    {
        if (low > high)
            return "";
        else if (low % 2 == 0)
            return low + (low < high - 1 ? ", " : "") + GetEvenNumbers(low + 2, high);
        else
            return GetEvenNumbers(low + 1, high);
    }
}