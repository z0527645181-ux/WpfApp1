using System;
using System.Collections.Generic;
using System.IO;
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


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Class1 c=new Class1();
        public MainWindow()
        {
            InitializeComponent();
        }

        private string GetExistPath(string txt)
        {
            string text= txt.Trim().Trim('"');
            if(string.IsNullOrEmpty(text)|| !Directory.Exists(text) )
            {
                return null;
            }
            return text;
        }
        
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] arr = File.ReadAllText("C:\\Users\\Documents\\14\\C#\\שיעור חמש\\products names (1).txt", Encoding.UTF8).Split(',');
               if (GetExistPath(txt.Text) != null)

                for (int i = 0; i < arr.Length; i++) 
                {
                    string path = Path.Combine(GetExistPath(txt.Text), arr[i] + ".txt");
                    File.Create(path).Close();
                }
        }

       
    }
}
