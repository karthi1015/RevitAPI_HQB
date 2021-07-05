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
using MessageBox = System.Windows.Forms.MessageBox;

namespace AlphaBIM
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class Lesson3WPFWindow : Window
    {
        public Lesson3WPFViewModel viewModel;
        public Lesson3WPFWindow(Lesson3WPFViewModel viewModel)
        {
            this.viewModel = viewModel;
            InitializeComponent();

            DataContext = viewModel;

            List<string> ListcbBox;
            ListcbBox = new List<string>();
            for (int i = 0; i < 15; i++)
            {
                ListcbBox.Add("Nguyễn Văn " + i.ToString());
            }
            ComboBox.ItemsSource = ListcbBox;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            string txBox = viewModel.txtBox;
            viewModel.txtBlock = txBox;
        }

        private void Button_True(object sender, RoutedEventArgs e)
        {

        }

        public void Radio1_True(object sender, RoutedEventArgs e)
        {

        }

        private void Radio2_True(object sender, RoutedEventArgs e)
        {

        }
        
       
        
        private void CheckAndRadio(object sender, RoutedEventArgs e)
        {
            viewModel.LayGiaTriChecked();
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(ComboBox.SelectionBoxItem);
            
        }

       






    }
}
