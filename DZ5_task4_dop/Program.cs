/* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */
Console.Clear();
int[] arrNum = ArrayRand(123);
Console.WriteLine($"[{String.Join(", ", arrNum)}]");
Console.WriteLine($"Количество элементов массива в отрезке [10,99] = {quantityEl(arrNum, 0)}");

int[] ArrayRand(int sz){
int[] digit = new int[sz];
for (int i = 0; i < sz; i++)
    digit[i] = new Random().Next(200); 
return digit;
}

int quantityEl(int []arr, int res){
    foreach (var item in arr)
        res += (item >= 10 && item <=99) ? 1 : 0;
    return res;
}