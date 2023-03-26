//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//  которая покажет количество чётных чисел в массиве.
int[] resultArray = GetArray(8, 100, 1000);
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
    int count = 0;
        for (int i = 0; i < resultArray.Length ; i++)
            {
                if(resultArray[i] % 2 == 0)
                {
                  count++;  
                }
            
            }
            
            Console.WriteLine($"Количество четных чисел: {count}");
        


