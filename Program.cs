using System;

class Program {
    static void Main() {
        int[] arr = {12, 11, 13, 5, 6, 7};
        HeapSort.Sort(arr);
        Console.WriteLine("Отсортированный массив: ");
        for (int i = 0; i < arr.Length; i++) {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
