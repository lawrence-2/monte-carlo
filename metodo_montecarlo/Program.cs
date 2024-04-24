using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("!!!Bienvenido al cslculador de Pi mediante el método Monte Carlo!!!");
        Console.WriteLine(" ingrese la cantidad de puntos a generar:");

        int totalPoints;
        while (!int.TryParse(Console.ReadLine(), out totalPoints) || totalPoints <= 0)
        {
            Console.WriteLine("Por favor, ingrese un número entero positivo.");
        }

        Random random = new Random();
        int pointsInsideCircle = 0;

        for (int i = 0; i < totalPoints; i++)
        {
            double x = random.NextDouble() * 2 - 1; // Genera x en [-1, 1]
            double y = random.NextDouble() * 2 - 1; // Genera y en [-1, 1]
            double distance = Math.Sqrt(x * x + y * y); // Distancia al origen

            if (distance <= 1) // Punto dentro del círculo si la distancia <= 1
            {
                pointsInsideCircle++;
            }
        }

        double piApproximation = 4.0 * pointsInsideCircle / totalPoints;
        Console.WriteLine($"Aproximación de Pi usando {totalPoints} puntos: {piApproximation}");
    }
}        //lorenzo ra
