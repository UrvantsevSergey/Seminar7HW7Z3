using System;

class Program
{
  public static void Main 
  (string[] args)
  {
    int[] arr = new int[10];
    FillArray(arr);
    PrintArray(arr); 
    Console.WriteLine();
    ReversArray(arr, 0);


    int[] FillArray (int[] array)
    {
      for (int i = 0; i < array.Length; i++)
      {
        array[i] = new Random().Next(-10,10);
      }
      return array;
    }

    void PrintArray (int[] array)
    {
      foreach (int item in array)
      {
        Console.Write($"{item}\t");
      }
    }

    void ReversArray (int[] array, int j)
    {
      if (j >= array.Length)
      {
       return;
      }
      ReversArray(array, j + 1);
      Console.Write($"{array[j]}\t");
    }
  }
}