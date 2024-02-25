Console.Clear();

int Prompt(string message)

{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int N = Prompt("Введите значение N = ");
int M = Prompt("Введите значение M = ");

int Akkerman(int M, int N)

{
  if (M == 0) return N + 1;
  else if (N == 0) return Akkerman(M - 1, 1);
  else return Akkerman(M - 1, Akkerman(M, N - 1));
}

int function = Akkerman(M, N);
Console.Write($"A(M,N) = {function} ");