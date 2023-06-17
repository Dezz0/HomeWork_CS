// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool CheckPalindrome(int number){
        int originalNumber = number;
        int reversedNumber = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }

        return originalNumber == reversedNumber;
};

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckPalindrome(number))
{
    Console.WriteLine("Число является палиндромом.");
}
else
{
    Console.WriteLine("Число не является палиндромом.");
}