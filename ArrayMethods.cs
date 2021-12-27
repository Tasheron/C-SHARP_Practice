class ArrayMethods {
    public static void FillArray(ref int[] array){
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(-9, 10);
        }
    }
    public static int[] ResizeArray(int[] array){
        int[] newArray = new int[0];
        int i = 0;
        foreach(int element in array){
            if(element % 2 == 0){
                Array.Resize(ref newArray, newArray.Length + 1);
                newArray[i] = element;
                i++;
            }
        }
        return newArray;
    }
    public static void PrintArray(int[] array){
        foreach(int el in array)
            Console.Write(el + " ");
        Console.WriteLine();
    }
}