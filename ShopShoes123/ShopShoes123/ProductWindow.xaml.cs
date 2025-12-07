using System.Linq;
using System.Windows;
using ShopShoes123.Statics;
using System.Data.Entity;
using System.Windows.Documents;
using ShopShoes123.ViewModels;
using System.Collections.Generic;

namespace ShopShoes123
{
    /// <summary>
    /// Логика взаимодействия для ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        private PROBNIKEntities _db = new PROBNIKEntities();   
        public ProductWindow()
        {
                InitializeComponent();
                LoadProducts();

        }
        public ProductWindow(Users user)
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = _db.Products.ToList();
            List<ProductViewModel> productViewModel = new List<ProductViewModel>();
            foreach (var p in products)
            {
                productViewModel.Add(new ProductViewModel(p));
            }
            ProductList.ItemsSource = productViewModel;
        }

        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentSession.CurrentUser = null;
            new MainWindow().Show();
            Close();
        }
    }
}
