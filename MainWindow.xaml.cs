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

namespace Wpf_Lesson3._2
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

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CancelBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            cancel_image.Source = new BitmapImage(new Uri(@"Images\CancelMouseOn.png"));
        }

        private void CancelBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            cancel_image.Source = new BitmapImage(new Uri(@"Images\Cancel.png"));
        }
    }
}
