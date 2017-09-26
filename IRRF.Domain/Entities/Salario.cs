using System;
using FluentValidator;

namespace IRRF.Domain.Entities
{
    public class Salario : Notifiable
    {
        public Salario(double salarioBase)
        {
            this.SalarioBase = salarioBase;

            new ValidationContract<Salario>(this).IsGreaterThan(s => s.SalarioBase, 1, "Salário deve ser maior que zero");

            IRRF irrf = new IRRF();

            this.FaixaSalarial = irrf.BuscarFaixaSalarial(salarioBase);
            this.Imposto = irrf.Calcula(this.FaixaSalarial, salarioBase);
        }

        public double Imposto
        {
            get;
            private set;
        }

        public TabelaIRRF FaixaSalarial
        {
            get;
            private set;
        }

        public double SalarioBase
        {
            get;
            private set;
        }
    }
}
