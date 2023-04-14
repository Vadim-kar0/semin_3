﻿// Циклы
// ВАЖНО! Стараться не делать бесконечных циклов while (true) и проверять условие
// while - работает, пока выполняется условие

// int x = 1;
// while (x < 5) // пока x меньше 5: 1, 2, 3, 4
// {
//     Console.WriteLine(x); // Вывод x в консоль
//     x++; // увеличение переменной на 1
//     // равнозначно с:
//     // x += 1;
//     // x = x + 1;
// }

// do .. while - похож на while, но сначала идёт первое действие, а потом проверка условия
// int x = 10;
// do
// {
//     Console.WriteLine("Несмотря на то, что условие не выполняется, всё равно совершаем первое действие");
// } while (x < 10); // x == 10, условие не выполняется

// for - цикл с параметрами
// первый параметр - действия до итерации. В нашем случае, объявляем переменную
// второй параметр - условие
// третий параметр - действия после итерации. В нашем случае, увеличиваем переменную на 1
// for (int i = 1; i < 5; i++)
// {
//     Console.WriteLine(i); // Вывод в консоль переменной i
// }

// Работа со строками

// Добавление переменных в строку
// int x = 5;
// $ - ставится в начале строки перед двойными кавычками. Говорит о том, что в эту строку можно вставить переменную
// внутри строки (между двойными кавычками) указываются переменные в фигурных скобках
// string str = $"Значение x = {x}. Какой-то дальше текст";
// string str2 = "Значение x = " + x + ". Какой-то дальше текст";
// Console.WriteLine(str);
// Console.WriteLine(str2);

// Длина строки - количество элементов (букв):
// string str = "abc"; // три буквы
// Console.WriteLine(str.Length); // 3. Учитываются пробелы и непечатные символы

// строка - массив букв
// элементы массива считаются с нуля (называется индексом)
// string str = "Hello";
// // char ch = 'a'; // тип данных - символ (буква)
// Console.WriteLine(str[2]); // 2 - это 3-я буква, 2 - индекс, то есть l
// Console.WriteLine(str[0]); // 0 - это 1-я буква, 0 - индекс, то есть H
// for (int i = 0; i < str.Length; i++)
// {
//     Console.WriteLine(str[i]);
// }


// switch - сравнение с набором значений
// int x = 10;
// switch (x)
// {
//     case 0:
//         Console.WriteLine("x равен 0");
//         break; // конец выполнения switch
//     case 1:
//         Console.WriteLine("x равен 1");
//         break;
//     case 2:
//     case 3:
//         Console.WriteLine("x равен 2 или 3");
//         break;
//     default:
//         Console.WriteLine("Дальше лень считать");
//         break;
// }

// Преобразование типов - изменение типа данных переменной
// string str = "123"; // "123"
// // int a = int.Parse(str); // 123 - целое число
// // Равнозначно с:
// int a = Convert.ToInt32(str); // 123 - целое число
// double b = double.Parse(str); // 123.0 - дробное число
// // Равнозначно с:
// // double b = Convert.ToDouble(str); // 123.0 - дробное число
// Console.WriteLine(str);
// Console.WriteLine(a / 2); // 61 - дробная часть отбрасывается, когда операции производятся над целыми числами
// Console.WriteLine(b / 2); // 61.5 - дробная часть на месте, потому что число дробное

// Математические операции:
// Math.Pow - возведение в степень
// первое число - которое возводится
// второе - степень
// double x = Math.Pow(5, 2); // 25
// double x = Math.Pow(5, 3); // 125
// Math.Sqrt - квадратный корень
// первое число - число из которого берётся корень
// double x = Math.Sqrt(25); // 5
// Console.WriteLine(x);