using Xunit;

namespace Desafio_3.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void AvaliarExpressao_DeveRetornarResultadoCorreto_QuandoUmaExpressaoValidaForFornecida()
        {
            // Arrange
            string expressao = "2 + 3 * 4 / 2";

            // Act
            double resultado = Calculadora.AvaliarExpressao(expressao);

            // Assert
            Assert.Equal(8.0, resultado);
        }

        [Fact]
        public void AvaliarExpressao_DeveLancarExcecao_QuandoAExpressaoEstiverAusente()
        {
            // Arrange
            string expressao = "";

            // Act & Assert
            Assert.Throws<System.ArgumentException>(() => Calculadora.AvaliarExpressao(expressao));
        }

        [Fact]
        public void AvaliarExpressao_DeveLancarExcecao_QuandoAExpressaoTentarDividirPorZero()
        {
            // Arrange
            string expressao = "10 / 0";

            // Act & Assert
            Assert.Throws<System.DivideByZeroException>(() => Calculadora.AvaliarExpressao(expressao));
        }

        [Fact]
        public void AvaliarExpressao_DeveLancarExcecao_QuandoAExpressaoPossuirFormatoInvalido()
        {
            // Arrange
            string expressao = "2 + 3 * / 4";

            // Act & Assert
            Assert.Throws<System.ArgumentException>(() => Calculadora.AvaliarExpressao(expressao));
        }
    }
}
