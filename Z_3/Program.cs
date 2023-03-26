// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int Prompt (string message)
 {
     System.Console.Write(message);
     int result = Convert.ToInt32(Console.ReadLine());
     return result;
 }
 int size = Prompt("Введите длинну массива: ");
double[] numbers = new double[size];
double[] resultArray = GetArray(numbers);
Console.WriteLine($"Массив: [ {String.Join("; ", resultArray)} ]");
    
    double[] GetArray (double[] numbers)
     {
        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().NextDouble())*100 ;
        }
        return numbers;
    } 
    double max = numbers[0]; 
    double min = numbers[0]; 
    for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}
double diff = max - min; 
Console.WriteLine($"Длинна мвссива {numbers.Length}. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {diff}");
