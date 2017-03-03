/**
 * Author: Sri Hari Haran Seenivasan
 * Class: Administrator
 * Description: To handle the WPF page Administrator.xaml.
 */
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

namespace tollgatemanagement
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

        private void btnEmployee_Click(object sender, RoutedEventArgs e)
        {
            
            ShowPage((Window)(new Employee(this)));
        }

        private void btnAdministrator_Click(object sender, RoutedEventArgs e)
        {
            ShowPage(new Administrator(this));
        }
       
        public void ShowPage(Window O)
        {
            this.Hide();
            O.Show();
        }

        private void wndwStart_Loaded(object sender, RoutedEventArgs e)
        {

            tollgatemanagement.Database1DataSet database1DataSet = ((tollgatemanagement.Database1DataSet)(this.FindResource("database1DataSet")));
            // Load data into the table Employee. You can modify this code as needed.
            tollgatemanagement.Database1DataSetTableAdapters.EmployeeTableAdapter database1DataSetEmployeeTableAdapter = new tollgatemanagement.Database1DataSetTableAdapters.EmployeeTableAdapter();
            database1DataSetEmployeeTableAdapter.Fill(database1DataSet.Employee);
            System.Windows.Data.CollectionViewSource employeeViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("employeeViewSource")));
            employeeViewSource.View.MoveCurrentToFirst();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            tollgatemanagement.Database1DataSetTableAdapters.EmployeeTableAdapter database1DataSetEmployeeTableAdapter = new tollgatemanagement.Database1DataSetTableAdapters.EmployeeTableAdapter();
            tollgatemanagement.Database1DataSetTableAdapters.ProcCheckUserExistTableAdapter q = new tollgatemanagement.Database1DataSetTableAdapters.ProcCheckUserExistTableAdapter();
            
            Database1DataSet.ProcCheckUserExistDataTable t =  q.GetData(txtUserName.Text, txtPassword.Password);
            if ((t.Count == 1) && (t[0][0]!=null))
            {
                AppDetails.Create(Convert.ToInt32(t[0][0]), Convert.ToInt32(t[0][1]), Convert.ToBoolean(t[0][2]));
                if (AppDetails.isAdmin)
                    ShowPage(new Administrator(this));
                else
                    ShowPage(new Employee(this));
            }
            else
                MessageBox.Show("Please check your username or password and try again!","Wrong Username or Password");

        }
    }
}
