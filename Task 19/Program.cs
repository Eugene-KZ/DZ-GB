// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

string Palindrome(string number){
	int size = number.Length;
	int i = 0;
	int LastIndex = size - 1;
	string result = "0";
	if(size == 5){
		while(i < size/2){
		if(number[i] == number[LastIndex - i]){
			result = "Да, число палиндром.";
			i++;
		}
		else{
			result = "Нет, число не палиндром.";
			break;
		}
	}
	}
	else{
		result = "Число не пятизначное.";
	}

	return result;
}

Console.WriteLine("Введите пятизначное число: ");
string number = Convert.ToString(Console.ReadLine());
Console.WriteLine(Palindrome(number));
