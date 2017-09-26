using IRRF.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IRRF.Domain.Tests
{
    [TestClass]
    public class SalarioTeste
    {
        [TestMethod]
        public void SalarioMaiorZero()
        {
            Salario _salario = new Salario(2000);
            Assert.IsTrue(_salario.IsValid());
        }
    }
}
