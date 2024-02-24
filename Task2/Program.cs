int AckermannFunc(int m, int n)
    {
        if (m < 0 || n < 0) throw new ArgumentOutOfRangeException();
        if (m == 0) return n + 1;
        if (n == 0) return AckermannFunc(m - 1, 1);
        return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
    }

Console.WriteLine(AckermannFunc(3, 5));
Console.WriteLine(AckermannFunc(1, 2));
