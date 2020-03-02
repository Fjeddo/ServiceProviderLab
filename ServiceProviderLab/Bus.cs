namespace ServiceProviderLab
{
    public class Bus : IBus
    {
        private readonly BusConfiguration _configuration;

        public Bus(IConfiguration<IBus> configuration)
        {
            _configuration = (BusConfiguration) configuration;
        }
    }
}