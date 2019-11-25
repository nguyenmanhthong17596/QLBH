using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _2PrintingManagement.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool isLoaded = false;
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand CustomerWindowCommand { get; set; }
        public ICommand ImageManagementWindowCommand { get; set; }
        public ICommand OutputWindowCommand { get; set; }
        public ICommand OutputManagementWindowCommand { get; set; }

        // Xử lý mọi thứ trong này 
        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                isLoaded = true;
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();
            }
            );

            // Xử lý di chuyển giữa các màn hình.
            CustomerWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) => { CustomerWindow window = new CustomerWindow(); window.ShowDialog(); } );
            ImageManagementWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) => { ImageManagementWindow window = new ImageManagementWindow(); window.ShowDialog(); } );
            OutputWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) => { OutputWindow window = new OutputWindow(); window.ShowDialog(); } );
            OutputManagementWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) => { ManageOutputWindow window = new ManageOutputWindow(); window.ShowDialog(); } );
        }
    }
}
