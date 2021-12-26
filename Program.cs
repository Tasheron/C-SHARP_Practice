int[] resizeArray(int[] array){
    int[] arrayNew = new int[array.Length];
    int i = 0;
    foreach(int element in array){
        if(element % 2 == 0){
            arrayNew[i] = element;
            i++;
        }
    }
    for (int j = i; j < arrayNew.Length; j++)
        arrayNew[j] = -10;
    return arrayNew;
}

void printArray(int[] array){
    foreach(int el in array)
        if(el > -10)
            Console.Write(el + " ");
    Console.WriteLine();
}

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
}

int[] arrayNew = resizeArray(array);

Console.WriteLine("Изначальный массив: ");
printArray(array);

Console.WriteLine("Массив четных чисел: ");
printArray(arrayNew);