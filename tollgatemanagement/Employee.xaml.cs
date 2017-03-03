/**
 * Author: Sri Hari Haran Seenivasan
 * Class: Employee
 * Description: To handle the WPF page Employee.xaml.
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
using System.Windows.Shapes;

namespace tollgatemanagement
{
    /// <summary>
    /// Interaction logic for Employee.xaml
    /// </summary>
    public partial class Employee : Window
    {
        private Window parent;
        public Employee(Window parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private tollgatemanagement.Database1DataSet getDatabaseDataSet => ((tollgatemanagement.Database1DataSet)(this.FindResource("database1DataSet")));
        private tollgatemanagement.Database1DataSetTableAdapters.PassReciptDetailsTableAdapter dsPassReciptDetailsTableAdapter = new tollgatemanagement.Database1DataSetTableAdapters.PassReciptDetailsTableAdapter();

        private void wndwCollector_Loaded(object sender, RoutedEventArgs e)
        {
            // Load data into the table PassReciptDetails. You can modify this code as needed.
            dsPassReciptDetailsTableAdapter.Fill(getDatabaseDataSet.PassReciptDetails);
            System.Windows.Data.CollectionViewSource passReciptDetailsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("passReciptDetailsViewSource")));
            passReciptDetailsViewSource.View.MoveCurrentToFirst();
            // Load data into the table TollArea. You can modify this code as needed.
            tollgatemanagement.Database1DataSetTableAdapters.TollAreaTableAdapter database1DataSetTollAreaTableAdapter = new tollgatemanagement.Database1DataSetTableAdapters.TollAreaTableAdapter();
            database1DataSetTollAreaTableAdapter.Fill(getDatabaseDataSet.TollArea);
            System.Windows.Data.CollectionViewSource tollAreaViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tollAreaViewSource")));
            tollAreaViewSource.View.MoveCurrentToFirst();
            // Load data into the table PassType. You can modify this code as needed.
            tollgatemanagement.Database1DataSetTableAdapters.PassTypeTableAdapter database1DataSetPassTypeTableAdapter = new tollgatemanagement.Database1DataSetTableAdapters.PassTypeTableAdapter();
            database1DataSetPassTypeTableAdapter.Fill(getDatabaseDataSet.PassType);
            System.Windows.Data.CollectionViewSource passTypeViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("passTypeViewSource")));
            passTypeViewSource.View.MoveCurrentToFirst();
            // Load data into the table VAPTable. You can modify this code as needed.
            tollgatemanagement.Database1DataSetTableAdapters.VAPTableTableAdapter database1DataSetVAPTableTableAdapter = new tollgatemanagement.Database1DataSetTableAdapters.VAPTableTableAdapter();
            database1DataSetVAPTableTableAdapter.Fill(getDatabaseDataSet.VAPTable);
            System.Windows.Data.CollectionViewSource vAPTableViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("vAPTableViewSource")));
            vAPTableViewSource.View.MoveCurrentToFirst();

            tollAreaComboBox.SelectedValue = AppDetails.postalCode;
            // Load data into the table VehicleType. You can modify this code as needed.
            tollgatemanagement.Database1DataSetTableAdapters.VehicleTypeTableAdapter database1DataSetVehicleTypeTableAdapter = new tollgatemanagement.Database1DataSetTableAdapters.VehicleTypeTableAdapter();
            database1DataSetVehicleTypeTableAdapter.Fill(getDatabaseDataSet.VehicleType);
            System.Windows.Data.CollectionViewSource vehicleTypeViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("vehicleTypeViewSource")));
            vehicleTypeViewSource.View.MoveCurrentToFirst();

            vehicleTypeComboBox.SelectionChanged += passTypeComboBox_SelectionChanged;
            
        }

        private void btnNxt_Click(object sender, RoutedEventArgs e)
        {
            tollgatemanagement.Database1DataSetTableAdapters.ProcPassReciptTableAdapter q = new tollgatemanagement.Database1DataSetTableAdapters.ProcPassReciptTableAdapter();
            Database1DataSet.ProcPassReciptDataTable t = q.GetData(Convert.ToInt32(vehicleTypeComboBox.SelectedValue), Convert.ToInt32(passTypeComboBox.SelectedValue) , Convert.ToInt32(tollAreaComboBox.SelectedValue),txtNumberPlate.Text, DateTime.Now, AppDetails.empId);
            dsPassReciptDetailsTableAdapter.Fill(getDatabaseDataSet.PassReciptDetails);
            passReciptDetailsDataGrid.UpdateLayout();
            txtNumberPlate.Text = "";
            txtPrice.Text = "";
        }

        private void passTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            setPrice();
        }
        private void setPrice() {
            string txtNumberPlateText = txtNumberPlate.Text;
            if (txtNumberPlateText != "")
            {
                tollgatemanagement.Database1DataSetTableAdapters.ProcCheckNumberPlateTableAdapter q = new tollgatemanagement.Database1DataSetTableAdapters.ProcCheckNumberPlateTableAdapter();

                Database1DataSet.ProcCheckNumberPlateDataTable t = q.GetData(txtNumberPlateText);
                if (t.Count>0)
                {
                    txtPrice.Text = "0";
                    return;
                }
                
            }
            tollgatemanagement.Database1DataSetTableAdapters.ProcGetPriceTableAdapter q1 = new tollgatemanagement.Database1DataSetTableAdapters.ProcGetPriceTableAdapter();
            if ((vehicleTypeComboBox.SelectedValue is null)||(passTypeComboBox.SelectedValue is null)|| (tollAreaComboBox.SelectedValue is null)) 
                return;
            
            Database1DataSet.ProcGetPriceDataTable t1 = q1.GetData(Convert.ToInt32(vehicleTypeComboBox.SelectedValue), Convert.ToInt32(passTypeComboBox.SelectedValue), Convert.ToInt32(tollAreaComboBox.SelectedValue));
            if  (t1[0][0] != null){
                txtPrice.Text = t1[0][0].ToString();
                return;
            }
            MessageBox.Show("There is no Fees Set for the Vehicle type in the area.","Error Retriving Price!");
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            AppDetails.Clear();
            parent.Show();
            this.Close();
        }

        private void txtPrice_GotFocus(object sender, RoutedEventArgs e)
        {
            setPrice();
        }
    }
}
