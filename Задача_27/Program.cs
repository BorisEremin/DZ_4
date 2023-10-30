// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int A){
    
    int counter = Convert.ToString(A).Length;
    int b = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      b = A - A % 10;
      result = result + (A - b);
      A = A / 10;
    }
   return result;
  }

int sumNumber = SumNumber(A);
Console.WriteLine("Сумма чисел в данном числе: " + sumNumber);
