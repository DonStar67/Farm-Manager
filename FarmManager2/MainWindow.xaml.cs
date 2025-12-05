using Npgsql;
using System.Configuration;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FarmManager2
{
    public partial class MainWindow : Window
    {
        private const string ConnectionString =
              "Host=SQLstudv2;Port=5432;Database=postgres;Username=23ipp22;Password=23ipp22";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void TestConnection_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(ConnectionString))
                {
                    conn.Open(); // попытка открыть соединение

                    // Простой запрос, чтобы убедиться, что все работает
                    using (var cmd = new NpgsqlCommand("SELECT version();", conn))
                    {
                        var result = cmd.ExecuteScalar();
                        var version = cmd.ExecuteScalar()?.ToString();
                        OutputBox.Text = "Подключение успешно!\nВерсия сервера:\n" + version;
                    }
                }
            }
            catch (Exception ex)
            {
                OutputBox.Text = "Ошибка подключение:\n" + ex.Message;
            }
        }
    }
}