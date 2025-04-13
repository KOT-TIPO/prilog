using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Yagnov.BDModel;

namespace Yagnov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow1.xaml
    /// </summary>
    public partial class MainWindow1 : Window
    {
        ShopDBEntities BDModel = new ShopDBEntities();
        private object _dbContext;
        private Product _product;

        public MainWindow1()
        {
            InitalizeComponent();
            _dbContext;
            _product = Product;
            if (_product != null)
            {
                NameTextBox.Text = _product.ProductName;
                PriceTextBox.Text = _product.Price.ToString();
                DescriptionTextBox.Text = _product.Description;
            }
           


        }

        private void InitalizeComponent()
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(NameTextBox.Text))
                {
                    MessageBox.Show("Введите название товара");
                    return;
                }
                if (!decimal.TryParse(PriceTextBox.Text, out decimal price))
                {
                    MessageBox.Show("Введите корректную цену товара.");
                    return;
                }
                if (_product == null)
                {
                    _product = new Products

                    {
                        ProductName = NameTextBox.Text,
                        price = price,
                        Description = DescriptionTextBox.Text
                    };
                    _dbContext.Products.Add(_product);
                }
                else
                {
                    _product.ProductName = NameTextBox.Text;
                    _product.Price = price;
                    _product.Description = DesriptionTextBox.Text;
                }
                _dbContext.SaveChanges();
                DialogResult = true;
                Close();
            }
                cath(Exception ex)
                    {
                MessageBox.Show($"Ошибка при сохранении товара:{ex.Message}");
            }
        }
    }
}
