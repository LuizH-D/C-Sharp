using System.Globalization;

namespace Banco {
    internal class ContaBancaria {
        public int NumConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numConta, string titular) {
            NumConta = numConta;
            Titular = titular;
        }
        public ContaBancaria(int numConta, string titular, double depositoInicial) : this(numConta, titular) {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia + 5;
        }

        public override string ToString() {
            return $"Conta {NumConta}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
