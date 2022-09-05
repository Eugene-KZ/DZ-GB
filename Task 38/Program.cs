// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



void RandomArray(int[] a){
	Random random = new Random();
	for(int i = 0; i < a.Length; i++) a[i] = random.Next(1, 100);
	Console.WriteLine(String.Join(", ", a));
}



int[] array = new int[10];
RandomArray(array);
int result = array.Max() - array.Min();
Console.WriteLine("Разница между максимальным и минимальным элементов массива равна: " + result);