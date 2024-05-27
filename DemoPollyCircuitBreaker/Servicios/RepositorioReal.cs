namespace DemoPollyCircuitBreaker.Servicios
{
    public class RepositorioReal : IRepositorio
    {
        public string[] Get()
        {
            string[] sumaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };
            return sumaries;
        }
    }
}
