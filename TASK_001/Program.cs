// Двумерные массивы

//string[,] table = new string[2,5];  // 2 - это кол-во строк, 5 - это кол-во столбцов

// Индекс идет с 0
// String.Empty - иницилизация пустых строк
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]  - обращаемся к первой строчке и 1,2,3,4,5 столбцу
// table[1,0] table[1,1] table[1,1] table[1,1] table[1,4]  - обращаемся ко сторой строчке и 1,2,3,4,5 столбцу

/*table[1,2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for(int colums = 0; colums < 5; colums++)
    {
        Console.WriteLine($"-{table[rows, colums]}-");      //распечатывание элементов нашего массива Console.WriteLine(), 
                                            // обращение к элементам массива через имя массива table, далее индекс строки и столбца [rows, colums]
    }
}*/

/* Вариант 1
int[,] matrix = new int[3, 4];

for (int i = 0; i < 3; i++)
{
    for(int j = 0; j < 4; j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();                                 // после того как вывели элементы в текущей строке мы перейдем на новую строку
}  */

// Вараиант 2 с matrix.GetLength()
int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++)    // matrix.GetLength(0) - это тоже самое что 3 элемента
{
    for(int j = 0; j < matrix.GetLength(1); j++)   // matrix.GetLength(1) - это тоже самое что 4 элемента
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();                                
}  