using CalculadoraIMC;

namespace TestXUnit
{
    public class TesteCalcXUnit
    {
        [Fact]
        public void CalcularIMC()
        {
            //Arrange - Preparação
            double kg = 40;
            double altura = 1.49;
            string c = "Abaixo do peso";

            //Act - Ação
            var resultado = Calculadora.CalcularIMC(kg, altura);

            //Assert
            Assert.Equal(c, resultado);

        }
        [Theory]
        [InlineData(40, 1.49, "Abaixo do peso")]
        [InlineData(50, 1.45, "Peso Normal")]
        [InlineData(69, 1.64, "Sobrepeso")]
        [InlineData(89, 1.72, "Obesidade Grau 1")]
        [InlineData(99, 1.68, "Obesidade Grau 2")]
        [InlineData(122, 1.74, "Obesidade Grau 3")]
        public void CalcularIMCLista(double kg,double altura, string c)
        {
            var resultado = Calculadora.CalcularIMC(kg, altura);
            Assert.Equal(c, resultado);
        }

    }

}