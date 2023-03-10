//Task1. Выводит список чисел от 1 до N.
/*
void ShowNums(int num)
{
  if(num>1) ShowNums(num-1);
  Console.Write(num + " ");
}

ShowNums(5);
*/

//Task2. Принимает на вход число. Выводит сумму чисел.
/*
int SumOfDigits(int num)
{
  if(num/10!=0) return SumOfDigits(num/10)+num % 10;
  return num;
}

Console.WriteLine(SumOfDigits(1234));
*/

//Task3. Вывести все натуральные числа от M до N.
/*
void ShowNums(int m, int n)
{
  Console.Write(m + " ");
  if (n > m) ShowNums(m + 1, n);
  else if (n < m) ShowNums(m - 1, n);

}

ShowNums(2, 8);
Console.WriteLine();
ShowNums(8, 2);
*/
//Task4. Принимает два числа. Возвращает a в степени b. b может быть отр.

double Power(double a, int b)
{
  if (b > 0)
    return a * Power(a, b - 1);
  else if (b < 0)
    return Power(a, b + 1) * (1 / a);
  else return 1;
}

Console.WriteLine(Power(2, 2));
Console.WriteLine(Power(2, -2));