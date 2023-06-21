using Microsoft.Windows.Themes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OnlineStore_WPF
{

    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products { get; set; } = new();

        public List<ListBoxItem>? MyProperty { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            MyProperty = new();
            
           
           
            DataContext = this;

        }

        private void basketButton_Click(object sender, RoutedEventArgs e)
        {
            // Prompt for product details
            string productName = Microsoft.VisualBasic.Interaction.InputBox("Enter the product name:", "Product Name", "");
            string productPriceString = Microsoft.VisualBasic.Interaction.InputBox("Enter the product price:", "Product Price", "");
            decimal productPrice;

            // Validate and convert the price to decimal
            if (!decimal.TryParse(productPriceString, out productPrice))
            {
                MessageBox.Show("Invalid product price. Please enter a valid decimal value.");
                return;
            }

            string imagePath = Microsoft.VisualBasic.Interaction.InputBox("Enter the image path or URL:", "Image Path or URL", "");

            ListBoxItem newItem = new ListBoxItem
            {
                Content = new Grid
                {
                    Children = {
                new Border { Style = (Style)FindResource("imageBorder") },
                new Image { Source = CreateImageSource(imagePath), Width = 40 },
                new Grid
                {
                    Margin = new Thickness(0, 183, 0, 0),
                    Children =
                    {
                        new Border { Style = (Style)FindResource("productsPriceBorder") },
                        new TextBlock { Text = productName, TextAlignment = TextAlignment.Center, VerticalAlignment = VerticalAlignment.Center, FontSize = 18, Foreground = Brushes.White, FontFamily = new FontFamily("Garamond") }
                    }
                }
            }
                }
            };
            
            itemListBox.Items.Add(newItem);
            Product selectedProduct = new Product();
            selectedProduct.Name = productName;
            selectedProduct.Price = productPrice;
            MessageBox.Show($"Seçilen ürün: {selectedProduct.Name}\nQiymet: {selectedProduct.Price} Manat");
        }

        private ImageSource CreateImageSource(string path)
        {
            if (Uri.TryCreate(path, UriKind.Absolute, out Uri uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
            {
                return new BitmapImage(uriResult);
            }
            else
            {
                return new BitmapImage(new Uri(path, UriKind.Relative));
            }
        }





        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void itemListBox_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListBoxItem selectedItem = itemListBox.SelectedItem as ListBoxItem;
            if (e.RightButton == MouseButtonState.Pressed)
            {
                if (itemListBox.SelectedItem == item1)
                {
                    itemListBox.Items.Remove(item1);
                }
                else if(itemListBox.SelectedItem == item2)
                {
                    itemListBox.Items.Remove(item2);
                }
                else if (itemListBox.SelectedItem == item3)
                {
                    itemListBox.Items.Remove(item3);
                }
                else if (itemListBox.SelectedItem == item4)
                {
                    itemListBox.Items.Remove(item4);
                }
                else if (itemListBox.SelectedItem == item5)
                {
                    itemListBox.Items.Remove(item5);
                }
                else if (itemListBox.SelectedItem == item6)
                {
                    itemListBox.Items.Remove(item6);
                }
                else
                {
                    itemListBox.Items.Remove(selectedItem);
                }
              
            }
        }

       

        private void itemListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            ListBoxItem selectedItem = listBox.SelectedItem as ListBoxItem;
            if (selectedItem != null)
            {
                if (selectedItem == item1)
                {

                    Product selectedProduct = new Product();
                    selectedProduct.Name = "Cola";
                    selectedProduct.Price = 0.80m;

                    MessageBox.Show($"Seçilen urun: {selectedProduct.Name}\nQiymet: {selectedProduct.Price} Manat");

                }
                else if (selectedItem == item2)
                {
                    Product selectedProduct = new Product();
                    selectedProduct.Name = "Potato";
                    selectedProduct.Price = 1.20m;
                    MessageBox.Show($"Seçilen urun: {selectedProduct.Name}\nQiymet: {selectedProduct.Price} Manat");


                }
                else if (selectedItem == item3)
                {
                    Product selectedProduct = new Product();
                    selectedProduct.Name = "Snickers";
                    selectedProduct.Price = 0.90m;
                    MessageBox.Show($"Seçilen urun: {selectedProduct.Name}\nQiymet: {selectedProduct.Price} Manat");

                }
                else if (selectedItem == item4)
                {
                    Product selectedProduct = new Product();
                    selectedProduct.Name = "Pepsi";
                    selectedProduct.Price = 0.85m;
                    MessageBox.Show($"Seçilen urun: {selectedProduct.Name}\nQiymet: {selectedProduct.Price} Manat");

                }
                else if (selectedItem == item5)
                {
                    Product selectedProduct = new Product();
                    selectedProduct.Name = "Vape";
                    selectedProduct.Price = 12.31m;
                    MessageBox.Show($"Seçilen urun: {selectedProduct.Name}\nQiymet: {selectedProduct.Price} Manat");

                }
                else if (selectedItem == item6)
                {
                    Product selectedProduct = new Product();
                    selectedProduct.Name = "Bread";
                    selectedProduct.Price = 0.65m;
                    MessageBox.Show($"Seçilen urun: {selectedProduct.Name}\nQiymet: {selectedProduct.Price} Manat");


                }
             



            }
        }
    }
}

