using System.Windows;

namespace ShopShoes123.Helprers
{
    public class MessageHelper
    {
        public void ShowInfo(string message)
        {
            MessageBox.Show(message,"Информаиця", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public void ShowWarning(string message)
        {
            MessageBox.Show(message, "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
