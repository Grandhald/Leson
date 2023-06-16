Console.WriteLine("Введите первое число: ");
string inputFirst = Console.ReadLine();
int numberFirst = Convert.ToInt32(inputFirst);
Console.WriteLine("Введите второе число: ");
string inputSecond = Console.ReadLine();
int numberSecond = Convert.ToInt32(inputSecond);
int square = numberFirst * numberFirst;
if (numberSecond == square) {
   Console.WriteLine($"Число {numberSecond} является квадратом числа {numberFirst}");
}
else {
    Console.WriteLine($"Число {numberSecond} не является квадратом числа {numberFirst}");
}