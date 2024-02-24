
int[] numbers = [2,5,43,56,4,3,2,1];
int size = numbers.Length -1;

void MassiveDigitsPrint(int [] numbers, int  size )
{
    if(size < 1)
    {
        System.Console.Write(numbers[size]);
        System.Console.WriteLine();
        return;
    }
    if (size < numbers.Length)
    {
        System.Console.Write(numbers[size]+ ",");
        MassiveDigitsPrint(numbers,size-1);
    }
    
}

MassiveDigitsPrint(numbers, size);


