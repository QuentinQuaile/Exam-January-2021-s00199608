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

/*
 * Student Number: s00199608
 * Github Link: https://github.com/QuentinQuaile/Exam-January-2021-s00199608
 */
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
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;



            InitializeComponent();
            Current CurrAccount = new Current(15000, "Bob", "Jim", "Current",dateTime);
            Current CurrAccount1 = new Current(8000, "Riley", "Thomas","Current", dateTime);
            Saving SavAccount = new Saving(1200, "Steward", "Martha","Saving", dateTime);
            Saving SavAccount1 = new Saving(22000, "Lane", "Louis","Saving", dateTime);

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
            else if (CurrentAcc.IsChecked == true)
            {
                listBox.ItemsSource = CurrentAccount;
            }
            else if (SavingAcc.IsChecked == true)
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
            else if (CurrentAcc.IsChecked == true)
            {
                listBox.ItemsSource = CurrentAccount;
            }
            else if (SavingAcc.IsChecked == true)
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
            else if (CurrentAcc.IsChecked == true)
            {
                listBox.ItemsSource = CurrentAccount;
            }
            else if (SavingAcc.IsChecked == true)
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
            else  if (CurrentAcc.IsChecked == true)
            {
                listBox.ItemsSource = CurrentAccount;
            }
            else if (SavingAcc.IsChecked == true)
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
            else if (CurrentAcc.IsChecked == true)
            {
                listBox.ItemsSource = CurrentAccount;
            }
            else if (SavingAcc.IsChecked == true)
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
                accountBlock.Text = selectedAccount.Account;
                balanceBlock1.Text = selectedAccount.Balance.ToString();
                InterestBlock.Text = selectedAccount.InterestDate.ToString("d");


            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string Bob = Transaction.Text;
            
            decimal bob = decimal.Parse(Bob);
            Accounts selectedAccount = listBox.SelectedItem as Accounts;
            if (selectedAccount != null)
            {
                if (bob >= 0)
                {
                    decimal transaction = selectedAccount.Deposit(bob);
                    balanceBlock.Text = transaction.ToString();
                    balanceBlock1.Text = transaction.ToString();
                }
            }
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            string Bob = Transaction.Text;

            decimal bob = decimal.Parse(Bob);
            Accounts selectedAccount = listBox.SelectedItem as Accounts;
            if (selectedAccount != null)
            {
                decimal transaction = selectedAccount.Withdraw(bob);
                balanceBlock.Text = transaction.ToString();
                balanceBlock1.Text = transaction.ToString();
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Accounts selectedAccount = listBox.SelectedItem as Accounts;
            if (selectedAccount != null)
            {
                decimal interest = selectedAccount.CalculateInterest();
                balanceBlock.Text = interest.ToString();
                balanceBlock1.Text = interest.ToString();
            }
        }

        private void CurrentAcc_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentAcc.IsChecked == true && SavingAcc.IsChecked == true)
            {
                listBox.ItemsSource = Account;
            }
            else if (CurrentAcc.IsChecked == true)
            {
                listBox.ItemsSource = CurrentAccount;
            }
            else if (SavingAcc.IsChecked == true)
            {
                listBox.ItemsSource = SavingAccount;
            }
            else
            {
                listBox.ItemsSource = null;
            }
        }

        private void SavingAcc_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentAcc.IsChecked == true && SavingAcc.IsChecked == true)
            {
                listBox.ItemsSource = Account;
            }
            else if (CurrentAcc.IsChecked == true)
            {
                listBox.ItemsSource = CurrentAccount;
            }
            else if (SavingAcc.IsChecked == true)
            {
                listBox.ItemsSource = SavingAccount;
            }
            else
            {
                listBox.ItemsSource = null;
            }
        }
    }
}
