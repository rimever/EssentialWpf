using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;

namespace Chapter6_14
{
    public class GetFileSystemInfosConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                if (value is DirectoryInfo)
                {
                    return ((DirectoryInfo) value).GetFileSystemInfos();
                }
            }
            catch
            {
                // ignore
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}