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
using System.Windows.Shapes;

namespace PracticeProject
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Win2 : Window
    {
        string text;
        private string _text;

        //private string line;

        public int Index { get; private set; }
        public object Value { get; }
        public Action<object, TextChangedEventArgs> SetValueForText1 { get; private set; }

        public Win2()
        {
            InitializeComponent();
            this.text = _text;
            
        }

      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            String Ttile = Console.ReadLine();
            
           
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            String Author = Console.ReadLine();
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            String Year = Console.ReadLine();
        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {
            String Genre = Console.ReadLine();
        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {
            String Director = Console.ReadLine();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


            
            var win2= new Win3();
            win2.Show();
            //this.myString = Value;
            this.Close(); 
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var win2 =  new Window1();
            win2. Show();
            this.Close();
        }
    }
}