namespace Wk3NavExample
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnGoToProductListClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ProductListPage());
        }
    }

}
