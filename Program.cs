int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine())!;
}

double[,] Create2DArray(int rows, int columns)
{
    return new double[rows, columns];
}

void Fill2DArray(double[,] array, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(rnd.NextDouble() + rnd.Next(minValue, maxValue), 2);
            // array[i, j] = rnd.NextDouble() * (maxValue - minValue) + minValue;
            
            // int deviation = 10;
            // array[i, j] = (rnd.NextDouble() - 0.5) * 2 * deviation;

            // array[i, j] = rnd.Next(minValue, maxValue + 1);
}

string Print2DArray(double[,] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            res += array[i, j];
            if (j != array.GetLength(1) - 1)
                res += ";\t";
            else
                res += "\n";
        }
    return res;
}

int numRows = InputNum("Input a number of rows: ");
int numCols = InputNum("Input a numbers of columns: ");
double[,] myArray = Create2DArray(numRows, numCols);
int min = InputNum("Input a min value: ");
int max = InputNum("Input a max value: ");
Fill2DArray(myArray, min, max);
string result = Print2DArray(myArray);
Console.WriteLine(result);