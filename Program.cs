/*6. Задача: Написать программу, которая из имеющегося массива строк формирует
массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекцияии, лучше обойтись исключительно массивами.
Создать репозиторий на GitHub
Примеры:
["hello", "2", "world", ".:-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> D﻿﻿ */
using System;

namespace Last_Ex01
{
    class Program
    {
        static void Main()
        {
            int num = 0;
            Console.WriteLine("Enter your any text(array):");
            string[] array = new string[3];
            string[] newArray = new string[array.Length];
                    for (int i = 0; i < array.Length; i++)
                        {
                            string input = Console.ReadLine();
                            array[i] = input;
                        }
    void PrintArr(string[] array)
                        {
                        for (int i = 0; i < array.Length; i++)
                            Console.Write($"{array[i]} "); 
                            
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                        }
    void FindNewArray (string[] array, string[] newArray)
                        {
                        int j = 0;
                        for (int i = 0; i < newArray.Length; i++)
                            {
                            if(array[i].Length <= 3)
                                newArray[j++] = array[i];
                            }
                        }

 Console.WriteLine(" ");
 Console.WriteLine("This your input: ");
 PrintArr(array);
 FindNewArray(array, newArray);
 Console.WriteLine("Array with i < 3 found:");
 PrintArr(newArray);

            }
            
        }
}

