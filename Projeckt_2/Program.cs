Console.WriteLine("Введите число: ");
string inputed = Console.ReadLine();
int numberDay = Convert.ToInt32(inputed);
if ( 0<numberDay&numberDay<8)  {
    string [] week = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
    Console.WriteLine(week[numberDay-1]);
}
else {
    Console.WriteLine("Вывели не верные данные");
}