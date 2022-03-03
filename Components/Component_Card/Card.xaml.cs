using System.Globalization;
using System.Windows.Controls;

namespace Products.Components.Component_Card
{
    public partial class Card : UserControl
    {
        public Card(string title, string description, double price)
        {
            InitializeComponent();
            
            LabelTitle.Content = title;
            LabelDescription.Content = description;
            LabelPrice.Content = price.ToString(CultureInfo.CurrentCulture);
        }
    }
}