using Calculadora.Services;

namespace Calculadora_Test
{
    public class CalcServiceTest
    {
        [Fact]
        public void SomarNumero()
        {
            //Arrange
            decimal num1 = 5;
            decimal num2 = 10;

            //Act
            decimal esperado = num1 + num2;
            decimal resultado = CalcService.Somar(num1, num2);

            //Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void SubtrairNumero()
        {
            //Arrange
            decimal num1 = 5;
            decimal num2 = 10;

            //Act
            decimal esperado = num1 - num2;
            decimal resultado = CalcService.Subtrair(num1, num2);

            //Assert
            Assert.Equal(esperado, resultado);
        }
        [Fact]
        public void DividirNumero()
        {
            //Arrange
            decimal num1 = 5;
            decimal num2 = 10;

            //Act
            decimal esperado = num1 / num2;
            decimal resultado = CalcService.Dividir(num1, num2);

            //Assert
            Assert.Equal(esperado, resultado);
        }
        [Fact]
        public void MultiplicarNumero()
        {
            //Arrange
            decimal num1 = 5;
            decimal num2 = 10;

            //Act
            decimal esperado = num1 * num2;
            decimal resultado = CalcService.Multiplicar(num1, num2);

            //Assert
            Assert.Equal(esperado, resultado);
        }
        [Theory]
        [InlineData(new int[] { 2, 4, 6, 8, 10 })]
        public void VerificarSeNumeroEhParERetornarVerdadeiro(int[] listaDeNumeros)
        {
            //Act //Assert
            Assert.All(listaDeNumeros, num => Assert.True(CalcService.EhPar(num)));
        }

    }
}