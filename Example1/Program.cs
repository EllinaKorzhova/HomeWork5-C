/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int [] InitArray(int length){
    int[]array = new int[length];
    Random rnd = new Random();
    for(int i = 0; i < length; i++){
        
        array[i] = rnd.Next(100,1000);

    }
    return array;
}

void PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++){
        
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetEvenNumber (int[] arr){
    int count = 0;
    for (int i = 0; i < arr.Length; i++){

        if (arr[i] % 2 == 0)
        {
        count++;
        }

    }
    return count;
}

int[] arr = InitArray(4);
PrintArray(arr);
int evennumbers = GetEvenNumber(arr);
Console.WriteLine($"Количество четных чисел в массиве: {evennumbers}");