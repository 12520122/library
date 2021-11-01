using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace QuanLyThuVien
{
    class ListTacGiaToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //throw new NotImplementedException();
            var listTacGia = value as List<TacGia>;
            StringBuilder str = new StringBuilder();
            if (listTacGia.Count>0)
            {
                str.Append(listTacGia[0].TenTacGia);
            }
            if (listTacGia.Count>1)
            {
                for (int i = 1; i < listTacGia.Count; i++)
                {
                    str.Append(", ").Append(listTacGia[i].TenTacGia);
                }
            }
            return str.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
            //return "xyzz";
        }
    }
}
