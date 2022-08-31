// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int Summ(string a){
	int summ = 0;
	for(int i = 0; i < a.Length; i++){
		int num = Convert.ToInt32(a[i].ToString());
		summ += num;
	}
	return summ;
}

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
Console.WriteLine("Сумма цифр числа равна: " + Summ(number));