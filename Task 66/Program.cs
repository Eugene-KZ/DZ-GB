// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNum(string a)
{
	Console.WriteLine(a);
	return Convert.ToInt32(Console.ReadLine());
}

int SummNaturalNumbers(int start, int finish)
{
	if (start == finish) return finish;
	int summ = start;
	start++;
	return summ + SummNaturalNumbers(start, finish);
}


int numStart = InputNum("Enter M: ");
int numFinish = InputNum("Enter N: ");
Console.WriteLine(SummNaturalNumbers(numStart, numFinish));
