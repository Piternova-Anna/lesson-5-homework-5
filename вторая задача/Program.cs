//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void FillArray(int[]array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0,100);
    }    
}
void PrintArray(int[]arr)
{ 
    Console.Write("[");
    int count = arr.Length;
        for (int position = 0; position < count-1 ; position++)
    {
       Console.Write(arr[position]+",");
    }
    
Console.Write(arr[count-1]+"]");
}

void SumNumsOddIndex(int[]Nums, int Length)
{
    int SumNumsOddIndex=0;
    for (int i = 1; i < Length; i=i+2)
    {
        SumNumsOddIndex=SumNumsOddIndex+Nums[i];
    }
    Console.WriteLine("сумма элементов, стоящих на нечётных позициях в данном массиве равна "+SumNumsOddIndex);
}




int length= new Random().Next(1,10);
int[]Array = new int [length];
FillArray(Array);
PrintArray(Array);
SumNumsOddIndex(Array, length);

