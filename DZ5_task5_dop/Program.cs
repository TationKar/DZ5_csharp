/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */
Console.Clear();
int Size = new Random().Next(3, 11);
int[] arrNum = ArrayRand(Size);
Console.WriteLine($"[{String.Join(", ", arrNum)}]");
int newSize = (Size % 2 == 0) ? Size / 2 : (Size / 2) + 1; 
int[] newArr = multEl(arrNum, newSize, Size-1);
Console.WriteLine($"[{String.Join(", ", newArr)}]");

int[] ArrayRand(int sz){
int[] digit = new int[sz];
for (int i = 0; i < sz; i++)
    digit[i] = new Random().Next(10); 
return digit;
}

int[] multEl(int[] arr, int sz, int oldSz){
    int[] res = new int[sz];
    int i = 0;
    for (i = 0; i < sz; i++)
        {
            res[i] = arr[i] * arr[oldSz];
            oldSz -= 1;
        }
    res[sz-1] = (Size % 2 == 1) ?  arr[Size/2] : res[sz-1];
    return res;
}