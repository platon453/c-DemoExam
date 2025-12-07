using System;
using System.Globalization;
using System.Windows.Data;

namespace ShopShoes123
{
    public class ImagePathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // value - это то, что приходит из базы (например, "1.jpg")
            string imageName = value as string;

            if (string.IsNullOrEmpty(imageName))
            {
                // Если имя файла пустое, используем заглушку
                imageName = "picture.png";
            }

            // Собираем полный Pack URI, который WPF точно поймет
            return $"pack://application:,,,/ShopShoes123;component/Res/{imageName}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Этот метод нам не нужен, оставляем его пустым
            throw new NotImplementedException();
        }
    }
}
