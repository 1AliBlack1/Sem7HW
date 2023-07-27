/*
double [,] CreateDBArray()
{
    Console.Write("Enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter count of collumns: ");
    int userColl = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter min possible value: ");
    int userMin = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter max possible value: ");
    int userMax = Convert.ToInt32(Console.ReadLine());

    double [,] createdArray = new double[userRows, userColl];

    for (int i = 0; i < userRows; i++)
    {
        for (int j = 0; j < userColl; j++)
        {
            createdArray[i,j] = Math.Round((new Random().Next(userMin, userMax ) + new Random().NextDouble()),2);
        }
    }
    return createdArray;
}

void Print2dArray(double[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++) //.GetLength(0) определяет количество строк в массиве
    {
        for (int j = 0; j < array2d.GetLength(1); j++) //.GetLength(1) определяет количество столбцов в массиве
        {
            Console.Write(array2d[i,j]+ " "); 
        }
        Console.WriteLine(); // переход на ввода новой строки
    }
    Console.WriteLine(); //отступ от самого массива
}

double[,] arrayDB = CreateDBArray();
Print2dArray(arrayDB);
*/
/*
Console.Write("Введите размерность m массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m,n];
Console.Write("Введите позицию строки:");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int n2 = Convert.ToInt32(Console.ReadLine());

void mas(int m, int n)
{
    int i,j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
         Console.WriteLine();
         for (j = 0; j < n; j++)
        {
             randomArray[i,j] = rand.NextDouble();
             Console.Write($"{randomArray[i,j]:F2} ");
        }
        Console.WriteLine();
    }
}
mas(m,n);
if (m2<1 || n2<1)
Console.Write("Позиции строк не могут быть отрицательными");
else if (m2 <= m+1 && n2 <= n+1)
Console.Write($"Значение элемента равно {randomArray[m2-1,n2-1]:F2} ");
else Console.Write("Такого элемента нет в массиве");
*/

Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];

void mas(int m, int n)
{
    int i,j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
         Console.WriteLine();
         for (j = 0; j < n; j++)
        {
             randomArray[i,j] = rand.Next(1,9);
             Console.Write($"{randomArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void arif(int m, int n)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    int i,j;
    Random rand = new Random();
    for (j = 0; j < n; j++)
    {
        double sum = 0;
        for (i = 0; i < m; i++)
        {
            sum = sum + randomArray[i,j];
        }
        Console.Write($"{sum/(i):F1}; ");
    }
}
mas(m,n);
arif(m,n);