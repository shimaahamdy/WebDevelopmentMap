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
using System.Windows.Shapes;

namespace Day1
{
    /// <summary>
    /// Interaction logic for Paint.xaml
    /// </summary>
    public partial class Paint : Window
    {
        public Paint()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
           

            switch(((RadioButton) sender).Content.ToString())
            {
                case "red":
                    inkC.DefaultDrawingAttributes.Color = Colors.Red;
                    break;
                case "Green":
                    inkC.DefaultDrawingAttributes.Color = Colors.Green;
                    break;
                case "Blue":
                    inkC.DefaultDrawingAttributes.Color = Colors.Blue;
                    break;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
