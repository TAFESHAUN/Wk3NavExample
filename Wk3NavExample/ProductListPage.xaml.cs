using System.Collections.ObjectModel;

namespace Wk3NavExample;

public partial class ProductListPage : ContentPage
{
    public ObservableCollection<Product> Products { get; set; }

    public ProductListPage()
    {
        InitializeComponent();
        Products = new ObservableCollection<Product>();
        BindingContext = this;
    }

    private void OnAddProductClicked(object sender, System.EventArgs e)
    {
        // Create a new product with the entered details
        var newProduct = new Product
        {
            Id = int.Parse(IdEntry.Text),
            Name = NameEntry.Text,
            Price = decimal.Parse(PriceEntry.Text),
            CalCode = CalCodeEntry.Text
        };

        // Add the new product to the list
        Products.Add(newProduct);

        // Clear the entry fields after adding the product
        IdEntry.Text = string.Empty;
        NameEntry.Text = string.Empty;
        PriceEntry.Text = string.Empty;
        CalCodeEntry.Text = string.Empty;
    }
}