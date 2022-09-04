//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void FillArray(int[]array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100,1000);
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
    
Console.Write(arr[count-1]+"] ->");
}

void EvenNums(int[]Nums,int size)
{
    int EvenNums=0;
       for (int i = 0; i < size; i++)
    {
        EvenNums+=Nums[i]%2==0?1:0;
    }
    Console.WriteLine(" в данном массиве количество четных чисел равно "+ EvenNums );
}
int length= new Random().Next(1,10);
int[]Array = new int [length];
FillArray(Array);
PrintArray(Array);
EvenNums(Array,length);
