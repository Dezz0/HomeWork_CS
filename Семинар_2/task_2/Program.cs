// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

bool CorrectNumber(int num){
    if (num / 100 != 0) return true;
    else return false;
};

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());

if (CorrectNumber(number))
{
    string numeral = number.ToString();
    System.Console.WriteLine($"Третья цифра в числе {number} -> {numeral[2]}");
}
else
{
    System.Console.WriteLine($"Третьей цифры в числе {number} нет");
}

