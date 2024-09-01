using SquareLib.Model;

/*
Задание:

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. 
Дополнительно к работоспособности оценим:

Юнит-тесты +
Легкость добавления других фигур +-
Вычисление площади фигуры без знания типа фигуры в compile-time -
Проверку на то, является ли треугольник прямоугольным +
*/

/*
 "Вычисление площади фигуры без знания типа фигуры в compile-time"
 Мне кажется, это можно было бы реализовать через теориему Пика
 */
internal class Program
{
    private static void Main(string[] args)
    {
        SquareLib.Square square = new SquareLib.Square();

        Console.WriteLine("Введите стороны треугольника: ");
        Console.Write("a = ");
        var a = square.CheckNumber(Console.ReadLine());
        Console.Write("b = ");
        var b = square.CheckNumber(Console.ReadLine());
        Console.Write("c = ");
        var c = square.CheckNumber(Console.ReadLine());

        if (a != null && b != null && c != null)
        {
            var num = square.TriangleSquare((double)a, (double)b, (double)c);
            if (null == num)
                Console.WriteLine("Треугольник не существует");
            else Console.WriteLine($"Площадь треугольника = {num}");

            if (square.RightTrinagle((double)a, (double)b, (double)c))
                Console.WriteLine("Треугольник является прямоугольным");
        }
        else Console.WriteLine("Введено некорретное значение");


        Console.Write("Введите радиус окружности: ");
        var radius = square.CheckNumber(Console.ReadLine());
        if (null != radius)
        {
            CircleFig.radius = (double)radius;
            square.CircleSquare();
        }
        else Console.WriteLine("Введено некорретное значение");
        
        Console.ReadLine();
    }
}