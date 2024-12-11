using System;

public class CuentaBancaria
{
    // Fields
    public string NumeroCuenta { get; private set; }
    public double Saldo { get; internal set; }
    private string _titular;

    // Properties
    public string Titular
    {
        get => _titular;
        set
        {
            if (value.Trim().Length < 3)
            {
                Console.WriteLine("El nombre del titular debe tener al menos 3 caracteres.");
                Console.WriteLine("Asignando nombre por defecto.");
                _titular = "Cliente";
            }
            else _titular = value.Trim();
        }
    }

    // Constructor
    public CuentaBancaria(string titular, double saldoInicial)
    {
        NumeroCuenta = Guid.NewGuid().ToString();
        Titular = titular;
        Saldo = saldoInicial;
    }

    // Methods
    public void Depositar(double monto) => Saldo += monto;
    public virtual void Retirar(double monto) => Saldo -= monto;
    public virtual void MostrarInformacion()
    {
        Console.WriteLine("---------------INFORMACIÓN DE LA CUENTA---------------");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Número de cuenta: {NumeroCuenta}");
        Console.WriteLine($"Saldo: {Saldo}");
    }
}