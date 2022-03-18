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

namespace tasks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowDate(object sender, RoutedEventArgs e)
        {
            string mess = "you have entered:\nFirstName: " + firstname.Text +
                "\nLastName: " + lastname.Text+
                "\nGender: "+gender.Text+
                "\nAddress: "+address.Text+
                "\nPhone: "+phone.Text+
                "\nMobile: "+mobile.Text+
                "\nEmail: "+email.Text+
                "\nJob Title: "+job.Text;
            if (MessageBox.Show(mess,"PersinalInfo", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                MessageBox.Show("data saved sucessfuly");  
            }

            
           
        }

        private void ClearDate(object sender, RoutedEventArgs e)
        {
            firstname.Clear();
            lastname.Clear();
            gender.Clear();
            address.Clear();
            phone.Clear();
            mobile.Clear();
            email.Clear();
            job.Clear();

        }
    }
}
