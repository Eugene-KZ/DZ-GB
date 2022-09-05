// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0




void RandomArray(int[] a){
	Random random = new Random();
	for(int i = 0; i < a.Length; i++) a[i] = random.Next(1, 100);
	Console.WriteLine(String.Join(", ", a));
}

int Summ(int[] a){
	int summ = 0;
	for(int i = 1; i < a.Length; i += 2){
		summ += a[i];
	}
	return summ;
}



int[] array = new int[10];
RandomArray(array);
Console.WriteLine("Сумму элементов, стоящих на нечётных позициях массива равна: " + Summ(array));