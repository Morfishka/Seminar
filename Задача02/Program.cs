﻿// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

Console.Write("Введите число дня недели: ");
int number =  Convert.ToInt32(Console.ReadLine());
if(number <= 7 & number >= 1) {
    if( number == 1) {
        Console.WriteLine("Поннедельник");
    }
    if(number == 2) {
        Console.WriteLine("Вторник");
    }
    if(number == 3) {
        Console.WriteLine("Среда");
    }
    if(number == 4) {
        Console.WriteLine("четверг");
    }
    if(number == 5) {
        Console.WriteLine("Пятница");
    }
    if(number == 6) {
        Console.WriteLine("Суббота");
    }
    if(number == 7) {
        Console.WriteLine("Воскресенье");
    }

    }
    else {
        Console.WriteLine("Такого дня недели не существует");
    }
