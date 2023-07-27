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