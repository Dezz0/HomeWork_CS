// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void IsWeekend(int num){
    if (num >= 1 && num <= 5)
    {
        System.Console.WriteLine($"{num} -> рабочий день");
    }
    if (num == 6 || num == 7)
    { 
        System.Console.WriteLine($"{num} -> выходной день");
    } 
}

System.Console.Write("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(System.Console.ReadLine());

IsWeekend(number);
