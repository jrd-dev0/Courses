using Calculadora.Services;

namespace Calculadora_Test
{
    public class StringServiceTest
    {
        [Fact]
        public void ContarOsCaracteresERetornarOValor()
        {
            //Arrange
            string nome = "Walter Benicio Durand Junior";

            //Act
            int esperado = nome.Length;
            int resultado = StringService.ContadorDeCaracteres(nome);

            //Assert
            Assert.Equal(esperado, resultado);
        }

    }
}
