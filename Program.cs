//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
Console.Write(" Введите число А ");

int A  = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите  число В ");
int B  = Convert.ToInt32(Console.ReadLine());
int C = 1;
for (int i = 0; i < B; i++)
{
    C *= A;
}
    Console.WriteLine(C);
