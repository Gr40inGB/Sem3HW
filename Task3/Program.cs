// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

//System.Console.SetWindowSize(50, 50);
//System.Console.CursorTop();
Console.Write("Введите число: ");
int inputNumber = int.Parse(Console.ReadLine());

int count = 1;  // введенное число 
int tabX = 2;
int tabY = 2;
int NumberPerString = 1;

Console.Clear();                                //  inputNumber/Math.Abs(inputNumber) = даёт нам минус, если он был у введенного числа 
Console.Write($"Вот таблица кубов всех чисел от {(inputNumber / Math.Abs(inputNumber))} до {inputNumber}: ");
while (count <= Math.Abs(inputNumber)) /// пытался построить таблицу - но при больших числах появляются ошибки отрисовки консоли. Победить не смог 
{
    System.Console.SetCursorPosition(tabX, tabY);
    System.Console.Write($"{Math.Pow(count * (inputNumber / Math.Abs(inputNumber)), 3)}"); ///  inputNumber/Math.Abs(inputNumber) = даёт нам минус, если он был у введенного числа 
    tabX += 9;
    count++;
    NumberPerString++;

    if (count <= Math.Abs(inputNumber))
    {
        System.Console.Write($",");
    }

    if (NumberPerString > 17)  /// 17 чисел на строке
    {
        tabY += 2; tabX = 2;
        NumberPerString = 1;
    }
}