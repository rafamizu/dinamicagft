namespace Desafio_GFT.src.Entities
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(double Saldo, double Rendimento)
        {
            Rendimento = 0.05;
            double saldoContaCorrente = Saldo * Rendimento;
        }
    }
}