// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


//Вариант через строку.
/*

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string StNumber = Convert.ToString(number);
if(StNumber.Length > 2){
	Console.WriteLine("Третья цифра числа " + number + " будет: " + StNumber[2]);
}
else{
	Console.WriteLine("Третьей цифры нет.");
}

*/
// Вариант через формулу
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99){
	int LongNumber = (int)Math.Log10(number)+1;
	int ThirdNum = (number % Convert.ToInt32(Math.Pow(10 , LongNumber - 2))) / Convert.ToInt32(Math.Pow(10 , LongNumber - 3));
	Console.WriteLine("Третья цифра числа " + number + " будет: " + ThirdNum);
}
else{
	Console.WriteLine("Третьей цифры нет.");
}