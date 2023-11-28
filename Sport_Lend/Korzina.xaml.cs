using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.AccessControl;
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
using System.Data.Entity;

namespace Sport_Lend
{
    /// <summary>
    /// Логика взаимодействия для Korzina.xaml
    /// </summary>
    public partial class Korzina : Window
    {

        private ObservableCollection<Bascket> basketItems = new ObservableCollection<Bascket>();
        public Korzina()
        {
            InitializeComponent();
            // loadkorzina();
            dataGrid.ItemsSource = basketItems;
            VivodSum();
            



        }
        public class Sport_LendEntities : DbContext
        {
            public virtual DbSet<Bascket> Bascket { get; set; }
            public virtual DbSet<Price> Price { get; set; }
            public Sport_LendEntities() : base("Data Source=DESKTOP-JT2CST3;Initial Catalog=Sport_Lend;Integrated Security=True")
            {

            }
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


        private void Back_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        public void VivodSum()
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
            }

            // Отобразим сумму в TextBlock
            sum_TextBlock.Text = $"Сумма: {totalSum}₽";
            discount_TextBlock.Text = $"Итого с учётом скидки: {discountedSum:0.##}₽";
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
       
        private void Zakaz_Click(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("Для заказа необходимо войти в систему");
            MessageBoxResult result = MessageBox.Show("Для заказа необходимо войти в систему.", "Предупреждение", MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                CloseAllOpenWindows();
                Input input = new Input();
                input.Show();
                this.Close();// Покажем окно входа
            }
            else
            {
                // Пользователь выбрал "Отмена"
                MessageBox.Show("Вы отменили вход. Для заказа необходимо войти в систему.");
            }
        }
        private void CloseAllOpenWindows()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window != this)
                {
                    window.Close();
                }
            }
        }

        private void NewZakaz_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Заказ добавлен");
        }
    }
}
    

