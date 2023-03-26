// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] resultArray = GetArray(23, -1000, 1000);
 Console.WriteLine($"Массив: [ {String.Join("; ", resultArray)} ]");
    
     int[] GetArray (int size, int min, int max)
      {
          int[] array = new int[size];
         for (int i = 0; i < size; i++)
         {
             array[i] = new Random().Next(min, max + 1);
         }
        return array;
     } 
    int sum = 0;

for (int z = 0; z < resultArray.Length; z+=2)
     sum = sum + resultArray[z];

     Console.WriteLine($"Длинна массива {resultArray.Length}, сумма элементов cтоящих на нечётных позициях = {sum}");   

 