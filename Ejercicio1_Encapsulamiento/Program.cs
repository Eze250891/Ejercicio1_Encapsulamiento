namespace Ejercicio1_Encapsulamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cuenta1 = new CuentaBancaria();
            cuenta1.Depositar(5000);
            cuenta1.Depositar(8000);

           
            Console.WriteLine(cuenta1.SaldoActualDeposito());

            cuenta1.Retirar(5000);

            Console.WriteLine(cuenta1.SaldoActualRetiro());

            cuenta1.Retirar(7500);
            Console.WriteLine(cuenta1.SaldoActualRetiro());

        }
    }
}