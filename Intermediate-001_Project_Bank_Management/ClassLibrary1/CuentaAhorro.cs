using System;

public class CuentaAhorro:CuentaBancaria
{
    public double TasaInteres { get; private set; }

    public CuentaAhorro(string titular, double saldoInicial, double tasaInteres):base(titular, saldoInicial)
    {
        TasaInteres = tasaInteres;
    }

    public void AplicarInteres() => Saldo += Saldo * (TasaInteres / 100.0);
    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Tasa de interés: {TasaInteres}");
        Console.WriteLine("Tipo de cuenta: Cuenta de ahorro.");
    }
}