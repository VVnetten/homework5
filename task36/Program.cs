// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetSum(int [] arr)
{
    int sum = 0;
    for(int i=0; i<arr.Length; i++)
    {
        if (i%2 != 0)
        {
            sum = arr[i]+ sum;
        }

    }
    return sum;
}

int [] GetArray()
{
    int [] array = new int [4];
    for(int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(100);
    }

return array;
}


int [] arr = GetArray();
int sum = GetSum(arr);
Console.WriteLine($" сумма элементов массива [{String.Join(",", arr)}], стоящих на нечётных позициях равнв {sum}");