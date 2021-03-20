using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidaExpressao.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestCategory("Expressão")]
        [TestMethod("Verificar se a expressão é valida")]
        [DataRow("( )",true)]
        [DataRow("(~a)(~a)", true)]
        //[DataRow("(~a)→(~a)", true)]
        [DataRow("( ))", false)]
        public void Verificar_expressao_valida(string expressao,bool status)
        {
            var validaExpressao = new ValidaExpressao();
            var resultado = validaExpressao.valida(expressao);
            Assert.AreEqual(status,resultado);
        }

    }
}
