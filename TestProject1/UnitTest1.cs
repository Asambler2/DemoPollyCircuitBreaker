using DemoPollyCircuitBreaker.Controllers;
using DemoPollyCircuitBreaker.Servicios;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controlador = new WeatherForecastController
                (
                    null,
                    new FakeRepository()
                );
            var resultado = controlador.Get();
            Assert.IsTrue(resultado != null);
            var comoArray = resultado.ToArray();
            Assert.IsTrue(comoArray.Length == 5);
        }
    }
}