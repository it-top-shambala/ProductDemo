using System.Collections.Generic;
using System.Windows;
using Products.Components.Component_Card;
using Products.Model;

namespace Products
{
    public partial class MainWindow : Window
    {
        private List<Product> _products;
        public MainWindow()
        {
            _products = new List<Product>
            {
                new() { Title = "Product_1", Description = "Product product product", Price = 200 },
                new() { Title = "Product_2", Description = "Product product product", Price = 2000 },
                new() { Title = "Product_3", Description = "Product product product", Price = 9999.99 },
            };
            InitializeComponent();
            InitPanelCards();
        }

        private void InitPanelCards()
        {
            foreach (var p in _products)
            {
                var card = new Card(p.Title, p.Description, p.Price) { Margin = new Thickness(10)};
                PanelCards.Children.Add(card);
            }
        }
    }
}
