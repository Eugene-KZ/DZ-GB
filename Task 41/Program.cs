// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3




int[] Read()
{
	Console.WriteLine("Введите колличество элементов в массиве: ");
	int M = Convert.ToInt32(Console.ReadLine());
	int[] array = new int[M];
	for (int i = 0; i < M; i++)
	{
		Console.WriteLine("Введите " + (i + 1) + "й элемент массива: ");
		array[i] = Convert.ToInt32(Console.ReadLine());
	}
	return array;

}

int Calck(int[] array){
	int count = 0;
	for (int i = 0; i < array.Length; i++){
		if(array[i] > 0) count++;
	}
	return count;
}

void Print(int count){
	Console.WriteLine("Колличество элементов в массиве больше 0: " + count);
}

Print(Calck(Read()));