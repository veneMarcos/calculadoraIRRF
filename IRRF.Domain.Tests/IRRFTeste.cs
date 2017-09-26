using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IRRF.Domain.Tests
{
    [TestClass]
    public class IRRFTeste  
    {
        [TestMethod]
        public void FaixaSalarial1()
        {
            IRRF.Domain.Entities.IRRF _irrf = new IRRF.Domain.Entities.IRRF();
            var faixa = _irrf.BuscarFaixaSalarial(1000);
            Assert.AreEqual(faixa.Aliquota, 0);
        }

		[TestMethod]
		public void FaixaSalarial2()
		{
			IRRF.Domain.Entities.IRRF _irrf = new IRRF.Domain.Entities.IRRF();
			var faixa = _irrf.BuscarFaixaSalarial(2000);
			Assert.AreEqual(faixa.Aliquota, 0.075);
		}

		[TestMethod]
		public void FaixaSalarial3()
		{
			IRRF.Domain.Entities.IRRF _irrf = new IRRF.Domain.Entities.IRRF();
			var faixa = _irrf.BuscarFaixaSalarial(3000);
			Assert.AreEqual(faixa.Aliquota, 0.15);
		}

		[TestMethod]
		public void FaixaSalarial4()
		{
			IRRF.Domain.Entities.IRRF _irrf = new IRRF.Domain.Entities.IRRF();
			var faixa = _irrf.BuscarFaixaSalarial(4000);
			Assert.AreEqual(faixa.Aliquota, 0.225);
		}

		[TestMethod]
		public void FaixaSalarial5()
		{
			IRRF.Domain.Entities.IRRF _irrf = new IRRF.Domain.Entities.IRRF();
			var faixa = _irrf.BuscarFaixaSalarial(5000);
			Assert.AreEqual(faixa.Aliquota, 0.275);
		}
    }
}
