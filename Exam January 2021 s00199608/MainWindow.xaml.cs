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
using System.Collections.ObjectModel;

namespace Exam_January_2021_s00199608
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Accounts> Account = new ObservableCollection<Accounts>();
        ObservableCollection<Accounts> SavingAccount = new ObservableCollection<Accounts>();
        ObservableCollection<Accounts> CurrentAccount = new ObservableCollection<Accounts>();
        public MainWindow()
        {
            InitializeComponent();
            Current CurrAccount = new Current(15000, "Bob", "Jim");
            Current CurrAccount1 = new Current(8000, "Riley", "Thomas");
            Saving SavAccount = new Saving(1200, "Steward", "Martha");
            Saving SavAccount1 = new Saving(22000, "Lane", "Louis");

            Account.Add(CurrAccount);
            Account.Add(CurrAccount1);
            Account.Add(SavAccount);
            Account.Add(SavAccount1);

            SavingAccount.Add(SavAccount);
            SavingAccount.Add(SavAccount1);
            CurrentAccount.Add(CurrAccount);
            CurrentAccount.Add(CurrAccount1);

            if (CurrentAcc.IsChecked == true && SavingAcc.IsChecked == true)
            {
                listBox.ItemsSource = Account;
            }
            if (CurrentAcc.IsChecked == true)
            {
                listBox.ItemsSource = CurrentAccount;
            }
            if (SavingAcc.IsChecked == true)
            {
                listBox.ItemsSource = SavingAccount;
            }
            else
            {
                listBox.ItemsSource = null;
            }
        }

        private void CurrentAcc_Checked(object sender, RoutedEventArgs e)
        {
            if (CurrentAcc.IsChecked == true && SavingAcc.IsChecked == true)
            {
                listBox.ItemsSource = Account;
            }
            if (CurrentAcc.IsChecked == true)
            {
                listBox.ItemsSource = CurrentAccount;
            }
            if (SavingAcc.IsChecked == true)
            {
                listBox.ItemsSource = SavingAccount;
            }
            else
            {
                listBox.ItemsSource = null;
            }
        }

        private void SavingAcc_Checked(object sender, RoutedEventArgs e)
        {
            if (CurrentAcc.IsChecked == true && SavingAcc.IsChecked == true)
            {
                listBox.ItemsSource = Account;
            }
            if (CurrentAcc.IsChecked == true)
            {
                listBox.ItemsSource = CurrentAccount;
            }
            if (SavingAcc.IsChecked == true)
            {
                listBox.ItemsSource = SavingAccount;
            }
            else
            {
                listBox.ItemsSource = null;
            }
        }

        private void CurrentAcc_Unchecked(object sender, RoutedEventArgs e)
        {
            if (CurrentAcc.IsChecked == true && SavingAcc.IsChecked == true)
            {
                listBox.ItemsSource = Account;
            }
            if (CurrentAcc.IsChecked == true)
            {
                listBox.ItemsSource = CurrentAccount;
            }
            if (SavingAcc.IsChecked == true)
            {
                listBox.ItemsSource = SavingAccount;
            }
            else
            {
                listBox.ItemsSource = null;
            }
        }

        private void SavingAcc_Unchecked(object sender, RoutedEventArgs e)
        {
            if (CurrentAcc.IsChecked == true && SavingAcc.IsChecked == true)
            {
                listBox.ItemsSource = Account;
            }
            if (CurrentAcc.IsChecked == true)
            {
                listBox.ItemsSource = CurrentAccount;
            }
            if (SavingAcc.IsChecked == true)
            {
                listBox.ItemsSource = SavingAccount;
            }
            else
            {
                listBox.ItemsSource = null;
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Accounts selectedAccount = listBox.SelectedItem as Accounts;

            if(selectedAccount != null)
            {
                firstName.Text = selectedAccount.fName;
                lastName.Text = selectedAccount.lName;
                balanceBlock.Text = selectedAccount.Balance.ToString();

                balanceBlock1.Text = selectedAccount.Balance.ToString();


            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
