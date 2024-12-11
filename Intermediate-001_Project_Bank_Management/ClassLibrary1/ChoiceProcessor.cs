using System;
using System.Collections.Generic;
using System.Xml.Serialization;

public class ChoiceProcessor
{
    public void ProcessorMenuPrincipal(int choice, ref bool exit, List<CuentaAhorro> listaCuentaDeAhorro, List<CuentaCorriente> listaCuentaCorriente)
    {
        switch (choice)
        {
            case 1:
                Console.Clear();
                Interfaz.MenuCrearCuenta();
                ProcessorCrearCuenta(listaCuentaDeAhorro, listaCuentaCorriente);
                break;
            case 2:
                Console.Clear();
                Interfaz.MenuDepositar();
                ProcesarMenuDepositar(listaCuentaDeAhorro, listaCuentaCorriente);
                break;
            case 3:
                Console.Clear();
                ProcesarMenuRetirar(listaCuentaCorriente);
                break;
            case 4:
                Console.Clear();
                Interfaz.MostrarInfoCorriente(listaCuentaCorriente);
                Interfaz.MostrarInfoAhorro(listaCuentaDeAhorro);
                break;
            case 5:
                Console.Clear();
                ProcesarTasaInteres(listaCuentaDeAhorro);
                break;
            case 6:
                exit = true;
                break;
            default:
                Console.WriteLine("Opcion no valida.");
                break;
        }
    }

    public void ProcessorCrearCuenta(List<CuentaAhorro> listaCuentaDeAhorro, List<CuentaCorriente> listaCuentaCorriente)
    {
        Console.Write("Seleccione una opción: ");
        string userChoice = Console.ReadLine();
        bool validChoice = int.TryParse(userChoice, out int choice);
        switch(choice)
        {
            case 1:
                Console.Write("Introduzca el nombre del titular: ");
                string titular = Console.ReadLine();
                Console.Write("Introduzca el saldo incial: ");
                string stringSaldo = Console.ReadLine();
                bool saldoValido = double.TryParse(stringSaldo, out double saldo);
                Console.Write("Introduzca el limite maximo descubierto: ");
                string stringDescubierto = Console.ReadLine();
                bool descubiertoValido = double.TryParse(stringDescubierto, out double descubierto);

                if (saldoValido && descubiertoValido)
                {
                    CuentaCorriente cuenta = new CuentaCorriente(titular, saldo, descubierto);
                    listaCuentaCorriente.Add(cuenta);
                    Console.WriteLine("\nCuenta creada con exito.\n");
                }
                else Console.WriteLine("\nNo se pudo crear la cuenta.\n");
                break;
            case 2:
                Console.Write("Introduzca el nombre del titular: ");
                titular = Console.ReadLine();
                Console.Write("Introduzca el saldo incial: ");
                stringSaldo = Console.ReadLine();
                saldoValido = double.TryParse(stringSaldo, out saldo);
                Console.Write("Introduzca la tasa de interés: ");
                string stringIntereses = Console.ReadLine();
                bool interesValido = double.TryParse(stringIntereses, out double interes);

                if (saldoValido && interesValido)
                {
                    CuentaAhorro cuenta = new CuentaAhorro(titular, saldo, interes);
                    listaCuentaDeAhorro.Add(cuenta);
                    Console.WriteLine("\nCuenta creada con exito.\n");
                }
                else Console.WriteLine("\nNo se pudo crear la cuenta.\n");
                break;
            default:
                Console.WriteLine("\nOpcion no valida.");
                Console.WriteLine("Saliendo al menu principal.\n");
                break;
        }
    }

    public void ProcesarMenuDepositar(List<CuentaAhorro> listaCuentaDeAhorro, List<CuentaCorriente> listaCuentaCorriente)
    {
        Console.Write("Seleccione una opción: ");
        string userChoice = Console.ReadLine();
        bool validChoice = int.TryParse(userChoice, out int choice);
        switch(choice)
        {
            case 1:
                if(listaCuentaCorriente.Count == 0)
                {
                    Console.WriteLine("\nNo hay cuentas corientes abiertas!\n");
                } else
                {
                    Console.Clear();
                    Interfaz.MostrarNumerosDeCuentaCorriente(listaCuentaCorriente);
                    Console.Write("Seleccione la cuenta: ");
                    userChoice = Console.ReadLine();
                    validChoice = int.TryParse(userChoice, out choice);
                    if(validChoice)
                    {
                        choice -= 1;
                        if(choice >= 0 && choice < listaCuentaCorriente.Count)
                        {
                            Console.WriteLine("Cuenta seleccionada con éxito.");
                            Console.Write("Ingrese la cantidad a depositar: ");
                            string userInput = Console.ReadLine();
                            bool validarDeposito = double.TryParse(userInput, out double deposito);
                            listaCuentaCorriente[choice].Depositar(deposito);
                            Console.WriteLine("Deposito realizado con exito.");
                        } else Console.WriteLine("Cuenta seleccionada no válida.");
                    } else
                    {
                        Console.WriteLine("Cuenta no válida.");
                    }
                }
                break;
            case 2:
                if(listaCuentaDeAhorro.Count == 0)
                {
                    Console.WriteLine("\nNo hay cuentas de ahorro abiertas!\n");
                }
                else
                {
                    Console.Clear();
                    Interfaz.MostrarNumerosDeCuentaAhorro(listaCuentaDeAhorro);
                    Console.Write("Seleccione la cuenta: ");
                    userChoice = Console.ReadLine();
                    validChoice = int.TryParse(userChoice, out choice);
                    if (validChoice)
                    {
                        choice -= 1;
                        if (choice >= 0 && choice < listaCuentaDeAhorro.Count)
                        {
                            Console.WriteLine("Cuenta seleccionada con éxito.");
                            Console.Write("Ingrese la cantidad a depositar: ");
                            string userInput = Console.ReadLine();
                            bool validarDeposito = double.TryParse(userInput, out double deposito);
                            listaCuentaDeAhorro[choice].Depositar(deposito);
                            Console.WriteLine("Deposito realizado con exito.");
                        } else Console.WriteLine("Cuenta seleccionada no válida.");
                    }
                    else
                    {
                        Console.WriteLine("Cuenta no válida.");
                    }
                }
                break;
            default:
                Console.WriteLine("\nOpcion no valida.");
                Console.WriteLine("Saliendo al menu principal.\n");
                break;
        }
    }

    public void ProcesarMenuRetirar(List<CuentaCorriente> listaCuentaCorriente)
    {
        if (listaCuentaCorriente.Count == 0)
        {
            Console.WriteLine("\nNo hay cuentas corientes abiertas!\n");
        }
        else
        {
            Console.Clear();
            Interfaz.MostrarNumerosDeCuentaCorriente(listaCuentaCorriente);
            Console.Write("Seleccione la cuenta: ");
            string userChoice = Console.ReadLine();
            bool validChoice = int.TryParse(userChoice, out int choice);
            if (validChoice)
            {
                choice -= 1;
                if (choice >= 0 && choice < listaCuentaCorriente.Count)
                {
                    Console.WriteLine("Cuenta seleccionada con éxito.");
                    Console.Write("Ingrese la cantidad a retirar: ");
                    string userInput = Console.ReadLine();
                    bool validarRetiro = double.TryParse(userInput, out double retiro);
                    listaCuentaCorriente[choice].Retirar(retiro);
                } else Console.WriteLine("Cuenta seleccionada no válida.");
            }
            else Console.WriteLine("Cuenta no válida.");
        }
    }

    public void ProcesarTasaInteres(List<CuentaAhorro> listaCuentaDeAhorro)
    {
        if(listaCuentaDeAhorro.Count == 0) Console.WriteLine("No hay cuentas de ahorro disponibles."); 
        else
        {
            Interfaz.MostrarNumerosDeCuentaAhorro(listaCuentaDeAhorro);
            Console.WriteLine("Seleccione la cuenta: ");
            string userChoice = Console.ReadLine();
            bool isValid = int.TryParse(userChoice, out int choice);
            if(isValid)
            {
                choice -= 1;
                if (choice >= 0 && choice < listaCuentaDeAhorro.Count)
                {
                    listaCuentaDeAhorro[choice].AplicarInteres();
                    Console.WriteLine("Tasa de interés aplicada con éxito.");
                }
                else Console.WriteLine("Cuenta no válida.");
            }
        }
    }
}