/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/


int [] InitArray(int length){
    int[]array = new int[length];
    Random rnd = new Random();
    for(int i = 0; i < length; i++){
        
        array[i] = rnd.Next(-1000,1000);

    }
    return array;
}

void PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++){
        
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetSum (int[] arr){
    int sum = 0;
    for (int i = 0; i < arr.Length; i++){

        if (i % 2 != 0)
        {
         sum += arr [i];
        }

    }
    return sum;
}


int[] arr = InitArray(4);
PrintArray(arr);
int sumOfNoEvenNumbers = GetSum(arr);
Console.WriteLine($"Сумма чисел стоящих на нечетных позициях: {sumOfNoEvenNumbers}");