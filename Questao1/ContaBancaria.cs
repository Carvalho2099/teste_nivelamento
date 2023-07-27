using System.Globalization;

namespace Questao1
{
    class ContaBancaria {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double? DepositoInicial { get; set; }
        public double TotalEmConta { get; set; }
        private double TributoSaque = 3.50;
        public ContaBancaria(int numero, string titular, double depositoInicial = 0.00)
        {
            Numero = numero;
            Titular = titular;
            TotalEmConta += depositoInicial;
        }
        internal void Deposito(double quantia) => TotalEmConta += quantia;
        internal void Saque(double quantia) => TotalEmConta = TotalEmConta - quantia - TributoSaque;
        internal string DadosDaConta()
        {
            return $"Conta {Numero}, Titular: {Titular}, Saldo:${TotalEmConta.ToString("F")}";
        }
        
    }
}
