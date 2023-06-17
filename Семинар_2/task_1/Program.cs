// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetMiddleNumber(int num){
    return (num / 10) % 10;
};

System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine($"Вторая цифра числа {number} -> {GetMiddleNumber(number)}");