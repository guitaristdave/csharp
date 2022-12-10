




// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
using learn;

int[] nums = func.getRandomArray(10, 0, 51);
int[] newnums = new int[10];

Console.WriteLine($"Старый массив: [ {String.Join(",", nums)} ]");

for (int i = 0; i < nums.Length; i++)
{
    newnums[i] = nums[i];
}

Console.WriteLine($"Новый массив: [ {String.Join(",", newnums)} ]");