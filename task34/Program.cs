// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int GetPositive(int [] arr)
{   
    int count = 0;
    for( int i = 0; i< arr.Length; i++)
    {
        if (arr [i] %2 == 0)
            {
                count = count +1;
            }

    }

return count;


}



int [] GetArray() {

    int [] array = new int [10];
    for(int i = 0; i< array.Length; i++)
    {
        array [i] = new Random().Next(99,1000);

    }
    return array;
}

int [] arr = GetArray();
int num = GetPositive(arr);
Console.WriteLine($"в массиве[{String.Join(",", arr)}] {num} четных чисел" );