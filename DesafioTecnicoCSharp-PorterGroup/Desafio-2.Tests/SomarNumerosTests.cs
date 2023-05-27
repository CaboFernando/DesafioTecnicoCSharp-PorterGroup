using Xunit;

namespace Desafio_2.Tests
{
    public class SomarNumerosTests
    {
        [Fact]
        public void SomarNumeros_DeveRetornarSomaCorreta_ComArrayPequeno()
        {
            // Arrange
            int[] numeros = { 1, 2, 3, 4, 5 };
            int expectedSoma = 15;

            // Act
            int soma = Program.SomarNumeros(numeros);

            // Assert
            Assert.Equal(expectedSoma, soma);
        }

        [Fact]
        public void SomarNumeros_DeveRetornarSomaCorreta_ComArrayGrande()
        {
            // Arrange
            int[] numeros = new int[1000000];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 1;
            }
            int expectedSoma = 1000000;

            // Act
            int soma = Program.SomarNumeros(numeros);

            // Assert
            Assert.Equal(expectedSoma, soma);
        }
    }
}
