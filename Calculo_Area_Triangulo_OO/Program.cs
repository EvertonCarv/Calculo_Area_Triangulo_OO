// See https://aka.ms/new-console-template for more information


using Calculo_Area_Triangulo_OO;

Triangulo objTriangulo = new Triangulo();

Console.WriteLine($"Digite a Base do Triángulo");
objTriangulo.@base = float.Parse(Console.ReadLine() ?? 0.ToString());

Console.WriteLine($"Digite a Altura do Triángulo");
objTriangulo.altura = float.Parse(Console.ReadLine() ?? throw new NullReferenceException());

objTriangulo.calculeArea(objTriangulo.@base, objTriangulo.altura);
Console.WriteLine($"A Área do Triángulo é {objTriangulo.area}");