Console.Clear();

int Prompt(string message)

{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Prompt ("Введите значение N = ");

void NaturalNumbers(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbers(num-1);
}

NaturalNumbers(number);