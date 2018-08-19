namespace Sales.ViewModels
{
    public class MainVewModel
    {
        public ProductsViewModel Products { get; set; }

        public MainVewModel()
        {
            this.Products = new ProductsViewModel();
        }
    }
}
