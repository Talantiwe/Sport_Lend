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
    /// Логика взаимодействия для Zakaz.xaml
    /// </summary>
    public partial class Zakaz : Window
    {
        private int userId;
        private ObservableCollection<Bascket> basketItems = new ObservableCollection<Bascket>();
        public Zakaz(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            dataGrid.ItemsSource = basketItems;
            UpdateDataGrid();
            VivodSum();
            Closed += Zakaz_Closed;
        }
        private void Zakaz_Closed(object sender, EventArgs e)
        {
            // Обработка события закрытия окна Zakaz
            ClearBasket();
        }

        public class Sport_LendEntities : DbContext
        {
            public virtual DbSet<Bascket> Bascket { get; set; }
            public virtual DbSet<Zakazi> Zakazi { get; set; }
            public Sport_LendEntities() : base("Data Source=DESKTOP-JT2CST3;Initial Catalog=Sport_Lend;Integrated Security=True")
            {

            }
        }

        private void ClearBasket()
        {
            try
            {
                using (Sport_LendEntities context = new Sport_LendEntities())
                {
                    // Получаем все элементы корзины из базы данных
                    var basketItems = context.Bascket.ToList();

                    // Удаляем все элементы корзины из базы данных
                    context.Bascket.RemoveRange(basketItems);

                    // Сохраняем изменения в базе данных
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при очистке корзины: {ex.Message}");
            }
        }
        private void Zakaz_Oformlen_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                using (Sport_LendEntities context = new Sport_LendEntities())
                {
                    if (userId != 0) // Проверка, что Id пользователя не равен 0
                    {
                        decimal updatedSum = VivodSum();
                        Zakazi newOrder = new Zakazi
                        {
                            Id_Client = userId,
                            Sum = updatedSum
                           
                        };
                        context.Zakazi.Add(newOrder);
                        context.SaveChanges();

                        MessageBox.Show("Заказ оформлен");

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


        private void Back_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        public decimal VivodSum()
        {
            decimal totalSum = 0;
            decimal discountedSum = 0;

            // Проверяем, что ItemsSource не null и является ObservableCollection<Bascket>
            if (dataGrid.ItemsSource is ObservableCollection<Bascket> basketItems)
            {
                // Пройдемся по элементам в коллекции и сложим цены
                foreach (var item in basketItems)
                {
                    totalSum += item.Price;
                }

                decimal discount = 0;
                if (totalSum > 15000)
                {
                    discount = 0.1m; // 10% скидка
                }
                else if (totalSum > 10000)
                {
                    discount = 0.05m; // 5% скидка
                }

                // Рассчитываем сумму с учетом скидки
                discountedSum = totalSum - (totalSum * discount);
                sum_TextBlock.Text = $"Сумма: {totalSum}₽";

                if (discountedSum > 0)
                {
                    discount_TextBlock.Text = $"Итого с учётом скидки: {discountedSum:0.##}₽";
                }
                else
                {
                    discount_TextBlock.Text = $"Сумма без скидки: {totalSum}₽";
                }
            }

            // Возвращаем discountedSum
            return discountedSum;
        }
        public void UpdateDataGrid()
        {
            try
            {
                using (Sport_LendEntities context = new Sport_LendEntities())
                {
                    var basketItemsData = from item in context.Bascket
                                          select item;

                    basketItems.Clear();
                    foreach (var item in basketItemsData)
                    {
                        basketItems.Add(item);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при обновлении DataGrid: {ex.Message}");
            }
        }
        private void ClearBasket_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                using (Sport_LendEntities context = new Sport_LendEntities())
                {
                    // Получаем все элементы корзины из базы данных
                    var basketItems = context.Bascket.ToList();

                    // Удаляем все элементы корзины из базы данных
                    context.Bascket.RemoveRange(basketItems);

                    // Очищаем коллекцию basketItems
                    basketItems.Clear();

                    // Сохраняем изменения в базе данных
                    context.SaveChanges();

                    // Обновляем отображение суммы
                    VivodSum();

                    // Обновляем отображение данных в DataGrid
                    UpdateDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при очистке корзины: {ex.Message}");
            }
        }
    }
}
