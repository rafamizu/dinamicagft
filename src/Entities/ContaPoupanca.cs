namespace Desafio_GFT.src.Entities
{
    public class ContaPoupanca
    {
        public ContaPoupanca(double Saldo, double Rendimento)
        {
            Rendimento = 0.07;
            double saldoContaCorrente = Saldo * Rendimento;
        }
    }
}
