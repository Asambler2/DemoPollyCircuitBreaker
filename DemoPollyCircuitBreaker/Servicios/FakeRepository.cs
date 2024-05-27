namespace DemoPollyCircuitBreaker.Servicios
{
    public class FakeRepository : IRepositorio
    {
        public string[] Get()
        {
            string[] sumaries = new[]
            {
                "Fresco", "Calor", "Vientecillo", "Frio", "Medio", "Warm", "Calido", "Hot", "Sweltering", "Scorching"
            };
            return sumaries;
        }
    }
}
