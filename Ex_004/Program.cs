// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Для определения расстояния между двумя точками для начала введите в каких измерениях будем работать.");
Console.Write("Двухмерное (вводим 2D) или трёхмерное (вводим 3D): ");
string space = Console.ReadLine() ?? "0";

int coordinate_x1 = 0, coordinate_y1 = 0, coordinate_z1 = 0,
    coordinate_x2 = 0, coordinate_y2 = 0, coordinate_z2 = 0;

double distance = 0;

if(space.ToLower() == "2d")
{
    Console.WriteLine("Отлично, работаем в двухмерном пространстве.");
    Console.WriteLine("Введите значение координат по оси абсцисс (х1) и по оси ординат (у1) для первой точки.");
    Console.Write("х1 = ");
    coordinate_x1 =int.Parse(Console.ReadLine());
    Console.Write("y1 = ");
    coordinate_y1 =int.Parse(Console.ReadLine());
    
    Console.WriteLine("Введите значение координат по оси абсцисс (х2) и по оси ординат (у2) для второй точки.");
    Console.Write("х2 = ");
    coordinate_x2 =int.Parse(Console.ReadLine());
    Console.Write("y2 = ");
    coordinate_y2 =int.Parse(Console.ReadLine());

    distance = Math.Sqrt(Math.Pow((coordinate_x2 - coordinate_x1),2) +  Math.Pow((coordinate_y2 - coordinate_y1),2));

    Console.Write("Расстояние на двухмерной плоскости между двумя точками, с указанными Вами координатами равно " + distance);
}

if(space.ToLower() == "3d")
{
    Console.WriteLine("Отлично, работаем в трёхмерном пространстве.");
    Console.WriteLine("Введите значение координат по оси абсцисс (х1), по оси ординат (у1) и по оси аппликат (z1) для первой точки.");
    Console.Write("х1 = ");
    coordinate_x1 =int.Parse(Console.ReadLine());
    Console.Write("y1 = ");
    coordinate_y1 =int.Parse(Console.ReadLine());
    Console.Write("z1 = ");
    coordinate_z1 =int.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение координат по оси абсцисс (х2), по оси ординат (у2) и по оси аппликат (z2) для второй точки.");
    Console.Write("х2 = ");
    coordinate_x2 =int.Parse(Console.ReadLine());
    Console.Write("y2 = ");
    coordinate_y2 =int.Parse(Console.ReadLine());
    Console.Write("z2 = ");
    coordinate_z2 =int.Parse(Console.ReadLine());

    distance = Math.Sqrt(Math.Pow((coordinate_x2 - coordinate_x1),2) +  Math.Pow((coordinate_y2 - coordinate_y1),2) +  Math.Pow((coordinate_z2 - coordinate_z1),2));

    Console.Write("Расстояние на трёхмерной плоскости между двумя точками, с указанными Вами координатами равно " + distance);
}

