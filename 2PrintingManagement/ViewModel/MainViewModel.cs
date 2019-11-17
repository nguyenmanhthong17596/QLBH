using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _2PrintingManagement.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool isLoaded = false;
        // Xử lý mọi thứ trong này 
        public MainViewModel()
        {
            if (!isLoaded)
            {
                isLoaded = true;
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();
            }
        }
    }
}
