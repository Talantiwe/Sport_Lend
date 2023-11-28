using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Sport_Lend
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Bascket> basketItems = new ObservableCollection<Bascket>();
        
        public MainWindow()
        {
            InitializeComponent();
            
            Primer1(null, null);
            
           // primer(null, null);

        }
        public class Sport_LendEntities : DbContext
        {
            public virtual DbSet<Bascket> Bascket { get; set; }
            public virtual DbSet<Price> Price { get; set; }
            public Sport_LendEntities() : base("Data Source=DESKTOP-JT2CST3;Initial Catalog=Sport_Lend;Integrated Security=True")
            {

            }
        }

        private void Exit_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Primer1(object sender, RoutedEventArgs e)
        {
            try
            {
                // Создайте объект Sport_LendEntities
                using (Sport_LendEntities context = new Sport_LendEntities())
                {
                    var prices = from Price in context.Price
                                 where Price.Name == "Kultlab BCAA"
                                 select new { Price.Name, Price.Prices, Price.Image };

                    foreach (var price in prices)
                    {
                        ns_TextBlock.Text += $" {price.Name}{Environment.NewLine}";
                        s_TextBlock.Text += $"{price.Prices}₽{Environment.NewLine}";

                        byte[] imageData = price.Image;

                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream stream = new MemoryStream(imageData))
                            {
                                BitmapImage image = new BitmapImage();
                                image.BeginInit();
                                image.StreamSource = stream;
                                image.CacheOption = BitmapCacheOption.OnLoad;
                                image.EndInit();

                                Image photoImage = new Image();
                                photoImage.Source = image;

                                // Ваш элемент управления для отображения изображения, например, Image
                                photo_TextBlock.Content = photoImage;
                            }
                        }
                    }

                    var prices2 = from Price in context.Price
                                  where Price.Name == "Protein"
                                  select new { Price.Name, Price.Prices, Price.Image };

                    foreach (var price in prices2)
                    {
                        ns2_TextBlock.Text += $" {price.Name}{Environment.NewLine}";
                        s2_TextBlock.Text += $"{price.Prices}₽{Environment.NewLine}";

                        byte[] imageData = price.Image;

                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream stream = new MemoryStream(imageData))
                            {
                                BitmapImage image = new BitmapImage();
                                image.BeginInit();
                                image.StreamSource = stream;
                                image.CacheOption = BitmapCacheOption.OnLoad;
                                image.EndInit();

                                Image photoImage = new Image();
                                photoImage.Source = image;

                                // Ваш элемент управления для отображения изображения, например, Image
                                photo2_TextBlock.Content = photoImage;
                            }
                        }
                    }

                    var prices3 = from Price in context.Price
                                  where Price.Name == "Omega 3"
                                  select new { Price.Name, Price.Prices, Price.Image };

                    foreach (var price in prices3)
                    {
                        ns3_TextBlock.Text += $" {price.Name}{Environment.NewLine}";
                        s3_TextBlock.Text += $"{price.Prices}₽{Environment.NewLine}";

                        byte[] imageData = price.Image;

                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream stream = new MemoryStream(imageData))
                            {
                                BitmapImage image = new BitmapImage();
                                image.BeginInit();
                                image.StreamSource = stream;
                                image.CacheOption = BitmapCacheOption.OnLoad;
                                image.EndInit();

                                Image photoImage = new Image();
                                photoImage.Source = image;

                                // Ваш элемент управления для отображения изображения, например, Image
                                photo3_TextBlock.Content = photoImage;
                            }
                        }
                    }

                    var prices4 = from Price in context.Price
                                  where Price.Name == "Cool Bar"
                                  select new { Price.Name, Price.Prices, Price.Image };

                    foreach (var price in prices4)
                    {
                        ns4_TextBlock.Text += $" {price.Name}{Environment.NewLine}";
                        s4_TextBlock.Text += $"{price.Prices}₽{Environment.NewLine}";

                        byte[] imageData = price.Image;

                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream stream = new MemoryStream(imageData))
                            {
                                BitmapImage image = new BitmapImage();
                                image.BeginInit();
                                image.StreamSource = stream;
                                image.CacheOption = BitmapCacheOption.OnLoad;
                                image.EndInit();

                                Image photoImage = new Image();
                                photoImage.Source = image;

                                // Ваш элемент управления для отображения изображения, например, Image
                                photo4_TextBlock.Content = photoImage;
                            }
                        }
                    }

                    var prices5 = from Price in context.Price
                                  where Price.Name == "Kultlab L-Carnitine"
                                  select new { Price.Name, Price.Prices, Price.Image };

                    foreach (var price in prices5)
                    {
                        ns5_TextBlock.Text += $" {price.Name}{Environment.NewLine}";
                        s5_TextBlock.Text += $"{price.Prices}₽{Environment.NewLine}";

                        byte[] imageData = price.Image;

                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream stream = new MemoryStream(imageData))
                            {
                                BitmapImage image = new BitmapImage();
                                image.BeginInit();
                                image.StreamSource = stream;
                                image.CacheOption = BitmapCacheOption.OnLoad;
                                image.EndInit();

                                Image photoImage = new Image();
                                photoImage.Source = image;

                                // Ваш элемент управления для отображения изображения, например, Image
                                photo5_TextBlock.Content = photoImage;
                            }
                        }
                    }

                    var prices6 = from Price in context.Price
                                  where Price.Name == "Kultlab Melatonin"
                                  select new { Price.Name, Price.Prices, Price.Image };

                    foreach (var price in prices6)
                    {
                        ns6_TextBlock.Text += $" {price.Name}{Environment.NewLine}";
                        s6_TextBlock.Text += $"{price.Prices}₽{Environment.NewLine}";

                        byte[] imageData = price.Image;

                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream stream = new MemoryStream(imageData))
                            {
                                BitmapImage image = new BitmapImage();
                                image.BeginInit();
                                image.StreamSource = stream;
                                image.CacheOption = BitmapCacheOption.OnLoad;
                                image.EndInit();

                                Image photoImage = new Image();
                                photoImage.Source = image;

                                // Ваш элемент управления для отображения изображения, например, Image
                                photo6_TextBlock.Content = photoImage;
                            }
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}");

                if (ex.InnerException != null)
                {
                    MessageBox.Show($"Inner Exception: {ex.InnerException.Message}\n\nInner Exception Stack Trace:\n{ex.InnerException.StackTrace}");
                }
            }
        }
        
        private void Korz_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                using (Sport_LendEntities context = new Sport_LendEntities())
                {

                    Korzina korzina = new Korzina();
                    korzina.Show();
                    korzina.UpdateDataGrid();
                    korzina.VivodSum();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}");

                if (ex.InnerException != null)
                {
                    MessageBox.Show($"Inner Exception: {ex.InnerException.Message}\n\nInner Exception Stack Trace:\n{ex.InnerException.StackTrace}");
                }
            }
            


        }
        private void Pay_Click(object sender, MouseButtonEventArgs e)
        {

            try
            {
                using (Sport_LendEntities context = new Sport_LendEntities())
                {

                    var name = ns_TextBlock.Text;
                    var price = s_TextBlock.Text;
                    var priceText = s_TextBlock.Text.Replace("₽", "").Trim();

                    var basketItem = new Bascket
                    {
                        Name_Product = name,
                        Price = Convert.ToDecimal(priceText)
                    };
                    context.Bascket.Add(basketItem);
                    basketItems.Add(basketItem);
                    context.SaveChanges();

                    MessageBox.Show("Товар добавлен в корзину");



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}");

                if (ex.InnerException != null)
                {
                    MessageBox.Show($"Inner Exception: {ex.InnerException.Message}\n\nInner Exception Stack Trace:\n{ex.InnerException.StackTrace}");
                }
            }
        }

        private void Pay2_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                using (Sport_LendEntities context = new Sport_LendEntities())
                {

                    var name = ns2_TextBlock.Text;
                    var price = s2_TextBlock.Text;
                    var priceText = s2_TextBlock.Text.Replace("₽", "").Trim();

                    var basketItem = new Bascket
                    {
                        Name_Product = name,
                        Price = Convert.ToDecimal(priceText)
                    };
                    context.Bascket.Add(basketItem);
                    basketItems.Add(basketItem);
                    context.SaveChanges();

                    MessageBox.Show("Товар добавлен в корзину");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}");

                if (ex.InnerException != null)
                {
                    MessageBox.Show($"Inner Exception: {ex.InnerException.Message}\n\nInner Exception Stack Trace:\n{ex.InnerException.StackTrace}");
                }
            }
        }

        private void Pay3_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                using (Sport_LendEntities context = new Sport_LendEntities())
                {
                    var name = ns3_TextBlock.Text;
                    var price = s3_TextBlock.Text;
                    var priceText = s3_TextBlock.Text.Replace("₽", "").Trim();

                    var basketItem = new Bascket
                    {
                        Name_Product = name,
                        Price = Convert.ToDecimal(priceText)
                    };
                    context.Bascket.Add(basketItem);
                    basketItems.Add(basketItem);
                    context.SaveChanges();

                    MessageBox.Show("Товар добавлен в корзину");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void Pay4_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                using (Sport_LendEntities context = new Sport_LendEntities())
                {
                    var name = ns4_TextBlock.Text;
                    var price = s4_TextBlock.Text;
                    var priceText = s4_TextBlock.Text.Replace("₽", "").Trim();

                    var basketItem = new Bascket
                    {
                        Name_Product = name,
                        Price = Convert.ToDecimal(priceText)
                    };
                    context.Bascket.Add(basketItem);
                    basketItems.Add(basketItem);
                    context.SaveChanges();

                    MessageBox.Show("Товар добавлен в корзину");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void Pay5_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                using (Sport_LendEntities context = new Sport_LendEntities())
                {
                    var name = ns5_TextBlock.Text;
                    var price = s5_TextBlock.Text;
                    var priceText = s5_TextBlock.Text.Replace("₽", "").Trim();

                    var basketItem = new Bascket
                    {
                        Name_Product = name,
                        Price = Convert.ToDecimal(priceText)
                    };
                    context.Bascket.Add(basketItem);
                    basketItems.Add(basketItem);
                    context.SaveChanges();

                    MessageBox.Show("Товар добавлен в корзину");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void Pay6_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                using (Sport_LendEntities context = new Sport_LendEntities())
                {
                    var name = ns6_TextBlock.Text;
                    var price = s6_TextBlock.Text;
                    var priceText = s6_TextBlock.Text.Replace("₽", "").Trim();

                    var basketItem = new Bascket
                    {
                        Name_Product = name,
                        Price = Convert.ToDecimal(priceText)
                    };
                    context.Bascket.Add(basketItem);
                    basketItems.Add(basketItem);
                    context.SaveChanges();

                    MessageBox.Show("Товар добавлен в корзину");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
        /*
        public void primer(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var context = new Sport_LendEntities())
                {
                    var foundUser = context.Client.FirstOrDefault(u => u.login == u.login);

                    if (foundUser != null)
                    {
                        log_TextBlock.Text += $"Логин: {foundUser.login} {Environment.NewLine}";
                    }
                    else
                    {
                        // Логика обработки, если пользователь с таким логином не найден
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\n\nInner Exception: {ex.InnerException?.Message}");
            }
        */
        }   
    }

