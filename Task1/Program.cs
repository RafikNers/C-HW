
void RangeOfDigit( int m, int n)
{   
    if (m == n)
    {
        System.Console.WriteLine(m);
        return;
    }
    System.Console.Write(m + ",");
    RangeOfDigit(m+1, n);
}


RangeOfDigit(1,5);