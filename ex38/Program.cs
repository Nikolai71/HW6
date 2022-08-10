// Задача 38: . Найдите разницу между максимальным и минимальным элементов массива.
// Задать размер (int) массива с клавиатуры
// [3 7 22 2 78] -> 76Задайте с клавиатуры массив вещественных (double) чисел

Console.WriteLine($"Задайте с клавиатуры массив вещественных (double) чисел:\n");
int N = Convert.ToInt32(Console.ReadLine());
double[] arrayRealNumbers = new double[N];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(10, 100);
    Console.Write(arrayRealNumbers[i] + " ");
  }
double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];
  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
       else 
    {
      minNumber = arrayRealNumbers[i];
    }
  }
  double decision = maxNumber - minNumber;
  Console.WriteLine();
  Console.WriteLine($" Разница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");