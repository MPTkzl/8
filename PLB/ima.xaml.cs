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

namespace PLB
{
    /// <summary>
    /// Логика взаимодействия для Kartinki.xaml
    /// </summary>
    public partial class ima : UserControl
    {
        public ima(string text,string img)
        {
            InitializeComponent();
            LabelText.Content= text;
            Uri uri = new Uri(img);
            if (img != null)
            {
                Image.Source = new BitmapImage(uri);
            }
        }
    }
}
