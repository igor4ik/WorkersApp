using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WorkerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Worker> worker;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            worker = new ObservableCollection<Worker>();
            lvWorkers.ItemsSource = worker;
        }

        //add new worker to collection
        private void Button_Add_Worker(object sender, RoutedEventArgs e)
        {
            if (!(txtAddName.Text).Equals(""))
            {
                worker.Add(new Worker() { Name = txtAddName.Text });
                txtAddName.Text = string.Empty;
            }
        }

        //remove woker by name
        private void Button_Remove_Worker(object sender, RoutedEventArgs e)
        {
            Worker needToRemove = new Worker() { Name = txtRemoveName.Text };//get worker name to remove from text box
            Boolean flag = true;
            if (!(txtRemoveName.Text).Equals("") && worker.Count > 0)//check if text box and list not empty
            {
                foreach (Worker workerItem in worker)
                {
                    if ((workerItem.Name).Equals(needToRemove.Name))//compare worker name with list of workers
                    {
                        worker.Remove(workerItem);
                        flag = false;//change flag value if worker exist
                        break;
                    }
                }
            }
            if (flag && !(txtRemoveName.Text).Equals(""))//error message if worker name not exist in list of workers
            {
                MessageBox.Show("Worker \"" + needToRemove.Name + "\" not exist !!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            txtRemoveName.Text = string.Empty;
        }

        //remove all workerss from Collection
        private void Button_Remove_All(object sender, RoutedEventArgs e)
        {
            if (worker.Count > 0)//check if worker list not empty
            {
                while (worker.Count > 0)
                {
                    worker.RemoveAt(worker.Count - 1);
                }
            }
        }
    }
}
