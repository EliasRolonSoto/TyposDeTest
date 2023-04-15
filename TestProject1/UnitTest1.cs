using TyposDeTest;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void DebeSumar1mas1yRetornar2()
        {
            var calc = new TyposDeTest.Calculadora();
            var resultado = calc.Sumar(1, 1);
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void DebeSumar2mas3yRetornar5()
        {
            var calc = new TyposDeTest.Calculadora();
            var resultado = calc.Sumar(2, 3);
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void DebeMultiplicarPorSiMismo()
        {
            var num1 = 3;
            var cuadr = new Calculadora();
            var resultado = cuadr.Cuadrado(num1);

            Assert.Equal(9, resultado);
                
         }

        [Fact]
        public void DebeDuplicarLaCadena()
        {
            var cadena1 = "UTN";
            var cadena2 = cadena1;


        }


    }
}