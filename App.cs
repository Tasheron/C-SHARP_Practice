class App {
    public static void Demo(){
        int[] array = new int[10];

        ArrayMethods.FillArray(ref array);

        int[] newArray = ArrayMethods.ResizeArray(array);

        Console.WriteLine("Изначальный массив: ");
        ArrayMethods.PrintArray(array);

        Console.WriteLine("Массив четных чисел: ");
        ArrayMethods.PrintArray(newArray);
    }
}