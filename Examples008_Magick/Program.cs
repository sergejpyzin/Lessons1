﻿Console.Clear (); // Очистка консоли
// Console.SetCursorPosition (x, y) - установка курсора в координаты x и y;
// Console.WriteLine ("*");

int xa = 60, ya = 1,
    xb = 1, yb = 30,
    xc = 120, yc = 30;

Console.SetCursorPosition (xa, ya);
Console.WriteLine ("*");

Console.SetCursorPosition (xb, yb);
Console.WriteLine ("*");

Console.SetCursorPosition (xc, yc);
Console.WriteLine ("*");

int x = xa, y = ya;

int count = 0;

while (count < 25000) {

    int what = new Random().Next(0, 3); //случайное число от 0 до 2 включительно

    if (what == 0) {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1) {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2) {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition (x, y);
    Console.WriteLine("*");
    count++;

}