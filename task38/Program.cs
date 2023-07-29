// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double GetDif(double [] arr)
{
    double diff = 0;
    double max = arr [0];
    double min = arr [0]; 
    for( int i = 0; i<arr.Length; i++)
    {
        
        if  (max < arr [i])
        {
            max = arr [i];
        }
        if  (min > arr [i])
        {
            min = arr [i];
        }
      
    }
    
    diff = max - min; 
    return diff;

}

double [] GetArray()
{
   double [] array = new double [4];
    for(int i=0; i<array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(1000))/100;
    }
return array;
}


double [] arr = GetArray();
double difference = GetDif(arr);
// Console.WriteLine($"[{String.Join(", " , arr)}]");
Console.WriteLine($" сразницу между максимальным и минимальным элементов массива [{String.Join(", ", arr)}] равна {difference}");