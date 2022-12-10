/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/


double[] InitArray(int length){
    double[] array = new double[length];
    Random rnd = new Random();
    for(int i = 0; i < length; i++){
        
        array[i] = Math.Round(rnd.NextDouble() * 100,1);

    }
    return array;
}

void PrintArray(double[] array){
    for (int i = 0; i < array.Length; i++){
        
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

(double, double) DiffMaxAndMin(double[] array){

double max = array[0];
double min = array[0];

   for (int i = 0; i < array.Length; i++){

        if (array[i] > max) 
        {
         max = array [i];
        } else {
         min = array [i];
        }

    }
    return (max, min);
}

double[] arr = InitArray(4);
PrintArray(arr);
(double maxNumber, double minNumber) = DiffMaxAndMin(arr);
Console.WriteLine($"Разница максимального и минимального значения: {maxNumber} - {minNumber} = {maxNumber - minNumber}");