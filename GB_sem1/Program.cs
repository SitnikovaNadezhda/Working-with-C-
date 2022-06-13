/*/
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
Console.WriteLine("Result is" + result);
*/

/* 
Console.WriteLine("Введите числf");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());

int square = num2 * num2;

if (num1 == square){
    Console.WriteLine("first number is a square of second number");
}
else
{
   Console.WriteLine("first number is not a square of second number"); 
}
*/

//Напишите программу,которая будет выдавать название дня недели по заданному номеру.
/*
Console.Write("input number of a dey: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7){
    Console.WriteLine("incorreect dey");
}
else{
    if (day == 1){
        Console.WriteLine("monday");
    }
    if (day == 2){
        Console.WriteLine("tuesday");

    }
}
*/

//Напишите программу, которая наи вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("input N: ");
int num = Convert.ToInt32(Console.ReadLine());
int current;
if (num < 0){
    current = num;
    num = num * (-1);
}
else{
    current = -1 * num;
}

while(current < num-1){
    current++;
    Console.Write(current + " ");
  
}
/*


// Напишите программу,которая принимает на входе трехзначное число и на выходе показывает последнее число.


