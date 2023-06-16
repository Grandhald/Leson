string inputedString = Console.ReadLine(); //Ввод данных пользователем
int number = Convert.ToInt32(inputedString); //перевеод введенных данных в цело-числовый тип данных
Console.WriteLine("Вы ввели число " + number); //Вывод того, что ввел пользователь
int square = number * number; // присвоение перменой square значения квадарата числа number
Console.WriteLine($"Квадарт числа {number} равен {square}"); // Вывод квадрата числа

