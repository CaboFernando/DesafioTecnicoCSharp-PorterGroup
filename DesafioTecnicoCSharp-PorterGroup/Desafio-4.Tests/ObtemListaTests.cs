
using System;
using System.Collections.Generic;
using Xunit;

namespace Desafio_4.Tests
{
    public class ObtemListaTests
    {
        [Fact]
        public void ObterObjetosUnicos_DeveRetornarListaComObjetosUnicos()
        {
            // Arrange
            List<int> listaOriginal = new List<int>() { 1, 2, 3, 2, 4, 5, 1, 6, 6 };

            // Act
            List<int> listaUnica = Program.ObterObjetosUnicos(listaOriginal);

            // Assert
            Assert.Equal(6, listaUnica.Count);
            Assert.Contains(1, listaUnica);
            Assert.Contains(2, listaUnica);
            Assert.Contains(3, listaUnica);
            Assert.Contains(4, listaUnica);
            Assert.Contains(5, listaUnica);
            Assert.Contains(6, listaUnica);
        }

        [Fact]
        public void LerValoresDaEntrada_DeveLerValoresCorretamente()
        {
            // Arrange
            string input = "10,20.5,2023-01-01,OpenAI";

            // Mock Console.ReadLine()
            var consoleInput = new System.IO.StringReader(input);
            Console.SetIn(consoleInput);

            // Act
            List<object> listaOriginal = Program.LerValoresDaEntrada();

            // Assert
            Assert.Equal(4, listaOriginal.Count);
            Assert.Contains(10, listaOriginal);
            Assert.Contains(20.5, listaOriginal);
            Assert.Contains(new DateTime(2023, 1, 1), listaOriginal);
            Assert.Contains("OpenAI", listaOriginal);
        }

        [Fact]
        public void Main_DeveImprimirListasOriginaisEUnicas()
        {
            // Arrange
            string input = "1, 2, 3, 2, 4, 5, 1, 6, 6";

            // Mock Console.ReadLine()
            var consoleInput = new System.IO.StringReader(input);
            Console.SetIn(consoleInput);

            // Mock Console.WriteLine()
            var consoleOutput = new System.IO.StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            Program.Main(null);

            // Assert
            string output = consoleOutput.ToString();
            Assert.Contains("Lista Original: 1, 2, 3, 2, 4, 5, 1, 6, 6", output);
            Assert.Contains("Lista Única: 1, 2, 3, 4, 5, 6", output);
        }
    }
}
