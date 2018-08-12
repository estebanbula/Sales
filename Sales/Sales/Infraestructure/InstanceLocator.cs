namespace Sales.Infraestructure
{
    using ViewModels;

    public class InstanceLocator
    {
        public MainVewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainVewModel();
        }
    }
}
