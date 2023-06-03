/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
Console.Clear();
Console.Write("Введите размер массива Size: ");
int Size = int.Parse(Console.ReadLine()!);
int[] arrNum = ArrayRand(Size);
Console.WriteLine($"[{String.Join(", ", arrNum)}]");
Console.WriteLine($"Сумма элементов на нечетных позициях = {oddPos(arrNum, 0)}");

int[] ArrayRand(int sz){
int[] digit = new int[sz];
for (int i = 0; i < sz; i++)
    digit[i] = new Random().Next(-100, 101); 
return digit;
}

int oddPos(int []arr, int res){
    for (int i = 1; i < arr.Length; i++)
        res += i % 2 == 0 ? 0 : arr[i];
    return res;
}