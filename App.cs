class App {
    public static void Demo(){
        int[] array = new int[10];

        ArrayMethods.fillArray(ref array);

        int[] newArray = ArrayMethods.resizeArray(array);

        Console.WriteLine("Изначальный массив: ");
        ArrayMethods.printArray(array);

        Console.WriteLine("Массив четных чисел: ");
        ArrayMethods.printArray(newArray);
    }
}