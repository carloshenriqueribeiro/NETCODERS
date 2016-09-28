using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using System.Linq;

namespace Test
{
    
    [TestClass]
    public class ContatoTest
    {

        [TestMethod]
        public void ExisteContato()
        {
            var rep = new ContatoRepository();

            var list = rep.GetAll();

            // se a lista estiver vazia, lançar falhar
            //if (!list.Any()) Assert.Fail();

            var qtdeEsperada = 4;

            Assert.AreEqual(qtdeEsperada, list.Count());

            
        }

    }
}
