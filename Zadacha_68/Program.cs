// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Функция работает только с положительными значениями!");
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Значение функции Аккермана для A({M},{N}) = {Ackerman(M,N)}");

int Ackerman(int M, int N){
    if (M == 0) return N + 1;
    if (M > 0 && N == 0) return Ackerman(M - 1, 1);
    if (M > 0 && N > 0) return Ackerman(M - 1, Ackerman(M, N - 1));
    return Ackerman(M, N);
}