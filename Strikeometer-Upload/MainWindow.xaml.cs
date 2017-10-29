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

namespace Strikeometer_Upload
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {       
        private readonly List<UploadDetails> _uploadQueue = new List<UploadDetails>();

        public MainWindow()
        {
            InitializeComponent();

            UploadGrid.ItemsSource = _uploadQueue;
            UploadGrid.Columns.Add(new DataGridTextColumn
            {
                Header = "Touch Name",
                Binding = new Binding("TouchName")
            });
            UploadGrid.Columns.Add(new DataGridTextColumn
            {
                Header = "Touch URL",
                Binding = new Binding("TouchURL")
            });
        }

        private void AddFromComputer_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
