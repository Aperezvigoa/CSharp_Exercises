using System;
using System.Collections.Generic;

public class Program
{
    
    static void Main()
    {
        List<CuentaAhorro> CuentasDeAhorro = new List<CuentaAhorro>();
        List<CuentaCorriente> CuentasCorrientes = new List<CuentaCorriente>();
        ChoiceProcessor procesador = new ChoiceProcessor();
        bool closeProgram = false;

        while (!closeProgram)
        {
            Interfaz.ImprimirMenu();
            string userChoice = Console.ReadLine();
            bool isValid = int.TryParse(userChoice, out int intUserChoice);
            procesador.ProcessorMenuPrincipal(intUserChoice, ref closeProgram, CuentasDeAhorro, CuentasCorrientes);

            Console.Write("Pulsa una tecla para continuar: ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}