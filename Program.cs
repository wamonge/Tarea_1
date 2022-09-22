String[] alumnos = new string[5];
for (int i = 0; i < 5; i++)
{
    Console.Write("Ingrese el nombre del estudiante {0}: ",i+1);
    alumnos[i] = Console.ReadLine();

}
double[] notas = new double[5];
for (int i = 0; i < 5; i++)
{
    Console.Write("Ingrese la nota del estudiante {0}: ", i + 1);
    notas[i] = double.Parse(Console.ReadLine());

}
double suma = 0;
for (int i = 0; i < 5; i++)
{
    suma = suma + notas[i];
}
double promedio = 0;
promedio = suma / 5;
int mayor = 0;
int menor = 0;
for (int i = 0; i < 5; i++)
{
    if (notas[i]>promedio)
    {
        mayor = mayor + 1;
    }
    if (notas[i] < promedio)
    {
        menor = menor + 1;
    }
    Console.WriteLine("El/La estudiante {0} tiene una nota de {1}", alumnos[i], notas[i]);
}
Console.WriteLine("La cantidad de estudiantes con una nota mayor al promedio es de {0}, " +
    "mientras que los estudiantes con una nota menor al promedio son de {1}. El promedio es de {2}", mayor, menor, promedio);
