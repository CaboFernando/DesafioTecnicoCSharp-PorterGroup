using Xunit;

namespace Desafio_1.Tests
{
    public class NumerosEmPalavrasTests
    {
        [Theory]
        [InlineData(0, "zero")]
        [InlineData(5, "cinco")]
        [InlineData(10, "dez")]
        [InlineData(25, "vinte e cinco")]
        [InlineData(100, "cem")]
        [InlineData(123, "cento e vinte e três")]
        [InlineData(1000, "mil")]
        [InlineData(2005, "dois mil e cinco")]
        [InlineData(1000000, "um milhão")]
        [InlineData(1234567, "um milhão e duzentos e trinta e quatro mil e quinhentos e sessenta e sete")]

        public void ConverteNumerosEmPalavras_ShouldConvertNumberToWords(int input, string expectedOutput)
        {
            // Arrange

            // Act
            string output = NumerosEmPalavras.ConverteNumerosEmPalavras(input);

            // Assert
            Assert.Equal(expectedOutput, output);
        }

        [Theory]
        [InlineData(0, "zero")]
        [InlineData(-5, "menos cinco")]
        [InlineData(-10, "menos dez")]
        [InlineData(-25, "menos vinte e cinco")]
        [InlineData(-100, "menos cem")]
        [InlineData(-123, "menos cento e vinte e três")]
        [InlineData(-1000, "menos mil")]
        [InlineData(-2005, "menos dois mil e cinco")]
        [InlineData(-1000000, "menos um milhão")]
        [InlineData(-1234567, "menos um milhão e duzentos e trinta e quatro mil e quinhentos e sessenta e sete")]
        public void ConverteNumerosEmPalavras_ShouldConvertNegativeNumberToWords(int input, string expectedOutput)
        {
            // Arrange

            // Act
            string output = NumerosEmPalavras.ConverteNumerosEmPalavras(input);

            // Assert
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void ConverteNumerosEmPalavras_ShouldHandleMaxValue()
        {
            // Arrange
            int input = 1999999;
            string expectedOutput = "um milhão e novecentos e noventa e nove mil e novecentos e noventa e nove";

            // Act
            string output = NumerosEmPalavras.ConverteNumerosEmPalavras(input);

            // Assert
            Assert.Equal(expectedOutput, output);
        }
    }
}
