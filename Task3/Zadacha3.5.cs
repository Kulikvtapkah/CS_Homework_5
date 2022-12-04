// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int EnterSmth(string request)
{
    System.Console.Write($" {request} >> ");
    int response = Convert.ToInt32(Console.ReadLine());
    return (response);
}

double[] RandArray(int Lnt, int Rmin, int Rmax)
{
    double[] RandArray = new double[Lnt];
    string Result = ("Случайный массив: ");

    for (int i = 0; i < Lnt; i++)
    {
        Random rnd = new Random();

        RandArray[i] = Math.Round((rnd.NextDouble() * (Rmax - Rmin) + Rmin), 2, MidpointRounding.ToEven);
        Result = Result + RandArray[i] + "; ";
    }
    Result = Result.TrimEnd(';', ' ') + ".";
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

int[] EnterBorders()
{
    int[] borders = { 0, 0 };
    int min = 0;
    int max = 0;
    bool rightInput = false;
    while (rightInput == false)
    {
        System.Console.WriteLine(" Введите границы диапазона: ");
        min = EnterSmth("нижняя ");
        max = EnterSmth("верхняя ");

        if (max >= min)
        {
            borders[0] = min;
            borders[1] = max;
            rightInput = true;
        }
        else { System.Console.WriteLine("Все с ног на голову! Попробуйте еще раз."); }
    }
    return (borders);
}

double MinMaxDiff(double[] Array)
{
double CurrMin = Array[0];
double CurrMax = Array[0];

for (int i = 1; i < Array.Length; i++)
{
    double test = Math.Abs(Array[i] - CurrMin);
    if (Array[i] < CurrMin) CurrMin = Array[i];
    else
    if (Array[i] > CurrMax) CurrMax = Array[i];
}
return (CurrMax - CurrMin);
}

System.Console.WriteLine("Генерируем случайный массив. Поехали!");

int[] Borders = EnterBorders();
double[] Array = RandArray(EnterLength(), Borders[0], Borders[1]);

System.Console.WriteLine();
System.Console.Write($"Разница между максимальным и минимальным элементом массива = {MinMaxDiff(Array)}.");
