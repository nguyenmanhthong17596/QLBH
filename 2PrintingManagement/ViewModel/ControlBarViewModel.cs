using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace _2PrintingManagement.ViewModel
{
    public class ControlBarViewModel : BaseViewModel
    {
        #region commands
        public ICommand  CloseWindowCommand { get; set; }
        #endregion

        public ControlBarViewModel()
        {
            CloseWindowCommand = new RelayCommand<UserControl>((p)=> { return p == null? false : true; },(p)=> { GetWindowParents(p); });
        }

        void GetWindowParents(UserControl p )
        {
            FrameworkElement t = p.Parent as FrameworkElement;

            FrameworkElement tt = t.Parent as FrameworkElement;
        }
    }
}
  