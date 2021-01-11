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

namespace Exam_January_2021_s00199608
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Current CurrAccount = new Current("Jim", "Bob", 15000);
            Current CurrAccount1 = new Current("Thomas", "Riley", 8000);
            Saving CurrAccount2 = new Saving("Martha", "Steward", 1200);
            Saving CurrAccount3 = new Saving("Louis", "Lane", 22000);
        }
    }
}
