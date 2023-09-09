using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n<<<<<<<<<< CALCULADORA DE PROMEDIO UNIVERSITARIO >>>>>>>>>>");

            // SOLICITANDO AL ESTUDIANTE QUE INGRESE LAS NOTAS DEL PRIMER COMPUTO

            Console.WriteLine("\nIngrese las notas del primer computo");

            Console.WriteLine("Ingrese la nota del laboratorio 1:");
            double lab1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIngrese la nota del parcial 1:");
            double par1 = Convert.ToDouble(Console.ReadLine());

            // SOLICITANDO AL ESTUDIANTE QUE INGRESE LAS NOTAS DEL SEGUNDO COMPUTO

            Console.WriteLine("\nIngrese las notas del segundo computo");

            Console.WriteLine("Ingrese la nota del laboratorio 2:");
            double lab2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIngrese la nota del parcial 2:");
            double par2 = Convert.ToDouble(Console.ReadLine());

            // SOLICITANDO AL ESTUDIANTE QUE INGRESE LAS NOTAS DEL TERCER COMPUTO

            Console.WriteLine("\nIngrese las notas del tercer computo");

            Console.WriteLine("Ingrese la nota del laboratorio 3:");
            double lab3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIngrese la nota del parcial 3:");
            double par3 = Convert.ToDouble(Console.ReadLine());

            // CALCULAR EL PROMEDIO

            double promedioLab = (lab1 + lab2 + lab3) * 0.60;
            double promedioPar = (par1 + par2 + par3) * 0.40;
            double notaFinal = (promedioLab / 3) + (promedioPar / 3);

            Console.WriteLine("\nSu nota final fue de: " + Math.Round(notaFinal, 1));

            // COMPARAR EL PROMEDIO DE LAS NOTA FINAL

            if (notaFinal >= 7)
            {
                Console.WriteLine("\nUsted paso la materia con exelente nota.\n");
            }

            else if (notaFinal >= 6)
            {
                Console.WriteLine("\nUsted paso la materia con nota baja.\n");
            }

            else
            {
                Console.WriteLine("\nUsted saco una nota menor que 6, reprobo la materia.\n");
            }

            Console.ReadKey();

            // NOMBRE: PEDRO ANTONIO ALVAREZ HERNANDEZ
            // CODIGO: U20230697

        }
    }
}