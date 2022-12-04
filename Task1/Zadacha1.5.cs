// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] RandArray(int Lnt)
{
    int[] RandArray = new int[Lnt];
    string Result = ("Случайный массив: ");

    for (int i = 0; i < Lnt; i++)
    {
        Random rnd = new Random();
        RandArray[i] = rnd.Next(100, 1000);
        Result = Result + RandArray[i] + ",";
    }
    Result = Result.TrimEnd(',') + ".";
    System.Console.Write(Result);
    return (RandArray);
}

int EnterLength()
{
    int response = 0;
    bool rightInput = false;
    while (rightInput == false)
    {
        System.Console.Write(" Введите длину массива >> ");
        response = Convert.ToInt32(Console.ReadLine());

        if (response > 0)
        {
            rightInput = true;
        }
        else { System.Console.WriteLine("Нужен хотя бы один элемент! Попробуйте еще раз."); }
    }
    return (response);
}



int[] Array = RandArray(EnterLength());

int Sum = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] % 2 == 0) Sum++;
}

System.Console.WriteLine();
System.Console.Write($"Количество четных элементов массива = {Sum}.");