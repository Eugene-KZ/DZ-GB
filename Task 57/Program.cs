// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Пример. Есть набор данных:
// { 1, 9, 9, 0, 2, 8, 0, 9 }


// Частотный массив можно представить так:
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза


int[,] FillArray(int m, int n)
{
	int[,] array = new int[m, n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			array[i, j] = new Random().Next(0, 10);
		}
	}
	return array;
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}


void FindNumbers(int[,] array)
{
	var element = new List<int>();
	var count = new List<int>();
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			if (!element.Contains(array[i, j]))
			{
				element.Add(array[i, j]);
				count.Add(1);
			}
			else
			{
				for (int m = 0; m < element.Count; m++)
				{
					if (array[i, j] == element[m]) count[m] += 1;
				}
			}
		}
	}
	PrintList(element, count);
}

void PrintList(List<int> element, List<int> count)
{
	SortingList(element, count);

	for (int i = 0; i < element.Count; i++)
	{
		Console.WriteLine(element[i] + " встречается " + count[i] + " раз");
	}
}

void SortingList(List<int> element, List<int> count)
{
	int[] temp = new int[2];
	for (int i = 0; i < element.Count; i++)
	{
		for (int j = 0; j < element.Count - 1; j++)
		{
			if (element[j] > element[j + 1])
			{
				temp[0] = element[j];
				temp[1] = count[j];
				element[j] = element[j + 1];
				count[j] = count[j + 1];
				element[j + 1] = temp[0];
				count[j + 1] = temp[1];
			}
		}
	}
}


Console.WriteLine("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(m, n);
PrintArray(array);
Console.WriteLine();
FindNumbers(array);