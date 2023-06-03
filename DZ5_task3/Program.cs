/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */
Console.Clear();
Console.Write("Введите размер массива Size: ");
int Size = int.Parse(Console.ReadLine()!);
double[] arrNum = ArrayRand(Size);
Console.WriteLine($"[{String.Join("  ", arrNum)}]");
double[] diffM = maxMinDiff(arrNum);
double differ = Math.Round(diffM[0] - diffM[1], 2);
Console.WriteLine($"Разница max и min элементов ->  {diffM[0]} - {diffM[1]} = {differ}");

double[] ArrayRand(int sz){
double[] digit = new double[sz];
for (int i = 0; i < sz; i++)
    digit[i] = Math.Round(new Random().NextDouble() * new Random().Next(100), 2);
return digit;
}

double[] maxMinDiff(double[] arr){
    double[] res = new double[2];
    res[0] = arr[0];
    res[1] = arr[0];
    foreach (var item in arr)
    {
        res[0] = item > res[0] ? item : res[0];
        res[1] = item < res[1] ? item : res[1];
    }
    return res;
}