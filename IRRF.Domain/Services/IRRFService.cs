using System;
using IRRF.Domain.Entities;
using IRRF.Domain.Services.Interfaces;

namespace IRRF.Domain.Services
{
    public class IRRFService : IIRRFService
    {
        public double CalculaImposto(double valorSalario)
        {
            var _salario = new Salario(valorSalario);

            return _salario.Imposto;
        }
    }
}
