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
using System.Windows.Navigation;
using System.Windows.Shapes;
using md5_sql_hash;

namespace Sport_Lend
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
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
        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (Sport_LendEntities context = new Sport_LendEntities())
                {

                    var login = Login.Text;
                    var pass = md5.GetHash(password.Password);
                    var name = Name.Text;

                    var newClient = new Client
                    {
                        login = login,
                        pass = pass,
                        Name = name
                    };
                    context.Client.Add(newClient);

                    context.SaveChanges();
                    MessageBox.Show("Вы успешно зарегестрировались");
                    Input input = new Input();
                    input.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void Exit_Click_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
