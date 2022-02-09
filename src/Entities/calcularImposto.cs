namespace Desafio_GFT.src.Entities
{
    public class calcularImposto
    {
        public calcularImposto(double salario, double imposto)
        {
            if (salario > 2500)
            {
                imposto = salario / 100 * 17.5;
            }
            else
            {
                imposto = salario / 100 * 11;
            }

            double salarioLiquido = salario - imposto;
        }
    }
}