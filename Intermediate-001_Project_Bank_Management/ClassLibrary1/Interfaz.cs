using System;
using System.Collections.Generic;

public static class Interfaz
{
    public static void ImprimirMenu()
    {
        Console.WriteLine("========= Sistema De Gestion Bancaria =========");
        Console.WriteLine("1. Crear nueva cuenta");
        Console.WriteLine("2. Depositar dinero");
        Console.WriteLine("3. Retirar dinero (Solo cuentas corrientes)");
        Console.WriteLine("4. Ver estado de todas las cuentas");
        Console.WriteLine("5. Aplicar intereses (Solo cuentas de ahorro)");
        Console.WriteLine("6. Salir\n");
    }

    public static void MenuCrearCuenta()
    {
        Console.WriteLine("\nSeleccione un tipo de cuenta");
        Console.WriteLine("1. Cuenta corriente");
        Console.WriteLine("2. Cuenta de ahorro\n");
    }

    public static void MenuDepositar()
    {
        Console.WriteLine("\nSeleccione la cuenta: ");
        Console.WriteLine("1. Cuenta corriente");
        Console.WriteLine("2. Cuenta de ahorro\n");
    }

    public static void MostrarInfoCorriente(List<CuentaCorriente> listaCuentaCorriente)
    {
        foreach(CuentaCorriente cuentas in listaCuentaCorriente)
        {
            cuentas.MostrarInformacion();
        }
    }

    public static void MostrarInfoAhorro(List<CuentaAhorro> listaCuentaDeAhorro)
    {
        foreach (CuentaAhorro cuentas in listaCuentaDeAhorro)
        {
            cuentas.MostrarInformacion();
        }
    }

    public static void MostrarNumerosDeCuentaCorriente(List<CuentaCorriente> listaCuentaCorriente)
    {
        int i = 1;
        foreach (CuentaCorriente cuentas in listaCuentaCorriente)
        {
            Console.WriteLine($"{i}. {cuentas.Titular} - {cuentas.NumeroCuenta}");
            i++;
        }
    }

    public static void MostrarNumerosDeCuentaAhorro(List<CuentaAhorro> listaCuentaDeAhorro)
    {
        int i = 1;
        foreach (CuentaAhorro cuentas in listaCuentaDeAhorro)
        {
            Console.WriteLine($"{i}. {cuentas.Titular} - {cuentas.NumeroCuenta}");
            i++;
        }
    }
}