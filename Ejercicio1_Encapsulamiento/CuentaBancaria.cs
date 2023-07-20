using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Encapsulamiento
{
    public class CuentaBancaria
    {
        //Atributos
        private int Saldo { get; set; }
        
        //Metodos
        
        public int Depositar (int deposito)
        {

            return Saldo += deposito;
        }


        public string SaldoActualDeposito()
        {
            return $"Tu Saldo Actual es de {Saldo}";
        }

        public int Retirar(int retiro)
        {
            return Saldo = Saldo - retiro;
        }

        public string SaldoActualRetiro()
        {
            return $"Tu Saldo actual despues del retiro es de {Saldo}";
        }
    }
}
