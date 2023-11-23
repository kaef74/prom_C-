class Program
{
    static void Main()
    {
        int low = 2, high = 3;
        Console.WriteLine($"low = {low}; high = {high} -> A(low, high) = {Ackermann(low, high)}");

        low = 3; high = 2;
        Console.WriteLine($"low = {low}; high = {high} -> A(low, high) = {Ackermann(low, high)}");
    }

    static int Ackermann(int low, int high)
    {
        if (low == 0)
            return high + 1;
        else if (high == 0)
            return Ackermann(low - 1, 1);
        else
            return Ackermann(low - 1, Ackermann(low, high - 1));
    }
}