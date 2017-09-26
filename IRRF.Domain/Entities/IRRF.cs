using System;
using System.Collections.Generic;
using System.Linq;

namespace IRRF.Domain.Entities
{
    public class IRRF
    {
        public IRRF()
        {
            this.Valores = new List<TabelaIRRF>()
            {
                new TabelaIRRF(0, 1999.18, 0, 0),
                new TabelaIRRF(1999.19, 2967.98, 0.075, 149.94),
                new TabelaIRRF(2967.99, 3938.60, 0.15, 372.54),
                new TabelaIRRF(3938.61, 4897.91, 0.225, 667.94),
                new TabelaIRRF(4897.92, double.MaxValue, 0.275, 912.83)
            };
        }

        public IList<TabelaIRRF> Valores { get; private set; }

        public TabelaIRRF BuscarFaixaSalarial(double salarioBase)
        {
            return Valores.First(x => x.SalarioInicial <= salarioBase && x.SalarioFinal >= salarioBase);
        }

        public double Calcula(TabelaIRRF dados, double salarioBase)
        {
            return salarioBase * dados.Aliquota - dados.Parcela;
        }
    }
}
