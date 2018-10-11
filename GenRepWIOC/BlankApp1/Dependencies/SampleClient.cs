namespace BlankApp1.Dependencies
{
    public class SampleClient : ISampleClient
    {
        public string ClientName { get; set; }

        public string PrintClientName() => ClientName;

        bool isInitialized;

        public void Initialize() {
            isInitialized = true;
        }
    }

    public interface ISampleClient
    {
        string ClientName { get; set; }
        string PrintClientName();
        void Initialize();
    }
}
