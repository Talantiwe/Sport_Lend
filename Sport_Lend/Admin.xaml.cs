using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sport_Lend
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public class Sport_LendEntities : DbContext
        {
            public virtual DbSet<Price> Price { get; set; }
            public Sport_LendEntities() : base("Data Source=DESKTOP-JT2CST3;Initial Catalog=Sport_Lend;Integrated Security=True")
            {

            }
        }
        private ObservableCollection<Price> priceItems = new ObservableCollection<Price>();
        public Admin()
        {
            InitializeComponent();
            dataGrid.ItemsSource = priceItems;
            UpdateDataGrid();
            dataGrid.CellEditEnding += DataGrid_CellEditEnding;
        }

        private void Back_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        public void UpdateDataGrid()
        {
            try
            {
                using (Sport_LendEntities context = new Sport_LendEntities())
                {
                    var priceItemsData = context.Price.ToList(); // Получаем все данные из таблицы Price

                    priceItems.Clear();
                    foreach (var item in priceItemsData)
                    {
                        priceItems.Add(new Price
                        {
                            Id_Price = item.Id_Price,
                            Name = item.Name,
                            Prices = item.Prices
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при обновлении DataGrid: {ex.Message}");
            }
        }

        private void Update_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                using (Sport_LendEntities context = new Sport_LendEntities())
                {
                    var priceItemsData = context.Price.ToList(); // Получаем все данные из таблицы Price

                    priceItems.Clear();
                    foreach (var item in priceItemsData)
                    {
                        priceItems.Add(new Price
                        {
                            Id_Price = item.Id_Price,
                            Name = item.Name,
                            Prices = item.Prices
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при обновлении DataGrid: {ex.Message}");
            }
        }
        private void DataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit)
            {
                DataGrid grid = (DataGrid)sender;
                var editedItem = grid.SelectedItem as Price;

                if (editedItem != null)
                {
                    // Получите новое значение из ячейки и обновите данные в базе данных
                    var editedColumn = e.Column as DataGridTextColumn;
                    if (editedColumn != null)
                    {
                        var textBox = e.EditingElement as TextBox;
                        if (textBox != null)
                        {
                            var newValue = textBox.Text;

                            // Обновите данные в базе данных, например, используя Entity Framework
                            using (Sport_LendEntities context = new Sport_LendEntities())
                            {
                                var priceToUpdate = context.Price.Find(editedItem.Id_Price);
                                if (priceToUpdate != null)
                                {
                                    // Обновите значение в соответствии с новым значением из ячейки
                                    priceToUpdate.Name = newValue;
                                    context.SaveChanges();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem is Price selectedPrice)
            {
                // Удалите объект из ObservableCollection
                priceItems.Remove(selectedPrice);

                // Удалите объект из базы данных
                using (Sport_LendEntities context = new Sport_LendEntities())
                {
                    var priceToDelete = context.Price.Find(selectedPrice.Id_Price);
                    if (priceToDelete != null)
                    {
                        context.Price.Remove(priceToDelete);
                        MessageBox.Show("Товар удален");
                        context.SaveChanges();
                    }
                }
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (Sport_LendEntities context = new Sport_LendEntities())
                {

                    var names = name.Text;
                    var sum = suma.Text;

                    var newPrice = new Price
                    {
                        Name = names,
                        Prices = Convert.ToDecimal(sum)
                        
                    };
                    context.Price.Add(newPrice);

                    context.SaveChanges();
                    MessageBox.Show("Товар добавлен");
                    name.Text = string.Empty;
                    suma.Text = string.Empty;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
