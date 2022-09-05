// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2





void RandomArray(int[] a){
	Random random = new Random();
	for(int i = 0; i < a.Length; i++) a[i] = random.Next(100, 1000);
	Console.WriteLine(String.Join(", ", a));
}

int EvenNumber(int[] a){
	int count = 0;
	for(int i=0; i < a.Length; i++){
		if(a[i] % 2 == 0) count++;
	}
	return count;
}

int[] array = new int[10];
RandomArray(array);
Console.WriteLine(EvenNumber(array));