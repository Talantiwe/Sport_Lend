using System;
using System.Collections.Generic;
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
using md5_sql_hash;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Sport_Lend;
using System.Data.SqlClient;
using System.Data;

namespace Sport_Lend
{
    /// <summary>
    /// Логика взаимодействия для Input.xaml
    /// </summary>
    public partial class Input : Window
    {

            
        public Input()
        {
            InitializeComponent();
            
        }
        public class Sport_LendEntities : DbContext
        {
            public virtual DbSet<Client> Client { get; set; }
            public Sport_LendEntities() : base("Data Source=DESKTOP-JT2CST3;Initial Catalog=Sport_Lend;Integrated Security=True")
            {

            }
        }
        private void Exit_Click_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        private int userId;
        private void Inputt_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                // Создайте объект Sport_LendEntities
                using (Sport_LendEntities context = new Sport_LendEntities())
                {

                    string login = Login.Text;
                    string pass = md5.GetHash(password.Password);

                    var client = context.Client.SingleOrDefault(c => c.login == login && c.pass == pass);

                    if (login == "ad" && pass == "Ujr1N5RrecT4Np7Tm6eGBQ==")
                    {
                        MessageBox.Show("Вы успешно вошли, как администратор");
                        Admin admin = new Admin();
                        admin.Show();
                        this.Close();
                    }
                    else if (client != null)
                    {
                        MessageBox.Show($"Добро пожаловать: {client.Name}");
                        client.IsAuthorized = true;
                        userId = client.Id_Client;
                        if (Convert.ToBoolean(client.IsAuthorized))
                        {
                            // Пользователь авторизован, открывайте окно заказа товаров
                            Zakaz zakaz = new Zakaz(userId);
                            zakaz.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Пользователь не авторизован");
                            context.SaveChanges(); // Сохраняем изменения
                            MainWindow mainWindow = new MainWindow();
                            mainWindow.Show();

                            this.Close();
                        }
                       
                        
                    }
                    else
                    {
                        MessageBox.Show("Нету пользователя с такими учетными данными");
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

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Close();
        }
    }
}
