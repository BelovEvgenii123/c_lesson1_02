﻿int[] array = {1,21,31,18,15,16,17,18};

int n = array.Length;
int find = 18;

int index = 0;
while (index < n)
{
if (array[index] == find)
{
    Console.WriteLine(index);
    break; // заверши
}
     index++;
}