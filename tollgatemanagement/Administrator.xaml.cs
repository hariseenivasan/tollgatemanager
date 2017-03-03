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
    /// Interaction logic for Administrator.xaml
    /// </summary>
    public partial class Administrator : Window
    {
        private Window parent;
        public Administrator(Window parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private tollgatemanagement.Database1DataSet getDatabaseDataSet => ((tollgatemanagement.Database1DataSet)(this.FindResource("database1DataSet")));
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

             
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

            // Load data into the table TollPassDetails. You can modify this code as needed.
            tollgatemanagement.Database1DataSetTableAdapters.TollPassDetailsTableAdapter database1DataSetTollPassDetailsTableAdapter = new tollgatemanagement.Database1DataSetTableAdapters.TollPassDetailsTableAdapter();
            database1DataSetTollPassDetailsTableAdapter.Fill(getDatabaseDataSet.TollPassDetails);
            System.Windows.Data.CollectionViewSource tollPassDetailsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tollPassDetailsViewSource")));
            tollPassDetailsViewSource.View.MoveCurrentToFirst();
            // Load data into the table TollArea. You can modify this code as needed.
            tollgatemanagement.Database1DataSetTableAdapters.TollAreaTableAdapter database1DataSetTollAreaTableAdapter = new tollgatemanagement.Database1DataSetTableAdapters.TollAreaTableAdapter();
            database1DataSetTollAreaTableAdapter.Fill(getDatabaseDataSet.TollArea);
            System.Windows.Data.CollectionViewSource tollAreaViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tollAreaViewSource")));
            tollAreaViewSource.View.MoveCurrentToFirst();
            // Load data into the table PassReciptDetails. You can modify this code as needed.
            tollgatemanagement.Database1DataSetTableAdapters.PassReciptDetailsTableAdapter database1DataSetPassReciptDetailsTableAdapter = new tollgatemanagement.Database1DataSetTableAdapters.PassReciptDetailsTableAdapter();
            database1DataSetPassReciptDetailsTableAdapter.Fill(getDatabaseDataSet.PassReciptDetails);
            System.Windows.Data.CollectionViewSource passReciptDetailsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("passReciptDetailsViewSource")));
            passReciptDetailsViewSource.View.MoveCurrentToFirst();
            // Load data into the table Employee. You can modify this code as needed.
            tollgatemanagement.Database1DataSetTableAdapters.EmployeeTableAdapter database1DataSetEmployeeTableAdapter = new tollgatemanagement.Database1DataSetTableAdapters.EmployeeTableAdapter();
            database1DataSetEmployeeTableAdapter.Fill(getDatabaseDataSet.Employee);
            System.Windows.Data.CollectionViewSource employeeViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("employeeViewSource")));
            employeeViewSource.View.MoveCurrentToFirst();
            // Load data into the table VehicleType. You can modify this code as needed.
            tollgatemanagement.Database1DataSetTableAdapters.VehicleTypeTableAdapter database1DataSetVehicleTypeTableAdapter = new tollgatemanagement.Database1DataSetTableAdapters.VehicleTypeTableAdapter();
            database1DataSetVehicleTypeTableAdapter.Fill(getDatabaseDataSet.VehicleType);
            System.Windows.Data.CollectionViewSource vehicleTypeViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("vehicleTypeViewSource")));
            vehicleTypeViewSource.View.MoveCurrentToFirst();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tollgatemanagement.Database1DataSetTableAdapters.UpsertVAPTablePriceTableAdapter database1DataSetQueryAdapter = new tollgatemanagement.Database1DataSetTableAdapters.UpsertVAPTablePriceTableAdapter();
            Database1DataSet.UpsertVAPTablePriceDataTable t= database1DataSetQueryAdapter.GetData(Convert.ToInt32(vehicleTypeComboBox.SelectedValue), Convert.ToInt32(passTypeComboBox.SelectedValue), Convert.ToInt32(tollAreaComboBox.SelectedValue), Convert.ToInt32(priceTextBox.Text));

            if (t[0][0] != null)
            {
                tollgatemanagement.Database1DataSetTableAdapters.TollPassDetailsTableAdapter database1DataSetTollPassDetailsTableAdapter = new tollgatemanagement.Database1DataSetTableAdapters.TollPassDetailsTableAdapter();
                database1DataSetTollPassDetailsTableAdapter.Fill(getDatabaseDataSet.TollPassDetails);
                //System.Windows.Data.CollectionViewSource tollPassDetailsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tollPassDetailsViewSource")));
                //tollPassDetailsViewSource.View.MoveCurrentToFirst();
                tollAreaDataGrid.UpdateLayout();
            }
        }

        private void btnAddTollArea_Click(object sender, RoutedEventArgs e)
        {
            tollgatemanagement.Database1DataSetTableAdapters.TollAreaTableAdapter database1DataSetTollAreaAdapter = new tollgatemanagement.Database1DataSetTableAdapters.TollAreaTableAdapter();
            database1DataSetTollAreaAdapter.Insert(Convert.ToInt32(postalCodeTextBox.Text),localityTextBox.Text,cityTextBox.Text,stateTextBox.Text);
            database1DataSetTollAreaAdapter.Fill(getDatabaseDataSet.TollArea);
            tollAreaDataGrid.UpdateLayout();
        }

        private void tollAreaComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tollgatemanagement.Database1DataSetTableAdapters.PassReciptDetailsTableAdapter database1DataSetPassReciptDetailsTableAdapter = new tollgatemanagement.Database1DataSetTableAdapters.PassReciptDetailsTableAdapter();
            database1DataSetPassReciptDetailsTableAdapter.Fill(getDatabaseDataSet.PassReciptDetails);
            
            System.Windows.Data.CollectionViewSource passReciptDetailsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("passReciptDetailsViewSource")));
            //passReciptDetailsViewSource= string.Format("PostalCode='{0}'", tollAreaComboBox.SelectedValue.ToString());
            passReciptDetailsViewSource.View.MoveCurrentToFirst();
            
        }


        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            AppDetails.Clear();
            parent.Show();
            this.Close();
        }
    }
}
