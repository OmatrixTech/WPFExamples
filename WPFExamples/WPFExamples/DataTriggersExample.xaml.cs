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

namespace WPFExamples
{
    /// <summary>
    /// Interaction logic for DataTriggersExample.xaml
    /// </summary>
    public partial class DataTriggersExample : Window
    {
        DataTriggerViewModel viewModel;
        public DataTriggersExample()
        {
            InitializeComponent();
            viewModel = this.DataContext as DataTriggerViewModel;
        }
    }
}
