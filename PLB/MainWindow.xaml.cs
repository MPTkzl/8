using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media.Imaging;
using serder;
using Microsoft.WindowsAPICodePack.Dialogs;
using Styles;

namespace PLB
{


    public partial class MainWindow : Window
    {
        List<msz> mszs = new List<msz>();
        List<ima> imas = new List<ima>();

        string filename;




        public MainWindow()
        {
            InitializeComponent();

            var kontent = serder1.Deserealize<List<msz>>();

            if (kontent != null)
            {
                foreach (var k in kontent)
                {
                    string path = k.Img;
                    string content = k.text;
                    ListText.Items.Add(new ima(content, path));
                    imas.Add(new ima(content, path));
                    mszs.Add(k);
                }
            }



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Text.Text != "" & filename != null)
            {
                msz l = new msz();
                l.text = Text.Text;
                l.Img = filename;
                mszs.Add(l);
                serder1.Serial(mszs);

                ima element = new ima(Text.Text, filename);
                ListText.Items.Add(element);

            }
            else
            {
                MessageBox.Show("Заполните поля");
            }
        }


        private void Kartinka_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            CommonFileDialogResult resylt = dialog.ShowDialog();
            var result = resylt == CommonFileDialogResult.Ok ? filename = dialog.FileName : null;
            Uri uri = new Uri(filename);
            if (image != null)
            {
                image.Source = new BitmapImage(uri);
                Lable.Content = Text.Text;
            }
        }

    }
}
