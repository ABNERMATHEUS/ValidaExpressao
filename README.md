# ValidaExpressao
Valida expressões de matemática discreta


### rodar - ValidaExpressao.Tests

```csharp
[TestClass]
    public class UnitTest1
    {
        [TestCategory("Expressão")]
        [TestMethod("Verificar se a expressão é valida")]
        [DataRow("( )",true)]
        [DataRow("(~a)(~a)", true)]
        [DataRow("(~a)(~b)", true)]
        [DataRow("(~a^b)(~b v a)", true)]                
        [DataRow("( ))", false)]
        public void Verificar_expressao_valida(string expressao,bool status)
        {
            var validaExpressao = new ValidaExpressao();
            var resultado = validaExpressao.valida(expressao);
            Assert.AreEqual(status,resultado);
        }

    }
```
