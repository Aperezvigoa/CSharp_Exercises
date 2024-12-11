using System;

public class CuentaCorriente:CuentaBancaria
{
    public double MaximoDescubierto { get; private set; }

    public CuentaCorriente(string titular, double saldoInicial, double maximoDescubierto):base(titular, saldoInicial)
    {
        MaximoDescubierto = 0 - maximoDescubierto;
    }

    public override void Retirar(double monto)
    {
        if ((Saldo - monto) >= MaximoDescubierto)
        { 
            base.Retirar(monto);
        } else
        {
            Console.WriteLine("No se pudo realizar la operación!");
            Console.WriteLine("El monto a retirar supera el limite de descubierto.");
        }
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Maximo descubierto: {MaximoDescubierto}");
        Console.WriteLine("Tipo de cuenta: Cuenta corriente.");
    }
}