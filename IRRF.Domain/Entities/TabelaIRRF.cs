using System;

namespace IRRF.Domain.Entities
{
    public class TabelaIRRF
    {
        public TabelaIRRF(double salarioInicial, double salarioFinal, double aliquota, double parcela)
        {
            this.SalarioInicial = salarioInicial;
            this.SalarioFinal = salarioFinal;
            this.Aliquota = aliquota;
            this.Parcela = parcela;
        }

        public double SalarioInicial { get; private set; }
        public double SalarioFinal { get; private set; }
        public double Aliquota { get; private set; }
        public double Parcela { get; private set; }
    }
}
