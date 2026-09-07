int x = 0;

while (x == 0)
{
    for (int i = 1; i <= 3; i++)
    {
        System.Console.WriteLine("Ingresar Nota " + i + ":");
        int nota = int.Parse(Console.ReadLine());
    }

    System.Console.WriteLine("¿Deseas ingresar notas de otro estudiante? (s/n)");
    char estudiante = char.Parse(Console.ReadLine());

    if (estudiante == 's')
        x = 0;
    else
        x = 1;
}