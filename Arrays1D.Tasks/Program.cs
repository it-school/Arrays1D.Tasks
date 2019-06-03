using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1D.Tasks
{
	class Program
	{
		static void Main(string[] args)
		{
		//  Модификация длины массива
		    int[] array = new int[10];  // Объявляем массив из 10 элементов
		    int i = 0;
		    foreach (var item in array)
		    {
			array.SetValue(r.Next() % 11, i);
			Console.Write("  " + array.GetValue(i++));
		    }

		    Array.Resize(ref array, 20);    // Изменяем размер (ёмкость) массива
		    Console.WriteLine("\n\n");
		    i = 0;
		    foreach (var item in array)
		    {
			Console.Write("  " + array.GetValue(i++));
		    }

		    // Удаление 3 элементов из начала массива
		    for (i = 0; i < 3; i++)
		    {
			for (int j = 0; j < array.Length - 1; j++)
			{
			    array[j] = array[j + 1];
			}
			Array.Resize(ref array, array.Length - 1);
		    }

		    // Удаление 4 элементов в конце массива
		    Array.Resize(ref array, array.Length - 4);
		    Console.WriteLine("\n\n");
		    i = 0;
		    foreach (var item in array)
			Console.Write("  " + array.GetValue(i++));


		    // Вставка значения в указанную позицию (k) в массиве
		    int k = 3;
		    Array.Resize(ref array, array.Length+1);
		    for (int j = array.Length-1; j>=k; j--)
			array[j] = array[j-1];

		    array[k] = 50;
		    Console.WriteLine("\n\n");
		    foreach (var item in array)
			Console.Write("  " + item);
	    }
	}
}
