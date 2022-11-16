// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите несколько целых чисел: ");
string text = Console.ReadLine();
int size = 1;
int j = 0;
string record = String.Empty;

for (int i = 0; i < text.Length; i++)
{
    int count = Convert.ToInt32(text[i]);
    if(count == 44)
    {
        size++;
    } 
}

int [] array = new int[size];

for (int i = 0; i < text.Length; i++)
{
    int num = Convert.ToInt32(text[i]);
   
    if(num == 45 || num >= 48 && num <= 57)
    {
    string str = Convert.ToString(text[i]);
    record = record + str;
    }
    if(num == 44 || i == text.Length - 1)
    {
    int number = Convert.ToInt32(record);
    record = string.Empty;
    array[j] = number;
    j++;
    }
}
WriteArray(array);
PositivNumbers(array);

void WriteArray(int[] number)
{
    for(int i = 0; i < (number.Length - 1); i++)
    {
        Console.Write($"{number[i]}, ");
    }
    Console.WriteLine($"{number[number.Length - 1]} ");
}

void PositivNumbers(int[] numbers)
{
    int count = 0;
    for(int i = 0; i < numbers.Length; i++)
    if(numbers[i] > 0)
    {
        count++;
    }
    Console.WriteLine($"Количество положительных чисел: {count}");
}