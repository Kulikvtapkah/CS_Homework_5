// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



int EnterSmth(string request)
{
    System.Console.Write($" {request} >> ");
    int response = Convert.ToInt32(Console.ReadLine());
    return (response);
}

int[] RandArray(int Lnt, int Rmin, int Rmax)
{
    int[] RandArray = new int[Lnt];
    string Result = ("Случайный массив: ");

    for (int i = 0; i < Lnt; i++)
    {
        Random rnd = new Random();
        RandArray[i] = rnd.Next(Rmin, Rmax);
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
        response = EnterSmth(" Введите длину массива");

        if (response > 0)
        {
            rightInput = true;
        }
        else { System.Console.WriteLine("Нужен хотя бы один элемент! Попробуйте еще раз."); }
    }
    return (response);
}

int [] EnterBorders()
{   int [] borders = {0,0};
    int min =0;
    int max =0;
    bool rightInput = false;
while (rightInput == false)
{
    System.Console.WriteLine(" Введите границы диапазона: ");
    min = EnterSmth("нижняя ");
    max = EnterSmth("верхняя ");

    if (max >= min)
    {   
        borders [0] = min;
        borders [1] = max;
        rightInput = true;
    }
    else { System.Console.WriteLine("Все с ног на голову! Попробуйте еще раз."); }
}

return (borders);
}


System.Console.WriteLine("Генерируем случайный массив. Поехали!"); 

int[] Borders =  EnterBorders();
int[] Array = RandArray(EnterLength(), Borders[0],  Borders[1]);


if (Array.Length<2) 
System.Console.Write(" В этом массиве нет нечетных позиций:(");

else
{
    
int Sum2nd = Array[1];
for (int i = 3; i < Array.Length; i+=2)
{
     Sum2nd= Sum2nd+ Array[i];
}

System.Console.WriteLine();
System.Console.Write($"Сумма элементов на нечетных позициях = {Sum2nd}.");

}