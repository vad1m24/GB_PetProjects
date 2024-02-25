Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int N = Prompt("Введите значение N = ");
int M = Prompt("Введите значение M = ");

int temp = M;

if (M> N)
{
  M = N;
  N = temp;
}

PrintResult(M, N, temp = 0);

void PrintResult(int M, int N, int summ)
{
  summ = summ + N;
  if (N <= M)
  {
    Console.Write($"сумма элементов от M до N -> {summ} ");
    return;
  }
  PrintResult(M, N - 1, summ);
}