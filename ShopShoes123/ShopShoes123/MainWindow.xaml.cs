using ShopShoes123.Helprers;
using ShopShoes123.Statics;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace ShopShoes123
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private PROBNIKEntities _db = new PROBNIKEntities();
        private MessageHelper _mh = new MessageHelper(); 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new ProductWindow().Show();
            Close();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginEnter.Text;
            string password = PaswwordEnter.Password;

            var user = _db.Users.Where(u => u.Login == login && u.Password == password).FirstOrDefault();
            if (user == null)
            {
                _mh.ShowError("Введен не правильный логин или пароль");
                return;
            }
            else
            {
                CurrentSession.CurrentUser = user;
                new ProductWindow(user).Show();
                Close();
            }
        }
    }
}