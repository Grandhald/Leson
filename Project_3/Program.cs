Console.WriteLine("Введите число:");
string inputed = Console.ReadLine();
int number = Convert.ToInt32(inputed);
int index = -number;
while (index!=number+1)
{
    Console.Write($"{index} ");
    index++;
}