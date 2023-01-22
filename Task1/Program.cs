// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Введите число: ");
int inputNumber = int.Parse(Console.ReadLine());  // введенное число 
int inputNumberToCut = Math.Abs(inputNumber);  // это число будем отрезать по десятку справа / 
int invertNumber = 0;               // это число которое будет наращиваться из вырезанного   - и в итоге получим перевернутое ввёденное число

while (inputNumberToCut % 10 > 0) //  пока в вырезаемом числе есть хоть какие-то числа перед зяпятой
{
    invertNumber = invertNumber * 10 + inputNumberToCut % 10;   // по сути двигаем число влево умножая на 10,  освобождая место для прибавления новой цифры и добавляем её
    inputNumberToCut = Convert.ToInt32(inputNumberToCut) / 10;  // отрезаем число, так как последнее ууже прибавили к инвертируемому 
}

if (invertNumber == Math.Abs(inputNumber))  // сравниваем полученные числа
    System.Console.WriteLine($"Вы ввели число {inputNumber} - это полиндром ");
else System.Console.WriteLine($"Вы ввели число {inputNumber} - это НЕ полиндром ");
