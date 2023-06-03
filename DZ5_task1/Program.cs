/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
Console.Clear();
Console.Write("Введите размер массива Size: ");
int Size = int.Parse(Console.ReadLine()!);
int[] arrNum = ArrayRand(Size);
Console.WriteLine($"[{String.Join(", ", arrNum)}]");
int numEven = evenElem(arrNum, 0);
if (numEven != 0)
    Console.WriteLine($"Количество четных элементов: {numEven}");
else
    Console.WriteLine("Четных элементов в массиве нет");


int[] ArrayRand(int sz){
int[] digit = new int[sz];
for (int i = 0; i < sz; i++)
    digit[i] = new Random().Next(100, 1000); 
return digit;
}

int evenElem(int []arr, int res){
    foreach (var item in arr)
        res += item % 2 == 0 ? 1 : 0;
    return res;
}